using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXProductShapeDocumentReader
    {
        IEnumerable<IXProductDefinitionShape> ProductShapes { get; }
    }
}
