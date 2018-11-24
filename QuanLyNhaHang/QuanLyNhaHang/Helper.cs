using BTL_CNPM.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM
{
    public static class Helper
    {
        #region Database
        public static RM_Context db = new RM_Context();

        public static void Reload()
        {
            try
            {
                var context = ((IObjectContextAdapter)db).ObjectContext;
                var refreshableObjects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                           EntityState.Added
                                                           | EntityState.Deleted
                                                           | EntityState.Modified
                                                           | EntityState.Unchanged)
                                          where entry.EntityKey != null
                                          select entry.Entity).ToList();

                context.Refresh(RefreshMode.StoreWins, refreshableObjects);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Hàm chức năng

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static int SoLuong(MATHANG a, DateTime batdau, DateTime ketthuc)
        {
            int ans = (
                        from chitiet in db.CHITIETHOADONs.Where(p => p.MATHANGID == a.ID).ToList()
                        from hoadon in db.HOADONs.Where(p => p.ID == chitiet.HOADONID && p.NGAYNHAP >= batdau && p.NGAYNHAP <= ketthuc).ToList()
                        select chitiet
                      )
                      .ToList()
                      .Sum(p => (int)p.SOLUONG);

            return ans;
        }

        #endregion

        #region Session
        public static NHANVIEN nhanvien = db.NHANVIENs.FirstOrDefault();
        public static PHIEUNHAP phieunhap = new PHIEUNHAP();
        #endregion
    }
}
