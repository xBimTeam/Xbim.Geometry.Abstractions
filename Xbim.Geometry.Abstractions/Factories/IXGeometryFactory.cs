using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXGeometryFactory : IXModelScoped
    {
        IXAxis2Placement2d BuildAxis2Placement2d(IXPoint location, IXVector XaxisDirection);
        IXAxis2Placement3d BuildAxis2Placement3d(IXPoint location, IXVector XaxisDirection, IXVector ZaxisDirection);
        IXAxis2Placement2d BuildAxis2Placement2d(IXPoint location, IXDirection XaxisDirection);
        IXAxis2Placement3d BuildAxis2Placement3d(IXPoint location, IXDirection XaxisDirection, IXDirection ZaxisDirection);
        bool IsFacingAwayFrom(IXFace face, IXDirection direction);
        IXPlane BuildPlane(IIfcPlane plane);
        double Distance(IXPoint a, IXPoint b);
        double IsEqual(IXPoint a, IXPoint b, double tolerance);
        IXDirection NormalAt(IXFace face, IXPoint position, double tolerance);
        IXPoint BuildPoint3d(double x, double y, double z);
        IXPoint BuildPoint2d(double x, double y);
        IXDirection BuildDirection3d(double x, double y, double z);
        IXDirection BuildDirection2d(double x, double y);
        IXLocation BuildLocation(IIfcObjectPlacement placement);
        IXLocation BuildLocation(IIfcAxis2Placement placement);
        IXMatrix BuildTransform(IIfcCartesianTransformationOperator tranformOp);
        void BuildMapTransform(IIfcCartesianTransformationOperator transform, IIfcAxis2Placement origin, out IXLocation location, out IXMatrix matrix);
    }
}
