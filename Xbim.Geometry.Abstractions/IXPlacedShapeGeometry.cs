namespace Xbim.Geometry.Abstractions
{
    public interface IXPlacedShapeGeometry
    {
        int AssemblyId { get; set; }
        IXLocation Location { get; set; }
        IXShapeGeometry Geometry { get; set; }
        IXShapeColour Colour { get; set; }
        IXShapeMaterialItem Material { get; set; }
        IXShape Shape { get; set; }
        public short ProductIfcType { get; set; }
        public short GeometryIfcType { get; set; }

    }
}
