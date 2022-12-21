using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xbim.Common;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXProductsShapeStore : IXModelScoped, IDisposable
    {
    
        IXBRepDocumentItem FeaturesNode { get; }
        bool StoreFeatures { get; set; }
        void Initialise(IModel model);
        IXGeometryEngineV6 GeometryEngine { get; }    
        IXBRepDocument Document { get; }
        IXProductShape AddProduct(IIfcProduct product);
        int AddProducts<TProduct>(Func<TProduct, bool> whereRule) where TProduct:IIfcProduct;
        Task<byte[]> GetBytesAsync();
        byte[] GetBytes();
        FileInfo SaveAs(string fileName);
        //saves contents to a temporary file and returns the file name, null if operation fails
        FileInfo SaveToTemporaryFile();
        void Open(string path);
        void UpdateAssemblies();
        IXProductDefinitionShape AddProductDefinition(IIfcProduct product);
        ISet<IIfcGeometricRepresentationContext> RequiredGeometricRepresentationContexts { get; set; }
        IDictionary<int, IXBRepDocumentItem> ShapeRepresentationsMap { get; }
        IDictionary<int, IXGeometricRepresentation> GeometricRepresentationItemsMap { get; }
        IDictionary<int, IXVisualMaterial> MaterialsMap { get; }
        IXBRepDocument Features { get; }

        void AssignMaterial(IXBRepDocumentItem subShape, IXVisualMaterial material);
        IXVisualMaterial GetVisualMaterial(IIfcGeometricRepresentationItem repItem);
        IXVisualMaterial GetVisualMaterial(IIfcProduct product);
        IXVisualMaterial GetVisualMaterial(IIfcMaterial material);
        IIfcMaterialSelect GetPhysicalMaterial(IIfcProduct product);
        IXVisualMaterial[] GetFirstAndLastVisualMaterial(IIfcMaterialSelect material);
        void Remove(IXBRepDocumentItem item);
        IList<IXMaterialQuantity> MaterialTakeOff();
        IEnumerable<IXProductDefinitionShape> ProductDefinitionShapes { get; }
        XbimMultiValueDictionary<int, int> OpeningsLookup { get; }
        XbimMultiValueDictionary<int, int> ProjectionsLookup { get; }
        bool SaveAsWexbim(string path, MeshGranularity meshGranularity = MeshGranularity.Normal);
        /// <summary>
        /// Returns an empty copy of the store but retaining all cached Ifc data
        /// This allows for the creation of new stores on the same model in a performant manner
        /// as the ifc entity caches do not have to be rebuilt
        /// </summary>
        /// <returns></returns>
        IXProductsShapeStore EmptyCopy();
        bool TryGetRepresentation(int entityLabel, out IXBRepDocumentItem repNode);
        bool TryAddRepresentation(int entityLabel, IXBRepDocumentItem shapeRepresentationNode);
        bool TryGetGeometryItem(int entityLabel, out IXGeometricRepresentation geomItemNode);
        bool TryAddGeometryItem(int entityLabel, IXGeometricRepresentation geomItemNode);
        /// <summary>
        /// Adds a shape to the Geometry Item cache, the item is not yet added to the physical store
        /// NB. This method is thread safe
        /// </summary>
        /// <returns></returns>
        IXGeometricRepresentation TryAddGeometryItem(int entityLabel, IXShape shape);

    }
}
