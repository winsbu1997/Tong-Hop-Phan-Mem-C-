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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string query = "SELECT MATKHAU FROM TAIKHOAN WHERE ID = 1";
            string matkhau = (string) DAO.SqlServerHelper.ExecuteScalar(query);
            if (matkhau == txtMatKhauCu.Text)
            {
                if (txtMatKhauMoi.Text == txtXacNhanMatKhauMoi.Text && txtMatKhauMoi.Text != "")
                {
                    query = "UPDATE TAIKHOAN SET MATKHAU = @MATKHAU WHERE ID = 1";
                    var count_row = DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { txtMatKhauMoi.Text });
                    if(count_row > 0) MessageBox.Show("Đổi mật khẩu thành công >> " + count_row);
                    this.Close();
                    return;
                }

                if (txtMatKhauMoi.Text == "")
                {
                    MessageBox.Show("Mật khẩu mới không được trống");
                    return;
                }

                if (txtMatKhauMoi.Text != txtXacNhanMatKhauMoi.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không chính xác");
                    return;
                }
            }

            MessageBox.Show("Mật khẩu cũ không chính xác");
        }
    }
}
