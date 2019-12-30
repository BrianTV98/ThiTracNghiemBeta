using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ThiTracNghiemBetta.models;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace ThiTracNghiemBetta.form.thi
{
    public partial class frmThiThu : DevExpress.XtraEditors.XtraForm
    {
        List<BoDe> boDe = BoDe.thithu;
        GiaoVienDK g = GiaoVienDK.thithu;
        public frmThiThu()
        {
            InitializeComponent();

        }
        int index = 0;
        int soCauThi = 0;
        Timer t = new Timer();
        int mm = 1;
        int ss = 0;
        float tongDiem = 0;
        int soCauDung = 0;
        

        private void frmTracNghiem_Load(object sender, EventArgs e)
        {
      
            soCauThi = boDe.Count;
            this.cT_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CT_BAITHI' table. You can move, or remove it, as needed.
            //this.cT_BAITHITableAdapter.Fill(this.dS.CHITIETBAITHI);
            // TODO: This line of code loads data into the 'dSQLTN.CT_BAITHI' table. You can move, or remove it, as needed.
            toolStripStatusHOTEN.Text = "Họ và tên: " + Program.mHoTen;
            toolStripStatusMAGV.Text = "Mã SV:" + Program.mUserId;
            toolStripStatusNHOM.Text = "nhóm: SINHVIEN";
            toolStripStatusMALOP.Text = "mã lớp: ";
            toolStripStatusTENLOP.Text = "tên lớp: ";

            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + index + 1 + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            
            soCauThi = g.SoCauThi;
            String lenh = "EXEC SP_TIMKIEMMH '" + g.MaMH + "'";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            Program.myReader.Read();
            String tenMH = Program.myReader.GetString(1);
            Program.myReader.Close();
            lblLOP.Text = "Lớp: " + "";
            lblMONHOC.Text = "Môn học: " + tenMH;
            lblNGAYTHI.Text = "Ngày thi: " + g.NgayThi.ToString("dd/MM/yyyy");
            lblTRINHDO.Text = "Trình độ: " + g.TrinhDo;
            btnCAUTRUOC.Enabled = false;
            mm = g.ThoiGian;
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            
            t.Start();
            //Copy dữ liệu từ bộ đề sang chi tiết bài thi
            int i = 1;
            foreach (BoDe b2 in boDe)
            {
                int cauHoi = b2.CauHoi;
                String maMH = b2.MaMH;
                String trinhDo = b2.TrinhDo;
                String noiDung = b2.NoiDung;
                String A = b2.DapAnA;
                String B = b2.DapAnB;
                String C = b2.DapAnC;
                String D = b2.DapAnD;
                String dapAn = b2.DapAnDung;
                String maGV = b2.MaGV;
                String dapAnDaChon = "";
                CT_BaiThi ct = new CT_BaiThi(cauHoi, i, noiDung, A, B, C, D, dapAn, dapAnDaChon);
                CT_BaiThi.thithu.Add(ct);
                i++;
            }
            /*cập nhật thông báo đáp án đã chọn*/
            //     capNhatThongBaoDapAnDaChon();
            numericUpDownCAUINDEX.Maximum = 100;
            numericUpDownCAUINDEX.Minimum = 1;

            summarylistview.View = View.Details;
            summarylistview.GridLines = true;
            summarylistview.FullRowSelect = true;
            foreach (CT_BaiThi ct in CT_BaiThi.thithu)
            {
                String[] arr = new string[2];
                arr[0] = ct.getThuTu().ToString();
                arr[1] = ct.getDapAnDaChon().ToString();
                ListViewItem baiThi = new ListViewItem(arr);
                this.summarylistview.Items.Add(baiThi);
            }
        }
        private void t_Tick(object sender, EventArgs e)
        {
            //get time;
            string time = "";
            string timess = "";
            string timemm = "";
            if (mm == 0 && ss == 0)
            {
                t.Stop();
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                lblTHONGBAO.Text = "Hết giờ làm bài!";
                chamDiem();
                ghiBangDiemVaBaiThi();
                this.Close();
            }
            if (ss != 0)
            {
                ss--;
            }
            else
            {
                mm--;
                ss = 59;
            }
            if (mm < 10)
            {
                timemm = "0" + mm;
            }
            else timemm = mm.ToString();
            if (ss < 10)
            {
                timess = "0" + ss;
            }
            else timess = ss.ToString();
            time = "Còn lại: "+ timemm + ":" + timess;
            lblTHOIGIANTHI.Text = time;
        }


        private void btnCAUSAU_Click(object sender, EventArgs e)
        {
            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;
            index++;
            numericUpDownCAUINDEX.Value = index + 1;
            btnCAUTRUOC.Enabled = true;
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + (index + 1) + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            if (index == soCauThi - 1)
            {
                btnCAUSAU.Enabled = false;
            }
            this.checkDapAnDaChon();
        }

        private void rdoA_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.thithu[index];
            ct.setDapDaChon("A");
            CT_BaiThi.thithu[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void rdoB_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.thithu[index];
            ct.setDapDaChon("B");
            CT_BaiThi.thithu[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.thithu[index];
            ct.setDapDaChon("C");
            CT_BaiThi.thithu[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void rdoD_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.thithu[index];
            ct.setDapDaChon("D");
            CT_BaiThi.thithu[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void btnCAUTRUOC_Click(object sender, EventArgs e)
        {

            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;
            index--;
            numericUpDownCAUINDEX.Value = index + 1;

            btnCAUSAU.Enabled = true;
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + (index + 1) + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            if (index == 0)
            {
                btnCAUTRUOC.Enabled = false;
            }
            this.checkDapAnDaChon();
        }

        private void btnNOPBAI_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn nộp bài thi?", "CẢNH BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                t.Stop();
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                chamDiem();
                ghiBangDiemVaBaiThi();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void checkDapAnDaChon()
        {
             CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.thithu[index];
             if (ct.getDapAnDaChon().Equals(""))
             {
                 rdoA.Checked = false;
                 rdoB.Checked = false;
                 rdoC.Checked = false;
                 rdoD.Checked = false;
             }
             else
             {
                 switch (ct.getDapAnDaChon())
                 {
                     case "A":
                         {
                             rdoA.Checked = true;
                             rdoB.Checked = false;
                             rdoC.Checked = false;
                             rdoD.Checked = false;
                             break;
                         }
                     case "B":
                         {
                             rdoA.Checked = false;
                             rdoB.Checked = true;
                             rdoC.Checked = false;
                             rdoD.Checked = false;
                             break;
                         }
                     case "C":
                         {
                             rdoA.Checked = false;
                             rdoB.Checked = false;
                             rdoC.Checked = true;
                             rdoD.Checked = false;
                             break;
                         }
                     case "D":
                         {
                             rdoA.Checked = false;
                             rdoB.Checked = false;
                             rdoC.Checked = false;
                             rdoD.Checked = true;
                             break;
                         }
                 }
             }
        }

        private void chamDiem()
        {
            float diemMoiCau = (float)10 / soCauThi;
             foreach (CT_BaiThi ct in CT_BaiThi.thithu)
             {
                 if (ct.getDapAnDaChon().Equals(ct.getDapAnDung()))
                 {
                     tongDiem += diemMoiCau;
                     soCauDung++;
                 }
             }
             tongDiem = (float)Math.Round(tongDiem, 2);
        }

        private void numericUpDownCAUINDEX_ValueChanged(object sender, EventArgs e)
        {
            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;
            index = (int)numericUpDownCAUINDEX.Value - 1;
            if (index <= 0)
            {
                btnCAUTRUOC.Enabled = false;
                btnCAUSAU.Enabled = true;
                index = 0;
                numericUpDownCAUINDEX.Value = index + 1;
            }
            else if (index >= soCauThi - 1)
            {
                btnCAUSAU.Enabled = false;
                btnCAUTRUOC.Enabled = true;
                index = soCauThi - 1;
                numericUpDownCAUINDEX.Value = index + 1;
            }
            else
            {
                btnCAUTRUOC.Enabled = true;
                btnCAUSAU.Enabled = true;
            }
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + (index + 1) + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            if (index == 0)
            {
                btnCAUTRUOC.Enabled = false;
            }
            this.checkDapAnDaChon();
        }
        private void summarylistview_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;
            int i = 0;
            try
            {
                i = index;
                index = summarylistview.FocusedItem.Index;
            }
            catch (Exception)
            {
                index = i;
            }
            if (index <= 0)
            {
                btnCAUTRUOC.Enabled = false;
                btnCAUSAU.Enabled = true;
                index = 0;
                numericUpDownCAUINDEX.Value = index + 1;
            }
            else if (index >= soCauThi - 1)
            {
                btnCAUSAU.Enabled = false;
                btnCAUTRUOC.Enabled = true;
                index = soCauThi - 1;
                numericUpDownCAUINDEX.Value = index + 1;
            }
            else
            {
                btnCAUTRUOC.Enabled = true;
                btnCAUSAU.Enabled = true;
            }
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + (index + 1) + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            if (index == 0)
            {
                btnCAUTRUOC.Enabled = false;
            }
            this.checkDapAnDaChon();
        }

        private void ghiBangDiemVaBaiThi()
        {

            this.Hide();
            DialogResult dialogResult = MessageBox.Show("Số câu đúng: " + soCauDung + "/" + soCauThi + "\nTổng điểm: " + tongDiem + "\nBạn có muốn xem lại bài thi?", "KẾT QUẢ", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                frmKQThiThu kq = new frmKQThiThu();
                kq.Show();

            }
            GiaoVienDK.thithu = null;
            CT_BaiThi.thithu.Clear();
            BoDe.thithu.Clear();
            
        }

        private void capNhatThongBaoDapAnDaChon(int cau)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.thithu[cau];
            String[] arr = new string[2];
            arr[0] = ct.getThuTu().ToString();
            arr[1] = ct.getDapAnDaChon().ToString();
            ListViewItem baiThi = new ListViewItem(arr);
            this.summarylistview.Items[cau] = baiThi;
        }

    }
}