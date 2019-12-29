namespace ThiTracNghiemBetta.form.thi
{
    partial class frmChonMonThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_monHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.cb_lanThi = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblSOCAU = new System.Windows.Forms.Label();
            this.lblTHOIGIAN = new System.Windows.Forms.Label();
            this.lblTRINHDO = new System.Windows.Forms.Label();
            this.lbSoCau = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbTrinhDo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn Học: ";
            // 
            // cb_monHoc
            // 
            this.cb_monHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_monHoc.FormattingEnabled = true;
            this.cb_monHoc.Location = new System.Drawing.Point(244, 77);
            this.cb_monHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cb_monHoc.Name = "cb_monHoc";
            this.cb_monHoc.Size = new System.Drawing.Size(170, 21);
            this.cb_monHoc.TabIndex = 1;
            this.cb_monHoc.SelectedIndexChanged += new System.EventHandler(this.cb_monHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Thi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lần Thi:";
            // 
            // dtPicker
            // 
            this.dtPicker.Enabled = false;
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(244, 121);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(170, 20);
            this.dtPicker.TabIndex = 4;
            // 
            // cb_lanThi
            // 
            this.cb_lanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lanThi.FormattingEnabled = true;
            this.cb_lanThi.Location = new System.Drawing.Point(244, 157);
            this.cb_lanThi.Margin = new System.Windows.Forms.Padding(2);
            this.cb_lanThi.Name = "cb_lanThi";
            this.cb_lanThi.Size = new System.Drawing.Size(170, 21);
            this.cb_lanThi.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(413, 328);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(87, 30);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Thi nào";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSOCAU
            // 
            this.lblSOCAU.AutoSize = true;
            this.lblSOCAU.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOCAU.Location = new System.Drawing.Point(241, 206);
            this.lblSOCAU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSOCAU.Name = "lblSOCAU";
            this.lblSOCAU.Size = new System.Drawing.Size(59, 17);
            this.lblSOCAU.TabIndex = 7;
            this.lblSOCAU.Text = "Số câu:";
            // 
            // lblTHOIGIAN
            // 
            this.lblTHOIGIAN.AutoSize = true;
            this.lblTHOIGIAN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHOIGIAN.Location = new System.Drawing.Point(241, 240);
            this.lblTHOIGIAN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTHOIGIAN.Name = "lblTHOIGIAN";
            this.lblTHOIGIAN.Size = new System.Drawing.Size(76, 17);
            this.lblTHOIGIAN.TabIndex = 9;
            this.lblTHOIGIAN.Text = "Thời gian:";
            // 
            // lblTRINHDO
            // 
            this.lblTRINHDO.AutoSize = true;
            this.lblTRINHDO.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRINHDO.Location = new System.Drawing.Point(241, 275);
            this.lblTRINHDO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTRINHDO.Name = "lblTRINHDO";
            this.lblTRINHDO.Size = new System.Drawing.Size(71, 17);
            this.lblTRINHDO.TabIndex = 8;
            this.lblTRINHDO.Text = "Trình độ:";
            // 
            // lbSoCau
            // 
            this.lbSoCau.AutoSize = true;
            this.lbSoCau.Location = new System.Drawing.Point(328, 195);
            this.lbSoCau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoCau.Name = "lbSoCau";
            this.lbSoCau.Size = new System.Drawing.Size(0, 13);
            this.lbSoCau.TabIndex = 10;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Location = new System.Drawing.Point(328, 230);
            this.lbThoiGian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(0, 13);
            this.lbThoiGian.TabIndex = 11;
            // 
            // lbTrinhDo
            // 
            this.lbTrinhDo.AutoSize = true;
            this.lbTrinhDo.Location = new System.Drawing.Point(328, 264);
            this.lbTrinhDo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTrinhDo.Name = "lbTrinhDo";
            this.lbTrinhDo.Size = new System.Drawing.Size(0, 13);
            this.lbTrinhDo.TabIndex = 12;
            // 
            // frmChonMonThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 369);
            this.Controls.Add(this.lbTrinhDo);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.lbSoCau);
            this.Controls.Add(this.lblSOCAU);
            this.Controls.Add(this.lblTHOIGIAN);
            this.Controls.Add(this.lblTRINHDO);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cb_lanThi);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_monHoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChonMonThi";
            this.Text = "frmChonMonThi";
            this.Load += new System.EventHandler(this.frmChonMonThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_monHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.ComboBox cb_lanThi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblSOCAU;
        private System.Windows.Forms.Label lblTHOIGIAN;
        private System.Windows.Forms.Label lblTRINHDO;
        private System.Windows.Forms.Label lbSoCau;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label lbTrinhDo;
    }
}