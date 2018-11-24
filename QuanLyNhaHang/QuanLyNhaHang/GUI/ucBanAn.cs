using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_CNPM.Data;

namespace BTL_CNPM.GUI
{
    public partial class ucBanAn : UserControl
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanAn));
        private BANAN ban = new BANAN();

        #region Hàm khởi tạo
        public ucBanAn(BANAN ba, EventHandler e)
        {
            InitializeComponent();
            Helper.Reload();
            ban = ba;

            btnBanAn.Click += e;
            btnBanAn.Tag = ba.ID;
        }
        #endregion

        #region LoadForm
        private void LoadStatus()
        {
            btnBanAn.Text = ban.TEN;

            if (ban.TRANGTHAI == 0)
            {
                this.btnBanAn.Image = ((System.Drawing.Image)(resources.GetObject("free")));
            }
            else
            {
                this.btnBanAn.Image = ((System.Drawing.Image)(resources.GetObject("busy")));
            }
        }
        private void ucBanAn_Load(object sender, EventArgs e)
        {
            LoadStatus();
        }

        public void Refresh()
        {
            LoadStatus();
        }
        #endregion
    }
}
