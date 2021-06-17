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
    public partial class RichTextBoxExample : Form
    {
        public RichTextBoxExample()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (paragraphTextbox.Text != "" && fileNameText.Text != "")
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (File.Exists(path + "\\" + fileNameText.Text))
                {
                   DialogResult dr =  MessageBox.Show("File already exists, Do you want add current data to this file?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if (dr == DialogResult.Yes)
                   {
                        File.AppendAllText(path + "\\" + fileNameText.Text, paragraphTextbox.Text);
                   }
                }

                else
                {
                    File.WriteAllText(path + "\\" + fileNameText.Text, paragraphTextbox.Text);

                    MessageBox.Show("File Created Successfully.");
                }
                
                
            }
        }
    }
}
