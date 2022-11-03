using System;
using System.Collections.Generic;
using System.Text;
using Xbim.Common.Geometry;

namespace Xbim.Geometry.Abstractions.WexBim
{
    /// <summary>
    /// The content of a WexBim stream or file
    /// </summary>
    public interface IWexBimContent
    {
        IWexBimHeader Header { get; }
        IEnumerable<IWexBimProduct> Products { get; }
        IList<IWexBimRegion> Regions { get; }
        IList<IWexBimStyle> Styles { get; }

        void AddProduct(IWexBimProduct product);
        void AddRegion(IWexBimRegion region);
        void AddStyle(IWexBimStyle style);
        void TransformProductBBoxes(XbimMatrix3D transform);
        void UpdateHeader();
        void WriteToStream(System.IO.BinaryWriter writer);
    }
}
