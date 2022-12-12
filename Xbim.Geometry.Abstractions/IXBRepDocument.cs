using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXBRepDocument : IDisposable
    {
        /// <summary>
        /// Create a top level assembly and initialises its shape to an empty IXCompound
        /// </summary>
        /// <param name="name">name of assembly</param>
        /// <returns></returns>
        IXStorageItem CreateAssembly(string name);
        /// <summary>
        /// Creates a top level assembly and initialises its shape to assemblyShape
        /// </summary>
        /// <param name="name">name of assembly</param>
        /// <param name="assemblyShape">initial shape state</param>
        /// <returns></returns>
        IXStorageItem CreateAssembly(string name, IXShape assemblyShape);
        bool RemoveAssembly(IXStorageItem item);
        
        /// <summary>
        /// Adds a shape to the document root, this shape may be shared or referred to by other shapes in the document
        /// </summary>
        /// <param name="id">Typically the entity label of the Ifc representation</param>
        /// <param name="shape"></param>
        /// <returns></returns>
        IXStorageItem AddShape(int id, IXShape shape);
        /// <summary>
        /// Gets a shape by its id stored in the root of the document
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Shape or Null if the shape does not exists</returns>
        IXShape GetShape(int id);



        bool ExportGltf(string path, bool asBinary = true);
        bool ExportSTEP(string path);

        //IEnumerable<IXStorageItem> FreeShapes { get; }
        IEnumerable<IXStorageItem> Shapes { get; }
        IXStorageItem RootItem { get; }

        void UpdateAssemblies();
        /// <summary>
        /// Exports the document to a webim format, level of triangulation detail is set by mesh factors, see SetGranularity method of IXMeshFactors
        /// </summary>
        /// <param name="path"></param>
        /// <param name="defaultColour"></param>
        /// <param name="meshGranularity"></param>
        /// <returns></returns>
        //bool ExportWexbim(string path, IXColourRGB defaultColour, MeshGranularity meshGranularity = MeshGranularity.Normal);
        //byte[] ExportWexbim(IXColourRGB defaultColour, MeshGranularity meshGranularity = MeshGranularity.Normal);

        double? ConversionFactorForOneMeter { get; set; }
        double? PrecisionFactor { get; set; }
    }
}
