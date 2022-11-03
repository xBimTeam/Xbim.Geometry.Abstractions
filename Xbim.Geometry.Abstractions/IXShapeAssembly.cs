using System.Collections.Generic;

namespace Xbim.Geometry.Abstractions
{
   
    public interface IXShapeAssembly : IXShapeComponent
    {
        IEnumerable<IXShapeInstance> Instances { get; }
        void AddInstance(IXShapeInstance component);
        
        
        bool IsSubAssembly { get; set; }
        
    }
}
