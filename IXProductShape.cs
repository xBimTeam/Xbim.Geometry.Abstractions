using System.Collections.Generic;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXProductShape
    {
        /// <summary>
        /// Shape of the product including any Openings or Projections (Nett shape)
        /// </summary>
        IXProductDefinitionShape ProductShapeDefinition { get; }
       
        IEnumerable<IXShape> Openings { get; }
        IEnumerable<IXShape> Projections { get; }
        
    }
}