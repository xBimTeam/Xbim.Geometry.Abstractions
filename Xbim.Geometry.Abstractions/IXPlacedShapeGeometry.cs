using Xbim.Common.Geometry;

namespace Xbim.Geometry.Abstractions
{
    public interface IXPlacedShapeGeometry
    {
        int AssemblyId { get; set; }
        IXLocation Location { get; set; }
        IXShapeGeometry Geometry { get; set; }
        IXShapeColour Colour { get; set; }
        IXShapeMaterial Material { get; set; }
        IXMatrix Transformation { get; set; }
    }
}
