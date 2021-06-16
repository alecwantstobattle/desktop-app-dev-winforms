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
    public partial class RadioExample : Form
    {
        public RadioExample()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
            {
                displayLabel.Text = "Your name is " + nameText.Text + " and your gender is " + maleRadioButton.Text;
            }
            else if (femaleRadioButton.Checked)
            {
                displayLabel.Text = "Your name is " + nameText.Text + " and your gender is " + femaleRadioButton.Text;
            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
            {
                MessageBox.Show("Hi I am male");
            }
            else
            {
                MessageBox.Show("Female is selected");
            }
        }

        //private void maleRadioButton_Enter(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hi I am radio button of type male");
        //}

        //private void maleRadioButton_Leave(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Bye I am radio button of type male");
        //}
    }
}
