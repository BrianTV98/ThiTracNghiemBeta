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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamRegistration));
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
            this.txt_validate = new System.Windows.Forms.Label();
            this.cb_maMonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.mONHOCTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_magv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_thoigian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cauhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_lanthi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tHOIGIANLabel
            // 
            resources.ApplyResources(tHOIGIANLabel, "tHOIGIANLabel");
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            // 
            // sOCAUTHILabel
            // 
            resources.ApplyResources(sOCAUTHILabel, "sOCAUTHILabel");
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            // 
            // lANLabel
            // 
            resources.ApplyResources(lANLabel, "lANLabel");
            lANLabel.Name = "lANLabel";
            // 
            // nGAYTHILabel
            // 
            resources.ApplyResources(nGAYTHILabel, "nGAYTHILabel");
            nGAYTHILabel.Name = "nGAYTHILabel";
            // 
            // tRINHDOLabel
            // 
            resources.ApplyResources(tRINHDOLabel, "tRINHDOLabel");
            tRINHDOLabel.Name = "tRINHDOLabel";
            // 
            // mALOPLabel
            // 
            resources.ApplyResources(mALOPLabel, "mALOPLabel");
            mALOPLabel.Name = "mALOPLabel";
            // 
            // mAMHLabel
            // 
            resources.ApplyResources(mAMHLabel, "mAMHLabel");
            mAMHLabel.Name = "mAMHLabel";
            // 
            // mAGVLabel
            // 
            resources.ApplyResources(mAGVLabel, "mAGVLabel");
            mAGVLabel.Name = "mAGVLabel";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
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
            resources.ApplyResources(this.gr_dkthi, "gr_dkthi");
            this.gr_dkthi.Name = "gr_dkthi";
            this.gr_dkthi.TabStop = false;
            this.gr_dkthi.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_validate
            // 
            resources.ApplyResources(this.txt_validate, "txt_validate");
            this.txt_validate.ForeColor = System.Drawing.Color.Red;
            this.txt_validate.Name = "txt_validate";
            // 
            // cb_maMonHoc
            // 
            this.cb_maMonHoc.DataSource = this.mONHOCBindingSource;
            this.cb_maMonHoc.DisplayMember = "MAMH";
            this.cb_maMonHoc.FormattingEnabled = true;
            resources.ApplyResources(this.cb_maMonHoc, "cb_maMonHoc");
            this.cb_maMonHoc.Name = "cb_maMonHoc";
            this.cb_maMonHoc.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.ds;
            // 
            // cb_maLop
            // 
            this.cb_maLop.DataSource = this.lOPBindingSource;
            this.cb_maLop.DisplayMember = "MALOP";
            this.cb_maLop.FormattingEnabled = true;
            resources.ApplyResources(this.cb_maLop, "cb_maLop");
            this.cb_maLop.Name = "cb_maLop";
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
            resources.GetString("cb_trinhdo.Items"),
            resources.GetString("cb_trinhdo.Items1"),
            resources.GetString("cb_trinhdo.Items2")});
            resources.ApplyResources(this.cb_trinhdo, "cb_trinhdo");
            this.cb_trinhdo.Name = "cb_trinhdo";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_magv
            // 
            resources.ApplyResources(this.txt_magv, "txt_magv");
            this.txt_magv.Name = "txt_magv";
            // 
            // spinEdit_thoigian
            // 
            resources.ApplyResources(this.spinEdit_thoigian, "spinEdit_thoigian");
            this.spinEdit_thoigian.Name = "spinEdit_thoigian";
            this.spinEdit_thoigian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("spinEdit_thoigian.Properties.Buttons"))))});
            // 
            // spinEdit_cauhoi
            // 
            resources.ApplyResources(this.spinEdit_cauhoi, "spinEdit_cauhoi");
            this.spinEdit_cauhoi.Name = "spinEdit_cauhoi";
            this.spinEdit_cauhoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("spinEdit_cauhoi.Properties.Buttons"))))});
            // 
            // spinEdit_lanthi
            // 
            resources.ApplyResources(this.spinEdit_lanthi, "spinEdit_lanthi");
            this.spinEdit_lanthi.Name = "spinEdit_lanthi";
            this.spinEdit_lanthi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("spinEdit_lanthi.Properties.Buttons"))))});
            // 
            // dt_ngaythi
            // 
            resources.ApplyResources(this.dt_ngaythi, "dt_ngaythi");
            this.dt_ngaythi.Name = "dt_ngaythi";
            this.dt_ngaythi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dt_ngaythi.Properties.Buttons"))))});
            this.dt_ngaythi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dt_ngaythi.Properties.CalendarTimeProperties.Buttons"))))});
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmExamRegistration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gr_dkthi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamRegistration";
            this.Load += new System.EventHandler(this.formExamRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_giaoVienDangKi)).EndInit();
            this.gr_dkthi.ResumeLayout(false);
            this.gr_dkthi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_magv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_thoigian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cauhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_lanthi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaythi.Properties)).EndInit();
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