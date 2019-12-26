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
    public partial class frmEditClass : Form
    {
        public frmEditClass()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txt_validate.Text = "";
            this.CenterToScreen();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            if (checkValidate() == true)
            {

                this.Close();
            }
                
           
        }
        private bool checkValidate()
        {


            string tenLop = txtTenLop.Text.Trim();

            if (tenLop.Length == 0)
            {
                //MessageBox.Show("Tên lớp không được để trống! ");
                txt_validate.Text = "Tên lớp không được để trống! ";
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand("SP_KIEM_TRA_TON_TAI_TEN_LOP", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@TENLOP", txtTenLop.Text);
            int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
            if (kq != 0)
            {
                txt_validate.Text = "Tên lớp đã tồn tại ở cơ sở "+kq +"! ";
                return false;
            }
            return true;
            
        }

        private void frmEditLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet.KHOA);

        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);
        }
        
    }
}
