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

namespace myFirstApp
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand getProductQuantityCommand = new SqlCommand("st_getQuantityWRTProduct", Imp.sqlConnection);
                getProductQuantityCommand.CommandType = CommandType.StoredProcedure;
                getProductQuantityCommand.Parameters.AddWithValue("@name", nameTextbox.Text);
                Imp.sqlConnection.Open();
                SqlDataReader dataReader = getProductQuantityCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        int productID = Convert.ToInt32(dataReader["ID"].ToString());
                        int productQuantity = Convert.ToInt32(dataReader["Quantity"].ToString());
                        SqlCommand updateCommand = new SqlCommand("st_updateStock", Imp.sqlConnection);
                        updateCommand.CommandType = CommandType.StoredProcedure;
                        updateCommand.Parameters.AddWithValue("@pid", productID);
                        updateCommand.Parameters.AddWithValue("@quantity", productQuantity + Convert.ToInt32(quantityTextbox.Text));

                        updateCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product Updated");
                }
                else
                {
                    SqlCommand addCommand = new SqlCommand("st_insertProduct", Imp.sqlConnection);
                    addCommand.CommandType = CommandType.StoredProcedure;
                    addCommand.Parameters.AddWithValue("@name", nameTextbox.Text);
                    addCommand.ExecuteNonQuery();

                    SqlCommand getProductIdCommand = new SqlCommand("st_getProductId", Imp.sqlConnection);
                    getProductIdCommand.CommandType = CommandType.StoredProcedure;
                    Imp.sqlConnection.Open();
                    int productID = Convert.ToInt32(getProductIdCommand.ExecuteScalar());

                    SqlCommand addStockCommand = new SqlCommand("st_insertStock", Imp.sqlConnection);
                    addStockCommand.CommandType = CommandType.StoredProcedure;
                    addStockCommand.Parameters.AddWithValue("@pid", productID);
                    addStockCommand.Parameters.AddWithValue("@quantity", Convert.ToInt32(quantityTextbox.Text));
                    addStockCommand.ExecuteNonQuery();

                    MessageBox.Show("Product Added");
                }

                SqlCommand getProductCommand = new SqlCommand("st_getQuantity", Imp.sqlConnection);
                getProductCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(getProductCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                Imp.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
