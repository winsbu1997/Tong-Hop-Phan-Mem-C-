using QuanLyQuanCafe.DAO;
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
    public partial class FrmQuanLyKho : Form
    {
        public FrmQuanLyKho()
        {
            InitializeComponent();
            LoadKhoHang();
        }

        void LoadKhoHang()
        {
            dgvHoaDonNhapMain.DataSource = KhoHangDAO.QuanLyKho();
        }
    }
}
