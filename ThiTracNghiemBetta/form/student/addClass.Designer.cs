namespace ThiTracNghiemBetta.form.student
{
    partial class addClass
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
            System.Windows.Forms.Label mAKHLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.tN_CSDLPTDataSet = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.cb_makhoa = new System.Windows.Forms.ComboBox();
            this.btn_addClass = new System.Windows.Forms.Button();
            this.txtValidate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(71, 191);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(71, 16);
            mAKHLabel.TabIndex = 5;
            mAKHLabel.Text = "MÃ KHOA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ LỚP";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(197, 62);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(189, 22);
            this.txtMaLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÊN LỚP";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(197, 122);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(189, 22);
            this.txtTenLop.TabIndex = 3;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cb_makhoa
            // 
            this.cb_makhoa.DataSource = this.kHOABindingSource;
            this.cb_makhoa.DisplayMember = "TENKH";
            this.cb_makhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_makhoa.Enabled = false;
            this.cb_makhoa.FormattingEnabled = true;
            this.cb_makhoa.Location = new System.Drawing.Point(197, 183);
            this.cb_makhoa.Name = "cb_makhoa";
            this.cb_makhoa.Size = new System.Drawing.Size(189, 24);
            this.cb_makhoa.TabIndex = 6;
            this.cb_makhoa.ValueMember = "MAKH";
            // 
            // btn_addClass
            // 
            this.btn_addClass.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClass.Location = new System.Drawing.Point(105, 276);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(124, 28);
            this.btn_addClass.TabIndex = 7;
            this.btn_addClass.Text = "THÊM LỚP";
            this.btn_addClass.UseVisualStyleBackColor = true;
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // txtValidate
            // 
            this.txtValidate.AutoSize = true;
            this.txtValidate.ForeColor = System.Drawing.Color.Red;
            this.txtValidate.Location = new System.Drawing.Point(160, 233);
            this.txtValidate.Name = "txtValidate";
            this.txtValidate.Size = new System.Drawing.Size(116, 17);
            this.txtValidate.TabIndex = 8;
            this.txtValidate.Text = "Hiển thị lỗi ở đây!";
            this.txtValidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // addClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtValidate);
            this.Controls.Add(this.btn_addClass);
            this.Controls.Add(mAKHLabel);
            this.Controls.Add(this.cb_makhoa);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addClass";
            this.Text = "Thêm lớp";
            this.Load += new System.EventHandler(this.addClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_addClass;
        private System.Windows.Forms.Label txtValidate;
        protected internal DevExpress.XtraEditors.TextEdit txtMaLop;
        protected internal DevExpress.XtraEditors.TextEdit txtTenLop;
        protected internal System.Windows.Forms.ComboBox cb_makhoa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}