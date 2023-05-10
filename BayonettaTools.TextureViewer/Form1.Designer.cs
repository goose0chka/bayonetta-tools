namespace BayonettaTextureViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            xmlFileTextbox = new TextBox();
            textureFileTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loadButton = new Button();
            selectedTexturePictureBox = new PictureBox();
            texturesList = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            topXLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            topyVal = new NumericUpDown();
            btmyVal = new NumericUpDown();
            btmxVal = new NumericUpDown();
            topxVal = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            widthTb = new TextBox();
            heightTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)selectedTexturePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topyVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btmyVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btmxVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topxVal).BeginInit();
            SuspendLayout();
            // 
            // xmlFileTextbox
            // 
            xmlFileTextbox.Location = new Point(66, 12);
            xmlFileTextbox.Name = "xmlFileTextbox";
            xmlFileTextbox.ReadOnly = true;
            xmlFileTextbox.Size = new Size(143, 23);
            xmlFileTextbox.TabIndex = 5;
            xmlFileTextbox.Click += textBox1_Click;
            // 
            // textureFileTextbox
            // 
            textureFileTextbox.Location = new Point(66, 41);
            textureFileTextbox.Name = "textureFileTextbox";
            textureFileTextbox.ReadOnly = true;
            textureFileTextbox.Size = new Size(143, 23);
            textureFileTextbox.TabIndex = 5;
            textureFileTextbox.Click += textureFileTextbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "XML:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Texture:";
            // 
            // loadButton
            // 
            loadButton.Enabled = false;
            loadButton.Location = new Point(134, 70);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // selectedTexturePictureBox
            // 
            selectedTexturePictureBox.BorderStyle = BorderStyle.FixedSingle;
            selectedTexturePictureBox.Location = new Point(341, 12);
            selectedTexturePictureBox.Name = "selectedTexturePictureBox";
            selectedTexturePictureBox.Size = new Size(124, 124);
            selectedTexturePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            selectedTexturePictureBox.TabIndex = 5;
            selectedTexturePictureBox.TabStop = false;
            // 
            // texturesList
            // 
            texturesList.FormattingEnabled = true;
            texturesList.ItemHeight = 15;
            texturesList.Location = new Point(215, 12);
            texturesList.Name = "texturesList";
            texturesList.Size = new Size(120, 124);
            texturesList.TabIndex = 5;
            texturesList.SelectedIndexChanged += texturesList_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // topXLabel
            // 
            topXLabel.AutoSize = true;
            topXLabel.Location = new Point(12, 144);
            topXLabel.Name = "topXLabel";
            topXLabel.Size = new Size(36, 15);
            topXLabel.TabIndex = 7;
            topXLabel.Text = "Top X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Top Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 174);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Bottom Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 144);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Bottom X";
            // 
            // topyVal
            // 
            topyVal.Location = new Point(54, 172);
            topyVal.Name = "topyVal";
            topyVal.Size = new Size(74, 23);
            topyVal.TabIndex = 1;
            topyVal.Enter += topxVal_Enter;
            // 
            // btmyVal
            // 
            btmyVal.Location = new Point(197, 172);
            btmyVal.Name = "btmyVal";
            btmyVal.Size = new Size(74, 23);
            btmyVal.TabIndex = 3;
            btmyVal.Enter += topxVal_Enter;
            // 
            // btmxVal
            // 
            btmxVal.Location = new Point(197, 142);
            btmxVal.Name = "btmxVal";
            btmxVal.Size = new Size(74, 23);
            btmxVal.TabIndex = 2;
            btmxVal.Enter += topxVal_Enter;
            // 
            // topxVal
            // 
            topxVal.Location = new Point(54, 142);
            topxVal.Name = "topxVal";
            topxVal.Size = new Size(74, 23);
            topxVal.TabIndex = 0;
            topxVal.Enter += topxVal_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 174);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 23;
            label6.Text = "Height";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 145);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 22;
            label7.Text = "Width";
            // 
            // widthTb
            // 
            widthTb.Location = new Point(322, 142);
            widthTb.Name = "widthTb";
            widthTb.ReadOnly = true;
            widthTb.Size = new Size(100, 23);
            widthTb.TabIndex = 5;
            // 
            // heightTb
            // 
            heightTb.Location = new Point(322, 171);
            heightTb.Name = "heightTb";
            heightTb.ReadOnly = true;
            heightTb.Size = new Size(100, 23);
            heightTb.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 201);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(275, 229);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 24;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 286);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(heightTb);
            Controls.Add(widthTb);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(topxVal);
            Controls.Add(btmyVal);
            Controls.Add(btmxVal);
            Controls.Add(topyVal);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(topXLabel);
            Controls.Add(texturesList);
            Controls.Add(selectedTexturePictureBox);
            Controls.Add(loadButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textureFileTextbox);
            Controls.Add(xmlFileTextbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)selectedTexturePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)topyVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btmyVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btmxVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)topxVal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox xmlFileTextbox;
        private TextBox textureFileTextbox;
        private Label label1;
        private Label label2;
        private Button loadButton;
        private PictureBox selectedTexturePictureBox;
        private ListBox texturesList;
        private OpenFileDialog openFileDialog1;
        private Label topXLabel;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown topyVal;
        private NumericUpDown btmyVal;
        private NumericUpDown btmxVal;
        private NumericUpDown topxVal;
        private Label label6;
        private Label label7;
        private TextBox widthTb;
        private TextBox heightTb;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}