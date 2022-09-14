
namespace LibraryManagementProject
{
    partial class ViewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.Viewuser_dgv = new System.Windows.Forms.DataGridView();
            this.Sex_cbx = new System.Windows.Forms.ComboBox();
            this.pl1 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.dob_dtp = new System.Windows.Forms.DateTimePicker();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.pl2 = new System.Windows.Forms.Panel();
            this.Role_cbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Address_tbx = new System.Windows.Forms.TextBox();
            this.Phone_tbx = new System.Windows.Forms.TextBox();
            this.RoleFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Viewuser_dgv)).BeginInit();
            this.pl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.pl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Refresh_btn.Location = new System.Drawing.Point(609, 185);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(90, 27);
            this.Refresh_btn.TabIndex = 19;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Viewuser_dgv
            // 
            this.Viewuser_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Viewuser_dgv.BackgroundColor = System.Drawing.Color.Yellow;
            this.Viewuser_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Viewuser_dgv.GridColor = System.Drawing.Color.MistyRose;
            this.Viewuser_dgv.Location = new System.Drawing.Point(9, 232);
            this.Viewuser_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Viewuser_dgv.Name = "Viewuser_dgv";
            this.Viewuser_dgv.RowHeadersWidth = 62;
            this.Viewuser_dgv.RowTemplate.Height = 33;
            this.Viewuser_dgv.Size = new System.Drawing.Size(1008, 249);
            this.Viewuser_dgv.TabIndex = 17;
            this.Viewuser_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Viewuser_dgv_CellClick);
            // 
            // Sex_cbx
            // 
            this.Sex_cbx.FormattingEnabled = true;
            this.Sex_cbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex_cbx.Location = new System.Drawing.Point(239, 145);
            this.Sex_cbx.Name = "Sex_cbx";
            this.Sex_cbx.Size = new System.Drawing.Size(239, 28);
            this.Sex_cbx.TabIndex = 36;
            // 
            // pl1
            // 
            this.pl1.BackColor = System.Drawing.Color.White;
            this.pl1.Controls.Add(this.lbl2);
            this.pl1.Controls.Add(this.lbl1);
            this.pl1.Controls.Add(this.pbx1);
            this.pl1.Location = new System.Drawing.Point(9, 10);
            this.pl1.Margin = new System.Windows.Forms.Padding(2);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(1008, 157);
            this.pl1.TabIndex = 13;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(606, 78);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 35);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Users";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(606, 30);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 35);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "View";
            // 
            // pbx1
            // 
            this.pbx1.Image = global::LibraryManagementProject.Properties.Resources.teamwork;
            this.pbx1.Location = new System.Drawing.Point(373, 0);
            this.pbx1.Margin = new System.Windows.Forms.Padding(2);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(177, 157);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl9.Location = new System.Drawing.Point(285, 189);
            this.lbl9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(50, 19);
            this.lbl9.TabIndex = 14;
            this.lbl9.Text = "Role:";
            // 
            // dob_dtp
            // 
            this.dob_dtp.Location = new System.Drawing.Point(239, 103);
            this.dob_dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dob_dtp.Name = "dob_dtp";
            this.dob_dtp.Size = new System.Drawing.Size(239, 27);
            this.dob_dtp.TabIndex = 35;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cancel_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel_btn.Location = new System.Drawing.Point(803, 202);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(90, 27);
            this.Cancel_btn.TabIndex = 34;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Delete_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.Location = new System.Drawing.Point(680, 202);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(90, 27);
            this.Delete_btn.TabIndex = 33;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_btn.Location = new System.Drawing.Point(554, 202);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(90, 27);
            this.Update_btn.TabIndex = 32;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl7.Location = new System.Drawing.Point(527, 105);
            this.lbl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(74, 19);
            this.lbl7.TabIndex = 30;
            this.lbl7.Text = "Address";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl6.Location = new System.Drawing.Point(527, 63);
            this.lbl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(59, 19);
            this.lbl6.TabIndex = 29;
            this.lbl6.Text = "Phone";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(74, 149);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(38, 19);
            this.lbl5.TabIndex = 28;
            this.lbl5.Text = "Sex";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(74, 105);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(107, 19);
            this.lbl4.TabIndex = 27;
            this.lbl4.Text = "Date of birth";
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(239, 58);
            this.Name_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(239, 27);
            this.Name_tbx.TabIndex = 22;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(74, 58);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 19);
            this.lbl3.TabIndex = 21;
            this.lbl3.Text = "Name";
            // 
            // pl2
            // 
            this.pl2.BackColor = System.Drawing.Color.Yellow;
            this.pl2.Controls.Add(this.Role_cbx);
            this.pl2.Controls.Add(this.Sex_cbx);
            this.pl2.Controls.Add(this.dob_dtp);
            this.pl2.Controls.Add(this.Cancel_btn);
            this.pl2.Controls.Add(this.Delete_btn);
            this.pl2.Controls.Add(this.Update_btn);
            this.pl2.Controls.Add(this.lbl7);
            this.pl2.Controls.Add(this.label1);
            this.pl2.Controls.Add(this.lbl6);
            this.pl2.Controls.Add(this.lbl5);
            this.pl2.Controls.Add(this.lbl4);
            this.pl2.Controls.Add(this.Address_tbx);
            this.pl2.Controls.Add(this.Phone_tbx);
            this.pl2.Controls.Add(this.Name_tbx);
            this.pl2.Controls.Add(this.lbl3);
            this.pl2.Location = new System.Drawing.Point(9, 498);
            this.pl2.Margin = new System.Windows.Forms.Padding(2);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(1008, 273);
            this.pl2.TabIndex = 18;
            // 
            // Role_cbx
            // 
            this.Role_cbx.FormattingEnabled = true;
            this.Role_cbx.Items.AddRange(new object[] {
            "ADMIN",
            "FULLACCESSADMIN",
            "LIBRARIAN",
            "MANAGER"});
            this.Role_cbx.Location = new System.Drawing.Point(659, 145);
            this.Role_cbx.Name = "Role_cbx";
            this.Role_cbx.Size = new System.Drawing.Size(235, 28);
            this.Role_cbx.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(528, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Change Type";
            // 
            // Address_tbx
            // 
            this.Address_tbx.Location = new System.Drawing.Point(659, 100);
            this.Address_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Address_tbx.Name = "Address_tbx";
            this.Address_tbx.Size = new System.Drawing.Size(235, 27);
            this.Address_tbx.TabIndex = 26;
            // 
            // Phone_tbx
            // 
            this.Phone_tbx.Location = new System.Drawing.Point(659, 58);
            this.Phone_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Phone_tbx.Name = "Phone_tbx";
            this.Phone_tbx.Size = new System.Drawing.Size(235, 27);
            this.Phone_tbx.TabIndex = 25;
            // 
            // RoleFilter
            // 
            this.RoleFilter.FormattingEnabled = true;
            this.RoleFilter.Items.AddRange(new object[] {
            "ADMIN",
            "FULLACCESSADMIN",
            "LIBRARIAN",
            "MANAGER"});
            this.RoleFilter.Location = new System.Drawing.Point(340, 184);
            this.RoleFilter.Name = "RoleFilter";
            this.RoleFilter.Size = new System.Drawing.Size(235, 28);
            this.RoleFilter.TabIndex = 37;
            this.RoleFilter.TextChanged += new System.EventHandler(this.RoleFilter_TextChanged);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1027, 780);
            this.Controls.Add(this.RoleFilter);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.Viewuser_dgv);
            this.Controls.Add(this.pl1);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.pl2);
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Viewuser_dgv)).EndInit();
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.pl2.ResumeLayout(false);
            this.pl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.DataGridView Viewuser_dgv;
        private System.Windows.Forms.ComboBox Sex_cbx;
        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.DateTimePicker dob_dtp;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel pl2;
        private System.Windows.Forms.TextBox Address_tbx;
        private System.Windows.Forms.TextBox Phone_tbx;
        private System.Windows.Forms.ComboBox Role_cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoleFilter;
    }
}