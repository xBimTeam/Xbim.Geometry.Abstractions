﻿namespace Xbim.Geometry.Abstractions
{
    public interface IXSurface
    {
        XSurfaceType SurfaceType { get; }
        bool IsPeriodic { get; }
    }
}
