using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Control;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Object;

namespace QuanLyNhanSu.View
{
    public partial class KyLuat : UserControl
    {
        DataTable db = new DataTable();
        int fl = 0;
        KyLuatObjTH klObj = new KyLuatObjTH();
        KyLuatCtrlTh ktCtrl = new KyLuatCtrlTh();
        public KyLuat()
        {
            InitializeComponent();
        }

        private void KyLuat_Load(object sender, EventArgs e)
        {

            db = ktCtrl.GetData();
            dgv_kyluat.DataSource = db;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            bingding();
            ReadOnly(true);
            txt_TimKiem.Enabled = true;
            btn_TimKiem.Enabled = true;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

        }
        public void ReadOnly(bool e)
        {
            txt_tenkl.ReadOnly = e;
            txt_makl.ReadOnly = e;
            txt_nguyennhan.ReadOnly = e;
            dgv_kyluat.ReadOnly = e;
            txt_hinhthuc.ReadOnly = e;
            txt_quydoi.ReadOnly = e;
        }
        public void bingding()
        {
            txt_makl.DataBindings.Clear();
            txt_makl.DataBindings.Add("Text", dgv_kyluat.DataSource, "MaKL");
            txt_tenkl.DataBindings.Clear();
            txt_tenkl.DataBindings.Add("Text", dgv_kyluat.DataSource, "TenKL");
            txt_hinhthuc.DataBindings.Clear();
            txt_hinhthuc.DataBindings.Add("Text", dgv_kyluat.DataSource, "HinhThuc");
            txt_nguyennhan.DataBindings.Clear();
            txt_nguyennhan.DataBindings.Add("Text", dgv_kyluat.DataSource, "NguyenNhan");
            txt_quydoi.DataBindings.Clear();
            txt_quydoi.DataBindings.Add("Text", dgv_kyluat.DataSource, "QuyDoiRaTienMat");


        }
        public void ClearDt()
        {
            txt_makl.Text = "";
            txt_tenkl.Text = "";
            txt_nguyennhan.Text = "";
            txt_quydoi.Text = "";
           
            txt_hinhthuc.Text = "";
        }
        void ganDuLieu(KyLuatObjTH Obj)
        {
            Obj.makl = txt_makl.Text.Trim(); ;
            Obj.tenkl = txt_tenkl.Text.Trim();
            Obj.hinhthuc = txt_hinhthuc.Text.Trim();
            Obj.nguyennhan = txt_nguyennhan.Text.Trim();
            Obj.quydoi = txt_quydoi.Text.Trim();
        }

        private void dgv_kyluat_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_kyluat.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_TimKiem.ReadOnly = true;
            btn_TimKiem.Enabled = false;
            fl = 0;
            txt_makl.Enabled = false;
            ReadOnly(false);
            ClearDt();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

            btn_Them.Enabled = false;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;

            db = ktCtrl.GetData();
            string a = "";
            if (db.Rows.Count <= 0)
            {
                a = "KL01";
            }
            else
            {
                int k;
                a = "KL";
                k = int.Parse(db.Rows[db.Rows.Count - 1][0].ToString().Trim().Substring(2, 2));
                k = k + 1;
                string tam = k.ToString();
                for (int i = 0; i < (2 - tam.Length); i++)
                {
                    a += "0";
                }
                a = a + k.ToString();
            }
            txt_makl.Text = a;
            this.txt_tenkl.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            fl = 1;
            ReadOnly(false);
            dgv_kyluat.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Enabled = true;
            if (txt_makl.Text == "" || txt_hinhthuc.Text == "" || txt_nguyennhan.Text == "" || txt_quydoi.Text == "" || txt_tenkl.Text == "")
            {
                MessageBox.Show(" Vui Lòng Nhập Đủ Thông Tin !");
                txt_tenkl.Focus();
            }
            else
            {
                ganDuLieu(klObj);
                if (fl == 0)
                {

                    if (ktCtrl.addData(klObj))
                    {

                        MessageBox.Show("Thêm thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KyLuat_Load(sender, e);
                    }

                    else
                        MessageBox.Show("Thêm mới không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KyLuat_Load(sender, e);
                }
                else
                {
                    if (ktCtrl.upData(klObj))
                    {

                        MessageBox.Show("Sửa thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KyLuat_Load(sender, e);
                    }

                    else

                        MessageBox.Show("Sửa không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KyLuat_Load(sender, e);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ? ", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ktCtrl.delData(txt_makl.Text.Trim()))
                {
                    MessageBox.Show("Xóa thàng công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                KyLuat_Load(sender, e);
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
            string str = string.Format("TenKL like '%{0}%'", txt_TimKiem.Text);


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
            KyLuat_Load(sender, e);
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
        }

        private void txt_quydoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
