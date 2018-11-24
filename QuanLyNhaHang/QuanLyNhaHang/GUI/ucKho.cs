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
    public partial class ucKho : UserControl
    {
        private RM_Context db = Helper.db;

        #region Hàm khởi tạo
        public ucKho()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm
        private void LoadDgvMatHang()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listMatHang = db.MATHANGs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  DonViTinh = p.DONVITINH,
                                  GiaBan = ((int)p.GIABAN).ToString("N0") + " vnđ",
                                  SoLuong = db.KHOes.Where(z => z.MATHANGID == p.ID).FirstOrDefault().SOLUONG,
                                  gt = p.GIABAN
                              })
                              .ToList();

            if (rdSoLuong.Checked) listMatHang = listMatHang.OrderByDescending(p => p.SoLuong).ToList();
            if (rdTenMatHang.Checked) listMatHang = listMatHang.OrderBy(p => p.Ten).ToList();
            if (rdGiaBan.Checked) listMatHang = listMatHang.OrderByDescending(p => p.gt).ToList();

            dgvMATHANGMain.DataSource = listMatHang.ToList()
                                        .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.DonViTinh.ToUpper().Contains(keyWord) || p.GiaBan.ToUpper().Contains(keyWord))
                                        .Select(p => new
                                        {
                                            ID = p.ID,
                                            STT = ++i,
                                            Ten = p.Ten,
                                            DonViTinh = p.DonViTinh,
                                            GiaBan = p.GiaBan,
                                            SoLuong = p.SoLuong
                                        }).ToList();
        }
        private void ucKho_Load(object sender, EventArgs e)
        {
            LoadDgvMatHang();
        }

        #endregion

        #region Sự kiện ngầm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDgvMatHang();
        }

        private void rdTenMatHang_CheckedChanged(object sender, EventArgs e)
        {
            LoadDgvMatHang();
        }
        #endregion
    }
}
