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
using System.IO;

namespace QuanLiNhaHang.GUI
{
    public partial class ListThucDon : UserControl
    {
        public static ListThucDon uct_listTD = new ListThucDon();
        public ListThucDon()
        {
            InitializeComponent();
        }
        public void LoadNhomMon()
        {
            int[] mau = { -5952982, -10039894, -70077677, -40121, -16711936, -16711681, -256, -16744448 };
            pnlNhomMon.Controls.Clear();
            List<Model.NhomMonMod> ListNM = Controller.NhomMonCtr.DanhSachNhomMon();
            int i = 0;
            foreach (Model.NhomMonMod item in ListNM)
            {
                Button btnNM = new Button() { Width = Controller.NhomMonCtr.btnWidth, Height = Controller.NhomMonCtr.btnHeight };
                btnNM.Text = item.TenNM;
                btnNM.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnNM.Tag = item;
                btnNM.FlatStyle = FlatStyle.Standard;
                btnNM.BackColor = Color.FromArgb(mau[i % 8]);
                i++;
                btnNM.Click += BtnNhomMon_Click;
                pnlNhomMon.Controls.Add(btnNM);
            }
            Button btn = new Button() { Width = Controller.NhomMonCtr.btnWidth, Height = Controller.NhomMonCtr.btnHeight };
            btn.Text = "Tất Cả";
            btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.FlatStyle = FlatStyle.Standard;
            btn.BackColor = Color.Silver;
            btn.Tag = "socola";
            btn.Click += BtnNhomMon_Click;
            pnlNhomMon.Controls.Add(btn);
        }
        private Image ByteToImg(byte[] imgBytes)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch
            {
                return null;
            }
        }

        public void LoadMonAn(string query)
        {
            DataTable dt = Model.Connection.FillDataTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Byte[] byteAnh = null;
                try
                {
                    byteAnh = (Byte[])dt.Rows[i]["HinhAnh"];
                    imageList1.Images.Add(ByteToImg(byteAnh));
                }
                catch { }
            }
            imageList1.ImageSize = new Size(100,100);
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                Button monan = new Button() { Width = 200, Height =  110};
                monan.Image = imageList1.Images[i];
                monan.ImageAlign = ContentAlignment.MiddleLeft;
                monan.AutoSize = false;
                string line1 = dt.Rows[i]["STTMA"].ToString() + Environment.NewLine;
                string line2 = (dt.Rows[i]["TenMA"].ToString()).ToUpper() + Environment.NewLine;
                string[] line = line2.Split(' ');
                line2 = "";
                int flag = 1;
                for(int j = 0; j < line.Length; j++)
                {
                    if (line2.Length + line[j].Length >= 13 * flag) { line2.Remove(line2.Length - 1) ; line2 += Environment.NewLine; flag++; }
                    line2 += line[j] + " ";
                    
                }
                string line3 =  "Giá: " + dt.Rows[i]["DonGia"].ToString() + "VND" + Environment.NewLine;
                string line4 =  "Đơn Vị Tính: " + dt.Rows[i]["DonViTinh"].ToString();
                monan.Text = line1 + line2 + line3 + line4;
                monan.TextAlign = ContentAlignment.TopRight;
                monan.ForeColor = Color.Black;
                monan.BackColor = Color.Linen;

                pnlMonAn.Controls.Add(monan);
                pnlMonAn.BackColor = Color.White;
            }
        }
        private void BtnNhomMon_Click(object sender, EventArgs e)
        {
            pnlMonAn.Controls.Clear();
            imageList1.Images.Clear();
            if ((sender as Button).Tag.ToString() != "socola")
            {
                string MaNM = ((sender as Button).Tag as Model.NhomMonMod).MaNM;
                LoadMonAn("SELECT *FROM dbo.MonAn where MaNM = '" + MaNM + "'");
            }               
            else LoadMonAn("SELECT *FROM dbo.MonAn");
        }
        private void ListThucDon_Load(object sender, EventArgs e)
        {
            LoadMonAn("SELECT *FROM dbo.MonAn");
            LoadNhomMon();
        }
    }
}
