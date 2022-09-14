using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        public TextBox BookType
        {
            get
            {
                return this.Type_tbx;
            }
            set
            {
                this.Type_tbx = value;
            }
        }

        public TextBox BookName
        {
            get
            {
                return this.Name_tbx;
            }
            set
            {
                this.Name_tbx = value;
            }
        }

        public TextBox BookAuthor
        {
            get
            {
                return this.Author_tbx;
            }
            set
            {
                this.Author_tbx = value;
            }
        }

        public TextBox GetNumber
        {
            get
            {
                return this.Name_tbx;
            }
            set
            {
                this.Name_tbx = value;
            }
        }

        private bool no_blank()
        {
            if (Type_tbx.Text != "" && Name_tbx.Text != "" && Author_tbx.Text != "" && this.Number_tbx.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string booktype = this.Type_tbx.Text;
            string bookname = this.Name_tbx.Text;
            string author = this.Author_tbx.Text;
            string booknumber = this.Number_tbx.Text;
            Add_Info addbook = new Add_Info();

            if (no_blank())
            {
                if (addbook.addBook(booktype, bookname, author, booknumber))
                {
                    MessageBox.Show("Successful!", "Added new book!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Missing info please try to fill out all of it!", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
