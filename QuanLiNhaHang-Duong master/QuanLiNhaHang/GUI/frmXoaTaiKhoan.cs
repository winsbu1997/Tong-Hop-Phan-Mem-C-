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

namespace QuanLiNhaHang.GUI
{
    public partial class frmXoaTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmXoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = Model.DangNhapMod.FillDataTableDN();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string TenDN = grvTaiKhoan.GetFocusedRowCellValue("IdDangNhap").ToString();
                int i = Controller.DangNhapCtr.DeleteDangNhap(TenDN);
                if (i == 1) MessageBox.Show("Xoá Thành Công");
                frmXoaTaiKhoan_Load(sender, e);
            }
            else MessageBox.Show("Xóa Không thành công");
        }
    }
}