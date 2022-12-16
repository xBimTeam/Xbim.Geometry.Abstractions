using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    /// <summary>
    /// Represents a component with a location
    /// </summary>
    public interface IXShapeInstance
    {
        IXShapeComponent Component { get; set; }
        IXLocation Location { get; set; }
        IXMatrix Transformation { get; set; }
    }
}
