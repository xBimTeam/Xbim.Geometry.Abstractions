namespace Xbim.Geometry.Abstractions
{
    public interface IXWexBimMeshFactory : IXModelScoped
    {
        byte[] CreateWexBimMesh(IXShape shape, out IXAxisAlignedBoundingBox bounds);

        byte[] CreateWexBimMesh(IXShape shape, out IXAxisAlignedBoundingBox bounds, out bool hasCurves);
    }
}
