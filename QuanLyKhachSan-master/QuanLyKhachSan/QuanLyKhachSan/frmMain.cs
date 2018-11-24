using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Phân quyền cho nhân viên hệ thống
            lblLoiChao.Text="Chào bạn: "+ NhanVien.Instance.Tennhanvien;
            if (NhanVien.Instance.Quyenhan == 2)
            {
                btnQuanLyDichVu.Enabled = false;
                btnQuanLyKhachHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnQuanLyTrangThietBi.Enabled = false;
                btnQuanLyPhong.Enabled = false;
                
            }
            #endregion
            LoadDanhSachPhong();
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietSuDungDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataKhachHangDV();

        }
        private void LoadDanhSachPhong()
        {
            PhongBUS phongBUS = new PhongBUS();
            lvPhong.Items.Clear();
            lvPhong.LargeImageList = imageList1;
            lvPhong.View = View.LargeIcon;
            foreach (Phong p in phongBUS.getListPhong())
            {
                ListViewItem lvItem = new ListViewItem(p.Tenphong);
                lvItem.SubItems.Add(p.Maphong);
                lvItem.SubItems.Add(p.Maloaiphong);
                lvItem.SubItems.Add(p.Giaphong.ToString());
                lvItem.SubItems.Add(p.Trangthai.ToString());
                //lvItem.SubItems.Add()
                if (p.Trangthai == 0)
                {
                    lvItem.ImageIndex = 0;
                    lvItem.BackColor = Color.Green;
                }
                else if (p.Trangthai == 1)
                {
                    lvItem.ImageIndex = 1;
                    lvItem.BackColor = Color.Red;
                }

                lvPhong.Items.Add(lvItem);


            }
            lvPhong.SelectedIndexChanged += LvPhong_SelectedIndexChanged;
        }
        #region cac bien lay du lieu cua khach
        private string masudungdichvu="";
        private void LoadSuDungDVPhong(string ma)
        {
            SuDungDichVuBUS sv = new SuDungDichVuBUS();
            dgvChiTietSuDungDichVu.DataSource = sv.DanhSachDVPhongSD(ma);
            txtTongTienDV.Text = sv.TongTienDichVu(masudungdichvu).ToString();
        }
        #endregion
        private void LvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhong.SelectedItems.Count > 0)
            {

                ListViewItem lv = lvPhong.SelectedItems[0];
        
                if (lv.SubItems[4].Text.Equals("1"))
                {
                    Phong p = new Phong();
                    p.Maphong = lv.SubItems[1].Text;
                    ThuePhongBUS thuephongbus = new ThuePhongBUS();
                    KhachHangBUS khBUS = new KhachHangBUS();
                    ThuePhong tp = new ThuePhong();
                    tp = thuephongbus.LayThongTinThuePhong(p.Maphong);
                    KhachHang kh = new KhachHang();
                    kh = khBUS.LayThongTinKhachHangTheoMa(tp.Makhachhang);
                    txtMaKhachHang.Text = kh.Makhachhang;
                    txtTenKhachHang.Text = kh.Tenkhachhang;
                    txtNgayThue.Text = tp.Ngaythue.ToString();
                    txtSoChungMinh.Text = kh.Sochungminh;

                    // Lay ma su dung dich vu tu thue phong

                    if (tp.Masudungdichvu != null)
                    {
                        masudungdichvu = tp.Masudungdichvu;
                        LoadSuDungDVPhong(masudungdichvu);
                    }
                }
                else
                {
                    txtMaKhachHang.Text = "";
                    txtTenKhachHang.Text = "";
                    txtNgayThue.Text = "";
                    txtSoChungMinh.Text = "";
                }

            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.ShowDialog();
        }

        private void btnQuanLyNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLyNhanVien f = new frmQuanLyNhanVien();
            f.ShowDialog();
        }


        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            frmThuePhong f = new frmThuePhong();
            f.ShowDialog();
            frmMain_Load(sender, e);


        }
        private void btnQuanLyTrangThietBi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThietBi f = new frmThietBi();
            f.ShowDialog();
        }

        private void btnQuanLyPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhong f = new frmPhong();
            f.ShowDialog();
            LoadDanhSachPhong();


        }

        private void btnThuePhong1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThuePhong f = new frmThuePhong();
            f.ShowDialog();
            LoadDanhSachPhong();
        }

        private void txtTimKiemDichVu_EditValueChanged(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = new DichVuBUS().TimKiemDichVu(txtTimKiemDichVu.Text);
        }
        private void LoadDataKhachHangDV()
        {
            dgvDichVu.DataSource = new DichVuBUS().DanhSachDichVu();
            txtMaDichVu.DataBindings.Add("Text", dgvDichVu.DataSource, "Madichvu");
            txtTenDV.DataBindings.Add("Text", dgvDichVu.DataSource, "Tendichvu");
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if(txtMaDichVu.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ sử dụng!");
            }
        
            else if (masudungdichvu == ""||txtMaKhachHang.Text=="")
            {
                MessageBox.Show("Phòng hiện đang trống!");
            }
            else
            {
                SuDungDichVuBUS sdBUs = new SuDungDichVuBUS();
                decimal dongia = (decimal)dgvDichVu.CurrentRow.Cells["Dongia"].Value;
                if (sdBUs.ThemChiTietSuDungDichVu(masudungdichvu, txtMaDichVu.Text, (int)nudSoLuong.Value, dongia * nudSoLuong.Value)){
                
                    LoadSuDungDVPhong(masudungdichvu);
                    SuDungDichVuBUS SuDungDichVuBUS = new SuDungDichVuBUS();
                    txtTongTienDV.Text = SuDungDichVuBUS.TongTienDichVu(masudungdichvu).ToString();
                }
                else if(sdBUs.CapNhatChiTietSuDungDichVu(masudungdichvu, txtMaDichVu.Text, (int)nudSoLuong.Value, dongia * nudSoLuong.Value))
                {
           
                    LoadSuDungDVPhong(masudungdichvu);
                    SuDungDichVuBUS SuDungDichVuBUS = new SuDungDichVuBUS();
                    txtTongTienDV.Text = SuDungDichVuBUS.TongTienDichVu(masudungdichvu).ToString()+"VND";
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                
            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            if (masudungdichvu == "" || txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Phòng hiện đang trống!");
            }
            else if (dgvChiTietSuDungDichVu.SelectedRows.Count > 0)
            {
                SuDungDichVuBUS sdBUs = new SuDungDichVuBUS();
                string madichvu = dgvChiTietSuDungDichVu.CurrentRow.Cells["madichvu1"].Value.ToString();
                string masudung = dgvChiTietSuDungDichVu.CurrentRow.Cells["masudungdichvu1"].Value.ToString();
                if (sdBUs.XoaChiTietSuDungDichVu(masudungdichvu, madichvu))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadSuDungDVPhong(masudungdichvu);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Chọn dịch vụ cần xóa!");
            }
        }

        private void btnQuanLyKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void btnQuanLyDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDichVu f = new frmDichVu();
            f.ShowDialog();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng để trả");
                return;
            }
            else
            {
                if (lvPhong.SelectedItems.Count > 0)
                {
                    PhongBUS phongBUS = new PhongBUS();
                    ListViewItem lv = lvPhong.SelectedItems[0];
                    Phong p = new Phong();
                    Phong p2 = new Phong();
                    p.Maphong = lv.SubItems[1].Text;
                    ThuePhongBUS thuephongbus = new ThuePhongBUS();
                    KhachHangBUS khBUS = new KhachHangBUS();
                    ThuePhong tp = new ThuePhong();
                    tp = thuephongbus.LayThongTinThuePhong(p.Maphong);
                    p2 = phongBUS.PhongTheoMa(p.Maphong);
                    string mathuephong =tp.Mathuephong;
                    string maphong = p.Maphong;
                    string tenphong =p2.Tenphong;
                    decimal giaphong =p2.Giaphong;
                    string tenkhach = txtTenKhachHang.Text;
                    DateTime ngaythue =DateTime.Parse(txtNgayThue.Text);
                    int tiendichvu = int.Parse(txtTongTienDV.Text);
                    string manhanvien = NhanVien.Instance.Manhanvien;
                    frmTraPhong frm = new frmTraPhong(mathuephong, tenphong,giaphong, tenkhach, ngaythue, tiendichvu, manhanvien, maphong);
                    frm.ShowDialog();
                    LoadDanhSachPhong();

                }
            }
        }
    }
}
