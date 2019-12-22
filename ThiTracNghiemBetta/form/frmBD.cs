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
    public partial class frmBD : DevExpress.XtraEditors.XtraForm
    {
        public frmBD()
        {
            InitializeComponent();
        }

        private void frmBD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.CHITIETBAITHI' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;

            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.dS.BODE);

            defaultCMB();
            normalMode();
        }
        private void defaultCMB()
        {
            cmbDA.SelectedIndex = 0;
            cmbTRINHDO.SelectedIndex = 0;
        }
  
        private void barbtThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            disableModify();
            enableInputs();
            gc_BD.Enabled = false;
            bdsBODE.AddNew();
            //txtIDCH.Text = "0";
            txtIDCH.Focus();
            Program.Control = "add";
        }

        private void disableModify()
        {
            barbtRefresh.Enabled = barbtThem.Enabled = barbtXoa.Enabled = barbtSua.Enabled = false;
            barbtCancel.Enabled = barbtSave.Enabled = barbtExit.Enabled = true;
        }

        private void enableModify()
        {
            barbtRefresh.Enabled = barbtThem.Enabled = barbtXoa.Enabled = barbtSua.Enabled = true;
            barbtCancel.Enabled = barbtSave.Enabled = barbtExit.Enabled = true;
            
        }

        private void normalMode()
        {
            enableModify();
            disableInputs();
            gc_BD.Enabled = true;
            if (Program.mNhom == "TRUONG")
            {
                disableModify();
                barbtRefresh.Enabled = true;
                barbtExit.Enabled = true;
            }
            else if (Program.mNhom == "COSO")
            {
                

            }


        }
        private void disableInputs()
        {
            groupF.Enabled = false;
        }

        private void enableInputs()
        {
            groupF.Enabled = true;

        }

        private bool validate()
        {
            string idCH = txtIDCH.Text.ToString().Trim();
            string maGV = txtGV.Text.ToString().Trim();
            string maMH = txtMAMH.Text.ToString().Trim();
            string trinhDo = txtTRINHDO.Text.ToString().Trim();
            string nd = txtND.Text.ToString().Trim();

            string a = txtA.Text.ToString();
            string b = txtB.Text.ToString();
            string c = txtC.Text.ToString();
            string d = txtD.Text.ToString();

            string da = txtDA.Text.ToString();

            if (idCH == "" || maGV == "" || maMH == "" || trinhDo == "" || nd == "" || a == "" || b == "" || c == "" || d == "" || da == "")
            {
                MessageBox.Show("Vui lòng không để trống!");
                return false;
            }
            if (Program.Control == "add")
            {
                if (isMaCHTontai(idCH))
                {
                    return false;
                }
            }
            return true;
        }
        private bool isMaCHTontai(String ma)
        {
            if (bdsBODE.SupportsSearching != true)
            {
                MessageBox.Show("Cannot search the list.");
                return false;
            }

            else
            {
                int foundIndex = bdsBODE.Find("CAUHOI", ma);
                if (foundIndex >= 0)
                {
                    MessageBox.Show("Mã câu hỏi đã tồn tại");
                    return true;
                }
                return false;
            }
        }

        private void cmbGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGV.Text = cmbGV.SelectedValue.ToString();
        }

        private void cmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMAMH.Text = cmbMH.SelectedValue.ToString();

        }

        private void cmbTRINHDO_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTRINHDO.Text = cmbTRINHDO.SelectedItem.ToString();
        }

        private void cmbDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDA.Text = cmbDA.SelectedItem.ToString();
        }

        private void barbtSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.Control = "edit";
            disableModify();
            enableInputs();
            txtIDCH.Enabled = false;
            gc_BD.Enabled = false;

        }
    }
}