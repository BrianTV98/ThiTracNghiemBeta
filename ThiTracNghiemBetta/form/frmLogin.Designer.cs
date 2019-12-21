namespace ThiTracNghiemBetta.form
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.tN_CSDLPTDataSet = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.edtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.chitietbaithiTableAdapter1 = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.CHITIETBAITHITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cbbCoSo.DisplayMember = "TENCN";
            this.cbbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(299, 151);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(238, 24);
            this.cbbCoSo.TabIndex = 1;
            this.cbbCoSo.ValueMember = "TENSERVER";
            this.cbbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbbCoSo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.edtPassword);
            this.groupBox1.Controls.Add(this.edtUserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbCoSo);
            this.groupBox1.Location = new System.Drawing.Point(41, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 462);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(299, 329);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(153, 39);
            this.btnDangNhap.TabIndex = 11;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // edtPassword
            // 
            this.edtPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.edtPassword.Location = new System.Drawing.Point(299, 267);
            this.edtPassword.MaxLength = 16;
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.Size = new System.Drawing.Size(238, 22);
            this.edtPassword.TabIndex = 7;
            this.edtPassword.Text = "456";
            // 
            // edtUserName
            // 
            this.edtUserName.Location = new System.Drawing.Point(299, 210);
            this.edtUserName.Name = "edtUserName";
            this.edtUserName.Size = new System.Drawing.Size(238, 22);
            this.edtUserName.TabIndex = 6;
            this.edtUserName.Text = "thien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cơ sở";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chitietbaithiTableAdapter1
            // 
            this.chitietbaithiTableAdapter1.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(826, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.TextBox edtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSetTableAdapters.CHITIETBAITHITableAdapter chitietbaithiTableAdapter1;
    }
}