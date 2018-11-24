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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "" | txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                NhanVienBUS nvBUS = new NhanVienBUS();
                if (nvBUS.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                {
                    frmMain f = new frmMain();
                    NhanVien.Instance = nvBUS.LayThongTinNhanVien(txtTaiKhoan.Text, txtMatKhau.Text);
                    this.Hide();
                    f.ShowDialog();

                    txtTaiKhoan.Text = txtMatKhau.Text = "";
                    this.Show();
                    txtTaiKhoan.Focus();
                }
                else
                {
                    txtTaiKhoan.Focus();
                    txtTaiKhoan.Text = txtMatKhau.Text = "";
                }
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
