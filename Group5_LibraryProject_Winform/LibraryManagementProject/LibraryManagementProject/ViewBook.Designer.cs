
namespace LibraryManagementProject
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.pl1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.bookname_tbx = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pl2 = new System.Windows.Forms.Panel();
            this.ID_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.Number_tbx = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Type_tbx = new System.Windows.Forms.TextBox();
            this.Author_tbx = new System.Windows.Forms.TextBox();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.bookview_dgv = new System.Windows.Forms.DataGridView();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.pl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.pl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookview_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pl1
            // 
            this.pl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pl1.Controls.Add(this.lbl1);
            this.pl1.Controls.Add(this.pbx1);
            this.pl1.Location = new System.Drawing.Point(2, 6);
            this.pl1.Margin = new System.Windows.Forms.Padding(2);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(598, 120);
            this.pl1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(300, 42);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(166, 35);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "View Book";
            // 
            // pbx1
            // 
            this.pbx1.Image = ((System.Drawing.Image)(resources.GetObject("pbx1.Image")));
            this.pbx1.Location = new System.Drawing.Point(162, 3);
            this.pbx1.Margin = new System.Windows.Forms.Padding(2);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(114, 117);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(11, 140);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(105, 22);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Book Name";
            // 
            // bookname_tbx
            // 
            this.bookname_tbx.Location = new System.Drawing.Point(150, 138);
            this.bookname_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.bookname_tbx.Name = "bookname_tbx";
            this.bookname_tbx.Size = new System.Drawing.Size(221, 27);
            this.bookname_tbx.TabIndex = 2;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_btn.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search_btn.Location = new System.Drawing.Point(398, 136);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(90, 29);
            this.Search_btn.TabIndex = 3;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 838);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // pl2
            // 
            this.pl2.BackColor = System.Drawing.Color.Lavender;
            this.pl2.Controls.Add(this.ID_lb);
            this.pl2.Controls.Add(this.label1);
            this.pl2.Controls.Add(this.lbl5);
            this.pl2.Controls.Add(this.Number_tbx);
            this.pl2.Controls.Add(this.lbl4);
            this.pl2.Controls.Add(this.Type_tbx);
            this.pl2.Controls.Add(this.Author_tbx);
            this.pl2.Controls.Add(this.Name_tbx);
            this.pl2.Controls.Add(this.lbl3);
            this.pl2.Controls.Add(this.Cancel_btn);
            this.pl2.Controls.Add(this.Delete_btn);
            this.pl2.Controls.Add(this.Update_btn);
            this.pl2.Location = new System.Drawing.Point(2, 470);
            this.pl2.Margin = new System.Windows.Forms.Padding(2);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(598, 261);
            this.pl2.TabIndex = 7;
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(21, 26);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(0, 20);
            this.ID_lb.TabIndex = 26;
            this.ID_lb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Number";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(94, 128);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(92, 19);
            this.lbl5.TabIndex = 25;
            this.lbl5.Text = "Book Type";
            // 
            // Number_tbx
            // 
            this.Number_tbx.Location = new System.Drawing.Point(273, 171);
            this.Number_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Number_tbx.Name = "Number_tbx";
            this.Number_tbx.Size = new System.Drawing.Size(226, 27);
            this.Number_tbx.TabIndex = 23;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(94, 77);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(157, 19);
            this.lbl4.TabIndex = 24;
            this.lbl4.Text = "Book Author Name";
            // 
            // Type_tbx
            // 
            this.Type_tbx.Location = new System.Drawing.Point(273, 125);
            this.Type_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Type_tbx.Name = "Type_tbx";
            this.Type_tbx.Size = new System.Drawing.Size(226, 27);
            this.Type_tbx.TabIndex = 23;
            // 
            // Author_tbx
            // 
            this.Author_tbx.Location = new System.Drawing.Point(273, 73);
            this.Author_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Author_tbx.Name = "Author_tbx";
            this.Author_tbx.Size = new System.Drawing.Size(226, 27);
            this.Author_tbx.TabIndex = 22;
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(273, 26);
            this.Name_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(226, 27);
            this.Name_tbx.TabIndex = 21;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(94, 29);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(99, 19);
            this.lbl3.TabIndex = 20;
            this.lbl3.Text = "Book Name";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cancel_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel_btn.Location = new System.Drawing.Point(410, 212);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(90, 27);
            this.Cancel_btn.TabIndex = 19;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Delete_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_btn.Location = new System.Drawing.Point(315, 212);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(90, 27);
            this.Delete_btn.TabIndex = 18;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_btn.Location = new System.Drawing.Point(221, 212);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(90, 27);
            this.Update_btn.TabIndex = 17;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // bookview_dgv
            // 
            this.bookview_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookview_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookview_dgv.BackgroundColor = System.Drawing.Color.Lavender;
            this.bookview_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookview_dgv.Location = new System.Drawing.Point(2, 179);
            this.bookview_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.bookview_dgv.Name = "bookview_dgv";
            this.bookview_dgv.RowHeadersWidth = 62;
            this.bookview_dgv.RowTemplate.Height = 33;
            this.bookview_dgv.Size = new System.Drawing.Size(598, 267);
            this.bookview_dgv.TabIndex = 4;
            this.bookview_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookview_dgv_CellClick);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh_btn.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refresh_btn.Location = new System.Drawing.Point(510, 136);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(90, 29);
            this.Refresh_btn.TabIndex = 3;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 742);
            this.Controls.Add(this.pl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookview_dgv);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.bookname_tbx);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewBook";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.pl2.ResumeLayout(false);
            this.pl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookview_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pl2;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox Type_tbx;
        private System.Windows.Forms.TextBox Author_tbx;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.DataGridView bookview_dgv;
        private System.Windows.Forms.TextBox bookname_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number_tbx;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Button Refresh_btn;
    }
}