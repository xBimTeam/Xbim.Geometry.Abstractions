using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXCurveFactory : IXModelScoped
    {
        IXCurve Build(IIfcCurve curve);
        IXCurve BuildDirectrix(IIfcCurve curve, double? startParam, double? endParam);
    }
}
