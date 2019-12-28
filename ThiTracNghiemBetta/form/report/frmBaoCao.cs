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
            MessageBox.Show(dtNgayBD.Value.ToString());
            rpDANHSACHDANGKYTHI f = new rpDANHSACHDANGKYTHI(dtNgayBD.Value, dtNgayKT.Value);
            ReportPrintTool print = new ReportPrintTool(f);
            f.lbNgayBD.Text = dtNgayBD.Value.ToShortDateString();
            f.lbNgayKT.Text = dtNgayKT.Value.ToShortDateString(); 
            print.ShowPreviewDialog();

        }
    }
}
