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
    public partial class FrmQuanLyNhanVien : Form
    {
        private List<int> ListXoaNhanVien = new List<int>();
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        #region load form
        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // thêm data source vào cho grid control
            dgvNhanVienMain.DataSource = DAO.NhanVienDAO.DanhSachNhanVien();

            /// binding
            txtMaNV.DataBindings.Add(new Binding("Text", dgvNhanVienMain.DataSource, "MANV", true, DataSourceUpdateMode.OnPropertyChanged));
            txtTenNV.DataBindings.Add(new Binding("Text", dgvNhanVienMain.DataSource, "TENNV", true, DataSourceUpdateMode.OnPropertyChanged));
            cbxNamSinh.DataBindings.Add(new Binding("Text", dgvNhanVienMain.DataSource, "NAMSINH", true, DataSourceUpdateMode.OnPropertyChanged));
            cbxGioiTinh.DataBindings.Add(new Binding("Text", dgvNhanVienMain.DataSource, "GIOITINH", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNhanVienMain.DataSource, "SDT", true, DataSourceUpdateMode.OnPropertyChanged));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvNhanVienMain.DataSource, "DIACHI", true, DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion

       

        #region sự kiện
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            /// cập nhật lại danh sách các nhân viên
            for (int i = 0; i < dgvNhanVien.RowCount; i++)
            {
                int MANV = (int)dgvNhanVien.GetRowCellValue(i, "MANV");
                string GIOITINH = (string)dgvNhanVien.GetRowCellValue(i, "GIOITINH");
                int NAMSINH = (int)dgvNhanVien.GetRowCellValue(i, "NAMSINH");
                string SDT = (string)dgvNhanVien.GetRowCellValue(i, "SDT");
                string DIACHI = (string)dgvNhanVien.GetRowCellValue(i, "DIACHI");
                string TENNV = (string)dgvNhanVien.GetRowCellValue(i, "TENNV");

                if (MANV > 0) DAO.NhanVienDAO.CapNhatNhanVien(MANV, TENNV, GIOITINH, DIACHI, NAMSINH, SDT);
                else
                {
                    DAO.NhanVienDAO.ThemNhanVien(TENNV, GIOITINH, DIACHI, NAMSINH, SDT);
                    string query = "SELECT MAX(MANV) FROM NHANVIEN";
                    MANV = (int)DAO.SqlServerHelper.ExecuteScalar(query);
                    dgvNhanVien.SetRowCellValue(i, "MANV", MANV);
                }
            }

            /// xóa các nhân viên trong list xóa
            foreach (int ma in ListXoaNhanVien) DAO.NhanVienDAO.XoaNhanVien(ma);
            ListXoaNhanVien.Clear();
            /// Cập nhật lại grid control
            int index = dgvNhanVien.GetFocusedDataSourceRowIndex();
            dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(0);
            dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(index);

            MessageBox.Show("Cập nhật thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hoàn thành";
                btnCapNhat.Enabled = false;
                dgvNhanVienMain.Enabled = false;
                btnXoa.Text = "Hủy";

                dgvNhanVien.AddNewRow();
                return;
            }

            if (btnThem.Text == "Hoàn thành")
            {
                /// kiểm tra tên nhân viên
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show("Tên nhân viên không được để trống");
                    return;
                }

                /// kiểm tra sđt
                string sdt = txtSDT.Text;
                bool ok = true;
                for (int i = 0; i < sdt.Length; i++)
                    if (sdt[i]!=' ' && (sdt[i] < '0' || sdt[i] > '9')) ok = false;
                if (!ok)
                {
                    MessageBox.Show("SĐT phải là ký tự số");
                    return;
                }

                /// kiểm tra tên nhân viên
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Địa chỉ không được để trống");
                    return;
                }

                /// thêm thành công
                btnThem.Text = "Thêm";
                btnCapNhat.Enabled = true;
                dgvNhanVienMain.Enabled = true;
                btnXoa.Text = "Xóa";
                
                int index = dgvNhanVien.GetFocusedDataSourceRowIndex();
                dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(0);
                dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(index);

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                int ma = (int)dgvNhanVien.GetFocusedRowCellValue("MANV");
                if (ma > 0) ListXoaNhanVien.Add(ma);
                dgvNhanVien.DeleteSelectedRows();
                return;
            }

            if (btnXoa.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnCapNhat.Enabled = true;
                dgvNhanVienMain.Enabled = true;
                btnXoa.Text = "Xóa";
                dgvNhanVien.DeleteSelectedRows();
                return;
            }
        }

        #endregion 

        #region sự kiện ngầm
        private void dgvNhanVien_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dgvNhanVien.SetRowCellValue(e.RowHandle, "MANV", 0);
            dgvNhanVien.SetRowCellValue(e.RowHandle, "TENNV", "");
            dgvNhanVien.SetRowCellValue(e.RowHandle, "SDT", "");
            dgvNhanVien.SetRowCellValue(e.RowHandle, "GIOITINH", "Nam");
            dgvNhanVien.SetRowCellValue(e.RowHandle, "NAMSINH", 1996);
            dgvNhanVien.SetRowCellValue(e.RowHandle, "DIACHI", "");
        }
        #endregion 
    }
}
