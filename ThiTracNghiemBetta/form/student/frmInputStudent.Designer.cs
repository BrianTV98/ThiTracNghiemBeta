namespace ThiTracNghiemBetta.form.student
{
    partial class frmInputStudent
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
            System.Windows.Forms.Label tENKHLabel;
            this.ds = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.bds_khoa = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.tENKHComboBox = new System.Windows.Forms.ComboBox();
            this.bds_lop = new System.Windows.Forms.BindingSource(this.components);
            this.gc_lop = new DevExpress.XtraGrid.GridControl();
            this.gv_Lop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_addClass = new System.Windows.Forms.Button();
            this.popupMenuLop = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_edit_lop = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_add_sv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit_sv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete_sv = new DevExpress.XtraBars.BarButtonItem();
            this.txt_malop = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenLop = new DevExpress.XtraEditors.TextEdit();
            this.txt_makhoa = new DevExpress.XtraEditors.TextEdit();
            this.bds_sv = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter();
            this.GV_SV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popupSinhVien = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            tENKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_malop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(12, 26);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(45, 16);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "KHOA";
            // 
            // ds
            // 
            this.ds.DataSetName = "TN_CSDLPTDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_khoa
            // 
            this.bds_khoa.DataMember = "KHOA";
            this.bds_khoa.DataSource = this.ds;
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
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tENKHComboBox
            // 
            this.tENKHComboBox.DataSource = this.bds_khoa;
            this.tENKHComboBox.DisplayMember = "TENKH";
            this.tENKHComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tENKHComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENKHComboBox.FormattingEnabled = true;
            this.tENKHComboBox.Location = new System.Drawing.Point(119, 12);
            this.tENKHComboBox.Name = "tENKHComboBox";
            this.tENKHComboBox.Size = new System.Drawing.Size(344, 30);
            this.tENKHComboBox.TabIndex = 3;
            this.tENKHComboBox.ValueMember = "MAKH";
            // 
            // bds_lop
            // 
            this.bds_lop.DataMember = "FK_LOP_KHOA";
            this.bds_lop.DataSource = this.bds_khoa;
            // 
            // gc_lop
            // 
            this.gc_lop.DataSource = this.bds_lop;
            this.gc_lop.Location = new System.Drawing.Point(10, 106);
            this.gc_lop.MainView = this.gv_Lop;
            this.gc_lop.Name = "gc_lop";
            this.gc_lop.Size = new System.Drawing.Size(1135, 206);
            this.gc_lop.TabIndex = 3;
            this.gc_lop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Lop});
            // 
            // gv_Lop
            // 
            this.gv_Lop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colMALOP,
            this.colTENLOP});
            this.gv_Lop.DetailHeight = 328;
            this.gv_Lop.GridControl = this.gc_lop;
            this.gv_Lop.Name = "gv_Lop";
            this.gv_Lop.OptionsBehavior.ReadOnly = true;
            this.gv_Lop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gv_Lop_MouseUp);
            // 
            // colMAKH
            // 
            this.colMAKH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceCell.Options.UseFont = true;
            this.colMAKH.Caption = "MÃ KHOA";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.ReadOnly = true;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceCell.Options.UseFont = true;
            this.colMALOP.Caption = "MÃ LỚP";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 1;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "TÊN LỚP";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.ReadOnly = true;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 2;
            this.colTENLOP.Width = 94;
            // 
            // btn_addClass
            // 
            this.btn_addClass.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_addClass.Location = new System.Drawing.Point(15, 66);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(150, 35);
            this.btn_addClass.TabIndex = 4;
            this.btn_addClass.Text = "THÊM LỚP MỚI";
            this.btn_addClass.UseVisualStyleBackColor = false;
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // popupMenuLop
            // 
            this.popupMenuLop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_edit_lop),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_delete)});
            this.popupMenuLop.Manager = this.barManager1;
            this.popupMenuLop.Name = "popupMenuLop";
            // 
            // btn_edit_lop
            // 
            this.btn_edit_lop.Caption = "Chỉnh Sửa";
            this.btn_edit_lop.Id = 3;
            this.btn_edit_lop.Name = "btn_edit_lop";
            this.btn_edit_lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_lop_ItemClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Caption = "Xóa";
            this.btn_delete.Id = 4;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_delete_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_edit_lop,
            this.btn_delete,
            this.btn_add_sv,
            this.btn_edit_sv,
            this.btn_delete_sv});
            this.barManager1.MaxItemId = 8;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1183, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 595);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1183, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 595);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1183, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 595);
            // 
            // btn_add_sv
            // 
            this.btn_add_sv.Caption = "Thêm";
            this.btn_add_sv.Id = 5;
            this.btn_add_sv.Name = "btn_add_sv";
            this.btn_add_sv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_add_sv_ItemClick);
            // 
            // btn_edit_sv
            // 
            this.btn_edit_sv.Caption = "Chỉnh Sửa";
            this.btn_edit_sv.Id = 6;
            this.btn_edit_sv.Name = "btn_edit_sv";
            this.btn_edit_sv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_edit_sv_ItemClick);
            // 
            // btn_delete_sv
            // 
            this.btn_delete_sv.Caption = "Xóa";
            this.btn_delete_sv.Id = 7;
            this.btn_delete_sv.Name = "btn_delete_sv";
            this.btn_delete_sv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_delete_sv_ItemClick);
            // 
            // txt_malop
            // 
            this.txt_malop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_lop, "MALOP", true));
            this.txt_malop.Location = new System.Drawing.Point(238, 341);
            this.txt_malop.MenuManager = this.barManager1;
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(0, 22);
            this.txt_malop.TabIndex = 10;
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_lop, "TENLOP", true));
            this.txt_tenLop.Location = new System.Drawing.Point(535, 343);
            this.txt_tenLop.MenuManager = this.barManager1;
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Size = new System.Drawing.Size(0, 22);
            this.txt_tenLop.TabIndex = 12;
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_lop, "MAKH", true));
            this.txt_makhoa.Location = new System.Drawing.Point(827, 343);
            this.txt_makhoa.MenuManager = this.barManager1;
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(0, 22);
            this.txt_makhoa.TabIndex = 14;
            // 
            // bds_sv
            // 
            this.bds_sv.DataMember = "FK_SINHVIEN_LOP";
            this.bds_sv.DataSource = this.bds_lop;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // GV_SV
            // 
            this.GV_SV.AutoGenerateColumns = false;
            this.GV_SV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.GV_SV.DataSource = this.bds_sv;
            this.GV_SV.Location = new System.Drawing.Point(10, 330);
            this.GV_SV.Name = "GV_SV";
            this.GV_SV.RowHeadersWidth = 51;
            this.GV_SV.RowTemplate.Height = 24;
            this.GV_SV.Size = new System.Drawing.Size(1135, 220);
            this.GV_SV.TabIndex = 18;
            this.GV_SV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_SV_CellContentClick);
            this.GV_SV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sINHVIENDataGridView_MouseClick);
            this.GV_SV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GV_SV_MouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MASV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MALOP";
            this.dataGridViewTextBoxColumn6.HeaderText = "MALOP";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // popupSinhVien
            // 
            this.popupSinhVien.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_add_sv),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_edit_sv),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_delete_sv)});
            this.popupSinhVien.Manager = this.barManager1;
            this.popupSinhVien.Name = "popupSinhVien";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmInputStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1183, 595);
            this.Controls.Add(this.GV_SV);
            this.Controls.Add(this.txt_makhoa);
            this.Controls.Add(this.txt_tenLop);
            this.Controls.Add(this.txt_malop);
            this.Controls.Add(this.btn_addClass);
            this.Controls.Add(this.gc_lop);
            this.Controls.Add(tENKHLabel);
            this.Controls.Add(this.tENKHComboBox);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmInputStudent";
            this.Text = "frmStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInputStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_malop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TN_CSDLPTDataSet ds;
        private System.Windows.Forms.BindingSource bds_khoa;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox tENKHComboBox;
        private System.Windows.Forms.BindingSource bds_lop;
        private System.Windows.Forms.Button btn_addClass;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraBars.PopupMenu popupMenuLop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraGrid.GridControl gc_lop;
        protected internal DevExpress.XtraGrid.Views.Grid.GridView gv_Lop;
        private DevExpress.XtraEditors.TextEdit txt_makhoa;
        private DevExpress.XtraEditors.TextEdit txt_tenLop;
        private DevExpress.XtraEditors.TextEdit txt_malop;
        private System.Windows.Forms.BindingSource bds_sv;
        private TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraBars.PopupMenu popupSinhVien;
        private DevExpress.XtraBars.BarButtonItem btn_edit_lop;
        private DevExpress.XtraBars.BarButtonItem btn_delete;
        private DevExpress.XtraBars.BarButtonItem btn_add_sv;
        private DevExpress.XtraBars.BarButtonItem btn_edit_sv;
        private DevExpress.XtraBars.BarButtonItem btn_delete_sv;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        public System.Windows.Forms.DataGridView GV_SV;
    }
}