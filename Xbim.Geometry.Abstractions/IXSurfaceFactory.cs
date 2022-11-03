using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface  IXSurfaceFactory:IXModelScoped
    {
        IXPlane BuildPlane(IXPoint origin, IXDirection normal);
    }
}
