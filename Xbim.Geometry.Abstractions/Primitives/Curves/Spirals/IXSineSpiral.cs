namespace Xbim.Geometry.Abstractions
{
    public interface IXSineSpiral : IXSpiral
    {
        public double SineTerm { get; }
        public double? LinearTerm { get; }
        public double? ConstantTerm { get; }
    }
}