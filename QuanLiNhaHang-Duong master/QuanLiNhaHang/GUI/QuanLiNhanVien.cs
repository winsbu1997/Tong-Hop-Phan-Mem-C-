using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.GUI
{
    public partial class QuanLiNhanVien : UserControl
    {
        int flag;
        private List<string> ListDeleteNhanVien = new List<string>();
        public QuanLiNhanVien()
        {
            InitializeComponent();
        }
        public static QuanLiNhanVien uct_nv = new GUI.QuanLiNhanVien();
        private void Binding()
        {
            txtMaNV.DataBindings.Add("Text", dgvNhanVienMain.DataSource, "MaNV", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenNV.DataBindings.Add("Text", dgvNhanVienMain.DataSource, "TenNV", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLuong.DataBindings.Add("Text", dgvNhanVienMain.DataSource, "Luong", true, DataSourceUpdateMode.OnPropertyChanged);
            txtChucVu.DataBindings.Add("Text", dgvNhanVienMain.DataSource, "ChucVu", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSdt.DataBindings.Add("Text", dgvNhanVienMain.DataSource, "Sdt", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Add("Text", dgvNhanVienMain.DataSource, "DiaChi", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNgaySinh.DataBindings.Add("Value", dgvNhanVienMain.DataSource, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbGioiTinh.DataBindings.Add("Text", dgvNhanVienMain.DataSource, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            txtTenNV.Text = "";
            dtpNgaySinh.Text = DateTime.Today.ToString();
            txtSdt.Text = "";
            txtChucVu.Text = "";
            LoadControl();
        }

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Columns[0].OptionsColumn.AllowEdit = false;
            txtMaNV.Enabled = false;
            dgvNhanVienMain.DataSource = Model.NhanVienMod.FillDataSetNhanVien().Tables[0];
            LoadControl();
            Binding();
            Dis_End(true);

        }
        private void LoadControl()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nu");
        }
        private void Dis_End(bool e)
        {
            btnCapNhat.Enabled = e;
            btnXoa.Enabled = e;
            btnThem.Enabled = e;

            btnChapNhan.Enabled = !e;
            btnThoat.Enabled = !e;
            dgvNhanVienMain.Enabled = e;
        }
  
        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_End(false);
            dgvNhanVien.AddNewRow();
            return;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_End(false);
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                dgvNhanVien.DeleteSelectedRows();
            }
            Dis_End(true);
        }
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show(" Tên Nhân Viên không được để trống ", " Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // them thanh cong
            }
            else
            {
                string _MaNV = (string)dgvNhanVien.GetFocusedRowCellValue("MaNV");
                if (_MaNV != "") ListDeleteNhanVien.Add(_MaNV);
                dgvNhanVien.DeleteSelectedRows();
            }
            Dis_End(true);
            int index = dgvNhanVien.GetFocusedDataSourceRowIndex();
            dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(0);
            dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(index);

            return;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNhanVien.RowCount; i++)
            {
                string _MaNV = (string)dgvNhanVien.GetRowCellValue(i,"MaNV");
                string _TenNV = (string)dgvNhanVien.GetRowCellValue(i, "TenNV");
                DateTime _NgaySinh = (DateTime)dgvNhanVien.GetRowCellValue(i,"NgaySinh");
                string _GioiTinh = (string)dgvNhanVien.GetRowCellValue(i, "GioiTinh");
                string _DiaChi = (string)dgvNhanVien.GetRowCellValue(i, "DiaChi");
                string _Sdt = (string)dgvNhanVien.GetRowCellValue(i, "Sdt");
                int _Luong = (int)dgvNhanVien.GetRowCellValue(i, "Luong");
                string _ChucVu = (string)dgvNhanVien.GetRowCellValue(i, "ChucVu");

                // them moi
                if (_MaNV == "")
                {
                    _MaNV = Model.Connection.ExcuteScalar(string.Format("select MaNV = dbo.fcgetIdNhanVien()"));
                    dgvNhanVien.SetRowCellValue(i,"MaNV",_MaNV);
                    Controller.NhanVienCtr.InsertNhanVien(_MaNV, _TenNV, _NgaySinh, _GioiTinh, _DiaChi, _Sdt, _Luong, _ChucVu);
                }
                // sua
                else
                {
                    Controller.NhanVienCtr.UpdateNhanVien(_MaNV, _TenNV, _NgaySinh, _GioiTinh, _DiaChi, _Sdt, _Luong, _ChucVu);
                }

                // xoa nhan vien trong danh sach
                foreach(string del in ListDeleteNhanVien)
                {
                    Controller.NhanVienCtr.DeleteNhanVien(del);
                }
                ListDeleteNhanVien.Clear();
                // cap nhap lai grid control
                int index = dgvNhanVien.GetFocusedDataSourceRowIndex() ;
                dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(0);
                dgvNhanVien.FocusedRowHandle = dgvNhanVien.GetVisibleRowHandle(index);
            }
            MessageBox.Show("Cập nhập thành công !");
        }


        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgvNhanVien_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            clearData();
            dgvNhanVien.SetRowCellValue(e.RowHandle, "MaNV", "");
            dgvNhanVien.SetRowCellValue(e.RowHandle, "TenNV", "");
            dgvNhanVien.SetRowCellValue(e.RowHandle, "Ngaysinh",dtpNgaySinh.Text);
            dgvNhanVien.SetRowCellValue(e.RowHandle, "Luong", 0);
            dgvNhanVien.SetRowCellValue(e.RowHandle, "ChucVu", "");
            dgvNhanVien.SetRowCellValue(e.RowHandle, "DiaChi", "");
            dgvNhanVien.SetRowCellValue(e.RowHandle, "GioiTinh", "Nam");
        }


        #endregion
    }
}
