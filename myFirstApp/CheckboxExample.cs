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
    public partial class CheckboxExample : Form
    {
        public CheckboxExample()
        {
            InitializeComponent();
        }

        private float sum = 0;

        private void Calculate (ListBox listBox, CheckBox checkBox, float price, Label result)
        {
            if (checkBox.Checked)
            {
                listBox.Items.Add(checkBox.Text);
                sum += price;
                result.Text = sum.ToString();
            }
            else
            {
                listBox.Items.Remove(checkBox.Text);
                sum -= price;
                result.Text = sum.ToString();
            }
        }

        private void internetCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //if (internetCheckbox.Checked)
            //{
            //    servicesListbox.Items.Add(internetCheckbox.Text);
            //    sum += 500;
            //    billLabel.Text = sum.ToString();
            //}
            //else
            //{
            //    servicesListbox.Items.Remove(internetCheckbox.Text);
            //    sum -= 500;
            //    billLabel.Text = sum.ToString();
            //}

            Calculate(servicesListbox, internetCheckbox, 500, billLabel);
        }

        private void lunchCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //if (lunchCheckbox.Checked)
            //{
            //    servicesListbox.Items.Add(lunchCheckbox.Text);
            //    sum += 450;
            //    billLabel.Text = sum.ToString();
            //}
            //else
            //{
            //    servicesListbox.Items.Remove(lunchCheckbox.Text);
            //    sum -= 450;
            //    billLabel.Text = sum.ToString();
            //}
            Calculate(servicesListbox, lunchCheckbox, 450, billLabel);
        }

        private void newspaperCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //if (newspaperCheckbox.Checked)
            //{
            //    servicesListbox.Items.Add(newspaperCheckbox.Text);
            //    sum += 30;
            //    billLabel.Text = sum.ToString();
            //}
            //else
            //{
            //    servicesListbox.Items.Remove(newspaperCheckbox.Text);
            //    sum -= 30;
            //    billLabel.Text = sum.ToString();
            //}
            Calculate(servicesListbox, newspaperCheckbox, 30, billLabel);
        }

        private void swimmingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //if (swimmingCheckbox.Checked)
            //{
            //    servicesListbox.Items.Add(swimmingCheckbox.Text);
            //    sum += 1000;
            //    billLabel.Text = sum.ToString();
            //}
            //else
            //{
            //    servicesListbox.Items.Remove(swimmingCheckbox.Text);
            //    sum -= 1000;
            //    billLabel.Text = sum.ToString();
            //}
            Calculate(servicesListbox, swimmingCheckbox, 1000, billLabel);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
