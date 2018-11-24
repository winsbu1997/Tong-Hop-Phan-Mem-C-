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
using DevExpress.XtraEditors;
using BTL_CNPM.Report;

namespace BTL_CNPM.GUI
{
    public partial class ucBanHang : UserControl
    {
        private RM_Context db = Helper.db;
        private int IDBanAn = 0;
        private BANAN banan = new BANAN();

        #region Hàm khởi tạo
        public ucBanHang()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm

        private void LoadDgvHoaDon(int idHoaDon)
        {
            int i = 0;
            var listChiTiet = db.CHITIETHOADONs.ToList()
                              .Where(p => p.HOADONID == idHoaDon)
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  STT = ++i,
                                  MatHang = db.MATHANGs.Where(z=>z.ID == p.MATHANGID).FirstOrDefault().TEN,
                                  DonGia = ((int)p.DONGIA).ToString("N0"),
                                  SoLuong = p.SOLUONG,
                                  ThanhTien = ((int) (p.DONGIA * p.SOLUONG)).ToString("N0")
                              });

            dgvHoaDonMain.DataSource = listChiTiet;
        }
        private void LoadDsBanAn()
        {
            try
            {
                int KhuVucID = (int)cbxKhuVuc.EditValue;
                var listBanAn = db.BANANs.Where(p=>p.KHUVUCBANID == KhuVucID).ToList();

                panelDsBanAn.Controls.Clear();
                foreach (var item in listBanAn)
                {
                    ucBanAn uc = new ucBanAn(item, ucClick);
                    panelDsBanAn.Controls.Add(uc);
                }

                IDBanAn = listBanAn.FirstOrDefault().ID;
                UpdateDetail(IDBanAn);
            }
            catch
            {

            }
        }

        private void LoadMonAn()
        {
            try
            {
                int LoaiMatHangID = (int)cbxLoaiMatHang.EditValue;

                cbxGMMatHang.Properties.DataSource = db.MATHANGs.Where(p=>p.LOAIMATHANGID == LoaiMatHangID)
                                                     .Select(p => new
                                                     {
                                                         ID = p.ID,
                                                         MatHang = p.TEN
                                                     })
                                                     .ToList();
                cbxGMMatHang.Properties.DisplayMember = "MatHang";
                cbxGMMatHang.Properties.ValueMember = "ID";
                cbxGMMatHang.ItemIndex = 0;
            }
            catch
            {

            }
        }

        private void ucClick(object sender,EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            UpdateDetail((int)button.Tag);
        }

        private void UpdateDsBanAn()
        {
            try
            {
                foreach (var item in panelDsBanAn.Controls)
                {
                    ucBanAn uc = item as ucBanAn;
                    uc.Refresh();
                }
            }
            catch { }
        }

        private void LoadInitControl()
        {
            try
            {
                /// Load cbx khu vực
                cbxKhuVuc.Properties.DataSource = db.KHUVUCBANs
                                                    .Select(p => new
                                                    {
                                                        ID = p.ID,
                                                        TEN = p.TEN
                                                    }).ToList();
                cbxKhuVuc.Properties.DisplayMember = "TEN";
                cbxKhuVuc.Properties.ValueMember = "ID";
                cbxKhuVuc.ItemIndex = 0;

                /// Load cbx loại mặt hàng
                cbxLoaiMatHang.Properties.DataSource = db.LOAIMATHANGs
                                                         .Select(p => new
                                                         {
                                                             ID = p.ID,
                                                             TEN = p.TEN
                                                         }).ToList();
                cbxLoaiMatHang.Properties.DisplayMember = "TEN";
                cbxLoaiMatHang.Properties.ValueMember = "ID";
                cbxLoaiMatHang.ItemIndex = 0;

                /// load cbx mặt hàng
                LoadMonAn();

                LoadBanTrong();
            }
            catch
            {

            }
        }

        private void LoadBanTrong()
        {
            try
            {
                int KhuVucID = (int)cbxKhuVuc.EditValue;
                cbxCBBanAn.Properties.DataSource = db.BANANs
                                                   .Where(p=>p.KHUVUCBANID == KhuVucID)
                                                   .Where(p => p.TRANGTHAI == 0).ToList()
                                                   .Where(p=>p.ID != IDBanAn)
                                                   .Select(p => new
                                                   {
                                                       ID = p.ID,
                                                       BanAn = p.TEN
                                                   }).ToList();
                cbxCBBanAn.Properties.DisplayMember = "BanAn";
                cbxCBBanAn.Properties.ValueMember = "ID";

                cbxCBBanAn.ItemIndex = 0;
            }
            catch { }
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            if (db.MATHANGs.ToList().Count == 0)
            {
                MessageBox.Show("Danh sách mặt hàng đang trống\nVui lòng thêm mặt hàng ở mục quản trị",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Hide();
            }

            if (db.BANANs.ToList().Count == 0)
            {
                MessageBox.Show("Danh sách bàn ăn đang trống\nVui lòng thêm bàn ăn ở mục quản trị",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Hide();
            }

            LoadInitControl();
            ClearControl();
            LoadDsBanAn();

            
        }
        #endregion

        #region Hàm chức năng
        // Hiển thị danh sách các món đã gọi khi click vào bàn
        private void UpdateDetail(int ID)
        {
            try
            {
                BANAN ba = db.BANANs.Where(p => p.ID == ID).FirstOrDefault();
                if (ba == null) return;

                IDBanAn = ID;
                banan = ba;
                txtTenBanAn.Text = ba.TEN + " : ";

                LoadBanTrong();
                ClearControl();
                if (ba.TRANGTHAI == 0) return;

                if (ba.TRANGTHAI == 1)
                {
                    int idHoaDon = (int)ba.HOADONID;
                    LoadDgvHoaDon(idHoaDon);
                    HOADON hd = db.HOADONs.Where(p => p.ID == ba.HOADONID).FirstOrDefault();
                    txtTongTien.Text = ((int)hd.TONGTIEN).ToString("N0");
                }
            }
            catch
            {

            }
        }

        private void ClearControl()
        {
            txtTongTien.Text = "0";
            dgvHoaDonMain.DataSource = null;
        }
        #endregion

        #region Sự kiện
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            /// kiểm tra đã có bàn ăn nào được chọn chưa
            if(IDBanAn == 0)
            {
                MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra xem bàn ăn là bàn đã có khách hay chưa có khách
            BANAN banan = db.BANANs.Where(p => p.ID == IDBanAn).FirstOrDefault();
            if (banan.HOADONID == null)
            {
                MessageBox.Show("Bàn ăn không có khách",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra lại xem đã muốn thanh toán chưa
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn thanh toán và in hóa đơn?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Question);

            if (rs == DialogResult.Cancel) return;

            try
            {
                

                if (rs == DialogResult.OK)
                {
                    /// xuất report hóa đơn
                    int ID = (int) banan.HOADONID;
                    HOADON hd = db.HOADONs.Where(p => p.ID == ID).FirstOrDefault();
                    int khuyenmai = (int)txtKhuyenMai.Value;

                    FrmRpHoaDon form = new FrmRpHoaDon(hd, khuyenmai);
                    form.ShowDialog();

                    hd.KHUYENMAI = khuyenmai;
                    db.SaveChanges();

                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                banan.TRANGTHAI = 0;
                banan.HOADONID = null;
                db.SaveChanges();

                UpdateDsBanAn();
                UpdateDetail(banan.ID);
            }
            catch
            {
                MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            try
            {
                /// Kiểm tra bàn ăn xem đã được chọn chưa
                if (IDBanAn == 0)
                {
                    MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                int idMatHang = (int) cbxGMMatHang.EditValue;
                MATHANG mathang = db.MATHANGs.Where(p => p.ID == idMatHang).FirstOrDefault();
                int SoLuongGM = (int) txtGMSoLuong.Value;
                int SoLuong = (int) db.KHOes.Where(p => p.MATHANGID == idMatHang).FirstOrDefault().SOLUONG;

                // Kiểm tra kho
                if (SoLuong < SoLuongGM)
                {
                    MessageBox.Show("Không đủ hàng (" + SoLuong + ")",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                /// Trừ số lượng trong kho
                KHO kho = db.KHOes.Where(p => p.MATHANGID == idMatHang).FirstOrDefault();
                kho.SOLUONG -= SoLuongGM;

                if (banan.HOADONID == null)
                {
                    // nếu bàn ăn này chưa chứa hóa đơn nào
                    HOADON hd = new HOADON();
                    hd.NGAYNHAP = DateTime.Now;
                    hd.TONGTIEN = 0;
                    hd.NHANVIENID = Helper.nhanvien.ID;
                    hd.MAHOADON = "";
                    hd.KHUYENMAI = 0;
                    db.HOADONs.Add(hd);
                    db.SaveChanges();

                    hd.MAHOADON = "HD" + hd.ID;
                    banan.TRANGTHAI = 1;
                    banan.HOADONID = hd.ID;
                    db.SaveChanges();

                    CHITIETHOADON chitiet = new CHITIETHOADON();
                    chitiet.HOADONID = hd.ID;
                    chitiet.SOLUONG = SoLuongGM;
                    chitiet.MATHANGID = mathang.ID;
                    chitiet.DONGIA = mathang.GIABAN;
                    chitiet.THANHTIEN = chitiet.DONGIA * chitiet.SOLUONG;
                    db.CHITIETHOADONs.Add(chitiet);
                    hd.TONGTIEN = chitiet.THANHTIEN;
                    db.SaveChanges();
                }
                else
                {
                    // nếu bàn ăn này đã chứa hóa đơn
                    HOADON hd = db.HOADONs.Where(p => p.ID == banan.HOADONID).FirstOrDefault();

                    var listChiTiet = db.CHITIETHOADONs.Where(p => p.HOADONID == hd.ID).ToList();
                    CHITIETHOADON chitiet;
                    chitiet = listChiTiet.Where(p => p.MATHANGID == mathang.ID).FirstOrDefault();

                    if (chitiet == null)
                    {
                        /// Nếu sản phẩm này chưa từng được thêm vào hóa đơn
                        chitiet = new CHITIETHOADON();
                        chitiet.HOADONID = hd.ID;
                        chitiet.SOLUONG = SoLuongGM;
                        chitiet.MATHANGID = mathang.ID;
                        chitiet.DONGIA = mathang.GIABAN;
                        chitiet.THANHTIEN = chitiet.DONGIA * chitiet.SOLUONG;
                        db.CHITIETHOADONs.Add(chitiet);

                        hd.TONGTIEN += chitiet.THANHTIEN;

                        db.SaveChanges();
                    }
                    else
                    {
                        /// Nếu sản phẩm này đã từng được thêm thì tăng số lượng
                        chitiet.SOLUONG += SoLuongGM;
                        chitiet.THANHTIEN = SoLuongGM * chitiet.DONGIA;
                        hd.TONGTIEN += chitiet.THANHTIEN;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                UpdateDsBanAn();
                UpdateDetail(IDBanAn);
            }
            
        }

        private void btnTraMon_Click(object sender, EventArgs e)
        {
            if (IDBanAn == 0)
            {
                MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra xem bàn ăn là bàn đã có khách hay chưa có khách
            BANAN banan = db.BANANs.Where(p => p.ID == IDBanAn).FirstOrDefault();
            if (banan.HOADONID == null)
            {
                MessageBox.Show("Bàn ăn không có khách",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra món ăn đang lựa chọn
            HOADON hd = db.HOADONs.Where(p => p.ID == banan.HOADONID).FirstOrDefault();

            int idChiTiet;
            try
            {
                idChiTiet = (int)dgvHoaDon.GetFocusedRowCellValue("ID");  
            }
            catch
            {
                MessageBox.Show("Chưa có mặt hàng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CHITIETHOADON chitiet = db.CHITIETHOADONs.Where(p => p.ID == idChiTiet).FirstOrDefault();

            int SoLuong = (int) chitiet.SOLUONG;
            int SoLuongTraMon = (int)txtTMSoLuong.Value;

            if (SoLuongTraMon > SoLuong)
            {
                MessageBox.Show("Số lượng trả món phải nhỏ hơn số lượng đã gọi",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            chitiet.SOLUONG -= SoLuongTraMon;
            

            try
            {
                hd.TONGTIEN -= SoLuongTraMon * chitiet.DONGIA;

                KHO kho = db.KHOes.Where(p => p.MATHANGID == chitiet.MATHANGID).FirstOrDefault();
                kho.SOLUONG += SoLuongTraMon;

                if (chitiet.SOLUONG == 0) db.CHITIETHOADONs.Remove(chitiet);

                db.SaveChanges();

                int cnt = db.CHITIETHOADONs.Where(p => p.HOADONID == hd.ID).ToList().Count;
                if (cnt == 0)
                { 
                    db.HOADONs.Remove(hd);
                    db.SaveChanges();
                    banan.HOADONID = null;
                    banan.TRANGTHAI = 0;

                    db.SaveChanges();
                    UpdateDsBanAn();
                }

                MessageBox.Show("Trả món thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Trả món thất bại",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                UpdateDetail(IDBanAn);
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (IDBanAn == 0)
            {
                MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra xem bàn ăn là bàn đã có khách hay chưa có khách
            BANAN banan = db.BANANs.Where(p => p.ID == IDBanAn).FirstOrDefault();
            if (banan.HOADONID == null)
            {
                MessageBox.Show("Bàn ăn không có khách",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int idBanAnMoi = (int)cbxCBBanAn.EditValue;
            BANAN bananmoi = db.BANANs.Where(p => p.ID == idBanAnMoi).FirstOrDefault();

            bananmoi.TRANGTHAI = 1;
            bananmoi.HOADONID = banan.HOADONID;
            banan.TRANGTHAI = 0;
            banan.HOADONID = null;

            try
            {
                db.SaveChanges();
                IDBanAn = idBanAnMoi;
                UpdateDetail(idBanAnMoi);

                UpdateDsBanAn();

                MessageBox.Show("Chuyển bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Chuyển bản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Sự kiện ngầm
        private void cbxKhuVuc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDsBanAn();
        }

        private void cbxLoaiMatHang_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonAn();
        }
        #endregion
    }
}
