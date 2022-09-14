using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        public TextBox TeacherID
        {
            get
            {
                return this.Teacherid_tbx;
            }
            set
            {
                this.Teacherid_tbx = value;
            }
        }

        public TextBox TeacherName
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

        public DateTime DOB
        {
            get
            {
                return this.dob_dtp.Value;
            }
            set
            {
                this.dob_dtp.Value = value;
            }
        }

        public bool SEX
        {
            get
            {
                if (Male_rdb.Checked)
                {
                    return true;
                }
                return false;
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
                return this.Add_tbx;
            }
            set
            {
                this.Add_tbx = value;
            }
        }

        private bool no_blank()
        {
            int year_now = DateTime.Now.Year;
            int year_registered = dob_dtp.Value.Year;
            int age_of_user = year_now - year_registered;
            if (Teacherid_tbx.Text != "" && Name_tbx.Text != "" && age_of_user > 10 && (Male_rdb.Checked == true || Female_rdb.Checked == true) && Phone_tbx.Text != "" && Add_tbx.Text != "")
            {
                return true;
            }

            return false;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (no_blank())
            {
                try
                {
                    int testphone = Int32.Parse(Phone_tbx.Text);
                    Add_Info addteacher = new Add_Info();
                    //get from form then move to parameter then move to datatable
                    string teacherid = Teacherid_tbx.Text;
                    string teachername = Name_tbx.Text;
                    DateTime dob = dob_dtp.Value;
                    bool isMale = Male_rdb.Checked ? true : false;
                    string phone = Phone_tbx.Text;
                    string address = Add_tbx.Text;
                    if (addteacher.addTeacher(teacherid, teachername, dob, isMale, phone, address))
                    {
                        MessageBox.Show("Successful!", "Added new  teacher!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Error!", "There is something wrong, please check!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                catch (Exception Ex)
                {
                    MessageBox.Show("Number: " + Ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Missing info please try to fill out all of it or age is invalid !", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
