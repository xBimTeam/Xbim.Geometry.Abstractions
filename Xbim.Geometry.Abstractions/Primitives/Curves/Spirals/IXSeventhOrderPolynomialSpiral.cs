namespace Xbim.Geometry.Abstractions
{
    public interface IXSeventhOrderPolynomialSpiral : IXSpiral
    {
        public double SepticTerm { get; }
        public double? SexticTerm { get; }
        public double? QuinticTerm { get; }
        public double? QuarticTerm { get; }
        public double? CubicTerm { get; }
        public double? QuadraticTerm { get; }
        public double? LinearTerm { get; }
        public double? ConstantTerm { get; }
    }
}