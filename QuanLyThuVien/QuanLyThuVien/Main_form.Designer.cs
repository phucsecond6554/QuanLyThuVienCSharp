namespace QuanLyThuVien
{
    partial class Main_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chucvu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.permssion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chao";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(102, 36);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(49, 13);
            this.Username.TabIndex = 0;
            this.Username.Text = "Xin chao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuc vu";
            // 
            // Chucvu
            // 
            this.Chucvu.AutoSize = true;
            this.Chucvu.Location = new System.Drawing.Point(102, 70);
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.Size = new System.Drawing.Size(47, 13);
            this.Chucvu.TabIndex = 0;
            this.Chucvu.Text = "Chuc vu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // permssion
            // 
            this.permssion.AutoSize = true;
            this.permssion.Location = new System.Drawing.Point(102, 112);
            this.permssion.Name = "permssion";
            this.permssion.Size = new System.Drawing.Size(35, 13);
            this.permssion.TabIndex = 2;
            this.permssion.Text = "label4";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.permssion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chucvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Chucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label permssion;
    }
}