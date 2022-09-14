using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    class DB_Config
    {
        private string connection_String;
        SqlConnection connection;
        public DB_Config()
        {
            connection_String = "Data Source=.\\SQLEXPRESS;Initial Catalog=librarymanagementt;Integrated Security=True";

            connection = new SqlConnection(connection_String);
        }

        public SqlConnection GetSqlConnection
        {
            get
            {
                return connection;
            }
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Can not connect to database ! Please check the connection");
                return false;
            }
        }

        public SqlDataReader QueryHandler(string query, IEnumerable<SqlParameter> parameters)
        {
            try
            {
                SqlCommand sqlServercommand = new SqlCommand(query, connection);

                foreach (SqlParameter parameter in parameters)
                {
                    sqlServercommand.Parameters.Add(parameter);
                }

                SqlDataReader reader;
                reader = sqlServercommand.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Error ! Please try again");
                return false;
            }
        }
    }
}
