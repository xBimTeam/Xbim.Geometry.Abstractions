using System;
using System.Collections.Generic;
using System.Text;

namespace Xbim.Geometry.Abstractions
{
    
    
    public interface  IXProjectionService : IXModelScoped
    {

        /// <summary>
        /// Create a 2D Polyline in the XY plane of the outer hull of the shape
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="linearDeflection">The max deviation in model units of a line segment from the curve it segments</param>
        /// <param name="angularDeflection">the maximum angle of deflection (tangental continuity) in radians for curved lines, default is 30 degrees</param>
        /// <returns>A closed loop of 2D points</returns>
        IXFootprint CreateFootprint(IXShape shape, double linearDeflection, double angularDeflection = 0.52359877559829887307710723054658);
        /// <summary>
        /// Create a 2D Polyline in the XY plane of the outer hull of the shape
        /// Uses defaults for linear deflection of 25mm or 1 inch (if imperial model) and angular deflection of 30 degrees
        /// </summary>
        /// <param name="shape">Shape to footprint</param>
        /// <returns>A closed loop of 2D points</returns>
        IXFootprint CreateFootprint(IXShape shape);
        /// <summary>
        /// Gets a shape that represents the edges of the project shape onto the Z=0 plane
        /// </summary>
        /// <param name="shape">Shape to project</param>
        /// <returns></returns>
        IXCompound GetOutline(IXShape shape);

        /// <summary>
        /// Returns a compound of faces that represent the interection of the shape with the plane
        /// </summary>
        /// <param name="shape">Shape to section</param>
        /// <param name="cutPlane">Plane to section on</param>
        /// <returns>Empty shape if the cutPlane does not intersect with the shape</returns>
        IEnumerable<IXFace> CreateSection(IXShape shape, IXPlane cutPlane);

       
    }
}
