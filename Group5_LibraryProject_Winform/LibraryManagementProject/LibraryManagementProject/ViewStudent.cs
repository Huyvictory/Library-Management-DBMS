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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        ViewStudent_DB db = new ViewStudent_DB();
        private int student_id;
        private string full_name;
        private DateTime date_of_birthday;
        private string sex;
        private int phone;
        private string address;
        private DataGridViewRow currentSelectedRow;

        public void fillData_GridView(SqlCommand command)
        {
            //Don't allow user to modify datagridview
            Viewstudent_dgv.ReadOnly = true;

            DataTable dt = db.getStudentData(command);
            if (dt != null)
            {
                Viewstudent_dgv.DataSource = dt;
                if (Viewstudent_dgv.Rows.Count > 0)
                {
                    Viewstudent_dgv.AllowUserToAddRows = false;
                }
            }
        }


        public void getDatafromDGV()
        {
            currentSelectedRow = Viewstudent_dgv.CurrentRow;
            student_id = Int32.Parse(Viewstudent_dgv.CurrentRow.Cells[0].Value.ToString());
            full_name = Viewstudent_dgv.CurrentRow.Cells[1].Value.ToString();
            date_of_birthday = DateTime.Parse(Viewstudent_dgv.CurrentRow.Cells[2].Value.ToString());
            sex = Viewstudent_dgv.CurrentRow.Cells[3].Value.ToString() == "True" ? "Male" : "Female";
            phone = Int32.Parse(Viewstudent_dgv.CurrentRow.Cells[4].Value.ToString());
            address = Viewstudent_dgv.CurrentRow.Cells[5].Value.ToString();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            fillData_GridView(null);
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            SqlCommand searchbook = new SqlCommand("Select * from dbo.[Search_student](@Search_key_word)");
            searchbook.Parameters.AddWithValue("@Search_key_word", this.Enrollement_tbx.Text);
            fillData_GridView(searchbook);
        }
        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            fillData_GridView(null);
            this.Enrollement_tbx.Text = "";
        }

        private void Viewstudent_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDatafromDGV();
            this.Enrollement_tbx.Text = student_id.ToString();
            this.Name_tbx.Text = full_name;
            this.dob_dtp.Value = date_of_birthday;
            this.Sex_cbx.Text = sex;
            this.Phone_tbx.Text = phone.ToString();
            this.Address_tbx.Text = address;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.updateStudent(Int32.Parse(this.Enrollement_tbx.Text), this.Name_tbx.Text, this.dob_dtp.Value, (this.Sex_cbx.Text == "Male" ? true : false), Int32.Parse(this.Phone_tbx.Text), this.Address_tbx.Text))
                {
                    MessageBox.Show("Student Info with id '%" + Int32.Parse(Enrollement_tbx.Text) + "%' updated", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillData_GridView(null);
                }
                else
                {
                    MessageBox.Show("There is something thing! Please check!", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Number: " + Ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete this student ?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string name_of_student = this.Name_tbx.Text;
                if (db.deleteStudent(Int32.Parse(this.Enrollement_tbx.Text)))
                {
                    MessageBox.Show("Student '%" + name_of_student + "%' deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("There is something wrong! Please check!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Action terminated!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
