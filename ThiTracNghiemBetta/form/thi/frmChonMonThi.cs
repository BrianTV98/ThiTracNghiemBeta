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
using ThiTracNghiemBetta.models;

namespace ThiTracNghiemBetta.form.thi
{
    public partial class frmChonMonThi : Form
    {
        public frmChonMonThi()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* kiem tra xem ki thi nay co that su ton tai trong he thong khong
             * kiểm tra số câu hỏi trong dsdk thi
             * getRamdom câu hỏi thi
             * Kiểm tra số dòng lấy ra có đáp ứng đủ số câu thi không;
             */

            string malop = Program.malop.Trim();
            string mamh = cb_monHoc.SelectedItem.ToString();
            string lanthi = cb_lanThi.SelectedItem.ToString();
            string trinhdo = "";
            int socauthi = -1;
            int thoigianthi = -1;
            Program.KetNoi();
            string query = "EXEC SP_GET_DK_THI '" + malop + "','" + mamh + "','" + lanthi + "'";
            MessageBox.Show(query);
            SqlDataReader dkthi= Program.ExecSqlDataReader(query);
            
            if (dkthi == null)
            {
                
                MessageBox.Show("Đợt thi này không tồn tại trong hệ thống");
            }
            else
            {
                bool c=dkthi.Read();
                if (c == false)
                {
                    MessageBox.Show("Đợt thi này đã không còn tồn tại trong hệ thống! ");
                    return;
                }
                
                trinhdo = dkthi.GetString(3).Trim();
                socauthi = dkthi.GetInt16(6);
                thoigianthi = dkthi.GetInt16(7);
                GiaoVienDK gv = new GiaoVienDK(
                dkthi.GetString(0),
                dkthi.GetString(1),
                 dkthi.GetString(2),
                 trinhdo,
                 dkthi.GetDateTime(4),
                 dkthi.GetInt16(5),
                 socauthi,
                 thoigianthi
                );
                GiaoVienDK.gv_dk = gv;
                dkthi.Close();
                DataTable db = Program.ExecSqlDataTable("EXEC SP_GET_DE_THI '" + socauthi + "','" + mamh  + "','" + trinhdo + "'");

                int checkCount = db.Rows.Count;
                if (checkCount < socauthi)
                {
                    MessageBox.Show("Số câu hỏi thi trong hệ thống không đáp ứng đủ để thi!");

                }
                else
                {
                    this.Close();
                    List<BoDe> list = convertToListBD(db);
                    BoDe.boDe = list;

                    frmTracNghiem form = new frmTracNghiem();
                    form.ShowDialog();

                }
            }
        }
        
        private List<BoDe> convertToListBD(DataTable ds)
        {
            List<BoDe> list = new List<BoDe>();
            foreach (DataRow row in ds.Rows) {
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

        private bool check_validate()
        {
            /*
             * check so lan thi co hop le khong
             * 
             */
            return true;
        }
        private void frmChonMonThi_Load(object sender, EventArgs e)
        {
            /*
             * Load Mon Hoc Theo Lop
             * Set time hien tai cua he thong
             * Load So lan THi cua mon do
             */

            // load mon hoc
            Program.KetNoi();
            DataTable dtMonHoc = Program.ExecSqlDataTable("EXEC SP_TIM_MON_HOC_DK_THI_THEO_LOP '"+Program.malop.Trim()+"'");
           
            foreach (DataRow row in dtMonHoc.Rows)
            {
                string name = row["MAMH"].ToString();
                cb_monHoc.Items.Add(name);
            }
            if (cb_monHoc.Items.Count > 0)
            {
                cb_monHoc.SelectedIndex = 0;
                cb_lanThi.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Lớp của bạn hiện chưa có môn thi!");
            }
            

            // set time
            dtPicker.Value = DateTime.Now;

           
        }
        private int getSoLanDKThi()
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GET_SO_LAN_DANG_KI_MON_THI_THEO_LOP", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MALOP", Program.malop.Trim());
            sqlCommand.Parameters.AddWithValue("@MAMH", cb_monHoc.SelectedItem.ToString().Trim());
            int kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
            return kq;
        }

        private void cb_monHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            cb_lanThi.Items.Clear();
            int valueCbLanThi = getSoLanDKThi();

            if (valueCbLanThi != 0)
            {
                for (int i = 1; i <= valueCbLanThi; i++)
                {
                    cb_lanThi.Items.Add(i);
                    
                }
            }
            else
            {
                MessageBox.Show("Một con bug tìm tàng ở cb_lanthi");
            }
            cb_lanThi.SelectedIndex = 0;
        }
    }
}
