using System;

namespace Xbim.Geometry.Abstractions
{
    public class XVisualMaterial : IXVisualMaterial
    {
        readonly string _name;
        IXColourRGB _ambientColor;
        IXColourRGB _diffuseColor;
        IXColourRGB _specularColor;
        IXColourRGB _emissiveColor;
        float _shininess;
        float _transparency;

        public XVisualMaterial(string name, IXColourRGB ambientColor, IXColourRGB diffuseColor, IXColourRGB specularColor, IXColourRGB emissiveColor = null, float shininess = 0f, float transparency = 0f)
        {
            _name = name;
            AmbientColor = ambientColor;
            DiffuseColor = diffuseColor;
            SpecularColor = specularColor;
            EmissiveColor = emissiveColor;
            Shininess = shininess;
            Transparency = transparency;
        }

        public string Name => _name;

        public IXBRepDocumentItem Label => throw new NotImplementedException();

        public IXColourRGB AmbientColor { get => _ambientColor; set => _ambientColor = value; }
        public IXColourRGB DiffuseColor { get => _diffuseColor; set => _diffuseColor = value; }
        public IXColourRGB SpecularColor { get => _specularColor; set => _specularColor = value; }
        public IXColourRGB EmissiveColor { get => _emissiveColor; set => _emissiveColor = value; }
        public float Shininess { get => _shininess; set => _shininess = value; }
        public float Transparency { get => _transparency; set => _transparency = value; }

        public bool IsDefined => true;

        public bool IsStored => false;
    }
}
