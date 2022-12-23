using System.Collections.Generic;

namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeLayeredMaterial : IXShapeItem
    {
        IList<IXShapeMaterial> MaterialList { get; }
        IXDirection LayerSetDirection { get; }
        bool IsReversed { get; }
    }
}
