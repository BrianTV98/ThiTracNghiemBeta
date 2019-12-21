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

namespace ThiTracNghiemBetta.form.student
{
    public partial class addClass : Form
    {
        protected internal bool state=false;
        public addClass()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CancelButton = this.btnCancel;
            txtValidate.Text = "";
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void addClass_Load(object sender, EventArgs e)
        {
            //  kha nang loi connection -> fixx lopTAbleadapter.ConnectionString 
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet.KHOA);
           

        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            if (checkValidateAddClass() == true)
            {
                  state = true;
                  this.Close();
            }  
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
        private bool checkExistMaLop(string strLenh)
        {
            try
            {
                int kn = Program.KetNoi();
                if (kn == 0) {
                    MessageBox.Show("Sự cố kết nối!", "", MessageBoxButtons.OK);
                    return true;
                }
                    
                String strlenh = "EXEC dbo.SP_TIMKIEM_LOP '" + strLenh + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader.Read() != false)
                {
                    //MessageBox.Show("Mã lớp đã tồn tại", "", MessageBoxButtons.OK);
                    txtValidate.Text = "Mã lớp đã tồn tại";
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
            string malop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            if (malop.Length == 0)
            {
                txtValidate.Text = "Mã lớp không được để trống!";
                return false;
            }
            if (tenLop.Length == 0)
            {
                txtValidate.Text = "Tên lớp không được để trống!";
                return false;
            }
            if (checkExistMaLop(txtMaLop.Text.Trim()))
            {
                txtValidate.Text = "Mã lớp đã tồn tại!!";
                return false;
            }
            if (checkExistTenLop(txtTenLop.Text.Trim()))
            {
                txtValidate.Text = "Tên lớp đã tồn tại !";
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            state= false;
            this.Close();
        }
    }
}
