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

        private void frmKHOA_Load(object sender, EventArgs e)
        {
            reloadData();
            groupBox2.Enabled = false;

            if (Program.mNhom == "TRUONG")
            {
                cmbCS.Enabled = true;
                barbtAdd.Enabled = false;
                barbtDel.Enabled = false;
                barbtEdit.Enabled = false;
                barbtSave1.Enabled = barbtRefesh1.Enabled = false;
                groupBox1.Enabled = false;
            }
            else if (Program.mNhom == "COSO")
            {
                cmbCS.Enabled = false;
                barbtAdd.Enabled = true;
                barbtDel.Enabled = true;
                barbtEdit.Enabled = true;
                barbtRefesh1.Enabled = true;
                
                barbtSave1.Enabled = true;
                groupBox1.Enabled = true;
            }

            cmbCS.SelectedIndex = Program.mChiNhanh;
        }

        private void reloadData()
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbCS.SelectedIndex != Program.mChiNhanh)
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

            if (txtTENKH.Text == "")
            {
                MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                txtTENKH.Focus();
                return;
            }
            if (txtMAKH.Text == "")
            {
                MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                txtMAKH.Focus();
                return;
            }

            if (Program.Control == "Add")
            {
                txtMAKH.Text = txtMAKH.Text.ToUpper().Trim();
                txtTENKH.Text = txtTENKH.Text.Trim();

                try
                {
                    int kn = Program.KetNoi();
                    if (kn == 0) return;
                    String strlenh = "EXEC dbo.SP_TIMKIEMKHOA '" + txtMAKH.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                    if (Program.myReader.GetInt16(0) == 1)
                    {
                        MessageBox.Show("Mã khoa đã tồn tại", "", MessageBoxButtons.OK);
                        txtMAKH.Focus();
                        Program.conn.Close();
                        return;
                    }
                    int kn1 = Program.KetNoi();
                    if (kn1 == 0) return;
                    String strlenh1 = "EXEC dbo.SP_TIMKIEMTENKHOA N'" + txtTENKH.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh1);
                    if (Program.myReader.GetInt16(0) == 1)
                    {
                        MessageBox.Show("Tên khoa đã tồn tại", "", MessageBoxButtons.OK);
                        Program.conn.Close();
                        txtMAKH.Focus();
                        return;
                    }
                    this.Validate();
                    this.bdsKHOA.EndEdit();
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                    MessageBox.Show("Đã thêm khoa thành công", "", MessageBoxButtons.OK);
                    barbtRefesh1.Enabled = barbtAdd1.Enabled = barbtDel1.Enabled = barbtEdit1.Enabled = true;
                    barbtSave1.Enabled = false;
                    gcKHOA.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khoa. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {
            gcKHOA.Enabled = false;
            groupBox2.Enabled = true;

            
            
            barbtRefesh1.Enabled = barbtAdd1.Enabled = barbtDel1.Enabled = barbtEdit1.Enabled = false;
            barbtCancel1.Enabled = barbtSave1.Enabled = barbtExit1.Enabled = true;
            bdsKHOA.AddNew();

            if (Program.mChiNhanh == 0)
            {
                txtMACS.Text = "CS1";

            }
            else
            {
                txtMACS.Text = "CS2";
            }
            Program.Control = "Add";
            
        }

        private void barbtReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}