using System;
using System.Collections.Generic;
using System.Text;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXCurveService : IXModelScoped
    {
        IXCurve Build(IIfcCurve curve);
        IXCurve BuildDirectrix(IIfcCurve curve, double? startParam, double? endParam);
    }
}
