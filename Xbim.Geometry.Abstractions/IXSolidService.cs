using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    public interface IXSolidService : IXModelScoped
    {

        IXShape Union(IXShape body, IXShape addition);
        IXShape Cut(IXShape body, IXShape subtraction);
        IXShape Intersect(IXShape body, IXShape other);
        IXShape Union(IXShape body, IEnumerable<IXShape> additions);
        IXShape Cut(IXShape body, IEnumerable<IXShape> subtractions);
        IXShape Intersect(IXShape body, IEnumerable<IXShape> others);
        IEnumerable<IXSolid> CollectSolids(IXShape collectFrom);
        IXShape Build(IIfcGeometricRepresentationItem geomRep);
        Task<IXShape> BuildAsync(IIfcGeometricRepresentationItem geomRep);
        Task<IXShape> BuildAsync(IIfcGeometricRepresentationItem geomRep, CancellationToken token);


        IXShape Build(IIfcSolidModel ifcSolid);
        Task<IXShape> BuildAsync(IIfcSolidModel ifcSolid);
        Task<IXShape> BuildAsync(IIfcSolidModel ifcSolid, CancellationToken token);


        IXSolid Build(IIfcCsgPrimitive3D ifcCsgPrimitive);
        Task<IXSolid> BuildAsync(IIfcCsgPrimitive3D ifcCsgPrimitive);
        Task<IXSolid> BuildAsync(IIfcCsgPrimitive3D ifcCsgPrimitive, CancellationToken token);


      

       
    }
}
