using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXBSplineSurface : IXBoundedSurface
    {
        int MaxDegree { get; }
        //double[] UKnots { get; }
        //double[] VKnots { get; }
    }

}
