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
            tN_CSDLPTDataSet1.EnforceConstraints = false;
        }

    }
}
