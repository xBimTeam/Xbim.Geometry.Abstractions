namespace Xbim.Geometry.Abstractions
{
    public interface IXVertexFactory
    {
        IXVertex Build(double x, double y, double z = 0);
        bool IsEqual(IXVertex other, double tolerance);
    }
}
