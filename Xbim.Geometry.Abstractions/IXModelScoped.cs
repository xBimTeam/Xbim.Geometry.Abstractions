namespace Xbim.Geometry.Abstractions
{
    public interface IXModelScoped
    {      
        IXModelService ModelService { get; }
        IXLoggingService LoggingService { get; }
    }
}
