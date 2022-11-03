using System.Collections.Generic;

namespace Xbim.Geometry.Abstractions
{
    public struct XColourRGB : IXColourRGB
    {
        public XColourRGB(double red, double green, double blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        public XColourRGB(IXColourRGB rgb)
        {
            Red = rgb.Red;
            Green = rgb.Green;
            Blue = rgb.Blue;
        }
        public double Red { get; set; }
        public double Green { get; set; }
        public double Blue { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(this, obj);
        }
        public bool Equals(IXColourRGB x, IXColourRGB y)
        {
            if (x == null && y == null) return true;
            if(x==null || y==null) return false;
            return (x.Red, x.Green, x.Blue) == (y.Red, y.Green, y.Blue);
        }
        public override int GetHashCode()
        {
            return GetHashCode(this);
        }
        public int GetHashCode(IXColourRGB obj)
        {
            var r = (int)(255 * obj.Red);
            var g = (int)(255 * obj.Green);
            var b = (int)(255 * obj.Blue);
            return b + (g << 8) + (r << 16);
        }

        public bool Equals(IXColourRGB other)
        {
            return Equals(this, other);
        }
    }
}
