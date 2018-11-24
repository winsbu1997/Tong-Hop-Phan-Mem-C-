using DTO;
using BUS;
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
    public partial class frmKhachHang : Form
    {
        private KhachHangBUS khbus = new KhachHangBUS();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KhachHangBUS khBUS = new KhachHangBUS();
            dgvkhachhang.DataSource = khBUS.DanhSachKhachHang();
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvr = dgvkhachhang.Rows[e.RowIndex];
                txtTenKhachHang.Text = dgvr.Cells["tenkhachhang"].Value.ToString();
                txtSoDienThoai.Text = dgvr.Cells["sodienthoai"].Value.ToString();
                txtSochunminh.Text = dgvr.Cells["sochungminh"].Value.ToString();
                //txtGioiTinh.Text = dgvr.Cells["gioitinh"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvr.Cells["ngaysinh"].Value;
                txtdiadiem.Text = dgvr.Cells["diadiem"].Value.ToString();
                string s = dgvr.Cells["gioitinh"].Value.ToString();
                if (s == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }

            }
            catch
            {

            }
        }

        private void txtTimKiemKhach_TextChanged(object sender, EventArgs e)
        {
            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KhachHangBUS khBUS = new KhachHangBUS();
            if (cmbTimKiemKhach.SelectedIndex == 0)
            {
                dgvkhachhang.DataSource = khBUS.TimKiemKhachHang(0, txtTimKiemKhach.Text);
            }
            else if (cmbTimKiemKhach.SelectedIndex == 1)
                dgvkhachhang.DataSource = khBUS.TimKiemKhachHang(1, txtTimKiemKhach.Text);
            else if (cmbTimKiemKhach.SelectedIndex == 2)
                dgvkhachhang.DataSource = khBUS.TimKiemKhachHang(2, txtTimKiemKhach.Text);
            else if (cmbTimKiemKhach.SelectedIndex == 3)
                dgvkhachhang.DataSource = khBUS.TimKiemKhachHang(3, txtTimKiemKhach.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" | txtSoDienThoai.Text == "" | txtSochunminh.Text == "" | txtdiadiem.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                KhachHangBUS khBUS = new KhachHangBUS();
                KhachHang kh = new KhachHang();
                kh.Tenkhachhang = txtTenKhachHang.Text;
                kh.Sodienthoai = txtSoDienThoai.Text;
                kh.Sochungminh = txtSochunminh.Text;
                kh.Ngaysinh = dtpNgaySinh.Value;
                if (rdbNam.Checked) kh.Gioitinh = "Nam";
                if (rdbNu.Checked) kh.Gioitinh = "Nữ";
                kh.Diadiem = txtdiadiem.Text;

                if (khBUS.ThemKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // this.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" | txtSoDienThoai.Text == "" | txtSochunminh.Text == "" | txtdiadiem.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string gioitinh = null;
                string tenkhachhang = txtTenKhachHang.Text;
                string diadiem = txtdiadiem.Text;
                int sodienthoai = Int32.Parse(txtSoDienThoai.Text);
                int sochungminh = Int32.Parse(txtSochunminh.Text);
                DateTime ngaysinh = dtpNgaySinh.Value;
                if (rdbNam.Checked) { gioitinh = "Nam"; }
                if (rdbNu.Checked) { gioitinh = "Nữ"; }
                string makhachhang = dgvkhachhang.CurrentRow.Cells["makhachhang"].Value.ToString();

                if (khbus.SuaKhachHang(makhachhang, tenkhachhang, sodienthoai, ngaysinh, gioitinh, sochungminh, diadiem))
                {
                    MessageBox.Show("Sửa thành công");
                    frmKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Sửa");
                }

            }
        }
    }
}
