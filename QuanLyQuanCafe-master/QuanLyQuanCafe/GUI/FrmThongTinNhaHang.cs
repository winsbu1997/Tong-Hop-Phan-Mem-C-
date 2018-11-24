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
    public partial class FrmThongTinNhaHang : Form
    {
        public FrmThongTinNhaHang()
        {
            InitializeComponent();
        }

        private void FrmThongTinNhaHang_Load(object sender, EventArgs e)
        {
            string query = "SELECT TENNH FROM THONGTINNHAHANG WHERE ID = 1";
            txtTenNhaHang.Text = (string)DAO.SqlServerHelper.ExecuteScalar(query);
            
            query = "SELECT DIACHI FROM THONGTINNHAHANG WHERE ID = 1";
            txtDiaChi.Text = (string)DAO.SqlServerHelper.ExecuteScalar(query);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THONGTINNHAHANG SET TENNH = @TENNH , DIACHI = @DIACHI WHERE ID = 1";
            DAO.SqlServerHelper.ExecuteScalar(query, new object[] { txtTenNhaHang.Text, txtDiaChi.Text });
            MessageBox.Show("Lưu thông tin nhà hàng thành công");
        }
    }
}
