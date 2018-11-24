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
    public partial class ucDanhSachKhuVucBan : UserControl
    {
        private RM_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachKhuVucBan()
        {
            InitializeComponent();
        }
        #endregion

        #region Hàm chức năng
        private KHUVUCBAN getKHUVUCBANByID()
        {
            try
            {
                int id = (int)dgvKhuVuc.GetFocusedRowCellValue("ID");
                KHUVUCBAN ans = db.KHUVUCBANs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new KHUVUCBAN();
                return ans;
            }
            catch
            {
                return new KHUVUCBAN();
            }
        }

        private KHUVUCBAN getKHUVUCBANByForm()
        {
            KHUVUCBAN ans = new KHUVUCBAN();

            try
            {
                ans.TEN = txtTenKhuVuc.Text;
                ans.VITRI = txtViTri.Text;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtTenKhuVuc.Text = "";
            txtViTri.Text = "";
        }

        private void UpdateDetail()
        {
            try
            {
                KHUVUCBAN tg = getKHUVUCBANByID();

                if (tg.ID == 0) return;

                txtTenKhuVuc.Text = tg.TEN;
                txtViTri.Text = tg.VITRI;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenKhuVuc.Enabled = false;
            txtViTri.Enabled = false;

            dgvKhuVucMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenKhuVuc.Enabled = true;
            txtViTri.Enabled = true;

            dgvKhuVucMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenKhuVuc.Text == "")
            {
                MessageBox.Show("Tên khu vực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtViTri.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            

            return true;
        }

        private bool CheckLuaChon()
        {
            KHUVUCBAN tg = getKHUVUCBANByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có khu vực nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref KHUVUCBAN cu, KHUVUCBAN moi)
        {
            cu.TEN = moi.TEN;
            cu.VITRI = moi.VITRI;
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            ClearControl();
        }
        private void LoadDgvKHUVUCBAN()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listKHUVUCBAN = db.KHUVUCBANs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  ViTri = p.VITRI
                              })
                              .ToList();

            dgvKhuVucMain.DataSource = listKHUVUCBAN.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.ViTri.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                             ViTri = p.ViTri
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvKhuVuc.FocusedRowHandle = index;
                dgvKhuVucMain.Select();
            }
            catch
            {

            }
        }
        private void ucDanhSachKHUVUCBAN_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvKHUVUCBAN();
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

                    KHUVUCBAN moi = getKHUVUCBANByForm();
                    db.KHUVUCBANs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin khu vực thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin khu vực thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvKHUVUCBAN();
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

                    KHUVUCBAN cu = getKHUVUCBANByID();
                    KHUVUCBAN moi = getKHUVUCBANByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin khu vực thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin khu vực thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvKHUVUCBAN();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                KHUVUCBAN cu = getKHUVUCBANByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa khu vực " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.KHUVUCBANs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin khu vực thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin khu vực thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvKHUVUCBAN();

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
            LoadDgvKHUVUCBAN();
            txtTimKiem.Focus();
        }

        private void dgvKHUVUCBAN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvKhuVuc.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
