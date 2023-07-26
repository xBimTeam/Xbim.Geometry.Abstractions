using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{

    public interface IXShapeProcessorService
    {


        /// <summary>
        /// Processes all products in the filter and creates an IXShapeStore.
        /// </summary>
        /// <param name="ifcDbFileName">Name of the IfcDb file containing the model, nb. this is not an Ifc STEP file. </param>
        /// <param name="outputFileName">If specified, Name of newly created IXShapeStore file, otherwise name of the temporary file holding the store</param>
        /// <param name="maxDegreeOfParallelism">how many thread to launcg, default is 2</param>
        /// <param name="productFilter">the filter of ifc products to add into the store</param>
        /// <returns>true if the operation was successful. It is the responsibility of the calling function to delete any unwanted databases created</returns>
        Task CreateShapeStoreAsync(string ifcDbFileName, string outputFileName = null, int maxDegreeOfParallelism = 2, Func<IIfcProduct, bool> productFilter = null, MeshGranularity granularity = MeshGranularity.Normal);

        IXShapeStore OpenShapeStore(string shapeStoreFileName);

    }
}
