using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            View main = new View();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(main);
            main.Dock = DockStyle.Fill;
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            BangLuong b = new BangLuong();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UcNhanVien b = new UcNhanVien();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }

        private void btnHeSoLuong_Click(object sender, EventArgs e)
        {
            UCHeSoLuong b = new UCHeSoLuong();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(b);
            b.Dock = DockStyle.Fill;

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            UCHopDong b = new UCHopDong();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
        }

        private void btnKhenTHuong_Click(object sender, EventArgs e)
        {
            KhenThuongTh th = new KhenThuongTh();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(th);
            th.Dock = DockStyle.Fill;

        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(cv);
            cv.Dock = DockStyle.Fill;
        }

        private void btnKyLuat_Click(object sender, EventArgs e)
        {
            KyLuat kl = new KyLuat();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(kl);
            kl.Dock = DockStyle.Fill;
        }
    }
}
