namespace ThiTracNghiemBetta.form
{
    partial class frmSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSV));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTRACUUDIEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnDANGXUAT = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.thongTinDangNhap = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusNHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMALOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTENLOP = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.thongTinDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnTHI,
            this.btnTRACUUDIEM,
            this.btnDANGXUAT,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(2217, 246);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnTHI
            // 
            this.btnTHI.Caption = "THI";
            this.btnTHI.Id = 1;
            this.btnTHI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTHI.ImageOptions.Image")));
            this.btnTHI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTHI.ImageOptions.LargeImage")));
            this.btnTHI.Name = "btnTHI";
            this.btnTHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHI_ItemClick);
            // 
            // btnTRACUUDIEM
            // 
            this.btnTRACUUDIEM.Caption = "TRA CỨU ĐIỂM";
            this.btnTRACUUDIEM.Id = 2;
            this.btnTRACUUDIEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTRACUUDIEM.ImageOptions.Image")));
            this.btnTRACUUDIEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTRACUUDIEM.ImageOptions.LargeImage")));
            this.btnTRACUUDIEM.Name = "btnTRACUUDIEM";
            this.btnTRACUUDIEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTRACUUDIEM_ItemClick);
            // 
            // btnDANGXUAT
            // 
            this.btnDANGXUAT.Caption = "ĐĂNG XUẤT";
            this.btnDANGXUAT.Id = 3;
            this.btnDANGXUAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDANGXUAT.ImageOptions.Image")));
            this.btnDANGXUAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDANGXUAT.ImageOptions.LargeImage")));
            this.btnDANGXUAT.Name = "btnDANGXUAT";
            this.btnDANGXUAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDANGXUAT_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTHI);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTRACUUDIEM);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDANGXUAT);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 765);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(2217, 47);
            // 
            // thongTinDangNhap
            // 
            this.thongTinDangNhap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.thongTinDangNhap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMAGV,
            this.toolStripStatusHOTEN,
            this.toolStripStatusNHOM,
            this.toolStripStatusMALOP,
            this.toolStripStatusTENLOP});
            this.thongTinDangNhap.Location = new System.Drawing.Point(0, 726);
            this.thongTinDangNhap.Name = "thongTinDangNhap";
            this.thongTinDangNhap.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.thongTinDangNhap.Size = new System.Drawing.Size(2217, 39);
            this.thongTinDangNhap.TabIndex = 3;
            this.thongTinDangNhap.Text = "statusStrip1";
            // 
            // toolStripStatusMAGV
            // 
            this.toolStripStatusMAGV.Name = "toolStripStatusMAGV";
            this.toolStripStatusMAGV.Size = new System.Drawing.Size(73, 30);
            this.toolStripStatusMAGV.Text = "MAGV";
            // 
            // toolStripStatusHOTEN
            // 
            this.toolStripStatusHOTEN.Name = "toolStripStatusHOTEN";
            this.toolStripStatusHOTEN.Size = new System.Drawing.Size(81, 30);
            this.toolStripStatusHOTEN.Text = "HOTEN";
            // 
            // toolStripStatusNHOM
            // 
            this.toolStripStatusNHOM.Name = "toolStripStatusNHOM";
            this.toolStripStatusNHOM.Size = new System.Drawing.Size(79, 30);
            this.toolStripStatusNHOM.Text = "NHOM";
            // 
            // toolStripStatusMALOP
            // 
            this.toolStripStatusMALOP.Name = "toolStripStatusMALOP";
            this.toolStripStatusMALOP.Size = new System.Drawing.Size(83, 30);
            this.toolStripStatusMALOP.Text = "MALOP";
            // 
            // toolStripStatusTENLOP
            // 
            this.toolStripStatusTENLOP.Name = "toolStripStatusTENLOP";
            this.toolStripStatusTENLOP.Size = new System.Drawing.Size(88, 30);
            this.toolStripStatusTENLOP.Text = "TENLOP";
            // 
            // frmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2217, 812);
            this.Controls.Add(this.thongTinDangNhap);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSV";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.thongTinDangNhap.ResumeLayout(false);
            this.thongTinDangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnTHI;
        private DevExpress.XtraBars.BarButtonItem btnTRACUUDIEM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDANGXUAT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.StatusStrip thongTinDangNhap;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMAGV;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHOTEN;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusNHOM;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMALOP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTENLOP;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    }
}