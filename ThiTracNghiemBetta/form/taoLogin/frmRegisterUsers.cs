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
using ThiTracNghiemBetta.form.register;
using ThiTracNghiemBetta.models;

namespace ThiTracNghiemBetta.form
{
  
    public partial class frmRegisterUsers : Form
    {
        public static Boolean chechauthentication = false;
        List<GiaoVien> listGiaoVien = new List<GiaoVien>();
        public string message = "";
        public frmRegisterUsers()
        {
            InitializeComponent();
            // khoi tao gia tri cho cac combobox
            if (Program.mNhom.Equals("TRUONG"))
            {
                this.cb_nhom.Items.AddRange(new object[] {
                "TRUONG"});
            }
            else if(Program.mNhom.Equals("COSO")){
                this.cb_nhom.Items.AddRange(new object[] {
                "COSO",
                "GIANGVIEN"});
            }
            // set default for combobox nhom
            cb_nhom.SelectedIndex = 0; 

           
            // get list GiaoVien
            int kq = Program.KetNoi();
            if (kq == 0)
            {
                return;
            }

            String strlenh = "SELECT * FROM GIAOVIEN";
            SqlDataReader objReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            if (objReader.HasRows)
            {
                while (objReader.Read())
                {
                    //I would also check for DB.Null here before reading the value.
                    string maGV = objReader.GetString(0);
                    string ho= objReader.GetString(1);
                    string ten = objReader.GetString(2);
                    string hocvi = objReader.GetString(3);
                    string khoa= objReader.GetString(4);
                    listGiaoVien.Add(new GiaoVien(maGV, ho, ten,hocvi, khoa));
                }
            }
            foreach(GiaoVien g in listGiaoVien)
            {
                this.cb_MAGV.Items.Add(g.MaGV);
            }
            

            //set again position for groupbox
            groupGV.Left = this.Width / 2;
            groupGV.Top = this.Height / 4;
        }

        private void cb_MAGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position=cb_MAGV.SelectedIndex;
            txt_name.Text = listGiaoVien[position].Ho + listGiaoVien[position].Ten;
            txt_maKhoa.Text = listGiaoVien[position].MaKh;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (check_validate() == false)// 
            {
                // thong bao ra
                MessageBox.Show( message, "Lỗi ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
          
            String strlenh = "EXEC dbo.SP_TAOLOGIN '" + txt_login.Text + "', '" + txt_password.Text + "','" + cb_MAGV.SelectedItem + "', '" + cb_nhom.SelectedItem + "'";
            ExceSP(strlenh);
        
        }
        private bool check_validate()
        {
            /*
             *Kiểm tra tên tài khoản có trống không!
             * Kiểm tra tên tài khoản có chứa khoảng trắng không và không chưa các kí tự đặc biệt
             * Kiểm tra password có trống không
             * Kiểm tra cofirm có trùng vs pass không
             */
            string login = txt_login.Text;
            string password = txt_password.Text;
            string confirm = txt_confirm.Text;

            if (login.Length == 0)
            {
                message =  "Tên tài khoản không được trống !";
                return false;
            }
            /*if(login.Contains(" ") == true)
            {
                message = "Tên đăng nhập không được chứa ký tự space";
            }*/
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            if (regex.IsMatch(login)==false)
            {
                message = "Tên đăng nhập không được chứa ký tự space và kí tự đặc biệt";
                return false;
            }
            if (password.Length == 0)
            {
                message = "Password không được để trống!";
                return false;
            }
            if (!password.Equals(confirm))
            {
                message = "Xác nhận mật khẩu chưa chính xác!";
                return false;
            }
            return true;
        }
        public static void ExceSP(String strLenh)
        {
            Program.KetNoi();
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                MessageBox.Show("Đăng Ký Thành Công! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                Program.conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không! ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                Program.frmMain.btBD.Enabled = Program.frmMain.btCancel.Enabled = Program.frmMain.btDSDK.Enabled = Program.frmMain.btKHOA.Enabled = Program.frmMain.btlogin.Enabled = Program.frmMain.btLOP.Enabled = Program.frmMain.btMonHoc.Enabled = true;
                Program.frmMain.btnXEMBAITHI.Enabled = Program.frmMain.btnXEMBANGDIEM.Enabled = Program.frmMain.btnXEMDSDANGKY.Enabled = true;
                this.Close();
            }
        }
    }
}
