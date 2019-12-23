using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiemBetta.models;

namespace ThiTracNghiemBetta.thi
{
    public partial class Thi : Form
    {
        /*
         * Tạo đồng hồ
         * Load dữ liệu từ CSDL vào (Số lượng câu hỏi, và câu hỏi được radom trực tiếp trên database);
         * Load thời gian thi từ CSDL
         * Cho phép thi
         * Chấm bài
         * Lưu vào CSDL
         */

            // load Time từ CSDL
        Timer t = new Timer();
        int mm = 1;
        int ss = 10;
        List<BoDe> bode = new List<BoDe>();
        int index = 0;
        public Thi()
        {
            /*
             * Load Cau Hoi tu CSDL  đổ vào list
             */
            InitializeComponent();
            this.CenterToScreen();
            //load bộ đề và câu hỏi đầu tiên
            fakeData();
            loadCauHoi(0);
        }
        private void Thi_Load(object sender, EventArgs e)
        {
            // tạo đồng hồ
            //timer Interval
            t.Interval = 1000;
           
            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
        }
        private void t_Tick(object sender,EventArgs e)
        {
            //get time;
            string time = "";
            string timess = "";
            string timemm = "";
            if (mm == 0 && ss==0)
            {
                this.Close();
            }
            if (ss != 0)
            {
                ss--; 
            }
            else
            {
                mm--;
                ss = 59;
            }
            if (mm < 10)
            {
                timemm = "0" + mm;
            }
            else timemm = mm.ToString();
            if (ss < 10)
            {
                timess = "0" + ss;
            }
            else timess = ss.ToString();
            time = timemm + ":" + timess;
            label1.Text = time;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Bạn có muốn nộp bài trước thời gian quy định không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
           
        }
        private void fakeData()
        {
            bode.Add(new BoDe("", "", "", "Người yêu tôi tên gì?", "Dell", "Asus", "MacBook", "ThinkPad","A",""));
            bode.Add(new BoDe("", "", "", "Câu hỏi 2?", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            bode.Add(new BoDe("", "", "", "Câu hỏi 3", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            bode.Add(new BoDe("", "", "", "Câu Hỏi 4?", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            bode.Add(new BoDe("", "", "", "Câu hỏi 5", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));
            bode.Add(new BoDe("", "", "", "Câu hỏi 6", "Dell", "Asus", "MacBook", "ThinkPad", "A", ""));

        }
        private void loadCauHoi( int index)
        {
            lbCauHoi.Text = bode[index].NoiDung;
            rbtnA.Text = bode[index].DapAnA;
            rbtnB.Text = bode[index].DapAnB;
            rbtnC.Text = bode[index].DapAnC;
            rbtnD.Text = bode[index].DapAnD;
            lbInfor.Text = "Câu : " + (index+1) + "/" + bode.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                loadCauHoi(index);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < bode.Count-1)
            {
                index++;
                loadCauHoi(index);
            }
        }
    }
}
