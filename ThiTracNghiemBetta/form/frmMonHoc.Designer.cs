namespace ThiTracNghiemBetta.form
{
    partial class frmMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.tN_CSDLPTDataSet = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.v_DS_PHANMANHBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.barBtnThemMH = new System.Windows.Forms.ToolStripButton();
            this.v_DS_PHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.giaovieN_DANGKYTableAdapter1 = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.mONHOCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMHGroupBox = new System.Windows.Forms.GroupBox();
            this.edtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.edtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.btnAddMH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mONHOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingNavigator)).BeginInit();
            this.v_DS_PHANMANHBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCDataGridView)).BeginInit();
            this.addMHGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(34, 59);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(120, 25);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "Mã môn học";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(34, 131);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(127, 25);
            tENMHLabel.TabIndex = 6;
            tENMHLabel.Text = "Tên môn học";
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
            // v_DS_PHANMANHBindingNavigator
            // 
            this.v_DS_PHANMANHBindingNavigator.AddNewItem = null;
            this.v_DS_PHANMANHBindingNavigator.BindingSource = this.v_DS_PHANMANHBindingSource;
            this.v_DS_PHANMANHBindingNavigator.CountItem = null;
            this.v_DS_PHANMANHBindingNavigator.DeleteItem = null;
            this.v_DS_PHANMANHBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.v_DS_PHANMANHBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator1,
            this.barBtnThemMH});
            this.v_DS_PHANMANHBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.v_DS_PHANMANHBindingNavigator.MoveFirstItem = null;
            this.v_DS_PHANMANHBindingNavigator.MoveLastItem = null;
            this.v_DS_PHANMANHBindingNavigator.MoveNextItem = null;
            this.v_DS_PHANMANHBindingNavigator.MovePreviousItem = null;
            this.v_DS_PHANMANHBindingNavigator.Name = "v_DS_PHANMANHBindingNavigator";
            this.v_DS_PHANMANHBindingNavigator.PositionItem = null;
            this.v_DS_PHANMANHBindingNavigator.Size = new System.Drawing.Size(1281, 40);
            this.v_DS_PHANMANHBindingNavigator.TabIndex = 0;
            this.v_DS_PHANMANHBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // barBtnThemMH
            // 
            this.barBtnThemMH.Enabled = false;
            this.barBtnThemMH.Image = global::ThiTracNghiemBetta.Properties.Resources.plus;
            this.barBtnThemMH.Name = "barBtnThemMH";
            this.barBtnThemMH.Size = new System.Drawing.Size(185, 34);
            this.barBtnThemMH.Text = "Thêm môn học";
            this.barBtnThemMH.Click += new System.EventHandler(this.barBtnThemMH_Click);
            // 
            // v_DS_PHANMANHBindingSource1
            // 
            this.v_DS_PHANMANHBindingSource1.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource1.DataSource = this.tN_CSDLPTDataSet;
            // 
            // cbCoSo
            // 
            this.cbCoSo.DataSource = this.v_DS_PHANMANHBindingSource1;
            this.cbCoSo.DisplayMember = "TENCN";
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(157, 86);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(400, 32);
            this.cbCoSo.TabIndex = 1;
            this.cbCoSo.ValueMember = "TENSERVER";
            this.cbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cơ  sở";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // giaovieN_DANGKYTableAdapter1
            // 
            this.giaovieN_DANGKYTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn học";
            // 
            // mONHOCDataGridView
            // 
            this.mONHOCDataGridView.AllowUserToAddRows = false;
            this.mONHOCDataGridView.AllowUserToDeleteRows = false;
            this.mONHOCDataGridView.AutoGenerateColumns = false;
            this.mONHOCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mONHOCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mONHOCDataGridView.DataSource = this.mONHOCBindingSource;
            this.mONHOCDataGridView.Location = new System.Drawing.Point(157, 148);
            this.mONHOCDataGridView.Name = "mONHOCDataGridView";
            this.mONHOCDataGridView.ReadOnly = true;
            this.mONHOCDataGridView.RowHeadersWidth = 72;
            this.mONHOCDataGridView.RowTemplate.Height = 31;
            this.mONHOCDataGridView.Size = new System.Drawing.Size(767, 516);
            this.mONHOCDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAMH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAMH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENMH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "rowguid";
            this.dataGridViewTextBoxColumn3.HeaderText = "rowguid";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // addMHGroupBox
            // 
            this.addMHGroupBox.Controls.Add(tENMHLabel);
            this.addMHGroupBox.Controls.Add(this.edtTenMH);
            this.addMHGroupBox.Controls.Add(mAMHLabel);
            this.addMHGroupBox.Controls.Add(this.edtMaMH);
            this.addMHGroupBox.Controls.Add(this.btnAddMH);
            this.addMHGroupBox.Controls.Add(this.label3);
            this.addMHGroupBox.Location = new System.Drawing.Point(157, 722);
            this.addMHGroupBox.Name = "addMHGroupBox";
            this.addMHGroupBox.Size = new System.Drawing.Size(770, 275);
            this.addMHGroupBox.TabIndex = 6;
            this.addMHGroupBox.TabStop = false;
            this.addMHGroupBox.Text = "Thêm môn học";
            this.addMHGroupBox.Enter += new System.EventHandler(this.addMHGroupBox_Enter);
            // 
            // edtTenMH
            // 
            this.edtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            this.edtTenMH.Location = new System.Drawing.Point(183, 126);
            this.edtTenMH.Name = "edtTenMH";
            this.edtTenMH.Size = new System.Drawing.Size(406, 36);
            this.edtTenMH.TabIndex = 7;
            // 
            // edtMaMH
            // 
            this.edtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "MAMH", true));
            this.edtMaMH.Location = new System.Drawing.Point(183, 48);
            this.edtMaMH.Name = "edtMaMH";
            this.edtMaMH.Size = new System.Drawing.Size(175, 36);
            this.edtMaMH.TabIndex = 6;
            this.edtMaMH.EditValueChanged += new System.EventHandler(this.edtMaMH_EditValueChanged);
            // 
            // btnAddMH
            // 
            this.btnAddMH.Location = new System.Drawing.Point(30, 214);
            this.btnAddMH.Name = "btnAddMH";
            this.btnAddMH.Size = new System.Drawing.Size(134, 41);
            this.btnAddMH.TabIndex = 4;
            this.btnAddMH.Text = "Thêm ";
            this.btnAddMH.UseVisualStyleBackColor = true;
            this.btnAddMH.Click += new System.EventHandler(this.btnAddMH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // mONHOCBindingSource1
            // 
            this.mONHOCBindingSource1.DataMember = "MONHOC";
            this.mONHOCBindingSource1.DataSource = this.tN_CSDLPTDataSet;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 1083);
            this.Controls.Add(this.addMHGroupBox);
            this.Controls.Add(this.mONHOCDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCoSo);
            this.Controls.Add(this.v_DS_PHANMANHBindingNavigator);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingNavigator)).EndInit();
            this.v_DS_PHANMANHBindingNavigator.ResumeLayout(false);
            this.v_DS_PHANMANHBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCDataGridView)).EndInit();
            this.addMHGroupBox.ResumeLayout(false);
            this.addMHGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v_DS_PHANMANHBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton barBtnThemMH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource1;
        private System.Windows.Forms.ComboBox cbCoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter giaovieN_DANGKYTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView mONHOCDataGridView;
        private System.Windows.Forms.GroupBox addMHGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.TextEdit edtMaMH;
        private DevExpress.XtraEditors.TextEdit edtTenMH;
        private System.Windows.Forms.BindingSource mONHOCBindingSource1;
    }
}