namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeStoreFactory 
    {
        IXShapeStore GetNew();
        IXShapeStore Open(string storeName);
    }
}
