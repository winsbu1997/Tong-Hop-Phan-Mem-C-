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
    public partial class FrmQuanLyBanAn : Form
    {
        private List<int> ListXoaBanAn = new List<int>();
        public FrmQuanLyBanAn()
        {
            InitializeComponent();
        }

        #region load form
        private void FrmQuanLyBanAn_Load(object sender, EventArgs e)
        {
            ///thêm datasource cho gridcontrol
            dgvBanAnMain.DataSource = DAO.BanAnDAO.DanhSachBanAn();

            /// thêm binding
            txtMaBA.DataBindings.Add(new Binding("Text", dgvBanAnMain.DataSource, "MABA", true, DataSourceUpdateMode.OnPropertyChanged));
            txtTenBA.DataBindings.Add(new Binding("Text", dgvBanAnMain.DataSource, "TENBA", true, DataSourceUpdateMode.OnPropertyChanged));
            txtViTri.DataBindings.Add(new Binding("Text", dgvBanAnMain.DataSource, "VITRI", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSoCho.DataBindings.Add(new Binding("Text", dgvBanAnMain.DataSource, "SOCHO", true, DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion

        #region sự kiện
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Hủy")
            {
                btnThem.Text = "Thêm";
                btnCapNhat.Enabled = true;
                dgvBanAnMain.Enabled = true;
                btnXoa.Text = "Xóa";
                dgvBanAn.DeleteSelectedRows();
                return;
            }

            if (btnXoa.Text == "Xóa")
            {
                int ma = (int)dgvBanAn.GetFocusedRowCellValue("MABA");
                if (ma > 0) ListXoaBanAn.Add(ma);
                dgvBanAn.DeleteSelectedRows();
                return;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                /// cập nhật lại các phần tử trong GridControl
                for (int i = 0; i < dgvBanAn.RowCount; i++)
                {
                    int MaBA = (int)dgvBanAn.GetRowCellValue(i, "MABA");
                    string TenBA = (string)dgvBanAn.GetRowCellValue(i, "TENBA");
                    int SoCho = (int)dgvBanAn.GetRowCellValue(i, "SOCHO");
                    string ViTri = (string)dgvBanAn.GetRowCellValue(i, "VITRI");

                    if (MaBA > 0) DAO.BanAnDAO.CapNhatBanAn(MaBA, TenBA, SoCho, ViTri);
                    else
                    {
                        DAO.BanAnDAO.ThemBanAn(TenBA, SoCho, ViTri);
                        string query = "SELECT MAX(MABA) FROM BANAN";
                        MaBA = (int)DAO.SqlServerHelper.ExecuteScalar(query);
                        dgvBanAn.SetRowCellValue(i, "MABA", MaBA);
                    }
                }
                /// Xóa đi các phần tử đã được người dùng bấm nút xóa
                foreach (int ma in ListXoaBanAn) DAO.BanAnDAO.XoaBanAn(ma);
                ListXoaBanAn.Clear();

                /// Cập nhật GridControl
                int index = dgvBanAn.GetFocusedDataSourceRowIndex();
                dgvBanAn.FocusedRowHandle = dgvBanAn.GetVisibleRowHandle(0);
                dgvBanAn.FocusedRowHandle = dgvBanAn.GetVisibleRowHandle(index); 
            }
            catch
            {
                
            }
            /// thong bao
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hoàn thành";
                btnCapNhat.Enabled = false;
                dgvBanAnMain.Enabled = false;
                btnXoa.Text = "Hủy";
                dgvBanAn.AddNewRow();

                return;
            }

            if (btnThem.Text == "Hoàn thành")
            {
                if (txtTenBA.Text == "")
                {
                    MessageBox.Show("Tên bàn ăn không được để trống");
                    return;
                }

                if (txtViTri.Text == "")
                {
                    MessageBox.Show("Vị trí bàn ăn không được để trống");
                    return;
                }

                /// thêm bàn ăn thành công
                btnThem.Text = "Thêm";
                btnCapNhat.Enabled = true;
                dgvBanAnMain.Enabled = true;
                btnXoa.Text = "Xóa";

                int index = dgvBanAn.GetFocusedDataSourceRowIndex();
                dgvBanAn.FocusedRowHandle = dgvBanAn.GetVisibleRowHandle(0);
                dgvBanAn.FocusedRowHandle = dgvBanAn.GetVisibleRowHandle(index);
            }
        }
        #endregion

        #region sự kiện ngầm
        private void dgvBanAn_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dgvBanAn.SetRowCellValue(e.RowHandle, "MABA", 0);
            dgvBanAn.SetRowCellValue(e.RowHandle, "TENBA", "");
            dgvBanAn.SetRowCellValue(e.RowHandle, "SOCHO", 0);
            dgvBanAn.SetRowCellValue(e.RowHandle, "VITRI", "");
        }
        #endregion

    }
}
