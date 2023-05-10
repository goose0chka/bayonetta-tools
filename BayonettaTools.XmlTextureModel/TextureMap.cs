using System.Xml.Serialization;

namespace BayonettaTools.XmlTextureModel;

[XmlRoot]
public class TextureMap
{
    public UVTable UVTable { get; set; } = new();
    public SizeTable SizeTable { get; set; } = new();
}