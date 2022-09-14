
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
    public partial class Dashboard : Form
    {

        DB_Config db = new DB_Config();
        private int UserID;
        private string Password;
        private string FullName;
        private DateTime Datetime;
        private bool Sex;
        private int Phone;
        private string Address;

        public Label GetUserName
        {
            get
            {
                return this.User_name;
            }
            set
            {
                this.User_name = value;
            }
        }

        public Label GetUserType
        {
            get
            {
                return this.User_Type;
            }
            set
            {
                this.User_Type = value;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        public DataTable getUserData(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection = db.GetSqlConnection;

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(dt);
            dt.Columns[0].ColumnName = "UserID";
            dt.Columns[1].ColumnName = "UserName";
            dt.Columns[2].ColumnName = "Password";
            dt.Columns[3].ColumnName = "FullName";
            dt.Columns[4].ColumnName = "DOB";
            dt.Columns[5].ColumnName = "Sex";
            dt.Columns[6].ColumnName = "Phone";
            dt.Columns[7].ColumnName = "Address";

            return dt;
        }

        private void Books_Click(object sender, EventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {
            ViewUser res = new ViewUser();
            res.Show();
        }
        private void Addbook_Click(object sender, EventArgs e)
        {
            AddBook res = new AddBook();
            res.Show();
        }

        private void Addstudent_Click(object sender, EventArgs e)
        {
            AddStudent res = new AddStudent();
            res.Show();
        }

        private void Addteacher_Click(object sender, EventArgs e)
        {
            AddTeacher res = new AddTeacher();
            res.Show();
        }

        private void Viewbooks_Click(object sender, EventArgs e)
        {
            ViewBook res = new ViewBook();
            res.Show();
        }

        private void Viewstudents_Click(object sender, EventArgs e)
        {
            ViewStudent res = new ViewStudent();
            res.Show();
        }

        private void Viewteachers_Click(object sender, EventArgs e)
        {
            Viewteacher res = new Viewteacher();
            res.Show();
        }

        private void BookLending_Click(object sender, EventArgs e)
        {
            Save_btn res = new Save_btn();
            res.UserID = UserID;
            res.Show();
        }

        private void BookReturning_Click(object sender, EventArgs e)
        {
            ReturnBook res = new ReturnBook();
            res.UserID = UserID;
            res.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm res = new LoginForm();
            res.Show();
        }
        private void UpdatePersonalInformation_Click(object sender, EventArgs e)
        {
            UpdatingForm res = new UpdatingForm();

            //update property of dashboard to new updated database then move to update form
            DataTable dt = getUserData(new SqlCommand("Select * from users where username like '%" + this.User_name.Text + "%'"));

            foreach (DataRow row in dt.AsEnumerable())
            {

                UserID = row.Field<int>("UserID");
                Password = row.Field<string>("Password");
                FullName = row.Field<string>("FullName");
                Datetime = row.Field<DateTime>("DOB");
                Sex = row.Field<bool>("Sex");
                Phone = row.Field<int>("Phone");
                Address = row.Field<string>("Address");
            }

            res.Get_User_Id = this.UserID;
            res.User_Name.Text = this.User_name.Text;
            res.User_Name.Enabled = false;
            res.Pass_word.Text = Password;
            res.Full_name.Text = FullName;
            res.RDB_Male.Checked = Sex ? true : false;
            res.RDB_Female.Checked = Sex ? false : true;
            res.DOB.Value = Datetime;
            res.Phone.Text = Phone.ToString();
            res.Address.Text = Address;

            res.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = getUserData(new SqlCommand("Select * from users where username like '%" + this.User_name.Text + "%'"));

                foreach (DataRow row in dt.AsEnumerable())
                {
                    UserID = row.Field<int>("UserID");
                    Password = row.Field<string>("Password");
                    FullName = row.Field<string>("FullName");
                    Datetime = row.Field<DateTime>("DOB");
                    Sex = row.Field<bool>("Sex");
                    Phone = row.Field<int>("Phone");
                    Address = row.Field<string>("Address");
                    
                }
                //Menu Items based on User Type
                if(this.User_Type.Text=="ADMIN")
                { 
                    this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] 
                    {
                        this.Books,
                        this.Students,
                        this.Teachers,
                        this.BookLending,
                        this.BookReturning,
                        this.UpdatePersonalInformation,
                        this.Users,
                        this.Logout
                    });
                }
                else if (this.User_Type.Text == "FULLACCESSADMIN")
                {
                    this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                    {
                        this.Books,
                        this.Students,
                        this.Teachers,
                        this.BookLending,
                        this.BookReturning,
                        this.UpdatePersonalInformation,
                        this.Logout
                    });
                }
                
                else if (this.User_Type.Text == "LIBRARIAN")
                {
                    this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                    {
                        this.Books,
                        this.UpdatePersonalInformation,
                        this.Logout
                    });
                }
                else {  //MANAGER 
                    this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                    {
                        this.Students,
                        this.Teachers,
                        this.UpdatePersonalInformation,
                        this.Logout
                    });
                }
                MessageBox.Show("Success on retrieving '" + this.User_name.Text + "' data", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch
            {
                MessageBox.Show("There is something wrong! Please check!", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
