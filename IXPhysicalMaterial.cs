using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXPhysicalMaterial
    {
        string Name { get; set; }
        string Description { get;  }
        /// <summary>
        /// Optional thickness if the material is in a layered form, null if homogenous
        /// </summary>
        double? Thickness { get; set; }
    }
}
