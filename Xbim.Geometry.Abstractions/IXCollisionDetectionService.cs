using System.Collections.Generic;

namespace Xbim.Geometry.Abstractions
{

    public interface IXCollisionDetectionResult
    {
        public int ProductLabel1 { get; }
        public int ProductLabel2 { get; }
    }

    public interface IXCollisionDetectionService
    {

        /// <summary>
        /// Determines whether the specified shapes are colliding.
        /// </summary>
        /// <param name="shape1">The first shape.</param>
        /// <param name="shape2">The second shape.</param>
        /// <returns>
        ///   <c>true</c> if the first shape is colliding with the second shape; otherwise, <c>false</c>.
        /// </returns>
        bool IsColliding(IXShape shape1, IXShape shape2);


        /// <summary>
        /// Detectes collisions in a specified shape store.
        /// </summary>
        /// <param name="shapeStore">The shape store.</param>
        /// <returns>A list of collision results.</returns>
        IEnumerable<IXCollisionDetectionResult> DetectCollisions(IXShapeStore shapeStore);


        /// <summary>
        /// Detects collisions between two shape stores.
        /// </summary>
        /// <param name="firstShapeStore">The first shape store.</param>
        /// <param name="secondShapeStore">The second shape store.</param>
        /// <returns></returns>
        IEnumerable<IXCollisionDetectionResult> DetectsCollisions(IXShapeStore firstShapeStore, IXShapeStore secondShapeStore);



    }
}
