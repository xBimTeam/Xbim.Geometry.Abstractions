using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeStore : IDisposable
    {
        ISet<int> RequiredContextIds { get; set; }
        /// <summary>
        /// Returns all assemblies
        /// </summary>
        IEnumerable<IXShapeAssembly> Assemblies { get; }

        IEnumerable<IXShapeGeometry> Geometries { get; }
        IEnumerable<IXShapeColour> Colours { get; }
        IEnumerable<IXShapeMaterialItem> Materials { get; }

        /// <summary>
        /// Saves all state and returns the fully qualified name of the store database
        /// </summary>
        /// <returns></returns>
        string Save(string saveAsName = null);

        /// <summary>
        /// Creates a new assembly in the store using the assemblyPrototype definition
        /// </summary>
        /// <param name="assemblyPrototype"> a transient assemby that holds the definition of all the parts and materials in the assembly. NB thse must have been created already in the store</param>

        /// <returns>true is a new element has been created</returns>
        bool TryAddAssembly(IXShapeAssembly assemblyPrototype);


        /// <summary>
        /// Creates a new part in the store using the geometryPrototype definition. If the part already exists it is not replaced, existing value is returned
        /// </summary>
        /// <param name="geometryPrototype"> a transient part that holds the definition of all the shapes and materials in the geometry. NB thse must have been created already in the store</param>

        /// <returns>true is a new element has been created</returns>
        bool TryAddGeometry(IXShapeGeometry geometryPrototype);
        /// <summary>
        /// Adds a featured shape to the geometry collection, a unique id is automatically generated for the geometry shape
        /// </summary>
        /// <param name="featuredShape"></param>
        /// <param name="ifcType"></param>
        /// <param name="toAssembly"></param>
        /// <returns></returns>
        IXShapeGeometry AddNewFeaturedGeometry(IXShape featuredShape, short ifcType, IXShapeAssembly toAssembly);
        /// <summary>
        /// Creates a new part in the store using the colourPrototype definition. If the material already exists it is not replaced, existing value is returned
        /// </summary>
        /// <param name="colourPrototype"> a transient part that holds the definition of the material. NB thse must have been created already in the store</param>
        /// <returns>true is a new element has been created</returns>
        bool TryAddColour(IXShapeColour colourPrototype);

        bool TryAddMaterial(IXShapeMaterialItem materialPrototype);

        bool TryGetAssembly(int id, out IXShapeAssembly shapeAssembly);

        bool TryGetGeometry(int id, out IXShapeGeometry shapeGeometry);


        bool TryGetColour(int id, out IXShapeColour shapeColour);
        bool TryGetMaterial(int id, out IXShapeMaterialItem shapeMaterial);
        /// <summary>
        /// Adds a reference between parent and child  with a location , the child could be another assembly or a geometry
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        IXShapeInstance AddReference(IXShapeAssembly parent, IXShapeComponent child, IXLocation location = null, IXMatrix transform = null, IXShapeMaterialItem material = null, IXShapeColour colour=null);

        /// <summary>
        /// Returns a list of shapes with their locations for the specified assembly, if assembly is null all located shapes are returned in the store
        /// </summary>
        /// <param name="assemblies">if null all root assemblies are parsed</param>
        /// <returns></returns>
        IXShapeOccurrenceList ShapeOccurences(IEnumerable<IXShapeAssembly> assemblies = null);

        IXShapeOccurrenceList ShapeOccurences(IXShapeAssembly assembly);
        bool TryRemove(IXShapeGeometry productBodyShape);

        IEnumerable<IXPlacedShapeGeometry> PlacedShapeGeometries();
        void StoreShape(IXShapeGeometry shapeGeometry, IXShape shape);
        IXShape RetrieveShape(IXShapeGeometry shapeGeometry);
    }
}
