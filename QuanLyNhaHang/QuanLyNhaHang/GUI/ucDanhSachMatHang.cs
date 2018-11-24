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
    public partial class ucDanhSachMatHang : UserControl
    {
        private RM_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachMatHang()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            ClearControl();

            // Load loại mặt hàng combobox
            cbxLoaiMatHang.Properties.DataSource = db.LOAIMATHANGs
                                                   .Select(p => new
                                                   {
                                                       ID = p.ID,
                                                       TEN = p.TEN
                                                   }).ToList();
            cbxLoaiMatHang.Properties.DisplayMember = "TEN";
            cbxLoaiMatHang.Properties.ValueMember = "ID";
            cbxLoaiMatHang.ItemIndex = 0;
        }
        private void LoadDgvMatHang()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listMatHang = db.MATHANGs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  DonViTinh = p.DONVITINH,
                                  GiaBan = ((int)p.GIABAN).ToString("N0") + " vnđ",
                                  LoaiMatHang = db.LOAIMATHANGs.Where(z=>z.ID == p.LOAIMATHANGID).FirstOrDefault().TEN.ToString()
                              })
                              .ToList();

            dgvMATHANGMain.DataSource = listMatHang.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.DonViTinh.ToUpper().Contains(keyWord) || p.GiaBan.ToUpper().Contains(keyWord) || p.LoaiMatHang.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                             DonViTinh = p.DonViTinh,
                                             GiaBan = p.GiaBan,
                                             LoaiMatHang = p.LoaiMatHang
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvMATHANG.FocusedRowHandle = index;
                dgvMATHANGMain.Select();
            }
            catch
            {

            }
        }

        private void ucDanhSachMatHang_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvMatHang();
            LockControl();
        }
        #endregion

        #region Hàm chức năng
        private MATHANG getMATHANGByID()
        {
            try
            {
                int id = (int)dgvMATHANG.GetFocusedRowCellValue("ID");
                MATHANG ans = db.MATHANGs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new MATHANG();
                return ans;
            }
            catch
            {
                return new MATHANG();
            }
        }

        private MATHANG getMATHANGByForm()
        {
            MATHANG ans = new MATHANG();

            try
            {
                ans.TEN = txtTenMatHang.Text;
                ans.DONVITINH = txtDonViTinh.Text;
                ans.THANHPHAN = txtThanhPhan.Text;
                ans.LOAIMATHANGID = (int)cbxLoaiMatHang.EditValue;

                ans.GIABAN = Int32.Parse(txtGiaBan.Text);
                ans.ANH = Helper.imageToByteArray(imgAnh.Image);
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtTenMatHang.Text = "";
            txtDonViTinh.Text = "";
            txtThanhPhan.Text = "";
            txtGiaBan.Text = "";
            imgAnh.Image = null;
            cbxLoaiMatHang.ItemIndex = 0;

            txtTitleTen.Text = "";
            txtTitleDonViTinh.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                MATHANG tg = getMATHANGByID();

                if (tg.ID == 0) return;

                txtTenMatHang.Text = tg.TEN;
                txtDonViTinh.Text = tg.DONVITINH;
                txtThanhPhan.Text = tg.THANHPHAN;
                txtGiaBan.Text = tg.GIABAN.ToString();
                cbxLoaiMatHang.EditValue = tg.LOAIMATHANGID;

                txtTitleTen.Text = tg.TEN;
                txtTitleDonViTinh.Text = tg.DONVITINH;

                imgAnh.Image = null;
                imgAnh.Image = Helper.byteArrayToImage(tg.ANH);
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenMatHang.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtGiaBan.Enabled = false;
            txtThanhPhan.Enabled = false;
            imgAnh.Enabled = false;
            cbxLoaiMatHang.Enabled = false;
            
            dgvMATHANGMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenMatHang.Enabled = true;
            txtDonViTinh.Enabled = true;
            txtGiaBan.Enabled = true;
            txtThanhPhan.Enabled = true;
            imgAnh.Enabled = true;
            cbxLoaiMatHang.Enabled = true;

            dgvMATHANGMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (imgAnh.Image == null)
            {
                MessageBox.Show("Ảnh của mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTenMatHang.Text == "")
            {
                MessageBox.Show("Tên mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDonViTinh.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giasp = Int32.Parse(txtGiaBan.Text);
            }
            catch
            {
                MessageBox.Show("Giá của sản phẩm phải là số nguyên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        private bool CheckLuaChon()
        {
            MATHANG tg = getMATHANGByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có mặt hàng nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref MATHANG cu, MATHANG moi)
        {
            cu.TEN = moi.TEN;
            cu.DONVITINH = moi.DONVITINH;
            cu.GIABAN = moi.GIABAN;
            cu.THANHPHAN = moi.THANHPHAN;
            cu.ANH = moi.ANH;
            cu.LOAIMATHANGID = moi.LOAIMATHANGID;
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


                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    LockControl();

                    MATHANG moi = getMATHANGByForm();
                    db.MATHANGs.Add(moi);

                    try
                    {
                        db.SaveChanges();

                        KHO kho = new KHO();
                        kho.MATHANGID = moi.ID;
                        kho.SOLUONG = 0;
                        db.KHOes.Add(kho);
                        db.SaveChanges();

                        MessageBox.Show("Thêm thông tin mặt hàng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin mặt hàng thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvMatHang();
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

                    MATHANG cu = getMATHANGByID();
                    MATHANG moi = getMATHANGByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin mặt hàng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin mặt hàng thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvMatHang();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                MATHANG cu = getMATHANGByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.MATHANGs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin mặt hàng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin mặt hàng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvMatHang();

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
            LoadDgvMatHang();
            txtTimKiem.Focus();
        }

        
        private void dgvMatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvMATHANG.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
