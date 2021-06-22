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
        Imp imp = new Imp();

        public RetrievalExample()
        {
            InitializeComponent();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            if (idTextbox.Text != "")
            {
                string [] data = imp.getUserData(Convert.ToInt32(idTextbox.Text));

                nameTextbox.Text = data[0];
                phoneText.Text = data[1];
                ageTextbox.Text = data[2];

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            Int16 gender = maleRadioButton.Checked ? Convert.ToInt16(1) : Convert.ToInt16(0);
            Int16 status = statusDropdown.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);

            imp.updateUser(Convert.ToInt32(idTextbox.Text), nameTextbox.Text, phoneText.Text, Convert.ToInt16(ageTextbox.Text), gender, status);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Question...", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                imp.deleteUser(Convert.ToInt32(idTextbox.Text));
            }
        }
    }
}
