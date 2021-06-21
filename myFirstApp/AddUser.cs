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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Imp imp = new Imp();
            Int16 gender = maleRadioButton.Checked ? Convert.ToInt16(1) : Convert.ToInt16(0);
            Int16 status = statusDropdown.SelectedItem.ToString() == "Active" ? Convert.ToInt16(1) : Convert.ToInt16(0);
            imp.addUser(nameTextbox.Text, phoneText.Text, Convert.ToInt16(ageTextbox.Text), gender, status);
        }
    }
}
