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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CheckboxButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
            CheckboxExample checkboxExample = new CheckboxExample();
            checkboxExample.MdiParent = MDIForm.ActiveForm;
            checkboxExample.WindowState = FormWindowState.Maximized;
            checkboxExample.Show();
        }

        private void RadioButtonsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadioExample radioExample = new RadioExample();
            radioExample.Show();
        }

        private void ComboBoxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComboExample comboExample = new ComboExample();
            comboExample.Show();
        }

        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
