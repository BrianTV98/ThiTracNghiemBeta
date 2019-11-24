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
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tN_CSDLPTDataSet.V_DS_PHANMANH);

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginModel loginModel = validateForm();
            if (!loginModel.isValid())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }

            MessageBox.Show("Hợp lí");

        }

        private LoginModel validateForm()
        {
            LoginModel loginModel = new LoginModel();
            loginModel.serverName = cbbCoSo.SelectedValue.ToString();
            loginModel.userName = edtUserName.Text.Trim();
            loginModel.password = edtPassword.Text.Trim();
            UserType userType = UserType.None;
            if (radSinhVien.Checked)
            {
                userType = UserType.SinhVien;
            } 
            if (radGiangVien.Checked) 
            {
                userType = UserType.GiangVien;
            }
            loginModel.userType = userType;
            return loginModel;
        }
    }
}
