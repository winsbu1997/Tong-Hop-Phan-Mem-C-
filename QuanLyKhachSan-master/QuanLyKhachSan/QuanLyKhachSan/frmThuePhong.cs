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
    public partial class frmThuePhong : Form
    {
        private List<Phong> dsPhongThue = new List<Phong>();
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();
            f.ShowDialog();
            frmThuePhong_Load(sender, e);
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbTimKiemKhach.SelectedIndex = 0;
            

        }

        private void txtTimKiemKhach_TextChanged(object sender, EventArgs e)
        {
            dgvKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KhachHangBUS khBUS = new KhachHangBUS();
            if (cmbTimKiemKhach.SelectedIndex == 0)
            {

                dgvKhach.DataSource = khBUS.TimKiemKhachHang(0, txtTimKiemKhach.Text);
            }
            else if (cmbTimKiemKhach.SelectedIndex == 1)
                dgvKhach.DataSource = khBUS.TimKiemKhachHang(1, txtTimKiemKhach.Text);
            else if (cmbTimKiemKhach.SelectedIndex == 2)
                dgvKhach.DataSource = khBUS.TimKiemKhachHang(2, txtTimKiemKhach.Text);
            else if (cmbTimKiemKhach.SelectedIndex == 3)
                dgvKhach.DataSource = khBUS.TimKiemKhachHang(3, txtTimKiemKhach.Text);
        }

        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow dgvr = dgvKhach.Rows[e.RowIndex];
                txtTenKhachHang.Text = dgvr.Cells["tenkhachhang"].Value.ToString();
                txtSoDienThoai.Text = dgvr.Cells["sodienthoai"].Value.ToString();
                txtSochunminh.Text = dgvr.Cells["sochungminh"].Value.ToString();
                txtGioiTinh.Text = dgvr.Cells["gioitinh"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvr.Cells["ngaysinh"].Value;

            }
            catch
            {

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            /// Load danh sách khách hàng
            dgvKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KhachHangBUS khBUS = new KhachHangBUS();
            dgvKhach.DataSource = khBUS.DanhSachKhachHang();

            ///Load danh sách phòng trống
            lvPhong.Items.Clear();
            PhongBUS pBUS = new PhongBUS();
            List<Phong> list = pBUS.DanhSachPhongTrong();
            foreach (Phong p in list)
            {
                ListViewItem lvitem = new ListViewItem(p.Maphong);
                lvitem.SubItems.Add(p.Tenphong);
                lvitem.SubItems.Add(p.Giaphong.ToString());
                lvitem.SubItems.Add(p.Songuoi.ToString());
                lvitem.SubItems.Add(p.Tenloaiphong);
                lvPhong.Items.Add(lvitem);
            }
            lvPhong.ItemChecked += LvPhong_ItemChecked;
        }

        private void LvPhong_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvPhong.CheckedItems.Count > 0)
            {
                ListViewItem lv = e.Item;
                Phong p = new Phong();
                p.Maphong = lv.SubItems[0].Text;
                p.Tenphong = lv.SubItems[1].Text;
                p.Giaphong = Decimal.Parse(lv.SubItems[2].Text);
               
                dsPhongThue.Add(p);
            }
           
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            if (dsPhongThue.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng nào !");
            }
            else if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng !");
            }
            else if (DialogResult.OK == MessageBox.Show("Bạn có chắc chắn thuê phòng không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                ThuePhongBUS tp = new ThuePhongBUS();
                string makhachhang = dgvKhach.CurrentRow.Cells["Makhachhang"].Value.ToString();
                if (tp.ThuePhong(dsPhongThue, dgvKhach.CurrentRow.Cells["Makhachhang"].Value.ToString(), NhanVien.Instance.Manhanvien, DateTime.Now))
                {
                    MessageBox.Show("Thuê phòng thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thuê phòng không thành công !");
                }
               
            }
            else
            {
                dsPhongThue.Clear();
                LoadData();
            }
            
        }
    }

}
