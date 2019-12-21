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

namespace ThiTracNghiemBetta.form
{
    public partial class dialogGV : DevExpress.XtraEditors.XtraForm
    {
        public String type = "add";
        public dialogGV()
        {
            InitializeComponent();
        }

        private void dialogGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            if (type == "add")
            {
                // TODO: add new

                gIAOVIENBindingSource.AddNew();
                txtMaKHH.Text = kHOAComboBox.SelectedValue.ToString().Trim();
                txtMaGV.Focus();
            } else
            {
                txtMaGV.Enabled = false;  
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (type == "add")
            {
                // TODO: save new GV
                addGV();
            } else
            {
                // TODO: save change
                editGV();
            }
        }
        private void editGV()
        {
            if (validateForm())
            {
                try
                {
                    this.Validate();
                    this.gIAOVIENBindingSource.EndEdit();
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa Giáo Viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }
        private void addGV()
        {
            if (validateForm())
            {
                try
                {
                    this.Validate();
                    this.gIAOVIENBindingSource.EndEdit();
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Giao Vien " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private Boolean validateForm()
        {
            String ma = txtMaGV.Text.Trim();
            String ho = txtHo.Text.Trim();
            String ten = txtTen.Text.Trim();
            String hocVi = txtHocVi.Text.Trim();
            if (ma.Equals("") || ten.Equals("") || ho.Equals("") || hocVi.Equals(""))
            {
                MessageBox.Show("Không để trống các trường", "", MessageBoxButtons.OK);
                return false;
            }
            if (type == "add")
            {
                // TODO: check ma is existed
                bool rs = isMaTontai(ma);
                if (rs) return false;
            }
            return true;
        }

        private bool isMaTontai(String ma)
        {
            if (gIAOVIENBindingSource.SupportsSearching != true)
            {
                MessageBox.Show("Cannot search the list.");
                return false;
            }
          
            else
            {
                int foundIndex = gIAOVIENBindingSource.Find("MAGV", ma);
                if (foundIndex >=0)
                {
                    MessageBox.Show("Mã đã tồn tại");

                    return true;
                }
                return false;
            }
        }

        private void kHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKHH.Text = kHOAComboBox.SelectedValue.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (Program.Control == "Add")
            {
                if (MessageBox.Show("Dữ liệu đang nhập. Bạn muốn hủy bỏ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    gIAOVIENBindingSource.CancelEdit();
                    this.Close();
                }
            }
            if (Program.Control == "Edit")
            {
                if (MessageBox.Show("Dữ liệu đang chỉnh sửa. Bạn muốn hủy bỏ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    gIAOVIENBindingSource.CancelEdit();
                    this.Close();
                }
            }
        }

        ~dialogGV()
        {
            gIAOVIENBindingSource.CancelEdit();
        }
    }
    
}