using BTL_CNPM.Data;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM.GUI
{
    public partial class FrmLogin : MetroForm
    {
        private RM_Context db = Helper.db;

        #region Hàm khởi tạo
        public FrmLogin()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion
        
        #region Sự kiện
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;

            if (taikhoan == "")
            {
                MessageBox.Show("Tài khoản không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (matkhau == "")
            {
                MessageBox.Show("Mật khẩu không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int cnt = db.NHANVIENs.Where(p => p.TAIKHOAN == taikhoan && p.MATKHAU == matkhau).ToList().Count;
            if (cnt == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Helper.nhanvien = db.NHANVIENs.Where(p => p.TAIKHOAN == taikhoan && p.MATKHAU == matkhau).FirstOrDefault();

            FrmMain form = new FrmMain();
            this.Hide();
            form.ShowDialog();
            this.Show();
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            this.Focus();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
