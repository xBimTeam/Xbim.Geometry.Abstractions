using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXTrimmedCurve : IXCurve
    {
        IXCurve BasisCurve { get; }
        IXPoint StartPoint { get; } 
        IXPoint EndPoint { get; }

    }
}
