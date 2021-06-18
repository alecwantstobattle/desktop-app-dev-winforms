using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstApp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public void Reset(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {

                control.

                if (control is TextBox)
                {
                    TextBox textbox = (TextBox) control;
                    textbox.Text = default;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox) control;
                    comboBox.SelectedIndex = -1;
                }

                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton) control;
                    radioButton.Checked = false;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox) control;
                    checkBox.Checked = false;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //comboBox1.SelectedIndex = -1;
            //checkBox1.Checked = false;
            //radioButton1.Checked = false;

            Reset(panel1);

        }
    }
}
