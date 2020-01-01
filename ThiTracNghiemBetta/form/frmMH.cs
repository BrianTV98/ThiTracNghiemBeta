using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ThiTracNghiemBetta.form
{
    public partial class frmMH :Form
    {
        public frmMH()
        {
            InitializeComponent();
        }

        private void frmMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.rootSeverName;
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS.V_DS_PHANMANH);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
           
            bdsMH.Filter = "XOA = 0";

            if (Program.mNhom == "TRUONG")
            {
               btnHuy.Enabled = barbtAdd.Enabled = barbtDel.Enabled = barbtEdit.Enabled = barbtSave.Enabled = groupBox1.Enabled = false;

            }
            else
            {
                pnChiNhanh.Enabled = false;
                groupBox1.Enabled = false;
                barbtSave.Enabled = false;
            }

            cmbCS.SelectedIndex = Program.mChiNhanh;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            gcMH.Enabled = false;
            barbtRefesh.Enabled = barbtAdd.Enabled = barbtDel.Enabled = barbtEdit.Enabled = false;
            barbtSave.Enabled = true;
            this.bdsMH.RemoveFilter();
            this.bdsMH.AddNew();
            ((DataRowView)bdsMH[bdsMH.Position])["XOA"] = 0;
            txtMAMH.Enabled = true;
            txtMAMH.Focus();
            Program.Control = "Add";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa mã môn học " + txtMAMH.Text + " không?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int kq = Program.KetNoi();
                    if (kq == 0) return;
                    SqlCommand sqlCommand = new SqlCommand("SP_DELETEMAMH", Program.conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@MaMH", txtMAMH.Text.Trim());
                    kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
                    Program.conn.Close();
                    if (kq == 1) // ton tai
                    {
                        MessageBox.Show("Môn học đã có dữ liệu trên bảng điểm");
                        return;
                    }
                    if (kq == 2) // ton tai
                    {
                        MessageBox.Show("Môn học đã có dữ liệu trên bộ đề");
                        return;
                    }
                    if (kq == 3) // ton tai
                    {
                        MessageBox.Show("Môn học đã có dữ liệu trên giáo viên đăng kí");
                        return;
                    }

                    var row = gvMonHoc.FocusedRowHandle;
                    gvMonHoc.DeleteRow(row);
                    mONHOCTableAdapterBindingSource.EndEdit();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                   
                   /* MessageBox.Show("" + mONHOCTableAdapterBindingSource.Position);
                    mONHOCTableAdapterBindingSource.RemoveAt(mONHOCTableAdapterBindingSource.Position);
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);*/
                    bdsMH.Filter = "XOA = 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                barbtRefesh.Enabled = barbtAdd.Enabled = barbtDel.Enabled = barbtEdit.Enabled = false;
                barbtSave.Enabled = true;
                txtMAMH.Enabled = false;
                Program.Control = "Edit";
                groupBox1.Enabled = true;
                gcMH.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Program.mNhom == "TRUONG")
                {
                    barbtAdd.Enabled = barbtDel.Enabled = barbtEdit.Enabled = barbtSave.Enabled = groupBox1.Enabled = false;
                }
                else
                    barbtRefesh.Enabled = barbtAdd.Enabled = barbtDel.Enabled = barbtEdit.Enabled = true;
                bdsMH.RemoveFilter();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.dS.BODE);
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                bdsMH.Filter = "XOA = 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn hủy tất cả?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (Program.mNhom == "TRUONG")
                    {
                        barbtAdd.Enabled = barbtDel.Enabled = barbtEdit.Enabled = barbtSave.Enabled = groupBox1.Enabled = false;
                    }
                    else
                        barbtRefesh.Enabled = barbtAdd.Enabled = barbtDel.Enabled = barbtEdit.Enabled = true;
                    barbtSave.Enabled = false;
                    bdsMH.CancelEdit();
                    bdsMH.MoveFirst();
                    groupBox1.Enabled = false;
                    gcMH.Enabled = true;
                    Program.Control = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                txtMAMH.Text = txtMAMH.Text.ToUpper();
                txtTENMH.Text = txtTENMH.Text.ToUpper();
                if (txtTENMH.Text.Trim() == "")
                {
                    MessageBox.Show("Tên môn không được rỗng", "", MessageBoxButtons.OK);
                    txtTENMH.Focus();
                    return;
                }
                if (Program.Control == "Add")
                {
                    if (txtMAMH.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã môn không được rỗng", "", MessageBoxButtons.OK);
                        txtMAMH.Focus();
                        return;
                    }
                    int kq = Program.KetNoi();
                    if (kq == 0) return;
                    String strlenh = "EXEC dbo.SP_TIMKIEMMH '" + txtMAMH.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                    if (Program.myReader.Read() != false)
                    {
                        MessageBox.Show("Mã môn học đã tồn tại", "", MessageBoxButtons.OK);
                        Program.conn.Close();
                        txtMAMH.Focus();
                        return;
                    }
                    int kn1 = Program.KetNoi();
                    if (kn1 == 0) return;
                    String strlenh1 = "EXEC dbo.SP_TIMKIEMTENMH N'" + txtTENMH.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh1);
                    if (Program.myReader.Read() != false)
                    {
                        MessageBox.Show("Tên môn học đã tồn tại", "", MessageBoxButtons.OK);
                        Program.conn.Close();
                        txtTENMH.Focus();
                        return;
                    }
                    try
                    {
                        this.Validate();
                        this.bdsMH.EndEdit();
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                        MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi môn học." + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (Program.Control == "Edit")
                {
                    int kn1 = Program.KetNoi();
                    if (kn1 == 0) return;
                    String strlenh1 = "EXEC dbo.SP_TIMKIEMTENMH N'" + txtTENMH.Text.Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh1);
                    if (Program.myReader.Read() != false)
                    {
                        MessageBox.Show("Tên môn học đã tồn tại", "", MessageBoxButtons.OK);
                        Program.conn.Close();
                        txtTENMH.Focus();
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
                bdsMH.Filter = "XOA = 0";
                Program.Control = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không? Mọi thay đổi mới nhất sẽ không dược lưu?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Program.mNhom == "GIANGVIEN") Program.frmMain.btKHOA.Enabled = Program.frmMain.btGiaoVien.Enabled = Program.frmMain.btLOP.Enabled = Program.frmMain.btMonHoc.Enabled = Program.frmMain.btlogin.Enabled = false;
                else
                {
                    Program.frmMain.btBD.Enabled = Program.frmMain.btCancel.Enabled = Program.frmMain.btDSDK.Enabled = Program.frmMain.btKHOA.Enabled = Program.frmMain.btlogin.Enabled = Program.frmMain.btLOP.Enabled = Program.frmMain.btMonHoc.Enabled = true;
                    Program.frmMain.btnXEMBAITHI.Enabled = Program.frmMain.btnXEMBANGDIEM.Enabled = Program.frmMain.btnXEMDSDANGKY.Enabled = true;
                }
                this.Close();
            }
        }

        int lastCOSO = Program.mChiNhanh;
        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCS.SelectedItem == null)
            {
                return;
            }
            if (cmbCS.SelectedIndex == 2)
            {
                MessageBox.Show("Cơ sở tra cứu không chứa dữ liệu môn học");
                cmbCS.SelectedIndex = lastCOSO;
                return;
            }
            if (cmbCS.SelectedIndex != lastCOSO && cmbCS.SelectedIndex >= 0)
            {

                Program.servername = cmbCS.SelectedValue.ToString();
                lastCOSO = cmbCS.SelectedIndex;
                if (Program.KetNoi() == 0)
                    return;
                else
                {
                    // TODO: This line of code loads data into the 'dS.V_DS_PHANMANH' table. You can move, or remove it, as needed

                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    cmbCS.SelectedIndex = lastCOSO;
                    bdsMH.Filter = "XOA = 0";
                }
            }
        }

    }
}
