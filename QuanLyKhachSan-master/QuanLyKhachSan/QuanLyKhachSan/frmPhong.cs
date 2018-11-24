using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmPhong : Form
    {
        private LoaiPhongBUS lpBus = new LoaiPhongBUS();
        private PhongBUS phongbus = new PhongBUS();
        private ChiTietThietBiPhongBUS chitietBus = new ChiTietThietBiPhongBUS();
        private ThietBiBUS tbbus = new ThietBiBUS();

        public frmPhong()
        {
            InitializeComponent();
            DanhSachLoaiPhong();
            LoaiPhongBiding();
            DanhSachPhong();
            HienThiLoaiPhong();
            PhongBinding();
            HienThiMaThietBi();
           
        }

        #region quan ly phong

        private void DanhSachPhong()
        {
            dgvPhong.DataSource = phongbus.getListPhong();
            

        }
        void PhongBinding()
        {
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "Maphong", true, DataSourceUpdateMode.Never));
            txtTenPhong.DataBindings.Clear();
            txtTenPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "Tenphong", true, DataSourceUpdateMode.Never));
            cbLoaiPhong.DataBindings.Clear();
            cbLoaiPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "Maloaiphong", true, DataSourceUpdateMode.Never));
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "Tenloaiphong", true, DataSourceUpdateMode.Never));
            txtSoNguoi.DataBindings.Clear();
            txtSoNguoi.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "Songuoi", true, DataSourceUpdateMode.Never));
            txtGiaPhong.DataBindings.Clear();
            txtGiaPhong.DataBindings.Add(new Binding("Text", dgvPhong.DataSource, "Giaphong", true, DataSourceUpdateMode.Never));
            rdbDaThue.DataBindings.Clear();
            rdbTrong.DataBindings.Clear();
            var check=new Binding("Checked", dgvPhong.DataSource, "Trangthai", true, DataSourceUpdateMode.Never);
            check.Format += (s, args) => args.Value = ((int)args.Value) == 1;
            check.Parse += (s, args) => args.Value = (bool)args.Value ? "1" : "0";
            rdbDaThue.DataBindings.Add(check);
            rdbDaThue.CheckedChanged += (s, args) => rdbTrong.Checked = !rdbDaThue.Checked;
        }
        
            
        void HienThiLoaiPhong()
        {
            List<LoaiPhong> dsLoaiPhong = lpBus.DanhSachLoaiPhong();
            string line;
            foreach(var item in dsLoaiPhong)
            {
                line = item.Maloaiphong;
                cbLoaiPhong.Items.Add(line);
            }
        }
       
        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maloaiphong = cbLoaiPhong.SelectedItem.ToString();
            LoaiPhong p = lpBus.ThongTinLoaiPhong(maloaiphong);
            txtSoNguoi.Text = p.Songuoi +"";
            txtGiaPhong.Text = p.Giaphong + "";
            txtTenLoai.Text = p.Tenloaiphong + "";
        }
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maphong = txtMaPhong.Text;
            dgvChiTietTb.DataSource = chitietBus.ThietBiTheoPhong(maphong);
            ThietBiBinding();
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            string maphong = phongbus.SinhMaPhong();
            string tenphong = txtTenPhong.Text;
            string maloaiphong = cbLoaiPhong.Text;
            int trangthai = 0;
            if (maphong != "" && tenphong != "" && maloaiphong != "")
            {
                if (phongbus.KiemTraMaPhong(maphong))
                {
                    MessageBox.Show("Mã phòng đã tồn tại!!");
                    return;
                }
                if (phongbus.ThemPhong(maphong, tenphong, maloaiphong, trangthai))
                {
                    MessageBox.Show("Thêm mới thành công");
                    DanhSachPhong();
                    PhongBinding();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm ");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập dữ liệu!");
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa nó", "Thông báo!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string maphong = txtMaPhong.Text;
                string tenphong = txtTenPhong.Text;
                string maloaiphong = cbLoaiPhong.Text;
                int trangthai = Convert.ToInt32(rdbDaThue.Checked);
                try
                {
                    if (phongbus.SuaPhong(maphong, tenphong, maloaiphong, trangthai))
                    {
                        MessageBox.Show("Sửa thành công");
                        DanhSachPhong();
                        PhongBinding();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                catch
                { }
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa nó?? ";
            string caption = "Thông báo!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string maphong = txtMaPhong.Text;
                if (phongbus.XoaPhong(maphong))
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
                DanhSachLoaiPhong();
                PhongBinding();
            }
        }

        private void txtTimKiemPhong_TextChanged(object sender, EventArgs e)
        {
            dgvPhong.DataSource = phongbus.TimKiemPhong(txtTimKiemPhong.Text);
            PhongBinding();
            frmPhong_Load(sender, e);

        }
        #endregion
        #region chitietthietbiphong
        void HienThiMaThietBi()
        {
            List<ThietBi> dsThietBi = tbbus.DanhSachThietBi();
            string line;
            foreach(var item in dsThietBi)
            {
                line = item.Mathietbi;
                cbMaTB.Items.Add(line);
            }
        }
        private void cbMaTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mathietbi = cbMaTB.SelectedItem.ToString();
            ThietBi tb = tbbus.ThietBiTheoMa(mathietbi);
            txtTenTB.Text = tb.Tenthietbi + "";
        }
        void ThietBiBinding()
        {
            cbMaTB.DataBindings.Clear();
            cbMaTB.DataBindings.Add(new Binding("Text", dgvChiTietTb.DataSource, "Mathietbi", true, DataSourceUpdateMode.Never));
            txtTenTB.DataBindings.Clear();
            txtTenTB.DataBindings.Add(new Binding("Text", dgvChiTietTb.DataSource, "Tenthietbi", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvChiTietTb.DataSource, "Soluong", true, DataSourceUpdateMode.Never));
        }
        private void btnThemTB_Click(object sender, EventArgs e)
        {
            string mathietbi = cbMaTB.Text;
            string maphong = txtMaPhong.Text;
            string soluong = txtSoLuong.Text;
            if (mathietbi != "" && soluong != "")
            {
                if(chitietBus.Kiemtramathietbi(mathietbi, maphong))
                {
                    MessageBox.Show("Thiết bị đã có trong phòng");
                    return;
                }
                if (chitietBus.ThemThietBiPhong(mathietbi, maphong, soluong))
                {
                    MessageBox.Show("Thêm mới thành công");
                    frmPhong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm ");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập dữ liệu!");
            }
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            string maphong = txtMaPhong.Text;
            dgvChiTietTb.DataSource = chitietBus.ThietBiTheoPhong(maphong);
            ThietBiBinding();
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa nó?? ";
            string caption = "Thông báo!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string maphong = txtMaPhong.Text;
                string mathietbi = cbMaTB.Text;
                if (chitietBus.XoaThietBiPhong(mathietbi, maphong))
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
                frmPhong_Load(sender, e);
            }
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa nó", "Thông báo!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string mathietbi = cbMaTB.Text;
                string maphong = txtMaPhong.Text;
                string soluong = txtSoLuong.Text;
                if (chitietBus.SuaThietBiPhong(mathietbi, soluong, maphong))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Sửa");
                }
                frmPhong_Load(sender, e);
            }
        }
        #endregion
        #region quan ly loai phong

        private void DanhSachLoaiPhong()
        {
            dgvLoaiPhong.DataSource = lpBus.DanhSachLoaiPhong();
        }

        private void LoaiPhongBiding()
        {
            txtMaLP.DataBindings.Clear();
            txtMaLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Maloaiphong", true, DataSourceUpdateMode.Never));
            txtTenLP.DataBindings.Clear();
            txtTenLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Tenloaiphong", true, DataSourceUpdateMode.Never));
            txtGiaLP.DataBindings.Clear();
            txtGiaLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Giaphong", true, DataSourceUpdateMode.Never));
            txtSoNguoiLP.DataBindings.Clear();
            txtSoNguoiLP.DataBindings.Add(new Binding("Text", dgvLoaiPhong.DataSource, "Songuoi", true, DataSourceUpdateMode.Never));
        }

        private void btnThemLP_Click(object sender, EventArgs e)
        {
            string maloaiphong = lpBus.SinhMaLoaiPhong();
            string tenloaiphong = txtTenLP.Text;
            decimal giaphong = Decimal.Parse(txtGiaLP.Text);
            int songuoi = Int32.Parse(txtSoNguoiLP.Text);
            if (maloaiphong.ToString() != "" && tenloaiphong.ToString() != "" && giaphong.ToString() != "" && songuoi.ToString() != "")
            {
                if (lpBus.ThemLoaiPhong(maloaiphong, tenloaiphong, giaphong, songuoi))
                {
                    MessageBox.Show("Thêm mới thành công");
                    DanhSachLoaiPhong();
                    LoaiPhongBiding();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm ");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập dữ liệu!");
            }
        }

        private void btnSuaLP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa nó", "Thông báo!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string maloaiphong = txtMaLP.Text;
                string tenloaiphong = txtTenLP.Text;
                decimal giaphong = Decimal.Parse(txtGiaLP.Text);
                int songuoi = Int32.Parse(txtSoNguoiLP.Text);
                if (lpBus.SuaLoaiPhong(maloaiphong, tenloaiphong, giaphong, songuoi))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Sửa");
                }
                DanhSachLoaiPhong();
                LoaiPhongBiding();
            }
        }

        private void btnXoaLP_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa nó?? ";
            string caption = "Thông báo!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string maloaiphong = txtMaLP.Text;
                if (lpBus.XoaLoaiPhong(maloaiphong))
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
                DanhSachLoaiPhong();
                LoaiPhongBiding();
            }
        }

        private void txtTimKiemLP_TextChanged(object sender, EventArgs e)
        {
            dgvLoaiPhong.DataSource = lpBus.TimKiemloaiphong(txtTimKiemLP.Text);
        }
    }

    #endregion quan ly loai phong
}