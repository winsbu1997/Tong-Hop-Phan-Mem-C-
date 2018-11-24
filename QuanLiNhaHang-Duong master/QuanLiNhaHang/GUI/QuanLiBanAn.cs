using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.GUI
{
    public partial class QuanLiBanAn : UserControl
    {
        int flag;
        public QuanLiBanAn()
        {
            InitializeComponent();
        }
        public static QuanLiBanAn uct_BA = new QuanLiBanAn();

        #region Method
        public void HienThiDanhSachBA()
        {
            dgvBanAnMain.DataSource = Model.BanAnMod.FillDataSetBanAn().Tables[0];
        }
        public void Binding()
        {
            txtMaBA.DataBindings.Clear();
            txtMaBA.DataBindings.Add("Text", dgvBanAnMain.DataSource, "MaBA", true);
            cbxMaHDB.DataBindings.Clear();
            cbxMaHDB.DataBindings.Add("Text", dgvBanAnMain.DataSource, "MaHDB", true);
            txtSoCho.DataBindings.Clear();
            txtSoCho.DataBindings.Add("Text", dgvBanAnMain.DataSource, "SoCho", true);
            cbxTrangThai.DataBindings.Clear();
            cbxTrangThai.DataBindings.Add("Text", dgvBanAnMain.DataSource, "TrangThai", true);
            cbxViTri.DataBindings.Clear();
            cbxViTri.DataBindings.Add("Text", dgvBanAnMain.DataSource, "ViTri", true);
        }
        void LoadControl()
        {
            cbxTrangThai.Items.Clear();
            cbxTrangThai.Items.Add("Có Khách");
            cbxTrangThai.Items.Add("Trống");
            cbxTrangThai.Items.Add("Đã Đặt Chỗ");
            cbxMaHDB.DataSource = Model.Connection.FillDataTable("SELECT DISTINCT MaHDB FROM dbo.BanAn");       
            cbxMaHDB.ValueMember = "MaHDB";
            cbxMaHDB.DisplayMember = "MaHDB";        
                       
            cbxViTri.Items.Clear();
            cbxViTri.Items.Add("Tầng 1");
            cbxViTri.Items.Add("Tầng 2");
            cbxViTri.Items.Add("Tầng thượng");
        }

        private void Dis_End(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnCapNhat.Enabled = e;
            btnThoat.Enabled = e;
        }
        private void clearData()
        {
            txtMaBA.Text = Model.Connection.ExcuteScalar(string.Format("select MaBA = dbo.fcgetIdBanAn()"));
            txtSoCho.Value = 6;
            cbxViTri.Text = "";
        }

        private void QuanLiBanAn_Load(object sender, EventArgs e)
        {
            LoadControl();
            txtMaBA.Enabled = false;
            HienThiDanhSachBA();           
            Binding();
            Dis_End(false);
        }
        #endregion

        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            Dis_End(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_End(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaBA = "";
            try
            {
                _MaBA = txtMaBA.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controller.BanAnCtr.DeleteBanAn(_MaBA);
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");
                    HienThiDanhSachBA();
                    Binding();
                    Dis_End(false);
                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _MaBA = txtMaBA.Text;
            string _MaHDB = "";
            try
            {
                _MaHDB = cbxMaHDB.Text;

            }
            catch { }

            int _SoCho = 0;
            try
            {
                _SoCho = (int)txtSoCho.Value;
            }
            catch { }

            string _TrangThai = "";
            try
            {
                _TrangThai = cbxTrangThai.Text;
            }
            catch { }
            string _ViTri = "";
            try
            {
                _ViTri = cbxViTri.Text;
            }
            catch { }

            if (flag == 0)
            {
                int i = 0;
                if(_MaHDB == "" && _TrangThai == "Trống")
                {
                    MessageBox.Show("dbo.insertBanAn @MaBA = '" + _MaBA + "',@MaHDB = " + "NULL" + ",@SoCho = " + _SoCho + ",@TrangThai = N'" + _TrangThai + "',@ViTri = N'" + _ViTri + "'");
                    i = Model.Connection.Excute_Sql("dbo.insertBanAn @MaBA = '"+ _MaBA + "',@MaHDB = " + "NULL" + ",@SoCho = "+ _SoCho +",@TrangThai = N'" + _TrangThai+ "',@ViTri = N'" + _ViTri +"'");
                }
                else
                {
                    i = Controller.BanAnCtr.InsertBanAn(_MaBA, _MaHDB, _SoCho, _TrangThai, _ViTri);
                }                
                if (i == 0)
                {
                    MessageBox.Show("Thêm mới thất bại !");
                }
                else
                {
                    MessageBox.Show("Thêm mới thành công !");
                    txtMaBA.Enabled = false;
                    HienThiDanhSachBA();
                    Binding();
                    Dis_End(false);
                }
            }
            else
            {
                int i = 0;
                if (_MaHDB == "" && _TrangThai == "Trống")
                {
                    i = Model.Connection.Excute_Sql("dbo.updateBanAn @MaBA = '" + _MaBA + "',@MaHDB = " + "NULL" + ",@SoCho = " + _SoCho + ",@TrangThai = N'" + _TrangThai + "',@ViTri = N'" + _ViTri + "'");
                }
                else
                {
                    i = Controller.BanAnCtr.UpdateBanAn(_MaBA, _MaHDB, _SoCho, _TrangThai, _ViTri);
                }
                if (i == 0)
                {
                    MessageBox.Show("Sửa thất bại !");
                }
                else
                {
                    MessageBox.Show("Sửa thành công !");
                    txtMaBA.Enabled = false;
                    HienThiDanhSachBA();
                    Binding();
                    Dis_End(false);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtMaBA.Enabled = false;
            HienThiDanhSachBA();
            Binding();
            Dis_End(false);
        }
        #endregion

        
    }
}
