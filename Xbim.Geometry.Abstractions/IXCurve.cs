using System;

namespace Xbim.Geometry.Abstractions
{
    public interface IXCurve
    {
        XCurveType CurveType { get; }
        bool Is3d { get; }
        double Length { get; }
        double FirstParameter { get; }
        double LastParameter { get; }
        /// <summary>
        /// Returns the point at parameter uParam, nb considers the parametric unit of the line
        /// </summary>
        /// <param name="uParam"></param>
        /// <returns></returns>
        IXPoint GetPoint(double uParam);
        /// <summary>
        /// Gets the point and the normal at the parameter uParam
        /// </summary>
        /// <param name="uParam"></param>
        /// <param name="normal">Normal at param uParam</param>
        /// <returns></returns>
        IXPoint GetFirstDerivative(double uParam, out IXVector normal);
    }
}
