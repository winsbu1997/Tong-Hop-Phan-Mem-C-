using DevExpress.XtraEditors;
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
    public partial class FrmQuanLyMatHang : Form
    {
        private List<int> ListXoaMH = new List<int>();
        public FrmQuanLyMatHang()
        {
            InitializeComponent();
        }

        #region Load Form
        private void FrmQuanLyMatHang_Load(object sender, EventArgs e)
        {
            /// them datasource
            dgvMatHangMain.DataSource = DAO.MatHangDAO.DanhSachMatHang();

            /// them binding
            txtMaMH.DataBindings.Add(new Binding("Text", dgvMatHangMain.DataSource, "MAMH", true, DataSourceUpdateMode.OnPropertyChanged));
            txtDonGia.DataBindings.Add(new Binding("Value", dgvMatHangMain.DataSource, "DONGIA", true, DataSourceUpdateMode.OnPropertyChanged));
            txtDonViTinh.DataBindings.Add(new Binding("Text", dgvMatHangMain.DataSource, "DVTINH", true, DataSourceUpdateMode.OnPropertyChanged));
            txtTen.DataBindings.Add(new Binding("Text", dgvMatHangMain.DataSource, "TENMH", true, DataSourceUpdateMode.OnPropertyChanged));
            imgHinhAnh.DataBindings.Add(new Binding("Image", dgvMatHangMain.DataSource, "HINHANH", true, DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion

        #region Sự kiện Thêm, Lưu, Xóa ảnh
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string FileName = file.FileName.ToString();
            
            try {
                imgHinhAnh.Image = Image.FromFile(FileName); 
            }
            catch
            {
                MessageBox.Show("Load ảnh lỗi");
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            /// button xóa ảnh
            imgHinhAnh.Image = null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            /// button lưu ảnh
            SaveFileDialog file = new SaveFileDialog();
            file.ShowDialog();
            string FileName = file.FileName.ToString();

            try
            {
                imgHinhAnh.Image.Save(FileName);
                MessageBox.Show("Lưu ảnh thành công");
            }
            catch
            {
                MessageBox.Show("Lưu ảnh lỗi");
            }
        }
        #endregion

        #region sự kiện thêm sửa xóa CSDL
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;

            if (button.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";
                btnCapNhat.Enabled = true;
                dgvMatHang.DeleteSelectedRows();
                dgvMatHangMain.Enabled = true;
                return;
            }

            int MaMH = (int) dgvMatHang.GetFocusedRowCellValue("MAMH");
            if (MaMH > 0) ListXoaMH.Add(MaMH);
            dgvMatHang.DeleteSelectedRows();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                /// cap nhat lai cac mat hang dang trong datasource
                for (int i = 0; i < dgvMatHang.RowCount; i++)
                {
                    string TenMH = (string)dgvMatHang.GetRowCellValue(i, "TENMH");
                    string DVTinh = (string)dgvMatHang.GetRowCellValue(i, "DVTINH");
                    int DonGia = (int)dgvMatHang.GetRowCellValue(i, "DONGIA");

                    byte[] HinhAnh = null;
                    try
                    {
                        HinhAnh = (byte[])dgvMatHang.GetRowCellValue(i, "HINHANH");
                    }
                    catch { }

                    int MaMH = (int)dgvMatHang.GetRowCellValue(i, "MAMH");
                    if (MaMH > 0) DAO.MatHangDAO.CapNhatMatHang(MaMH, TenMH, DVTinh, DonGia, HinhAnh);
                    else
                    {
                        DAO.MatHangDAO.ThemMatHang(TenMH, DVTinh, DonGia, HinhAnh);
                        string query = "SELECT MAX(MAMH) FROM MATHANG";
                        MaMH = (int)DAO.SqlServerHelper.ExecuteScalar(query);
                        dgvMatHang.SetRowCellValue(i, "MAMH", MaMH);
                    }

                }
                /// xoa cac mat hang trong list xoa
                foreach (int ma in ListXoaMH) DAO.MatHangDAO.XoaMatHang(ma);
                ListXoaMH.Clear();
                /// cap nhat lai grid control
                int index = dgvMatHang.GetFocusedDataSourceRowIndex();
                dgvMatHang.FocusedRowHandle = dgvMatHang.GetVisibleRowHandle(0);
                dgvMatHang.FocusedRowHandle = dgvMatHang.GetVisibleRowHandle(index);
            }
            catch
            {

            }
            /// thong bao
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;

            if (button.Text == "Thêm")
            {
                btnThem.Text = "Hoàn thành";
                btnXoa.Text = "Hủy";
                btnCapNhat.Enabled = false;
                dgvMatHang.AddNewRow();
                dgvMatHang.FocusedRowHandle = dgvMatHang.GetVisibleRowHandle(dgvMatHang.RowCount);
                dgvMatHangMain.Enabled = false;

                return;
            }

            if (button.Text == "Hoàn thành")
            {
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Tên mặt hàng không được để trống");
                    return;
                }
                
                if (txtDonViTinh.Text == "")
                {
                    MessageBox.Show("Đơn vị tính không được để trống");
                    return;
                }

                /// thêm mặt hành thành công
                button.Text = "Thêm";
                btnXoa.Text = "Xóa";
                btnCapNhat.Enabled = true;
                dgvMatHangMain.Enabled = true;


                int index = dgvMatHang.GetFocusedDataSourceRowIndex();
                dgvMatHang.FocusedRowHandle = dgvMatHang.GetVisibleRowHandle(0);
                dgvMatHang.FocusedRowHandle = dgvMatHang.GetVisibleRowHandle(index);

                MessageBox.Show("Thêm mặt hàng thành công");
            }

        }
        #endregion

        #region sự kiện ngầm
        private void dgvMatHang_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dgvMatHang.SetRowCellValue(e.RowHandle, "MAMH", 0);
            dgvMatHang.SetRowCellValue(e.RowHandle, "TENMH", "");
            dgvMatHang.SetRowCellValue(e.RowHandle, "DVTINH", "");
            dgvMatHang.SetRowCellValue(e.RowHandle, "DONGIA", 0);
            dgvMatHang.SetRowCellValue(e.RowHandle, "HINHANH", null);
        }
        #endregion

    }
}
