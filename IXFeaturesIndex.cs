using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXFeaturesIndex
    {
        bool TryGetOpenings(int productId, out ICollection<int> openingsIds);
        bool TryGetProjections(int productId, out ICollection<int> projectionsIds);
    }
}
