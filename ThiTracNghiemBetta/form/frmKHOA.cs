using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ThiTracNghiemBetta.form
{
    public partial class frmKHOA : Form
    {
        public frmKHOA()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.kHOABindingSource.EndEdit();
            
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void frmKHOA_Load(object sender, EventArgs e)
        {
            reloadData();

            if (Program.mNhom == "TRUONG")
            {
                cmbCS.Enabled = true;
                barbtAdd.Enabled = false;
                barbtDel.Enabled = false;
                barbtEdit.Enabled = false;
                barbtSave.Enabled = barbtReset.Enabled = false;
                groupBox1.Enabled = false;
            }
            else if (Program.mNhom == "COSO")
            {
                cmbCS.Enabled = false;
                barbtAdd.Enabled = true;
                barbtDel.Enabled = true;
                barbtEdit.Enabled = true;
                barbtReset.Enabled = true;
                
                barbtSave.Enabled = true;
                groupBox1.Enabled = true;
            }
        }

        private void reloadData()
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet.KHOA);
        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCS.SelectedValue != null)
            {
              
                Program.servername = cmbCS.SelectedValue.ToString();
                
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
                else
                {
                    reloadData();
                }

            }
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barbtSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}