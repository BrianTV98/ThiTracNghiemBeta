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
using ThiTracNghiemBetta.form.thi;
using ThiTracNghiemBetta.models;

namespace ThiTracNghiemBetta.form.examregistation
{
    public partial class frmExamRegistration : Form
    {
        frmListExamRegistration frmRoot;
       
        private GiaoVienDK giaoVienDk;
        public bool isDKMoi = true;
        public GiaoVienDK tmp;
        private string message = "";
        public frmExamRegistration(frmListExamRegistration f)
        {
            InitializeComponent();
            this.frmRoot = f;
            txt_magv.Text = Program.mUserId.Trim();
            // default trinh do
            cb_trinhdo.SelectedIndex = 0;
           
            this.CancelButton = btnCancel;
            this.CenterToScreen();
            /*gr_dkthi.Left = this.Width*2/ 3;
            gr_dkthi.Top = this.Height / 5;*/


        }
        public frmExamRegistration(frmListExamRegistration f, GiaoVienDK gvdk)
        {
            InitializeComponent();
            this.frmRoot = f;
            this.giaoVienDk = gvdk;
            txt_magv.Text = Program.mUserId.Trim();
            // default trinh do
            cb_trinhdo.SelectedIndex = 0;
           
            this.CancelButton = btnCancel;
            this.CenterToScreen();
            /*gr_dkthi.Left = this.Width*2/ 3;
            gr_dkthi.Top = this.Height / 5;*/


        }


        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_giaoVienDangKi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);
        }

        private void formExamRegistration_Load(object sender, EventArgs e)
        {
            this.ds.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.ds.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.ds.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.ds.GIAOVIEN_DANGKY);
            
            this.ds.EnforceConstraints = true;

            IsFormDKMoi(isDKMoi);
        }
        private void IsFormDKMoi(bool c)
        {
           
            cb_maMonHoc.Enabled = c;
            cb_maLop.Enabled = c;
            if (c == true)
            {
                btnRegister.Text = "ĐĂNG KÍ";
               
            }
            else
            {
                cb_maMonHoc.Text =giaoVienDk.MaMH;
                cb_maLop.Text = giaoVienDk.MaLop;
                cb_trinhdo.Text = giaoVienDk.TrinhDo;
                dt_ngaythi.Text = giaoVienDk.NgayThi.ToString();
                spinEdit_lanthi.Text = giaoVienDk.Lan.ToString();
                spinEdit_thoigian.Text = giaoVienDk.ThoiGian.ToString();
                spinEdit_cauhoi.Text = giaoVienDk.SoCauThi.ToString();
                btnRegister.Text = "HOÀN TẤT";
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*TODO
             * checkvaldiate
             * Đăng kí
            */
            if (isDKMoi == true)
            {
                if (checkValidate() == true)
                {
                    if (DANGKY() == true)
                    {
                        MessageBox.Show("Đăng KÝ Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (checkDKEdit() == true)
                {
                    string query= "UPDATE GIAOVIEN_DANGKY " +
                        "SET  TRINHDO = '"+cb_trinhdo.SelectedItem+"', NGAYTHI = '"+dt_ngaythi.DateTime+"', LAN = '"+spinEdit_lanthi.Text.ToString()+"', SOCAUTHI = '"+spinEdit_cauhoi.Text.ToString()+"', THOIGIAN = '"+spinEdit_thoigian.Text.ToString()+"'"+
                        "WHERE MAMH = '"+cb_maMonHoc.SelectedValue.ToString()+"' AND MALOP = '"+cb_maLop.Text.ToString()+"' AND LAN = "+spinEdit_lanthi.Text.ToString();
                    MessageBox.Show(query);
                    SqlCommand sqlcmd = new SqlCommand(query, Program.conn);
                    sqlcmd.CommandType = CommandType.Text;
                    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                    sqlcmd.ExecuteReader();
                    frmRoot.adapter_gvdk.Fill(frmRoot.ds.GIAOVIEN_DANGKY);
                    // Luu Log
                    GiaoVienDK gvdk = new GiaoVienDK(txt_magv.Text,
                    cb_maMonHoc.SelectedValue.ToString(),
                    cb_maLop.SelectedValue.ToString(),
                    cb_trinhdo.SelectedItem.ToString(),
                    dt_ngaythi.DateTime,
                    int.Parse(spinEdit_lanthi.Text.ToString()),
                    int.Parse(spinEdit_cauhoi.Text.ToString()),
                    int.Parse(spinEdit_thoigian.Text.ToString()));
                    Program.logGVDK.Insert(Program.indexLogGVDK + 1, new DataLogGVDK("U", giaoVienDk, gvdk));
                    Program.indexLogGVDK++;
                }
                else
                {
                    MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool DANGKY()
        {
            MessageBox.Show(txt_magv.Text + cb_maMonHoc.SelectedValue.ToString() + cb_maLop.SelectedValue.ToString()
                + cb_trinhdo.SelectedItem.ToString() + dt_ngaythi.DateTime.ToString() + spinEdit_lanthi.Value +
                spinEdit_cauhoi.Value + spinEdit_thoigian.Value);
            try
            {
                DataRow row = this.ds.GIAOVIEN_DANGKY.NewRow();
                row[0] = txt_magv.Text;
                row[1] = cb_maMonHoc.SelectedValue.ToString();
                row[2] = cb_maLop.SelectedValue.ToString();
                row[3] = cb_trinhdo.SelectedItem.ToString();
                row[4] = dt_ngaythi.DateTime.ToString();
                row[5] = spinEdit_lanthi.Text;
                row[6] = spinEdit_cauhoi.Text;
                row[7] = spinEdit_thoigian.Text;
                this.ds.GIAOVIEN_DANGKY.Rows.Add(row);
                bds_giaoVienDangKi.EndEdit();
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.ds.GIAOVIEN_DANGKY);
                this.frmRoot.adapter_gvdk.Fill(this.frmRoot.ds.GIAOVIEN_DANGKY);

                //Ghi Log
                GiaoVienDK gvdk = new GiaoVienDK(txt_magv.Text,
                    cb_maMonHoc.SelectedValue.ToString(),
                    cb_maLop.SelectedValue.ToString(),
                    cb_trinhdo.SelectedItem.ToString(),
                    dt_ngaythi.DateTime,
                    int.Parse(spinEdit_lanthi.Text.ToString()),
                    int.Parse(spinEdit_cauhoi.Text.ToString()),
                    int.Parse(spinEdit_thoigian.Text.ToString()));

               /* if (Program.indexLogGVDK == Program.logGVDK.Count - 1)
                {*/
                    Program.logGVDK.Insert(Program.indexLogGVDK + 1, new DataLogGVDK("I", null, gvdk));
                    Program.indexLogGVDK++;
               /* }
                else
                {
                    
                }*/
                
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }
        private bool checkDKEdit()
        {
            
            int socauhoi = Int32.Parse(spinEdit_cauhoi.Text);
            int thoigianthi = Int32.Parse(spinEdit_thoigian.Text); ;
            int datetime = DateTime.Compare(DateTime.Now, dt_ngaythi.DateTime);
            int soCauHoiHeThong = getSoCauHoiCuaHeThong(cb_maMonHoc.SelectedValue.ToString(), cb_trinhdo.SelectedItem.ToString());
            if (datetime > 0)
            {
                message = "Thời gian đăng ký không hợp lệ! ";
                return false;
            }

            if (socauhoi > soCauHoiHeThong)
            {
                message = "Số lượng câu hỏi trong hệ thống không đáp ứng được!";
                return false;
            }
            //
            return true;
        }
        private bool checkValidate()
        {
            /*
             * Kiem tra Trinh do -> chi nhan a, b,c 
             * Kiem tra Ngay THi ->  không được trong thời gian của quá khứ
             * Kiem tra Lan Thi  ->  chi nhan 1 va 2
             * Kiem tra Thoi Gian THi -> =>15 and <60
             * kiem tra so cau thi -> >=10 and <=100;
             * kiểm tra số câu hỏi : Số câu hỏi  phải nhỏ hơn số câu hỏi của bộ đề môn học ;
             */

            int lanthi = Int32.Parse(spinEdit_lanthi.Text);
            int socauhoi = Int32.Parse(spinEdit_cauhoi.Text);
            int thoigianthi = Int32.Parse(spinEdit_thoigian.Text); ;
            int datetime =  DateTime.Compare(DateTime.Now, dt_ngaythi.DateTime);
            int soCauHoiHeThong = getSoCauHoiCuaHeThong(cb_maMonHoc.SelectedValue.ToString(), cb_trinhdo.SelectedItem.ToString());
            
            if (lanthi <0)
            {
                message = "Số lần thi không hợp lệ!";
                return false;
            }
            if (lanthi > 2)
            {
                message = "Chỉ cho phép tối đa thi 2 lần";
                return false;
            }
            if (lanthi == 1)
            {
                bool check=checkTonTaiDKThi(cb_maMonHoc.SelectedValue.ToString(), cb_maLop.SelectedValue.ToString(), lanthi);
                if (check == true)
                {
                    message = "Đã đăng kí thi lần 1";
                    return false;
                }
            }
            if (lanthi == 2)
            {
                /*
                 * Kiểm tra xem lần 1 đã đăng kí chưa -> nếu chưa báo lỗi
                 * Kiểm tra xem lần 2 đã đăng kí chưa -> nếu đăng kí rồi thì báo lỗi
                 */

                bool check = checkTonTaiDKThi(cb_maMonHoc.SelectedValue.ToString(), cb_maLop.SelectedValue.ToString(), lanthi-1);
                if (check == false)
                {
                    message = "Bạn phải đăng kí thi lần 1 trước khi đăng kí thi lần 2";
                    return false;
                }
                bool check2 = checkTonTaiDKThi(cb_maMonHoc.SelectedValue.ToString(), cb_maLop.SelectedValue.ToString(), lanthi);
                if (check2 == true)
                {
                    message = "Đã đăng kí thi lần 2 !";
                    return false;
                }

            }
            if (socauhoi < 10 || socauhoi>100)
            {
                message = "Số câu hỏi phải nằm trong khoản 10-100!";
                return false;
            }
          
            if (thoigianthi < 15|| thoigianthi >60)
            {
                message = "Thời gian thi phải nằm trong khoản 15- 60 p";
                return false;
            }
            if (datetime > 0)
            {
                message = "Thời gian đăng ký không hợp lệ! ";
                return false;
            }

            if (socauhoi>soCauHoiHeThong)
            {
                message = "Số lượng câu hỏi trong hệ thống không đáp ứng được!";
                return false;
            }
            //
            return true;
        }
        private int getSoCauHoiCuaHeThong(string maMH, string trinhdo)
        {
            int kn = Program.KetNoi();
            if (kn == 0)
            {
                MessageBox.Show("Lỗi kết nối! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand sqlCommand = new SqlCommand("SP_DEM_CAU_HOI", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MAMH",maMH);
            sqlCommand.Parameters.AddWithValue("@TRINHDO", trinhdo);
            try
            {   
                int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
                return kq;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không kiểm tra được số câu hỏi có trong hệ thống " + ex, "Lỗi Phần Mềm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            
           
        }

        /* Trả về true: nếu đã tồn tại lần thi này
         * trả về false : nếu chưa tồn tại!
         */
        private bool checkTonTaiDKThi( string maMH, string malop, int lanthi)
        {
            
            int kn = Program.KetNoi();
            if (kn == 0)
            {
                MessageBox.Show("Lỗi kết nối! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand sqlCommand = new SqlCommand("CHECK_TON_TAI_GV_DK", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MAMH", maMH);
            sqlCommand.Parameters.AddWithValue("@MALOP", malop);
            sqlCommand.Parameters.AddWithValue("@LAN", lanthi);
            try
            {
                int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
                if (kq == 1)
                {
                    return true;
                }
                return false;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể kiểm tra đăng ký thí! \n" +ex, "Lỗi do thằng lập trình ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if (isDKMoi == true)
            {
                if (!checkValidate()) return;
            }
            else
            {
                if (!checkDKEdit()) return;
            }
           
            MessageBox.Show("Vao thi nè! ");
            string malop = cb_maLop.SelectedValue.ToString();
            string mamh = cb_maMonHoc.SelectedValue.ToString();
            string lanthi = spinEdit_lanthi.Text;
            string trinhdo = cb_trinhdo.SelectedItem.ToString();
            int socauthi = Int32.Parse(spinEdit_cauhoi.Text);
            int thoigianthi = Int32.Parse(spinEdit_thoigian.Text);

            DataTable db = Program.ExecSqlDataTable("EXEC SP_GET_DE_THI " + socauthi + ",'" + mamh + "','" + trinhdo + "'");
                int checkCount = db.Rows.Count;
                if (checkCount == 0)
                {
                    MessageBox.Show("Số câu hỏi thi trong hệ thống không đáp ứng đủ để thi!");
                }
                else
                {
              
                GiaoVienDK gv = new GiaoVienDK(
               Program.mUserId,
               mamh,
                malop,
                trinhdo,
                dt_ngaythi.DateTime,
                int.Parse(lanthi),
                socauthi,
                thoigianthi
               );
                GiaoVienDK.thithu = gv;
                List<BoDe> list = convertToListBD(db);
                    BoDe.thithu = list;
                    frmThiThu form = new frmThiThu();
                    form.ShowDialog();
                }
            
        }

        private List<BoDe> convertToListBD(DataTable ds)
        {
            List<BoDe> list = new List<BoDe>();
            foreach (DataRow row in ds.Rows)
            {
                BoDe bd = new BoDe(
                    Convert.ToInt32(row["CAUHOI"].ToString()),
                    row["MAMH"].ToString(),
                    row["TRINHDO"].ToString(),
                    row["NOIDUNG"].ToString(),
                    row["A"].ToString(),
                    row["B"].ToString(),
                    row["C"].ToString(),
                    row["D"].ToString(),
                    row["DAP_AN"].ToString(),
                    row["MAGV"].ToString()
                    );
                list.Add(bd);
            }
            return list;
        }
    }
}
