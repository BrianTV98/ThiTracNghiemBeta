namespace ThiTracNghiemBetta.form.report
{
    partial class BangDiemMonHoc
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
            System.Windows.Forms.Label mAMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDiemMonHoc));
            this.tN_CSDLPTDataSet = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter();
            this.mONHOCTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtLan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnChiNhanh = new System.Windows.Forms.Panel();
            this.tENCNComboBox = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pnControl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GET_BANG_DIEM_THEO_LOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GET_BANG_DIEM_THEO_LOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.SP_GET_BANG_DIEM_THEO_LOPTableAdapter();
            this.gvBangDiem = new System.Windows.Forms.DataGridView();
            this.v_DS_PHANMANHTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.pnPrint = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pngridview = new System.Windows.Forms.Panel();
            this.popupMenuBangDiem = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barChiTietBaiThi = new DevExpress.XtraBars.BarButtonItem();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLan)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_BANG_DIEM_THEO_LOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangDiem)).BeginInit();
            this.pnPrint.SuspendLayout();
            this.pngridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(97, 50);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(36, 17);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "LỚP";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(333, 50);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(74, 17);
            mAMHLabel.TabIndex = 3;
            mAMHLabel.Text = "MÔN HỌC";
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
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cbMaLop
            // 
            this.cbMaLop.DataSource = this.lOPBindingSource;
            this.cbMaLop.DisplayMember = "TENLOP";
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(163, 47);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(121, 24);
            this.cbMaLop.TabIndex = 2;
            this.cbMaLop.ValueMember = "MALOP";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DataSource = this.mONHOCBindingSource;
            this.cbMonHoc.DisplayMember = "TENMH";
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(437, 43);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(121, 24);
            this.cbMonHoc.TabIndex = 4;
            this.cbMonHoc.ValueMember = "MAMH";
            // 
            // txtLan
            // 
            this.txtLan.Location = new System.Drawing.Point(697, 45);
            this.txtLan.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtLan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(120, 22);
            this.txtLan.TabIndex = 5;
            this.txtLan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "LẦN";
            // 
            // pnChiNhanh
            // 
            this.pnChiNhanh.Controls.Add(this.tENCNComboBox);
            this.pnChiNhanh.Controls.Add(this.label2);
            this.pnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(949, 79);
            this.pnChiNhanh.TabIndex = 7;
            // 
            // tENCNComboBox
            // 
            this.tENCNComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_PHANMANHBindingSource, "TENCN", true));
            this.tENCNComboBox.DataSource = this.v_DS_PHANMANHBindingSource;
            this.tENCNComboBox.DisplayMember = "TENCN";
            this.tENCNComboBox.FormattingEnabled = true;
            this.tENCNComboBox.Location = new System.Drawing.Point(384, 29);
            this.tENCNComboBox.Name = "tENCNComboBox";
            this.tENCNComboBox.Size = new System.Drawing.Size(251, 24);
            this.tENCNComboBox.TabIndex = 2;
            this.tENCNComboBox.ValueMember = "TENSERVER";
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI NHÁNH";
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.button1);
            this.pnControl.Controls.Add(this.cbMonHoc);
            this.pnControl.Controls.Add(mALOPLabel);
            this.pnControl.Controls.Add(this.label1);
            this.pnControl.Controls.Add(this.txtLan);
            this.pnControl.Controls.Add(mAMHLabel);
            this.pnControl.Controls.Add(this.cbMaLop);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 79);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(949, 149);
            this.pnControl.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // sP_GET_BANG_DIEM_THEO_LOPBindingSource
            // 
            this.sP_GET_BANG_DIEM_THEO_LOPBindingSource.DataMember = "SP_GET_BANG_DIEM_THEO_LOP";
            this.sP_GET_BANG_DIEM_THEO_LOPBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // sP_GET_BANG_DIEM_THEO_LOPTableAdapter
            // 
            this.sP_GET_BANG_DIEM_THEO_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // gvBangDiem
            // 
            this.gvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBangDiem.Location = new System.Drawing.Point(0, 0);
            this.gvBangDiem.Name = "gvBangDiem";
            this.gvBangDiem.ReadOnly = true;
            this.gvBangDiem.RowHeadersWidth = 51;
            this.gvBangDiem.RowTemplate.Height = 24;
            this.gvBangDiem.Size = new System.Drawing.Size(949, 247);
            this.gvBangDiem.TabIndex = 9;
            this.gvBangDiem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvBangDiem_MouseUp);
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // pnPrint
            // 
            this.pnPrint.Controls.Add(this.btnPrint);
            this.pnPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPrint.Location = new System.Drawing.Point(0, 475);
            this.pnPrint.Name = "pnPrint";
            this.pnPrint.Size = new System.Drawing.Size(949, 60);
            this.pnPrint.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(776, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 60);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "IN";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pngridview
            // 
            this.pngridview.Controls.Add(this.gvBangDiem);
            this.pngridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pngridview.Location = new System.Drawing.Point(0, 228);
            this.pngridview.Name = "pngridview";
            this.pngridview.Size = new System.Drawing.Size(949, 247);
            this.pngridview.TabIndex = 10;
            // 
            // popupMenuBangDiem
            // 
            this.popupMenuBangDiem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barChiTietBaiThi)});
            this.popupMenuBangDiem.Manager = this.barManager1;
            this.popupMenuBangDiem.Name = "popupMenuBangDiem";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barChiTietBaiThi});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(949, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 535);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(949, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 535);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(949, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 535);
            // 
            // barChiTietBaiThi
            // 
            this.barChiTietBaiThi.Caption = "Xem Chi Tiết";
            this.barChiTietBaiThi.Id = 0;
            this.barChiTietBaiThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barChiTietBaiThi.Name = "barChiTietBaiThi";
            this.barChiTietBaiThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 535);
            this.Controls.Add(this.pngridview);
            this.Controls.Add(this.pnPrint);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BangDiemMonHoc";
            this.Text = "BangDiemMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BangDiemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLan)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_BANG_DIEM_THEO_LOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangDiem)).EndInit();
            this.pnPrint.ResumeLayout(false);
            this.pngridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.NumericUpDown txtLan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button button1;
        private TN_CSDLPTDataSetTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private System.Windows.Forms.BindingSource sP_GET_BANG_DIEM_THEO_LOPBindingSource;
        private TN_CSDLPTDataSetTableAdapters.SP_GET_BANG_DIEM_THEO_LOPTableAdapter sP_GET_BANG_DIEM_THEO_LOPTableAdapter;
        private System.Windows.Forms.DataGridView gvBangDiem;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox tENCNComboBox;
        private System.Windows.Forms.Panel pnPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pngridview;
        private DevExpress.XtraBars.PopupMenu popupMenuBangDiem;
        private DevExpress.XtraBars.BarButtonItem barChiTietBaiThi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}