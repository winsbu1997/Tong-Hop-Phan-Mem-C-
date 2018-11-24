 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_CNPM.Data;

namespace BTL_CNPM.GUI
{
    public partial class ucDanhSachNhanVien : UserControl
    {
        private RM_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachNhanVien()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            ClearControl();
        }

        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyWord = txtTimKiem.Text.Trim().ToUpper();
            var listNv = db.NHANVIENs.ToList()
                           .Select(p => new
                           {
                               ID = p.ID,
                               HoTen = p.TEN,
                               ChucVu = (p.CHUCVU == 0) ? "Nhân viên" : "Quản trị viên"
                           })
                           .ToList();
            dgvNhanVienMain.DataSource = listNv.ToList()
                                         .Where(p => p.HoTen.ToUpper().Contains(keyWord) || p.ChucVu.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             HoTen = p.HoTen,
                                             ChucVu = p.ChucVu
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvNhanVien.FocusedRowHandle = index;
                dgvNhanVienMain.Select();
            }
            catch
            {

            }

        }
        private void ucDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvNhanVien();
            LockControl();
        }
        #endregion

        #region Hàm chức năng

        private NHANVIEN getNhanVienByID()
        {
            try
            {
                int id = (int)dgvNhanVien.GetFocusedRowCellValue("ID");
                NHANVIEN ans = db.NHANVIENs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new NHANVIEN();
                return ans;
            }
            catch
            {
                return new NHANVIEN();
            }
        }

        private NHANVIEN getNhanVienByForm()
        {
            NHANVIEN ans = new NHANVIEN();

            try
            {
                ans.MATKHAU = "1";
                ans.TAIKHOAN = txtTaiKhoan.Text;

                ans.TEN = txtHoTen.Text;
                ans.CHUCVU = cbxChucVu.SelectedIndex;
                ans.GIOITINH = cbxGioiTinh.SelectedIndex;
                ans.NGAYSINH = dateNgaySinh.DateTime;
                ans.SDT = txtSDT.Text;
                ans.QUEQUAN = txtQueQuan.Text;
                ans.EMAIL = txtEmail.Text;

                ans.ANH = Helper.imageToByteArray(imgAnh.Image);
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            cbxGioiTinh.SelectedIndex = 0;
            cbxChucVu.SelectedIndex = 0;
            dateNgaySinh.DateTime = DateTime.Now;

            txtHoTen.Text = "";
            txtTitleHoTen.Text = "";
            txtTitleChucVu.Text = "";
            txtSDT.Text = "";
            txtQueQuan.Text = "";
            txtEmail.Text = "";
            txtTaiKhoan.Text = "";

            imgAnh.Image = null;
        }

        private void UpdateDetail()
        {
            try
            {
                NHANVIEN nhanvien = getNhanVienByID();

                if (nhanvien.ID == 0) return;

                txtHoTen.Text = nhanvien.TEN;
                txtTitleHoTen.Text = nhanvien.TEN;
                txtTitleChucVu.Text = ((int)nhanvien.CHUCVU == 1) ? "Quản trị viên" : "Nhân viên";
                cbxChucVu.SelectedIndex = (int)nhanvien.CHUCVU;
                dateNgaySinh.DateTime = (DateTime)nhanvien.NGAYSINH;
                txtSDT.Text = nhanvien.SDT;
                txtEmail.Text = nhanvien.EMAIL;
                txtQueQuan.Text = nhanvien.QUEQUAN;
                txtTaiKhoan.Text = nhanvien.TAIKHOAN;

                cbxChucVu.SelectedIndex = (int)nhanvien.CHUCVU;
                cbxGioiTinh.SelectedIndex = (int)nhanvien.GIOITINH;

                imgAnh.Image = null;
                imgAnh.Image = Helper.byteArrayToImage(nhanvien.ANH);
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtHoTen.Enabled = false;
            cbxChucVu.Enabled = false;
            dateNgaySinh.Enabled = false;
            cbxGioiTinh.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            txtQueQuan.Enabled = false;
            imgAnh.Enabled = false;

            dgvNhanVienMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtTaiKhoan.Visible = false;
            lblTaiKhoan.Visible = false;
        }

        private void UnlockControl()
        {
            txtHoTen.Enabled = true;
            cbxChucVu.Enabled = true;
            dateNgaySinh.Enabled = true;
            cbxGioiTinh.Enabled = true;
            txtSDT.Enabled = true;
            txtEmail.Enabled = true;
            txtQueQuan.Enabled = true;
            imgAnh.Enabled = true;

            dgvNhanVienMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

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

            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            NHANVIEN k = getNhanVienByID();
            int cnt = db.NHANVIENs.Where(p => p.TAIKHOAN == txtTaiKhoan.Text && p.ID != k.ID).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Tài khoản đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            NHANVIEN tg = getNhanVienByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có nhân viên nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref NHANVIEN cu, NHANVIEN moi)
        {
            cu.TEN = moi.TEN;
            cu.CHUCVU = moi.CHUCVU;
            cu.GIOITINH = moi.GIOITINH;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.SDT = moi.SDT;
            cu.EMAIL = moi.EMAIL;
            cu.QUEQUAN = moi.QUEQUAN;
            cu.ANH = moi.ANH;
        }

        #endregion

        #region Sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnSua.Enabled = false;
                btnThem.Text = "Lưu";
                btnXoa.Text = "Hủy";

                ClearControl();
                UnlockControl();

                lblTaiKhoan.Visible = true;
                txtTaiKhoan.Visible = true;

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    LockControl();

                    lblTaiKhoan.Visible = false;
                    txtTaiKhoan.Visible = false;

                    NHANVIEN moi = getNhanVienByForm();
                    db.NHANVIENs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin nhân viên thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin nhân viên thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNhanVien();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";

                    LockControl();

                    NHANVIEN cu = getNhanVienByID();
                    NHANVIEN moi = getNhanVienByForm();

                    if (cu == Helper.nhanvien && moi.CHUCVU == 0)
                    {
                        MessageBox.Show("Bạn không được sửa quyền của chính mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin nhân viên thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                NHANVIEN cu = getNhanVienByID();

                if (cu == Helper.nhanvien)
                {
                    MessageBox.Show("Bạn không được phép xóa chính mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa nhân viên " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.NHANVIENs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin nhân viên thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin nhân viên thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvNhanVien();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }

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

        #endregion

        #region Sự kiện ngầm

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvNhanVien();
            txtTimKiem.Focus();
        }

        private void dgvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvNhanVien.FocusedRowHandle;
            }
            catch { }
        }

        #endregion


    }
}
