using System.Xml.Serialization;
using System.Drawing.Imaging;
using System.Drawing;
using BayonettaTools.XmlTextureModel;

const string fileName = "image.png";
//string path = @"C:\Users\ihorl\Desktop\data13_files\mess\jp\common_mes\TextureMap.xml";
string path = @"E:\bayo\data13\mess\jp\common_mes\TextureMap.xml";
TextureMap? result = null;

XmlSerializer serializer = new XmlSerializer(typeof(TextureMap));
try
{
	using (var file = File.OpenRead(path))
	{
		result = (TextureMap?)serializer.Deserialize(file);
	}
}
catch { System.Console.WriteLine("Parsing error"); }
if (result is null) return;

using var bitmap = new Bitmap(2048, 1024);
using var graphics = Graphics.FromImage(bitmap);
using var pen = new Pen(Color.White, 1);
using var font = new Font(FontFamily.GenericMonospace, 8);

foreach (var entry in result.UVTable.Entries)
{
	var rect = getRect(entry);
	var id = string.Format("{0:X4}", entry.Id);
	graphics.DrawRectangle(pen, rect);
	graphics.DrawString(id, font, pen.Brush, rect.X, rect.Y);
	bitmap.SetPixel(rect.X, rect.Y, Color.Red);
	bitmap.SetPixel(rect.X + rect.Width, rect.Y + rect.Height, Color.Red);
}

if (File.Exists(fileName)) File.Delete(fileName);
bitmap.Save(fileName, ImageFormat.Png);

Rectangle getRect(TextureMapUV mapUv)
{
	var x0 = (int)(bitmap.Width * mapUv.StartX);
	var x1 = (int)(bitmap.Width * mapUv.EndX);
	var y0 = (int)(bitmap.Height * mapUv.StartY);
	var y1 = (int)(bitmap.Height * mapUv.EndY);
	return new(x0, y0, x1 - x0, y1 - y0);
}