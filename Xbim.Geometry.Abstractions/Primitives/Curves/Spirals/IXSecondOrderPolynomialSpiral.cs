namespace Xbim.Geometry.Abstractions
{
    public interface IXSecondOrderPolynomialSpiral : IXSpiral
    {
        public double QuadraticTerm { get; }
        public double? LinearTerm { get; }
        public double? ConstantTerm { get; }
    }
}