namespace Xbim.Geometry.Abstractions
{
    public interface IXTrimmedCurve : IXCurve
    {
        IXCurve BasisCurve { get; }
        IXPoint StartPoint { get; } 
        IXPoint EndPoint { get; }

    }
}
