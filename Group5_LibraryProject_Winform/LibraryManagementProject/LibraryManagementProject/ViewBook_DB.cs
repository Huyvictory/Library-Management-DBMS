using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    class ViewBook_DB
    {
        public DataTable getBookData(SqlCommand command)
        {
            DB_Config db = new DB_Config();
            DataTable dt = new DataTable();

            try
            {
                //No command then select all from book table
                if (command == null)
                {
                    command = new SqlCommand("Select * from book", db.GetSqlConnection);
                }
                else
                {
                    command.Connection = db.GetSqlConnection;
                }
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);
                dt.Columns[0].ColumnName = "BookID";
                dt.Columns[1].ColumnName = "BookType";
                dt.Columns[2].ColumnName = "BookName";
                dt.Columns[3].ColumnName = "Author";
                dt.Columns[4].ColumnName = "BookNumber";
                return dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool updateBook(int bookid, string booktype, string bookname, string author, string booknumber)
        {
            DB_Config db = new DB_Config();
            db.openConnection();


            using (SqlCommand cmd = new SqlCommand("Edit_Book_Detail", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@bookid", SqlDbType.Int).Value = bookid;
                cmd.Parameters.Add("@booktype", SqlDbType.VarChar).Value = booktype;
                cmd.Parameters.Add("@bookname", SqlDbType.VarChar).Value = bookname;
                cmd.Parameters.Add("@author", SqlDbType.NVarChar).Value = author;
                cmd.Parameters.Add("@number", SqlDbType.Int).Value = Int32.Parse(booknumber);

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

        public bool deleteBook(int bookid)
        {
            DB_Config db = new DB_Config();
            db.openConnection();
            using (SqlCommand cmd = new SqlCommand("Delete_Book_Detail", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@bookid", SqlDbType.Int).Value = bookid;

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
