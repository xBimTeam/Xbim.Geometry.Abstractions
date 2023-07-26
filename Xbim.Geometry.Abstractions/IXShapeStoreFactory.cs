using Xbim.Common;

namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeStoreFactory 
    {
        IXShapeStore GetNew(IModel model);
        IXShapeStore Open(string storeName);
    }
}
