namespace ThiTracNghiemBetta.form
{
    partial class frmRegisterUsers
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
            this.cb_nhom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupGV = new System.Windows.Forms.GroupBox();
            this.txt_infor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_confirm = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_maKhoa = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_MAGV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_login = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_confirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nhom
            // 
            this.cb_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nhom.FormattingEnabled = true;
            this.cb_nhom.Location = new System.Drawing.Point(250, 129);
            this.cb_nhom.Name = "cb_nhom";
            this.cb_nhom.Size = new System.Drawing.Size(224, 24);
            this.cb_nhom.TabIndex = 1;
            this.cb_nhom.SelectedIndexChanged += new System.EventHandler(this.cb_nhom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÓM";
            // 
            // groupGV
            // 
            this.groupGV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupGV.Controls.Add(this.button1);
            this.groupGV.Controls.Add(this.txt_infor);
            this.groupGV.Controls.Add(this.label8);
            this.groupGV.Controls.Add(this.txt_confirm);
            this.groupGV.Controls.Add(this.label7);
            this.groupGV.Controls.Add(this.btn_register);
            this.groupGV.Controls.Add(this.txt_maKhoa);
            this.groupGV.Controls.Add(this.cb_nhom);
            this.groupGV.Controls.Add(this.label1);
            this.groupGV.Controls.Add(this.label6);
            this.groupGV.Controls.Add(this.txt_name);
            this.groupGV.Controls.Add(this.label5);
            this.groupGV.Controls.Add(this.cb_MAGV);
            this.groupGV.Controls.Add(this.label4);
            this.groupGV.Controls.Add(this.txt_password);
            this.groupGV.Controls.Add(this.label3);
            this.groupGV.Controls.Add(this.txt_login);
            this.groupGV.Controls.Add(this.label2);
            this.groupGV.Location = new System.Drawing.Point(12, 12);
            this.groupGV.Name = "groupGV";
            this.groupGV.Size = new System.Drawing.Size(984, 534);
            this.groupGV.TabIndex = 1;
            this.groupGV.TabStop = false;
            this.groupGV.Enter += new System.EventHandler(this.groupGV_Enter);
            // 
            // txt_infor
            // 
            this.txt_infor.AutoSize = true;
            this.txt_infor.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_infor.ForeColor = System.Drawing.Color.Red;
            this.txt_infor.Location = new System.Drawing.Point(397, 439);
            this.txt_infor.Name = "txt_infor";
            this.txt_infor.Size = new System.Drawing.Size(126, 16);
            this.txt_infor.TabIndex = 13;
            this.txt_infor.Text = "Thông báo lỗi ở đây!";
            this.txt_infor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_infor.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(669, 68);
            this.label8.TabIndex = 12;
            this.label8.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(250, 376);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Properties.PasswordChar = '*';
            this.txt_confirm.Size = new System.Drawing.Size(224, 22);
            this.txt_confirm.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "CONFIRM";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(309, 475);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(140, 39);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "ĐĂNG KÝ";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_maKhoa
            // 
            this.txt_maKhoa.Enabled = false;
            this.txt_maKhoa.Location = new System.Drawing.Point(713, 232);
            this.txt_maKhoa.Name = "txt_maKhoa";
            this.txt_maKhoa.Size = new System.Drawing.Size(224, 22);
            this.txt_maKhoa.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(553, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "KHOA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(713, 184);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(224, 22);
            this.txt_name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(553, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "HO TEN";
            // 
            // cb_MAGV
            // 
            this.cb_MAGV.FormattingEnabled = true;
            this.cb_MAGV.Location = new System.Drawing.Point(250, 187);
            this.cb_MAGV.Name = "cb_MAGV";
            this.cb_MAGV.Size = new System.Drawing.Size(224, 24);
            this.cb_MAGV.TabIndex = 5;
            this.cb_MAGV.SelectedIndexChanged += new System.EventHandler(this.cb_MAGV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "MAGV";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(250, 318);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(224, 22);
            this.txt_password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(250, 255);
            this.txt_login.Name = "txt_login";
            this.txt_login.Properties.MaxLength = 20;
            this.txt_login.Size = new System.Drawing.Size(224, 22);
            this.txt_login.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "LOGIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegisterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 558);
            this.Controls.Add(this.groupGV);
            this.Name = "frmRegisterUsers";
            this.Text = "Đăng Ký";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegisterUsers_Load);
            this.groupGV.ResumeLayout(false);
            this.groupGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_confirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_nhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupGV;
        private System.Windows.Forms.Button btn_register;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_MAGV;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txt_maKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txt_confirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_infor;
        private System.Windows.Forms.Button button1;
    }
}