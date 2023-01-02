namespace Xbim.Geometry.Abstractions
{
    public enum NodeType : byte
    {
        Product = 0,
        ProductRepresentation = 1,
        ShapeRepresentation = 2,
        BRepShape = 3,
        FeatureElement = 4,
        Colour = 5,
        BRepShapeWithFeatures = 6,
        LayeredMaterial = 7,
        Material = 8,
        MaterialConstituent = 9
    }
}
