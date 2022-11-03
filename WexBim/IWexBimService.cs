namespace Xbim.Geometry.Abstractions.WexBim
{
    public interface IWexBimService
    {
        IWexBimContent Create(IXShapeStore shapeStore, MeshGranularity granularity);
    }
}
