namespace Xbim.Geometry.Abstractions
{
    /// <summary>
    /// A 2 or 3 dimensional point
    /// </summary>
    public interface IXPoint
    {
        /// <summary>
        /// True if the point is a 3d point
        /// </summary>
        bool Is3d { get; }
        double X { get; }
        double Y { get; }
        double Z { get; }
    }
}