using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.GUI
{
    public partial class FrmDangNhap : Form
    {
        private Helper.DangNhapThanhCong dangnhapthanhcong;
        public FrmDangNhap(Helper.DangNhapThanhCong dn)
        {
            InitializeComponent();
            this.dangnhapthanhcong = dn;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = "SELECT TENDN FROM TAIKHOAN WHERE ID = 1";
            string TenDN = (string) DAO.SqlServerHelper.ExecuteScalar(query);

            query = "SELECT MATKHAU FROM TAIKHOAN WHERE ID = 1";
            string MatKhau = (string) DAO.SqlServerHelper.ExecuteScalar(query);

            if (txtTaiKhoan.Text == TenDN && txtMatKhau.Text == MatKhau)
            {
                MessageBox.Show("Đăng nhập thành công");
                dangnhapthanhcong();
                this.Close();
                return;
            }

            MessageBox.Show("Đăng nhập thất bại\nKiểm tra lại tên đăng nhập và mật khẩu");
        }
    }
}
