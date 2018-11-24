using BTL_CNPM.Data;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM.GUI
{
    public partial class FrmThongTinCaNhan : MetroForm
    {
        private RM_Context db = Helper.db;
        private NHANVIEN nhanvien = Helper.nhanvien;

        #region Hàm khởi tạo
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            try
            {
                txtHoTen.Text = nhanvien.TEN;
                txtTitleTen.Text = nhanvien.TEN;
                txtTitleChucVu.Text = ((int)nhanvien.CHUCVU == 1) ? "Quản trị viên" : "Nhân viên";
                cbxChucVu.SelectedIndex = (int)nhanvien.CHUCVU;
                dateNgaySinh.DateTime = (DateTime)nhanvien.NGAYSINH;
                txtSDT.Text = nhanvien.SDT;
                txtEmail.Text = nhanvien.EMAIL;
                txtQueQuan.Text = nhanvien.QUEQUAN;

                cbxChucVu.SelectedIndex = (int)nhanvien.CHUCVU;
                cbxGioiTinh.SelectedIndex = (int)nhanvien.GIOITINH;

                imgAnh.Image = null;
                imgAnh.Image = Helper.byteArrayToImage(nhanvien.ANH);
            }
            catch
            {

            }
        }
        #endregion

        #region Sự kiện

        private bool Check()
        {
            if (imgAnh.Image == null)
            {
                MessageBox.Show("Ảnh của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ tên của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!Check()) return;

            try
            {
                nhanvien.TEN = txtHoTen.Text;
                nhanvien.CHUCVU = cbxChucVu.SelectedIndex;
                nhanvien.GIOITINH = cbxGioiTinh.SelectedIndex;
                nhanvien.NGAYSINH = dateNgaySinh.DateTime;
                nhanvien.SDT = txtSDT.Text;
                nhanvien.QUEQUAN = txtQueQuan.Text;
                nhanvien.EMAIL = txtEmail.Text;

                nhanvien.ANH = Helper.imageToByteArray(imgAnh.Image);

                db.SaveChanges();
                MessageBox.Show("Thay đổi thông tin cá nhân thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thay đổi thông tin cá nhân không thành công\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void imgAnh_Click(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
            }
            catch
            {

            }

            try
            {
                Image image = Image.FromFile(path);

                imgAnh.Image = image;
            }
            catch
            {
                MessageBox.Show("Định dạng ảnh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
