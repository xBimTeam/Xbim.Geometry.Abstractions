using Xbim.Common.Geometry;

namespace Xbim.Geometry.Abstractions
{
    public interface IXPlacedShapeGeometry
    {
              
        IXLocation Location { get; set; }
        IXShapeGeometry Geometry { get; set; }
        IXShapeColour Colour { get; set; }
    }
}
