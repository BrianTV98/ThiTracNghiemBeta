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
    /* author: Tran Hieu
     * Date: 21/12/2019
     */

    public partial class addSV : Form
    {
        /*descrip :
         * state =false -> thao tac huy : ket qua se khong duoc save;
         * state= true -> thao tac xac thuc :  save ket qua ;
         */
        protected internal bool state = false;
       
        public addSV()
        {
            InitializeComponent();
            // disable Minimize va Maxnimax
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.CancelButton = this.btn_Cancel;
            txt_malop.Enabled = false;
            txt_validate.Text = "";
           
       
        }

        private void addSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (checkValidate() == true)
            {
                state = true;
                this.Close();
            }
        }

        /*tra ve true neu  tat ca du lieu deu hop le
         * tra ve false  neu 1 trong cac fiel du lieu khong hop le
         */
        private bool checkValidate() 
        {
            /*TO DO
             * check  rong tat cac cac fiel
             * kiểm tra ký tự rỗng của fiel mã sinh viên
             * check  check ma sv co ton tai chua
             */
            string maSv = txt_ma_sv.Text.Trim();
            string ho = txt_ho_sv.Text.Trim();
            string ten = txt_ten_sv.Text.Trim();
            string date = dt_picker.ToString().Trim();
            string diaChi = txt_dia_chi.Text.Trim();
            string maLop = txt_malop.Text.Trim();

            if (maSv.Length == 0)
            {
                txt_validate.Text = "Mã sinh viên không được rỗng! ";
                return false;
            }
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            if (regex.IsMatch(maSv) == false)
            {
                txt_validate.Text = "Tên lớp không được chứa khoảng trắng hoặc ký tự đặc biệt";
                return false;
            }
            if (ho.Length == 0)
            {
                txt_validate.Text = "Họ không được rỗng! ";
                return false;
            }

            if (ten.Length == 0)
            {
                txt_validate.Text = "Tên không được rỗng! ";
                return false;
            }
            if (date.Length == 0)
            {
                txt_validate.Text = "Ngày sinh không được được rỗng! ";
                return false;
            }
            if (diaChi.Length == 0)
            {
                txt_validate.Text = "Địa chỉ không được rỗng! ";
                return false;
            }
            if (maLop.Length == 0)
            {
                txt_validate.Text = "Mã lớp không được rỗng! ";
                return false;
            }

            if (txt_ma_sv.Enabled == true) // add thi mo khoa-> check , nguoc lai : edit  -> khoa -> uncheck
            {
                if (checkExistMASV(maSv) == true)
                {
                    txt_validate.Text = "Mã sinh viên bị trùng ";
                    return false;
                }
            }
            
            return true;

        }
        private bool checkExistMASV( string masv) // tra ve true neu ton tai - false neu khong ton tai
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.state = false;
            this.Close();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }
    }
}
