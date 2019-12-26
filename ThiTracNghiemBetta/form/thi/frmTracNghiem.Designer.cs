namespace ThiTracNghiemBetta.form.thi
{
    partial class frmTracNghiem
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
            this.thongTinDangNhap = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusNHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMALOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTENLOP = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNOIDUNG = new System.Windows.Forms.RichTextBox();
            this.lblCHUYENDENCAU = new System.Windows.Forms.Label();
            this.numericUpDownCAUINDEX = new System.Windows.Forms.NumericUpDown();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.btnCAUSAU = new System.Windows.Forms.Button();
            this.btnCAUTRUOC = new System.Windows.Forms.Button();
            this.btnNOPBAI = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNGAYTHI = new System.Windows.Forms.Label();
            this.lblTRINHDO = new System.Windows.Forms.Label();
            this.lblLOP = new System.Windows.Forms.Label();
            this.lblMONHOC = new System.Windows.Forms.Label();
            this.lblTHOIGIANTHI = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.lblTHONGBAO = new System.Windows.Forms.Label();
            this.dS = new ThiTracNghiemBetta.TN_CSDLPTDataSet();
            this.bdsCT_BAITHI = new System.Windows.Forms.BindingSource(this.components);
            this.cT_BAITHITableAdapter = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.CHITIETBAITHITableAdapter();
            this.tableAdapterManager = new ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.summarylistview = new System.Windows.Forms.ListView();
            this.question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thongTinDangNhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCAUINDEX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_BAITHI)).BeginInit();
            this.SuspendLayout();
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
            this.thongTinDangNhap.Location = new System.Drawing.Point(0, 764);
            this.thongTinDangNhap.Name = "thongTinDangNhap";
            this.thongTinDangNhap.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.thongTinDangNhap.Size = new System.Drawing.Size(1359, 22);
            this.thongTinDangNhap.TabIndex = 3;
            this.thongTinDangNhap.Text = "statusStrip1";
            // 
            // toolStripStatusMAGV
            // 
            this.toolStripStatusMAGV.Name = "toolStripStatusMAGV";
            this.toolStripStatusMAGV.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusMAGV.Text = "MAGV";
            // 
            // toolStripStatusHOTEN
            // 
            this.toolStripStatusHOTEN.Name = "toolStripStatusHOTEN";
            this.toolStripStatusHOTEN.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusHOTEN.Text = "HOTEN";
            // 
            // toolStripStatusNHOM
            // 
            this.toolStripStatusNHOM.Name = "toolStripStatusNHOM";
            this.toolStripStatusNHOM.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusNHOM.Text = "NHOM";
            // 
            // toolStripStatusMALOP
            // 
            this.toolStripStatusMALOP.Name = "toolStripStatusMALOP";
            this.toolStripStatusMALOP.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusMALOP.Text = "MALOP";
            this.toolStripStatusMALOP.Click += new System.EventHandler(this.toolStripStatusMALOP_Click);
            // 
            // toolStripStatusTENLOP
            // 
            this.toolStripStatusTENLOP.Name = "toolStripStatusTENLOP";
            this.toolStripStatusTENLOP.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusTENLOP.Text = "TENLOP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNOIDUNG);
            this.groupBox1.Controls.Add(this.lblCHUYENDENCAU);
            this.groupBox1.Controls.Add(this.numericUpDownCAUINDEX);
            this.groupBox1.Controls.Add(this.rdoD);
            this.groupBox1.Controls.Add(this.rdoC);
            this.groupBox1.Controls.Add(this.rdoB);
            this.groupBox1.Controls.Add(this.rdoA);
            this.groupBox1.Controls.Add(this.btnCAUSAU);
            this.groupBox1.Controls.Add(this.btnCAUTRUOC);
            this.groupBox1.Location = new System.Drawing.Point(10, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1125, 678);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // lblNOIDUNG
            // 
            this.lblNOIDUNG.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOIDUNG.Location = new System.Drawing.Point(0, 18);
            this.lblNOIDUNG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNOIDUNG.Name = "lblNOIDUNG";
            this.lblNOIDUNG.ReadOnly = true;
            this.lblNOIDUNG.Size = new System.Drawing.Size(1120, 175);
            this.lblNOIDUNG.TabIndex = 10;
            this.lblNOIDUNG.Text = "";
            // 
            // lblCHUYENDENCAU
            // 
            this.lblCHUYENDENCAU.AutoSize = true;
            this.lblCHUYENDENCAU.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHUYENDENCAU.Location = new System.Drawing.Point(156, 608);
            this.lblCHUYENDENCAU.Name = "lblCHUYENDENCAU";
            this.lblCHUYENDENCAU.Size = new System.Drawing.Size(114, 17);
            this.lblCHUYENDENCAU.TabIndex = 9;
            this.lblCHUYENDENCAU.Text = "Chuyển đến câu:";
            // 
            // numericUpDownCAUINDEX
            // 
            this.numericUpDownCAUINDEX.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCAUINDEX.Location = new System.Drawing.Point(298, 606);
            this.numericUpDownCAUINDEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCAUINDEX.Name = "numericUpDownCAUINDEX";
            this.numericUpDownCAUINDEX.Size = new System.Drawing.Size(103, 24);
            this.numericUpDownCAUINDEX.TabIndex = 8;
            this.numericUpDownCAUINDEX.ValueChanged += new System.EventHandler(this.numericUpDownCAUINDEX_ValueChanged);
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoD.Location = new System.Drawing.Point(664, 473);
            this.rdoD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(36, 21);
            this.rdoD.TabIndex = 6;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D";
            this.rdoD.UseVisualStyleBackColor = true;
            this.rdoD.CheckedChanged += new System.EventHandler(this.rdoD_CheckedChanged);
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoC.Location = new System.Drawing.Point(212, 473);
            this.rdoC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(35, 21);
            this.rdoC.TabIndex = 5;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C";
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.CheckedChanged += new System.EventHandler(this.rdoC_CheckedChanged);
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoB.Location = new System.Drawing.Point(664, 291);
            this.rdoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(34, 21);
            this.rdoB.TabIndex = 4;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B";
            this.rdoB.UseVisualStyleBackColor = true;
            this.rdoB.CheckedChanged += new System.EventHandler(this.rdoB_CheckedChanged);
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoA.Location = new System.Drawing.Point(213, 291);
            this.rdoA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(34, 21);
            this.rdoA.TabIndex = 3;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A";
            this.rdoA.UseVisualStyleBackColor = true;
            this.rdoA.CheckedChanged += new System.EventHandler(this.rdoA_CheckedChanged);
            // 
            // btnCAUSAU
            // 
            this.btnCAUSAU.Location = new System.Drawing.Point(448, 594);
            this.btnCAUSAU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAUSAU.Name = "btnCAUSAU";
            this.btnCAUSAU.Size = new System.Drawing.Size(110, 46);
            this.btnCAUSAU.TabIndex = 1;
            this.btnCAUSAU.Text = "Câu Sau";
            this.btnCAUSAU.UseVisualStyleBackColor = true;
            this.btnCAUSAU.Click += new System.EventHandler(this.btnCAUSAU_Click);
            // 
            // btnCAUTRUOC
            // 
            this.btnCAUTRUOC.Location = new System.Drawing.Point(5, 594);
            this.btnCAUTRUOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAUTRUOC.Name = "btnCAUTRUOC";
            this.btnCAUTRUOC.Size = new System.Drawing.Size(122, 46);
            this.btnCAUTRUOC.TabIndex = 0;
            this.btnCAUTRUOC.Text = "Câu trước";
            this.btnCAUTRUOC.UseVisualStyleBackColor = true;
            this.btnCAUTRUOC.Click += new System.EventHandler(this.btnCAUTRUOC_Click);
            // 
            // btnNOPBAI
            // 
            this.btnNOPBAI.Location = new System.Drawing.Point(1244, 24);
            this.btnNOPBAI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNOPBAI.Name = "btnNOPBAI";
            this.btnNOPBAI.Size = new System.Drawing.Size(106, 46);
            this.btnNOPBAI.TabIndex = 7;
            this.btnNOPBAI.Text = "NỘP BÀI";
            this.btnNOPBAI.UseVisualStyleBackColor = true;
            this.btnNOPBAI.Click += new System.EventHandler(this.btnNOPBAI_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNGAYTHI);
            this.groupBox2.Controls.Add(this.lblTRINHDO);
            this.groupBox2.Controls.Add(this.lblLOP);
            this.groupBox2.Controls.Add(this.lblMONHOC);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(951, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lblNGAYTHI
            // 
            this.lblNGAYTHI.AutoSize = true;
            this.lblNGAYTHI.Location = new System.Drawing.Point(693, 30);
            this.lblNGAYTHI.Name = "lblNGAYTHI";
            this.lblNGAYTHI.Size = new System.Drawing.Size(46, 13);
            this.lblNGAYTHI.TabIndex = 3;
            this.lblNGAYTHI.Text = "ngày thi";
            // 
            // lblTRINHDO
            // 
            this.lblTRINHDO.AutoSize = true;
            this.lblTRINHDO.Location = new System.Drawing.Point(477, 30);
            this.lblTRINHDO.Name = "lblTRINHDO";
            this.lblTRINHDO.Size = new System.Drawing.Size(46, 13);
            this.lblTRINHDO.TabIndex = 2;
            this.lblTRINHDO.Text = "Trình độ";
            // 
            // lblLOP
            // 
            this.lblLOP.AutoSize = true;
            this.lblLOP.Location = new System.Drawing.Point(261, 30);
            this.lblLOP.Name = "lblLOP";
            this.lblLOP.Size = new System.Drawing.Size(26, 13);
            this.lblLOP.TabIndex = 1;
            this.lblLOP.Text = "LỚP";
            // 
            // lblMONHOC
            // 
            this.lblMONHOC.AutoSize = true;
            this.lblMONHOC.Location = new System.Drawing.Point(8, 30);
            this.lblMONHOC.Name = "lblMONHOC";
            this.lblMONHOC.Size = new System.Drawing.Size(55, 13);
            this.lblMONHOC.TabIndex = 0;
            this.lblMONHOC.Text = "MÔN HỌC";
            // 
            // lblTHOIGIANTHI
            // 
            this.lblTHOIGIANTHI.AutoSize = true;
            this.lblTHOIGIANTHI.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHOIGIANTHI.ForeColor = System.Drawing.Color.Red;
            this.lblTHOIGIANTHI.Location = new System.Drawing.Point(1020, 24);
            this.lblTHOIGIANTHI.Name = "lblTHOIGIANTHI";
            this.lblTHOIGIANTHI.Size = new System.Drawing.Size(71, 19);
            this.lblTHOIGIANTHI.TabIndex = 6;
            this.lblTHOIGIANTHI.Text = "Còn lại:";
            // 
            // lblTHONGBAO
            // 
            this.lblTHONGBAO.AutoSize = true;
            this.lblTHONGBAO.Location = new System.Drawing.Point(1021, 56);
            this.lblTHONGBAO.Name = "lblTHONGBAO";
            this.lblTHONGBAO.Size = new System.Drawing.Size(58, 13);
            this.lblTHONGBAO.TabIndex = 7;
            this.lblTHONGBAO.Text = "Thông báo";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCT_BAITHI
            // 
            this.bdsCT_BAITHI.DataMember = "CHITIETBAITHI";
            this.bdsCT_BAITHI.DataSource = this.dS;
            // 
            // cT_BAITHITableAdapter
            // 
            this.cT_BAITHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = this.cT_BAITHITableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemBetta.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // summarylistview
            // 
            this.summarylistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.question,
            this.answer});
            this.summarylistview.GridLines = true;
            this.summarylistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.summarylistview.HideSelection = false;
            this.summarylistview.Location = new System.Drawing.Point(1141, 91);
            this.summarylistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summarylistview.MultiSelect = false;
            this.summarylistview.Name = "summarylistview";
            this.summarylistview.Size = new System.Drawing.Size(209, 672);
            this.summarylistview.TabIndex = 9;
            this.summarylistview.UseCompatibleStateImageBehavior = false;
            this.summarylistview.View = System.Windows.Forms.View.Details;
            this.summarylistview.SelectedIndexChanged += new System.EventHandler(this.summarylistview_SelectedIndexChanged);
            // 
            // question
            // 
            this.question.Text = "Question";
            this.question.Width = 120;
            // 
            // answer
            // 
            this.answer.Text = "Answer";
            this.answer.Width = 120;
            // 
            // frmTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 786);
            this.Controls.Add(this.summarylistview);
            this.Controls.Add(this.lblTHONGBAO);
            this.Controls.Add(this.lblTHOIGIANTHI);
            this.Controls.Add(this.btnNOPBAI);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thongTinDangNhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTracNghiem";
            this.Text = "frmTracNghiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTracNghiem_Load);
            this.thongTinDangNhap.ResumeLayout(false);
            this.thongTinDangNhap.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCAUINDEX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCT_BAITHI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip thongTinDangNhap;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMAGV;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHOTEN;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusNHOM;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMALOP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTENLOP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.Button btnCAUSAU;
        private System.Windows.Forms.Button btnCAUTRUOC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNGAYTHI;
        private System.Windows.Forms.Label lblTRINHDO;
        private System.Windows.Forms.Label lblLOP;
        private System.Windows.Forms.Label lblMONHOC;
        private System.Windows.Forms.Button btnNOPBAI;
        private System.Windows.Forms.Label lblTHOIGIANTHI;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label lblTHONGBAO;
        private System.Windows.Forms.NumericUpDown numericUpDownCAUINDEX;
        private System.Windows.Forms.Label lblCHUYENDENCAU;
        private TN_CSDLPTDataSet dS;
        private System.Windows.Forms.BindingSource bdsCT_BAITHI;
        private TN_CSDLPTDataSetTableAdapters.CHITIETBAITHITableAdapter cT_BAITHITableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListView summarylistview;
        private System.Windows.Forms.ColumnHeader question;
        private System.Windows.Forms.ColumnHeader answer;
        private System.Windows.Forms.RichTextBox lblNOIDUNG;
    }
}