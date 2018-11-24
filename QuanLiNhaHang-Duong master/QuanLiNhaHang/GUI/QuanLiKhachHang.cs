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
    public partial class QuanLiKhachHang : UserControl
    {
        #region Properties

        int flag = 0;

        public QuanLiKhachHang()
        {
            InitializeComponent();
        }

        public static QuanLiKhachHang uct_KH = new QuanLiKhachHang();

        #endregion

        #region Method
        public void HienThiDanhSachKH()
        {
            dgvKhachHangMain.DataSource = Model.KhachHangMod.FillDataSetKhachHang().Tables[0];   
        }
        public void Binding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKhachHangMain.DataSource, "MaKH",true);
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dgvKhachHangMain.DataSource, "TenKH",true);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvKhachHangMain.DataSource, "DiaChi",true);
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dgvKhachHangMain.DataSource, "Sdt",true);
        }

        private void LoadControl()
        {
            cbxFindIdorTen.Items.Clear();
            cbxFindIdorTen.Items.Add("Mã Khách Hàng");
            cbxFindIdorTen.Items.Add("Tên Khách Hàng");
        }

        private void Dis_End(bool e)
        {
            grcKhachHang.Enabled = e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnCapNhat.Enabled = e;
            btnThoat.Enabled = e;
        }
        private void clearData()
        {
            txtMaKH.Text = Model.Connection.ExcuteScalar(string.Format("select MaKH = dbo.fcgetIdKhachHang()"));
            txtDiaChi.Text = "";
            txtTenKH.Text = "";
            txtSdt.Text = "";
            txtFind.Text = "";
        }

        private void QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.Columns[0].OptionsColumn.AllowEdit = false;
            txtMaKH.Enabled = false;
            HienThiDanhSachKH();
            LoadControl();
            Binding();
            Dis_End(false);
        }
        #endregion

        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            Dis_End(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_End(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaKH = "";
            try
            {
                _MaKH = txtMaKH.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controller.KhachHangCtr.DeleteKhachHang(_MaKH);
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");
                    QuanLiKhachHang_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _MaKH = txtMaKH.Text;
            string _TenKH = "";
            try
            {
                _TenKH = txtTenKH.Text;
            }
            catch { }

            string _DiaChi = "";
            try
            {
                _DiaChi = txtDiaChi.Text;
            }
            catch { }

            string _Sdt = "";
            try
            {
                _Sdt = txtSdt.Text;
            }
            catch { }

            if (flag == 0)
            {
                int i = 0;
                i = Controller.KhachHangCtr.InsertKhachHang(_MaKH, _TenKH, _Sdt, _DiaChi);
                if (i == 0)
                {
                    MessageBox.Show("Thêm mới thất bại !");
                }
                else
                {
                    MessageBox.Show("Thêm mới thành công !");
                    QuanLiKhachHang_Load(sender, e);
                    Dis_End(false);
                }
            }
            else
            {
                int i = 0;
                i = Controller.KhachHangCtr.UpdateKhachHang(_MaKH, _TenKH, _Sdt, _DiaChi);
                if (i == 0)
                {
                    MessageBox.Show("Sửa thất bại !");
                }
                else
                {
                    MessageBox.Show("Sửa thành công !");
                    Dis_End(false);
                }
            }
            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang_Load(sender, e);
            Dis_End(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbxFindIdorTen.Text == "Mã Khách Hàng")
            {
                string _MaKH = txtFind.Text.ToString();
                dt = Controller.KhachHangCtr.FillDataSet_SearchKhachHangbyMaKH(_MaKH).Tables[0];
            }
            else
            {
                string _TenKH = txtFind.Text.ToString();
                dt = Controller.KhachHangCtr.FillDataSet_SearchKhachHangbyTenKH(_TenKH).Tables[0];
            }
            dgvKhachHangMain.DataSource = dt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
