using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace QuanLiNhaHang.GUI
{
    public partial class QuanLiNhapHang : UserControl
    {
        public static QuanLiNhapHang uct_NH = new QuanLiNhapHang();
        public QuanLiNhapHang()
        {
            InitializeComponent();
        }
        #region Properties
        int flag = 0;        
        List<string> deleteHDN = new List<string>();
        List<string> deleteCTN = new List<string>();
        #endregion



        #region Method
        #region LoadUserControl
        private void BindingCTNClear()
        {
            cbxTenNguyenLieu.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtThanhTien.DataBindings.Clear();
        }
        private void BindingHDN()
        {
            cbxTenNhanVien.DataBindings.Add("selectedValue", dgvHoaDonNhapMain.DataSource, "MaNV", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMaHDN.DataBindings.Add("Text", dgvHoaDonNhapMain.DataSource, "MaHDN", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNgayNhap.DataBindings.Add("Text", dgvHoaDonNhapMain.DataSource, "NgayNhap", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGhiChu.DataBindings.Add("Text", dgvHoaDonNhapMain.DataSource, "GhiChu", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTongTien.DataBindings.Add("Text", dgvHoaDonNhapMain.DataSource, "TongTien", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void BindingCTN()
        {
            cbxTenNguyenLieu.DataBindings.Add("selectedValue", dgvChiTietNhapMain.DataSource, "MaNL", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSoLuong.DataBindings.Add("Text", dgvChiTietNhapMain.DataSource, "SoLuong", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDonGia.DataBindings.Add("Text", dgvChiTietNhapMain.DataSource, "DonGia", true, DataSourceUpdateMode.OnPropertyChanged);
            txtThanhTien.DataBindings.Add("Text", dgvChiTietNhapMain.DataSource, "ThanhTien", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void LoadHoaDonNhap()
        {
            Dis_End(true);
            dgvHoaDonNhapMain.DataSource = Model.HoaDonNhapMod.FillDataSetHoaDonNhap().Tables[0];
            RepositoryItemLookUpEdit riMaNV = new RepositoryItemLookUpEdit();
            riMaNV.DataSource = Model.NhanVienMod.FillDataSetNhanVien().Tables[0];
            riMaNV.ValueMember = "MaNV";
            riMaNV.DisplayMember = "TenNV";
            dgvHoaDonNhap.Columns["MaNV"].ColumnEdit = riMaNV;

            // combobox
            cbxTenNhanVien.DataSource = Model.NhanVienMod.FillDataSetNhanVien().Tables[0];
            cbxTenNhanVien.ValueMember = "MaNV";
            cbxTenNhanVien.DisplayMember = "TenNV";           
        }
        private void LoadChiTietNhap()
        {
            // chinh cot MaNL
            Dis_EndChiTiet(true);
            DataTable dt = new DataTable();
            dt = Model.ChiTietNhapMod.FillDataSetChiTietNhap().Tables[0];
            dt.Columns.Add("ThanhTien");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["ThanhTien"] = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString()) * Convert.ToInt32(dt.Rows[i]["DonGia"].ToString());
            }
            dgvChiTietNhapMain.DataSource = dt;
            RepositoryItemLookUpEdit riMaNL = new RepositoryItemLookUpEdit();
            riMaNL.DataSource = Model.NguyenLieuMod.FillDataSetNguyenLieu().Tables[0];
            riMaNL.ValueMember = "MaNL";
            riMaNL.DisplayMember = "TenNL";
            dgvChiTietNhap.Columns["MaNL"].ColumnEdit = riMaNL;

            // combobox
            cbxTenNguyenLieu.DataSource = Model.NguyenLieuMod.FillDataSetNguyenLieu().Tables[0];
            cbxTenNguyenLieu.ValueMember = "MaNL";
            cbxTenNguyenLieu.DisplayMember = "TenNL";

            cbxDVTinh.DataSource = Model.NguyenLieuMod.FillDataSetNguyenLieu().Tables[0];
            cbxDVTinh.ValueMember = "MaNL";
            cbxDVTinh.DisplayMember = "DonViTinh";

            // gia
            txtDonGia.Value = Convert.ToInt32(Model.Connection.docGiaTri("SELECT DonGia FROM dbo.NguyenLieu WHERE MaNL = '" + cbxTenNguyenLieu.SelectedValue + "'"));         

        }
        private void QuanLiNhapHang_Load(object sender, EventArgs e)
        {
            dgvChiTietNhap.Columns[0].OptionsColumn.AllowEdit = false;
            dgvHoaDonNhap.Columns[0].OptionsColumn.AllowEdit = false;
            dgvHoaDonNhap.Columns[4].OptionsColumn.AllowEdit = false;
            dgvChiTietNhap.Columns[3].OptionsColumn.AllowEdit = false;
            LoadChiTietNhap();
            LoadHoaDonNhap();
            BindingCTN();
            BindingHDN();
            UpdateDataChiTietNhap();
            TinhLaiTongTien();
        }

        #endregion
        private void clearData(int a)
        {
            if (a == 0)
            {
                txtMaHDN.Text = "";
                dtpNgayNhap.Text = DateTime.Now.ToString();
                cbxTenNhanVien.SelectedIndex = 0;
                txtGhiChu.Text = "";
                txtTongTien.Text = "";
            }
            else
            {
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
                txtThanhTien.Text = "";
            }
        }
        private void Dis_End(bool e)
        {
            dgvHoaDonNhapMain.Enabled = e;
            btnThem.Enabled = e;
            btnXoa.Enabled = e;
            btnCapNhat.Enabled = e;
            btnChapNhan.Enabled = !e;
            btnHuy.Enabled = !e;
        }
        private void Dis_EndChiTiet(bool e)
        {
            dgvHoaDonNhapMain.Enabled = e;
            dgvChiTietNhapMain.Enabled = e;
            btnThemChiTiet.Enabled = e;
            btnLuuChiTiet.Enabled = !e;
            btnXoaChiTiet.Enabled = e;
            btnSuaChiTiet.Enabled = e;
            btnHuyChiTiet.Enabled = !e;
        }
        private void UpdateDataChiTietNhap()
        {
            dgvChiTietNhap.ActiveFilterString = "[MaHDN]= '" + txtMaHDN.Text + "'";
        }
        private void TinhLaiTongTien()
        {
            int TongTien = 0;
            for (int i = 0; i < dgvChiTietNhap.RowCount; i++)
            {
                try
                {
                    TongTien += Convert.ToInt32(dgvChiTietNhap.GetRowCellValue(i, "ThanhTien"));
                }
                catch { }
            }
            txtTongTien.Text = TongTien.ToString();
        }
        private void TinhLaiThanhTien()
        {
            try
            {
                decimal SoLuong = txtSoLuong.Value;
                decimal DonGia = txtDonGia.Value;
                txtThanhTien.Text = (SoLuong * DonGia).ToString();
            }
            catch { }

            int index = dgvChiTietNhap.GetFocusedDataSourceRowIndex();
            dgvChiTietNhap.LoadRow(index);
            TinhLaiTongTien();
        }
        #endregion

        #region Events
        #region HoaDonNhap
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_End(false);
            dgvHoaDonNhap.AddNewRow();

        }
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (dtpNgayNhap.Text == "")
                {
                    MessageBox.Show(" Ngay Nhap không được để trống ", " Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // them thanh cong
            }
            else
            {
                string _MaHDN = (string)dgvHoaDonNhap.GetFocusedRowCellValue("MaHDN");
                if (_MaHDN != "") deleteHDN.Add(_MaHDN);
                dgvHoaDonNhap.DeleteSelectedRows();
            }
            Dis_End(true);
            TinhLaiTongTien();
            UpdateDataChiTietNhap();
            int index = dgvHoaDonNhap.GetFocusedDataSourceRowIndex() - 1;
            dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(0);
            dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(index);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                dgvHoaDonNhap.DeleteSelectedRows();
            }
            Dis_End(true);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_End(false);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvHoaDonNhap.RowCount; i++)
            {
                string _MaHDN = (string)dgvHoaDonNhap.GetRowCellValue(i, "MaHDN");
                DateTime _NgayNhap = (DateTime)dgvHoaDonNhap.GetRowCellValue(i, "NgayNhap");
                string _MaNV = (string)dgvHoaDonNhap.GetRowCellValue(i, "MaNV");
                string _GhiChu = (string)dgvHoaDonNhap.GetRowCellValue(i, "GhiChu");
                int _TongTien = (int)dgvHoaDonNhap.GetRowCellValue(i, "TongTien");

                if (_MaHDN == "")
                {
                    _MaHDN = Model.Connection.ExcuteScalar(string.Format("Select MaHDN = dbo.fcgetHoaDonNhap()"));
                    dgvHoaDonNhap.SetRowCellValue(i, "MaHDN", _MaHDN);
                    Controller.HoaDonNhapCtr.InsertHoaDonNhap(_MaHDN, _NgayNhap, _TongTien, _GhiChu, _MaNV);
                }
                else
                {
                    Controller.HoaDonNhapCtr.UpdateHoaDonNhap(_MaHDN, _NgayNhap, _TongTien, _GhiChu, _MaNV);
                }
            }
            foreach (string del in deleteHDN)
            {
                Controller.HoaDonNhapCtr.DeleteHoaDonNhap(del);
            }
            deleteHDN.Clear();
            // cap nhap lai grip control
            int index = dgvHoaDonNhap.GetFocusedDataSourceRowIndex();
            dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(0);
            dgvHoaDonNhap.FocusedRowHandle = dgvHoaDonNhap.GetVisibleRowHandle(index);
            MessageBox.Show("Cập Nhập Thành Công Hóa Đơn Nhập !");
        }

        #endregion

        #region ChiTietNhap
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData(1);
            Dis_EndChiTiet(false);
            dgvChiTietNhap.AddNewRow();
        }
        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            string _MaHDN = "";
            try
            {
                _MaHDN = txtMaHDN.Text;
            }
            catch { }
            string _MaNL = "";
            try
            {
                _MaNL = cbxTenNguyenLieu.SelectedValue.ToString();
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controller.ChiTietNhapCtr.DeleteChiTietNhap(_MaHDN,_MaNL);
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");
                    Dis_EndChiTiet(true);
                    LoadChiTietNhap();
                    BindingCTNClear();
                    BindingCTN();
                    TinhLaiTongTien();
                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
        }
        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_EndChiTiet(false);
        }
        private void btnHuyChiTiet_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                dgvChiTietNhap.DeleteSelectedRows();
            }
            Dis_EndChiTiet(true);
        }
        private void btnLuuChiTiet_Click(object sender, EventArgs e)
        {
            string _MaHDN = "";
            try
            {
                _MaHDN = txtMaHDN.Text;
            }
            catch { }
            string _MaNL = "";
            try
            {
                _MaNL = cbxTenNguyenLieu.SelectedValue.ToString();
            }
            catch { }
            int _DonGia = 0;
            try
            {
                _DonGia = (int)txtDonGia.Value;
            }
            catch { }
            int _SoLuong = 0;
            try
            {
                _SoLuong = (int)txtSoLuong.Value;
            }
            catch { }
            if(flag == 0)
            {
                int i = 0;
                i = Controller.ChiTietNhapCtr.InsertChiTietNhap(_MaHDN, _MaNL, _SoLuong, _DonGia);
                if (i > 0)
                {
                    MessageBox.Show("Thêm Chi tiết nhập thành công");
                    LoadChiTietNhap();
                    BindingCTNClear();
                    BindingCTN();
                    TinhLaiTongTien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                int i = 0;
                i = Controller.ChiTietNhapCtr.UpdateChiTietNhap(_MaHDN, _MaNL, _SoLuong, _DonGia);
                if (i > 0)
                {
                    MessageBox.Show("update  thành công");
                    TinhLaiTongTien();
                }
                else
                {
                    MessageBox.Show("update thất bại");
                }
            }
            Dis_EndChiTiet(true);
            // thay doi gia tri trong cot tong tien cua HoaDonNhap
            int index = dgvHoaDonNhap.GetFocusedDataSourceRowIndex();
            dgvHoaDonNhap.SetRowCellValue(index, "TongTien", txtTongTien.Text);
        }     
        #endregion

        #endregion
        #region EventsPhatSinh
        private void dgvChiTietNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TinhLaiThanhTien();
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhLaiThanhTien();
        }

        private void dgvHoaDonNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDataChiTietNhap();
        }

        private void dgvHoaDonNhap_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateDataChiTietNhap();
        }

        private void dgvHoaDonNhap_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            clearData(0);
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "MaHDN", "");
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "MaNV", cbxTenNhanVien.SelectedIndex);
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "NgayNhap", dtpNgayNhap.Text);
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "GhiChu", "Không");
            dgvHoaDonNhap.SetRowCellValue(e.RowHandle, "TongTien", 0);
        }

        private void dgvChiTietNhap_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "MaNL", cbxTenNhanVien.SelectedIndex);
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "SoLuong", txtSoLuong.Value);
            dgvChiTietNhap.SetRowCellValue(e.RowHandle, "DonGia", txtDonGia.Value);
        }

        private void cbxTenNguyenLieu_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDonGia.Value = Convert.ToInt32(Model.Connection.docGiaTri("SELECT DonGia FROM dbo.NguyenLieu WHERE MaNL = '" + cbxTenNguyenLieu.SelectedValue + "'"));
        }
        #endregion


    }
}
