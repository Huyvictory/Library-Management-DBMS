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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        ViewUser_DB db = new ViewUser_DB();
        private int user_id;
        private string full_name;
        private DateTime date_of_birthday;
        private string sex;
        private int phone;
        private string address;
        private string role;
        private DataGridViewRow currentSelectedRow;

        public void fillData_GridView(SqlCommand command)
        {
            //Don't allow user to modify datagridview
            Viewuser_dgv.ReadOnly = true;

            DataTable dt = db.getUserData(command);
            if (dt != null)
            {
                Viewuser_dgv.DataSource = dt;
                if (Viewuser_dgv.Rows.Count > 0)
                {
                    Viewuser_dgv.AllowUserToAddRows = false;
                }
            }
        }


        public void getDatafromDGV()
        {
            currentSelectedRow = Viewuser_dgv.CurrentRow;
            user_id = Int32.Parse(Viewuser_dgv.CurrentRow.Cells[0].Value.ToString());
            full_name = Viewuser_dgv.CurrentRow.Cells[3].Value.ToString();
            date_of_birthday = DateTime.Parse(Viewuser_dgv.CurrentRow.Cells[4].Value.ToString());
            sex = Viewuser_dgv.CurrentRow.Cells[5].Value.ToString() == "True" ? "Male" : "Female";
            phone = Int32.Parse(Viewuser_dgv.CurrentRow.Cells[6].Value.ToString());
            address = Viewuser_dgv.CurrentRow.Cells[7].Value.ToString();
            role = Viewuser_dgv.CurrentRow.Cells[8].Value.ToString();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            fillData_GridView(null);
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            this.RoleFilter.Text = "";
        }

        private void Viewuser_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDatafromDGV();
            this.Name_tbx.Text = full_name;
            this.dob_dtp.Value = date_of_birthday;
            this.Sex_cbx.Text = sex;
            this.Phone_tbx.Text = phone.ToString();
            this.Address_tbx.Text = address;
            this.Role_cbx.Text = role;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (db.updateUsers(this.user_id, this.Name_tbx.Text, this.dob_dtp.Value, (this.Sex_cbx.Text == "Male" ? true : false), Int32.Parse(this.Phone_tbx.Text), this.Address_tbx.Text, this.Role_cbx.Text == "ADMIN" ? "ADMIN" : this.Role_cbx.Text == "FULLACCESSADMIN" ? "FULLACCESSADMIN" : this.Role_cbx.Text == "LIBRARIAN" ? "LIBRARIAN" : "MANAGER"))
            {
                MessageBox.Show("User with id '%" + this.user_id + "%' updated", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.RoleFilter.Text = this.Role_cbx.Text;
            }
            else
            {
                MessageBox.Show("There is something wrong! Please check!", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete this user ?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string name_of_user = this.Name_tbx.Text;
                if (db.deleteUsers(this.user_id))
                {
                    MessageBox.Show("User '%" + name_of_user + "%' deleted", "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.RoleFilter.Text = this.Role_cbx.Text;
                    this.Name_tbx.Text = "";
                    this.dob_dtp.Value = DateTime.Now;
                    this.Sex_cbx.Text = "";
                    this.Phone_tbx.Text = "";
                    this.Address_tbx.Text = "";
                    this.Role_cbx.Text = "";
                }
                else
                {
                    MessageBox.Show("There is something wrong! Please check!", "Delete teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Action terminated!", "Delete teacher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoleFilter_TextChanged(object sender, EventArgs e)
        {
            if (this.RoleFilter.Text == "ADMIN")
            {
                fillData_GridView(new SqlCommand("select * from ViewUsers_ADMIN"));
            }

            else if (this.RoleFilter.Text == "FULLACCESSADMIN")
            {
                fillData_GridView(new SqlCommand("select * from ViewUsers_FULLACCESSADMIN"));
            }

            else if (this.RoleFilter.Text == "LIBRARIAN")
            {
                fillData_GridView(new SqlCommand("select * from ViewUsers_LIBRARIAN"));
            }

            else if (this.RoleFilter.Text == "MANAGER")
            {
                fillData_GridView(new SqlCommand("select * from ViewUsers_MANAGER"));
            }
            else //empty combobox
            {
                fillData_GridView(null);
            }
        }
    }
}
