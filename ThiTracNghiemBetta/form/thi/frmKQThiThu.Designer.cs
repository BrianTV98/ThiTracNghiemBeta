namespace ThiTracNghiemBetta.form.thi
{
    partial class frmKQThiThu
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.summarylistview = new System.Windows.Forms.ListView();
            this.question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DapAnDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TraLoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.summarylistview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(597, 650);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(597, 650);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // summarylistview
            // 
            this.summarylistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.question,
            this.TraLoi,
            this.DapAnDung});
            this.summarylistview.GridLines = true;
            this.summarylistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.summarylistview.HideSelection = false;
            this.summarylistview.Location = new System.Drawing.Point(19, 12);
            this.summarylistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summarylistview.MultiSelect = false;
            this.summarylistview.Name = "summarylistview";
            this.summarylistview.Size = new System.Drawing.Size(566, 626);
            this.summarylistview.TabIndex = 10;
            this.summarylistview.UseCompatibleStateImageBehavior = false;
            this.summarylistview.View = System.Windows.Forms.View.Details;
            // 
            // question
            // 
            this.question.Text = "Question";
            this.question.Width = 120;
            // 
            // DapAnDung
            // 
            this.DapAnDung.Text = "Đáp án đúng";
            this.DapAnDung.Width = 120;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.summarylistview;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(577, 630);
            this.layoutControlItem1.Text = " ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(3, 13);
            // 
            // TraLoi
            // 
            this.TraLoi.Text = "Đã trả lời";
            this.TraLoi.Width = 161;
            // 
            // frmKQThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 650);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmKQThiThu";
            this.Text = "frmKQThiThu";
            this.Load += new System.EventHandler(this.frmKQThiThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.ListView summarylistview;
        private System.Windows.Forms.ColumnHeader question;
        private System.Windows.Forms.ColumnHeader TraLoi;
        private System.Windows.Forms.ColumnHeader DapAnDung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}