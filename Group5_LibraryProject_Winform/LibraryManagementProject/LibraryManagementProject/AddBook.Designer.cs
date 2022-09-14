
namespace LibraryManagementProject
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.lbl1 = new System.Windows.Forms.Label();
            this.pl1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Type_tbx = new System.Windows.Forms.TextBox();
            this.Author_tbx = new System.Windows.Forms.TextBox();
            this.Name_tbx = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.pl2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Number_tbx = new System.Windows.Forms.TextBox();
            this.pl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(295, 46);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(154, 35);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Add Book";
            // 
            // pl1
            // 
            this.pl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pl1.Controls.Add(this.pictureBox1);
            this.pl1.Controls.Add(this.lbl1);
            this.pl1.Location = new System.Drawing.Point(10, 2);
            this.pl1.Margin = new System.Windows.Forms.Padding(2);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(567, 128);
            this.pl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(394, 220);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(82, 30);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "Cancel";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(300, 220);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 30);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "Save";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(85, 130);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(92, 19);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "Book Type";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(85, 86);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(157, 19);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Book Author Name";
            // 
            // Type_tbx
            // 
            this.Type_tbx.Location = new System.Drawing.Point(250, 130);
            this.Type_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Type_tbx.Name = "Type_tbx";
            this.Type_tbx.Size = new System.Drawing.Size(226, 27);
            this.Type_tbx.TabIndex = 5;
            // 
            // Author_tbx
            // 
            this.Author_tbx.Location = new System.Drawing.Point(250, 86);
            this.Author_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Author_tbx.Name = "Author_tbx";
            this.Author_tbx.Size = new System.Drawing.Size(226, 27);
            this.Author_tbx.TabIndex = 4;
            // 
            // Name_tbx
            // 
            this.Name_tbx.Location = new System.Drawing.Point(250, 38);
            this.Name_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Name_tbx.Name = "Name_tbx";
            this.Name_tbx.Size = new System.Drawing.Size(226, 27);
            this.Name_tbx.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(85, 38);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(99, 19);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Book Name";
            // 
            // pl2
            // 
            this.pl2.BackColor = System.Drawing.Color.Lavender;
            this.pl2.Controls.Add(this.btn3);
            this.pl2.Controls.Add(this.btn2);
            this.pl2.Controls.Add(this.lbl5);
            this.pl2.Controls.Add(this.label1);
            this.pl2.Controls.Add(this.lbl4);
            this.pl2.Controls.Add(this.Type_tbx);
            this.pl2.Controls.Add(this.Number_tbx);
            this.pl2.Controls.Add(this.Author_tbx);
            this.pl2.Controls.Add(this.Name_tbx);
            this.pl2.Controls.Add(this.lbl3);
            this.pl2.Location = new System.Drawing.Point(10, 145);
            this.pl2.Margin = new System.Windows.Forms.Padding(2);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(567, 279);
            this.pl2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number";
            // 
            // Number_tbx
            // 
            this.Number_tbx.Location = new System.Drawing.Point(250, 174);
            this.Number_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.Number_tbx.Name = "Number_tbx";
            this.Number_tbx.Size = new System.Drawing.Size(226, 27);
            this.Number_tbx.TabIndex = 4;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 433);
            this.Controls.Add(this.pl2);
            this.Controls.Add(this.pl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pl2.ResumeLayout(false);
            this.pl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox Type_tbx;
        private System.Windows.Forms.TextBox Author_tbx;
        private System.Windows.Forms.TextBox Name_tbx;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel pl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number_tbx;
    }
}