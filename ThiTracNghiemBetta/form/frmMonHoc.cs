using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemBetta.form
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.tN_CSDLPTDataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);

        }

        private void btnAddMH_Click(object sender, EventArgs e)
        {
            try
            {
                edtMaMH.Text = edtMaMH.Text.ToUpper().Trim();
                edtTenMH.Text = edtTenMH.Text.ToUpper().Trim();
                Boolean isValidate = true;
                if (edtTenMH.Text == "")
                {
                    edtTenMH.Focus();
                    isValidate = false;
                }
                
                if (edtMaMH.Text == "")
                {
                    edtMaMH.Focus();
                    isValidate = false;
                }

                if (!isValidate)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "", MessageBoxButtons.OK);
                    return;
                }

                int kq = Program.KetNoi();
                if (kq == 0) return;
                String strlenh = "EXEC dbo.SP_TIMKIEMMH '" + edtMaMH.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader.Read() != false)
                {
                    MessageBox.Show("Mã môn học đã tồn tại", "", MessageBoxButtons.OK);
                    Program.conn.Close();
                    edtMaMH.Focus();
                    return;
                }
                int kn1 = Program.KetNoi();
                if (kn1 == 0) return;
                String strlenh1 = "EXEC dbo.SP_TIMKIEMTENMH N'" + edtTenMH.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                if (Program.myReader.Read() != false)
                {
                    MessageBox.Show("Tên môn học đã tồn tại", "", MessageBoxButtons.OK);
                    Program.conn.Close();
                    edtTenMH.Focus();
                    return;
                }
                try
                {
                    this.Validate();
                    // this.bdsMH.EndEdit();
                    // this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi môn học." + ex.Message, "", MessageBoxButtons.OK);
                }
  /*              if (Program.Control == "Edit")
                {
                    int kn1 = Program.KetNoi();
                    if (kn1 == 0) return;
                    String strlenh1 = "EXEC dbo.SP_TIMKIEMTENMH N'" + edtTenMH.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh1);
                    if (Program.myReader.Read() != false)
                    {
                        MessageBox.Show("Tên môn học đã tồn tại", "", MessageBoxButtons.OK);
                        Program.conn.Close();
                        edtTenMH.Focus();
                        return;
                    }
                    try
                    {
                        this.Validate();
                        this.bdsMH.EndEdit();
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi sửa môn học.", "", MessageBoxButtons.OK);
                    }
                }
                groupBox1.Enabled = false;
                gcMH.Enabled = true;
                barbtRefesh.Enabled = barbtEdit.Enabled = barbtAdd.Enabled = barbtDel.Enabled = true;
                barbtSave.Enabled = false;
                bdsMH.Filter = "XOA = '0'";
                Program.Control = "";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addMHGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void edtMaMH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barBtnThemMH_Click(object sender, EventArgs e)
        {

        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
