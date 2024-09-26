using System.Collections.Generic;

namespace Xbim.Geometry.Abstractions
{
    public interface IXPolynomialCurve : IXCurve
    {
        IXAxisPlacement Position { get; }
        List<double> CoefficientsX { get; }
        List<double> CoefficientsY { get; }
        List<double> CoefficientsZ { get; }
    }
}