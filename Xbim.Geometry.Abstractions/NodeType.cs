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
        MaterialList,
        MaterialConstituent,
        LayeredMaterialInstance,
        MaterialLayer,
        ProductGroup, //IFC Assembly or IFC Group
        BRepShapePart, //Part of a shape, normally of a different colour or texture
        BRepShapeNonUniformTransformed //shape that has undergoen a nin uniform transformation (stretch)
    }
}
