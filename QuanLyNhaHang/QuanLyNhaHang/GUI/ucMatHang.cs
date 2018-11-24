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
    public partial class ucMatHang : UserControl
    {
        private RM_Context db = Helper.db;
        private MATHANG mathang = new MATHANG();

        #region Hàm khởi tạo
        public ucMatHang(MATHANG mh)
        {
            InitializeComponent();
            Helper.Reload();
            mathang = mh;
        }
        #endregion

        #region LoadForm
        private void ucMatHang_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenMatHang.Text = mathang.TEN;
                txtGiaBan.Text = ((int)mathang.GIABAN).ToString("N0") + " vnđ";
                imgAnh.Image = Helper.byteArrayToImage(mathang.ANH);
            }
            catch { }
        }
        #endregion
    }
}
