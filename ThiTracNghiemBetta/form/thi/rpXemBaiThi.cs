using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ThiTracNghiemBetta.form.thi
{
    public partial class rpXemBaiThi : DevExpress.XtraReports.UI.XtraReport
    {
        int idBD;
        public rpXemBaiThi(int idBangDiem)
        {
            idBD = idBangDiem;
            InitializeComponent();

            tN_CSDLPTDataSet1.EnforceConstraints = false;
            this.sP_XEM_CT_BAITHITableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_XEM_CT_BAITHITableAdapter1.Fill(tN_CSDLPTDataSet1.SP_XEM_CT_BAITHI, idBangDiem);
        }

    }
}
