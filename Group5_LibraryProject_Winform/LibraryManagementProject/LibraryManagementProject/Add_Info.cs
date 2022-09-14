using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    class Add_Info
    {
        public bool addTeacher(string TeacherID, string TeacherName, DateTime DOB, bool sex, string Phone, string Address)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            //try
            //{
            //        int test = Int32.Parse(Phone);
            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show("Number: " + Ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    db.closeConnection();

            //}

            using (SqlCommand cmd = new SqlCommand("Add_Teacher", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@teacherid", SqlDbType.Int).Value = Int64.Parse(TeacherID);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = TeacherName;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = DOB;
                cmd.Parameters.Add("@sex", SqlDbType.Bit).Value = sex;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = Int64.Parse(Phone);
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;

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

        public bool addStudent(string StudentID, string StudentName, DateTime DOB, bool sex, string Phone, string Address)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using(SqlCommand cmd = new SqlCommand("Add_Student", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@studentid", SqlDbType.Int).Value = Int64.Parse(StudentID);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = StudentName;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = DOB;
                cmd.Parameters.Add("@sex", SqlDbType.Bit).Value = sex;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = Int64.Parse(Phone);
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;

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

        public bool addBook(string BookType, string BookName, string Author, string BookNumber)
        {
            DB_Config db = new DB_Config();
            db.openConnection();

            using(SqlCommand cmd = new SqlCommand("Add_Book", db.GetSqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@booktype", SqlDbType.VarChar).Value = BookType;
                cmd.Parameters.Add("@bookname", SqlDbType.NVarChar).Value = BookName;
                cmd.Parameters.Add("@author", SqlDbType.NVarChar).Value = Author;
                cmd.Parameters.Add("@number", SqlDbType.Int).Value = Int64.Parse(BookNumber);

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
