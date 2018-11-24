using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.QUANLYQUANCAFEDataSet1TableAdapters;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.GUI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            //DataTable data = ChiTietBan.HienThiHoaDon(1);
            //InHoaDonTableAdapter test = new InHoaDonTableAdapter();
            //QUANLYQUANCAFEDataSet1.InHoaDonDataTable a = new QUANLYQUANCAFEDataSet1.InHoaDonDataTable();
            //test.Fill(, 1);
            this.reportViewer1.RefreshReport();
        }
    }
}
