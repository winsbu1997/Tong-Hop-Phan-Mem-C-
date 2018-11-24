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
    public partial class frmDoiMatKhau : Form
    {
        public delegate void SendText(string Ten);
        public SendText Sender;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            Sender = new SendText(GetText);
        }
        #region Method
        public void GetText(string Ten)
        {
            txtTenDN.Text = Ten;
        }
        void Enter1(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "Tên đăng nhập")
            {
                txtTenDN.Text = string.Empty;
            }
        }
        void Leave1(object sender, EventArgs e)
        {
            if (txtTenDN.Text == string.Empty)
            {
                txtTenDN.Text = "Tên đăng nhập";
            }
        }
        void Enter2(object sender, EventArgs e)
        {
            if (txtMKCu.Text == "Mật khẩu cũ")
            {
                txtMKCu.Text = string.Empty;
            }
        }
        void Leave2(object sender, EventArgs e)
        {
            if (txtMKCu.Text == string.Empty)
            {
                txtMKCu.Text = "Mật khẩu cũ";
            }
        }
        void Enter3(object sender, EventArgs e)
        {
            if (txtMKMoi.Text == "Mật khẩu mới")
            {
                txtMKMoi.Text = string.Empty;
            }
        }
        void Leave3(object sender, EventArgs e)
        {
            if (txtMKMoi.Text == string.Empty)
            {
                txtMKMoi.Text = "Mật khẩu mới";
            }
        }
        void Enter4(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == "Xác nhận mật khẩu")
            {
                txtXacNhanMK.PasswordChar = '*';
                txtXacNhanMK.Text = string.Empty;
            }
        }
        void Leave4(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == string.Empty)
            {
                txtXacNhanMK.PasswordChar = '\0';
                txtXacNhanMK.Text = "Xác nhận mật khẩu";
            }
        }

        #endregion

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string _TenDN = "";
            try
            {
                _TenDN = txtTenDN.Text;
            }
            catch { }

            string _MatKhaucu = "";
            try
            {
                _MatKhaucu = txtMKCu.Text;
            }
            catch { }

            string _MatKhaumoi = "";
            try
            {
                _MatKhaumoi = txtMKMoi.Text;
            }
            catch { }
            string _XacNhanMK = "";
            try
            {
                _XacNhanMK = txtXacNhanMK.Text;
            }
            catch { }

            //---------------------
            int check = Convert.ToInt32(Model.Connection.ExcuteScalar("select tmp = dbo.CheckDangNhap('" + txtTenDN.Text + "','" + txtMKMoi.Text + "')"));
            if (check == 1 || txtMKMoi.Text != txtXacNhanMK.Text)              
            {
                MessageBox.Show("Đổi mật khẩu thất bại !");
            }
            else
            {
                Controller.DangNhapCtr.UpdateDangnhap(_TenDN, _MatKhaumoi);
                MessageBox.Show("Đổi mật khẩu thành công !");
                this.Close();
            }
        }

        private void lbQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
