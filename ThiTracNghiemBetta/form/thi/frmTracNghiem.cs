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

namespace ThiTracNghiemBetta.form.thi
{
    public partial class frmTracNghiem : DevExpress.XtraEditors.XtraForm
    {
        public frmTracNghiem()
        {
            InitializeComponent();
        }
        int index = 0;
        int soCauThi = 0;
        int time = 0;
        int h, m, s;
        float tongDiem = 0;
        int soCauDung = 0;
        List<BoDe> boDe = new List<BoDe>();
        List<GiaoVien> gv_dk = new List<GiaoVien>();
        private void fakeData()
        {
            boDe.Add(new BoDe("", "", "", "Người yêu tôi tên gì?", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            boDe.Add(new BoDe("", "", "", "Câu hỏi 2?", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            boDe.Add(new BoDe("", "", "", "Câu hỏi 3", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            boDe.Add(new BoDe("", "", "", "Câu Hỏi 4?", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            boDe.Add(new BoDe("", "", "", "Câu hỏi 5", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            boDe.Add(new BoDe("", "", "", "Câu hỏi 6", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            soCauThi = boDe.Count;
        }
        private void frmTracNghiem_Load(object sender, EventArgs e)
        {
            fakeData();
            this.cT_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.CT_BAITHI' table. You can move, or remove it, as needed.
            this.cT_BAITHITableAdapter.Fill(this.dS.CHITIETBAITHI);
            // TODO: This line of code loads data into the 'dSQLTN.CT_BAITHI' table. You can move, or remove it, as needed.
            toolStripStatusHOTEN.Text = "Họ và tên: " + Program.mHoTen;
            toolStripStatusMAGV.Text = "Mã SV:" + Program.mUserId;
            toolStripStatusNHOM.Text = "nhóm: SINHVIEN";
            toolStripStatusMALOP.Text = "mã lớp: " + Program.svMaLop;
            toolStripStatusTENLOP.Text = "tên lớp: " + Program.svTenLop;
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + index + 1 + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            /*            GiaoVien g = (GiaoVien)gv_dk[GiaoVien.gv_dkIndex];
                        soCauThi = g.getSoCauThi();
                        String lenh = "EXEC SP_TIMKIEMMH '" + g.getMaMH() + "'";
                        Program.myReader = Program.ExecSqlDataReader(lenh);
                        Program.myReader.Read();
                        String tenMH = Program.myReader.GetString(0);
                        Program.myReader.Close();
                        lblLOP.Text = "Lớp: " + Program.svTenLop;
                        lblMONHOC.Text = "Môn học: " + tenMH;
                        lblNGAYTHI.Text = "Ngày thi: " + g.getNgayThi().Substring(0, 10);
                        lblTRINHDO.Text = "Trình độ: " + g.getTrinhDo();*/
            btnCAUTRUOC.Enabled = false;
            //time = g.getThoiGian();
            h = time / 60;
            m = time - 60 * h;
            s = 0;
            lblTHOIGIANTHI.Text = "Còn lại: " + h + ":" + m + ":" + s;

            //Copy dữ liệu từ bộ đề sang chi tiết bài thi
            int i = 1;
            /* foreach (BoDe b2 in BoDe.boDe)
             {
                 int cauHoi = b2.getCauHoi();
                 String maMH = b2.getMaMH();
                 String trinhDo = b2.getTrinhDo();
                 String noiDung = b2.NoiDung;
                 String A = b2.DapAnA;
                 String B = b2.DapAnB;
                 String C = b2.DapAnC;
                 String D = b2.DapAnD;
                 String dapAn = b2.getDapAn();
                 String maGV = b2.getMaGV();
                 String dapAnDaChon = "";
                 CT_BaiThi ct = new CT_BaiThi(cauHoi, i, noiDung, A, B, C, D, dapAn, dapAnDaChon);
                 CT_BaiThi.ct_baiThi.Add(ct);
                 i++;
             }*/
            /*cập nhật thông báo đáp án đã chọn*/
            //     capNhatThongBaoDapAnDaChon();
            numericUpDownCAUINDEX.Maximum = 100;
            numericUpDownCAUINDEX.Minimum = 1;

            summarylistview.View = View.Details;
            summarylistview.GridLines = true;
            summarylistview.FullRowSelect = true;
            /* foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
             {
                 String[] arr = new string[2];
                 arr[0] = ct.getThuTu().ToString();
                 arr[1] = ct.getDapAnDaChon().ToString();
                 ListViewItem baiThi = new ListViewItem(arr);
                 this.summarylistview.Items.Add(baiThi);
             }*/
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == -1)
            {
                if (m == 0)
                {
                    if (h == 0)
                    {
                        //                      lblTHOIGIANTHI.Text = "Còn lại: " + h + ":" + m + ":" + s;
                        lblTHONGBAO.Text = "Hết giờ làm bài!";
                        clock.Stop();
                        chamDiem();
                        ghiBangDiemVaBaiThi();

                    }
                    else
                    {
                        h--;
                        m = 59;
                        lblTHOIGIANTHI.Text = "Còn lại: " + h + ":" + m + ":" + s;
                    }
                }
                else
                {
                    m--;
                    s = 59;
                    lblTHOIGIANTHI.Text = "Còn lại: " + h + ":" + m + ":" + s;
                }
            }
            lblTHOIGIANTHI.Text = "Còn lại: " + h + ":" + m + ":" + s;
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
            /* CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
             ct.setDapDaChon("A");
             CT_BaiThi.ct_baiThi[index] = ct;
             capNhatThongBaoDapAnDaChon(index);*/
        }

        private void rdoB_CheckedChanged(object sender, EventArgs e)
        {
            /*CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            ct.setDapDaChon("B");
            CT_BaiThi.ct_baiThi[index] = ct;
            capNhatThongBaoDapAnDaChon(index);*/
        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            /*CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            ct.setDapDaChon("C");
            CT_BaiThi.ct_baiThi[index] = ct;
            capNhatThongBaoDapAnDaChon(index);*/
        }

        private void rdoD_CheckedChanged(object sender, EventArgs e)
        {
            /*CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            ct.setDapDaChon("D");
            CT_BaiThi.ct_baiThi[index] = ct;
            capNhatThongBaoDapAnDaChon(index);*/
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
                this.clock.Stop();
                chamDiem();
                ghiBangDiemVaBaiThi();
                /*Program.formSV = new frmSV();
                Program.formSV.Activate();
                Program.formSV.Show();
                Program.formTracNghiem.Hide();*/
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
            /* CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
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
             }*/
        }

        private void chamDiem()
        {
            /* float diemMoiCau = (float)10 / soCauThi;
             foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
             {
                 if (ct.getDapAnDaChon().Equals(ct.getDapAnDung()))
                 {
                     tongDiem += diemMoiCau;
                     soCauDung++;
                 }
             }
             tongDiem = (float)Math.Round(tongDiem, 2);*/
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

        private void cT_BAITHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCT_BAITHI.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

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
            /* GiaoVien g = (GiaoVien)GiaoVien.gv_dk[GiaoVien.gv_dkIndex];
             BangDiem bd = new BangDiem(Program.username, g.getMaMH(), g.getLan(), g.getNgayThi(), tongDiem);
             bd.ghiDiem();
             String strlenh = "EXEC SP_TIMBANGDIEM_THI '" + Program.username + "', '" + g.getMaMH() + "', " + g.getLan();
             Program.myReader.Close();

             Program.myReader = Program.ExecSqlDataReader(strlenh);
             Program.myReader.Read();

             int idBangDiem = Program.myReader.GetInt32(6);
             Program.myReader.Close();
             foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
             {
                 bdsCT_BAITHI.AddNew();
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["THUTU"] = ct.getThuTu();
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["NOIDUNG"] = ct.NoiDung;
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["A"] = ct.DapAnA;
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["B"] = ct.DapAnB;
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["C"] = ct.DapAnC;
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["D"] = ct.DapAnD;
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["DAPANDUNG"] = ct.getDapAnDung();
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["DAPANCHON"] = ct.getDapAnDaChon();
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["ID_BANGDIEM"] = idBangDiem;
                 ((DataRowView)bdsCT_BAITHI[bdsCT_BAITHI.Position])["CAUHOI"] = ct.getCauHoi();
                 bdsCT_BAITHI.EndEdit();
             }
             try
             {
                 cT_BAITHITableAdapter.Update(this.dS.CT_BAITHI);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

             DialogResult dialogResult = MessageBox.Show("Số câu đúng: " + soCauDung + "/" + soCauThi + "\nTổng điểm: " + tongDiem + "\nBạn có muốn xem lại bài thi?", "KẾT QUẢ", MessageBoxButtons.YesNoCancel);
             if (dialogResult == DialogResult.Yes)
             {
                 frmReportXemBaiThiSV rp = new frmReportXemBaiThiSV(idBangDiem);
                 rp.lblHOTEN.Text = "HỌ TÊN: " + Program.mHoTen;
                 rp.lblLOP.Text = "LỚP: " + Program.svTenLop;
                 rp.lblMONTHI.Text = this.lblMONHOC.Text;
                 rp.lblNGAYTHI.Text = "NGÀY THI: " + lblNGAYTHI.Text;

                 rp.lblLAN.Text = "LẦN: " + g.getLan();
                 ReportPrintTool print = new ReportPrintTool(rp);
                 print.ShowPreviewDialog();
             }
             else if (dialogResult == DialogResult.No)
             {
             }
             else if (dialogResult == DialogResult.Cancel)
             {

             }
             *//*dọn dẹp*//*
             GiaoVien.gv_dk.Clear();
             GiaoVien.gv_dkIndex = 0;
             CT_BaiThi.ct_baiThi.Clear();
             BoDe.boDe.Clear();*/
        }

        private void capNhatThongBaoDapAnDaChon(int cau)
        {
            /*CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[cau];
            String[] arr = new string[2];
            arr[0] = ct.getThuTu().ToString();
            arr[1] = ct.getDapAnDaChon().ToString();
            ListViewItem baiThi = new ListViewItem(arr);
            this.summarylistview.Items[cau] = baiThi;*/
        }

    }
}