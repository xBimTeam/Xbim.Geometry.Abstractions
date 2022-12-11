namespace Xbim.Geometry.Abstractions
{
    public interface IXRectangleTrimmedSurface : IXBoundedSurface
    {
        IXSurface BasisSurface { get; }
        double U1 { get; }
        double U2 { get; }
        double V1 { get; }
        double V2 { get; }
        bool USense { get; }
        bool VSense { get; }
        bool IsPeriodic { get; }
    }
}
