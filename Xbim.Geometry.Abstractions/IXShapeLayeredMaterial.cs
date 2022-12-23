using System.Collections.Generic;

namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeLayeredMaterial : IXShapeItem
    {
        IList<IXShapeMaterialLayer> MaterialLayerList { get; }
        IXDirection LayerSetDirection { get; }
        bool IsReversed { get; }
    }
}
