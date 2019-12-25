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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn Học: ";
            // 
            // cb_monHoc
            // 
            this.cb_monHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_monHoc.FormattingEnabled = true;
            this.cb_monHoc.Location = new System.Drawing.Point(314, 142);
            this.cb_monHoc.Name = "cb_monHoc";
            this.cb_monHoc.Size = new System.Drawing.Size(225, 24);
            this.cb_monHoc.TabIndex = 1;
            this.cb_monHoc.SelectedIndexChanged += new System.EventHandler(this.cb_monHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Thi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lần Thi:";
            // 
            // dtPicker
            // 
            this.dtPicker.Enabled = false;
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(314, 196);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(225, 22);
            this.dtPicker.TabIndex = 4;
            // 
            // cb_lanThi
            // 
            this.cb_lanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lanThi.FormattingEnabled = true;
            this.cb_lanThi.Location = new System.Drawing.Point(314, 240);
            this.cb_lanThi.Name = "cb_lanThi";
            this.cb_lanThi.Size = new System.Drawing.Size(225, 24);
            this.cb_lanThi.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(294, 332);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(116, 37);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChonMonThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 454);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cb_lanThi);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_monHoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}