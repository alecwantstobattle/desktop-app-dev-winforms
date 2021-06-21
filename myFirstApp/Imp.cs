using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstApp
{
    class Imp
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=dadDb; Integrated Security=True; MultipleActiveResultSets=True";
        public static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public void addUser(string name, string phone, Int16 age, Int16 gender, Int16 status)
        {
            try
            {
                SqlCommand command = new SqlCommand("st_insertUser", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@status", status);

                sqlConnection.Open();
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show(name + " added successfully into System.");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
