using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiemBetta.models;

namespace ThiTracNghiemBetta.form
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginModel loginModel = getLoginData();
            if (!loginModel.isValid())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin :(");
                return;
            }

            Program.servername = cbbCoSo.SelectedValue.ToString();
            Program.mChiNhanh = cbbCoSo.SelectedIndex;

            Program.mlogin = loginModel.userName;
            Program.password = loginModel.password;

            int kq = Program.KetNoi();
            if (kq == 0)
            {
                return;
            }
           
            String strlenh = "EXEC dbo.SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.mUserId = Program.myReader.GetString(0);
            Program.mHoTen = Program.myReader.GetString(1);
            Program.mNhom = Program.myReader.GetString(2);
            Program.mLoai = Program.myReader.GetString(3);
            Program.malop = Program.myReader.GetString(4);
            Program.tenlop = Program.myReader.GetString(5);

            Program.myReader.Close();

            //MessageBox.Show("Chào "+Program.mHoTen +"\nBạn đã đăng nhập thành công :)", "Thành công rực rỡ");
            this.Hide();
            switch (Program.mLoai)
            {
                case "giangvien":
                    {
                        Program.frmMain = new frmMain();
                        Program.frmMain.Activate();
                        Program.frmMain.Show();
                        break;
                    }
                case "sinhvien":
                    {
                        frmSV form = new frmSV();
                        form.Activate();
                        form.Show();
                        break;
                    }
            }

        }

        private LoginModel getLoginData()
        {
            LoginModel loginModel = new LoginModel();
            loginModel.userName = edtUserName.Text.Trim();
            loginModel.password = edtPassword.Text.Trim();
            return loginModel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
