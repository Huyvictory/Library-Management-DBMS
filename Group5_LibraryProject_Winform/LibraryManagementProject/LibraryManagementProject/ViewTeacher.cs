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
    public partial class Viewteacher : Form
    {
        public Viewteacher()
        {
            InitializeComponent();
        }

        ViewTeacher_DB db = new ViewTeacher_DB();
        private int teacher_id;
        private string full_name;
        private DateTime date_of_birthday;
        private string sex;
        private int phone;
        private string address;
        private DataGridViewRow currentSelectedRow;

        public void fillData_GridView(SqlCommand command)
        {
            //Don't allow user to modify datagridview
            Viewteacher_dgv.ReadOnly = true;

            DataTable dt = db.getTeacherData(command);
            if (dt != null)
            {
                Viewteacher_dgv.DataSource = dt;
                if (Viewteacher_dgv.Rows.Count > 0)
                {
                    Viewteacher_dgv.AllowUserToAddRows = false;
                }
            }
        }


        public void getDatafromDGV()
        {
            currentSelectedRow = Viewteacher_dgv.CurrentRow;
            teacher_id = Int32.Parse(Viewteacher_dgv.CurrentRow.Cells[0].Value.ToString());
            full_name = Viewteacher_dgv.CurrentRow.Cells[1].Value.ToString();
            date_of_birthday = DateTime.Parse(Viewteacher_dgv.CurrentRow.Cells[2].Value.ToString());
            sex = Viewteacher_dgv.CurrentRow.Cells[3].Value.ToString() == "True" ? "Male" : "Female";
            phone = Int32.Parse(Viewteacher_dgv.CurrentRow.Cells[4].Value.ToString());
            address = Viewteacher_dgv.CurrentRow.Cells[5].Value.ToString();
        }

        private void Viewteacher_Load(object sender, EventArgs e)
        {
            fillData_GridView(null);
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            SqlCommand searchbook = new SqlCommand("Select * from dbo.[Search_teacher](@Search_key_word)");
            searchbook.Parameters.AddWithValue("@Search_key_word", this.Enrollement_tbx.Text);
            fillData_GridView(searchbook);
        }
        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            fillData_GridView(null);
            this.Enrollement_tbx.Text = "";
        }

        private void Viewteacher_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDatafromDGV();
            this.Enrollement_tbx.Text = teacher_id.ToString();
            this.Name_tbx.Text = full_name;
            this.dob_dtp.Value = date_of_birthday;
            this.Sex_cbx.Text = sex;
            this.Phone_tbx.Text = phone.ToString();
            this.Address_tbx.Text = address;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try { 
                if (db.updateTeacher(Int32.Parse(this.Enrollement_tbx.Text), this.Name_tbx.Text, this.dob_dtp.Value, (this.Sex_cbx.Text == "Male" ? true : false), Int32.Parse(this.Phone_tbx.Text), this.Address_tbx.Text))
                {
                    MessageBox.Show("Teacher Info with id '%" + Int32.Parse(Enrollement_tbx.Text) + "%' updated", "Update teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillData_GridView(null);
                }
                else
                {
                    MessageBox.Show("There is something thing! Please check!", "Update teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Number: " + Ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete this teacher ?", "Delete teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string name_of_teacher = this.Name_tbx.Text;
                if (db.deleteTeacher(Int32.Parse(this.Enrollement_tbx.Text)))
                {
                    MessageBox.Show("Teacher'%" + name_of_teacher + "%' deleted", "Delete teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillData_GridView(null);
                    this.Enrollement_tbx.Text = "";
                    this.Name_tbx.Text = "";
                    this.dob_dtp.Value = DateTime.Now;
                    this.Sex_cbx.Text = "";
                    this.Phone_tbx.Text = "";
                    this.Address_tbx.Text = "";
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
    }
}
