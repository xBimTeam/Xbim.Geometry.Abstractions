namespace Xbim.Geometry.Abstractions
{
    public interface IXLocation
    {
        double Scale { get; }
        IXPoint Translation { get;}
        IXQuaternion Rotation { get; }
        IXLocation Multiplied(IXLocation location);
        bool IsIdentity { get; }
        IXLocation Inverted();
        IXLocation ScaledBy(double scaleFactor);
    }
}
