using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace myFirstApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex("^[0-9]+$");

            if (num1Text.Text == "")
            {
                num1ErrorLabel.Visible = true;
            }
            else
            {
                num1ErrorLabel.Visible = false;
            }

            if (num2Text.Text == "")
            {
                num2ErrorLabel.Visible = true;
            }
            else
            {
                num2ErrorLabel.Visible = false;
            }

            if (num1ErrorLabel.Visible || num2ErrorLabel.Visible)
            {
                MessageBox.Show("Fields with * are mandatory.");
            }
            else
            {
                if (rg.Match(num1Text.Text).Success && rg.Match(num2Text.Text).Success)
                {
                    int num1 = Convert.ToInt32(num1Text.Text);
                    int num2 = Convert.ToInt32(num2Text.Text);
                    int result = num1 + num2;
                    resultText.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Only numerics are accepted.");
                }
            }
        }

        private void num1Text_TextChanged(object sender, EventArgs e)
        {
            if (num1Text.Text == "")
            {
                num1ErrorLabel.Visible = true;
            }
            else
            {
                num1ErrorLabel.Visible = false;
            }
        }

        private void num2Text_TextChanged(object sender, EventArgs e)
        {
            if (num2Text.Text == "")
            {
                num2ErrorLabel.Visible = true;
            }
            else
            {
                num2ErrorLabel.Visible = false;
            }
        }
    }
}
