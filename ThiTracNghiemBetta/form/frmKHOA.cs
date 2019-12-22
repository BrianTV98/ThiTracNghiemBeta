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
            normalMode();

            cmbCS.SelectedIndex = Program.mChiNhanh;
        }

        private void reloadData()
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbCS.SelectedIndex != Program.mChiNhanh && cmbCS.SelectedIndex >= 0)
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

            if (txtTENK.Text == "")
            {
                MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                txtTENK.Focus();
                return;
            }
            

            if (Program.Control == "Add")
            {
                bool validMK = checkValidMaKhoa();
                if (!validMK) return;
                bool validTK = checkValidTenKhoa();
                if (!validTK) return;

                try
                {
                    this.Validate();
                    this.bdsKHOA.EndEdit();
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                    MessageBox.Show("Đã thêm khoa thành công", "", MessageBoxButtons.OK);
                    normalMode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khoa. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (Program.Control == "Edit")
            {
                
                bool validTK = checkValidTenKhoa();
                if (!validTK) return;

                try
                {
                    this.Validate();
                    this.bdsKHOA.EndEdit();
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                    MessageBox.Show("Đã Sửa tên khoa thành công", "", MessageBoxButtons.OK);
                    normalMode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa khoa. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }
        private bool checkValidMaKhoa()
        {
            txtMAK.Text = txtMAK.Text.ToUpper().Trim();
            if (txtMAK.Text == "")
            {
                MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                txtMAK.Focus();
                return false;
            }
            try
            {
                int kn = Program.KetNoi();
                if (kn == 0)
                {
                    return false;
                }
                String strlenh = "EXEC dbo.SP_TIMKIEMKHOA '" + txtMAK.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader.Read() != false)
                {
                    MessageBox.Show("Mã khoa đã tồn tại", "", MessageBoxButtons.OK);
                    txtMAK.Focus();
                    Program.conn.Close();
                    return false;
                }
                return true;
            } catch (Exception e)
            {
                MessageBox.Show("Kiểm tra mã khoa thất bại: "+e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        private bool checkValidTenKhoa()
        {
            txtTENK.Text = txtTENK.Text.Trim();
            if (txtTENK.Text == "")
            {
                MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                txtMAK.Focus();
                return false;
            }
            try
            {
                int kn = Program.KetNoi();
                if (kn == 0)
                {
                    return false;
                }
                String strlenh = "EXEC dbo.SP_TIMKIEMTENKHOA '" + txtTENK.Text.Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader.Read() != false)
                {
                    MessageBox.Show("Tên khoa đã tồn tại", "", MessageBoxButtons.OK);
                    txtTENK.Focus();
                    Program.conn.Close();
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Kiểm tra tên khoa thất bại: " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {
            enableInputs();
            gcKHOA.Enabled = false;
            disableModify();
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
            reloadData();
        }

        private void disableModify ()
        {
            barbtRefesh1.Enabled = barbtAdd1.Enabled = barbtDel1.Enabled = barbtEdit1.Enabled = false;
            barbtCancel1.Enabled = barbtSave1.Enabled = barbtExit1.Enabled = true;

            btnAddGV.Enabled = false;
            gvControlGV.Enabled = false;
        }

        private void enableModify()
        {
            barbtRefesh1.Enabled = barbtAdd1.Enabled = barbtDel1.Enabled = barbtEdit1.Enabled = true;
            barbtCancel1.Enabled = barbtSave1.Enabled = barbtExit1.Enabled = true;
            btnAddGV.Enabled = true;
            gvControlGV.Enabled = true;
        }

        private void normalMode()
        {
            enableModify();
            gcKHOA.Enabled = true;
            disableInputs();

            if (Program.mNhom == "TRUONG")
            {
                disableModify();
                cmbCS.Enabled = true;
                gvControlGV.Enabled = true;
                barbtCancel1.Enabled = barbtSave1.Enabled = false;
                barbtRefesh1.Enabled = true;
                
                groupBox1.Enabled = true;
                groupBox3.Enabled = false;

                btnAddGV.Enabled = false;
                
            }
            else if (Program.mNhom == "COSO")
            {
                cmbCS.Enabled = false;
           
            }

            
        }
        private void disableInputs()
        {
            txtTENK.Enabled = false;
            txtMAK.Enabled = false;
        }

        private void enableInputs()
        {
            txtTENK.Enabled = true;
            txtMAK.Enabled = true;
        }

        private void barbtEdit1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            disableModify();
            enableInputs();
            txtMAK.Enabled = false;
            Program.Control = "Edit";
        }

        private void barbtDel1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGV.Count > 0)
            {
                MessageBox.Show("Khoa đã đăng có giáo viên không được xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsLOP.Count > 0)
            {
                MessageBox.Show("Khoa đã đăng có lớp không được xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa khoa " + txtTENKH.Text.Trim() + " ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsKHOA.RemoveAt(bdsKHOA.Position);
                this.kHOATableAdapter.Update(this.dS.KHOA);
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
            }
        }

        private void barbtCancel1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.Control == "Add")
            {
                if (MessageBox.Show("Dữ liệu đang nhập. Bạn muốn hủy bỏ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bdsKHOA.CancelEdit();
                    normalMode();
                }
            }
            if (Program.Control == "Edit")
            {
                if (MessageBox.Show("Dữ liệu đang chỉnh sửa. Bạn muốn hủy bỏ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bdsKHOA.CancelEdit();
                    normalMode();
                }
            }
        }

        private void barbtExit1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Thoát sẽ mất hết dữ liệu đang thao tác. Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
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

        private void onShowPopUpGV(object sender, MouseEventArgs e)
        {
            if (Program.mNhom == "TRUONG") { return; }
            if (e.Button != MouseButtons.Right) return;
            var rowH = gvGV.FocusedRowHandle;
            var focusRowView = (DataRowView)gvGV.GetFocusedRow();
            if (focusRowView == null || focusRowView.IsNew) return;

            if (rowH >= 0)
            {
                popupMenuGV.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
            else popupMenuGV.HidePopup();
        }

        private void btnAddGV_Click(object sender, EventArgs e)
        {            
            dialogGV d = new dialogGV();
            d.type = "add";

            d.ShowDialog();
            reloadData();
        }

        private void btnSuaGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dialogGV d = new dialogGV();
            d.type = "edit";

            d.ShowDialog();
            reloadData();
        }

        private void btnXoaGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bODEBindingSource.Count > 0)
            {
                MessageBox.Show("Giáo viên đang có bộ đề, không được xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (!validGVDangKy())
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa khoa " + txtTENKH.Text.Trim() + " ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsGV.RemoveAt(bdsGV.Position);
                this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
            }
        }

        private bool validGVDangKy()
        {
            try
            {
                int kn = Program.KetNoi();
                if (kn == 0)
                {
                    return false;
                }
                String strlenh = "EXEC dbo.SP_TIMGVDANGKY '" + txtMAGV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader.Read() != false)
                {
                    MessageBox.Show("Giáo viên đã đăng ký thi cho lớp, không thể xóa", "", MessageBoxButtons.OK);
                    Program.conn.Close();
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Kiểm tra giáo viên đăng ký thất bại: " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        private void gcKHOA_Click(object sender, EventArgs e)
        {

        }

        private void onRefreshGiaoVien(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reloadData();
        }
    }
}