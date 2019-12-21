namespace ThiTracNghiemBetta.form.student
{
    partial class addSV
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
            this.txt_ma_sv = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ho_sv = new DevExpress.XtraEditors.TextEdit();
            this.txt_ten_sv = new DevExpress.XtraEditors.TextEdit();
            this.txt_dia_chi = new DevExpress.XtraEditors.TextEdit();
            this.txt_malop = new DevExpress.XtraEditors.TextEdit();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dt_picker = new System.Windows.Forms.DateTimePicker();
            this.txt_validate = new System.Windows.Forms.Label();
            this.tN_CSDLPTDataSet = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ma_sv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho_sv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten_sv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dia_chi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_malop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ SV:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ma_sv
            // 
            this.txt_ma_sv.Location = new System.Drawing.Point(195, 41);
            this.txt_ma_sv.Name = "txt_ma_sv";
            this.txt_ma_sv.Properties.MaxLength = 8;
            this.txt_ma_sv.Size = new System.Drawing.Size(200, 22);
            this.txt_ma_sv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "HỌ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "NGÀY SINH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "ĐỊA CHỈ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "MÃ LỚP";
            // 
            // txt_ho_sv
            // 
            this.txt_ho_sv.Location = new System.Drawing.Point(195, 85);
            this.txt_ho_sv.Name = "txt_ho_sv";
            this.txt_ho_sv.Properties.MaxLength = 40;
            this.txt_ho_sv.Size = new System.Drawing.Size(200, 22);
            this.txt_ho_sv.TabIndex = 7;
            // 
            // txt_ten_sv
            // 
            this.txt_ten_sv.Location = new System.Drawing.Point(195, 129);
            this.txt_ten_sv.Name = "txt_ten_sv";
            this.txt_ten_sv.Properties.MaxLength = 10;
            this.txt_ten_sv.Size = new System.Drawing.Size(200, 22);
            this.txt_ten_sv.TabIndex = 8;
            // 
            // txt_dia_chi
            // 
            this.txt_dia_chi.Location = new System.Drawing.Point(195, 217);
            this.txt_dia_chi.Name = "txt_dia_chi";
            this.txt_dia_chi.Properties.MaxLength = 40;
            this.txt_dia_chi.Size = new System.Drawing.Size(200, 22);
            this.txt_dia_chi.TabIndex = 10;
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(195, 258);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Properties.MaxLength = 8;
            this.txt_malop.Size = new System.Drawing.Size(200, 22);
            this.txt_malop.TabIndex = 11;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(85, 332);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(126, 32);
            this.btn_confirm.TabIndex = 12;
            this.btn_confirm.Text = "XÁC NHẬN";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(242, 332);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(153, 32);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "HỦY BỎ";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dt_picker
            // 
            this.dt_picker.Location = new System.Drawing.Point(195, 170);
            this.dt_picker.Name = "dt_picker";
            this.dt_picker.Size = new System.Drawing.Size(200, 22);
            this.dt_picker.TabIndex = 14;
            // 
            // txt_validate
            // 
            this.txt_validate.AutoSize = true;
            this.txt_validate.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_validate.ForeColor = System.Drawing.Color.Red;
            this.txt_validate.Location = new System.Drawing.Point(157, 303);
            this.txt_validate.Name = "txt_validate";
            this.txt_validate.Size = new System.Drawing.Size(114, 16);
            this.txt_validate.TabIndex = 15;
            this.txt_validate.Text = "Hiển thị lỗi tại đây!";
            this.txt_validate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 389);
            this.Controls.Add(this.txt_validate);
            this.Controls.Add(this.dt_picker);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_malop);
            this.Controls.Add(this.txt_dia_chi);
            this.Controls.Add(this.txt_ten_sv);
            this.Controls.Add(this.txt_ho_sv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ma_sv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addSV";
            this.Text = "addSV";
            this.Load += new System.EventHandler(this.addSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ma_sv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ho_sv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ten_sv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dia_chi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_malop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_Cancel;
        protected internal DevExpress.XtraEditors.TextEdit txt_ma_sv;
        protected internal DevExpress.XtraEditors.TextEdit txt_ho_sv;
        protected internal DevExpress.XtraEditors.TextEdit txt_ten_sv;
        protected internal DevExpress.XtraEditors.TextEdit txt_dia_chi;
        protected internal DevExpress.XtraEditors.TextEdit txt_malop;
        protected internal System.Windows.Forms.DateTimePicker dt_picker;
        private System.Windows.Forms.Label txt_validate;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}