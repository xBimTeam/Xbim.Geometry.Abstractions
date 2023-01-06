namespace Xbim.Geometry.Abstractions
{
    public enum NodeType : byte
    {
        Default = 0,
        Product,
        ProductRepresentation,
        ShapeRepresentation,
        BRepShape,
        FeatureElement,
        Colour,
        BRepShapeWithFeatures,
        LayeredMaterial,
        Material,
        MaterialConstituent
    }
}
