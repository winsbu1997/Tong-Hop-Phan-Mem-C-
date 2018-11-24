using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace QuanLiNhaHang.GUI
{
    public partial class ThucDon : UserControl
    {
        #region Properties
        int flag = 0;
        string FileName = "";
        public static ThucDon uct_MonAn = new ThucDon();
        public ThucDon()
        {
            InitializeComponent();
        }

        #endregion

        #region Method    
        void Dis_End(bool e)
        {
            btnThemMA.Enabled = e;
            btnSuaMA.Enabled = e;
            btnXoaMA.Enabled = e;
            btnLuuMA.Enabled = !e;
            btnHuyMA.Enabled = !e;
            dgvMonAnMain.Enabled = e;
        }  
        void ClearData()
        {
            txtMaMA.Text = Model.Connection.ExcuteScalar(string.Format("select STTMA = dbo.fcgetIdMonAn()"));
            txtDonViTnh.Text = "";
            txtTenMA.Text = "";
            txtDonGia.Value = 0;
            ptbMonAn.Image = null;
        } 

        void Dis_EndNM(bool e)
        {
            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;
            dgvNhomMonMain.Enabled = e;
            btnLuu.Enabled = !e;
            btnHuy.Enabled = !e;
        }
        void ClearDataNM()
        {
            txtMaNM.Text = Model.Connection.ExcuteScalar(string.Format("select MaNM = dbo.fcgetIdNhomMon()"));
            txtTenNM.Text = "";
        }
        void UpgradeMonAn()
        {
            dgvMonAn.ActiveFilterString = "[MaNM]= '" + txtMaNM.Text + "'";
        }

        #endregion

        #region Loadform
        void LoadMonAn()
        {
            dgvMonAnMain.DataSource = Model.MonAnMod.FillDataSetMonAn().Tables[0];
            txtMaMA.DataBindings.Clear();
            txtMaMA.DataBindings.Add("Text", dgvMonAnMain.DataSource, "STTMA", true);
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvMonAnMain.DataSource, "DonGia", true);
            txtDonViTnh.DataBindings.Clear();
            txtDonViTnh.DataBindings.Add("Text", dgvMonAnMain.DataSource, "DonViTinh", true);
            txtTenMA.DataBindings.Clear();
            txtTenMA.DataBindings.Add("Text", dgvMonAnMain.DataSource, "TenMA", true);
            ptbMonAn.DataBindings.Clear();
            ptbMonAn.DataBindings.Add("Image", dgvMonAnMain.DataSource, "HinhAnh", true);

        }
        void LoadNhomMon()
        {
            dgvNhomMonMain.DataSource = Model.NhomMonMod.FillDataSetNhomMon().Tables[0];
            txtMaNM.DataBindings.Clear();
            txtMaNM.DataBindings.Add("Text", dgvNhomMonMain.DataSource, "MaNM");
            txtTenNM.DataBindings.Clear();
            txtTenNM.DataBindings.Add("Text", dgvNhomMonMain.DataSource, "TenNM");
        }
        private void ThucDon_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            LoadNhomMon();
            Dis_End(true);
            Dis_EndNM(true);
            ptbMonAn.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            UpgradeMonAn();
        }

        #endregion

        #region Events

        private void btnThayDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files|*.*";
            file.ShowDialog();
            FileName = file.FileName.ToString();
            try
            {
                ptbMonAn.Image = Image.FromFile(FileName);
               
                ptbMonAn.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
            catch
            {
                MessageBox.Show("Load ảnh lỗi");
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            ptbMonAn.Image = null;
        }
        #region MonAn
        private void btnThemMA_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_End(false);
            ClearData();
        }

        private void btnSuaMA_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_End(false);

        }

        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            string _STTMA = "";
            try
            {
                _STTMA = txtMaMA.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controller.MonAnCtr.DeleteMonAn(_STTMA);
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");
                    LoadMonAn();
                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btnLuuMA_Click(object sender, EventArgs e)
        {
            string _STTMA = "";
            try
            {
                _STTMA = txtMaMA.Text;
            }
            catch { }

            string _TenMA = "";
            try
            {
                _TenMA = txtTenMA.Text;
            }
            catch { }

            string _MaNM = "";
            try
            {
                _MaNM = txtMaNM.Text;
            }
            catch { }

            string _DonViTinh = "";
            try
            {
                _DonViTinh = txtDonViTnh.Text;
            }
            catch { }

            int _DonGia = 0;
            try
            {
                _DonGia = Convert.ToInt32(txtDonGia.Value);
            }
            catch { }

            Byte[] _HinhAnh = null;
            using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                _HinhAnh = new Byte[fs.Length];
                fs.Read(_HinhAnh, 0, (int)fs.Length);
            }
            if (flag == 0)
            {
                int i = 0;
                i = Controller.MonAnCtr.InsertMonAn(_STTMA,_TenMA, _DonGia, _MaNM, _DonViTinh, _HinhAnh);
                if(i > 0)
                {
                    MessageBox.Show("Thêm mới thành công !");
                    LoadMonAn();
                    Dis_End(true);
                }
                else
                {
                    MessageBox.Show("Them moi that bai");
                }
            }
            else
            {
                int i = 0;
                i = Controller.MonAnCtr.UpdateMonAn(_STTMA, _TenMA, _DonGia, _MaNM, _DonViTinh, _HinhAnh);
                if (i > 0)
                {
                    MessageBox.Show("Sua thành công !");
                    Dis_End(true);
                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
            }
        }

        private void btnHuyMA_Click(object sender, EventArgs e)
        {
            Dis_End(true);
        }
        #endregion


        #region NhomMon

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_EndNM(true);
            LoadNhomMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _MaNM = "";
            try
            {
                _MaNM = txtMaNM.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show(" Bạn có chắc chắn xóa ?", "Xác nhận ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controller.NhomMonCtr.DeleteNhomMon(_MaNM);
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công !");
                    LoadNhomMon();
                }
                else
                    MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearDataNM();
            flag = 0;
            Dis_EndNM(false);
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _MaNM = "";
            try
            {
                _MaNM = txtMaNM.Text;
            }
            catch { }
            string _TenNM = "";
            try
            {
                _TenNM = txtTenNM.Text;
            }
            catch { }

            if(flag == 0)
            {
                int i = 0;
                i = Controller.NhomMonCtr.InsertNhomMon(_MaNM,_TenNM);
                if (i > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    LoadNhomMon();
                    ClearData();
                    Dis_EndNM(true);
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controller.NhomMonCtr.UpdateNhomMon(_MaNM, _TenNM);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    Dis_EndNM(true);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            UpgradeMonAn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_EndNM(false);
        }
        #endregion

        #region SukienNgam

        private void dgvNhomMon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpgradeMonAn();
        }

        private void dgvNhomMon_DataSourceChanged(object sender, EventArgs e)
        {
            UpgradeMonAn();
        }

        private void dgvNhomMon_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            int index = dgvNhomMon.GetFocusedDataSourceRowIndex();
            dgvNhomMon.SetRowCellValue(index,"TenNM", txtTenNM.Text);
        }
        #endregion

        #endregion
    }
}
