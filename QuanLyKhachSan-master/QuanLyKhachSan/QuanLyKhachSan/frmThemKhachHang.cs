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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" | txtSoDienThoai.Text == "" | txtSoChungMinh.Text == "" | txtNoio.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                KhachHangBUS khBUS = new KhachHangBUS();
                KhachHang kh = new KhachHang();
                kh.Tenkhachhang = txtTenKhachHang.Text;
                kh.Sodienthoai = txtSoDienThoai.Text;
                kh.Sochungminh = txtSoChungMinh.Text;
                kh.Ngaysinh = dtpNgaySinh.Value;
                if (rdbNam.Checked) kh.Gioitinh = "Nam";
                if (rdbNu.Checked) kh.Gioitinh = "Nữ";
                kh.Diadiem = txtNoio.Text;

                if (khBUS.ThemKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
