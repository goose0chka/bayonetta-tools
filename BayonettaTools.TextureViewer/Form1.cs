using BayonettaMesParser.Model;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Xml.Serialization;

namespace BayonettaTextureViewer
{
    public partial class Form1 : Form
    {
        private TextureMap? result = null;
        private Bitmap? texture = null;
        private Bitmap? selectedTexture = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlFileTextbox.Text = openFileDialog1.FileName;
                EnableLoadButton();
            }
        }

        private void textureFileTextbox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG files (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textureFileTextbox.Text = openFileDialog1.FileName;
                EnableLoadButton();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(xmlFileTextbox.Text)) return;

            XmlSerializer serializer = new XmlSerializer(typeof(TextureMap));
            try
            {
                using var file = File.OpenRead(xmlFileTextbox.Text);
                result = (TextureMap?)serializer.Deserialize(file);
                LoadXml();
                LoadTextures();
            }
            catch { Debug.WriteLine("Parsing error"); }
        }

        private void LoadTextures()
        {
            texture = new Bitmap(textureFileTextbox.Text);
            topxVal.Maximum = texture.Width;
            btmxVal.Maximum = texture.Width;
            topyVal.Maximum = texture.Height;
            btmyVal.Maximum = texture.Height;
        }

        private void LoadXml()
        {
            texturesList.Items.Clear();
            var items = result?.UVTable.Entries.ToArray() ?? Array.Empty<object>();
            var collection = new ListBox.ObjectCollection(texturesList, items);

            texturesList.Items.Clear();
            texturesList.Items.AddRange(collection);

            texturesList.DisplayMember = "Id";
            texturesList.FormatString = "X4";
            texturesList.FormattingEnabled = true;
        }

        private void EnableLoadButton()
        {
            loadButton.Enabled = !string.IsNullOrWhiteSpace(xmlFileTextbox.Text)
                && !string.IsNullOrWhiteSpace(textureFileTextbox.Text);
        }

        private void texturesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSymbol();
        }

        private void LoadSymbol()
        {
            var selected = (TextureMapUV)texturesList.SelectedItem;
            if (selected is null || texture is null) return;

            if (selectedTexture is not null) selectedTexture.Dispose();
            selectedTexture = null;

            var x0 = (int)(texture.Width * selected.StartX);
            var x1 = (int)(texture.Width * selected.EndX);
            var y0 = (int)(texture.Height * selected.StartY);
            var y1 = (int)(texture.Height * selected.EndY);
            var rect = new Rectangle(x0, y0, x1 - x0, y1 - y0);

            topxVal.Value = x0;
            btmxVal.Value = x1;
            topyVal.Value = y0;
            btmyVal.Value = y1;

            selectedTexture = texture.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
            selectedTexturePictureBox.Image = selectedTexture;

            var size = result?.SizeTable.Entries.FirstOrDefault(x => x.Id == selected.Id);
            widthTb.Text = $"{size?.Width} ({selectedTexture.Width})";
            heightTb.Text = $"{size?.Height} ({selectedTexture.Height})";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var x in result?.UVTable.Entries)
            {
                var entry = result.SizeTable.Entries.FirstOrDefault(y => y.Id == x.Id);
                if (entry == null)
                {
                    entry = new TextureMapSize()
                    {
                        Id = x.Id
                    };
                    result.SizeTable.Entries.Add(entry);
                }

                entry.Width = (int)(texture.Width * (x.EndX - x.StartX));
                entry.Height = (int)(texture.Height * (x.EndY - x.StartY));
            }

            var dialog = new SaveFileDialog()
            {
                DefaultExt = "xml"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using var file = File.OpenWrite(dialog.FileName);
                var serializer = new XmlSerializer(typeof(TextureMap));
                serializer.Serialize(file, result);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selected = (TextureMapUV)texturesList.SelectedItem;
            selected.StartX = decimal.ToDouble(topxVal.Value) / texture.Width;
            selected.StartY = decimal.ToDouble(topyVal.Value) / texture.Height;
            selected.EndX = decimal.ToDouble(btmxVal.Value) / texture.Width;
            selected.EndY = decimal.ToDouble(btmyVal.Value) / texture.Height;
            LoadSymbol();
        }

        private void topxVal_Enter(object sender, EventArgs e)
        {
            if (sender is NumericUpDown obj)
                obj.Select(0, obj.Text.Length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in result.UVTable.Entries.Where(x => x.Id > 500))
            {
                item.Id -= 12;
            }
            foreach (var item in result.SizeTable.Entries.Where(x => x.Id > 500))
            {
                item.Id -= 12;
            }
        }
    }
}