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
using DevExpress.XtraReports.UI;

namespace ThiTracNghiemBetta.form.thi
{
    public partial class formXemBaiThiSV : DevExpress.XtraEditors.XtraForm
    {
        public formXemBaiThiSV()
        {
            InitializeComponent();
        }

        private void formXemBaiThiSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.tN_CSDLPTDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            if (Program.mNhom == "SINHVIEN")
            {
                bANGDIEMBindingSource.Filter = " MASV= '" + Program.mUserId + "'";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.tN_CSDLPTDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.

            if (Program.mNhom == "SINHVIEN")
            {
                bANGDIEMBindingSource.Filter = " MASV= '" + Program.mUserId + "'";
            }
        }

        private void btnXemBaiThi_Click(object sender, EventArgs e)
        {
            int viTri = bANGDIEMBindingSource.Position;
            if (viTri == -1)
            {
                MessageBox.Show("Chọn 1 bảng điểm để xem nhé :)");
                return;
            }
            int id_bangdiem = int.Parse(((DataRowView)bANGDIEMBindingSource[viTri])["MA_BAI_THI"].ToString());
            rpXemBaiThi rp = new rpXemBaiThi(id_bangdiem);
            rp.lbHoTen.Text = "HỌ TÊN: " + Program.mHoTen;
            rp.lbLop.Text = "LỚP: " + Program.tenlop;

            String maMonThi = ((DataRowView)bANGDIEMBindingSource[viTri])["MAMH"].ToString();
            Program.myReader = Program.ExecSqlDataReader("EXEC SP_TIMKIEMMH '" + maMonThi + "'");
            Program.myReader.Read();
            String tenMonThi = Program.myReader.GetString(1);
            Program.myReader.Close();
            rp.lbMonHoc.Text = "MÔN THI: " + tenMonThi;
            String ngayThi = ((DataRowView)bANGDIEMBindingSource[viTri])["NGAYTHI"].ToString();
            rp.lbNgayThi.Text = "NGÀY THI: " + ngayThi.Substring(0, 10);
            String lan = ((DataRowView)bANGDIEMBindingSource[viTri])["LAN"].ToString();
            rp.lbLanThi.Text = "LẦN: " + lan;
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}