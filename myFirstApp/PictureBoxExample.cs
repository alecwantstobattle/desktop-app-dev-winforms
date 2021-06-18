using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstApp
{
    public partial class PictureBoxExample : Form
    {
        public PictureBoxExample()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                Image image = new Bitmap(openFileDialog1.FileName);

                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                File.Copy(textBox1.Text, Application.StartupPath + "\\a.jpg");
                MessageBox.Show("Copied");
            }
        }
    }
}
