namespace ThiTracNghiemBetta.form.examregistation
{
    partial class frmExamRegistration
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
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label label1;
            this.ds = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.bds_giaoVienDangKi = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.gr_dkthi = new System.Windows.Forms.GroupBox();
            this.cb_maLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_trinhdo = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txt_magv = new DevExpress.XtraEditors.TextEdit();
            this.spinEdit_thoigian = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_cauhoi = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_lanthi = new DevExpress.XtraEditors.SpinEdit();
            this.dt_ngaythi = new DevExpress.XtraEditors.DateEdit();
            this.lOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.cb_maMonHoc = new System.Windows.Forms.ComboBox();
            this.txt_validate = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_giaoVienDangKi)).BeginInit();
            this.gr_dkthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_magv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_thoigian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cauhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_lanthi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tHOIGIANLabel.Location = new System.Drawing.Point(158, 486);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(86, 16);
            tHOIGIANLabel.TabIndex = 31;
            tHOIGIANLabel.Text = "THỜI GIAN :";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOCAUTHILabel.Location = new System.Drawing.Point(158, 432);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(93, 16);
            sOCAUTHILabel.TabIndex = 29;
            sOCAUTHILabel.Text = "SỐ CÂU HỎI :";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lANLabel.Location = new System.Drawing.Point(158, 378);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(69, 16);
            lANLabel.TabIndex = 27;
            lANLabel.Text = "LẦN THI :";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYTHILabel.Location = new System.Drawing.Point(158, 324);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(80, 16);
            nGAYTHILabel.TabIndex = 25;
            nGAYTHILabel.Text = "NGÀY THI :";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRINHDOLabel.Location = new System.Drawing.Point(158, 270);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(81, 16);
            tRINHDOLabel.TabIndex = 23;
            tRINHDOLabel.Text = "TRÌNH ĐỘ :";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(158, 216);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(66, 16);
            mALOPLabel.TabIndex = 21;
            mALOPLabel.Text = "MÃ LỚP :";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(158, 162);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(105, 16);
            mAMHLabel.TabIndex = 19;
            mAMHLabel.Text = "MÃ MÔN HỌC :";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(158, 108);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(122, 16);
            mAGVLabel.TabIndex = 18;
            mAGVLabel.Text = "MÃ GIẢNG VIÊN :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(181, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(432, 68);
            label1.TabIndex = 34;
            label1.Text = "ĐĂNG KÝ THI";
            // 
            // ds
            // 
            this.ds.DataSetName = "TN_CSDLPTDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_giaoVienDangKi
            // 
            this.bds_giaoVienDangKi.DataMember = "GIAOVIEN_DANGKY";
            this.bds_giaoVienDangKi.DataSource = this.ds;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gr_dkthi
            // 
            this.gr_dkthi.Controls.Add(this.txt_validate);
            this.gr_dkthi.Controls.Add(this.cb_maMonHoc);
            this.gr_dkthi.Controls.Add(this.cb_maLop);
            this.gr_dkthi.Controls.Add(this.cb_trinhdo);
            this.gr_dkthi.Controls.Add(this.btnCancel);
            this.gr_dkthi.Controls.Add(this.btnRegister);
            this.gr_dkthi.Controls.Add(label1);
            this.gr_dkthi.Controls.Add(this.txt_magv);
            this.gr_dkthi.Controls.Add(tHOIGIANLabel);
            this.gr_dkthi.Controls.Add(this.spinEdit_thoigian);
            this.gr_dkthi.Controls.Add(sOCAUTHILabel);
            this.gr_dkthi.Controls.Add(this.spinEdit_cauhoi);
            this.gr_dkthi.Controls.Add(lANLabel);
            this.gr_dkthi.Controls.Add(this.spinEdit_lanthi);
            this.gr_dkthi.Controls.Add(nGAYTHILabel);
            this.gr_dkthi.Controls.Add(this.dt_ngaythi);
            this.gr_dkthi.Controls.Add(tRINHDOLabel);
            this.gr_dkthi.Controls.Add(mALOPLabel);
            this.gr_dkthi.Controls.Add(mAMHLabel);
            this.gr_dkthi.Controls.Add(mAGVLabel);
            this.gr_dkthi.Location = new System.Drawing.Point(22, 12);
            this.gr_dkthi.Name = "gr_dkthi";
            this.gr_dkthi.Size = new System.Drawing.Size(828, 603);
            this.gr_dkthi.TabIndex = 0;
            this.gr_dkthi.TabStop = false;
            this.gr_dkthi.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_maLop
            // 
            this.cb_maLop.DataSource = this.lOPBindingSource;
            this.cb_maLop.DisplayMember = "MALOP";
            this.cb_maLop.FormattingEnabled = true;
            this.cb_maLop.Location = new System.Drawing.Point(307, 208);
            this.cb_maLop.Name = "cb_maLop";
            this.cb_maLop.Size = new System.Drawing.Size(263, 24);
            this.cb_maLop.TabIndex = 39;
            this.cb_maLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.ds;
            // 
            // cb_trinhdo
            // 
            this.cb_trinhdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trinhdo.FormattingEnabled = true;
            this.cb_trinhdo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cb_trinhdo.Location = new System.Drawing.Point(307, 262);
            this.cb_trinhdo.Name = "cb_trinhdo";
            this.cb_trinhdo.Size = new System.Drawing.Size(263, 24);
            this.cb_trinhdo.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(415, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 34);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(229, 549);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 34);
            this.btnRegister.TabIndex = 35;
            this.btnRegister.Text = "ĐĂNG KÍ";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_magv
            // 
            this.txt_magv.Location = new System.Drawing.Point(307, 103);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(263, 22);
            this.txt_magv.TabIndex = 33;
            // 
            // spinEdit_thoigian
            // 
            this.spinEdit_thoigian.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinEdit_thoigian.Location = new System.Drawing.Point(307, 481);
            this.spinEdit_thoigian.Name = "spinEdit_thoigian";
            this.spinEdit_thoigian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_thoigian.Size = new System.Drawing.Size(263, 22);
            this.spinEdit_thoigian.TabIndex = 32;
            // 
            // spinEdit_cauhoi
            // 
            this.spinEdit_cauhoi.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_cauhoi.Location = new System.Drawing.Point(307, 427);
            this.spinEdit_cauhoi.Name = "spinEdit_cauhoi";
            this.spinEdit_cauhoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_cauhoi.Size = new System.Drawing.Size(263, 22);
            this.spinEdit_cauhoi.TabIndex = 30;
            // 
            // spinEdit_lanthi
            // 
            this.spinEdit_lanthi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_lanthi.Location = new System.Drawing.Point(307, 373);
            this.spinEdit_lanthi.Name = "spinEdit_lanthi";
            this.spinEdit_lanthi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_lanthi.Size = new System.Drawing.Size(263, 22);
            this.spinEdit_lanthi.TabIndex = 28;
            // 
            // dt_ngaythi
            // 
            this.dt_ngaythi.EditValue = null;
            this.dt_ngaythi.Location = new System.Drawing.Point(307, 319);
            this.dt_ngaythi.Name = "dt_ngaythi";
            this.dt_ngaythi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaythi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_ngaythi.Size = new System.Drawing.Size(263, 22);
            this.dt_ngaythi.TabIndex = 26;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.ds;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cb_maMonHoc
            // 
            this.cb_maMonHoc.DataSource = this.mONHOCBindingSource;
            this.cb_maMonHoc.DisplayMember = "MAMH";
            this.cb_maMonHoc.FormattingEnabled = true;
            this.cb_maMonHoc.Location = new System.Drawing.Point(307, 158);
            this.cb_maMonHoc.Name = "cb_maMonHoc";
            this.cb_maMonHoc.Size = new System.Drawing.Size(263, 24);
            this.cb_maMonHoc.TabIndex = 41;
            this.cb_maMonHoc.ValueMember = "MAMH";
            // 
            // txt_validate
            // 
            this.txt_validate.AutoSize = true;
            this.txt_validate.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_validate.ForeColor = System.Drawing.Color.Red;
            this.txt_validate.Location = new System.Drawing.Point(327, 518);
            this.txt_validate.Name = "txt_validate";
            this.txt_validate.Size = new System.Drawing.Size(108, 16);
            this.txt_validate.TabIndex = 42;
            this.txt_validate.Text = "Hiển thị lỗi ở đây!";
            this.txt_validate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExamRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 618);
            this.Controls.Add(this.gr_dkthi);
            this.Name = "frmExamRegistration";
            this.Text = "ĐĂNG KÝ THI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formExamRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_giaoVienDangKi)).EndInit();
            this.gr_dkthi.ResumeLayout(false);
            this.gr_dkthi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_magv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_thoigian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cauhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_lanthi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TN_CSDLPTDataSet ds;
        private System.Windows.Forms.BindingSource bds_giaoVienDangKi;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gr_dkthi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private DevExpress.XtraEditors.TextEdit txt_magv;
        private DevExpress.XtraEditors.SpinEdit spinEdit_thoigian;
        private DevExpress.XtraEditors.SpinEdit spinEdit_cauhoi;
        private DevExpress.XtraEditors.SpinEdit spinEdit_lanthi;
        private DevExpress.XtraEditors.DateEdit dt_ngaythi;
        private System.Windows.Forms.ComboBox cb_trinhdo;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cb_maLop;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cb_maMonHoc;
        private System.Windows.Forms.Label txt_validate;
    }
}