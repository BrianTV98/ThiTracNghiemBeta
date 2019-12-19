using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemBetta.form.register
{
    public partial class loginAuthentication : Form
    {
        public loginAuthentication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void authentication_txt_login_Click(object sender, EventArgs e)
        {

        }

        private void aut_btn_aut_Click(object sender, EventArgs e)
        {
            String login = aut_txt_login.Text.Trim();
            String pass = aut_txt_passw.Text;
            if (login.Equals(Program.mlogin)&& pass.Equals(Program.password))
            {
                frmRegisterUsers.chechauthentication = true;
                this.Close();

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!","", MessageBoxButtons.OK,MessageBoxIcon.Error);

                if(dialogResult== DialogResult.OK)
                {
                    aut_txt_login.Text = "";
                    aut_txt_passw.Text = "";
                }
                else
                {
                   
                }
            }
        }

        private void loginAuthentication_Load(object sender, EventArgs e)
        {

        }
    }
}
