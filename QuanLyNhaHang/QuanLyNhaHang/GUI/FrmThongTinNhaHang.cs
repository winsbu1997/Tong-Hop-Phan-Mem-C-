using BTL_CNPM.Data;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM.GUI
{
    public partial class FrmThongTinNhaHang : MetroForm
    {
        private RM_Context db = Helper.db;

        #region Khởi tạo
        public FrmThongTinNhaHang()
        {
            InitializeComponent();
            Helper.Reload();
        }
        #endregion

        #region Sự kiện
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNhaHang.Text == "")
            {
                MessageBox.Show("Tên nhà hàng không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ của bạn không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            THONGTINNHAHANG tt = db.THONGTINNHAHANGs.FirstOrDefault();
            if (tt == null)
            {
                tt = new THONGTINNHAHANG();
                tt.TEN = txtTenNhaHang.Text;
                tt.DIACHI = txtDiaChi.Text;
                db.THONGTINNHAHANGs.Add(tt);
            }
            else
            {
                tt.TEN = txtTenNhaHang.Text;
                tt.DIACHI = txtDiaChi.Text;
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Thay đổi thông tin nhà hàng thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Thay đổi thông tin nhà hàng thất bại",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LoadForm
        private void FrmThongTinNhaHang_Load(object sender, EventArgs e)
        {
            THONGTINNHAHANG tt = db.THONGTINNHAHANGs.FirstOrDefault();
            if (tt == null) return;

            txtTenNhaHang.Text = tt.TEN;
            txtDiaChi.Text = tt.DIACHI;
        }
        #endregion
    }
}
