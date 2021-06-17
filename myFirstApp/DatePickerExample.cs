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
    public partial class DatePickerExample : Form
    {
        public DatePickerExample()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToString("MMM-yyyy");
            //MessageBox.Show(dateTimePicker1.Value.Day.ToString() + "\n" + dateTimePicker1.Value.Month.ToString() + "\n" + dateTimePicker1.Value.Year.ToString() + "\n" + dateTimePicker1.Value.Hour.ToString());

            MessageBox.Show(dateTimePicker1.Value.AddDays(-67).ToString("dd-MMM-yyyy"));
        }
    }
}
