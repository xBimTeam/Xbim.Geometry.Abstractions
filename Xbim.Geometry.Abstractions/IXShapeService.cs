using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xbim.Common.Geometry;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXShapeService : IXModelScoped
    {
       

        /// <summary>
        /// Returns the 3D symold of the specified type, note these symbol shapes are readonly
        /// </summary>
        /// <param name="symbolType"></param>
        
        /// <returns></returns>
        IXShape GetSymbol(GeometricSymbols symbolType);
        /// <summary>
        /// Unifies faces and edges of the shape which lie on the same geometry
        /// </summary>
        /// <param name="shape"></param>
        /// <returns>modified copy of the shape</returns>
        IXShape UnifyDomain(IXShape shape);
        IXShape Convert(string brepString);
        IXbimGeometryObject ConvertToV5(string brepString);
        string Convert(IXShape shape);
        IXbimGeometryObject ConvertToV5(IXShape shape);
        string Convert(IXbimGeometryObject v5Shape);
        //legacy call to create version 5 geometry objects
        IXShape Build(IIfcGeometricRepresentationItem geomRep, out ShapeGeometryErrorOrWarning errorOrWarning);
        Task<(IXShape, ShapeGeometryErrorOrWarning)> BuildAsync(IIfcGeometricRepresentationItem geomRep);
        Task<(IXShape, ShapeGeometryErrorOrWarning)> BuildAsync(IIfcGeometricRepresentationItem geomRep, CancellationToken token);

        IXShape Transform(IXShape shape, XbimMatrix3D transformMatrix);
        void Triangulate(IXShape shape);
        IXShape Union(IXShape body, IXShape addition);
        IXShape Cut(IXShape body, IXShape subtraction);
        IXShape Union(IXShape body, IEnumerable<IXShape> additions);
        IXShape Cut(IXShape body, IEnumerable<IXShape> subtractions);
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
        IXAxis2Placement2d BuildAxis2Placement2d(IXPoint location, IXVector xDirection);

        bool IsFacingAwayFrom(IXFace face, IXDirection direction);

  

        /// <summary>
        /// Creates a single compound shape from the shapes params
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns></returns>
        IXShape Combine(params IXShape[] shapes);

        /// <summary>
        /// Method to handle faces with badly defined bounds
        /// If there is more than one outer bound, separate faces are retruned for each bound
        /// Wires are revered as necessary to ensure correct windings for inner and outer bounds
        /// </summary>
        /// <param name="face"></param>
        /// <returns></returns>
        IEnumerable<IXFace> FixFace(IXFace face);

        /// <summary>
        /// Creates a mesh of the shape, a call to Triangulation must be made on the shape prior to this call
        /// An empty mesh will be returned if no triangulation is present
        /// use has curves to see if a finer or course mesh can be calculated
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="meshFactors">Factors to control the mesh triangulation granularity</param>
        /// <param name="hasCurves">true if the shape has any curved edges or faces, use to determine if finer or courser meshing will return a different result</param>
        /// <returns></returns>
        byte[] CreateWexBimMesh(IXShape shape, IXMeshFactors meshFactors, ref bool hasCurves);
        byte[] CreateWexBimMesh(IEnumerable<IXFace> faces, IXMeshFactors meshFactors, ref bool hasCurves);
        byte[] CreateWexBimMesh(IXShape shape, IXMeshFactors meshFactors);
        byte[] CreateWexBimMesh(IEnumerable<IXFace> faces, IXMeshFactors meshFactors);
    }
}
