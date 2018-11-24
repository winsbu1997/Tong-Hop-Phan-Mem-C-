using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.GUI
{
    public partial class ThongTinNhaHang : UserControl
    {
        public ThongTinNhaHang()
        {
            InitializeComponent();
            timer1.Start();
        }
        public static ThongTinNhaHang uct_TTNH = new ThongTinNhaHang();
        int count = 0;
        private void LoadImage()
        {
            if(count == 12)
            {
                count = 0;
            }
            ptbImage.ImageLocation = string.Format(Application.StartupPath + @"\images\stock canh vat\{0}.jpg",count);
            count++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void ThongTinNhaHang_Load(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder();
            query.Append("https://www.google.com/maps/place/236+Ho%C3%A0ng+Qu%E1%BB%91c+Vi%E1%BB%87t,+C%E1%BB%95+Nhu%E1%BA%BF+1,+C%E1%BA%A7u+Gi%E1%BA%A5y,+H%C3%A0+N%E1%BB%99i,+Vi%E1%BB%87t+Nam/@21.0482625,105.7837171,17z/data=!4m5!3m4!1s0x3135ab3277f870d7:0xf27837785a779a8a!8m2!3d21.0482898!4d105.7858431");
            webBrowser1.Navigate(query.ToString());
        }
        void openurl(string url)
        {
            Bunifu.Framework.Lib.LinkWeb.EXECUTECMD("start explorer.exe \"" + url + "\"");
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            openurl("https://www.facebook.com/profile.php?id=100004203068479");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            openurl("https://www.youtube.com/");
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            openurl("https://mail.google.com/");
        }
    }
}
