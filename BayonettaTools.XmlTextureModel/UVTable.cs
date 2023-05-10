using System.Xml.Serialization;

namespace BayonettaTools.XmlTextureModel;

public class UVTable
{
    [XmlAttribute]
    public int Count { get; set; }
    public List<TextureMapUV> Entries { get; set; } = new();
}