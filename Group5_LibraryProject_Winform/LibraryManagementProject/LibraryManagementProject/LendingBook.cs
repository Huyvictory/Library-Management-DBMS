using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public partial class Save_btn : Form
    {
        public Save_btn()
        {
            InitializeComponent();
        }

        private int Userid;
        private int BookID;
        LendingBook_DB db = new LendingBook_DB();

        public int UserID
        {
            get
            {
                return this.Userid;
            }
            set
            {
                this.Userid = value;
            }
        }

        public void fillData_GridView(DataGridView dgv, SqlCommand command)
        {
            //Don't allow user to modify datagridview
            dgv.ReadOnly = true;

            DataTable dt = db.getData(command);
            if (dt != null)
            {
                dgv.DataSource = dt;
                if (dgv.Rows.Count > 0)
                {
                    dgv.AllowUserToAddRows = false;
                }
            }
        }


        private void Save_btn_Load(object sender, EventArgs e)
        {
            fillData_GridView(Borrower_dgv, new SqlCommand("select * from Select_All_Teacher"));
            fillData_GridView(Book_dgv, new SqlCommand("select * from Select_All_Book"));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                fillData_GridView(Borrower_dgv, new SqlCommand("select * from Select_All_Teacher"));
                this.Schoolid_tbx.Text = "";
                this.Fullname_tbx.Text = "";
                this.Phone_tbx.Text = "";
            }
            else
            {
                fillData_GridView(Borrower_dgv, new SqlCommand("select * from Select_All_Student"));
                this.Schoolid_tbx.Text = "";
                this.Fullname_tbx.Text = "";
                this.Phone_tbx.Text = "";
            }
        }

        private void SearchStudent_btn_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                SqlCommand searchteacher_lending = new SqlCommand("Select * from dbo.[Search_teacher_lending](@teacherid, @fullname, @phone)");
                searchteacher_lending.Parameters.AddWithValue("@teacherid", this.Schoolid_tbx.Text);
                searchteacher_lending.Parameters.AddWithValue("@fullname", this.Fullname_tbx.Text);
                searchteacher_lending.Parameters.AddWithValue("@phone", this.Phone_tbx.Text);
                fillData_GridView(Borrower_dgv, searchteacher_lending);
            }
            else
            {
                SqlCommand searchstudent_lending = new SqlCommand("Select * from dbo.[Search_student_lending](@studentid, @fullname, @phone)");
                searchstudent_lending.Parameters.AddWithValue("@studentid", this.Schoolid_tbx.Text);
                searchstudent_lending.Parameters.AddWithValue("@fullname", this.Fullname_tbx.Text);
                searchstudent_lending.Parameters.AddWithValue("@phone", this.Phone_tbx.Text);
                fillData_GridView(Borrower_dgv, searchstudent_lending);
            }
        }

        private void SearchBook_btn_Click(object sender, EventArgs e)
        {
            SqlCommand searchbook_lending = new SqlCommand("Select * from dbo.[Search_book_lending](@bookname, @number)");
            searchbook_lending.Parameters.AddWithValue("@bookname", this.BookName_tbx.Text);
            searchbook_lending.Parameters.AddWithValue("@number", this.Number_tbx.Text);
            fillData_GridView(Book_dgv, searchbook_lending);
        }

        private void Borrower_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Schoolid_tbx.Text = Borrower_dgv.CurrentRow.Cells[0].Value.ToString();
            this.Fullname_tbx.Text = Borrower_dgv.CurrentRow.Cells[1].Value.ToString();
            this.Phone_tbx.Text = Borrower_dgv.CurrentRow.Cells[4].Value.ToString();
        }

        private void Book_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.BookID = Int32.Parse(Book_dgv.CurrentRow.Cells[0].Value.ToString());
            this.BookName_tbx.Text = Book_dgv.CurrentRow.Cells[2].Value.ToString();
            this.Number_tbx.Text = Book_dgv.CurrentRow.Cells[4].Value.ToString();
        }

        //private void Confirm_btn_Click(object sender, EventArgs e)
        //{
        //    int lendingdate = Lendingdate_dtp.Value.Day;
        //    int returningdate = expectedreturningdate_dtp.Value.Day;
        //    int daytoborrow = returningdate - lendingdate;
        //    //date of returning is less than 7 then not allowed 
        //    if(this.Schoolid_tbx.Text != "" && this.Fullname_tbx.Text != "" && this.Phone_tbx.Text != "" && this.BookName_tbx.Text != "" && this.Number_tbx.Text != "" && daytoborrow >= 7)
        //    {

        //        //For lending table
        //        if(checkBox1.Checked)
        //        {
        //            if (db.User_Lending_Detail_Teacher(this.Userid, Int32.Parse(this.Schoolid_tbx.Text), this.Fullname_tbx.Text)) 
        //            {
        //                MessageBox.Show("Successful!", "Added teacher's personal lending detail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //        else
        //        {
        //            if(db.User_Lending_Detail_Student(this.Userid, Int32.Parse(this.Schoolid_tbx.Text), this.Fullname_tbx.Text)) 
        //            {
        //                MessageBox.Show("Successful!", "Added student's personal lending detail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //        //For lending_detail table
        //        if(db.Book_Lending_Detail(Int32.Parse(this.Schoolid_tbx.Text), this.BookID, this.BookName_tbx.Text, int.Parse(this.Number_tbx.Text), Lendingdate_dtp.Value, expectedreturningdate_dtp.Value)) 
        //        {
        //            string user;
        //            if(checkBox1.Checked)
        //            {
        //                user = "teacher";
        //                MessageBox.Show("Successful!", "Added " + user +"'s personal book lending detail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            }
        //            else
        //            {
        //                user = "student";
        //                MessageBox.Show("Successful!", "Added " + user + "'s personal book lending detail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }                
        //    }
        //    else
        //    {
        //        MessageBox.Show("Missing info please try to fill out all of it or day to borrow is invalid !", "LendingBook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            int lendingdate = Lendingdate_dtp.Value.Day;
            int returningdate = expectedreturningdate_dtp.Value.Day;
            //int daytoborrow = returningdate - lendingdate;
            int daytoborrow = (expectedreturningdate_dtp.Value - Lendingdate_dtp.Value).Days;
            //date of returning is less than 7 then not allowed
            try
            {
                if (Int32.Parse(Book_dgv.CurrentRow.Cells[4].Value.ToString()) >= Int32.Parse(this.Number_tbx.Text) && Int32.Parse(this.Number_tbx.Text) > 0)
                {
                    if (daytoborrow >= 7)
                    {
                        if (this.Schoolid_tbx.Text != "" && this.Fullname_tbx.Text != "" && this.Phone_tbx.Text != "" && this.BookName_tbx.Text != "" && this.Number_tbx.Text != "")
                        {
                            //For lending_detail table
                            if (db.Book_Lending_Detail(Int32.Parse(this.Schoolid_tbx.Text), this.BookID, this.BookName_tbx.Text, int.Parse(this.Number_tbx.Text), Lendingdate_dtp.Value, expectedreturningdate_dtp.Value))
                            {
                                //For lending table
                                if (checkBox1.Checked)
                                {
                                    if (db.User_Lending_Detail_Teacher(this.Userid, Int32.Parse(this.Schoolid_tbx.Text), this.Fullname_tbx.Text))
                                    {
                                        MessageBox.Show("Successful!", "Added teacher's personal lending detail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (db.User_Lending_Detail_Student(this.Userid, Int32.Parse(this.Schoolid_tbx.Text), this.Fullname_tbx.Text))
                                    {
                                        MessageBox.Show("Successful!", "Added student's personal lending detail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                //fillData_GridView(Borrower_dgv, new SqlCommand("Select * from lendingdetail"));
                                fillData_GridView(Book_dgv, new SqlCommand("Select * from book"));
                            }
                            else
                            {
                                MessageBox.Show("Error!", "There is something wrong, please check!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else MessageBox.Show("Missing information! Please try to fill out all of it!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else MessageBox.Show("Time of lending must be at least 7 days", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Invalid number of lending books", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Number: " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
