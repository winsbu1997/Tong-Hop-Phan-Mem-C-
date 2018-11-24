using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.GUI
{
    public partial class FrmNhapHang : Form
    {
        private List<int> ListXoaChiTietNhap = new List<int>();
        private List<int> ListXoaHoaDonNhap = new List<int>();
        public FrmNhapHang()
        {
            InitializeComponent();
        }

        #region  LoadForm

        private void LoadHoaDonNhap()
        {
            // data source cho combobox
            cbxNhanVien.DataSource = DAO.NhanVienDAO.DanhSachNhanVien();
            cbxNhanVien.DisplayMember = "TENNV";
            cbxNhanVien.ValueMember = "MANV";

            // chinh lai thuoc tinh cua date edit
            dateNgayNhap.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateNgayNhap.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Load GridControl
            dgvHoaDonNhapMain.DataSource = DAO.HoaDonNhapDAO.DanhSachHoaDon();

            // chinh lai columnedit cua cot nhan vien nhap
            RepositoryItemLookUpEdit riNV = new RepositoryItemLookUpEdit();
            riNV.DataSource = DAO.NhanVienDAO.DanhSachNhanVien();
            riNV.ValueMember = "MANV";
            riNV.DisplayMember = "TENNV";
            dgvHoaDonNhap.Columns["MANV"].ColumnEdit = riNV;

            RepositoryItemDateEdit riNgayNhap = new RepositoryItemDateEdit();
            riNgayNhap.Properties.Mask.EditMask = "dd/MM/yyyy";
            riNgayNhap.Properties.Mask.UseMaskAsDisplayFormat = true;
            dgvHoaDonNhap.Columns["NGAY"].ColumnEdit = riNgayNhap;

            /// databinding Hoa don nhap
            txtMaPhieuNhap.DataBindings.Add(new Binding("Text", dgvHoaDonNhapMain.DataSource, "MAHDN", true, DataSourceUpdateMode.OnPropertyChanged));
            cbxNhanVien.DataBindings.Add(new Binding("SelectedValue", dgvHoaDonNhapMain.DataSource, "MANV", true, DataSourceUpdateMode.OnPropertyChanged));
            dateNgayNhap.DataBindings.Add(new Binding("DateTime", dgvHoaDonNhapMain.DataSource, "NGAY", true, DataSourceUpdateMode.OnPropertyChanged));
            txtNoiNhap.DataBindings.Add(new Binding("Text", dgvHoaDonNhapMain.DataSource, "NOINHAP", true, DataSourceUpdateMode.OnPropertyChanged));
            txtTongTien.DataBindings.Add(new Binding("Text", dgvHoaDonNhapMain.DataSource, "TONGTIEN", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void LoadChiTietNhap()
        {
            /// them datasource
            dgvChiTietNhapMain.DataSource = DAO.ChiTietNhapDAO.DanhSachChiTietNhap();

            /// chinh cot MaMH
            RepositoryItemLookUpEdit riMaMH = new RepositoryItemLookUpEdit();
            riMaMH.DataSource = DAO.MatHangDAO.DanhSachMatHang();
            riMaMH.ValueMember = "MAMH";
            riMaMH.DisplayMember = "TENMH";
            dgvChiTietNhap.Columns["MAMH"].ColumnEdit = riMaMH;

            /// combobox
            cbxMatHang.DataSource = DAO.MatHangDAO.DanhSachMatHang();
            cbxMatHang.DisplayMember = "TENMH";
            cbxMatHang.ValueMember = "MAMH";

            cbxDonViTinh.DataSource = DAO.MatHangDAO.DanhSachMatHang();
            cbxDonViTinh.DisplayMember = "DVTINH";
            cbxDonViTinh.ValueMember = "MAMH";
            cbxDonViTinh.DataBindings.Add("SelectedValue", cbxMatHang, "SelectedValue", true, DataSourceUpdateMode.OnPropertyChanged);
            
            /// databinding Chi Tiet Nhap
             

            txtMaChiTietNhap.DataBindings.Add("Text", dgvChiTietNhapMain.DataSource, "MACTN", true, DataSourceUpdateMode.OnPropertyChanged);
            cbxMatHang.DataBindings.Add("SelectedValue", dgvChiTietNhapMain.DataSource, "MAMH", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSoLuong.DataBindings.Add("Text", dgvChiTietNhapMain.DataSource, "SOLUONG", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDonGia.DataBindings.Add("Text", dgvChiTietNhapMain.DataSource, "DONGIA", true, DataSourceUpdateMode.OnPropertyChanged);
            txtThanhTien.DataBindings.Add("Text", dgvChiTietNhapMain.DataSource, "THANHTIEN", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            LoadHoaDonNhap();
            LoadChiTietNhap();
            UpdateGridChiTietNhap();
        }
        #endregion 

        #region Cập nhật
        private void TinhLaiTongTien()
        {
            int tongtien = 0;
            for (int i = 0; i < dgvChiTietNhap.RowCount; i++)
            {
                try
                {
                    int thanhtien = (int)dgvChiTietNhap.GetRowCellValue(i, "THANHTIEN");
                    tongtien += thanhtien;
                }
                catch
                {

                }
            }
            txtTongTien.Text = tongtien.ToString();
        }

        private void UpdateGridChiTietNhap()
        {
            string ma = txtMaPhieuNhap.Text;
            //if (index != null) ma = index.Row.ItemArray[0].ToString();
            if (ma == "") ma = "0";

            dgvChiTietNhap.ActiveFilterString = "[MAHDN]= '" + ma + "'";
            TinhLaiTongTien(); 
        }

        #endregion

        #region hàm chức năng

        private void TinhLaiThanhTien()
        {
            try
            {
                decimal SoLuong = txtSoLuong.Value;
                decimal DonGia = txtDonGia.Value;
                txtThanhTien.Text = (SoLuong * DonGia).ToString();
            }
            catch
            {

            }
            
            int index = dgvChiTietNhap.GetFocusedDataSourceRowIndex();
            dgvChiTietNhap.LoadRow(index);
            TinhLaiTongTien();
            //dgvChiTietNhap.FocusedRowHandle = dgvChiTietNhap.GetVisibleRowHandle(0);
            //dgvChiTietNhap.FocusedRowHandle = dgvChiTietNhap.GetVisibleRowHandle(index); 
        }

        #endregion

        #region Sự kiện ngầm

        private void dgvChiTietNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TinhLaiThanhTien();
            TinhLaiTongTien();
        }

        private void txtDonGia_ValueChanged(object sender, EventArgs e)
        {
            TinhLaiThanhTien();
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhLaiThanhTien();
        }

        private void dgvHoaDonNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateGridChiTietNhap();
        }
        #endregion

        #region sự kiện hóa đơn nhập
        private void btnXoaHDN_Click(object sender, EventArgs e)
        {
            if (btnXoaHDN.Text == "Xóa phiếu nhập")
            {
                int ma = 0;
                try
                {
                    ma = (int)dgvHoaDonNhap.GetFocusedRowCellValue("MAHDN");
                    if (ma > 0) ListXoaHoaDonNhap.Add(ma);
                }
                catch { }
                dgvHoaDonNhap.DeleteSelectedRows();
                TinhLaiTongTien();
                UpdateGridChiTietNhap();
                return;
            }

            if (btnXoaHDN.Text == "Hủy")
            {
                dgvHoaDonNhap.DeleteSelectedRows();

                btnThemHDN.Text = "Thêm phiếu nhập";
                dgvHoaDonNhapMain.Enabled = true;
                btnCapNhatHoaDonNhap.Enabled = true;
                btnThemChiTietNhap.Enabled = true;
                btnLuuDanhSachChiTietNhap.Enabled = true;
                btnXoaChiTietNhap.Enabled = true;
                btnXoaHDN.Text = "Xóa phiếu nhập";
            }
        }
        private void btnCapNhatHoaDonNhap_Click(object sender, EventArgs e)
        {
            /// cập nhật lại Gridcontrol Hóa đơn nhập
            for (int i = 0; i < dgvHoaDonNhap.RowCount; i++)
            {
                int MaHDN = (int) dgvHoaDonNhap.GetRowCellValue(i, "MAHDN");
                DateTime Ngay = (DateTime)dgvHoaDonNhap.GetRowCellValue(i, "NGAY");
                int TongTien = (int)dgvHoaDonNhap.GetRowCellValue(i, "TONGTIEN");
                int MaNV = (int)dgvHoaDonNhap.GetRowCellValue(i, "MANV");
                string NoiNhap = (string)dgvHoaDonNhap.GetRowCellValue(i, "NOINHAP");

                if (MaHDN > 0) DAO.HoaDonNhapDAO.CapNhatHoaDonNhap(MaHDN, MaNV, Ngay, TongTien, NoiNhap);
                else
                {
                    MaHDN = DAO.HoaDonNhapDAO.ThemHoaDonNhap(MaNV, Ngay, TongTien, NoiNhap);
                    dgvHoaDonNhap.SetRowCellValue(i, "MAHDN", MaHDN);
                }
            }
            /// xoa danh sach cac hoa don duoc nguoi dung bam nut xoa
            foreach(int ma in ListXoaHoaDonNhap) DAO.HoaDonNhapDAO.XoaHoaDonNhap(ma);
            ListXoaHoaDonNhap.Clear();

            MessageBox.Show("Cập nhật thông tin danh sách phiếu nhập thành công");
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            if (btnThemHDN.Text == "Thêm phiếu nhập")
            {
                btnThemHDN.Text = "Hoàn thành";
                
                btnCapNhatHoaDonNhap.Enabled = false;
                btnThemChiTietNhap.Enabled = false;
                btnLuuDanhSachChiTietNhap.Enabled = false;
                btnXoaChiTietNhap.Enabled = false;

                btnXoaHDN.Text = "Hủy";
                dgvHoaDonNhap.AddNewRow();

                int index = dgvHoaDonNhap.RowCount - 1;
                dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(0);
                dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(index);
                dgvHoaDonNhapMain.Enabled = false;

                dateNgayNhap.DateTime = DateTime.Now;
                cbxNhanVien.SelectedIndex = 0;

                return;
            }

            if (btnThemHDN.Text == "Hoàn thành")
            {
                // THÊM LUÔN VÀO CSDL
                int index = dgvHoaDonNhap.RowCount - 1;
                int MaHDN;
                DateTime Ngay = dateNgayNhap.DateTime;
                int TongTien = 0;
                int MaNV = (int) cbxNhanVien.SelectedValue;
                string NoiNhap = txtNoiNhap.Text;

                MaHDN = DAO.HoaDonNhapDAO.ThemHoaDonNhap(MaNV, Ngay, TongTien, NoiNhap);
                dgvHoaDonNhap.SetRowCellValue(index, "MAHDN", MaHDN);

                /// THÊM THÀNH CÔNG, TRẢ LẠI TRẠNG THÁI CHO FORM
                btnThemHDN.Text = "Thêm phiếu nhập";
                dgvHoaDonNhapMain.Enabled = true;
                btnCapNhatHoaDonNhap.Enabled = true;
                btnThemChiTietNhap.Enabled = true;
                btnLuuDanhSachChiTietNhap.Enabled = true;
                btnXoaChiTietNhap.Enabled = true;
                btnXoaHDN.Text = "Xóa phiếu nhập";

                index = dgvHoaDonNhap.RowCount - 1;
                dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(0);
                dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(index);
                return;
            }
        }
        #endregion

        #region sự kiện chi tiết nhập
        private void btnXoaChiTietNhap_Click(object sender, EventArgs e)
        {
            if (btnXoaChiTietNhap.Text == "Xóa chi tiết nhập")
            {
                int ma;
                try
                {
                    ma = (int)dgvChiTietNhap.GetFocusedRowCellValue("MACTN");
                }
                catch
                {
                    ma = 0;
                }
                if (ma > 0) ListXoaChiTietNhap.Add(ma);
                dgvChiTietNhap.DeleteSelectedRows();
                TinhLaiTongTien();
                return;
            }

            if (btnXoaChiTietNhap.Text == "Hủy")
            {
                btnThemChiTietNhap.Text = "Thêm chi tiết nhập";
                btnLuuDanhSachChiTietNhap.Enabled = true;
                dgvChiTietNhapMain.Enabled = true;
                btnXoaChiTietNhap.Text = "Xóa chi tiết nhập";

                btnCapNhatHoaDonNhap.Enabled = true;
                btnThemHDN.Enabled = true;
                btnXoaHDN.Enabled = true;
                dgvHoaDonNhapMain.Enabled = true;

                dgvChiTietNhap.DeleteSelectedRows();
                TinhLaiTongTien();
            }
        }

        private void btnLuuDanhSachChiTietNhap_Click(object sender, EventArgs e)
        {
            /// luu bang chi tiet nhap
            for (int i = 0; i < dgvChiTietNhap.RowCount; i++)
            {
                int MaHDN, MaCTN, MaMH, SoLuong, DonGia, ThanhTien;

                MaHDN = (int)dgvChiTietNhap.GetRowCellValue(i, "MAHDN");
                MaCTN = (int)dgvChiTietNhap.GetRowCellValue(i, "MACTN");
                MaMH = (int)dgvChiTietNhap.GetRowCellValue(i, "MAMH");
                SoLuong = (int)dgvChiTietNhap.GetRowCellValue(i, "SOLUONG");
                DonGia = (int)dgvChiTietNhap.GetRowCellValue(i, "DONGIA");
                ThanhTien = (int)dgvChiTietNhap.GetRowCellValue(i, "THANHTIEN");

                if (MaCTN > 0) DAO.ChiTietNhapDAO.CapNhatChiTietNhap(MaCTN, MaHDN, MaMH, SoLuong, DonGia, ThanhTien);
                else
                {
                    MaCTN = DAO.ChiTietNhapDAO.ThemChiTietNhap(MaHDN, MaMH, SoLuong, DonGia, ThanhTien);
                    dgvChiTietNhap.SetRowCellValue(i, "MACTN", MaCTN);
                }
            }
            // xoa di danh sach cac chi tiet nhap nguoi dung xoa
            foreach (int ma in ListXoaChiTietNhap) DAO.ChiTietNhapDAO.XoaChiTietNhap(ma);
            ListXoaChiTietNhap.Clear();

            // cap nhat lai row vua sua
            int index = dgvChiTietNhap.GetFocusedDataSourceRowIndex();
            dgvChiTietNhap.FocusedRowHandle = dgvChiTietNhap.GetVisibleRowHandle(0);
            dgvChiTietNhap.FocusedRowHandle = dgvChiTietNhap.GetVisibleRowHandle(index);

            MessageBox.Show("Lưu thông tin chi tiết nhập thành công");
        }

        private void btnThemChiTietNhap_Click(object sender, EventArgs e)
        {
            if (btnThemChiTietNhap.Text == "Thêm chi tiết nhập")
            {
                btnThemChiTietNhap.Text = "Hoàn thành";
                btnLuuDanhSachChiTietNhap.Enabled = false;
                dgvChiTietNhapMain.Enabled = false;
                btnXoaChiTietNhap.Text = "Hủy";

                btnCapNhatHoaDonNhap.Enabled = false;
                btnThemHDN.Enabled = false;
                btnXoaHDN.Enabled = false;
                dgvHoaDonNhapMain.Enabled = false;

                dgvChiTietNhap.AddNewRow();
                return;
            }

            if (btnThemChiTietNhap.Text == "Hoàn thành")
            {

                /// thêm thành công
                btnThemChiTietNhap.Text = "Thêm chi tiết nhập";
                btnLuuDanhSachChiTietNhap.Enabled = true;
                dgvChiTietNhapMain.Enabled = true;
                btnXoaChiTietNhap.Text = "Xóa chi tiết nhập";

                btnCapNhatHoaDonNhap.Enabled = true;
                btnThemHDN.Enabled = true;
                btnXoaHDN.Enabled = true;
                dgvHoaDonNhapMain.Enabled = true;

                int index = dgvChiTietNhap.GetFocusedDataSourceRowIndex();
                dgvChiTietNhap.FocusedRowHandle = dgvChiTietNhap.GetVisibleRowHandle(0);
                dgvChiTietNhap.FocusedRowHandle = dgvChiTietNhap.GetVisibleRowHandle(index);
                return;
            }
        }
        #endregion      

        #region sự kiện trước khi thêm 1 chi tiết nhập hoặc hóa đơn nhập
        private void dgvChiTietNhap_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "MAHDN", Int32.Parse(txtMaPhieuNhap.Text));
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "MACTN", 0);
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "MAMH", 1);
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "SOLUONG", 0);
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "DONGIA", 0);
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "THANHTIEN", 0);
        }

        private void dgvHoaDonNhap_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateGridChiTietNhap();
        }

        private void dgvHoaDonNhap_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //int ma = DAO.HoaDonNhapDAO.ThemHoaDonNhap(1, DateTime.Now, 0, "");
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "MAHDN", 0);
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "MANV", 1);
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "NGAY", DateTime.Now);
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "NOINHAP", "");
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "TONGTIEN", 0);
        }
        #endregion

       


    }
}
