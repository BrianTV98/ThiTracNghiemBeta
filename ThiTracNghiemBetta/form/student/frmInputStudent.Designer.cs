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
            this.tN_CSDLPTDataSet = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.LOPTableAdapter();
            this.tENKHComboBox = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gv_Lop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_addClass = new System.Windows.Forms.Button();
            this.popupMenuLop = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtn_EditLop = new DevExpress.XtraBars.BarButtonItem();
            this.bar_btn_deleteLop = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            tENKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(18, 23);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(45, 16);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "KHOA";
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
            this.tENKHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "TENKH", true));
            this.tENKHComboBox.DataSource = this.kHOABindingSource;
            this.tENKHComboBox.DisplayMember = "TENKH";
            this.tENKHComboBox.FormattingEnabled = true;
            this.tENKHComboBox.Location = new System.Drawing.Point(125, 17);
            this.tENKHComboBox.Name = "tENKHComboBox";
            this.tENKHComboBox.Size = new System.Drawing.Size(342, 23);
            this.tENKHComboBox.TabIndex = 3;
            this.tENKHComboBox.ValueMember = "MAKH";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "FK_LOP_KHOA";
            this.lOPBindingSource.DataSource = this.kHOABindingSource;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.lOPBindingSource;
            this.lOPGridControl.Location = new System.Drawing.Point(10, 106);
            this.lOPGridControl.MainView = this.gv_Lop;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(1135, 206);
            this.lOPGridControl.TabIndex = 3;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Lop});
            // 
            // gv_Lop
            // 
            this.gv_Lop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colMALOP,
            this.colTENLOP});
            this.gv_Lop.DetailHeight = 328;
            this.gv_Lop.GridControl = this.lOPGridControl;
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
            // 
            // popupMenuLop
            // 
            this.popupMenuLop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_EditLop),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_deleteLop)});
            this.popupMenuLop.Manager = this.barManager1;
            this.popupMenuLop.Name = "popupMenuLop";
            // 
            // barBtn_EditLop
            // 
            this.barBtn_EditLop.Caption = "Chỉnh Sửa";
            this.barBtn_EditLop.Id = 0;
            this.barBtn_EditLop.Name = "barBtn_EditLop";
            this.barBtn_EditLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_EditLop_ItemClick);
            // 
            // bar_btn_deleteLop
            // 
            this.bar_btn_deleteLop.Caption = "Xóa";
            this.bar_btn_deleteLop.Id = 1;
            this.bar_btn_deleteLop.Name = "bar_btn_deleteLop";
            this.bar_btn_deleteLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_deleteLop_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtn_EditLop,
            this.bar_btn_deleteLop});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1163, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 623);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1163, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 623);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1163, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 623);
            // 
            // frmInputStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1163, 623);
            this.Controls.Add(this.btn_addClass);
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(tENKHLabel);
            this.Controls.Add(this.tENKHComboBox);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmInputStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmInputStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TN_CSDLPTDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPTDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox tENKHComboBox;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Lop;
        private System.Windows.Forms.Button btn_addClass;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraBars.PopupMenu popupMenuLop;
        private DevExpress.XtraBars.BarButtonItem barBtn_EditLop;
        private DevExpress.XtraBars.BarButtonItem bar_btn_deleteLop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}