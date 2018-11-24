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
    public partial class UCHopDong : UserControl
    {

        int check;
        DataTable dt1;
        public UCHopDong()
        {
            InitializeComponent();
        }

        private void UCHopDong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataLuong();
        }
        public void LoadData()
        {
            dt1 = new DataTable();
            dt1 = HopDongCtrl.GetData();
            dgvSach.DataSource = dt1;

            txtLoaiHD.Enabled = false;
            txtMaHD.Enabled = false;
            txtTenHD.Enabled = false;
            dtpNgayBD.Enabled = false;
            dtpNgayKT.Enabled = false;
            cmbBacLuong.Enabled = false;
            txtTimKiem.Enabled = true;
            

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
          
        }
        public void LoadDataLuong()
        {
            cmbBacLuong.DataSource = HeSoLuongCtrl.GetData();
            cmbBacLuong.ValueMember = "BacLuong";
            cmbBacLuong.DisplayMember = "BacLuong";

        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaHD.Text = Convert.ToString(dgvSach.CurrentRow.Cells["MaHD"].Value);
                txtTenHD.Text = Convert.ToString(dgvSach.CurrentRow.Cells["TenHD"].Value);
                txtLoaiHD.Text = Convert.ToString(dgvSach.CurrentRow.Cells["LoaiHD"].Value);
                dtpNgayBD.Text = Convert.ToString(dgvSach.CurrentRow.Cells["NgayBatDau"].Value);
                dtpNgayKT.Text = Convert.ToString(dgvSach.CurrentRow.Cells["NgayKetThuc"].Value);
                cmbBacLuong.Text = Convert.ToString(dgvSach.CurrentRow.Cells["BacLuong"].Value);
            }
        }

        private void dgvSach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSach.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("MaHD like '%{0}%' or TenHD like '%{0}%' or LoaiHD like '%{0}%' ", txtTimKiem.Text);
            dt1.DefaultView.RowFilter = str;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            txtMaHD.Enabled = true;
            txtTenHD.Enabled = true;
            txtLoaiHD.Enabled = true;
            dtpNgayBD.Enabled = true;
            dtpNgayKT.Enabled = true;
            cmbBacLuong.Enabled = true;
            txtTimKiem.Enabled = false;
            
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvSach.Enabled = false;

            txtMaHD.Text = "";
            txtTenHD.Text = "";
            txtLoaiHD.Text = "";
            dtpNgayBD.Text = "";
            dtpNgayKT.Text = "";
            cmbBacLuong.Text = "";
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            if (txtMaHD.Text == "")
                MessageBox.Show("Bạn cần chọn Hợp Đồng để sửa !", "Thông Báo");
            else
            {
                txtMaHD.Enabled = true;
                txtTenHD.Enabled = true;
                txtLoaiHD.Enabled = true;
                dtpNgayBD.Enabled = true;
                dtpNgayKT.Enabled = true;
                cmbBacLuong.Enabled = true;
                txtTimKiem.Enabled = false;

                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                dgvSach.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
                MessageBox.Show("Bạn cần chọn Hợp Đồng để xóa !", "Thông Báo");
            else
             if (MessageBox.Show("Bạn có chắc chắn muốn xóa Hợp Đồng " + txtTenHD.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HopDongObj qh = new HopDongObj();
                qh.MaHD = txtMaHD.Text;
                if (HopDongCtrl.DeleteProfile(qh) > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    UCHopDong_Load(sender, e);
                }
                else MessageBox.Show("Không thể Xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtTenHD.Text == "" || txtLoaiHD.Text == "" || cmbBacLuong.Text == "")
            {
                MessageBox.Show("Bạn Cần Điền Đầy Đủ Thông Tin Trước Khi Lưu", "Thông Báo");
            }
            else
              if (check == 1)
            {
                HopDongObj qh = new HopDongObj();
                qh.MaHD = txtMaHD.Text;
                qh.TenHD = txtTenHD.Text;
                qh.LoaiHD = txtLoaiHD.Text;
                qh.NgayBatDau = DateTime.Parse(dtpNgayBD.Text);
                qh.NgayKetThuc = DateTime.Parse(dtpNgayKT.Text);
                
                qh.BacLuong = cmbBacLuong.SelectedValue.ToString();
                

                if (HopDongCtrl.InsertProfile(qh) > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    UCHopDong_Load(sender, e);
                    dgvSach.Enabled = true;

                }
                else MessageBox.Show("Không thể thêm mới");

            }

            else
            {
                HopDongObj qh = new HopDongObj();
                qh.MaHD = txtMaHD.Text;
                qh.TenHD = txtTenHD.Text;
                qh.LoaiHD = txtLoaiHD.Text;
                qh.NgayBatDau = DateTime.Parse(dtpNgayBD.Text);
                qh.NgayKetThuc = DateTime.Parse(dtpNgayKT.Text);

                qh.BacLuong = cmbBacLuong.SelectedValue.ToString();

                if (HopDongCtrl.UpdateProfile(qh) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    UCHopDong_Load(sender, e);
                    dgvSach.Enabled = true;

                }
                else MessageBox.Show("Không thể Sửa");

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = false;
            txtTenHD.Enabled = false;
            txtLoaiHD.Enabled = false;
            dtpNgayBD.Enabled = false;
            dtpNgayKT.Enabled = false;
            cmbBacLuong.Enabled = false;
            txtTimKiem.Enabled = true;
           
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvSach.Enabled = true;

            txtMaHD.Text = "";
            txtTenHD.Text = "";
            txtLoaiHD.Text = "";
            dtpNgayBD.Text = "";
            dtpNgayKT.Text = "";
            cmbBacLuong.Text = "";
           
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
