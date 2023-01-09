namespace Xbim.Geometry.Abstractions
{
    public interface IXLocation: IXMatrix
    {
        double Scale { get; }
        IXPoint Translation { get; set; }
        IXQuaternion Rotation { get; }
        IXLocation Multiplied(IXLocation location);
        
        IXLocation Inverted();
        IXLocation ScaledBy(double scaleFactor);
      
    }
}
