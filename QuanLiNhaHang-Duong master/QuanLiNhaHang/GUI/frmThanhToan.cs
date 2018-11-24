using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLiNhaHang.GUI
{
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendText(string TenBA, int TongTien);
        public SendText Sender;

        public event SendText ReceiveText;
        public frmThanhToan()
        {
            InitializeComponent();
            Sender = new SendText(GetText);
        }
        private void GetText(string TenBA, int TongTien)
        {
            txtTenBan.Text = TenBA;
            txtTongTien.Text = (TongTien).ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTienThua.Text) >= 0)
            {
                ReceiveText(txtTienTra.Text, Convert.ToInt32(txtTienThua.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Mời khách trả đủ !");
                txtTienTra.Text = "0";
                txtTienThua.Text = "0";
            }
              
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTienTra_TextChanged(object sender, EventArgs e)
        {
            int tientra = 0;
            try
            {
                tientra = Convert.ToInt32(txtTienTra.Text);
            }
            catch { }
            
            int tongtien = Convert.ToInt32(txtTongTien.Text);
            txtTienThua.Text = (tientra - tongtien).ToString();
        }

        private void txtTienTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}