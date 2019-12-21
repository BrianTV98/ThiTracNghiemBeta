namespace ThiTracNghiemBetta.form.student
{
    partial class frmEditClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.tN_CSDLPTDataSet = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.txt_maKhoa = new DevExpress.XtraEditors.TextEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.txt_validate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Location = new System.Drawing.Point(157, 92);
            this.txtMaLop.MaxLength = 8;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(221, 22);
            this.txtMaLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(157, 147);
            this.txtTenLop.MaxLength = 50;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(221, 22);
            this.txtTenLop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Khoa";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(173, 264);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(92, 39);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Hoàn Tất";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
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
            // txt_maKhoa
            // 
            this.txt_maKhoa.Enabled = false;
            this.txt_maKhoa.Location = new System.Drawing.Point(157, 207);
            this.txt_maKhoa.Name = "txt_maKhoa";
            this.txt_maKhoa.Properties.MaxLength = 8;
            this.txt_maKhoa.Size = new System.Drawing.Size(221, 22);
            this.txt_maKhoa.TabIndex = 7;
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
            // txt_validate
            // 
            this.txt_validate.AutoSize = true;
            this.txt_validate.ForeColor = System.Drawing.Color.Red;
            this.txt_validate.Location = new System.Drawing.Point(170, 238);
            this.txt_validate.Name = "txt_validate";
            this.txt_validate.Size = new System.Drawing.Size(123, 17);
            this.txt_validate.TabIndex = 8;
            this.txt_validate.Text = "Hiển thị lỗi tại đây!";
            this.txt_validate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 326);
            this.Controls.Add(this.txt_validate);
            this.Controls.Add(this.txt_maKhoa);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditClass";
            this.Text = "frmEditLop";
            this.Load += new System.EventHandler(this.frmEditLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox txtMaLop;
        protected internal System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnComplete;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        protected internal DevExpress.XtraEditors.TextEdit txt_maKhoa;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.Label txt_validate;
    }
}