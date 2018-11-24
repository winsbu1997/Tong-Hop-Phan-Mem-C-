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
    public partial class QuanLiNguyenLieu : UserControl
    {
        int flag;
        public QuanLiNguyenLieu()
        {
            InitializeComponent();
        }
        public static QuanLiNguyenLieu uct_NL = new QuanLiNguyenLieu();

        #region Method
        public void HienThiDanhSachNL()
        {
            dgvNguyenLieuMain.DataSource = Model.NguyenLieuMod.FillDataSetNguyenLieu().Tables[0];
        }
        public void Binding()
        {
            txtMaNL.DataBindings.Clear();
            txtMaNL.DataBindings.Add("Text", dgvNguyenLieuMain.DataSource, "MaNL", true);
            txtTenNL.DataBindings.Clear();
            txtTenNL.DataBindings.Add("Text", dgvNguyenLieuMain.DataSource, "TenNL", true);
            txtDVT.DataBindings.Clear();
            txtDVT.DataBindings.Add("Text", dgvNguyenLieuMain.DataSource, "DonViTinh", true);
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvNguyenLieuMain.DataSource, "DonGia", true);
        }
       
        private void Dis_End(bool e)
        {
            grcNguyenLieu.Enabled = e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnCapNhat.Enabled = e;
            btnThoat.Enabled = e;
        }
        private void clearData()
        {
            txtMaNL.Text = Model.Connection.ExcuteScalar(string.Format("select MaNL = dbo.fcgetIdNguyenLieu()"));
            txtTenNL.Text = "";
            txtDVT.Text = "";
            txtDonGia.Value = 0;
        }

        private void QuanLiNguyenLieu_Load(object sender, EventArgs e)
        {
            //dgvNguyenLieu.Columns[0].OptionsColumn.AllowEdit = false;
            txtMaNL.Enabled = false;
            HienThiDanhSachNL();
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
            string _MaNL = "";
            try
            {
                _MaNL = txtMaNL.Text;
                MessageBox.Show(_MaNL);
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controller.NguyenLieuCtr.DeleteNguyenLieu(_MaNL);
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");
                    QuanLiNguyenLieu_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _MaNL = txtMaNL.Text;
            string _TenNL = "";
            try
            {
                _TenNL = txtTenNL.Text;
                
            }
            catch { }

            string _DonViTinh = "";
            try
            {
                _DonViTinh = txtDVT.Text;
            }
            catch { }

            int _DonGia = 0;
            try
            {
                _DonGia = (int) txtDonGia.Value;
            }
            catch { }

            if (flag == 0)
            {
                int i = 0;
                i = Controller.NguyenLieuCtr.InsertNguyenLieu(_MaNL, _TenNL, _DonViTinh, _DonGia);
                if (i == 0)
                {
                    MessageBox.Show("Thêm mới thất bại !");
                }
                else
                {
                    MessageBox.Show("Thêm mới thành công !");
                    QuanLiNguyenLieu_Load(sender, e);
                    Dis_End(false);
                }
            }
            else
            {
                int i = 0;
                i = Controller.NguyenLieuCtr.UpdateNguyenLieu(_MaNL, _TenNL, _DonViTinh, _DonGia);
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
            QuanLiNguyenLieu_Load(sender, e);
            Dis_End(false);
        }
        #endregion

    }
}
