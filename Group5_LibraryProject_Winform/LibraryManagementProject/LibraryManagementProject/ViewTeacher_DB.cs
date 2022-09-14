using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    class ViewTeacher_DB
    {
        public DataTable getTeacherData(SqlCommand command)
        {
            DB_Config db = new DB_Config();
            DataTable dt = new DataTable();

            try
            {
                //No command then select all from book table
                if (command == null)
                {
                    command = new SqlCommand("Select * from teacher", db.GetSqlConnection);
                }
                else
                {
                    command.Connection = db.GetSqlConnection;
                }
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);
                dt.Columns[0].ColumnName = "Teacher ID";
                dt.Columns[1].ColumnName = "Full Name";
                dt.Columns[2].ColumnName = "DOB";
                dt.Columns[3].ColumnName = "Sex";
                dt.Columns[4].ColumnName = "Phone";
                dt.Columns[5].ColumnName = "Address";

                return dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool updateTeacher(int teacherid, string fullname, DateTime DOB, bool sex, int phone, string address)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using (SqlCommand cmd = new SqlCommand("Edit_Teacher_Detail", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = teacherid;
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = fullname;
                cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = DOB;
                cmd.Parameters.Add("@sex", SqlDbType.Bit).Value = sex;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;

                //if success
                if ((cmd.ExecuteNonQuery() == 1))
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

        public bool deleteTeacher(int teacherid)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using (SqlCommand cmd = new SqlCommand("Delete_Teacher_Detail", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = teacherid;

                //if success
                if ((cmd.ExecuteNonQuery() == 1))
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
}
