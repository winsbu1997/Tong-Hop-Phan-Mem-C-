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
    public partial class ucDanhSachLoaiMatHang : UserControl
    {
        private RM_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachLoaiMatHang()
        {
            InitializeComponent();
        }
        #endregion

        #region Hàm chức năng
        private LOAIMATHANG getLOAIMATHANGByID()
        {
            try
            {
                int id = (int)dgvLoaiMatHang.GetFocusedRowCellValue("ID");
                LOAIMATHANG ans = db.LOAIMATHANGs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new LOAIMATHANG();
                return ans;
            }
            catch
            {
                return new LOAIMATHANG();
            }
        }

        private LOAIMATHANG getLOAIMATHANGByForm()
        {
            LOAIMATHANG ans = new LOAIMATHANG();

            try
            {
                ans.TEN = txtTenLoaiMatHang.Text;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtTenLoaiMatHang.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                LOAIMATHANG tg = getLOAIMATHANGByID();

                if (tg.ID == 0) return;

                txtTenLoaiMatHang.Text = tg.TEN;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenLoaiMatHang.Enabled = false;

            dgvLoaiMatHangMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenLoaiMatHang.Enabled = true;

            dgvLoaiMatHangMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenLoaiMatHang.Text == "")
            {
                MessageBox.Show("Tên loại mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            LOAIMATHANG tg = getLOAIMATHANGByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có loại mặt hàng nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref LOAIMATHANG cu, LOAIMATHANG moi)
        {
            cu.TEN = moi.TEN;
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            ClearControl();
        }
        private void LoadDgvLOAIMATHANG()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listLOAIMATHANG = db.LOAIMATHANGs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN
                              })
                              .ToList();

            dgvLoaiMatHangMain.DataSource = listLOAIMATHANG.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvLoaiMatHang.FocusedRowHandle = index;
                dgvLoaiMatHangMain.Select();
            }
            catch
            {

            }
        }
        private void ucDanhSachLOAIMATHANG_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvLOAIMATHANG();
            LockControl();
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

                    LOAIMATHANG moi = getLOAIMATHANGByForm();
                    db.LOAIMATHANGs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin loại mặt hàng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin loại mặt hàng thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvLOAIMATHANG();
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

                    LOAIMATHANG cu = getLOAIMATHANGByID();
                    LOAIMATHANG moi = getLOAIMATHANGByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin loại mặt hàng thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin loại mặt hàng thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvLOAIMATHANG();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                LOAIMATHANG cu = getLOAIMATHANGByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa loại mặt hàng " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.LOAIMATHANGs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin loại mặt hàng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin loại mặt hàng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvLOAIMATHANG();

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
        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvLOAIMATHANG();
            txtTimKiem.Focus();
        }

        private void dgvLOAIMATHANG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvLoaiMatHang.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
