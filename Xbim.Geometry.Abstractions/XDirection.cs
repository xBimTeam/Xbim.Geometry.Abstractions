namespace Xbim.Geometry.Abstractions
{
    public class XDirection : IXDirection
    {
        bool _is3d = false;
        double _x;
        double _y;
        double _z;

        public XDirection(double x, double y, double z) 
        {
            _is3d = true;
            _x = x;
            _y = y;
            _z = z;
        }
        public XDirection(double x, double y)
        {
            _is3d = false;
            _x = x;
            _y = y;
         
        }
        public double X => _x;

        public double Y => _y;

        public double Z => _z;

        public bool Is3d => _is3d;

        public bool IsNull => false;
    }
}
