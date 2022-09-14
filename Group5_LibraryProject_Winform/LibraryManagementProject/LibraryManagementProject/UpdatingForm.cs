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
    public partial class UpdatingForm : Form
    {

        DB_Config db = new DB_Config();
        private string getusername;
        private int get_user_id;

        public int Get_User_Id
        {
            get
            {
                return this.get_user_id;
            }
            set
            {
                this.get_user_id = value;
            }
        }

        public TextBox User_Name
        {
            get
            {
                return this.Username_tbx;
            }
            set
            {
                this.Username_tbx = value;
            }
        }

        public TextBox Pass_word
        {
            get
            {
                return this.Password_tbx;
            }
            set
            {
                this.Password_tbx = value;
            }
        }

        public TextBox Full_name
        {
            get
            {
                return this.Fullname_tbx;
            }
            set
            {
                this.Fullname_tbx = value;
            }
        }

        public RadioButton RDB_Male
        {
            get
            {
                return this.Male_rdb;
            }
            set
            {
                this.Male_rdb = value;
            }
        }

        public RadioButton RDB_Female
        {
            get
            {
                return this.Female_rdb;
            }
            set
            {
                this.Female_rdb = value;
            }
        }

        public DateTimePicker DOB
        {
            get
            {
                return this.dob_dtp;
            }
            set
            {
                this.dob_dtp = value;
            }
        }

        public TextBox Phone
        {
            get
            {
                return this.Phone_tbx;
            }
            set
            {
                this.Phone_tbx = value;
            }
        }

        public TextBox Address
        {
            get
            {
                return this.Address_tbx;
            }
            set
            {
                this.Address_tbx = value;
            }
        }

        public UpdatingForm()
        {
            InitializeComponent();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            int register_year = dob_dtp.Value.Year;
            int year_now = DateTime.Now.Year;
            int age_of_user = year_now - register_year;
            db.openConnection();
            if (Username_tbx.Text != "" && Password_tbx.Text != "" && Fullname_tbx.Text != "" && (Male_rdb.Checked == true || Female_rdb.Checked == true) && age_of_user > 10 && Phone_tbx.Text != "" && Address_tbx.Text != "")
            {
                SqlCommand command = new SqlCommand("Edit_User", db.GetSqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@userid", SqlDbType.VarChar).Value = this.get_user_id;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password_tbx.Text;
                command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = this.Fullname_tbx.Text;
                command.Parameters.Add("@dob", SqlDbType.Date).Value = this.dob_dtp.Value;
                command.Parameters.Add("@sex", SqlDbType.Bit).Value = this.Male_rdb.Checked ? true : false;
                command.Parameters.Add("@phone", SqlDbType.Int).Value = Int64.Parse(this.Phone_tbx.Text);
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = this.Address_tbx.Text;

                if (command.ExecuteNonQuery() == 1)
                {
                    string username = this.Username_tbx.Text;
                    MessageBox.Show("Information of " + username + " updated", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.closeConnection();
                    this.Close();
                    LoginForm res = new LoginForm();
                    res.Show();
                }
                else
                {
                    MessageBox.Show("There is something wrong! Please check!", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeConnection();
                }

            }

            else
            {
                MessageBox.Show("Missing info please try to fill out all of it or the age is invalid!", "UpdateAdminInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
