using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System.Threading;

namespace QuanLiNhaHang.GUI
{
    public partial class GoiMon : UserControl
    {
        public delegate void SendText(string MaKH);
        public SendText Sender;
        public GoiMon()
        {
            InitializeComponent();
            cbxKhachHang.Enabled = false;
            Sender = new SendText(GetText);
        }

        private void GetText(string MaKH)
        {
            cbxKhachHang.DataSource = Controller.KhachHangCtr.FillDataSet_SearchKhachHangbyMaKH(MaKH).Tables[0];
            cbxKhachHang.DisplayMember = "TenKH";
            cbxKhachHang.ValueMember = "MaKH";
        }

        #region Properties
        public static GoiMon uct_gm = new GoiMon();
        int flag = 0;
        int soluong = 0;
        int inhd = 0;
        int thanhtien = 0;
        #endregion

        #region LoadForm
        private void GoiMon_Load(object sender, EventArgs e)
        {
            btnnen.Visible = false;
            Dis_End(false);
            LoadBanAn();
            cbxViTri.Items.Add("Tầng 1");
            cbxViTri.Items.Add("Tầng 2");
            cbxViTri.Items.Add("Tầng thượng");
            DataTable dt = Model.Connection.FillDataTable(" SELECT DISTINCT MaHDB FROM dbo.BanAn");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MaHDB"].ToString() != "") cbxMaHDB.Items.Add(dt.Rows[i]["MaHDB"].ToString());
            }
        }
        public void LoadBanAn()
        {
            Dis_End(false);
            pnlDSBanAn.Controls.Clear();
            List<Model.BanAnMod> listBA = Controller.BanAnCtr.DanhSachBanAn();
            int i = 1;
            foreach (Model.BanAnMod item in listBA)
            {
                Button btnBanAn = new Button() { Width = Controller.BanAnCtr.TableWidth, Height = Controller.BanAnCtr.TableHeight, BackgroundImageLayout = ImageLayout.Center };
                btnBanAn.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Bàn ăn " + i++;
                btnBanAn.Tag = item;
                btnBanAn.FlatStyle = FlatStyle.Standard;
                btnBanAn.Click += BtnBanAn_Click;
                btnBanAn.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\tray.png");

                switch (item.TrangThai)
                {
                    case "Trống":
                        btnBanAn.BackColor = Color.Aqua;
                        break;
                    case "Có Khách":
                        btnBanAn.BackColor = Color.Red;
                        break;
                    default:
                        btnBanAn.BackColor = Color.Lime;
                        break;
                }
                pnlDSBanAn.Controls.Add(btnBanAn);

            }
        }
        void LoadNhomMon()
        {
            int[] mau = { -5952982, -10039894, -70077677, -40121, -16711936, -16711681, -256, -16744448 };
            pnlNhomMon.Controls.Clear();
            List<Model.NhomMonMod> ListNM = Controller.NhomMonCtr.DanhSachNhomMon();
            int i = 0;
            foreach (Model.NhomMonMod item in ListNM)
            {
                Button btnNM = new Button() { Width = 150, Height = 80 };
                btnNM.Text = item.TenNM;
                btnNM.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnNM.Tag = item;
                btnNM.FlatStyle = FlatStyle.Standard;
                btnNM.BackColor = Color.FromArgb(mau[i % 8]);
                i++;

                btnNM.Click += BtnNM_Click;
                pnlNhomMon.Controls.Add(btnNM);
            }
        }
        void LoadMonAn(string _MaNM)
        {

            pnlMonAn.Controls.Clear();
            List<Model.MonAnMod> listMA = Controller.MonAnCtr.DanhSachMonAn(_MaNM);
            foreach (Model.MonAnMod item in listMA)
            {
                Button btnMA = new Button() { Width = Controller.MonAnCtr.FoodWidth, Height = Controller.MonAnCtr.FoodHeight };
                btnMA.Text = item.TenMA + Environment.NewLine + item.DonGia.ToString() + "VND / " + item.DonViTinh;
                btnMA.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnMA.Tag = item;
                btnMA.BackColor = Color.Khaki;
                btnMA.FlatStyle = FlatStyle.Flat;
                btnMA.ForeColor = Color.Red;
                btnMA.Click += BtnMA_Click;
                pnlMonAn.Controls.Add(btnMA);
            }

        }
        void LoadChiTietBan()
        {
            dgvChiTietBanMain.DataSource = Controller.ChiTietBanCtr.SearchChiTietBanbyMaHDB(cbxMaHDB.Text).Tables[0];
            RepositoryItemLookUpEdit riMaHDB = new RepositoryItemLookUpEdit();
            riMaHDB.DataSource = Model.MonAnMod.FillDataSetMonAn().Tables[0];

            riMaHDB.DisplayMember = "TenMA";
            riMaHDB.ValueMember = "STTMA";

            dgvChiTietBan.Columns["STTMA"].ColumnEdit = riMaHDB;
            TinhTongTien();
        }
        #endregion

        #region Method
        void Dis_End(bool e)
        {
            btnnen.Visible = e;
            pnlGoiMon.Visible = e;
            pnlDatHuyMon.Visible = e;
            pnlChiTietBan.Visible = e;
            pnlNhomMon.Visible = e;
            pnlMonAn.Visible = e;
        }
        void TinhTongTien()
        {
            int tong = 0;
            for (int i = 0; i < dgvChiTietBan.RowCount; i++)
            {
                try
                {
                    tong += Convert.ToInt32(dgvChiTietBan.GetRowCellValue(i, "ThanhTien"));
                }
                catch { }
            }
            txtTongTien.Text = (tong - tong * Convert.ToInt32(txtGiamGia.Value) / 100).ToString();
        }
        void ClearData()
        {
            cbxMaHDB.Text = Model.Connection.ExcuteScalar(string.Format("select MaHDB = dbo.fcgetIdHoaDonBan()"));
            cbxKhachHang.Text = "";
            cbxNhanVien.Text = "";
            txtTongTien.Text = "";

        }

        #endregion

        #region Events

        private void BtnBanAn_Click(object sender, EventArgs e)
        {           
            btnGoiMon.Enabled = true;
            Dis_End(false);
            txtTrangThai.Text = ((sender as Button).Tag as Model.BanAnMod).TrangThai;
            cbxViTri.Text = ((sender as Button).Tag as Model.BanAnMod).ViTri;
            string MaHDB = ((sender as Button).Tag as Model.BanAnMod).MaHDB;
            cbxViTri.Tag = ((sender as Button).Tag as Model.BanAnMod).MaBA;

            pnlGoiMon.Visible = true;
            pnlDatHuyMon.Visible = true;
            string s = "";
            if ((sender as Button).BackColor == Color.Aqua) s = (sender as Button).Text.Trim();
            else
            {
                DataTable xxx = Model.Connection.FillDataTable("SELECT MaBA FROM dbo.BanAn WHERE MaHDB = '" + MaHDB + "'");
                for (int i = 0; i < xxx.Rows.Count; i++)
                {
                    s += "Bàn ăn " + Convert.ToInt32(xxx.Rows[i]["MaBA"].ToString().Substring(2)).ToString() + " ";
                }
            }
            pnlDatHuyMon.Text = s;
            btnThanhToan.Tag = pnlDatHuyMon.Text;
            cbxNhanVien.DataSource = Model.NhanVienMod.FillDataSetNhanVien().Tables[0];
            cbxNhanVien.ValueMember = "MaNV";
            cbxNhanVien.DisplayMember = "TenNV";

            if (txtTrangThai.Text == "Có Khách" || txtTrangThai.Text == "Đã Đặt Chỗ")
            {
                ToolTip tip = new ToolTip() { IsBalloon = true };

                cbxKhachHang.DataSource = Model.KhachHangMod.FillDataSetKhachHang().Tables[0];
                cbxKhachHang.DisplayMember = "TenKH";
                cbxKhachHang.ValueMember = "MaKH";
                pnlChiTietBan.Visible = true;
                cbxMaHDB.Text = MaHDB;
                LoadChiTietBan();

                DataTable dt = Controller.HoaDonBanCtr.FillDatasetHDBbyMaHDB(cbxMaHDB.Text).Tables[0];
                cbxNhanVien.SelectedValue = dt.Rows[0]["MaNV"].ToString();
                cbxKhachHang.SelectedValue = dt.Rows[0]["MaKH"].ToString();

                dtpTime.Value = (DateTime)dt.Rows[0]["NgayBan"];
                btnDatCho.Enabled = false;
                if (txtTrangThai.Text == "Đã Đặt Chỗ")
                {
                    DateTime tzanDat = (DateTime)Model.Connection.docGiaTri("SELECT NgayBan FROM dbo.HoaDonBan WHERE MaHDB = '" + MaHDB + "'");
                    TimeSpan ss = tzanDat.Subtract(DateTime.Now);
                    string time = ss.Days.ToString() + "ngay " + ss.Hours.ToString() + "h " + ss.Minutes.ToString() + "m " + ss.Seconds.ToString() + "s";
                    tip.SetToolTip(sender as Button, "Thời gian còn lại là: " + time);
                    btnGoiMon.Text = "Đặt Món";
                    btnDatCho.Text = "Vào Bàn";
                    btnDatCho.Enabled = true;
                }
                else
                {
                    DateTime tzanDat = (DateTime)Model.Connection.docGiaTri("SELECT NgayBan FROM dbo.HoaDonBan WHERE MaHDB = '" + MaHDB + "'");
                    TimeSpan ss = DateTime.Now.Subtract(tzanDat);
                    string time = ss.Hours.ToString() + "h " + ss.Minutes.ToString() + "m " + ss.Seconds.ToString() + "s";
                    tip.SetToolTip(sender as Button, "Thời gian vào bàn được : " + time);
                }

                TinhTongTien();
            }
            else
            {
                dtpTime.Value = DateTime.Now;
                btnDatCho.Text = "Đặt Chỗ";
                ClearData();
                pnlChiTietBan.Visible = false;
                dgvChiTietBanMain.DataSource = null;
                btnDatCho.Enabled = true;
            }
        }
        private void BtnNM_Click(object sender, EventArgs e)
        {
            string _MaHDB = "";
            try
            {
                _MaHDB = cbxMaHDB.Text;
            }
            catch { }

            DateTime _NgayBan = dtpTime.Value;

            int _TongTien = 0;
            try
            {
                _TongTien = Convert.ToInt32(txtTongTien.Text);
            }
            catch { }

            string _MaNV = "";
            try
            {
                _MaNV = cbxNhanVien.SelectedValue.ToString();
            }
            catch { }

            string _MaKH = "";
            try
            {
                _MaKH = cbxKhachHang.SelectedValue.ToString();
            }
            catch { }

            int _GiamGia = 0;
            try
            {
                _GiamGia = Convert.ToInt32(txtGiamGia.Value);
            }
            catch { }
            if (txtTrangThai.Text == "Trống" || txtTrangThai.Text == "Đã Đặt Chỗ")
            {
                if (cbxNhanVien.Text == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin của nhân viên");
                }
                else
                {
                    int i = Controller.HoaDonBanCtr.InsertHoaDonBan(_MaHDB, _NgayBan, _TongTien, _MaNV, _MaKH, _GiamGia);
                    if (txtTrangThai.Text == "Trống") txtTrangThai.Text = "Có Khách";
                    else txtTrangThai.Text = "Đã Đặt Chỗ";
                    cbxMaHDB.Items.Add(_MaHDB);
                    Controller.BanAnCtr.UpdateTrangThaiBA(cbxViTri.Tag.ToString(), txtTrangThai.Text, _MaHDB);
                }
            }
            //int i = Controller.HoaDonBanCtr.UpdateHoaDonBan(_MaHDB, _NgayBan, _TongTien, _MaNV, _MaKH, _GiamGia);
            if (cbxNhanVien.Text != "")
            {
                btnnen.Visible = true;
                pnlMonAn.Visible = true;
                string _MaNM = ((sender as Button).Tag as Model.NhomMonMod).MaNM;
                LoadMonAn(_MaNM);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string STTMA = dgvChiTietBan.GetFocusedRowCellValue("STTMA").ToString();
            int i = 0;
            i = Controller.ChiTietBanCtr.DeleteChiTietBan(cbxMaHDB.Text, STTMA);
            LoadChiTietBan();
        }
        private void BtnMA_Click(object sender, EventArgs e)
        {
            string STTMA = ((sender as Button).Tag as Model.MonAnMod).STTMA;
            //dgvChiTietBan.Tag = STTMA;
            string TenMA = ((sender as Button).Tag as Model.MonAnMod).TenMA;
            string DonViTinh = ((sender as Button).Tag as Model.MonAnMod).DonViTinh;
            int DonGia = ((sender as Button).Tag as Model.MonAnMod).DonGia;
            soluong = 0;
            try
            {
                //soluong = Convert.ToInt32(dgvChiTietBan.GetFocusedRowCellValue("SoLuong"));
            }
            catch { }
            thanhtien = 0;
            frmCTB ctb = new frmCTB();
            ctb.Sender(TenMA, DonViTinh, soluong, DonGia);

            ctb.ReceiveText += Ctb_ReceiveText;
            ctb.ShowDialog();
            if (flag == 2)
            {
                int j = 0;
                int check = 0;
                for (int i = 0; i < dgvChiTietBan.RowCount; i++)
                {
                    string _STTMA = dgvChiTietBan.GetRowCellValue(i, "STTMA").ToString();
                    if (_STTMA == STTMA) { check = 1; break; }
                }
                if (check == 1)
                {
                    j = Controller.ChiTietBanCtr.UpdateChiTietBan(cbxMaHDB.Text, STTMA, soluong, thanhtien);
                }
                else
                {
                    j = Controller.ChiTietBanCtr.InsertChiTietBan(cbxMaHDB.Text, STTMA, soluong, thanhtien);
                }
                LoadChiTietBan();
                btnBack.Enabled = true;
            }

        }
        private void Ctb_ReceiveText(string TenMA, string DonViTinh, int SoLuong, int DonGia)
        {
            soluong = SoLuong;
            thanhtien = SoLuong * DonGia;
            flag = 2;
        }

        // Xu li su kien cho 3 nut goi,dat,back
        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            btnGoiMon.Enabled = false;
            if (btnGoiMon.Text == "Gọi Món")
            {
                btnDatCho.Enabled = false;
                if (txtTrangThai.Text == "Trống")
                {
                    flag = Convert.ToInt32(Model.Connection.ExcuteScalar(string.Format("select test = dbo.checkHDBInBanAn('" + cbxMaHDB.Text + "')")));
                    if (flag == 1)
                    {
                        Controller.BanAnCtr.UpdateTrangThaiBA(cbxViTri.Tag.ToString(), "Có Khách", cbxMaHDB.Text);
                        txtTrangThai.Text = "Có Khách";
                        LoadChiTietBan();
                        DataTable dt = Controller.HoaDonBanCtr.FillDatasetHDBbyMaHDB(cbxMaHDB.Text).Tables[0];
                        cbxNhanVien.SelectedValue = dt.Rows[0]["MaNV"].ToString();
                        cbxKhachHang.SelectedValue = dt.Rows[0]["MaKH"].ToString();
                    }
                    int k = Convert.ToInt32(Model.Connection.ExcuteScalar(string.Format("select test = dbo.checkHDBInHoaDonBan('" + cbxMaHDB.Text + "')")));
                    if (k == 0)
                    {
                        frmNhapKhachHang nhap = new frmNhapKhachHang();
                        nhap.Show();
                    }
                }
                pnlChiTietBan.Visible = true;
            }
            LoadNhomMon();
            pnlNhomMon.Visible = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            string _MaHDB = "";
            try
            {
                _MaHDB = cbxMaHDB.Text;
            }
            catch { }

            DateTime _NgayBan = dtpTime.Value;

            int _TongTien = 0;
            try
            {
                _TongTien = Convert.ToInt32(txtTongTien.Text);
            }
            catch { }

            string _MaNV = "";
            try
            {
                _MaNV = cbxNhanVien.SelectedValue.ToString();
            }
            catch { }

            string _MaKH = "";
            try
            {
                _MaKH = cbxKhachHang.SelectedValue.ToString();
            }
            catch { }

            int _GiamGia = 0;
            try
            {
                _GiamGia = Convert.ToInt32(txtGiamGia.Value);
            }
            catch { }

            int i = 0;
            i = Controller.HoaDonBanCtr.UpdateHoaDonBan(_MaHDB, _NgayBan, _TongTien, _MaNV, _MaKH, _GiamGia);
            if (i > 0)
            {
                MessageBox.Show("Sửa Thành Công !");
            }
            else
            {
                MessageBox.Show("Thất Bại !");
            }
            btnGoiMon.Text = "Gọi Món";
            btnDatCho.Text = "Đặt Chỗ";
            Dis_End(false);
            btnnen.Visible = false;
            pnlDSBanAn.Enabled = true;
            LoadBanAn();
        }
        private void btnDatCho_Click(object sender, EventArgs e)
        {
            if (btnDatCho.Text == "Đặt Chỗ")
            {
                MessageBox.Show("Nhập đầy đủ thông tin khách hàng và thời gian đến và chọn món", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGoiMon.Text = "Đặt Món";
                txtTrangThai.Text = "Đã Đặt Chỗ";
                frmNhapKhachHang nhap = new frmNhapKhachHang();
                nhap.Show();
                pnlDSBanAn.Enabled = false;
                btnBack.Enabled = false;
            }
            else
            {
                dtpTime.Value = DateTime.Now;
                txtTrangThai.Text = "Có Khách";
                btnGoiMon.Text = "Gọi Món";
                Controller.BanAnCtr.UpdateTrangThaiBA(cbxViTri.Tag.ToString(), "Có Khách", cbxMaHDB.Text);
            }
            pnlChiTietBan.Visible = true;
            btnDatCho.Enabled = false;
        }
        // xu li su kien thanh toan
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTrangThai.Text == "Có Khách")
            {
                if (Convert.ToInt32(txtTongTien.Text) == 0)
                {
                    MessageBox.Show(" Bạn phải gọi món ?");
                    return;
                }
                DialogResult dr = MessageBox.Show("Bạn có muốn in hóa đơn", "Thông Báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK) inhd = 1;
                frmThanhToan tt = new frmThanhToan();
                tt.Sender(btnThanhToan.Tag.ToString(), Convert.ToInt32(txtTongTien.Text));
                tt.ReceiveText += Tt_ReceiveText;
                tt.ShowDialog();
                if (flag == 3)
                {
                    Model.Connection.Excute_Sql("dbo.UpdateBASaukhiBan @MaHDB = '" + cbxMaHDB.Text + "'");
                    Controller.HoaDonBanCtr.UpdateHoaDonBan(cbxMaHDB.Text, dtpTime.Value, Convert.ToInt32(txtTongTien.Text), cbxNhanVien.SelectedValue.ToString(), cbxKhachHang.SelectedValue.ToString(), Convert.ToInt32(txtGiamGia.Value));
                    cbxMaHDB.Items.Remove(cbxMaHDB.Text.ToString());
                    ClearData();
                    Dis_End(false);
                    LoadBanAn();
                }
            }
        }

        private void Tt_ReceiveText(string TenBA, int TongTien)
        {
            flag = 3;
            if (inhd == 1)
            {
                using (GUI.frmPrint fr = new frmPrint())
                {
                    DataTable dt = Model.Connection.FillDataTable("InHoaDon '" + cbxMaHDB.Text + "'");
                    fr.printHD(cbxMaHDB.Text, cbxNhanVien.Text, cbxKhachHang.Text, Convert.ToInt32(txtTongTien.Text), Convert.ToInt32(txtGiamGia.Value), (DateTime)dtpTime.Value, TenBA, TongTien, dt);
                    fr.ShowDialog();
                }
                inhd = 0;
            }

        }

        private void txtGiamGia_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        #endregion

    }
}
