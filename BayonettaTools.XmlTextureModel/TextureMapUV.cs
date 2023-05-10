using System.Xml.Serialization;

namespace BayonettaTools.XmlTextureModel;

public class TextureMapUV
{
    [XmlAttribute]
    public int Id { get; set; }
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
}