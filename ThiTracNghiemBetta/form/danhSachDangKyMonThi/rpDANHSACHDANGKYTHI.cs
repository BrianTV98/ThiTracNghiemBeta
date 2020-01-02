using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using static ThiTracNghiemBetta.TN_CSDLPTDataSet;

namespace ThiTracNghiemBetta.form.report
{
    public partial class rpDANHSACHDANGKYTHI : DevExpress.XtraReports.UI.XtraReport
    {

        public rpDANHSACHDANGKYTHI(DateTime ngaybd, DateTime ngaykt, string chiNhanh)
        {
            InitializeComponent();  
            this.tN_CSDLPTDataSet1.EnforceConstraints = false;
            SP_XEM_DANH_SACH_DANG_KY_THIDataTable datatable = this.tN_CSDLPTDataSet1.SP_XEM_DANH_SACH_DANG_KY_THI;

            if (Program.mNhom.Equals("TRUONG"))
            {
                this.sP_XEM_DANH_SACH_DANG_KY_THITableAdapter1.Fill(this.tN_CSDLPTDataSet1.SP_XEM_DANH_SACH_DANG_KY_THI, ngaybd, ngaykt,"-1");
            }
            else {
                this.sP_XEM_DANH_SACH_DANG_KY_THITableAdapter1.Fill(this.tN_CSDLPTDataSet1.SP_XEM_DANH_SACH_DANG_KY_THI, ngaybd, ngaykt, chiNhanh);
            }
            
        }

    }
}
