using System;
using System.Collections.Generic;
using System.Text;
using Xbim.Ifc2x3.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface  IXSurfaceFactory:IXModelScoped
    {
        IXSurface Build(IIfcSurface surface);
        IXPlane BuildPlane(IXPoint origin, IXDirection normal);
    }
}
