using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Object;
using QuanLyNhanSu.Control;
using QuanLyNhanSu.Model;

namespace QuanLyNhanSu.View
{
    public partial class PhongBan : UserControl
    {
        DataTable db = new DataTable();
        int fl = 0;
        PhongBanObjL pbObj = new PhongBanObjL();
        PhongBanCtrlL pbCtrl = new PhongBanCtrlL();
        public PhongBan()
        {
            InitializeComponent();
        }

        private void PhongBan_Load(object sender, EventArgs e)
        {
            db = pbCtrl.GetData();
            dgv_PhongBan.DataSource = db;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            bingding();
            ReadOnly(true);
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
        }

        private void bingding()
        {
            txt_mapb.DataBindings.Clear();
            txt_mapb.DataBindings.Add("Text", dgv_PhongBan.DataSource, "MaPB");
            txt_tenpb.DataBindings.Clear();
            txt_tenpb.DataBindings.Add("Text", dgv_PhongBan.DataSource, "TenPB");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dgv_PhongBan.DataSource, "DiaChi");
            txt_sdt.DataBindings.Clear();
            txt_sdt.DataBindings.Add("Text", dgv_PhongBan.DataSource, "SDT");
        }

        private void ReadOnly(bool p)
        {
            txt_tenpb.ReadOnly = p;
            txt_mapb.ReadOnly = p;
            txt_diachi.ReadOnly = p;
            dgv_PhongBan.ReadOnly = p;
            txt_sdt.ReadOnly = p;
        }
        public void ClearDt()
        {
            txt_mapb.Text = "";
            txt_tenpb.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
        }
        void ganDuLieu(PhongBanObjL Obj)
        {
            Obj.MaPB = txt_mapb.Text.Trim(); ;
            Obj.TenPB = txt_tenpb.Text.Trim();
            Obj.DiaChi = txt_diachi.Text.Trim();
            Obj.SDT = txt_sdt.Text.Trim();
        }

        private void dgv_PhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_PhongBan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_TimKiem.ReadOnly = true;
            btn_TimKiem.Enabled = false;
            fl = 0;
            ReadOnly(false);
            ClearDt();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

            btn_Them.Enabled = false;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;

            db = pbCtrl.GetData();
            string a = "";
            if (db.Rows.Count <= 0)
            {
                a = "PB01";
            }
            else
            {
                int k;
                a = "PB";
                k = int.Parse(db.Rows[db.Rows.Count - 1][0].ToString().Trim().Substring(2, 2));
                k = k + 1;
                string tam = k.ToString();
                for (int i = 0; i < (2 - tam.Length); i++)
                {
                    a += "0";
                }
                a = a + k.ToString();
            }
            txt_mapb.Text = a;
            this.txt_tenpb.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            fl = 1;
            ReadOnly(false);
            dgv_PhongBan.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            ganDuLieu(pbObj);
            if (fl == 0)
            {

                if (pbCtrl.addData(pbObj))
                {

                    MessageBox.Show("Thêm thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhongBan_Load(sender, e);
                }

                else
                    MessageBox.Show("Thêm mới không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhongBan_Load(sender, e);
            }
            else
            {
                if (pbCtrl.upData(pbObj))
                {

                    MessageBox.Show("Sửa thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhongBan_Load(sender, e);
                }

                else

                    MessageBox.Show("Sửa không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhongBan_Load(sender, e);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ? ", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (pbCtrl.delData(txt_mapb.Text.Trim()))
                {
                    MessageBox.Show("Xóa thàng công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                PhongBan_Load(sender, e);
            }
            else
                return;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
            txt_TimKiem.Focus();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("TenPB like '%{0}%'", txt_TimKiem.Text);


            db.DefaultView.RowFilter = str;
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            View main = new View();
            this.Controls.Clear();
            this.Controls.Add(main);
            main.Dock = DockStyle.Fill;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            PhongBan_Load(sender, e);
        }
    }
}
