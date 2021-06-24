using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace myFirstApp
{
    public partial class UserReportWindow : Form
    {
        public UserReportWindow()
        {
            InitializeComponent();
        }

        private ReportDocument reportDocument = new ReportDocument();

        private void UserReportWindow_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection =
                    new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = arms; Integrated Security=true;");
                SqlCommand command = new SqlCommand("st_getUsersForReport", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                reportDocument.Load(Application.StartupPath + @"\Reports\UserReport.rpt");
                reportDocument.SetDataSource(dataTable);
                crystalReportViewer1.ReportSource = reportDocument;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                if (reportDocument != null)
                    reportDocument.Close();
                MessageBox.Show("Unable to load report \n" + ex.Message);
            }
        }

        private void UserReportWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reportDocument != null)
                reportDocument.Close();
        }
    }
}
