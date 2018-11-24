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
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Control;
using QuanLyNhanSu.View;
using System.Data.SqlClient;
namespace QuanLyNhanSu.View
{
    public partial class UCHeSoLuong : UserControl
    {
        int check;
        DataTable dt1;
        public UCHeSoLuong()
        {
            InitializeComponent();
        }

        private void UCHeSoLuong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dt1 = new DataTable();
            dt1 = HeSoLuongCtrl.GetData();
            dgvHeSoLuong.DataSource = dt1;

            txtBacLuong.Enabled = false;
            txtLuongCB.Enabled = false;
            txtLuongtangca.Enabled = false;

            txtTimKiem.Enabled = true;


            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void dgvHeSoLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtBacLuong.Text = Convert.ToString(dgvHeSoLuong.CurrentRow.Cells["BacLuong"].Value);
                txtLuongCB.Text = Convert.ToString(dgvHeSoLuong.CurrentRow.Cells["LuongCB"].Value);
                txtLuongtangca.Text = Convert.ToString(dgvHeSoLuong.CurrentRow.Cells["LuongTangCa"].Value);
            }
        }

        private void dgvHeSoLuong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHeSoLuong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("BacLuong like '%{0}%' ", txtTimKiem.Text);
            dt1.DefaultView.RowFilter = str;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            txtBacLuong.Enabled = true;
            txtLuongCB.Enabled = true;
            txtLuongtangca.Enabled = true;

            txtTimKiem.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvHeSoLuong.Enabled = false;

            txtBacLuong.Text = "";
            txtLuongCB.Text = "";
            txtLuongtangca.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            if (txtBacLuong.Text == "")
                MessageBox.Show("Bạn cần chọn Bậc Lương để sửa !", "Thông Báo");
            else
            {
                txtBacLuong.Enabled = true;
                txtLuongCB.Enabled = true;
                txtLuongtangca.Enabled = true;

                txtTimKiem.Enabled = false;


                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                dgvHeSoLuong.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtBacLuong.Text == "")
                MessageBox.Show("Bạn cần chọn Bậc Lương để xóa !", "Thông Báo");
            else
          if (MessageBox.Show("Bạn có chắc chắn muốn xóa Lương " + txtBacLuong.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HeSoLuong qh = new HeSoLuong();
                qh.BacLuong = txtBacLuong.Text;
                if (HeSoLuongCtrl.DeleteProfile(qh) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    UCHeSoLuong_Load(sender, e);
                }
                else MessageBox.Show("Không thể Xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtBacLuong.Text == "" || txtLuongCB.Text == "" || txtLuongtangca.Text=="")
            {
                MessageBox.Show("Bạn Cần Điền Đầy Đủ Thông Tin Trước Khi Lưu", "Thông Báo");
            }
            else
            if (check == 1)
            {
                HeSoLuong qh = new HeSoLuong();
                qh.BacLuong = txtBacLuong.Text;
                qh.LuongCB = float.Parse(txtLuongCB.Text);
                qh.LuongTangCa= float.Parse(txtLuongtangca.Text);



                if (HeSoLuongCtrl.InsertProfile(qh) > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    UCHeSoLuong_Load(sender, e);
                    dgvHeSoLuong.Enabled = true;

                }
                else MessageBox.Show("Không thể thêm mới");

            }

            else
            {
                HeSoLuong qh = new HeSoLuong();
                qh.BacLuong = txtBacLuong.Text;
                qh.LuongCB = float.Parse(txtLuongCB.Text);
                qh.LuongTangCa = float.Parse(txtLuongtangca.Text);

                if (HeSoLuongCtrl.UpdateProfile(qh) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    UCHeSoLuong_Load(sender, e);
                    dgvHeSoLuong.Enabled = true;

                }
                else MessageBox.Show("Không thể Sửa");

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtBacLuong.Enabled = false;
            txtLuongtangca.Enabled = false;
            txtLuongCB.Enabled = false;

            txtTimKiem.Enabled = true;


            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvHeSoLuong.Enabled = true;

            txtLuongCB.Text = "";
            txtBacLuong.Text = "";
            txtLuongtangca.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
             View m = new View();
            this.Controls.Clear();
            this.Controls.Add(m);
            m.Dock = DockStyle.Fill;
        }
    }
}
