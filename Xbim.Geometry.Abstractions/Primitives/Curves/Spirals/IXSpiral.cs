namespace Xbim.Geometry.Abstractions
{
    public interface IXSpiral : IXCurve
    {
        IXAxis2Placement3d Position { get; }
    }
}