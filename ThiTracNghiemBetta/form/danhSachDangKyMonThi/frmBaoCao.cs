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

namespace ThiTracNghiemBetta.form.report
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (chechValidate() == false)
            {
                MessageBox.Show("Ngày bắt đầu phải sớm hơn hoặc bằng Ngày kết thúc",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rpDANHSACHDANGKYTHI f = new rpDANHSACHDANGKYTHI(dtNgayBD.Value.Date, dtNgayKT.Value.Date);
                ReportPrintTool print = new ReportPrintTool(f);
                f.lbNgayBD.Text = dtNgayBD.Value.ToShortDateString();
                f.lbNgayKT.Text = dtNgayKT.Value.ToShortDateString();
                print.ShowPreviewDialog();
            }    
        }
        private bool chechValidate()
        {
            
            int datetime =  DateTime.Compare(dtNgayBD.Value.Date, dtNgayKT.Value.Date);

            if (datetime > 0)
            {
                return false;
            }
            return true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
