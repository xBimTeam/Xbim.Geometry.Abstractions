namespace Xbim.Geometry.Abstractions
{
    public interface IXModelScoped
    {      
        IXModelGeometryService ModelService { get; }
        IXLoggingService LoggingService { get; }
    }
}
