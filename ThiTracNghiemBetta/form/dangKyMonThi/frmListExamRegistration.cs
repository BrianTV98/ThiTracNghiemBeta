using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiemBetta.models;

namespace ThiTracNghiemBetta.form.examregistation
{
    public partial class frmListExamRegistration : Form
    {
       
        public frmListExamRegistration()
        {
            InitializeComponent();
            
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_gvdk.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);
        }

        private void frmListExamRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.ds.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.adapter_gvdk.Connection.ConnectionString = Program.connstr;
            this.adapter_gvdk.Fill(this.ds.GIAOVIEN_DANGKY);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmExamRegistration f = new frmExamRegistration(this);
            f.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.adapter_gvdk.Connection.ConnectionString = Program.connstr;
            this.adapter_gvdk.Fill(this.ds.GIAOVIEN_DANGKY);
        }

        private void gIAOVIEN_DANGKYGridControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {

                return;
            }
            var rowH = gv_gvdk.FocusedRowHandle;
            var focusRowView = (DataRowView)gv_gvdk.GetFocusedRow();
            if (focusRowView == null || focusRowView.IsNew)
            {
                return;
            }

            if (rowH >= 0)
            {
                popupMenuRightClick.ShowPopup(barManagerRightClickItem, new Point(MousePosition.X, MousePosition.Y));
            }
            else {
                popupMenuRightClick.HidePopup();
            }
        }

        private void barBtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmExamRegistration f = new frmExamRegistration(this);
            f.ShowDialog();

        }

        private void barBtnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
             * Kiểm tra xem lớp đã thi chưa
             * Nếu lớp đã thi rồi thì không cho sửa nữa
             */
            GiaoVienDK gv= coverDataRowToGiaoVienDK( gv_gvdk.GetFocusedDataRow());

            bool check = checkDieuKienXoaDangKiThi(gv.MaMH, gv.MaLop, gv.Lan.ToString());
            if (check == true)
            {
                MessageBox.Show("Kì thi này đã thi! Không thể sửa ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                frmExamRegistration f = new frmExamRegistration(this, gv);
                f.isDKMoi = false;
                f.ShowDialog();
            }

        }
        private GiaoVienDK coverDataRowToGiaoVienDK(DataRow dr)
        {
            string magv = dr[0].ToString().Trim();
            string mamh = dr[1].ToString().Trim();
            string malop = dr[2].ToString().Trim();
            string trinhdo = dr[3].ToString().Trim();
            DateTime dt = Convert.ToDateTime(dr[4].ToString().Trim());
            int lanthi = int.Parse(dr[5].ToString().Trim());
            int socauthi = int.Parse(dr[6].ToString());
            int thoigian = int.Parse(dr[7].ToString());
            return new GiaoVienDK(magv, mamh, malop, trinhdo, dt, lanthi, socauthi, thoigian);
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
             * Lấy thông tin đăng kí thi của lớp đó ra
             * Kiểm tra xem lớp đó đã thi chưa
             * Nếu chưa thi mới cho phép xóa , thi rồi thì báo lỗi
             */
            DataRow dr = gv_gvdk.GetFocusedDataRow();
            string mamh = dr[1].ToString().Trim();
            string malop = dr[2].ToString().Trim();
            string trinhdo = dr[3].ToString().Trim();
            DateTime ngaythi = Convert.ToDateTime(dr[4].ToString().Trim());
            string lan = dr[5].ToString().Trim();
            int socauthi = int.Parse(dr[6].ToString().Trim());
            int thoigian = int.Parse(dr[7].ToString().Trim());
            bool check = checkDieuKienXoaDangKiThi(mamh, malop, lan);
            if (check == true)
            {
                MessageBox.Show("Kì thi này đã thi! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var row = gv_gvdk.FocusedRowHandle;
                gv_gvdk.DeleteRow(row);
                bds_gvdk.EndEdit();
                this.adapter_gvdk.Update(this.ds.GIAOVIEN_DANGKY);

                //Luu Log
                GiaoVienDK giaoVienDk = new GiaoVienDK(Program.mUserId, mamh, malop, trinhdo, ngaythi, int.Parse(lan), socauthi, thoigian);
                Program.logGVDK.Insert(Program.indexLogGVDK + 1, new DataLogGVDK("D", giaoVienDk, null));
                Program.indexLogGVDK++;
            }

        }
        private bool checkDieuKienXoaDangKiThi(string mamh, string malop, string lan)
        {
            /*
             *tra ve true neu da ton tai thi -> khong cho xoa
             * tra ve false neu khong ton tai thi -> cho xoa
             */
            int kn = Program.KetNoi();
            SqlCommand sqlCommand = new SqlCommand("SP_KIEM_TRA_GVDK_DA_THI_CHUA", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MAMH", mamh);
            sqlCommand.Parameters.AddWithValue("@MALOP", malop);
            sqlCommand.Parameters.AddWithValue("@LAN", lan);
            int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
            if (kq != 0) // ton tai
            {
                return true;
            }
            return false;    
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = tENCNComboBox.SelectedValue.ToString();
                this.adapter_gvdk.Connection.ConnectionString = Program.connstr;
                MessageBox.Show(this.ds.GIAOVIEN_DANGKY.Rows.Count.ToString());
                this.adapter_gvdk.Fill(this.ds.GIAOVIEN_DANGKY);
            }
            catch (Exception)
            {

            }
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
             * Neu Insert thi delete
             * Nêu Update thi Update
             * Nếu Xóa Thì Insert
             * 
             */
            if (Program.indexLogGVDK >= 0)
            {
                DataLogGVDK logGvdk = Program.logGVDK[Program.indexLogGVDK];
                if (logGvdk.Action.Equals("I"))
                {
                    SqlCommand sqlcmd = new SqlCommand("SP_XOA_GVDK", Program.conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add("@MAMH", logGvdk.Sau.MaMH);
                    sqlcmd.Parameters.Add("@MALOP", logGvdk.Sau.MaLop);
                    sqlcmd.Parameters.Add("@LAN", logGvdk.Sau.Lan);
                    int check= Program.execStoreProcedureWithReturnValue(sqlcmd);
                    if (check == 1)
                    {
                        MessageBox.Show("Lỗi Khôi phục Insert");
                    }
                    else
                    {
                        barButtonItem1.PerformClick();
                        Program.indexLogGVDK--;
                    }
                }
                if (logGvdk.Action.Equals("D"))
                {
                    SqlCommand sqlcmd = new SqlCommand("SP_THEM_GVDK", Program.conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add("@MAGV", logGvdk.Truoc.MaGV);
                    sqlcmd.Parameters.Add("@MAMH", logGvdk.Truoc.MaMH);
                    sqlcmd.Parameters.Add("@MALOP", logGvdk.Truoc.MaLop);
                    sqlcmd.Parameters.Add("@TRINHDO", logGvdk.Truoc.TrinhDo);
                    sqlcmd.Parameters.Add("@NGAYTHI", logGvdk.Truoc.NgayThi);
                    sqlcmd.Parameters.Add("@LAN", logGvdk.Truoc.Lan);
                    sqlcmd.Parameters.Add("@SOCAUTHI", logGvdk.Truoc.SoCauThi);
                    sqlcmd.Parameters.Add("@THOIGIAN", logGvdk.Truoc.ThoiGian);
                    int check = Program.execStoreProcedureWithReturnValue(sqlcmd);
                    if (check == 1)
                    {
                        MessageBox.Show("Lỗi Khôi phục Insert");
                    }
                    else
                    {
                        barButtonItem1.PerformClick();
                        Program.indexLogGVDK--;
                    }
                }
                if (logGvdk.Action.Equals("U"))
                {
                    SqlCommand sqlcmd = new SqlCommand("SP_SUA_GVDK", Program.conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add("@MAGV", logGvdk.Truoc.MaGV);
                    sqlcmd.Parameters.Add("@MAMH", logGvdk.Truoc.MaMH);
                    sqlcmd.Parameters.Add("@MALOP", logGvdk.Truoc.MaLop);
                    sqlcmd.Parameters.Add("@TRINHDO", logGvdk.Truoc.TrinhDo);
                    sqlcmd.Parameters.Add("@NGAYTHI", logGvdk.Truoc.NgayThi);
                    sqlcmd.Parameters.Add("@LAN", logGvdk.Truoc.Lan);
                    sqlcmd.Parameters.Add("@SOCAUTHI", logGvdk.Truoc.SoCauThi);
                    sqlcmd.Parameters.Add("@THOIGIAN", logGvdk.Truoc.ThoiGian);
                    int check = Program.execStoreProcedureWithReturnValue(sqlcmd);
                    if (check == 1)
                    {
                        MessageBox.Show("Lỗi Khôi phục Insert");
                    }
                    else
                    {
                        barButtonItem1.PerformClick();
                        Program.indexLogGVDK--;
                    }
                }
                
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // redo
        {

            if (Program.indexLogGVDK < Program.logGVDK.Count-1)
            {
                Program.indexLogGVDK++;
                DataLogGVDK logGvdk = Program.logGVDK[Program.indexLogGVDK];
                if (logGvdk.Action.Equals("I"))
                {

                    SqlCommand sqlcmd = new SqlCommand("SP_THEM_GVDK", Program.conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add("@MAGV", logGvdk.Sau.MaGV);
                    sqlcmd.Parameters.Add("@MAMH", logGvdk.Sau.MaMH);
                    sqlcmd.Parameters.Add("@MALOP", logGvdk.Sau.MaLop);
                    sqlcmd.Parameters.Add("@TRINHDO", logGvdk.Sau.TrinhDo);
                    sqlcmd.Parameters.Add("@NGAYTHI", logGvdk.Sau.NgayThi);
                    sqlcmd.Parameters.Add("@LAN", logGvdk.Sau.Lan);
                    sqlcmd.Parameters.Add("@SOCAUTHI", logGvdk.Sau.SoCauThi);
                    sqlcmd.Parameters.Add("@THOIGIAN", logGvdk.Sau.ThoiGian);
                    MessageBox.Show(logGvdk.Action+logGvdk.Sau.MaMH + " " + logGvdk.Sau.MaLop + " " + logGvdk.Sau.Lan+""+ logGvdk.Sau.TrinhDo+ logGvdk.Sau.NgayThi+ logGvdk.Sau.SoCauThi+ logGvdk.Sau.ThoiGian);
                    int check = Program.execStoreProcedureWithReturnValue(sqlcmd);
                    if (check == 1)
                    {
                        MessageBox.Show("Lỗi Khôi phục Insert");
                    }
                    else
                    {
                        barButtonItem1.PerformClick();
                     
                    }



                    
                }
                if (logGvdk.Action.Equals("D"))
                {
                    SqlCommand sqlcmd = new SqlCommand("SP_XOA_GVDK", Program.conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add("@MAMH", logGvdk.Truoc.MaMH);
                    sqlcmd.Parameters.Add("@MALOP", logGvdk.Truoc.MaLop);
                    sqlcmd.Parameters.Add("@LAN", logGvdk.Truoc.Lan);
                    int check = Program.execStoreProcedureWithReturnValue(sqlcmd);
                    if (check == 1)
                    {
                        MessageBox.Show("Lỗi Khôi phục Insert");
                    }
                    else
                    {
                        barButtonItem1.PerformClick();

                    }
                }
                if (logGvdk.Action.Equals("U"))
                {
                    SqlCommand sqlcmd = new SqlCommand("SP_SUA_GVDK", Program.conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add("@MAGV", logGvdk.Sau.MaGV);
                    sqlcmd.Parameters.Add("@MAMH", logGvdk.Sau.MaMH);
                    sqlcmd.Parameters.Add("@MALOP", logGvdk.Sau.MaLop);
                    sqlcmd.Parameters.Add("@TRINHDO", logGvdk.Sau.TrinhDo);
                    sqlcmd.Parameters.Add("@NGAYTHI", logGvdk.Sau.NgayThi);
                    sqlcmd.Parameters.Add("@LAN", logGvdk.Sau.Lan);
                    sqlcmd.Parameters.Add("@SOCAUTHI", logGvdk.Sau.SoCauThi);
                    sqlcmd.Parameters.Add("@THOIGIAN", logGvdk.Sau.ThoiGian);
                    int check = Program.execStoreProcedureWithReturnValue(sqlcmd);
                    if (check == 1)
                    {
                        MessageBox.Show("Lỗi Khôi phục Insert");
                    }
                    else
                    {
                        barButtonItem1.PerformClick();
                 
                    }
                }

            }
        }
    }
}
