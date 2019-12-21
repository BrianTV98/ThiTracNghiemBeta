﻿using System;
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
            this.bds_khoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

        }

        private void frmInputStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.ds.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.ds.LOP);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.ds.KHOA);

        }

        private void bar_btn_deleteLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }
        private bool checkValidateLop()
        {
            if (bds_sv.Count > 0)
            {
                MessageBox.Show("Lớp đã tồn tại sinh viên. Không thể xóa lớp này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            addClass f = new addClass();
            f.ShowDialog();
            gv_Lop.AddNewRow();
            
            txt_malop.Text = f.txtMaLop.Text.Trim();
            txt_tenLop.Text = f.txtTenLop.Text.Trim();
            txt_makhoa.Text = f.cb_makhoa.SelectedValue.ToString();
            if (f.state == true)
            {
                bds_lop.EndEdit();
                this.lOPTableAdapter.Update(this.ds.LOP);
            }
            else gv_Lop.DeleteSelectedRows();
           
        }

      
        private void sINHVIENDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
              
            }
    }

        private void btn_edit_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gv_Lop.FocusedRowHandle;
            frmEditClass f = new frmEditClass();
            f.txtMaLop.Text = gv_Lop.GetFocusedRowCellValue("MALOP").ToString();
            f.txtTenLop.Text = gv_Lop.GetFocusedRowCellValue("TENLOP").ToString();
            f.txt_maKhoa.Text = gv_Lop.GetFocusedRowCellValue("MAKH").ToString();
            f.ShowDialog();
            string test = f.txtTenLop.Text;
            txt_makhoa.Text = f.txt_maKhoa.Text;
            txt_tenLop.Text = f.txtTenLop.Text;
            txt_malop.Text = f.txtMaLop.Text;

            bds_lop.EndEdit();
            this.lOPTableAdapter.Update(this.ds.LOP);
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkValidateLop() == true)
            {
                var row = gv_Lop.FocusedRowHandle;
                gv_Lop.DeleteRow(row);
                bds_lop.EndEdit();
                this.lOPTableAdapter.Update(this.ds.LOP);
            }
        }

        private void btn_add_sv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*TO DO
             *  show form để nhận data 
             *  get data từ form;
             *  add data vao gridview
             */


            addSV f = new addSV();
            f.txt_malop.Text= gv_Lop.GetFocusedRowCellValue("MALOP").ToString();
            f.ShowDialog();

            //get data add data
            if (f.state == true)
            {
                
                DataRow row = this.ds.SINHVIEN.NewRow();
                row[0] = f.txt_ma_sv.Text.Trim();
                row[1] = f.txt_ho_sv.Text.Trim();
                row[2] = f.txt_ten_sv.Text.Trim();
                row[3] =  new DateTime(f.dt_picker.Value.Year, f.dt_picker.Value.Month, f.dt_picker.Value.Day) ;
                row[4] = f.txt_dia_chi.Text.Trim();
                row[5] = f.txt_malop.Text;
                this.ds.SINHVIEN.Rows.Add(row);
                bds_sv.EndEdit();
                sINHVIENTableAdapter.Update(this.ds.SINHVIEN);
            }
           
        }

        private void GV_SV_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var rowH = gv_Lop.FocusedRowHandle;
            var focusRowView = (DataRowView)gv_Lop.GetFocusedRow();
            if (focusRowView == null || focusRowView.IsNew)
            {
                return;
            }

            if (rowH >= 0)
            {
                popupSinhVien.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
            else popupSinhVien.HidePopup();
        }

        private void GV_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_edit_sv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*TO DO
             * tao form
             * gui thong tin sang form
             * thuc hien chinh sua
             * Update du lieu;
             */
            addSV f = new addSV();
            //gui du lieu
            f.txt_malop.Text = gv_Lop.GetFocusedRowCellValue("MALOP").ToString();
            f.txt_ma_sv.Text = GV_SV.CurrentRow.Cells[0].Value.ToString();
            f.txt_ho_sv.Text = GV_SV.CurrentRow.Cells[1].Value.ToString();
            f.txt_ten_sv.Text = GV_SV.CurrentRow.Cells[2].Value.ToString();
            f.dt_picker.Text = GV_SV.CurrentRow.Cells[3].Value.ToString();
            f.txt_dia_chi.Text = GV_SV.CurrentRow.Cells[4].Value.ToString();
            f.txt_ma_sv.Enabled = false;
           
            f.ShowDialog();

            //get data
            if (f.state == true)
            {
                GV_SV.CurrentRow.Cells[1].Value=f.txt_ho_sv.Text.Trim();
                GV_SV.CurrentRow.Cells[2].Value=f.txt_ten_sv.Text.Trim();
                GV_SV.CurrentRow.Cells[3].Value = new DateTime(f.dt_picker.Value.Year, f.dt_picker.Value.Month, f.dt_picker.Value.Day);
                GV_SV.CurrentRow.Cells[4].Value= f.txt_dia_chi.Text.Trim();
                bds_sv.EndEdit();
                sINHVIENTableAdapter.Update(this.ds.SINHVIEN);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void btn_delete_sv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GV_SV.Rows.Remove(GV_SV.CurrentRow);
            bds_sv.EndEdit();
            sINHVIENTableAdapter.Update(this.ds.SINHVIEN);
        }
    }
}