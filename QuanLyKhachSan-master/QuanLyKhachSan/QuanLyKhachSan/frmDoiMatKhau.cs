using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "" | txtMatKhauMoi.Text == "" | txtMatKhauXacNhan.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtMatKhauCu.Text != NhanVien.Instance.Matkhau)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                }
                else if (txtMatKhauMoi.Text != txtMatKhauXacNhan.Text)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận không khớp");
                }


                else
                {
                    NhanVienBUS nvBUS = new NhanVienBUS();
                    if (nvBUS.DoiMatKhau(txtMaNhanVien.Text, txtMatKhauMoi.Text)){
                        MessageBox.Show("Đổi mật khẩu thành công");
                        NhanVien.Instance = new NhanVienBUS().LayThongTinNhanVien(NhanVien.Instance.Taikhoan, txtMatKhauMoi.Text);
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                    this.Close();
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = NhanVien.Instance.Manhanvien;
            txtTaiKhoan.Text = NhanVien.Instance.Taikhoan;
            txtTenNhanVien.Text = NhanVien.Instance.Tennhanvien;
            txtMatKhauCu.Focus();

        }
    }
}
