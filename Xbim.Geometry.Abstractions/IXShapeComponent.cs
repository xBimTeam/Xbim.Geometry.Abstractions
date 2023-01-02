using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    /// <summary>
    /// Effectively Abstract interface for an IXShapeAssembly or IXShapeGeometry
    /// </summary>
    public  interface IXShapeComponent : IXShapeItem
    {
        Type IfcType { get; set; }
    }
}
