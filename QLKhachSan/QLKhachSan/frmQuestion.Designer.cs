namespace QLKhachSan
{
    partial class frmQuestion
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
            this.btReloadLogin = new System.Windows.Forms.Button();
            this.btThoatQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn có muốn đăng nhập bằng một tài khoản khác??";
            // 
            // btReloadLogin
            // 
            this.btReloadLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReloadLogin.Location = new System.Drawing.Point(32, 88);
            this.btReloadLogin.Name = "btReloadLogin";
            this.btReloadLogin.Size = new System.Drawing.Size(85, 30);
            this.btReloadLogin.TabIndex = 1;
            this.btReloadLogin.Text = "Đồng ý";
            this.btReloadLogin.UseVisualStyleBackColor = true;
            this.btReloadLogin.Click += new System.EventHandler(this.btReloadLogin_Click);
            // 
            // btThoatQuestion
            // 
            this.btThoatQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoatQuestion.Location = new System.Drawing.Point(139, 88);
            this.btThoatQuestion.Name = "btThoatQuestion";
            this.btThoatQuestion.Size = new System.Drawing.Size(85, 30);
            this.btThoatQuestion.TabIndex = 1;
            this.btThoatQuestion.Text = "Thoát";
            this.btThoatQuestion.UseVisualStyleBackColor = true;
            this.btThoatQuestion.Click += new System.EventHandler(this.btThoatQuestion_Click);
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.btThoatQuestion);
            this.Controls.Add(this.btReloadLogin);
            this.Controls.Add(this.label1);
            this.Name = "frmQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReloadLogin;
        private System.Windows.Forms.Button btThoatQuestion;
    }
}