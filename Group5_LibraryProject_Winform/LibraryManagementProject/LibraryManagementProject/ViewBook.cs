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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        ViewBook_DB db = new ViewBook_DB();
        private int book_id;
        private string book_name;
        private string book_author_name;
        private string book_type;
        private string book_number;
        private DataGridViewRow currentSelectedRow;

        public void fillData_GridView(SqlCommand command)
        {
            //Don't allow user to modify datagridview
            bookview_dgv.ReadOnly = true;

            DataTable dt = db.getBookData(command);
            if (dt != null)
            {
                bookview_dgv.DataSource = dt;
                if (bookview_dgv.Rows.Count > 0)
                {
                    bookview_dgv.AllowUserToAddRows = false;
                }
            }
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            fillData_GridView(null);
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            SqlCommand searchbook = new SqlCommand("Select * from dbo.[Search_book](@Search_key_word)");
            searchbook.Parameters.AddWithValue("@Search_key_word", this.bookname_tbx.Text);
            fillData_GridView(searchbook);
        }
        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            this.bookname_tbx.Text = "";
            fillData_GridView(new SqlCommand("Select * from book where bookname like '%" + bookname_tbx.Text + "%'"));
        }

        public void getDatafromDGV()
        {
            currentSelectedRow = bookview_dgv.CurrentRow;
            book_id = Int32.Parse(bookview_dgv.CurrentRow.Cells[0].Value.ToString());
            book_type = bookview_dgv.CurrentRow.Cells[1].Value.ToString();
            book_name = bookview_dgv.CurrentRow.Cells[2].Value.ToString();
            book_author_name = bookview_dgv.CurrentRow.Cells[3].Value.ToString();
            book_number = bookview_dgv.CurrentRow.Cells[4].Value.ToString();
        }

        private void bookview_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDatafromDGV();
            this.ID_lb.Text = book_id.ToString();
            this.Name_tbx.Text = book_name;
            this.Author_tbx.Text = book_author_name;
            this.Type_tbx.Text = book_type;
            this.Number_tbx.Text = book_number;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (db.updateBook(Int32.Parse(this.ID_lb.Text), this.Type_tbx.Text.ToString(), this.Name_tbx.Text.ToString(), this.Author_tbx.Text.ToString(), this.Number_tbx.Text.ToString()))
            {
                MessageBox.Show("Book Info updated", "Update book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillData_GridView(null);
            }
            else
            {
                MessageBox.Show("There is something thing! Please check!", "Update book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete this book ?", "Delete book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (db.deleteBook(Int32.Parse(this.ID_lb.Text)))
                {
                    MessageBox.Show("Book deleted", "Delete book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillData_GridView(null);
                    this.ID_lb.Text = "";
                    this.Name_tbx.Text = "";
                    this.Author_tbx.Text = "";
                    this.Type_tbx.Text = "";
                    this.Number_tbx.Text = "";
                }
                else
                {
                    MessageBox.Show("There is something thing! Please check!", "Delete book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Action terminated!", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
