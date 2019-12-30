namespace ThiTracNghiemBetta.form.register
{
    partial class loginAuthentication
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
            this.txtAuthentication = new System.Windows.Forms.Label();
            this.aut_lb_login = new System.Windows.Forms.Label();
            this.aut_lb_password = new System.Windows.Forms.Label();
            this.aut_btn_aut = new System.Windows.Forms.Button();
            this.aut_txt_login = new DevExpress.XtraEditors.TextEdit();
            this.aut_txt_passw = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.aut_txt_login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aut_txt_passw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAuthentication
            // 
            this.txtAuthentication.AutoSize = true;
            this.txtAuthentication.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthentication.Location = new System.Drawing.Point(139, 71);
            this.txtAuthentication.Name = "txtAuthentication";
            this.txtAuthentication.Size = new System.Drawing.Size(522, 49);
            this.txtAuthentication.TabIndex = 0;
            this.txtAuthentication.Text = "XÁC THỰC ĐĂNG NHẬP";
            // 
            // aut_lb_login
            // 
            this.aut_lb_login.AutoSize = true;
            this.aut_lb_login.Location = new System.Drawing.Point(207, 182);
            this.aut_lb_login.Name = "aut_lb_login";
            this.aut_lb_login.Size = new System.Drawing.Size(51, 17);
            this.aut_lb_login.TabIndex = 1;
            this.aut_lb_login.Text = "Login :";
           
            // 
            // aut_lb_password
            // 
            this.aut_lb_password.AutoSize = true;
            this.aut_lb_password.Location = new System.Drawing.Point(207, 241);
            this.aut_lb_password.Name = "aut_lb_password";
            this.aut_lb_password.Size = new System.Drawing.Size(69, 17);
            this.aut_lb_password.TabIndex = 2;
            this.aut_lb_password.Text = "Password";
            // 
            // aut_btn_aut
            // 
            this.aut_btn_aut.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aut_btn_aut.Location = new System.Drawing.Point(315, 327);
            this.aut_btn_aut.Name = "aut_btn_aut";
            this.aut_btn_aut.Size = new System.Drawing.Size(134, 31);
            this.aut_btn_aut.TabIndex = 5;
            this.aut_btn_aut.Text = "Xac Nhận";
            this.aut_btn_aut.UseVisualStyleBackColor = true;
            this.aut_btn_aut.Click += new System.EventHandler(this.aut_btn_aut_Click);
            // 
            // aut_txt_login
            // 
            this.aut_txt_login.Location = new System.Drawing.Point(382, 182);
            this.aut_txt_login.Name = "aut_txt_login";
            this.aut_txt_login.Size = new System.Drawing.Size(179, 22);
            this.aut_txt_login.TabIndex = 6;
            // 
            // aut_txt_passw
            // 
            this.aut_txt_passw.Location = new System.Drawing.Point(382, 238);
            this.aut_txt_passw.Name = "aut_txt_passw";
            this.aut_txt_passw.Size = new System.Drawing.Size(179, 22);
            this.aut_txt_passw.TabIndex = 7;
            // 
            // loginAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 481);
            this.Controls.Add(this.aut_txt_passw);
            this.Controls.Add(this.aut_txt_login);
            this.Controls.Add(this.aut_btn_aut);
            this.Controls.Add(this.aut_lb_password);
            this.Controls.Add(this.aut_lb_login);
            this.Controls.Add(this.txtAuthentication);
            this.Name = "loginAuthentication";
            this.Text = "loginAuthentication";
           
            ((System.ComponentModel.ISupportInitialize)(this.aut_txt_login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aut_txt_passw.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAuthentication;
        private System.Windows.Forms.Label aut_lb_login;
        private System.Windows.Forms.Label aut_lb_password;
        private System.Windows.Forms.Button aut_btn_aut;
        private DevExpress.XtraEditors.TextEdit aut_txt_login;
        private DevExpress.XtraEditors.TextEdit aut_txt_passw;
    }
}