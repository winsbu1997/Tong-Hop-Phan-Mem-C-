using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.GUI
{
    public partial class frmNhapKhachHang : Form
    {
        public frmNhapKhachHang()
        {
            InitializeComponent();
            txtMaKH.Enabled = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
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
            int i = 0;
            i = Controller.KhachHangCtr.InsertKhachHang(_MaKH, _TenKH, _Sdt, _DiaChi);
            if (i == 0)
            {
                MessageBox.Show("Thêm mới thất bại !");
            }
            else
            {
                GUI.GoiMon.uct_gm.Sender(_MaKH);
                MessageBox.Show("Thêm mới thành công !");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = Model.Connection.ExcuteScalar(string.Format("select MaKH = dbo.fcgetIdKhachHang()"));
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
