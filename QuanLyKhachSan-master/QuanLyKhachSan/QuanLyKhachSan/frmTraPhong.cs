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
    public partial class frmTraPhong : Form
    {
        private string mathuephong;
        private string tenphong;
        private string maphong;
        private decimal giaphong;
        private string tenkhach;
        private DateTime ngaythue;
        private int tiendichvu;
        private int songaythue;
        private int tongtien;
        private string manhanvien;
        TraPhongBUS trabus = new TraPhongBUS();
        PhongBUS phongbus = new PhongBUS();
        public frmTraPhong(string mathuephong, string tenphong,decimal giaphong ,string tenkhach, DateTime ngaythue, int tiendichvu, string manhanvien, string maphong)
        {
            InitializeComponent();
            this.mathuephong = mathuephong;
            this.tenphong = tenphong;
            this.giaphong = giaphong;
            this.tenkhach = tenkhach;
            this.ngaythue = ngaythue;
            this.tiendichvu = tiendichvu;
            this.manhanvien = manhanvien;
            this.maphong = maphong;
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            txtTenKH.Text = tenkhach;
            txtTenPhong.Text = tenphong;
            dtpNgayThuePhong.Value = ngaythue;
            dtpNgayTraPhong.Value = DateTime.Now;
            txtTienDichVu.Text = tiendichvu + "";
            int ngay = (dtpNgayTraPhong.Value - dtpNgayThuePhong.Value).Days;
            if (ngay == 0)
                songaythue = 1;
            else
                songaythue = ngay;
            txtSoNgay.Text = songaythue + "";
            txtTienThuePhong.Text = songaythue * giaphong + "";
            txtTongTien.Text = tiendichvu + int.Parse(txtTienThuePhong.Text) + "";
        }

        private void txtTienBoiThuong_TextChanged(object sender, EventArgs e)
        {
            if (txtTienBoiThuong.Text == "" || txtTienBoiThuong.Text == "0")
            {
                tongtien = tiendichvu + int.Parse(txtTienThuePhong.Text);
                txtTongTien.Text = tongtien + "";
            }
            else
            {
                txtTongTien.Clear();
                try
                {
                    tongtien = tiendichvu + int.Parse(txtTienThuePhong.Text) + int.Parse(txtTienBoiThuong.Text);
                    txtTongTien.Text = tongtien + "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập dữ liệu không đúng");
                }

            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string mathue = mathuephong;
            string matraphong = trabus.SinhMaTraPhong();
            decimal tongtien =decimal.Parse(txtTongTien.Text);
            DateTime ngaytra = dtpNgayTraPhong.Value;
            string manv = manhanvien;
            string thongtin = txtThongtin.Text;
            if (trabus.ThemTraPhong(mathue,matraphong, tongtien, ngaytra, manv, thongtin))
            {
                MessageBox.Show("Trả phòng thành công");
                phongbus.CapNhatTrangThaiPhong(maphong, 0);
                this.Close();
            }


            
        }
    }
}

