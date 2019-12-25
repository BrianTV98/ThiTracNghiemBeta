using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ThiTracNghiemBetta.form.thi;

namespace ThiTracNghiemBetta.form
{
    public partial class frmSV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmSV()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnTHI_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Form frm = this.CheckExists(typeof(frmThi));
             if (frm != null)
             {
                 Program.formThi.Activate();
             }
             else
             {
                 Program.formThi = new frmThi();
                 Program.formThi.MdiParent = Program.formSV;
                 Program.formThi.Show();
             }*/

            new frmTracNghiem().ShowDialog();
        }

        private void btnDANGXUAT_ItemClick(object sender, ItemClickEventArgs e)
        {
           /* DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "CẢNH BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.username = "";
                Program.mlogin = "";
                Program.password = "";
                GiaoVien_DangKy.gv_dk.Clear();
                GiaoVien_DangKy.gv_dkIndex = -1;
                Program.formDangNhap.Show();
                Program.formSV.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }*/
        }

        private void frmSV_Load(object sender, EventArgs e)
        {
            toolStripStatusHOTEN.Text = "Họ và tên: " + Program.mHoTen;
            toolStripStatusMAGV.Text = "Mã SV:" + Program.mUserId;
            toolStripStatusNHOM.Text = "nhóm: SINHVIEN";
            toolStripStatusMALOP.Text = "mã lớp: " + Program.svMaLop;
            toolStripStatusTENLOP.Text = "tên lớp: " + Program.svTenLop;
        }

        private void btnTRACUUDIEM_ItemClick(object sender, ItemClickEventArgs e)
        {
           /* Form frm = this.CheckExists(typeof(frmXemBaiThiSV));
            if (frm != null) Program.formXemBaiThiSV.Activate();
            else
            {
                Program.formXemBaiThiSV = new frmXemBaiThiSV();
                Program.formXemBaiThiSV.MdiParent = Program.formSV;
                Program.formXemBaiThiSV.Show();
            }*/
        }
    }
}