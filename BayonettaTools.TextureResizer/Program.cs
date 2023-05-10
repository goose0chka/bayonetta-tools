using BayonettaMesParser.Model;
using System.Xml.Serialization;

if (args.Length != 5)
{
    Console.WriteLine("Usage: bayonetta-mes-resizer <old width> <old height> <new width> <new height> <xml file>");
    return;
}

var filePath = args[4];
if (File.Exists(filePath) || Path.GetExtension(filePath) != ".xml")
{
    Console.WriteLine("XML file not found");
    return;
}

using var file = File.Open(filePath, FileMode.Open);

TextureMap? data = null;
var serializer = new XmlSerializer(typeof(TextureMap));
try
{
    data = (TextureMap?)serializer.Deserialize(file);
    if (data == null) throw new Exception("Parser returned null");
}
catch (Exception ex)
{
    Console.WriteLine("XML parsing error");
    Console.WriteLine(ex.Message);
    return;
}

var values = args.Take(4)
    .Select(x => new { Parsed = uint.TryParse(x, out var Value), Value })
    .Where(x => x.Parsed && x.Value > 0)
    .Select(x => x.Value)
    .ToArray();

if (values.Length != 4)
{
    Console.WriteLine("Coordinate parsing error");
    Console.WriteLine("All 4 values must be greater than 0");
    return;
}

var resize = new 
{ 
    Width = values[0], 
    Height = values[1], 
    NewWidth = values[2], 
    NewHeight = values[3] 
};

foreach (var entry in data.UVTable.Entries)
{
    entry.StartX *= resize.Width / resize.NewWidth;
    entry.EndX *= resize.Width / resize.NewWidth;
    entry.StartY *= resize.Height / resize.NewHeight;
    entry.EndY *= resize.Height / resize.NewHeight;
}

try
{
    file.Position = 0;
    serializer.Serialize(file, data);
}
catch (Exception ex)
{
    Console.WriteLine("Error while saving changes");
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Successfully updated file");
