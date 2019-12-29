using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ThiTracNghiemBetta.form.report
{
    public partial class rpDANHSACHDANGKYTHI : DevExpress.XtraReports.UI.XtraReport
    {
       
        public rpDANHSACHDANGKYTHI(DateTime ngaybd, DateTime ngaykt)
        {
            InitializeComponent();  
            this.tN_CSDLPTDataSet1.EnforceConstraints = false;
            this.sP_XEM_DANH_SACH_DANG_KY_THITableAdapter1.Fill(this.tN_CSDLPTDataSet1.SP_XEM_DANH_SACH_DANG_KY_THI, ngaybd, ngaykt);
        }

    }
}
