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
    public partial class ChucVu : UserControl
    {
        DataTable db = new DataTable();
        int fl = 0;
        ChucVuObjL cvObj = new ChucVuObjL();
        ChucVuCtrlL cvCtrl = new ChucVuCtrlL();
        public ChucVu()
        {
            InitializeComponent();
        }

        private void txt_makt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            db = cvCtrl.GetData();
            dgv_ChucVu.DataSource = db;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            bingding();
            ReadOnly(true);
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
        }

        private void ReadOnly(bool p)
        {
            txt_macv.ReadOnly = p;
            txt_tencv.ReadOnly = p;

        }

        private void bingding()
        {
            txt_macv.DataBindings.Clear();
            txt_macv.DataBindings.Add("Text", dgv_ChucVu.DataSource, "MaCV");
            txt_tencv.DataBindings.Clear();
            txt_tencv.DataBindings.Add("Text", dgv_ChucVu.DataSource, "TenCV");
        }
        public void ClearDt()
        {
            txt_macv.Text = "";
            txt_tencv.Text = "";
        }
        void ganDuLieu(ChucVuObjL Obj)
        {
            Obj.MaCV = txt_macv.Text.Trim(); ;
            Obj.TenCV = txt_tencv.Text.Trim();
        }

        private void dgv_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_ChucVu.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
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

            db = cvCtrl.GetData();
            string a = "";
            if (db.Rows.Count <= 0)
            {
                a = "CV01";
            }
            else
            {
                int k;
                a = "CV";
                k = int.Parse(db.Rows[db.Rows.Count - 1][0].ToString().Trim().Substring(2, 2));
                k = k + 1;
                string tam = k.ToString();
                for (int i = 0; i < (2 - tam.Length); i++)
                {
                    a += "0";
                }
                a = a + k.ToString();
            }
            txt_macv.Text = a;
            this.txt_tencv.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            fl = 1;
            ReadOnly(false);
            dgv_ChucVu.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            ganDuLieu(cvObj);
            if (fl == 0)
            {

                if (cvCtrl.addData(cvObj))
                {

                    MessageBox.Show("Thêm thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChucVu_Load(sender, e);
                }

                else
                    MessageBox.Show("Thêm mới không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChucVu_Load(sender, e);
            }
            else
            {
                if (cvCtrl.upData(cvObj))
                {

                    MessageBox.Show("Sửa thàng công !", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChucVu_Load(sender, e);
                }

                else

                    MessageBox.Show("Sửa không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChucVu_Load(sender, e);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa không ? ", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (cvCtrl.delData(txt_macv.Text.Trim()))
                {
                    MessageBox.Show("Xóa thàng công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                ChucVu_Load(sender, e);
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
            string str = string.Format("TenCV like '%{0}%'", txt_TimKiem.Text);


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
            ChucVu_Load(sender, e);
        }
    }
}
