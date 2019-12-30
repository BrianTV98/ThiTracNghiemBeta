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
            MessageBox.Show(malop + maMH + lanthi);
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

    }
}
