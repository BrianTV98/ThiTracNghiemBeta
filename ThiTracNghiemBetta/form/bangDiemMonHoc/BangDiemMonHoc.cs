using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiemBetta.form.thi;

namespace ThiTracNghiemBetta.form.report
{
    public partial class BangDiemMonHoc : Form
    {
        private string malop = "";
        private string tenlop = "";
        private string maMH = "";
        private string tenMH = "";
        private int lanthi = 0; 
        public BangDiemMonHoc()
        {
            InitializeComponent();
            if (Program.mNhom == "TRUONG")
            {
                pnChiNhanh.Enabled = true;
            }
            else pnChiNhanh.Enabled = false;
            
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();    
        }

        private void BangDiemMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.tN_CSDLPTDataSet.EnforceConstraints = false;
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.tN_CSDLPTDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.

            this.tN_CSDLPTDataSet.EnforceConstraints = true;
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            malop = cbMaLop.SelectedValue.ToString().Trim();
            tenlop = cbMaLop.Text.Trim();
            maMH = cbMonHoc.SelectedValue.ToString().Trim();
            tenMH = cbMonHoc.Text.Trim();
            lanthi = (int)txtLan.Value;
            try
            {
                sP_GET_BANG_DIEM_THEO_LOPTableAdapter.Fill(this.tN_CSDLPTDataSet.SP_GET_BANG_DIEM_THEO_LOP, malop,maMH,lanthi );
                gvBangDiem.DataSource = this.tN_CSDLPTDataSet.SP_GET_BANG_DIEM_THEO_LOP;
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rpBangDiemMonHocj f = new rpBangDiemMonHocj(malop,maMH,lanthi);
            f.lbTenLop.Text = tenlop;
            f.lbTenMH.Text = tenMH;
            ReportPrintTool print = new ReportPrintTool(f);
            print.ShowPreviewDialog();
        }

        private void gvBangDiem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var rowH = gvBangDiem.Rows.Count;
            var focusRowView = gvBangDiem.CurrentRow;
            if (focusRowView == null || focusRowView.IsNewRow)
            {
                //popupMenuThemLop.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
                return;
            }

            if (rowH >= 0)
            {
                popupMenuBangDiem.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));

            }
            else
            {
                popupMenuBangDiem.HidePopup();
                // popupMenuThemLop.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
             * Lay Ma SV, Ma Mh, Lan  trong row
             * Get Bang Diem -> Lay ra id bai thi
             * Show Ra
             */
            string maSv= gvBangDiem.CurrentRow.Cells[0].Value.ToString();
            Program.myReader = Program.ExecSqlDataReader("EXEC SP_TIMBANGDIEM_THI '" + maSv + "','"+ maMH+"','"+lanthi+"'");
            Program.myReader.Read();
            int maBaiThi = Program.myReader.GetInt32(5);
            String ngaythi = Program.myReader.GetDateTime(3).ToString();
            Program.myReader.Close();


            
            rpXemBaiThi rp = new rpXemBaiThi(maBaiThi);
            rp.lbHoTen.Text = "HỌ TÊN: " + gvBangDiem.CurrentRow.Cells[1].Value.ToString();
            rp.lbLop.Text = "LỚP: " + tenlop;
            rp.lbMonHoc.Text = "MÔN THI: " + tenMH;
            rp.lbNgayThi.Text = "NGÀY THI: " + ngaythi;
            rp.lbLanThi.Text = "LẦN: " + lanthi;
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
