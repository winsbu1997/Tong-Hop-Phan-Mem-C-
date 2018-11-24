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
    public partial class frmCTB : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendText(string TenMA, string DonViTinh, int SoLuong, int DonGia);
        public SendText Sender;

        public event SendText ReceiveText;  
    
        public frmCTB()
        {
            InitializeComponent();
            Sender = new SendText(GetText);

        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            txtSL.Text = (Convert.ToInt32(txtSL.Text) + 1).ToString();
        }

        private void btnSUB_Click(object sender, EventArgs e)
        {
            int sub = (Convert.ToInt32(txtSL.Text) - 1);
            if (sub > 0)
                txtSL.Text = sub.ToString();
        }
        private void GetText(string TenMA, string DonViTinh, int SoLuong, int DonGia) 
        {
            txtDonGia.Text = DonGia.ToString();
            txtDVT.Text = DonViTinh;
            txtTenMA.Text = TenMA;
            txtSL.Text = SoLuong.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int DonGia = Convert.ToInt32(txtDonGia.Text);
            string DonViTinh = txtDVT.Text;
            string TenMA = txtTenMA.Text;
            int SoLuong = Convert.ToInt32(txtSL.Text);
            ReceiveText( TenMA, DonViTinh, SoLuong, DonGia);
            this.Close();
        }
    }
}