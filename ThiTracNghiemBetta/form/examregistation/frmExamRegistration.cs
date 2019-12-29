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
        public frmExamRegistration(frmListExamRegistration f)
        {
            InitializeComponent();
            this.frmRoot = f;
            txt_magv.Text = Program.mUserId.Trim();
            // default trinh do
            cb_trinhdo.SelectedIndex = 0;
            txt_validate.Text = "";
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
        }

        private void sOCAUTHILabel_Click(object sender, EventArgs e)
        {

        }

        private void mAGVLabel_Click(object sender, EventArgs e)
        {

        }

        private void nGAYTHILabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*TODO
             * checkvaldiate
             * Đăng kí
            */
            if (checkValidate() == true)
            {
                if (DANGKY() == true)
                {
                    MessageBox.Show("Đăng KÝ Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_validate.Text = "";
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_validate.Text = "";
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
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
        }
        private bool checkValidate()
        {
            /*
             * Kiem tra Trinh do -> chi nhan a, b,c 
             * Kiem tra Ngay THi ->  không được trong thời gian của quá khứ
             * Kiem tra Lan Thi  ->  chi nhan 1 va 2
             * Kiem tra Thoi Gian THi -> =>15 and <6=0
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
                txt_validate.Text = "Số lần thi không hợp lệ!";
                return false;
            }
            if (lanthi > 2)
            {
                txt_validate.Text = "Chỉ cho phép tối đa thi 2 lần";
                return false;
            }
            if (lanthi == 1)
            {
                bool check=checkTonTaiDKThi(cb_maMonHoc.SelectedValue.ToString(), cb_maLop.SelectedValue.ToString(), lanthi);
                if (check == true)
                {
                    txt_validate.Text="Đã đăng kí thi lần 1";
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
                    txt_validate.Text = "Bạn phải đăng kí thi lần 1 trước khi đăng kí thi lần 2";
                    return false;
                }
                bool check2 = checkTonTaiDKThi(cb_maMonHoc.SelectedValue.ToString(), cb_maLop.SelectedValue.ToString(), lanthi);
                if (check2 == true)
                {
                    txt_validate.Text = "Đã đăng kí thi lần 2 !";
                    return false;
                }

            }
            if (socauhoi < 15 || socauhoi>100)
            {
                txt_validate.Text = "Số câu hỏi phải nằm trong khoản 15-100!";
                return false;
            }
          
            if (thoigianthi < 15|| thoigianthi >60)
            {
                txt_validate.Text = "Thời gian thi phải nằm trong khoản 15- 60 p";
                return false;
            }
            if (datetime > 0)
            {
                txt_validate.Text = "Thời gian đăng ký không hợp lệ! ";
                return false;
            }

            if (socauhoi>soCauHoiHeThong)
            {
                txt_validate.Text = "Số lượng câu hỏi trong hệ thống không đáp ứng được!";
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
            int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
            return kq;
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
            int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
            if (kq == 1)
            {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if (!checkValidate()) return;

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
