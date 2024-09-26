namespace Xbim.Geometry.Abstractions
{
    public interface IXCosineSpiral : IXSpiral
    {
        public double CosineTerm { get; }
        public double? ConstantTerm { get; }
    }
}