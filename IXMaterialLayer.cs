using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXMaterialLayer
    {
        string Name { get; set; }
        double Thickness { get; set; }
    }
}
