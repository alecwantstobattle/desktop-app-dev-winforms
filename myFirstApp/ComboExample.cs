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
    public partial class ComboExample : Form
    {
        public ComboExample()
        {
            InitializeComponent();
        }

        private void countriesDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countriesDropdown.SelectedIndex != -1)
            {
                citiesDropdown.Items.Clear();

                //if (countriesDropdown.SelectedItem.ToString() == "Pakistan")
                if (countriesDropdown.SelectedIndex == 0)
                {
                    citiesDropdown.Items.Add("Karachi");
                    citiesDropdown.Items.Add("Lahore");
                }
                //else if (countriesDropdown.SelectedItem.ToString() == "China")
                else if (countriesDropdown.SelectedIndex == 1)
                {
                    citiesDropdown.Items.Add("Beijing");
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (countriesDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select country");
            }
            else
            {
                answerLabel.Text = countriesDropdown.SelectedItem.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (countriesDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select country");
            }
            else
            {
                if (itemListbox.Items.Contains(countriesDropdown.SelectedItem.ToString()))
                {
                    MessageBox.Show(countriesDropdown.SelectedItem.ToString() + " already exist.");
                }
                else
                {
                    itemListbox.Items.Add(countriesDropdown.SelectedItem.ToString());
                }
            }
        }
    }
}
