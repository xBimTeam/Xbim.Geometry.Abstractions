using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    /// <summary>
    /// Represents a geometric shape with material
    /// </summary>
    public interface IXShapeGeometry : IXShapeComponent
    {
        IXShape GetShape(IXShapeStore store);
        ShapeGeometryErrorOrWarning ErrorOrWarnings { get; set; }

    }
}
