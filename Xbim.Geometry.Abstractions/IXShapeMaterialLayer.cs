namespace Xbim.Geometry.Abstractions
{
    public  interface IXShapeMaterialLayer : IXShapeMaterialItem
    {
        //string Name { get; set; }
        double Thickness { get; set; }
        IXShapeMaterial Material { get; set; }
        int Priority_ { get; set; }
        bool IsVentilated { get; set; }
    }
}
