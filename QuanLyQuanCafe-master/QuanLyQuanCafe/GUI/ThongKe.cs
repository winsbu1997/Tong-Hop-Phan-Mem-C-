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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        #region Methods
        void load()
        {
            DateTime fromday = dtpfromday.Value;
            DateTime today = dtptoday.Value;

            dgrThongKe.DataSource = KhoHangDAO.ThongKe(fromday, today);
        }
        #endregion

        #region Events
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dtpfromday_ValueChanged(object sender, EventArgs e)
        {
            load();
        }

        private void dtptoday_ValueChanged(object sender, EventArgs e)
        {
            load();
        }
        #endregion
    }
}
