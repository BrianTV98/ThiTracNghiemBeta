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
using ThiTracNghiemBetta.utils;

namespace ThiTracNghiemBetta.form.student
{
    public partial class addClass : Form
    {
        protected internal bool state=false;
        frmInputStudent frm = new frmInputStudent();
        public addClass(frmInputStudent f)
        {
            /*
             * Xóa Maxnimize va Minnima
             * default validate
             * Định dạng form nằm giữa màng hình
            */
            InitializeComponent();
            this.frm = f;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CancelButton = this.btnCancel;
            txtValidate.Text = frm.gv_Lop.GetFocusedRowCellValue("MALOP").ToString() +"1";
            this.CenterToScreen();

                var row = frm.gv_Lop.FocusedRowHandle;
                txtMaLop.Text = frm.gv_Lop.GetFocusedRowCellValue("MALOP").ToString();
                txtTenLop.Text = frm.gv_Lop.GetFocusedRowCellValue("TENLOP").ToString();
                cb_makhoa.Text = frm.gv_Lop.GetFocusedRowCellValue("MAKH").ToString();
            
           
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
            /*
             * Nếu check ok -> thêm vào lớp
             */
            if (checkValidateAddClass() == true)
            {
                DataRow dr= frm.ds.LOP.NewRow();
                dr[0] = txtMaLop.Text.Trim().ToUpper();
                dr[1] = utils.utils.chuanHoaTen(txtTenLop.Text);
                dr[2] = cb_makhoa.SelectedValue.ToString();
                frm.ds.LOP.Rows.Add(dr);
                frm.bds_lop.EndEdit();
                frm.adapterLop.Update(frm.ds.LOP);  
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
            /*
             * Kiểm tra mã lớp rỗng ko?
             * Kiểm tra các ký tự đặc biệt của mã lớp
             * kiểm tra mã lớp có tồn tại chưa
             * Kiểm tra lên lớp có rỗng không
             * kiểm tên lớp có tồn tại chưa (tên lớp khóa unique)
             */
            string malop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            if (malop.Length == 0)
            {
                txtValidate.Text = "Mã lớp không được để trống!";
                return false;
            }
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            if (regex.IsMatch(malop) == false)
            {
                txtValidate.Text = "Tên lớp không được chứa khoảng trắng hoặc ký tự đặc biệt";
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
