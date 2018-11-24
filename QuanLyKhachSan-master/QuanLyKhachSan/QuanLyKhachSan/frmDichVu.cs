using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyKhachSan
{
    public partial class frmDichVu : Form
    {
        private DichVuBUS dv = new DichVuBUS();
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dgvdichvu.DataSource = dv.DanhSachDichVu();
        }

        private void dgvdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvr = dgvdichvu.Rows[e.RowIndex];
                txtmadichvu.Text = dgvr.Cells["madichvu"].Value.ToString();
                txttendichvu.Text = dgvr.Cells["tendichvu"].Value.ToString();
                txtdongia.Text = dgvr.Cells["dongia"].Value.ToString();

            }
            catch
            {

            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvdichvu.DataSource = dv.TimKiemDichVu(txttimkiem.Text);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtmadichvu.Text == "") | (txttendichvu.Text == "") | (txtdongia.Text == ""))
                {
                    MessageBox.Show("Mời nhập dữ liệu");
                }
                else
                {
                    string madichvu = txtmadichvu.Text;
                    string tendichvu = txttendichvu.Text;
                    decimal dongia = Decimal.Parse(txtdongia.Text);
                    if (dv.ThemDichVu(madichvu, tendichvu, dongia))
                    {
                        MessageBox.Show("Thêm mới thành công");
                        frmDichVu_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi ");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string madichvu = txtmadichvu.Text;
            string tendichvu = txttendichvu.Text;
            decimal dongia = Decimal.Parse(txtdongia.Text);
            if (dv.SuaDichVu(madichvu, tendichvu, dongia))
            {
                MessageBox.Show("Sửa thành công");
                frmDichVu_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string madichvu = txtmadichvu.Text;
                if (dv.XoaDichVu(madichvu))
                {
                    MessageBox.Show("Xóa thành công!!!");
                    frmDichVu_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
