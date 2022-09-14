using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = Username_tbx;
        }

        DB_Config db = new DB_Config();

        public TextBox Username_TBX
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

        public TextBox Password_TBX
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

        public RadioButton FullAccessAdminType
        {
            get
            {
                return this.FullAccessAdmin_rdb;
            }
            set
            {
                this.FullAccessAdmin_rdb = value;
            }
        }

        public RadioButton LibrarianType
        {
            get
            {
                return this.Librarian_rdb;
            }
            set
            {
                this.Librarian_rdb = value;
            }
        }

        public RadioButton ManagerType
        {
            get
            {
                return this.Manager_rdb;
            }
            set
            {
                this.Manager_rdb = value;
            }
        }

        private void Login_btn_Click
            (object sender, EventArgs e)
        {
            //nếu mở kết nối db thành công thì thực hiện câu lệnh truy vấn
            if (Username_tbx.Text != "" && Password_tbx.Text != "" && (Librarian_rdb.Checked == true || Manager_rdb.Checked == true || Admin_rdb.Checked == true || FullAccessAdmin_rdb.Checked == true))
            {

                db.openConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db.GetSqlConnection;

                String usertype = "";
                if (Admin_rdb.Checked == true)
                    usertype = "ADMIN";
                else if (FullAccessAdmin_rdb.Checked == true)
                    usertype = "FULLACCESSADMIN";
                else if (Librarian_rdb.Checked == true)
                    usertype = "LIBRARIAN";
                else usertype = "MANAGER";

                cmd.CommandText = "Get_User_Info_Login";   
                cmd.CommandType = CommandType.StoredProcedure;

                //Set username and password
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = this.Username_tbx.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = this.Password_tbx.Text;
                cmd.Parameters.Add("@role", SqlDbType.NChar).Value = usertype;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    Dashboard dsb = new Dashboard();
                    dsb.GetUserName.Text = this.Username_tbx.Text;
                    dsb.GetUserType.Text = usertype;
                    dsb.Show();                   
                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Wrong Password or Wrong User Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Missing info please try again !!!", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                db.closeConnection();
            }

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm res = new RegistrationForm();
            res.Show();
        }

    }
}
