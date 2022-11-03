using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXColourRGB : IEqualityComparer<IXColourRGB>, IEquatable<IXColourRGB>
    {
        double Red { get; }
        double Green { get;  }
        double Blue { get; }
        
    }
}
