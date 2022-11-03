namespace Xbim.Geometry.Abstractions
{
    public enum NodeType : byte
    {
        IfcProduct = 0,
        IfcProductRepresentation = 1,
        IfcShapeRepresentation = 2,
        BRepShape=3,
        IfcFeatureElement = 4, 
        IfcColour = 5,
        BRepShapeWithFeatures = 6
    }
}
