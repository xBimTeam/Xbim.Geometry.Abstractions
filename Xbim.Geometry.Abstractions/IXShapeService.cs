﻿using System.Collections.Generic;
using Xbim.Common.Geometry;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeService
    {

        /// <summary>
        /// Unifies faces and edges of the shape which lie on the same geometry
        /// </summary>
        /// <param name="shape"></param>
        /// <returns>modified copy of the shape</returns>
        IXShape UnifyDomain(IXShape shape);
        IXShape Convert(string brepString);
        IXbimGeometryObject ConvertToV5(string brepString);
        string Convert(IXShape shape);
        string Convert(IXbimGeometryObject v5Shape);


        IXShape Transform(IXShape shape, IXMatrix transformMatrix);
        void Triangulate(IXShape shape);
        IXShape Union(IXShape body, IXShape addition);
        IXShape Cut(IXShape body, IXShape subtraction);
        IXShape Intersect(IXShape body, IXShape intersect);
        IXShape Union(IXShape body, IEnumerable<IXShape> additions);
        IXShape Cut(IXShape body, IEnumerable<IXShape> subtractions);
        IXShape Intersect(IXShape body, IEnumerable<IXShape> intersections);
        /// <summary>
        /// Removes any placement
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        IXShape RemovePlacement(IXShape shape);
        /// <summary>
        /// Sets the placement of the shape, overrides any existing placement
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="placement"></param>
        /// <returns></returns>
        IXShape SetPlacement(IXShape shape, IIfcObjectPlacement placement);


        /// <summary>
        /// Applies the inverse of the object placement if invertPacement is true
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="placement"></param>
        /// <param name="invertPlacement">if true inverts the placement tranformation that is applied</param>
        /// <returns></returns>
        IXShape Moved(IXShape shape, IIfcObjectPlacement placement, bool invertPlacement = false);
        IXShape Moved(IXShape shape, IXLocation moveTo);
        IXShape Scaled(IXShape shape, double scale);

        bool IsFacingAwayFrom(IXFace face, IXDirection direction);


        /// <summary>
        /// Creates a single compound shape from the shapes params
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns></returns>
        IXShape Combine(IEnumerable<IXShape> shapes);

        /// <summary>
        /// Determines whether the specified shapes are colliding.
        /// </summary>
        /// <param name="shape1">The first shape.</param>
        /// <param name="shape2">The second shape.</param>
        /// <param name="precision">The precision.</param>
        /// <returns>
        ///   <c>true</c> if the specified shape1 is colliding with shape2; otherwise, <c>false</c>.
        /// </returns>
        bool IsColliding(IXShape shape1, IXShape shape2, double precision);

        /// <summary>
        /// Creates a mesh of the shape, a call to Triangulation must be made on the shape prior to this call
        /// An empty mesh will be returned if no triangulation is present
        /// use has curves to see if a finer or course mesh can be calculated
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="meshFactors">Factors to control the mesh triangulation granularity</param>
        /// <param name="hasCurves">true if the shape has any curved edges or faces, use to determine if finer or courser meshing will return a different result</param>
        /// <returns></returns>
        byte[] CreateWexBimMesh(IXShape shape, IXMeshFactors meshFactors, double scale, out IXAxisAlignedBoundingBox bounds, out bool hasCurves);
        byte[] CreateWexBimMesh(IXShape shape, IXMeshFactors meshFactors, double scale, out IXAxisAlignedBoundingBox bounds);
    }
}
