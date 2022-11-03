namespace Xbim.Geometry.Abstractions
{
    /// <summary>
    /// A brep representation coresponding conceptually to an IfcGeometricRepresentationItem
    /// </summary>
    public interface IXGeometricRepresentation
    {
        int EntityLabel { get; }
        IXShape Shape { get; }
        IXVisualMaterial Material { get; }
        IXStorageItem StorageHandle { get; set; }
        bool IsStored { get; }
    }
}
