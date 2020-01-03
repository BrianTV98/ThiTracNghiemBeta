namespace ThiTracNghiemBetta.form.student
{
    partial class frmNhapLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapLop));
            this.ds = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.bds_lop = new System.Windows.Forms.BindingSource(this.components);
            this.adapterLop = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.adaterSv = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pnChiNhanh = new System.Windows.Forms.Panel();
            this.tENCNComboBox = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnLop = new System.Windows.Forms.Panel();
            this.pnNhapLop = new System.Windows.Forms.Panel();
            this.txtMaKhoa = new System.Windows.Forms.ComboBox();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.pnGcLop = new System.Windows.Forms.Panel();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gv_Lop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnSV = new System.Windows.Forms.Panel();
            this.pnGCSV = new System.Windows.Forms.Panel();
            this.gvSV = new System.Windows.Forms.DataGridView();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds_sv = new System.Windows.Forms.BindingSource(this.components);
            this.pnNhapSV = new System.Windows.Forms.Panel();
            this.btnCancelSV = new System.Windows.Forms.Button();
            this.btnLuuSV = new System.Windows.Forms.Button();
            this.txtMaLopSv = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoSV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.v_DS_PHANMANHTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.popupMenuLop = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barbtnThemLop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditLop = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeleteLop = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerLop = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerSV = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThemSV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSuaSV = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoaSV = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuSV = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuThemLop = new DevExpress.XtraBars.PopupMenu(this.components);
            this.kHOATableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_lop)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.pnLop.SuspendLayout();
            this.pnNhapLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            this.pnGcLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).BeginInit();
            this.pnSV.SuspendLayout();
            this.pnGCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sv)).BeginInit();
            this.pnNhapSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLopSv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuThemLop)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(106, 45);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(64, 17);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MÃ LỚP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(106, 93);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(72, 17);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TÊN LỚP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(106, 146);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(75, 17);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MÃ KHOA:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(106, 27);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(50, 17);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(106, 75);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(106, 123);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(40, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(106, 171);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(83, 17);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(106, 219);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(56, 17);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(106, 267);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(60, 17);
            mALOPLabel1.TabIndex = 10;
            mALOPLabel1.Text = "MALOP:";
            // 
            // ds
            // 
            this.ds.DataSetName = "TN_CSDLPTDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_lop
            // 
            this.bds_lop.DataMember = "LOP";
            this.bds_lop.DataSource = this.ds;
            // 
            // adapterLop
            // 
            this.adapterLop.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = this.adapterLop;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.adaterSv;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adaterSv
            // 
            this.adaterSv.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI NHANH";
            // 
            // pnChiNhanh
            // 
            this.pnChiNhanh.Controls.Add(this.tENCNComboBox);
            this.pnChiNhanh.Controls.Add(this.label1);
            this.pnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiNhanh.Location = new System.Drawing.Point(0, 48);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(1924, 64);
            this.pnChiNhanh.TabIndex = 3;
            // 
            // tENCNComboBox
            // 
            this.tENCNComboBox.DataSource = this.v_DS_PHANMANHBindingSource;
            this.tENCNComboBox.DisplayMember = "TENCN";
            this.tENCNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tENCNComboBox.FormattingEnabled = true;
            this.tENCNComboBox.Location = new System.Drawing.Point(768, 16);
            this.tENCNComboBox.Name = "tENCNComboBox";
            this.tENCNComboBox.Size = new System.Drawing.Size(283, 24);
            this.tENCNComboBox.TabIndex = 2;
            this.tENCNComboBox.ValueMember = "TENSERVER";
            this.tENCNComboBox.SelectedIndexChanged += new System.EventHandler(this.tENCNComboBox_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.ds;
            // 
            // pnLop
            // 
            this.pnLop.Controls.Add(this.pnNhapLop);
            this.pnLop.Controls.Add(this.pnGcLop);
            this.pnLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLop.Location = new System.Drawing.Point(0, 112);
            this.pnLop.Name = "pnLop";
            this.pnLop.Size = new System.Drawing.Size(1924, 281);
            this.pnLop.TabIndex = 4;
            // 
            // pnNhapLop
            // 
            this.pnNhapLop.AutoScroll = true;
            this.pnNhapLop.Controls.Add(this.txtMaKhoa);
            this.pnNhapLop.Controls.Add(this.cbMaKhoa);
            this.pnNhapLop.Controls.Add(this.btnCancel);
            this.pnNhapLop.Controls.Add(this.btnLuu);
            this.pnNhapLop.Controls.Add(mAKHLabel);
            this.pnNhapLop.Controls.Add(tENLOPLabel);
            this.pnNhapLop.Controls.Add(this.txtTenLop);
            this.pnNhapLop.Controls.Add(mALOPLabel);
            this.pnNhapLop.Controls.Add(this.txtMaLop);
            this.pnNhapLop.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnNhapLop.Location = new System.Drawing.Point(1486, 0);
            this.pnNhapLop.Name = "pnNhapLop";
            this.pnNhapLop.Size = new System.Drawing.Size(438, 281);
            this.pnNhapLop.TabIndex = 1;
            this.pnNhapLop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnNhapLop_Paint);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_lop, "MAKH", true));
            this.txtMaKhoa.FormattingEnabled = true;
            this.txtMaKhoa.Location = new System.Drawing.Point(202, 169);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(0, 24);
            this.txtMaKhoa.TabIndex = 10;
            this.txtMaKhoa.SelectedIndexChanged += new System.EventHandler(this.txtMaKhoa_SelectedIndexChanged);
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.mAKHComboBox_TextChanged);
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.DataSource = this.kHOABindingSource;
            this.cbMaKhoa.DisplayMember = "MAKH";
            this.cbMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.Location = new System.Drawing.Point(202, 139);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(121, 24);
            this.cbMaKhoa.TabIndex = 9;
            this.cbMaKhoa.ValueMember = "MAKH";
            this.cbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbMaKhoa_SelectedIndexChanged);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.ds;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(117, 198);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_lop, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(202, 90);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(125, 22);
            this.txtTenLop.TabIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnThem,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem9, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barbtnThem
            // 
            this.barbtnThem.ActAsDropDown = true;
            this.barbtnThem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barbtnThem.Caption = "Thêm";
            this.barbtnThem.DropDownControl = this.popupMenu2;
            this.barbtnThem.Id = 0;
            this.barbtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barbtnThem.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.barbtnThem.Name = "barbtnThem";
            this.barbtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // popupMenu2
            // 
            this.popupMenu2.Manager = this.barManager1;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Refresh";
            this.barButtonItem9.Id = 7;
            this.barButtonItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem9.ImageOptions.SvgImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Undo";
            this.barButtonItem7.Id = 5;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Redo";
            this.barButtonItem8.Id = 6;
            this.barButtonItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thoát";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 48);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 815);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 767);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 48);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 767);
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_lop, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(202, 42);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(125, 22);
            this.txtMaLop.TabIndex = 1;
            // 
            // pnGcLop
            // 
            this.pnGcLop.AutoScroll = true;
            this.pnGcLop.Controls.Add(this.lOPGridControl);
            this.pnGcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGcLop.Location = new System.Drawing.Point(0, 0);
            this.pnGcLop.Name = "pnGcLop";
            this.pnGcLop.Size = new System.Drawing.Size(1924, 281);
            this.pnGcLop.TabIndex = 0;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bds_lop;
            this.lOPGridControl.Location = new System.Drawing.Point(0, 3);
            this.lOPGridControl.MainView = this.gv_Lop;
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(1528, 281);
            this.lOPGridControl.TabIndex = 0;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Lop});
            this.lOPGridControl.Click += new System.EventHandler(this.lOPGridControl_Click);
            this.lOPGridControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lOPGridControl_MouseUp);
            // 
            // gv_Lop
            // 
            this.gv_Lop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gv_Lop.GridControl = this.lOPGridControl;
            this.gv_Lop.Name = "gv_Lop";
            this.gv_Lop.OptionsBehavior.ReadOnly = true;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // pnSV
            // 
            this.pnSV.Controls.Add(this.pnGCSV);
            this.pnSV.Controls.Add(this.pnNhapSV);
            this.pnSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSV.Location = new System.Drawing.Point(0, 393);
            this.pnSV.Name = "pnSV";
            this.pnSV.Size = new System.Drawing.Size(1924, 422);
            this.pnSV.TabIndex = 5;
            // 
            // pnGCSV
            // 
            this.pnGCSV.Controls.Add(this.gvSV);
            this.pnGCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGCSV.Location = new System.Drawing.Point(0, 0);
            this.pnGCSV.Name = "pnGCSV";
            this.pnGCSV.Size = new System.Drawing.Size(1489, 422);
            this.pnGCSV.TabIndex = 1;
            // 
            // gvSV
            // 
            this.gvSV.AutoGenerateColumns = false;
            this.gvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.mALOPDataGridViewTextBoxColumn});
            this.gvSV.DataSource = this.bds_sv;
            this.gvSV.Location = new System.Drawing.Point(0, 0);
            this.gvSV.Name = "gvSV";
            this.gvSV.RowHeadersWidth = 51;
            this.gvSV.RowTemplate.Height = 24;
            this.gvSV.Size = new System.Drawing.Size(1534, 470);
            this.gvSV.TabIndex = 0;
            this.gvSV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvSV_MouseUp);
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HO";
            this.hODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
            // 
            // bds_sv
            // 
            this.bds_sv.DataMember = "FK_SINHVIEN_LOP";
            this.bds_sv.DataSource = this.bds_lop;
            // 
            // pnNhapSV
            // 
            this.pnNhapSV.Controls.Add(this.btnCancelSV);
            this.pnNhapSV.Controls.Add(this.btnLuuSV);
            this.pnNhapSV.Controls.Add(mALOPLabel1);
            this.pnNhapSV.Controls.Add(this.txtMaLopSv);
            this.pnNhapSV.Controls.Add(dIACHILabel);
            this.pnNhapSV.Controls.Add(this.txtDiaChi);
            this.pnNhapSV.Controls.Add(nGAYSINHLabel);
            this.pnNhapSV.Controls.Add(this.dtNgaySinh);
            this.pnNhapSV.Controls.Add(tENLabel);
            this.pnNhapSV.Controls.Add(this.txtTenSV);
            this.pnNhapSV.Controls.Add(hOLabel);
            this.pnNhapSV.Controls.Add(this.txtHoSV);
            this.pnNhapSV.Controls.Add(mASVLabel);
            this.pnNhapSV.Controls.Add(this.txtMaSV);
            this.pnNhapSV.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnNhapSV.Location = new System.Drawing.Point(1489, 0);
            this.pnNhapSV.Name = "pnNhapSV";
            this.pnNhapSV.Size = new System.Drawing.Size(435, 422);
            this.pnNhapSV.TabIndex = 0;
            // 
            // btnCancelSV
            // 
            this.btnCancelSV.Location = new System.Drawing.Point(247, 321);
            this.btnCancelSV.Name = "btnCancelSV";
            this.btnCancelSV.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSV.TabIndex = 13;
            this.btnCancelSV.Text = "Cancel";
            this.btnCancelSV.UseVisualStyleBackColor = true;
            this.btnCancelSV.Click += new System.EventHandler(this.btnCancelSV_Click);
            // 
            // btnLuuSV
            // 
            this.btnLuuSV.Location = new System.Drawing.Point(109, 321);
            this.btnLuuSV.Name = "btnLuuSV";
            this.btnLuuSV.Size = new System.Drawing.Size(75, 23);
            this.btnLuuSV.TabIndex = 12;
            this.btnLuuSV.Text = "Lưu";
            this.btnLuuSV.UseVisualStyleBackColor = true;
            this.btnLuuSV.Click += new System.EventHandler(this.btnLuuSV_Click);
            // 
            // txtMaLopSv
            // 
            this.txtMaLopSv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sv, "MALOP", true));
            this.txtMaLopSv.Location = new System.Drawing.Point(200, 262);
            this.txtMaLopSv.MenuManager = this.barManager1;
            this.txtMaLopSv.Name = "txtMaLopSv";
            this.txtMaLopSv.Size = new System.Drawing.Size(125, 22);
            this.txtMaLopSv.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sv, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(202, 214);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(125, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sv, "NGAYSINH", true));
            this.dtNgaySinh.EditValue = null;
            this.dtNgaySinh.Location = new System.Drawing.Point(202, 166);
            this.dtNgaySinh.MenuManager = this.barManager1;
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Size = new System.Drawing.Size(125, 22);
            this.dtNgaySinh.TabIndex = 7;
            // 
            // txtTenSV
            // 
            this.txtTenSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sv, "TEN", true));
            this.txtTenSV.Location = new System.Drawing.Point(202, 118);
            this.txtTenSV.MenuManager = this.barManager1;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(125, 22);
            this.txtTenSV.TabIndex = 5;
            // 
            // txtHoSV
            // 
            this.txtHoSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sv, "HO", true));
            this.txtHoSV.Location = new System.Drawing.Point(202, 70);
            this.txtHoSV.MenuManager = this.barManager1;
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(125, 22);
            this.txtHoSV.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_sv, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(202, 22);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(125, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenuLop
            // 
            this.popupMenuLop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnThemLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDeleteLop)});
            this.popupMenuLop.Manager = this.barManagerLop;
            this.popupMenuLop.Name = "popupMenuLop";
            // 
            // barbtnThemLop
            // 
            this.barbtnThemLop.Caption = "Thêm";
            this.barbtnThemLop.Id = 2;
            this.barbtnThemLop.Name = "barbtnThemLop";
            this.barbtnThemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnThemLop_ItemClick);
            // 
            // barBtnEditLop
            // 
            this.barBtnEditLop.Caption = "Chỉnh Sửa";
            this.barBtnEditLop.Id = 0;
            this.barBtnEditLop.Name = "barBtnEditLop";
            this.barBtnEditLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditLop_ItemClick);
            // 
            // barBtnDeleteLop
            // 
            this.barBtnDeleteLop.Caption = "Xóa";
            this.barBtnDeleteLop.Id = 1;
            this.barBtnDeleteLop.Name = "barBtnDeleteLop";
            this.barBtnDeleteLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeleteLop_ItemClick);
            // 
            // barManagerLop
            // 
            this.barManagerLop.DockControls.Add(this.barDockControl1);
            this.barManagerLop.DockControls.Add(this.barDockControl2);
            this.barManagerLop.DockControls.Add(this.barDockControl3);
            this.barManagerLop.DockControls.Add(this.barDockControl4);
            this.barManagerLop.Form = this;
            this.barManagerLop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnEditLop,
            this.barBtnDeleteLop,
            this.barbtnThemLop});
            this.barManagerLop.MaxItemId = 3;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManagerLop;
            this.barDockControl1.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 815);
            this.barDockControl2.Manager = this.barManagerLop;
            this.barDockControl2.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManagerLop;
            this.barDockControl3.Size = new System.Drawing.Size(0, 815);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1924, 0);
            this.barDockControl4.Manager = this.barManagerLop;
            this.barDockControl4.Size = new System.Drawing.Size(0, 815);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManagerSV
            // 
            this.barManagerSV.DockControls.Add(this.barDockControl5);
            this.barManagerSV.DockControls.Add(this.barDockControl6);
            this.barManagerSV.DockControls.Add(this.barDockControl7);
            this.barManagerSV.DockControls.Add(this.barDockControl8);
            this.barManagerSV.Form = this;
            this.barManagerSV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem6,
            this.barBtnThemSV,
            this.barBtnSuaSV,
            this.barBtnXoaSV});
            this.barManagerSV.MaxItemId = 4;
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManagerSV;
            this.barDockControl5.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 815);
            this.barDockControl6.Manager = this.barManagerSV;
            this.barDockControl6.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.barManagerSV;
            this.barDockControl7.Size = new System.Drawing.Size(0, 815);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1924, 0);
            this.barDockControl8.Manager = this.barManagerSV;
            this.barDockControl8.Size = new System.Drawing.Size(0, 815);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 0;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barBtnThemSV
            // 
            this.barBtnThemSV.Caption = "Thêm";
            this.barBtnThemSV.Id = 1;
            this.barBtnThemSV.Name = "barBtnThemSV";
            this.barBtnThemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemSV_ItemClick);
            // 
            // barBtnSuaSV
            // 
            this.barBtnSuaSV.Caption = "Chỉnh Sửa";
            this.barBtnSuaSV.Id = 2;
            this.barBtnSuaSV.Name = "barBtnSuaSV";
            this.barBtnSuaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSuaSV_ItemClick);
            // 
            // barBtnXoaSV
            // 
            this.barBtnXoaSV.Caption = "Xóa";
            this.barBtnXoaSV.Id = 3;
            this.barBtnXoaSV.Name = "barBtnXoaSV";
            this.barBtnXoaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoaSV_ItemClick);
            // 
            // popupMenuSV
            // 
            this.popupMenuSV.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnThemSV),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSuaSV),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnXoaSV)});
            this.popupMenuSV.Manager = this.barManagerSV;
            this.popupMenuSV.Name = "popupMenuSV";
            // 
            // popupMenuThemLop
            // 
            this.popupMenuThemLop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnThemLop)});
            this.popupMenuThemLop.Manager = this.barManagerLop;
            this.popupMenuThemLop.Name = "popupMenuThemLop";
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 815);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.pnLop);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "frmNhapLop";
            this.Text = "frmNhapLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_lop)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.pnLop.ResumeLayout(false);
            this.pnNhapLop.ResumeLayout(false);
            this.pnNhapLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            this.pnGcLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).EndInit();
            this.pnSV.ResumeLayout(false);
            this.pnGCSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_sv)).EndInit();
            this.pnNhapSV.ResumeLayout(false);
            this.pnNhapSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLopSv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuThemLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TN_CSDLPTDataSet ds;
        private System.Windows.Forms.BindingSource bds_lop;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter adapterLop;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnChiNhanh;
        private System.Windows.Forms.Panel pnLop;
        private System.Windows.Forms.Panel pnNhapLop;
        private System.Windows.Forms.Panel pnGcLop;
        private System.Windows.Forms.Panel pnSV;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barbtnThem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Lop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private TN_CSDLPTDataSetTableAdapters.SINHVIENTableAdapter adaterSv;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox tENCNComboBox;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManagerLop;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barBtnEditLop;
        private DevExpress.XtraBars.BarButtonItem barBtnDeleteLop;
        private DevExpress.XtraBars.PopupMenu popupMenuLop;
        private System.Windows.Forms.BindingSource bds_sv;
        private System.Windows.Forms.Panel pnGCSV;
        private System.Windows.Forms.Panel pnNhapSV;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private System.Windows.Forms.Button btnCancelSV;
        private System.Windows.Forms.Button btnLuuSV;
        private DevExpress.XtraEditors.TextEdit txtMaLopSv;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.DateEdit dtNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private DevExpress.XtraEditors.TextEdit txtHoSV;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManagerSV;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.PopupMenu popupMenuSV;
        private DevExpress.XtraBars.BarButtonItem barBtnThemSV;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaSV;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaSV;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.BarButtonItem barbtnThemLop;
        private DevExpress.XtraBars.PopupMenu popupMenuThemLop;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.ComboBox cbMaKhoa;
        private System.Windows.Forms.ComboBox txtMaKhoa;
        private System.Windows.Forms.DataGridView gvSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
    }
}