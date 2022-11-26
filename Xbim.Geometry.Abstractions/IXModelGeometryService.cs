using Xbim.Common;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXModelGeometryService
    {
        /// <summary>
        /// The Ifc Model the services are scoped to
        /// </summary>
        IModel Model { get; set; }
        /// <summary>
        /// Version 5 Geometry Engine for backward compatibility, now deprecated
        /// </summary>
        IXbimGeometryEngine GeometryEngineV5 { get;}

        /// <summary>
        /// Root Service to access Geometry Factories that are scoped to the current Model
        /// </summary>
        IXModelService ModelService { get;}

    }
}
