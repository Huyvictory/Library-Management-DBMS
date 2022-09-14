using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    class LendingBook_DB
    {
        public DataTable getData(SqlCommand command)
        {
            DB_Config db = new DB_Config();
            DataTable dt = new DataTable();

            try
            {
                command.Connection = db.GetSqlConnection;
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);

                return dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool User_Lending_Detail_Teacher(int userid, int teacherid, string fullname)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using (SqlCommand cmd = new SqlCommand("Add_Teacher_Lending", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Userid", SqlDbType.Int).Value = userid;
                cmd.Parameters.Add("@Teacherid", SqlDbType.Int).Value = teacherid;
                cmd.Parameters.Add("@Fullname", SqlDbType.NVarChar).Value = fullname;

                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.RecordsAffected > 0)
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

        public bool User_Lending_Detail_Student(int userid, int studentid, string fullname)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using (SqlCommand cmd = new SqlCommand("Add_Student_Lending", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Userid", SqlDbType.Int).Value = userid;
                cmd.Parameters.Add("@Studentid", SqlDbType.Int).Value = studentid;
                cmd.Parameters.Add("@Fullname", SqlDbType.NVarChar).Value = fullname;

                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.RecordsAffected > 0)
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

        public bool Book_Lending_Detail(int schoolid, int bookid, string bookname, int number, DateTime lendingdate, DateTime returningdate)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using (SqlCommand cmd = new SqlCommand("Add_Book_Borrowed", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Schoolid", SqlDbType.Int).Value = schoolid;
                cmd.Parameters.Add("@Bookid", SqlDbType.Int).Value = bookid;
                cmd.Parameters.Add("@Bookname", SqlDbType.NVarChar).Value = bookname;
                cmd.Parameters.Add("@Number", SqlDbType.Int).Value = number;
                cmd.Parameters.Add("@Lendingdate", SqlDbType.Date).Value = lendingdate;
                cmd.Parameters.Add("@Returningdate", SqlDbType.Date).Value = returningdate;

                SqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.RecordsAffected > 0)
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
