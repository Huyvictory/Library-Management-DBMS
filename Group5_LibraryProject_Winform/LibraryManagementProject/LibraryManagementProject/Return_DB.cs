using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    class Return_DB
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

        public bool deleteUser_Lending(int lendingid)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            SqlCommand command = new SqlCommand("Delete_User_Lending", db.GetSqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@lendingid", SqlDbType.Int).Value = lendingid;

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

        public bool deleteBook_Lending(int lendingid)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            SqlCommand command = new SqlCommand("Delete_Book_Lending", db.GetSqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@lendingid", SqlDbType.Int).Value = lendingid;

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
        public bool updateBook_Lending(int lendingid, int number)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            SqlCommand command = new SqlCommand("update lendingdetail set number = number - @Number  where lendingid = @LendingID", db.GetSqlConnection);
            command.Parameters.Add("@LendingID", SqlDbType.Int).Value = lendingid;
            command.Parameters.Add("@Number", SqlDbType.Int).Value = number;

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
        public bool Add_Returning_Detail(int schoolid, int bookid, string bookname, int number, DateTime lendingdate, DateTime expecteddate, DateTime actualdate, int finemoney)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using (SqlCommand cmd = new SqlCommand("To_Returning_Detail", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Schoolid", SqlDbType.Int).Value = schoolid;
                cmd.Parameters.Add("@Bookid", SqlDbType.Int).Value = bookid;
                cmd.Parameters.Add("@Bookname", SqlDbType.NVarChar).Value = bookname;
                cmd.Parameters.Add("@Number", SqlDbType.Int).Value = number;
                cmd.Parameters.Add("@Lendingdate", SqlDbType.Date).Value = lendingdate;
                cmd.Parameters.Add("@Expectedreturningdate", SqlDbType.Date).Value = expecteddate;
                cmd.Parameters.Add("@Returningdate", SqlDbType.Date).Value = actualdate;
                cmd.Parameters.Add("@Finemoney", SqlDbType.Int).Value = finemoney;

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
