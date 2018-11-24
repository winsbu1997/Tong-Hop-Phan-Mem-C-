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
using QuanLyNhanSu.Object;
namespace QuanLyNhanSu.View
{
    public partial class UcNhanVien : UserControl
    {
        public UcNhanVien()
        {
            InitializeComponent();
        }
        string m_chucnang = "";
        DataTable dt = new DataTable();
        private void UcNhanVien_Load(object sender, EventArgs e)
        {

            dt = NhanVienCtrlTr.GetListNhanVien();
            dataGridView1.DataSource = dt;

            cmbChucVu.DataSource = ChucVuCtrlTr.GetListChucVu();
            cmbChucVu.DisplayMember = "TenCV";
            cmbChucVu.ValueMember = "MaCV";
            cmbPhongBan.DataSource = PhongBanCtrlTr.GetListPhongBan();
            cmbPhongBan.DisplayMember = "TenPB";
            cmbPhongBan.ValueMember = "MaPB";
            cmbHopDong.DataSource = HopDongCtrlTr.GetListHopDong();
            cmbHopDong.DisplayMember = "TenHD";
            cmbHopDong.ValueMember = "MaHD";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.btnLuu.Visible = true;
            this.btnHuy.Visible = true;
            this.btnThem.Visible = false;
            this.btnSua.Visible = false;
            this.btnXoa.Visible = false;
            this.btnThoat.Visible = false;
            txtNhanVien.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cmbChucVu.Enabled = true;
            cmbHopDong.Enabled = true;
            cmbPhongBan.Enabled = true;
            m_chucnang = "them";
            txtNhanVien.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtTimKiem.Enabled = false;
            //tang ma hd tu dong
            DataTable dtHd = new DataTable();

            dtHd = NhanVienCtrlTr.GetListNhanVien();
            string s = "";
            if (dtHd.Rows.Count <= 0)
            {
                s = "0";
            }
            else
            {
                s = "HD";
                s = (int.Parse(dtHd.Rows[dtHd.Rows.Count - 1][0].ToString().Trim()) + 1).ToString();
            }
            lblMaNV.Text = s;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.btnLuu.Visible = true;
            this.btnHuy.Visible = true;
            this.btnThem.Visible = false;
            this.btnSua.Visible = false;
            this.btnXoa.Visible = false;

            this.btnThoat.Visible = false;
            m_chucnang = "sua";
            lblMaNV.Focus();
            txtNhanVien.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cmbChucVu.Enabled = true;
            cmbHopDong.Enabled = true;
            cmbPhongBan.Enabled = true;
            txtTimKiem.Enabled = false;

            // cmbSoLuong.ResetText();
            //txtGiaNhap.ResetText();

            if (txtNhanVien.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnLuu.Visible = false;
                this.btnHuy.Visible = false;
                this.btnThem.Visible = true;
                this.btnSua.Visible = true;
                this.btnXoa.Visible = true;

                this.btnThoat.Visible = true;
                txtNhanVien.Enabled = false;
                txtSDT.Enabled = false;
                txtCMND.Enabled = false;
                dtpNgaySinh.Enabled = false;
                cmbChucVu.Enabled = false;
                cmbHopDong.Enabled = false;
                cmbPhongBan.Enabled = false;
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ( txtNhanVien.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            NhanVienObjTr ctdObj = new NhanVienObjTr();
            ctdObj.maNV = lblMaNV.Text;


            //nv.Luong = int.Parse(txtLuong.Text);
            //nv.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            //nv.NgaySinh = dtpNgaySinh.Value;
            //nv.MaPhongBan = cmbMaPhongBan.SelectedText;
            if (MessageBox.Show(string.Format("Xóa Nhân Viên có Mã nhân viên {0}", lblMaNV.Text), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (NhanVienCtrlTr.DeleteNhanVien(ctdObj) > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcNhanVien_Load(sender, e);

                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.btnLuu.Visible = false;
            this.btnHuy.Visible = false;
            this.btnThem.Visible = true;
            this.btnSua.Visible = true;
            this.btnXoa.Visible = true;

            this.btnThoat.Visible = true;
            txtNhanVien.Enabled = false;
            txtSDT.Enabled = false;
            txtCMND.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cmbChucVu.Enabled = false;
            cmbHopDong.Enabled = false;
            cmbPhongBan.Enabled = false;
            txtTimKiem.Enabled = true;
            try
            {
                if (m_chucnang == "them")
                {
                    if (txtNhanVien.Text == "")
                    {
                        MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        NhanVienObjTr ctdObj = new NhanVienObjTr();
                        ctdObj.maNV = lblMaNV.Text;
                        ctdObj.HoTen = txtNhanVien.Text.Trim();
                        ctdObj.NgaySinh = dtpNgaySinh.Value;
                        ctdObj.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";
                        ctdObj.SoCMND = int.Parse(txtCMND.Text.Trim());
                        ctdObj.SDT = txtSDT.Text.Trim();
                        ctdObj.MaCV = cmbChucVu.SelectedValue.ToString();
                        ctdObj.MaHD = cmbHopDong.SelectedValue.ToString();
                        ctdObj.MaPB = cmbPhongBan.SelectedValue.ToString();

                        if (MessageBox.Show(string.Format("Thêm  Nhân Viên có Mã nhân viên {0}", lblMaNV.Text), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (NhanVienCtrlTr.InsertNhanVien(ctdObj) > 0)
                            {
                                MessageBox.Show("Thêm mới thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UcNhanVien_Load(sender, e);

                            }
                            else MessageBox.Show("Mã Nhân Viên đã có,Vui Lòng Nhập Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }
                if (m_chucnang == "sua")
                {
                    if (txtNhanVien.Text == "")
                    {
                        MessageBox.Show("Chưa chọn thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {


                        NhanVienObjTr ctdObj = new NhanVienObjTr();
                        ctdObj.maNV = lblMaNV.Text;
                        ctdObj.HoTen = txtNhanVien.Text.Trim();
                        ctdObj.NgaySinh = dtpNgaySinh.Value;
                        ctdObj.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";
                        ctdObj.SoCMND = int.Parse(txtCMND.Text.Trim());
                        ctdObj.SDT = txtSDT.Text.Trim();
                        ctdObj.MaCV = cmbChucVu.SelectedValue.ToString();
                        ctdObj.MaHD = cmbHopDong.SelectedValue.ToString();
                        ctdObj.MaPB = cmbPhongBan.SelectedValue.ToString();

                        if (MessageBox.Show(string.Format("Sửa Nhân Viên có Mã nhân viên {0}", lblMaNV.Text), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (NhanVienCtrlTr.UpdateNhanVien(ctdObj) > 0)
                            {
                                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UcNhanVien_Load(sender, e);


                            }
                            else MessageBox.Show("Không Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Xảy Ra!", "Thông Báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnLuu.Visible = false;
            this.btnHuy.Visible = false;
            this.btnThem.Visible = true;
            this.btnSua.Visible = true;
            this.btnXoa.Visible = true;

            this.btnThoat.Visible = true;
            txtNhanVien.Enabled = false;
            txtSDT.Enabled = false;
            txtCMND.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cmbChucVu.Enabled = false;
            cmbHopDong.Enabled = false;
            cmbPhongBan.Enabled = false;
            txtNhanVien.ResetText();
            txtCMND.ResetText();
            txtSDT.ResetText();
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Nhập Tên Nhân Viên";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            View main = new View();
            this.Controls.Clear();
            this.Controls.Add(main);
            main.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lblMaNV.Text = dataGridView1.CurrentRow.Cells["manv"].Value.ToString();
            txtNhanVien.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
            dtpNgaySinh.Text = dataGridView1.CurrentRow.Cells["ngaysinh"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["gioitinh"].Value.ToString().Contains("Nam"))
                rbtNam.Checked = true;
            else rbtNu.Checked = true;
            txtCMND.Text = dataGridView1.CurrentRow.Cells["socmnd"].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells["sdt"].Value.ToString();
            cmbChucVu.Text = dataGridView1.CurrentRow.Cells["tencv"].Value.ToString();
            cmbHopDong.Text = dataGridView1.CurrentRow.Cells["hopdong"].Value.ToString();
            cmbPhongBan.Text = dataGridView1.CurrentRow.Cells["tenpb"].Value.ToString();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }
    

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        string str = string.Format("HoTen like '%{0}%'", txtTimKiem.Text);
        dt.DefaultView.RowFilter = str;
    }

       

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
