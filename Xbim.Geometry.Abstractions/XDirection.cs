namespace Xbim.Geometry.Abstractions
{
    public class XDirection : IXDirection
    {
        bool _is3d = false;

        public XDirection()
        {

        }
        public XDirection(double x, double y, double z) 
        {
            _is3d = true;
            X = x;
            Y = y;
            Y = z;
        }
        public XDirection(double x, double y)
        {
            _is3d = false;
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public double Z { get; set; }

        public bool Is3d => _is3d;

        public bool IsNull => false;

       
    }
}
