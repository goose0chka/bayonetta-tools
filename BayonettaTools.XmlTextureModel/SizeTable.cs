using System.Xml.Serialization;

namespace BayonettaTools.XmlTextureModel;

public class SizeTable
{
    [XmlAttribute]
    public int Count { get; set; }
    public int CharSizeX { get; set; }
    public int CharSizeY { get; set; }
    public List<TextureMapSize> Entries { get; set; } = new();
}