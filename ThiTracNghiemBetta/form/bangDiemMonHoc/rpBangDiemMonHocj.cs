using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ThiTracNghiemBetta.form.report
{
    public partial class rpBangDiemMonHocj : DevExpress.XtraReports.UI.XtraReport
    {
        private  string malop;
        private string maMH;
        private int lanthi;

        public rpBangDiemMonHocj(string malop, string maMH, int lanthi)
        {
            InitializeComponent();
            this.malop = malop;
            this.maMH = maMH;
            this.lanthi = lanthi;
            tN_CSDLPTDataSet1.EnforceConstraints = false;
            this.sP_GET_BANG_DIEM_THEO_LOPTableAdapter.Fill(tN_CSDLPTDataSet1.SP_GET_BANG_DIEM_THEO_LOP, malop, maMH, lanthi);
        }

    }
}
