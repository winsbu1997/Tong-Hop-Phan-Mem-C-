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
    public partial class frmThietBi : Form
    {
        ThietBiBUS tbBus = new ThietBiBUS();
        public frmThietBi()
        {
            InitializeComponent();
            DanhSachThietBi();
            ThietBiBiding();
        }
        void DanhSachThietBi()
        {
            dgvThietBi.DataSource = tbBus.DanhSachThietBi();
        }
        void ThietBiBiding()
        {
            txtMaTb.DataBindings.Clear();
            txtMaTb.DataBindings.Add(new Binding("Text", dgvThietBi.DataSource, "Mathietbi", true, DataSourceUpdateMode.Never));
            txtTenTB.DataBindings.Clear();
            txtTenTB.DataBindings.Add(new Binding("Text", dgvThietBi.DataSource, "Tenthietbi", true, DataSourceUpdateMode.Never));
            txtSoLuongTb.DataBindings.Clear();
            txtSoLuongTb.DataBindings.Add(new Binding("Text", dgvThietBi.DataSource, "Soluong", true, DataSourceUpdateMode.Never));
            txtGiaTB.DataBindings.Clear();
            txtGiaTB.DataBindings.Add(new Binding("Text", dgvThietBi.DataSource, "Giathietbi", true, DataSourceUpdateMode.Never));

        }
        private void btnThemTB_Click(object sender, EventArgs e)
        {
            string mathietbi = tbBus.SinhMaThietBiPhong();
            string tenthietbi = txtTenTB.Text;
            decimal giathietbi = Decimal.Parse(txtGiaTB.Text);
            int soluong = Int32.Parse(txtSoLuongTb.Text);
            if (mathietbi.ToString() != "" && tenthietbi.ToString() != "" && giathietbi.ToString() != "" && soluong.ToString() != "")
            {
                if (tbBus.ThemThietBi(mathietbi, tenthietbi, giathietbi, soluong))
                {
                    MessageBox.Show("Thêm mới thành công");
                    DanhSachThietBi();
                    ThietBiBiding();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm ");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập dữ liệu!");
            }
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa nó", "Thông báo!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string mathietbi = txtMaTb.Text;
                string tenthietbi = txtTenTB.Text;
                decimal giathietbi = Decimal.Parse(txtGiaTB.Text);
                int soluong = Int32.Parse(txtSoLuongTb.Text);
                if (tbBus.SuaThietBi(mathietbi, tenthietbi, giathietbi, soluong))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Sửa");
                }
                DanhSachThietBi();
                ThietBiBiding();
            }
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa nó?? ";
            string caption = "Thông báo!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string mathietbi = txtMaTb.Text;
                if (tbBus.XoaThietBi(mathietbi))
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
                DanhSachThietBi();
                ThietBiBiding();
            }
        }
        private void txtTimKiemTB_TextChanged(object sender, EventArgs e)
        {
            dgvThietBi.DataSource = tbBus.TimKiemThietBi(txtTimKiemTB.Text);
            ThietBiBiding();
        }
    }
}
