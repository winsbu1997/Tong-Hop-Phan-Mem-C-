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
using BTL_CNPM.Report;

namespace BTL_CNPM.GUI
{
    public partial class ucNhapHang : UserControl
    {
        private RM_Context db = Helper.db;
        private int index = 0, index1 = 0;

        #region Hàm khởi tạo
        public ucNhapHang()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            cbxNhanVien.Properties.DataSource = db.NHANVIENs.ToList().Select(p => new { ID = p.ID, Ten = p.TEN });
            cbxNhanVien.Properties.DisplayMember = "Ten";
            cbxNhanVien.Properties.ValueMember = "ID";

            cbxNhanVien.Enabled = false;
            cbxNhanVien.EditValue = Helper.nhanvien.ID;

            cbxMatHang.Properties.DataSource = db.MATHANGs.Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxMatHang.Properties.DisplayMember = "Ten";
            cbxMatHang.Properties.ValueMember = "ID";
            cbxMatHang.ItemIndex = 0;
        }

        private void LoadPhieuNhap()
        {
            btnLapPhieuNhap.Enabled = false;
            groupChiTietNhap.Enabled = true;
            btnLuuPhieuNhap.Enabled = true;

            txtMaPhieuNhap.Enabled = false;
            dateNgayNhap.Enabled = false;
            cbxNhanVien.Enabled = false;

            LockControl();
            LoadDgvChiTietNhap();
        }

        private void LoadDgvChiTietNhap()
        {
            int i = 0;
            var listChiTietNhap = (db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == Helper.phieunhap.ID).ToList()
                                  .Select(p => new
                                  {
                                      STT = ++i,
                                      ID = p.ID,
                                      MatHang = db.MATHANGs.Where(z => z.ID == p.MATHANGID).FirstOrDefault().TEN,
                                      DonGia = p.DONGIA,
                                      SoLuong = p.SOLUONG,
                                      ThanhTien = p.THANHTIEN
                                  })
                                  ).ToList();

            dgvCHITIETNHAPMain.DataSource = listChiTietNhap;

            UpdateDetail();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvCHITIETNHAP.FocusedRowHandle = index;
                dgvCHITIETNHAPMain.Select();
            }
            catch
            {

            }

        }
        private void ucNhapHang_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            if (Helper.phieunhap.ID == 0)
            {
                // chưa có phiếu nhập nào đc chọn
                LockPhieuNhap();
            }
            else
            {
                LoadPhieuNhap();
            }
        }
        #endregion

        #region Hàm chức năng
        private void LockPhieuNhap()
        {
            groupChiTietNhap.Enabled = false;
            btnLuuPhieuNhap.Enabled = false;
            btnLapPhieuNhap.Enabled = true;

            txtMaPhieuNhap.Enabled = true;
            dateNgayNhap.Enabled = true;
            cbxNhanVien.Enabled = false;


            dateNgayNhap.DateTime = DateTime.Now;
        }

        private CHITIETNHAP getCHITIETNHAPByID()
        {
            try
            {
                int id = (int)dgvCHITIETNHAP.GetFocusedRowCellValue("ID");
                CHITIETNHAP ans = db.CHITIETNHAPs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new CHITIETNHAP();
                return ans;
            }
            catch
            {
                return new CHITIETNHAP();
            }
        }

        private CHITIETNHAP getCHITIETNHAPByForm()
        {
            CHITIETNHAP ans = new CHITIETNHAP();

            try
            {
                ans.MATHANGID = (int)cbxMatHang.EditValue;
                ans.SOLUONG = (int)txtSoLuong.Value;
                ans.DONGIA = Int32.Parse(txtDonGia.Text);
                ans.THANHTIEN = ans.SOLUONG * ans.DONGIA;
                ans.PHIEUNHAPID = Helper.phieunhap.ID;
            }
            catch { }

            return ans;
        }

        private void ClearControl()
        {
            cbxMatHang.ItemIndex = 0;
            txtDonGia.Text = "";
            txtSoLuong.Value = 1;
        }

        private void UpdateDetail()
        {
            try
            {
                CHITIETNHAP tg = getCHITIETNHAPByID();
                txtTongTien.Text = ((int)Helper.phieunhap.TONGTIEN).ToString("N0");
                txtChiPhi.Text = ((int)Helper.phieunhap.TONGTIEN).ToString("N0");

                int id = (int)cbxMatHang.EditValue;
                txtDonViTinh.Text = db.MATHANGs.Where(p => p.ID == id).FirstOrDefault().DONVITINH;

                if (tg.ID == 0) return;

                
                cbxMatHang.ItemIndex = (int)tg.MATHANGID;
                txtDonViTinh.Text = "";
                txtSoLuong.Value = (int)tg.SOLUONG;

            }
            catch
            {

            }
        }

        private void LockControl()
        {
            cbxMatHang.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuong.Enabled = false;

            dgvCHITIETNHAPMain.Enabled = true;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            cbxMatHang.Enabled = true;
            txtDonViTinh.Enabled = true;
            txtDonGia.Enabled = true;
            txtSoLuong.Enabled = true;

            dgvCHITIETNHAPMain.Enabled = true;
        }

        private bool Check()
        {

            try
            {
                int dongia = Int32.Parse(txtDonGia.Text);

            }
            catch
            {
                MessageBox.Show("Đơn giá phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            CHITIETNHAP tg = getCHITIETNHAPByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có chi tiết nhập nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CapNhat(ref CHITIETNHAP cu, CHITIETNHAP moi)
        {
            cu.MATHANGID = moi.MATHANGID;
            cu.DONGIA = moi.DONGIA;
            cu.THANHTIEN = moi.THANHTIEN;
            cu.SOLUONG = moi.SOLUONG;
            cu.PHIEUNHAPID = moi.PHIEUNHAPID;
        }

        #endregion

        #region Sự kiện
        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            /// Check phiếu nhập

            if (txtMaPhieuNhap.Text == "")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cnt = db.PHIEUNHAPs.Where(p => p.MAPHIEUNHAP == txtMaPhieuNhap.Text).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PHIEUNHAP pn = new PHIEUNHAP();
            pn.MAPHIEUNHAP = txtMaPhieuNhap.Text;
            pn.NGAYNHAP = dateNgayNhap.DateTime;
            pn.NHANVIENID = (int)cbxNhanVien.EditValue;
            pn.TONGTIEN = 0;
            db.PHIEUNHAPs.Add(pn);

            try
            {
                db.SaveChanges();
                Helper.phieunhap = pn;
                MessageBox.Show("Lập phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuNhap();
            }
            catch
            {
                MessageBox.Show("Lập phiếu nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHoanThanhPhieuNhap_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Lưu thông tin phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LockPhieuNhap();

            try
            {
                foreach (var item in db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == Helper.phieunhap.ID).ToList())
                {
                    KHO kho = db.KHOes.Where(p => p.MATHANGID == item.MATHANGID).FirstOrDefault();
                    kho.SOLUONG += item.SOLUONG;
                }
                db.SaveChanges();
            }
            catch
            {

            }
            finally
            {
                Helper.phieunhap = new PHIEUNHAP();
            }


        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)Helper.phieunhap.ID;
                PHIEUNHAP hd = db.PHIEUNHAPs.Where(p => p.ID == ID).FirstOrDefault();
                FrmRpPhieuNhap form = new FrmRpPhieuNhap(hd);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Chưa có phiếu nhập nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
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

                    CHITIETNHAP moi = getCHITIETNHAPByForm();
                    db.CHITIETNHAPs.Add(moi);

                    try
                    {
                        db.SaveChanges();

                        Helper.phieunhap.TONGTIEN += moi.SOLUONG * moi.DONGIA;
                        db.SaveChanges();

                        MessageBox.Show("Thêm thông tin chi tiết nhập thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin chi tiết nhập thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvChiTietNhap();
                }
                return;
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                CHITIETNHAP cu = getCHITIETNHAPByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chi tiết nhập này không?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    Helper.phieunhap.TONGTIEN -= cu.SOLUONG * cu.DONGIA;
                    db.CHITIETNHAPs.Remove(cu);
                    db.SaveChanges();

                    MessageBox.Show("Xóa thông tin chi tiết nhập thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin chi tiết nhập thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvChiTietNhap();
                UpdateDetail();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }

       



        #endregion

        #region Sự kiện ngầm
        private void dgvChiTietHoaDon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index1 = index;
                index = dgvCHITIETNHAP.FocusedRowHandle;
            }
            catch { }
        }

        private void cbxMatHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int) cbxMatHang.EditValue;
                txtDonViTinh.Text = db.MATHANGs.Where(p => p.ID == id).FirstOrDefault().DONVITINH;
            }
            catch
            {

            }
        }
        #endregion


    }
}
