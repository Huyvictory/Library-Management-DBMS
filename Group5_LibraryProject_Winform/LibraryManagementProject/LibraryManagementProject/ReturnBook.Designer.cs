
namespace LibraryManagementProject
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.Lending_dgv = new System.Windows.Forms.DataGridView();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.pl1 = new System.Windows.Forms.Panel();
            this.Lending_Detail_dgv = new System.Windows.Forms.DataGridView();
            this.SearchStudent_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.Fullname_tbx = new System.Windows.Forms.TextBox();
            this.Schoolid_tbx = new System.Windows.Forms.TextBox();
            this.expectedreturningdate_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Number_tbx = new System.Windows.Forms.TextBox();
            this.Lendingdate_dtp = new System.Windows.Forms.DateTimePicker();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SearchBook_btn = new System.Windows.Forms.Button();
            this.BookName_tbx = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Lending_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.pl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lending_Detail_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lending_dgv
            // 
            this.Lending_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Lending_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Lending_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lending_dgv.Location = new System.Drawing.Point(11, 122);
            this.Lending_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lending_dgv.Name = "Lending_dgv";
            this.Lending_dgv.RowHeadersWidth = 51;
            this.Lending_dgv.RowTemplate.Height = 25;
            this.Lending_dgv.Size = new System.Drawing.Size(700, 280);
            this.Lending_dgv.TabIndex = 86;
            this.Lending_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lending_dgv_CellClick);
            // 
            // pbx1
            // 
            this.pbx1.Image = ((System.Drawing.Image)(resources.GetObject("pbx1.Image")));
            this.pbx1.Location = new System.Drawing.Point(391, 1);
            this.pbx1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(110, 104);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 54;
            this.pbx1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(524, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Returning Book";
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Confirm_btn.BackgroundImage = global::LibraryManagementProject.Properties.Resources.Picture1;
            this.Confirm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Confirm_btn.FlatAppearance.BorderSize = 0;
            this.Confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_btn.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm_btn.ForeColor = System.Drawing.Color.White;
            this.Confirm_btn.Location = new System.Drawing.Point(613, 714);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(217, 67);
            this.Confirm_btn.TabIndex = 87;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // pl1
            // 
            this.pl1.BackColor = System.Drawing.Color.White;
            this.pl1.Controls.Add(this.pbx1);
            this.pl1.Controls.Add(this.label2);
            this.pl1.Location = new System.Drawing.Point(11, 11);
            this.pl1.Margin = new System.Windows.Forms.Padding(2);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(1417, 105);
            this.pl1.TabIndex = 85;
            // 
            // Lending_Detail_dgv
            // 
            this.Lending_Detail_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Lending_Detail_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Lending_Detail_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lending_Detail_dgv.Location = new System.Drawing.Point(727, 122);
            this.Lending_Detail_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lending_Detail_dgv.Name = "Lending_Detail_dgv";
            this.Lending_Detail_dgv.RowHeadersWidth = 51;
            this.Lending_Detail_dgv.RowTemplate.Height = 25;
            this.Lending_Detail_dgv.Size = new System.Drawing.Size(700, 280);
            this.Lending_Detail_dgv.TabIndex = 83;
            this.Lending_Detail_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lending_Detail_dgv_CellClick);
            // 
            // SearchStudent_btn
            // 
            this.SearchStudent_btn.BackColor = System.Drawing.Color.White;
            this.SearchStudent_btn.BackgroundImage = global::LibraryManagementProject.Properties.Resources.Picture1;
            this.SearchStudent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchStudent_btn.FlatAppearance.BorderSize = 0;
            this.SearchStudent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchStudent_btn.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchStudent_btn.ForeColor = System.Drawing.Color.White;
            this.SearchStudent_btn.Location = new System.Drawing.Point(279, 208);
            this.SearchStudent_btn.Name = "SearchStudent_btn";
            this.SearchStudent_btn.Size = new System.Drawing.Size(147, 43);
            this.SearchStudent_btn.TabIndex = 59;
            this.SearchStudent_btn.Text = "Search";
            this.SearchStudent_btn.UseVisualStyleBackColor = false;
            this.SearchStudent_btn.Click += new System.EventHandler(this.SearchStudent_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SearchStudent_btn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl9);
            this.panel1.Controls.Add(this.Fullname_tbx);
            this.panel1.Controls.Add(this.Schoolid_tbx);
            this.panel1.Location = new System.Drawing.Point(11, 410);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 280);
            this.panel1.TabIndex = 82;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(354, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 24);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Yes, I\'m a teacher";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(115, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 28);
            this.label5.TabIndex = 57;
            this.label5.Text = "Are you a teacher?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 57;
            this.label3.Text = "Full name";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl9.Location = new System.Drawing.Point(115, 31);
            this.lbl9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(113, 28);
            this.lbl9.TabIndex = 51;
            this.lbl9.Text = "School Id";
            // 
            // Fullname_tbx
            // 
            this.Fullname_tbx.Location = new System.Drawing.Point(354, 80);
            this.Fullname_tbx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Fullname_tbx.Name = "Fullname_tbx";
            this.Fullname_tbx.Size = new System.Drawing.Size(234, 27);
            this.Fullname_tbx.TabIndex = 52;
            // 
            // Schoolid_tbx
            // 
            this.Schoolid_tbx.Location = new System.Drawing.Point(354, 34);
            this.Schoolid_tbx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Schoolid_tbx.Name = "Schoolid_tbx";
            this.Schoolid_tbx.Size = new System.Drawing.Size(234, 27);
            this.Schoolid_tbx.TabIndex = 52;
            // 
            // expectedreturningdate_dtp
            // 
            this.expectedreturningdate_dtp.Location = new System.Drawing.Point(308, 170);
            this.expectedreturningdate_dtp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.expectedreturningdate_dtp.Name = "expectedreturningdate_dtp";
            this.expectedreturningdate_dtp.Size = new System.Drawing.Size(301, 27);
            this.expectedreturningdate_dtp.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Returning Date";
            // 
            // Number_tbx
            // 
            this.Number_tbx.Location = new System.Drawing.Point(308, 77);
            this.Number_tbx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Number_tbx.Name = "Number_tbx";
            this.Number_tbx.Size = new System.Drawing.Size(301, 27);
            this.Number_tbx.TabIndex = 42;
            // 
            // Lendingdate_dtp
            // 
            this.Lendingdate_dtp.Location = new System.Drawing.Point(308, 126);
            this.Lendingdate_dtp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Lendingdate_dtp.Name = "Lendingdate_dtp";
            this.Lendingdate_dtp.Size = new System.Drawing.Size(301, 27);
            this.Lendingdate_dtp.TabIndex = 41;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(117, 77);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(104, 28);
            this.lbl5.TabIndex = 40;
            this.lbl5.Text = "Number ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(117, 126);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(155, 28);
            this.lbl4.TabIndex = 39;
            this.lbl4.Text = "Lending Date";
            // 
            // SearchBook_btn
            // 
            this.SearchBook_btn.BackColor = System.Drawing.Color.White;
            this.SearchBook_btn.BackgroundImage = global::LibraryManagementProject.Properties.Resources.Picture1;
            this.SearchBook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBook_btn.FlatAppearance.BorderSize = 0;
            this.SearchBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBook_btn.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBook_btn.ForeColor = System.Drawing.Color.White;
            this.SearchBook_btn.Location = new System.Drawing.Point(292, 208);
            this.SearchBook_btn.Name = "SearchBook_btn";
            this.SearchBook_btn.Size = new System.Drawing.Size(147, 43);
            this.SearchBook_btn.TabIndex = 47;
            this.SearchBook_btn.Text = "Search";
            this.SearchBook_btn.UseVisualStyleBackColor = false;
            this.SearchBook_btn.Click += new System.EventHandler(this.SearchBook_btn_Click);
            // 
            // BookName_tbx
            // 
            this.BookName_tbx.Location = new System.Drawing.Point(308, 24);
            this.BookName_tbx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BookName_tbx.Name = "BookName_tbx";
            this.BookName_tbx.Size = new System.Drawing.Size(301, 27);
            this.BookName_tbx.TabIndex = 38;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(114, 24);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(137, 28);
            this.lbl3.TabIndex = 37;
            this.lbl3.Text = "Book Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.SearchBook_btn);
            this.panel2.Controls.Add(this.expectedreturningdate_dtp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Number_tbx);
            this.panel2.Controls.Add(this.Lendingdate_dtp);
            this.panel2.Controls.Add(this.lbl5);
            this.panel2.Controls.Add(this.lbl4);
            this.panel2.Controls.Add(this.BookName_tbx);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Location = new System.Drawing.Point(727, 410);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 280);
            this.panel2.TabIndex = 84;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1439, 793);
            this.Controls.Add(this.Lending_dgv);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.pl1);
            this.Controls.Add(this.Lending_Detail_dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lending_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lending_Detail_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Lending_dgv;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.DataGridView Lending_Detail_dgv;
        private System.Windows.Forms.Button SearchStudent_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox Fullname_tbx;
        private System.Windows.Forms.TextBox Schoolid_tbx;
        private System.Windows.Forms.DateTimePicker expectedreturningdate_dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number_tbx;
        private System.Windows.Forms.DateTimePicker Lendingdate_dtp;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button SearchBook_btn;
        private System.Windows.Forms.TextBox BookName_tbx;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}