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
    public partial class RetrievalExample : Form
    {
        public RetrievalExample()
        {
            InitializeComponent();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            if (idTextbox.Text != "")
            {
                Imp imp = new Imp();
                string [] data = imp.getUserData(Convert.ToInt32(idTextbox.Text));

                nameTextbox.Text = data[0];
                ageTextbox.Text = data[1];
                phoneText.Text = data[2];

                if (data[3] == "Male")
                {
                    maleRadioButton.Checked = true;
                }
                else if (data[3] == "Female")
                {
                    femaleRadioButton.Checked = true;
                }

                statusDropdown.SelectedItem = data[4];
            }
            else
            {
                MessageBox.Show("Please enter ID");
            }
        }
    }
}
