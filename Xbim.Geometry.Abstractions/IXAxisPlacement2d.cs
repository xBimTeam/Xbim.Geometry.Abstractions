
namespace Xbim.Geometry.Abstractions
{
    public interface IXAxisPlacement2d : IXAxisPlacement
    {
        IXPoint Location { get; }
        IXDirection Direction { get; }
        IXDirection YDirection { get; }
    }
}
