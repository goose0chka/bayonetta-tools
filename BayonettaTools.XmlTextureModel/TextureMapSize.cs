using System.Xml.Serialization;

namespace BayonettaTools.XmlTextureModel;

public class TextureMapSize
{
    [XmlAttribute]
    public int Id { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}