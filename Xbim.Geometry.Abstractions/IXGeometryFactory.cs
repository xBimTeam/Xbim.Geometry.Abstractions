using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXGeometryFactory : IXModelScoped
    {
        IXAxis2Placement2d GetAxis2Placement2d(IXPoint location, IXVector XaxisDirection);
        bool IsFacingAwayFrom(IXFace face, IXDirection direction);
        IXPlane BuildPlane(IIfcPlane plane);
        double Distance(IXPoint a, IXPoint b);
        double IsEqual(IXPoint a, IXPoint b, double tolerance);
        IXDirection NormalAt(IXFace face, IXPoint position, double tolerance);
        IXPoint BuildPoint(double x, double y, double z);
        IXDirection BuildDirection(double x, double y, double z);
        IXVisualMaterial BuildVisualMaterial(string name, IIfcSurfaceStyleElementSelect styling);
        IXVisualMaterial BuildVisualMaterial(string name);
        IXColourRGB BuildColourRGB(double red, double green, double blue);
        IXShapeColour BuildShapeColour(string name, IIfcSurfaceStyleElementSelect surfaceStyle);
        IXLocation BuildLocation(double tx, double ty, double tz, double sc, double qw, double qx, double qy, double qz);
    }
}
