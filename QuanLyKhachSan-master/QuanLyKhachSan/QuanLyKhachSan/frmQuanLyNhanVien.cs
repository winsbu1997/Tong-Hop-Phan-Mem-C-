using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUS;
using DTO;

namespace QuanLyKhachSan
{
    public partial class frmQuanLyNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private int trangthai = 0;
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cmbTimKiem.SelectedIndex = 0;
            cmbQuyenHan.SelectedIndex = 0;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.DataSource = new NhanVienBUS().DanhSachNhanVien();
            grbNhanVien.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            trangthai = 1;
            txtTenNhanVien.Text = txtQueQuan.Text = txtTaiKhoan.Text = txtMatKhau.Text = "";
            txtMatKhau.Enabled = txtTaiKhoan.Enabled = true;
            grbNhanVien.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            trangthai = 2;
            grbNhanVien.Enabled = true;
            if (txtTenNhanVien.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào!");
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyNhanVien_Load(sender, e);
        }

        private void btnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtTaiKhoan.Text == "" | txtMatKhau.Text == "" | txtTenNhanVien.Text == "" | txtQueQuan.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin !");
            }
           
            else
            {
                NhanVienBUS nvBus = new NhanVienBUS();
                NhanVien1 nv = new NhanVien1();
                nv.Manhanvien = txtMaNhanVien.Text;
                nv.Quequan = txtQueQuan.Text;
                nv.Taikhoan = txtTaiKhoan.Text;
                nv.Tennhanvien = txtTenNhanVien.Text;
                nv.Matkhau = txtMatKhau.Text;
                nv.Ngaysinh = dtpNgaySinh.Value;
                if (cmbQuyenHan.SelectedIndex == 0) nv.Quyenhan = 1;
                if (cmbQuyenHan.SelectedIndex == 1) nv.Quyenhan = 2;
                if (rdbNam.Checked) nv.Gioitinh = "Nam";
                if (rdbNu.Checked) nv.Gioitinh = "Nữ";
                if (trangthai == 0)
                {
                    MessageBox.Show("Vui lòng chọn chức năng !");
                }
                if (trangthai == 1)
                {
                    if (new NhanVienBUS().KiemTraTaiKhoanTonTai(txtTaiKhoan.Text))
                    {
                        MessageBox.Show("Tai khoan da ton tai");
                    }
                    else if (nvBus.ThemNhanVien(nv))
                    {
                        MessageBox.Show("Thêm thành công");
                        frmQuanLyNhanVien_Load(sender, e);
                    }
                    else MessageBox.Show("Thêm không thành công !");

                }
                if(trangthai == 2)
                {
                    if (nvBus.SuaNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công");
                        frmQuanLyNhanVien_Load(sender, e);
                    }
                    else MessageBox.Show("Sửa không thành công !");
                }
               
            }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            NhanVienBUS nvBus = new NhanVienBUS();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (cmbTimKiem.SelectedIndex == 0)
            {
                dgvNhanVien.DataSource = nvBus.TimKiemNhanVien(0, txtTimKiem.Text);
            }
            else if(cmbTimKiem.SelectedIndex==1)
                dgvNhanVien.DataSource = nvBus.TimKiemNhanVien(1, txtTimKiem.Text);
        
    }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dgvNhanVien.CurrentRow;
                txtMaNhanVien.Text = dr.Cells["Manhanvien"].Value.ToString();
                txtTenNhanVien.Text = dr.Cells[1].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dr.Cells["Ngaysinh"].Value;
                if (dr.Cells[3].Value.ToString().Equals("Nam")) rdbNam.Checked = true;
                if (dr.Cells[3].Value.ToString().Equals("Nữ")) rdbNam.Checked = true;
                txtTaiKhoan.Text = dr.Cells["Taikhoan"].Value.ToString();
                txtQueQuan.Text = dr.Cells["Quequan"].Value.ToString();
                txtMatKhau.Text = dr.Cells["Matkhau"].Value.ToString();
                txtMatKhau.Enabled = false;
                txtTaiKhoan.Enabled = false;
                if ((int)dr.Cells["Quyenhan"].Value == 1) cmbQuyenHan.SelectedIndex = 1;
                if ((int)dr.Cells["Quyenhan"].Value == 2) cmbQuyenHan.SelectedIndex = 0;
            }
            catch
            {

            }
        }
    }
}