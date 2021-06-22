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

        public void updateUser(int userID, string name, string phone, Int16 age, Int16 gender, Int16 status)
        {
            try
            {
                SqlCommand command = new SqlCommand("st_updateUser", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", userID);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@status", status);

                sqlConnection.Open();
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show(name + " updated successfully into System.");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteUser(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("st_deleteUser", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);

                sqlConnection.Open();
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("data deleted successfully from System.");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string[] data = new string[5];

        public string[] getUserData(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("st_retrieveData", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        data[0] = dataReader["Name"].ToString(); 
                        data[1] = dataReader["Phone"].ToString(); 
                        data[2] = dataReader["Age"].ToString(); 
                        data[3] = dataReader["Gender"].ToString(); 
                        data[4] = dataReader["Status"].ToString(); 
                    }
                }
                else
                {
                    MessageBox.Show("No data available.");
                }

                sqlConnection.Close();
            }
            catch
            {

            }

            return data;
        }
    }
}
