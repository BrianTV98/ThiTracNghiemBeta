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
        public BangDiemMonHoc()
        {
            InitializeComponent();
            
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
        }

        private void BangDiemMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.tN_CSDLPTDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.


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

        

        private void gvBangDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malop = cbMaLop.SelectedValue.ToString().Trim();
            string maMH = cbMonHoc.SelectedValue.ToString().Trim();
            int lanthi = (int)txtLan.Value;
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
    }
}
