namespace Xbim.Geometry.Abstractions
{
    public interface IXThirdOrderPolynomialSpiral : IXSpiral
    {
        public double CubicTerm { get; }
        public double? QuadraticTerm { get; }
        public double? LinearTerm { get; }
        public double? ConstantTerm { get; }
    }
}