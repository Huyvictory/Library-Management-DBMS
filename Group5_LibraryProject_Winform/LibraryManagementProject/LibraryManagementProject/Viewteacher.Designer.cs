
namespace LibraryManagementProject
{
    partial class Viewteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewteacher));
            this.dob_dtp = new System.Windows.Forms.DateTimePicker();
            this.pl2 = new System.Windows.Forms.Panel();
            this.Sex_cbx = new System.Windows.Forms.ComboBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Address_tbx = new System.Windows.Forms.TextBox();
            this.Phone_tbx = new System.Windows.Forms.TextBox();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Enrollement_tbx = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pl1 = new System.Windows.Forms.Panel();
            this.Viewteacher_dgv = new System.Windows.Forms.DataGridView();
            this.lbl9 = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.pl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.pl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewteacher_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dob_dtp
            // 
            this.dob_dtp.Location = new System.Drawing.Point(239, 103);
            this.dob_dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dob_dtp.Name = "dob_dtp";
            this.dob_dtp.Size = new System.Drawing.Size(239, 27);
            this.dob_dtp.TabIndex = 35;
            // 
            // pl2
            // 
            this.pl2.BackColor = System.Drawing.Color.SpringGreen;
            this.pl2.Controls.Add(this.Sex_cbx);
            this.pl2.Controls.Add(this.dob_dtp);
            this.pl2.Controls.Add(this.Cancel_btn);
            this.pl2.Controls.Add(this.Delete_btn);
            this.pl2.Controls.Add(this.Update_btn);
            this.pl2.Controls.Add(this.lbl7);
            this.pl2.Controls.Add(this.lbl6);
            this.pl2.Controls.Add(this.lbl5);
            this.pl2.Controls.Add(this.lbl4);
            this.pl2.Controls.Add(this.Address_tbx);
            this.pl2.Controls.Add(this.Phone_tbx);
            this.pl2.Controls.Add(this.Name_tbx);
            this.pl2.Controls.Add(this.lbl3);
            this.pl2.Location = new System.Drawing.Point(10, 498);
            this.pl2.Margin = new System.Windows.Forms.Padding(2);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(1008, 273);
            this.pl2.TabIndex = 11;
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
            this.lbl3.Size = new System.Drawing.Size(120, 19);
            this.lbl3.TabIndex = 21;
            this.lbl3.Text = "Teacher Name";
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Search_btn.Location = new System.Drawing.Point(587, 185);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(90, 27);
            this.Search_btn.TabIndex = 9;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Enrollement_tbx
            // 
            this.Enrollement_tbx.Location = new System.Drawing.Point(349, 185);
            this.Enrollement_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Enrollement_tbx.Name = "Enrollement_tbx";
            this.Enrollement_tbx.Size = new System.Drawing.Size(217, 27);
            this.Enrollement_tbx.TabIndex = 8;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(606, 78);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(129, 35);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Teacher";
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
            this.pbx1.Image = ((System.Drawing.Image)(resources.GetObject("pbx1.Image")));
            this.pbx1.Location = new System.Drawing.Point(373, 0);
            this.pbx1.Margin = new System.Windows.Forms.Padding(2);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(177, 157);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // pl1
            // 
            this.pl1.BackColor = System.Drawing.Color.White;
            this.pl1.Controls.Add(this.lbl2);
            this.pl1.Controls.Add(this.lbl1);
            this.pl1.Controls.Add(this.pbx1);
            this.pl1.Location = new System.Drawing.Point(10, 10);
            this.pl1.Margin = new System.Windows.Forms.Padding(2);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(1008, 157);
            this.pl1.TabIndex = 6;
            // 
            // Viewteacher_dgv
            // 
            this.Viewteacher_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Viewteacher_dgv.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.Viewteacher_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Viewteacher_dgv.GridColor = System.Drawing.Color.MistyRose;
            this.Viewteacher_dgv.Location = new System.Drawing.Point(10, 232);
            this.Viewteacher_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.Viewteacher_dgv.Name = "Viewteacher_dgv";
            this.Viewteacher_dgv.RowHeadersWidth = 62;
            this.Viewteacher_dgv.RowTemplate.Height = 33;
            this.Viewteacher_dgv.Size = new System.Drawing.Size(1008, 249);
            this.Viewteacher_dgv.TabIndex = 10;
            this.Viewteacher_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Viewteacher_dgv_CellClick);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl9.Location = new System.Drawing.Point(249, 189);
            this.lbl9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(96, 19);
            this.lbl9.TabIndex = 7;
            this.lbl9.Text = "Teacher Id:";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Refresh_btn.Location = new System.Drawing.Point(692, 185);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(90, 27);
            this.Refresh_btn.TabIndex = 12;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Viewteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1027, 780);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.pl2);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Enrollement_tbx);
            this.Controls.Add(this.pl1);
            this.Controls.Add(this.Viewteacher_dgv);
            this.Controls.Add(this.lbl9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Viewteacher";
            this.Text = "Viewteacher";
            this.Load += new System.EventHandler(this.Viewteacher_Load);
            this.pl2.ResumeLayout(false);
            this.pl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewteacher_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dob_dtp;
        private System.Windows.Forms.Panel pl2;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox Address_tbx;
        private System.Windows.Forms.TextBox Phone_tbx;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Enrollement_tbx;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.DataGridView Viewteacher_dgv;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.ComboBox Sex_cbx;
        private System.Windows.Forms.Button Refresh_btn;
    }
}