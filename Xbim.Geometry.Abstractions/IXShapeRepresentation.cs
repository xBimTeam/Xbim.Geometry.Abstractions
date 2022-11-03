using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeRepresentation
    {
        IEnumerable<IXGeometricRepresentation> Shapes { get; }
        IXVisualMaterial Material { get; }
    }
}
