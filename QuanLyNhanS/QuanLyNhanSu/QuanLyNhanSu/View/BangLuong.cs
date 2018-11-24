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

namespace QuanLyNhanSu.View
{
    public partial class BangLuong : UserControl
    {
        BangLuongCtrlH bang = new BangLuongCtrlH();
        DataTable dtLuong = new DataTable();
        DataTable dtKT = new DataTable();
        DataTable dtKL = new DataTable();
        private string makt, makl, manv, nam, thang;
        public BangLuong()
        {
            InitializeComponent();
        }

        private void BangLuong_Load(object sender, EventArgs e)
        {
            nudThang.Value = DateTime.Today.Month;
            nudNam.Value = DateTime.Today.Year;
            nudNam.Maximum = DateTime.Today.Year;
            dtKT = bang.GetData("select MaKT, NoiDung, QuyDoiRaTienMat from KhenThuong");
            dtKL = bang.GetData("select MaKL, NguyenNhan, QuyDoiRaTienMat from KyLuat");
            dgvKhenThuong.DataSource = dtKT;
            dgvKyLuat.DataSource = dtKL;
            enable(false);

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            enable(false);
            thang = nudThang.Value.ToString();
            nam = nudNam.Value.ToString();
            DataTable dt = bang.GetData("select Thang, Nam from BangLuong where Thang=" + thang + " and Nam=" + nam + "");
            if (dt.Rows.Count > 0)
            {
                string s = "select NhanVien.MaNV, HoTen,LuongCB, LuongTangCa, SoGioTangCa, MaKL, MaKT, Tong from NhanVien, BangLuong  where BangLuong.MaNV = NhanVien.MaNV and Thang="+thang+" and Nam="+nam+"";
                dtLuong = bang.GetData(s);
            }
            else
            {
                dt = bang.GetData("select MaNV from NhanVien");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string s = "declare @luongcoban float, @luongtc float " +
                                        "select @luongcoban = LuongCB from HeSoLuong, HopDong, NhanVien " +
                                        "where NhanVien.mahd = HopDong.MaHD and hopdong.BacLuong = HeSoLuong.BacLuong and MaNV = '" + dr["MaNV"].ToString() + "' " +
                                        "select @luongtc = LuongTangCa from HeSoLuong, HopDong, NhanVien " +
                                        "where NhanVien.mahd = HopDong.MaHD and hopdong.BacLuong = HeSoLuong.BacLuong and MaNV = '" + dr["MaNV"].ToString() + "' " +
                                        "insert into BangLuong values('" + dr["MaNV"].ToString() + "', '" + thang + "', '" + nam + "', @luongcoban, @luongtc, 0, null, null, @luongcoban) ";
                        bang.ThucHienLenh(s);
                    }
                }
                MessageBox.Show("Tính toán thành công");
                dtLuong = bang.GetData("select NhanVien.MaNV, HoTen,LuongCB, LuongTangCa, SoGioTangCa, MaKL, MaKT, Tong from NhanVien, BangLuong  where BangLuong.MaNV = NhanVien.MaNV and Thang="+thang+" and Nam="+nam+"");
            }
            dgvLuong.DataSource = dtLuong;
            
            
        }

        private void enable(bool e)
        {
            txtNhanVien.ReadOnly = !e;
            txtLuongTangCa.ReadOnly = !e;
            nudGioTangCa.ReadOnly = !e;
            txtLuongCoBan.ReadOnly = !e;
            txtKhenThuong.ReadOnly = !e;
            txtTienKhenThuong.ReadOnly = !e;
            txtKyLuat.ReadOnly = !e;
            txtTienKyLuat.ReadOnly = !e;
            btnSua.Enabled = e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtLuong.Rows.Count > 0)
            {
                string str = string.Format("MaNV like '%{0}%' or HoTen like '%{1}%'", txtTimKiem.Text, txtTimKiem.Text);
                dtLuong.DefaultView.RowFilter = str;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable(true);
            btnSua.Enabled = false;
            txtNhanVien.ReadOnly = true;
            txtTienKhenThuong.ReadOnly = true;
            txtTienKyLuat.ReadOnly = true;
            txtKhenThuong.Select();
            dgvLuong.Enabled = false;
        }
        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtLuong.Rows.Count > 0)
            {
                txtNhanVien.Text = dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[1].Value.ToString();
                txtLuongCoBan.Text = dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[2].Value.ToString();
                txtLuongTangCa.Text = dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[3].Value.ToString();
                manv = dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[0].Value.ToString();
                if (dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[4].Value != null)
                    nudGioTangCa.Text = dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[4].Value.ToString();
                else
                    nudGioTangCa.Text = "0";
                if (dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[6].Value.ToString() != "")
                {
                    txtKhenThuong.Text = dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[6].Value.ToString();
                    txtTienKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[2].Value.ToString();
                    txtKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[1].Value.ToString();
                    dgvKhenThuong.Visible = false;
                }
                else
                {
                    txtKhenThuong.Text = "";
                    txtTienKhenThuong.Text = "";
                    dgvKhenThuong.Visible = false;
                }
                if (dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[5].Value.ToString() != "")
                {
                    txtKyLuat.Text = dgvLuong.Rows[dgvLuong.CurrentRow.Index].Cells[5].Value.ToString();
                    txtTienKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[2].Value.ToString();
                    txtKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[1].Value.ToString();
                    dgvKyLuat.Visible = false;
                }
                else
                {
                    txtKyLuat.Text = "";
                    txtTienKyLuat.Text = "";
                    dgvKyLuat.Visible = false;
                }
                btnSua.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnTraCuu_Click(sender, e);
            dgvLuong.Enabled = true;
            dgvKhenThuong.Visible = false;
            dgvKyLuat.Visible = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvKhenThuong.Rows.Count != 1)
                makt = "null";
            else
            {
                makt = dgvKhenThuong.SelectedRows[0].Cells[0].Value.ToString();
            }
            if (dgvKyLuat.Rows.Count != 1)
                makl = "null";
            else
            {
                makl = dgvKyLuat.SelectedRows[0].Cells[0].Value.ToString();
            }
            if (makt == "null")
            {
                if (makl == "null")
                {
                    bang.ThucHienLenh("update BangLuong set LuongCB = '" + txtLuongCoBan.Value + "', LuongTangCa ='" + txtLuongTangCa.Value + "', SoGioTangCa='" + nudGioTangCa.Value + "', MaKT=null,MaKL=null,Tong=" + (float.Parse(txtLuongTangCa.Value.ToString()) * float.Parse(nudGioTangCa.Value.ToString()) + float.Parse(txtLuongCoBan.Value.ToString())).ToString() + " where MaNV = '"+manv+"' and Thang="+thang+" and Nam="+nam+"");
                }
                else
                {
                    bang.ThucHienLenh("update BangLuong set LuongCB = '" + txtLuongCoBan.Value + "', LuongTangCa ='" + txtLuongTangCa.Value + "', SoGioTangCa='" + nudGioTangCa.Value + "', MaKT=null,MaKL='" + makl+"',Tong=" + (float.Parse(txtLuongTangCa.Value.ToString()) * float.Parse(nudGioTangCa.Value.ToString()) + float.Parse(txtLuongCoBan.Value.ToString()) - float.Parse(txtTienKyLuat.Text)).ToString() + " where MaNV = '" + manv + "' and Thang=" + thang + " and Nam=" + nam + "");
                }
            }
            else if (makl == "null")
            {
                string s = "update BangLuong set LuongCB = '" + txtLuongCoBan.Value + "', LuongTangCa ='" + txtLuongTangCa.Value + "', SoGioTangCa='" + nudGioTangCa.Value + "', MaKT='" + makt + "',MaKL=null ,Tong=" + (float.Parse(txtLuongTangCa.Value.ToString()) * float.Parse(nudGioTangCa.Value.ToString()) + float.Parse(txtLuongCoBan.Value.ToString()) + float.Parse(txtTienKhenThuong.Text)).ToString() + " where MaNV = '" + manv + "' and Thang=" + thang + " and Nam=" + nam + "";
                bang.ThucHienLenh(s);
            }
            else
            {
                bang.ThucHienLenh("update BangLuong set LuongCB = '" + txtLuongCoBan.Value + "', LuongTangCa ='" + txtLuongTangCa.Value + "', SoGioTangCa='" + nudGioTangCa.Value + "', MaKT='" + makt + "',MaKL='" + makl + "',Tong=" + (float.Parse(txtLuongTangCa.Value.ToString()) * float.Parse(nudGioTangCa.Value.ToString()) + float.Parse(txtLuongCoBan.Value.ToString()) - float.Parse(txtTienKyLuat.Text) + float.Parse(txtTienKhenThuong.Text)).ToString() + " where MaNV = '" + manv + "' and Thang=" + thang + " and Nam=" + nam + "");
            }
            MessageBox.Show("Thành công");
            dgvLuong.Enabled = true;
            dgvKhenThuong.Visible = false;
            dgvKyLuat.Visible = false; 
            btnTraCuu_Click(sender, e);

        }

        private void txtKhenThuong_TextChanged(object sender, EventArgs e)
        {
            if (dtKT.Rows.Count > 0)
            {
                dgvKhenThuong.Visible = true;
                string str = string.Format("MaKT like '%{0}%' or NoiDung like '%{1}%' ", txtKhenThuong.Text.Trim(), txtKhenThuong.Text.Trim());
                dtKT.DefaultView.RowFilter = str;
            }
        }

        private void txtKyLuat_TextChanged(object sender, EventArgs e)
        {
            if (dtKL.Rows.Count > 0)
            {
                dgvKyLuat.Visible = true;
                string str = string.Format("MaKL like '%{0}%' or NguyenNhan like '%{1}%' ", txtKyLuat.Text.Trim(), txtKyLuat.Text.Trim());
                dtKL.DefaultView.RowFilter = str;
            }
        }

        private void dgvKhenThuong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhenThuong.Rows.Count > 0)
            {
                txtTienKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[2].Value.ToString();
                txtKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[1].Value.ToString();
                makt = dgvKhenThuong.SelectedRows[0].Cells[0].Value.ToString();
                dgvKhenThuong.Visible = false;
            }
        }

        private void dgvKyLuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKyLuat.Rows.Count > 0)
            {
                txtTienKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[2].Value.ToString();
                txtKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[1].Value.ToString();
                makl = dgvKyLuat.SelectedRows[0].Cells[0].Value.ToString();
                dgvKyLuat.Visible = false;
            }
        }

        private void dgvKhenThuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvKhenThuong.Rows.Count > 0)
            {
                if (e.KeyData == Keys.Enter)
                {
                    txtTienKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[2].Value.ToString();
                    txtKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[1].Value.ToString();
                    makt = dgvKhenThuong.SelectedRows[0].Cells[0].Value.ToString();
                    dgvKhenThuong.Visible = false;
                }
            }
        }

        private void dgvKyLuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvKyLuat.Rows.Count > 0)
            {
                if (e.KeyData == Keys.Enter)
                {
                    txtTienKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[2].Value.ToString();
                    txtKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[1].Value.ToString();
                    makl = dgvKyLuat.SelectedRows[0].Cells[0].Value.ToString();
                    dgvKyLuat.Visible = false;
                }
            }
        }

        private void dgvKhenThuong_Leave(object sender, EventArgs e)
        {
            dgvKhenThuong.Visible = false;
        }

        private void txtKhenThuong_Leave(object sender, EventArgs e)
        {
            dgvKhenThuong.Select();
        }

        private void txtKyLuat_Leave(object sender, EventArgs e)
        {
            dgvKyLuat.Select();
        }

        private void txtKhenThuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                dgvKhenThuong.Visible = false;
                txtKhenThuong.Clear();
            }
            if (e.KeyData == Keys.Enter)
            {
                if (dgvKhenThuong.Rows.Count > 0)
                {
                    txtTienKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[2].Value.ToString();
                    txtKhenThuong.Text = dgvKhenThuong.SelectedRows[0].Cells[1].Value.ToString();
                    makt = dgvKhenThuong.SelectedRows[0].Cells[0].Value.ToString();
                    dgvKhenThuong.Visible = false;
                }
                else
                {
                    dgvKhenThuong.Visible = false;
                    txtKhenThuong.Clear();
                }
            }
        }

        private void txtKyLuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                dgvKyLuat.Visible = false;
                txtKyLuat.Clear();
            }
            if (e.KeyData == Keys.Enter)
            {
                if (dgvKyLuat.Rows.Count > 0)
                {
                    txtTienKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[2].Value.ToString();
                    txtKyLuat.Text = dgvKyLuat.SelectedRows[0].Cells[1].Value.ToString();
                    makl = dgvKyLuat.SelectedRows[0].Cells[0].Value.ToString();
                    dgvKyLuat.Visible = false;
                }
                else
                {
                    dgvKyLuat.Visible = false;
                    txtKyLuat.Clear();
                }
            }
        }

        private void dgvKyLuat_Leave(object sender, EventArgs e)
        {
            dgvKyLuat.Visible = false;
        }
    }
}
