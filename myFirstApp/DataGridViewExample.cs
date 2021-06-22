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
    public partial class DataGridViewExample : Form
    {
        public DataGridViewExample()
        {
            InitializeComponent();
        }

        private void DataGridViewExample_Load(object sender, EventArgs e)
        {
            Imp imp = new Imp();
            imp.getAllUser(dataGridView1, idGV, NameGV, PhoneGV, AgeGV, GenderGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //MessageBox.Show("The person's name in this row is " + row.Cells["Name"].Value);

                //if (e.ColumnIndex == 3)
                //{
                //    MessageBox.Show("Gender: " + row.Cells["Gender"].Value);
                //}

                nameTextbox.Text = row.Cells["Name"].Value.ToString();
            }
            
        }
    }
}
