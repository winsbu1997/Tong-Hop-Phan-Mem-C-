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
    public partial class ucDanhSachBanAn : UserControl
    {
        private RM_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucDanhSachBanAn()
        {
            InitializeComponent();
        }
        #endregion

        #region Hàm chức năng
        private BANAN getBANANByID()
        {
            try
            {
                int id = (int)dgvBANAN.GetFocusedRowCellValue("ID");
                BANAN ans = db.BANANs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new BANAN();
                return ans;
            }
            catch
            {
                return new BANAN();
            }
        }

        private BANAN getBANANByForm()
        {
            BANAN ans = new BANAN();

            try
            {
                ans.TEN = txtTenBan.Text;
                ans.VITRI = txtViTri.Text;
                ans.SOCHO = Int32.Parse(txtSoCho.Text);
                ans.KHUVUCBANID = (int) cbxKhuVucBan.EditValue;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            txtTenBan.Text = "";
            txtViTri.Text = "";
            txtSoCho.Text = "";
            cbxKhuVucBan.ItemIndex = 0;
        }

        private void UpdateDetail()
        {
            try
            {
                BANAN tg = getBANANByID();

                if (tg.ID == 0) return;

                txtTenBan.Text = tg.TEN;
                txtViTri.Text = tg.VITRI;
                txtSoCho.Text = tg.SOCHO.ToString();
                cbxKhuVucBan.EditValue = tg.KHUVUCBANID;
            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtTenBan.Enabled = false;
            txtSoCho.Enabled = false;
            txtViTri.Enabled = false;
            cbxKhuVucBan.Enabled = false;

            dgvBANANMain.Enabled = true;
            txtTimKiem.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            txtTenBan.Enabled = true;
            txtSoCho.Enabled = true;
            txtViTri.Enabled = true;
            cbxKhuVucBan.Enabled = true;

            dgvBANANMain.Enabled = false;
            txtTimKiem.Enabled = false;
        }

        private bool Check()
        {
            if (txtTenBan.Text == "")
            {
                MessageBox.Show("Tên bàn ăn không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giasp = Int32.Parse(txtSoCho.Text);
            }
            catch
            {
                MessageBox.Show("Số chỗ của bàn ăn phải là số nguyên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            BANAN tg = getBANANByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref BANAN cu, BANAN moi)
        {
            cu.TEN = moi.TEN;
            cu.SOCHO = moi.SOCHO;
            cu.VITRI = moi.VITRI;
            cu.KHUVUCBANID = moi.KHUVUCBANID;
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            ClearControl();

            /// Load combobox khu vực bàn
            cbxKhuVucBan.Properties.DataSource = db.KHUVUCBANs
                                                   .Select(p=> new
                                                    {
                                                        TEN = p.TEN,
                                                        ID = p.ID
                                                    }).ToList();
            cbxKhuVucBan.Properties.DisplayMember = "TEN";
            cbxKhuVucBan.Properties.ValueMember = "ID";
            cbxKhuVucBan.ItemIndex = 0;
        }
        private void LoadDgvBANAN()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listBANAN = db.BANANs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  SoCho = p.SOCHO,
                                  ViTri = p.VITRI,
                                  KhuVucBan = db.KHUVUCBANs.Where(z=>z.ID == p.KHUVUCBANID).FirstOrDefault().TEN
                              })
                              .ToList();

            dgvBANANMain.DataSource = listBANAN.ToList()
                                         .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.ViTri.ToUpper().Contains(keyWord) || p.KhuVucBan.Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             Ten = p.Ten,
                                             SoCho = p.SoCho,
                                             ViTri = p.ViTri,
                                             KhuVucBan = p.KhuVucBan
                                         }).ToList();

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvBANAN.FocusedRowHandle = index;
                dgvBANANMain.Select();
            }
            catch
            {

            }
        }
        private void ucDanhSachBanAn_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvBANAN();
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

                    BANAN moi = getBANANByForm();
                    moi.TRANGTHAI = 0;
                    db.BANANs.Add(moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Thêm thông tin bàn ăn thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin bàn ăn thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBANAN();
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

                    BANAN cu = getBANANByID();
                    BANAN moi = getBANANByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sưa thông tin bàn ăn thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin bàn ăn thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvBANAN();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                BANAN cu = getBANANByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa bàn ăn " + cu.TEN + "?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    db.BANANs.Remove(cu);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thông tin bàn ăn thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin bàn ăn thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvBANAN();

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
            LoadDgvBANAN();
            txtTimKiem.Focus();
        }

        private void dgvBanAn_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvBANAN.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
