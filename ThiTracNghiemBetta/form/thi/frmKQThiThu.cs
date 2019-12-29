using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ThiTracNghiemBetta.models;

namespace ThiTracNghiemBetta.form.thi
{
    public partial class frmKQThiThu : DevExpress.XtraEditors.XtraForm
    {
        public frmKQThiThu()
        {
            InitializeComponent();
        }

        private void frmKQThiThu_Load(object sender, EventArgs e)
        {
            summarylistview.View = View.Details;
            summarylistview.GridLines = true;
            summarylistview.FullRowSelect = true;
            foreach (CT_BaiThi ct in CT_BaiThi.thithu)
            {
                String[] arr = new string[3];
                arr[0] = ct.getThuTu().ToString();
                arr[1] = ct.getDapAnDaChon().ToString();
                arr[2] = ct.getDapAnDung().ToString();
                ListViewItem baiThi = new ListViewItem(arr);
                this.summarylistview.Items.Add(baiThi);
            }
        }
    }
}