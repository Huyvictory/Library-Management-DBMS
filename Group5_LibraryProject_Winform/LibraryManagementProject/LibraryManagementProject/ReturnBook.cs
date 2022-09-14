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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private int Userid;
        private int BookID;
        private DateTime ExpectedReturnDate;
        private int LendingID_User;
        private int LendingID_Book;
        Return_DB db = new Return_DB();

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

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            fillData_GridView(Lending_dgv, new SqlCommand("Select * from Select_Teacher_BorrowBook"));
            fillData_GridView(Lending_Detail_dgv, new SqlCommand("Select * from Select_All_LendingDetail"));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                fillData_GridView(Lending_dgv, new SqlCommand("select * from Select_Teacher_BorrowBook"));
                this.Schoolid_tbx.Text = "";
                this.Fullname_tbx.Text = "";
            }
            else
            {
                fillData_GridView(Lending_dgv, new SqlCommand("select * from Select_Student_BorrowBook"));
                this.Schoolid_tbx.Text = "";
                this.Fullname_tbx.Text = "";
            }
        }

        private void SearchStudent_btn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SqlCommand searchteacher_borrow = new SqlCommand("Select * from dbo.[Search_teacher_borrow](@teacherid, @fullname)");
                searchteacher_borrow.Parameters.AddWithValue("@teacherid", this.Schoolid_tbx.Text);
                searchteacher_borrow.Parameters.AddWithValue("@fullname", this.Fullname_tbx.Text);
                fillData_GridView(Lending_dgv, searchteacher_borrow);
            }
            else
            {
                SqlCommand searchstudent_borrow = new SqlCommand("Select * from dbo.[Search_student_borrow](@studentid, @fullname)");
                searchstudent_borrow.Parameters.AddWithValue("@studentid", this.Schoolid_tbx.Text);
                searchstudent_borrow.Parameters.AddWithValue("@fullname", this.Fullname_tbx.Text);
                fillData_GridView(Lending_dgv, searchstudent_borrow);
            }
        }

        private void SearchBook_btn_Click(object sender, EventArgs e)
        {
            SqlCommand searchbook_lendingdetail = new SqlCommand("Select * from dbo.[Search_Book_LendingDetail](@bookname, @number)");
            searchbook_lendingdetail.Parameters.AddWithValue("@bookname", this.BookName_tbx.Text);
            searchbook_lendingdetail.Parameters.AddWithValue("@number", this.Number_tbx.Text);
            fillData_GridView(Lending_Detail_dgv, searchbook_lendingdetail);
        }

        private void Lending_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.LendingID_User = Int32.Parse(Lending_dgv.CurrentRow.Cells[0].Value.ToString());
                this.Schoolid_tbx.Text = Lending_dgv.CurrentRow.Cells[3].Value.ToString();
                this.Fullname_tbx.Text = Lending_dgv.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                this.LendingID_User = Int32.Parse(Lending_dgv.CurrentRow.Cells[0].Value.ToString());
                this.Schoolid_tbx.Text = Lending_dgv.CurrentRow.Cells[2].Value.ToString();
                this.Fullname_tbx.Text = Lending_dgv.CurrentRow.Cells[4].Value.ToString();
            }
            
        }

        private void Lending_Detail_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LendingID_Book = Int32.Parse(Lending_Detail_dgv.CurrentRow.Cells[0].Value.ToString());
            this.BookID = Int32.Parse(Lending_Detail_dgv.CurrentRow.Cells[2].Value.ToString());
            this.BookName_tbx.Text = Lending_Detail_dgv.CurrentRow.Cells[3].Value.ToString();
            this.Number_tbx.Text = Lending_Detail_dgv.CurrentRow.Cells[4].Value.ToString();
            this.Lendingdate_dtp.Value = DateTime.Parse(Lending_Detail_dgv.CurrentRow.Cells[5].Value.ToString());
            this.ExpectedReturnDate = DateTime.Parse(Lending_Detail_dgv.CurrentRow.Cells[6].Value.ToString());
        }

        public int Calculatefinemoney()
        {
            if (this.expectedreturningdate_dtp.Value.Day - this.ExpectedReturnDate.Day <= 0)
            {
                return 0;
            }

            else if (this.expectedreturningdate_dtp.Value.Day - this.ExpectedReturnDate.Day >=1 && this.expectedreturningdate_dtp.Value.Day - this.ExpectedReturnDate.Day <= 7)
            {
                return 100000;
            }
            else
            {
                return 200000;
            }
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (this.LendingID_User == this.LendingID_Book)
            {
                try
                {
                    if (Int32.Parse(Lending_Detail_dgv.CurrentRow.Cells[4].Value.ToString()) == Int32.Parse(this.Number_tbx.Text) && Int32.Parse(this.Number_tbx.Text) > 0)
                    {
                        if (db.deleteUser_Lending(this.LendingID_User))
                        {

                        }

                        if (db.deleteBook_Lending(this.LendingID_Book))
                        {
                            fillData_GridView(Lending_Detail_dgv, new SqlCommand("Select * from Select_All_LendingDetail"));
                        }

                        if (db.Add_Returning_Detail(Int32.Parse(this.Schoolid_tbx.Text), BookID, this.BookName_tbx.Text, Int32.Parse(this.Number_tbx.Text), this.Lendingdate_dtp.Value, this.ExpectedReturnDate, this.expectedreturningdate_dtp.Value, Calculatefinemoney()))
                        {
                            if (checkBox1.Checked)
                            {
                                fillData_GridView(Lending_dgv, new SqlCommand("Select * from Select_Teacher_BorrowBook"));
                                MessageBox.Show("Teacher returned", "ReturnBook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            else
                            {
                                fillData_GridView(Lending_dgv, new SqlCommand("Select * from Select_Student_BorrowBook"));
                                MessageBox.Show("Student returned", "ReturnBook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            MessageBox.Show("Book returned", "ReturnBook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Schoolid_tbx.Text = "";
                            this.Fullname_tbx.Text = "";
                            this.BookName_tbx.Text = "";
                            this.Number_tbx.Text = "";
                            this.Lendingdate_dtp.Value = DateTime.Now;
                            this.expectedreturningdate_dtp.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("There is something wrong! Please check", "ReturnBook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Int32.Parse(Lending_Detail_dgv.CurrentRow.Cells[4].Value.ToString()) > Int32.Parse(this.Number_tbx.Text))
                    {
                        if (db.updateBook_Lending(this.LendingID_Book, Int32.Parse(this.Number_tbx.Text)))
                        {
                            fillData_GridView(Lending_Detail_dgv, new SqlCommand("Select * from lendingdetail"));
                            fillData_GridView(Lending_dgv, new SqlCommand("Select * from lending"));

                        }

                        //if (db.Update_Returning_Detail(this.LendingID_Book, Int32.Parse(this.Number_tbx.Text)))
                        if (db.Add_Returning_Detail(Int32.Parse(this.Schoolid_tbx.Text), BookID, this.BookName_tbx.Text, Int32.Parse(this.Number_tbx.Text), this.Lendingdate_dtp.Value, this.ExpectedReturnDate, this.expectedreturningdate_dtp.Value, Calculatefinemoney()))
                        {
                            MessageBox.Show("Book returned", "ReturnBook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Schoolid_tbx.Text = "";
                            this.Fullname_tbx.Text = "";
                            this.BookName_tbx.Text = "";
                            this.Number_tbx.Text = "";
                            this.Lendingdate_dtp.Value = DateTime.Now;
                            this.expectedreturningdate_dtp.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("There is something wrong! Please check", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid number of returning books", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Number: " + Ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                MessageBox.Show("The information is not match!", "ReturnBook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
