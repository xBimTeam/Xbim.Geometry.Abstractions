namespace Xbim.Geometry.Abstractions
{
    public  interface IXShapeMaterialLayer
    {
        double Thicknesss { get; set; }
        IXShapeMaterial Material { get; set; }
    }
}
