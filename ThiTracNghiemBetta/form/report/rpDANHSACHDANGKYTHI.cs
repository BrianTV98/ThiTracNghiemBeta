using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ThiTracNghiemBetta.form.report
{
    public partial class rpDANHSACHDANGKYTHI : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime ngayBD;
        private DateTime ngayKT;
        public rpDANHSACHDANGKYTHI(DateTime ngaybd, DateTime ngaykt)
        {
            InitializeComponent();
            this.ngayBD = ngaybd;
            this.ngayKT = ngayKT;
            //sqlDataSource1.EnforceConstraints = false;
            this.sP_XEM_DANH_SACH_DANG_KY_THITableAdapter1.Fill(tN_CSDLPTDataSet1.SP_XEM_DANH_SACH_DANG_KY_THI, new DateTime(2018,12,12), new DateTime (2020,12,12));

        }

    }
}
