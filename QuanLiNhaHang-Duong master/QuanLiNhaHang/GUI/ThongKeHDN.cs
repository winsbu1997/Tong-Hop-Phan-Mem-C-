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
using Microsoft.Office.Interop.Excel;
using System.Threading;

namespace QuanLiNhaHang.GUI
{
    public partial class ThongKeHDN : UserControl
    {
        public static ThongKeHDN uct_TKHDN = new ThongKeHDN();
        public ThongKeHDN()
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
                txtTongTien.Text = String.Format("{0:N0}", Model.Connection.docGiaTri(string.Format("SELECT s = dbo.SumTongTienHDN('" + d1.ToString() + "','" + d2.ToString() + "')")));
                txtTongSoNL.Text = Model.Connection.docGiaTri("SELECT Sum(SoLuong) FROM dbo.ChiTietHDN where MaHDN = '" + dgvChiTietNhap.GetFocusedRowCellValue("MaHDN") + "'").ToString();
            }
            catch { }
        }
        void LoadTKHDN()
        {
            DateTime d1 = dtpfromDay.Value;
            DateTime d2 = dtptoDay.Value;

            dgvHoaDonNhapMain.DataSource = Model.Connection.FillDataTable("SELECT *FROM dbo.HoaDonNhap WHERE NgayNhap BETWEEN '" + d1.ToString() + "' AND'" + d2.ToString() + "'");
            // Hàm để thay thế manv = tennv
            RepositoryItemLookUpEdit riMaNV = new RepositoryItemLookUpEdit();
            riMaNV.DataSource = Model.NhanVienMod.FillDataSetNhanVien().Tables[0];
            riMaNV.ValueMember = "MaNV";
            riMaNV.DisplayMember = "TenNV";
            dgvHoaDonNhap.Columns["MaNV"].ColumnEdit = riMaNV;
            TienHD();
            LoadCTN();
        }
        void LoadCTN()
        {
            dgvChiTietNhapMain.DataSource = Model.Connection.FillDataTable("TKChiTietNhap '" + dgvHoaDonNhap.GetFocusedRowCellValue("MaHDN") + "'");
            txtTongHoaDon.Text = dgvHoaDonNhap.RowCount.ToString();
        }
        #endregion
        #region Events
        private void ThongKeHDN_Load(object sender, EventArgs e)
        {
            txtTongSoNL.Text = "0";
            txtTongTien.Text = "0";
            txtTongHoaDon.Text = "0";
        }

        private void dtpfromDay_ValueChanged(object sender, EventArgs e)
        {
            LoadTKHDN();
        }

        private void dtptoDay_ValueChanged(object sender, EventArgs e)
        {
            LoadTKHDN();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadTKHDN();
        }

        private void dgvHoaDonNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadCTN();
        }

        private void btnThongKeTheoNL_Click(object sender, EventArgs e)
        {
            label4.Text = "Thống Kê Nguyên Liệu Nhập";
            DateTime d1 = dtpfromDay.Value;
            DateTime d2 = dtptoDay.Value;
            dgvChiTietNhapMain.DataSource = Model.Connection.FillDataTable("TKNguyenLieu '" + d1.ToString() + "', '" + d2.ToString() + "'");
            txtTongSoNL.Text = Model.Connection.docGiaTri("select s = dbo.TKSoNguyenLieu ('" + d1.ToString() + "', '" + d2.ToString() + "')").ToString();
        }
        #endregion

        #region ExporttoExel


        #endregion

        struct DataParameter
        {
            public List<Model.HoaDonNhapMod> HoaDonNhapList;
            public string FileName { get; set; }

        }
        DataParameter _inputParameter;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Model.HoaDonNhapMod> list = ((DataParameter)e.Argument).HoaDonNhapList;
            string fileName = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = true;
            int index = 1;
            int process = list.Count;
            // them cot
            ws.Cells[1, 1] = "Mã Hóa Đơn Nhâp";
            ws.Cells[1, 2] = "Nhân Viên Nhập";
            ws.Cells[1, 3] = "Ngày Nhập";
            ws.Cells[1, 4] = "Ghi Chú";
            ws.Cells[1, 5] = "Tổng Tiền";

            foreach (Model.HoaDonNhapMod hdn in list)
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = hdn.MaHDN.ToString();
                    ws.Cells[index, 2] = hdn.MaNV.ToString();
                    ws.Cells[index, 3] = (DateTime)hdn.NgayNhap;
                    ws.Cells[index, 4] = (string)hdn.GhiChu;
                    ws.Cells[index, 5] = (int)hdn.TongTien;
                }
            }
            ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
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
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.FileName = sfd.FileName;
                    _inputParameter.HoaDonNhapList = Controller.HoaDonNhapCtr.DanhSachHoaDonNhap("SELECT *FROM dbo.HoaDonNhap WHERE NgayNhap BETWEEN '" + d1.ToString() + "' AND'" + d2.ToString() + "'");
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(_inputParameter);
                }
            }
        }

        private void btndeleteHDN_Click(object sender, EventArgs e)
        {

        }
    }
}
