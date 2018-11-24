using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    public static class Helper
    {
        public delegate void DangNhapThanhCong();
        public static byte[] ImageToByte(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public static Image ByteToImage(byte[] dl){
            MemoryStream ms = new MemoryStream(dl);
                return Image.FromStream(ms);
        }
    }
}
