using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using System.Threading;
using Microsoft.Office.Interop.Excel;

namespace QuanLiNhaHang.GUI
{
    public partial class ThongKeHDB : UserControl
    {
        public static ThongKeHDB uct_TK = new ThongKeHDB();
        public ThongKeHDB()
        {
            InitializeComponent();
        }
        #region MethodThongKe
        void TienHD()
        {
            DateTime d1 = dtpfromDay.Value;
            DateTime d2 = dtptoDay.Value;
            try
            {
                txtTongTien.Text = Model.Connection.ExcuteScalar(string.Format("select sum = dbo.SumTongTien('" + d1.ToString() + "','" + d2.ToString() + "')")).ToString();
                txtGiamGia.Text = Model.Connection.ExcuteScalar(string.Format("select sum = dbo.SumGiamGia('" + d1.ToString() + "','" + d2.ToString() + "')"));
                txtTienThuVe.Text = String.Format("{0:N0}",Convert.ToInt32(txtTongTien.Text) - Convert.ToInt32(txtGiamGia.Text));
                txtTongSoMon.Text = String.Format("{0:N0}",Convert.ToInt32(Model.Connection.docGiaTri("SELECT Sum(SoLuong) FROM dbo.ChiTietHDB where MaHDB = '" + dgvHoaDonBan.GetFocusedRowCellValue("MaHDB") + "'")));
            }
            catch { }
            
        }

        void UpdateDataChiTietBan()
        {           
            dgvChiTietBanMain.DataSource = Model.Connection.FillDataTable("TKChiTietBan '" + dgvHoaDonBan.GetFocusedRowCellValue("MaHDB") + "'");
            //dgvChiTietBan.ActiveFilterString = "[MaHDB]= '" + dgvHoaDonBan.GetFocusedRowCellValue("MaHDB") + "'";
            txtTongHoaDon.Text = dgvHoaDonBan.RowCount.ToString();
            TienHD();
        }
        void LoadTK()
        {
            DateTime d1 = dtpfromDay.Value;
            DateTime d2 = dtptoDay.Value;

            dgvHoaDonBanMain.DataSource = Model.Connection.FillDataTable("SELECT *FROM dbo.HoaDonBan WHERE NgayBan BETWEEN '"+ d1.ToString() + "' AND'" + d2.ToString() + "' and TongTien > 0");

            RepositoryItemLookUpEdit riMaNV = new RepositoryItemLookUpEdit();
            riMaNV.DataSource = Model.NhanVienMod.FillDataSetNhanVien().Tables[0];
            riMaNV.ValueMember = "MaNV";
            riMaNV.DisplayMember = "TenNV";
            dgvHoaDonBan.Columns["MaNV"].ColumnEdit = riMaNV;

            RepositoryItemLookUpEdit riMaKH = new RepositoryItemLookUpEdit();
            riMaKH.DataSource = Model.KhachHangMod.FillDataSetKhachHang().Tables[0];
            riMaKH.ValueMember = "MaKH";
            riMaKH.DisplayMember = "TenKH";
            dgvHoaDonBan.Columns["MaKH"].ColumnEdit = riMaKH;
            UpdateDataChiTietBan();
           
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadTK();
        }

        private void dtptoDay_ValueChanged(object sender, EventArgs e)
        {
            LoadTK();
        }

        private void dtpfromDay_ValueChanged(object sender, EventArgs e)
        {
            LoadTK();
        }

        private void dgvHoaDonBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDataChiTietBan();
        }

        private void dgvHoaDonBan_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateDataChiTietBan();

        }

        private void frmThongKeHDB_Load(object sender, EventArgs e)
        {
            txtGiamGia.Text = "";
            txtTienThuVe.Text = "";
            txtTongTien.Text = "";
            txtTongSoMon.Text = "";
            txtTongHoaDon.Text = "";
        }

        private void btnThongKeTheoMon_Click(object sender, EventArgs e)
        {
            label4.Text = "Thống Kê Theo Món Ăn";
            DateTime d1 = dtpfromDay.Value;
            DateTime d2 = dtptoDay.Value;
            dgvChiTietBanMain.DataSource = Model.Connection.FillDataTable("TKMonAn '" + d1.ToString() + "', '" + d2.ToString() + "'");
            txtTongSoMon.Text = Model.Connection.docGiaTri("select s = dbo.TKSoMon ('" + d1.ToString() + "', '" + d2.ToString() + "')").ToString();
        }
        #endregion

        // Export excel

        #region ExportExcel

        struct DataParameter
        {
            public List<Model.HoaDonBanMod> HoaDonBanList;
            public string FileName { get; set; }
               
        }
        DataParameter _inputParameter;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Model.HoaDonBanMod> list = ((DataParameter)e.Argument).HoaDonBanList;
            string fileName = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = true;
            int index = 1;
            int process = list.Count;
            // them cot
            ws.Cells[1, 1] = "Mã Hóa Đơn Bán";
            ws.Cells[1, 2] = "Mã Khách Hàng";
            ws.Cells[1, 3] = "Mã Nhân Viên";
            ws.Cells[1, 4] = "Ngày Bán";
            ws.Cells[1, 5] = "Tiền Giảm Giá";
            ws.Cells[1, 6] = "Tổng Tiền";

            foreach (Model.HoaDonBanMod hdb in list)
            {
                
                if (!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = hdb.MaHDB.ToString();                  
                    ws.Cells[index, 2] = hdb.MaKH.ToString();
                    ws.Cells[index, 3] = 
                    ws.Cells[index, 4] = (DateTime)hdb.NgayBan;
                    ws.Cells[index, 5] = (int)hdb.GiamGia;
                    ws.Cells[index, 6] = (int)hdb.TongTien;
                }
            }
            ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing,Type.Missing);
            //excel.Quit();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // MessageBox.Show("1");
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = string.Format("Processing ...{0}", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("1");
            if (e.Error == null)
            {
                Thread.Sleep(100);
                lblStatus.Text = " Successfully exported";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DateTime d1 = dtpfromDay.Value;
            DateTime d2 = dtptoDay.Value;
            if (backgroundWorker1.IsBusy) return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.FileName = sfd.FileName;
                    _inputParameter.HoaDonBanList = Controller.HoaDonBanCtr.DanhSachHoaDonBan("SELECT *FROM dbo.HoaDonBan WHERE NgayBan BETWEEN '" + d1.ToString() + "' AND'" + d2.ToString() + "' and TongTien > 0");
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(_inputParameter);
                }
            }
        }

        #endregion

        #region XoaThongKe
        private void btndeleteHDB_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
