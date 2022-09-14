using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    class ViewUser_DB
    {
        public DataTable getUserData(SqlCommand command)
        {
            DB_Config db = new DB_Config();
            DataTable dt = new DataTable();

            try
            {
                //No command then select all from book table
                if (command == null)
                {
                    command = new SqlCommand("Select * from users", db.GetSqlConnection);
                }
                else
                {
                    command.Connection = db.GetSqlConnection;
                }
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);
                dt.Columns[0].ColumnName = "User ID";
                dt.Columns[3].ColumnName = "Full Name";
                dt.Columns[4].ColumnName = "DOB";
                dt.Columns[5].ColumnName = "Sex";
                dt.Columns[6].ColumnName = "Phone";
                dt.Columns[7].ColumnName = "Address";
                dt.Columns[8].ColumnName = "Role";  //Xử lý chỗ này


                return dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool updateUsers(int userid, string fullname, DateTime DOB, bool sex, int phone, string address, string role)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            SqlCommand command = new SqlCommand("Edit_User_Admin", db.GetSqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = fullname;
            command.Parameters.Add("@dob", SqlDbType.DateTime).Value = DOB;
            command.Parameters.Add("@sex", SqlDbType.Bit).Value = sex;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@role", SqlDbType.NChar).Value = role;


            //if success
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool deleteUsers(int userid)
        {
            DB_Config db = new DB_Config();
            db.openConnection();
            SqlCommand command = new SqlCommand("Delete_User", db.GetSqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;

            //if success
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
