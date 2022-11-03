using System.Collections.Generic;

namespace Xbim.Geometry.Abstractions
{
    public interface IXWire: IXShape
    {
        //Length in default model units, use IXGeometryPropertyService to get lengths in a specific imperial or metric unit system
        double Length { get; }
        //Area of the wire in default model units, e IXGeometryPropertyService to get lengths in a specific imperial or metric unit system
        double Area { get; }
        IEnumerable<IXEdge> EdgeLoop { get; }
        
    }
}
