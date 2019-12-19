using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemBetta.form.student
{
    public partial class frmInputStudent : Form
    {
        public frmInputStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPTDataSet);

        }

        private void frmInputStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.tN_CSDLPTDataSet.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPTDataSet.KHOA);

        }

        private void barBtn_EditLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bar_btn_deleteLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gv_Lop.FocusedRowHandle;
            gv_Lop.DeleteRow(row);
        }

        private void gv_Lop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var rowH = gv_Lop.FocusedRowHandle;
            var focusRowView = (DataRowView)gv_Lop.GetFocusedRow();
            if (focusRowView == null || focusRowView.IsNew) return;

            if (rowH >= 0)
            {
                popupMenuLop.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
            else popupMenuLop.HidePopup();
        }
    }
}
