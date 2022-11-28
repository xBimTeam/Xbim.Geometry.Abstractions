using Microsoft.Extensions.Logging;
using Xbim.Common;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXGeometryConverterFactory
    {

        /// <summary>
        /// Version 5 Geometry Engine for backward compatibility, now deprecated
        /// </summary>
        IXbimGeometryEngine CreateGeometryEngineV5(IModel model, ILoggerFactory loggerFactory);

        /// <summary>
        /// Creates a Root Service to access Geometry Factories that are scoped to the current Model
        /// </summary>
        IXModelGeometryService CreateModelGeometryService(IModel model, ILoggerFactory loggerFactory);

    }
}
