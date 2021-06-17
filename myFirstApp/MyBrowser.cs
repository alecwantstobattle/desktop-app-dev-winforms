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
    public partial class MyBrowser : Form
    {
        public MyBrowser()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (addressTextbox.Text != "")
            {
                string http = "http://www.";
                Uri uri = new Uri (http + addressTextbox.Text);

                webBrowser1.Url = uri;
                addressTextbox.Text = http + addressTextbox.Text;
            }
            else
            {
                MessageBox.Show("Enter Address");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
