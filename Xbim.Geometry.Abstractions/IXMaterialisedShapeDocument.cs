using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    public interface IXMaterialisedShapeDocument : IDisposable
    {
        IXShape Shape { get; }
        IEnumerable<IXShape> SubShapes { get; }

        /// <summary>
        /// Sets the material of a sub shape of the main shape (i.e. the face of a shell may be a different colour to the entire shell)
        /// </summary>
        /// <param name="part"></param>
        /// <param name="material"></param>
        void SetVisualMaterial(IXShape part, IXVisualMaterial material);
        IXVisualMaterial GetVisualMaterial(IXShape shape);
        IEnumerable<IXVisualMaterial> VisualMaterials { get; }
        byte[] ToArray();
        /// <summary>
        /// Retruns a WexBIm byte array, the shape will be triangulate
        /// </summary>
        /// <param name="meshFactors">Linear and angular defelction, as well as the number of model units in a meter</param>
        /// <param name="cleanBefore">if true removes any existing triangulation and overwrites with new mesh factors</param>
        /// <param name="cleanAfter">After creating the wexbim, any mesh data is removed</param>
        /// <returns></returns>
        byte[] ToWexBim(IXMeshFactors meshFactors, bool cleanBefore = false, bool cleanAfter = false);
    }
}
