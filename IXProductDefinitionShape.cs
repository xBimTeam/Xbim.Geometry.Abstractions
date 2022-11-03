using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Xbim.Common;
using Xbim.Ifc4.Interfaces;

namespace Xbim.Geometry.Abstractions
{
    /// <summary>
    /// Defines the 3D shape representation of a Product and the related materials
    /// </summary>
    public interface IXProductDefinitionShape
    {
        IEnumerable<IXShapeRepresentation> ShapeRepresentations { get; }
        int NbMaterialLayers { get; }

        void AddShapeRepresentation(string name, int id,  IXStorageItem representationShape, IIfcObjectPlacement objectPlacement, ILogger logger);
        double? Volume { get; set; }
        double? Area { get; set; }
        double? ThicknessMax { get; set; }
        double? HeightMin { get; set; }
        double? HeightMax { get; set; }
        IXShape Shape { get; set; }
        IEnumerable<IXMaterialLayer> MaterialLayers { get;  }
        int IfcId { get; }
        string IfcName { get; }
        string IfcType { get; }
        string Classification { get; }

        void SetMaterialLayers(IEnumerable<IIfcMaterialLayer> layers, double oneMetre);
    }
}
