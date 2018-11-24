using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class testHinhAnh : Form
    {
        public testHinhAnh()
        {
            InitializeComponent();
            int a = 12;
            float b = 3.5F;
            int c;
            c = a + Convert.ToInt32(b);
            MessageBox.Show(c.ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog1 = new OpenFileDialog();
            saveFileDialog1.ShowDialog();
            string FileName = saveFileDialog1.FileName.ToString();

            try
            {
                imgMain.Image = Image.FromFile(FileName);
                imgMain.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                MessageBox.Show("Load ảnh lỗi");
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = DESKTOP-DA79QLM\SQLEXPRESS;Initial Catalog=QUANLYQUANCAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("Kết nối cơ sở dữ liệu thành công");

            string query = "select hinhanh from mathang";
            SqlCommand command = new SqlCommand(query, connection);

            object ans = new object();
            ans = command.ExecuteScalar();

            imgMain.Image = ByteToImage(ans as byte[]);
            imgMain.SizeMode = PictureBoxSizeMode.StretchImage;


            connection.Close();
        }
    }
}
