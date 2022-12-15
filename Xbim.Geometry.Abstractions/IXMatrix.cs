using System;
using System.Collections.Generic;
using System.Text;
using Xbim.Common.Geometry;

namespace Xbim.Geometry.Abstractions
{
    public interface IXMatrix 
    {

        bool IsAffine { get; }
        bool IsIdentity { get; }
      
        double M11 { get; set; }
        double M12 { get; set; }
        double M13 { get; set; }
        double M14 { get; set; }
        double M21 { get; set; }
        double M22 { get; set; }
        double M23 { get; set; }
        double M24 { get; set; }
        double M31 { get; set; }
        double M32 { get; set; }
        double M33 { get; set; }
        double M34 { get; set; }
        double M44 { get; set; }
        double OffsetX { get; set; }
        double OffsetY { get; set; }
        double OffsetZ { get; set; }
        
    }
}
