using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemBetta.form.student
{
    public partial class frmNhapLop : Form
    {
        //=fale : chinh sua , == true: add
        private bool trangthaifrmLop = false;
        private bool trangthaiframSV = false;
        private string message = "";
        Button closeAll = new Button();
        public frmNhapLop()
        {
            InitializeComponent();
            if (Program.mNhom == "TRUONG")
            {
                pnChiNhanh.Enabled = true;
                pnLop.Enabled = false;
                pnSV.Enabled = false;
            }
            else
            {
                pnChiNhanh.Enabled = false;
            }
            pnNhapLop.Enabled = false;
            pnNhapSV.Enabled = false;
            closeAll.Click += new EventHandler(this.CloseBtn_Click);
            this.CancelButton = closeAll;
            
        }
        private void CloseBtn_Click(Object sender,
                           EventArgs e)
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

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_lop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void frmNhapLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.ds.KHOA);
            this.ds.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.ds.V_DS_PHANMANH);

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.adaterSv.Connection.ConnectionString = Program.connstr;
            this.adaterSv.Fill(this.ds.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.adapterLop.Connection.ConnectionString = Program.connstr;
            this.adapterLop.Fill(this.ds.LOP);

            this.ds.EnforceConstraints = true;

       
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthaifrmLop == false)
            {
                if (checkExistTenLop(txtTenLop.Text.Trim())) //luu thất bại
                {
                    MessageBox.Show("Tên lớp đã tồn tại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else // lưu thành công
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bds_lop.EndEdit();
                    this.adapterLop.Update(this.ds.LOP);
                    pressEdit(false);
                }
            }
            else
            {
                bool check = checkValidateAddClass();
                if (check == false)
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                   // MessageBox.Show("Thêm Thành Công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bds_lop.EndEdit();
                    this.adapterLop.Update(this.ds.LOP);
                    gv_Lop.AddNewRow();
                }
            }
        }
       

        private void barBtnDeleteLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkValidateLop() == true)
            {
                var row = gv_Lop.FocusedRowHandle;
                gv_Lop.DeleteRow(row);
                bds_lop.EndEdit();
                this.adapterLop.Update(this.ds.LOP);
            }
        }
        private bool checkValidateLop()
        {
            if (bds_sv.Count > 0)
            {
                MessageBox.Show(bds_sv.Count.ToString());
                MessageBox.Show("Lớp đã tồn tại sinh viên. Không thể xóa lớp này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void lOPGridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {

                return;
            }
            var rowH = gv_Lop.FocusedRowHandle;
            var focusRowView = (DataRowView)gv_Lop.GetFocusedRow();
            if (focusRowView == null || focusRowView.IsNew)
            {
                return;
            }

            if (rowH >= 0)
            {
                popupMenuLop.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
               
            }
            else popupMenuLop.HidePopup();
        }

        private void barBtnEditLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pressEdit(true);

        }
        private void pressEdit(bool a)
        {
            if (a == true)
            {
                if (trangthaifrmLop == true)
                {
                    txtMaLop.Enabled = true;
                    cbMaKhoa.Enabled = true;
                }
                else
                {
                    txtMaLop.Enabled = false;
                    cbMaKhoa.Enabled = false;
                }
                pnNhapLop.Enabled = true;
                txtTenLop.Enabled = true;
                pnGcLop.Enabled = false;
                
            }
            else
            {
                pnNhapLop.Enabled = false;
                pnGcLop.Enabled = true;
            }
        }
        private bool checkExistMaLop(string strLenh)
        {
            try
            {
                int kn = Program.KetNoi();
                if (kn == 0)
                {
                    MessageBox.Show("Sự cố kết nối!", "", MessageBoxButtons.OK);
                    return true;
                }

                String strlenh = "EXEC dbo.SP_TIMKIEM_LOP '" + strLenh + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader.Read() != false)
                {
                    //MessageBox.Show("Mã lớp đã tồn tại", "", MessageBoxButtons.OK);
                    message = "Mã lớp đã tồn tại";
                    Program.conn.Close();
                    return true;
                }

                else
                {
                    Program.conn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private bool checkValidateAddClass()
        {
            /*
             * Kiểm tra mã lớp rỗng ko?
             * Kiểm tra các ký tự đặc biệt của mã lớp
             * kiểm tra mã lớp có tồn tại chưa
             * Kiểm tra lên lớp có rỗng không
             * kiểm tên lớp có tồn tại chưa (tên lớp khóa unique)
             */
            string malop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            if (malop.Length == 0)
            {
                message = "Mã lớp không được để trống!";
                return false;
            }
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            if (regex.IsMatch(malop) == false)
            {
                message = "Tên lớp không được chứa khoảng trắng hoặc ký tự đặc biệt";
                return false;
            }

            if (tenLop.Length == 0)
            {
                message = "Tên lớp không được để trống!";
                return false;
            }
            if (checkExistMaLop(txtMaLop.Text.Trim()))
            {
                message = "Mã lớp đã tồn tại!!";
                return false;
            }
            if (checkExistTenLop(txtTenLop.Text.Trim()))
            {
                message = "Tên lớp đã tồn tại !";
                return false;
            }
            return true;
        }
        private bool checkExistTenLop(string tenlop)
        {
            int kn = Program.KetNoi();
            SqlCommand sqlCommand = new SqlCommand("SP_KIEM_TRA_TON_TAI_TEN_LOP", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@TENLOP", txtTenLop.Text);
            int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
            if (kq != 0) // ton tai
            {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (trangthaifrmLop == false)
            {
                pressEdit(false);
            }
            else
            {
                bds_lop.CancelEdit();
                pressEdit(false);
            }
        }

        private void barBtnThemSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthaiframSV = true;
            pressEditSV(true);
            bds_sv.AddNew();
        }

        private void barBtnSuaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthaiframSV = false;
            pressEditSV(true);
        }
        private void pressEditSV(bool trangthai)
        {
           
            if (trangthai == true)
            {
                pnGCSV.Enabled = false;
                pnNhapSV.Enabled = true;

                if (trangthaiframSV == false)
                {
                    txtMaSV.Enabled = false;
                }
                else
                {
                    txtMaSV.Enabled = true;
                }
                txtHoSV.Enabled = true;
                txtTenSV.Enabled = true;
                dtNgaySinh.Enabled = true;
                txtDiaChi.Enabled = true;
                txtMaLopSv.Enabled = false;
            }
            else
            {
                pnGCSV.Enabled = true;
                pnNhapSV.Enabled = false;

                txtMaSV.Enabled = false;
                txtHoSV.Enabled = false;
                txtTenSV.Enabled = false;
                dtNgaySinh.Enabled = false;
                txtDiaChi.Enabled = false;
                txtMaLopSv.Enabled = false;
            }
        }
        private void barBtnXoaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvSV_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Right) return;
            
            var rowH = gvSV.Rows.Count;
            var focusRowView = gvSV.CurrentRow;
            if (focusRowView == null || focusRowView.IsNewRow)
            {
                //popupMenuThemLop.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
                return;
            }

            if (rowH >= 0)
            {
                popupMenuSV.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));

            }
            else {
                popupMenuSV.HidePopup();
               // popupMenuThemLop.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
            }
            
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            if (checkValidateSV() == false)
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bds_sv.EndEdit();
                this.adaterSv.Update(this.ds.SINHVIEN);
                pressEditSV(false);
            }
           
        }
        private bool checkValidateSV()
        {
            /*TO DO
             * check  rong tat cac cac fiel
             * kiểm tra ký tự rỗng của fiel mã sinh viên
             * check  check ma sv co ton tai chua
             */
            string maSv = txtMaSV.Text.Trim();
            string ho = txtHoSV.Text.Trim();
            string ten = txtTenSV.Text.Trim();
            string date = dtNgaySinh.ToString().Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string maLop = txtMaLop.Text.Trim();

            if (maSv.Length == 0)
            {
                message = "Mã sinh viên không được rỗng! ";
                return false;
            }
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            if (regex.IsMatch(maSv) == false)
            {
                message = "Tên lớp không được chứa khoảng trắng hoặc ký tự đặc biệt";
                return false;
            }
            if (ho.Length == 0)
            {
                message = "Họ không được rỗng! ";
                return false;
            }

            if (ten.Length == 0)
            {
                message = "Tên không được rỗng! ";
                return false;
            }
            if (date.Length == 0)
            {
                message = "Ngày sinh không được được rỗng! ";
                return false;
            }
            if (diaChi.Length == 0)
            {
                message = "Địa chỉ không được rỗng! ";
                return false;
            }
            if (maLop.Length == 0)
            {
                message = "Mã lớp không được rỗng! ";
                return false;
            }

            if (trangthaiframSV == true) // add thi mo khoa-> check , nguoc lai : edit  -> khoa -> uncheck
            {
                if (checkExistMASV(maSv) == true)
                {
                    message = "Mã sinh viên bị trùng ";
                    return false;
                }
            }

            return true;

        }
        private bool checkExistMASV(string masv) // tra ve true neu ton tai - false neu khong ton tai
        {
            int kn = Program.KetNoi();
            if (kn == 0)
            {
                MessageBox.Show("Lỗi kết nối! ");
                return true;
            }
            SqlCommand sqlCommand = new SqlCommand("SP_KIEM_TRA_TON_TAI_MASV", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MASV", masv);
            int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
            if (kq != 0)
            {
                Program.conn.Close();
                return true;
            }
            Program.conn.Close();
            return false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void barbtnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthaifrmLop = true;
            pressEdit(true);
            gv_Lop.AddNewRow();
        }

        private void pnNhapLop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mAKHComboBox_TextChanged(object sender, EventArgs e)
        {
            cbMaKhoa.Text = txtMaKhoa.Text;
        }

        private void txtMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaKhoa.SelectedValue != null)
                txtMaKhoa.Text = cbMaKhoa.SelectedValue.ToString();
        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
