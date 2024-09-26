namespace Xbim.Geometry.Abstractions
{
    public interface IXClothoid : IXSpiral
    {
        double ClothoidConstant { get; }
    }
}