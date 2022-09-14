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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        DB_Config db = new DB_Config();

        private void Register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int register_year = dob_dtp.Value.Year;
                int year_now = DateTime.Now.Year;
                int age_of_user = year_now - register_year;
                //All info received
                if (Username_tbx.Text != "" && Password_tbx.Text != "" && Fullname_tbx.Text != "" && (Male_rdb.Checked == true || Female_rdb.Checked == true) && age_of_user > 10  && Phone_tbx.Text != "" && Address_tbx.Text != "" && (this.Librarian_rdb.Checked == true || this.Manager_rdb.Checked == true || this.FullAccessAdmin_rdb.Checked == true))
                {
                    db.openConnection();

                    SqlCommand checkusername = new SqlCommand("Select dbo.[CheckDuplicateUsername](@Username)", db.GetSqlConnection);
                    checkusername.Parameters.AddWithValue("@Username", this.Username_tbx.Text);
                    string Checkamount = checkusername.ExecuteScalar().ToString();

                    int Actualamount = Int32.Parse(Checkamount);

                    //no duplicate password then allow to proceed
                    if(Actualamount <= 0)
                    {
                        using (SqlCommand cmd = new SqlCommand("Add_User", db.GetSqlConnection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.Username_tbx.Text;
                            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password_tbx.Text;
                            cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = this.Fullname_tbx.Text;
                            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = this.dob_dtp.Value;
                            cmd.Parameters.Add("@sex", SqlDbType.Bit).Value = Male_rdb.Checked ? true : false;
                            cmd.Parameters.Add("@phone", SqlDbType.Int).Value = Int64.Parse(this.Phone_tbx.Text);
                            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = this.Address_tbx.Text;
                            cmd.Parameters.Add("@role", SqlDbType.NChar).Value = Librarian_rdb.Checked ? "LIBRARIAN" : Manager_rdb.Checked ? "MANAGER" : "FULLACCESSADMIN";

                            SqlDataReader reader;
                            reader = cmd.ExecuteReader();
                            
                            if(reader.RecordsAffected > 0)
                            {
                                MessageBox.Show("Successful!", "Added new user successfully!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                db.closeConnection();
                                LoginForm res = new LoginForm();
                                res.Username_TBX.Text = this.Username_tbx.Text.ToString();
                                res.Password_TBX.Text = this.Password_tbx.Text.ToString();
                                res.FullAccessAdminType.Checked = this.FullAccessAdmin_rdb.Checked ? true : false;
                                res.LibrarianType.Checked = this.Librarian_rdb.Checked ? true : false;
                                res.ManagerType.Checked = this.Manager_rdb.Checked ? true : false;
                                this.Close();
                                res.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                db.closeConnection();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate username found please use another one!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Username_tbx.Text = "";
                        db.closeConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Missing info please try to fill out all of it or the age is invalid!", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Could not connect database please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm res = new LoginForm();
            res.Show();
        }
    }
}
