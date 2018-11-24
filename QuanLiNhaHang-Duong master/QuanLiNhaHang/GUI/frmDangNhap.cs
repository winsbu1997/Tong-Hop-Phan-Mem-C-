using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.GUI
{
    public partial class frmDangNhap : Form
    {
        public string TenDN { get; set; }
        public frmDangNhap()
        {
            InitializeComponent();
            this.Size = new Size(320, 480);
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Enabled = false;
        }
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Label logreg = new Label();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaoTen.Text = "Tên đăng nhập";
            timer1.Tick += new EventHandler(timer1_go);
            timer2.Tick += new EventHandler(timer2_go);
            timer1.Interval = 10;
            timer2.Interval = 5;
            timer1.Start();
        }
        void timer1_go(object sender, EventArgs e)
        {
            Logoposition();
        }
        //
        void timer2_go(object sender, EventArgs e)
        {
            if (logreg.Text == "Tạo tài khoản")
            {
                reg();
            }
            else if (logreg.Text == "Trở lại")
            {
                log();
            }
        }

        /// <summary>
        /// Create animation
        /// </summary>
        int go = 1;
        #region
        //logo postion
        void Logoposition()
        {
            if (panel1.Left == 0)
            {
                pictureBox1.Top += go;
                if (pictureBox1.Top > 50)
                {
                    timer1.Stop();
                }
            }
            if (panel2.Left == 0)
            {
                pictureBox1.Top -= go;
                if (pictureBox1.Top < 34)
                {
                    timer1.Stop();
                }
            }
        }

        //line animation
        void line()
        {
            if (panel1.Left == 0)
            {
                bunifuSeparator10.LineThickness = 3;
                bunifuSeparator10.LineColor = Color.FromArgb(0, 173, 239);
                bunifuSeparator9.LineThickness = 1;
                bunifuSeparator9.LineColor = Color.Silver;
            }
            if (panel2.Left == 0)
            {
                bunifuSeparator10.LineThickness = 1;
                bunifuSeparator10.LineColor = Color.Silver;
                bunifuSeparator9.LineThickness = 3;
                bunifuSeparator9.LineColor = Color.FromArgb(0, 173, 239);
            }
        }

        //slide panel
        int move_speed = 20;
        void reg()
        {
            if (panel2.Left > 0)
            {
                timer1.Start();
                line();

                panel1.Left -= move_speed;
                panel2.Left -= move_speed;
                if (panel2.Left == 0)
                {
                    timer2.Stop();
                }
            }
        }
        void log()
        {
            if (panel1.Left < 0)
            {
                timer1.Start();
                line();

                panel2.Left += move_speed;
                panel1.Left += move_speed;
                if (panel1.Left == 0)
                {
                    timer2.Stop();
                }
            }
        }

        //image of key
        void unlock()
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';
                pictureBox2.Image = Properties.Resources.show;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                pictureBox2.Image = Properties.Resources._lock;
            }
        }
        #endregion

        /// <summary>
        /// Event of TextBox
        /// </summary>
        void Enter1(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "Tên đăng nhập")
            {
                txtDangNhap.Text = string.Empty;
            }
        }
        void Leave1(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == string.Empty)
            {
                txtDangNhap.Text = "Tên đăng nhập";
            }
        }
        void Enter2(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.PasswordChar = '*';
                pictureBox2.Enabled = true;
                txtMatKhau.Text = string.Empty;
            }
        }
        void Leave2(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == string.Empty)
            {
                txtTaoTen.Text = "Mật khẩu";
            }
        }
        void Enter3(object sender, EventArgs e)
        {
            if (txtTaoTen.Text == "Tên đăng nhập")
            {
                txtTaoTen.Text = string.Empty;
            }
        }
        void Leave3(object sender, EventArgs e)
        {
            if (txtTaoTen.Text == string.Empty)
            {
                txtTaoTen.Text = "Tên đăng nhập";
            }
        }
        void Enter5(object sender, EventArgs e)
        {
            if (txtTaoMK.Text == "Mật khẩu")
            {
                txtTaoMK.Text = string.Empty;
            }
        }
        void Leave5(object sender, EventArgs e)
        {
            if (txtTaoMK.Text == string.Empty)
            {
                txtTaoMK.Text = "Mật khẩu";
            }
        }
        void Enter6(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == "Xác nhận mật khẩu")
            {
                txtXacNhanMK.PasswordChar = '*';
                txtXacNhanMK.Text = string.Empty;
            }
        }
        void Leave6(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == string.Empty)
            {
                txtXacNhanMK.PasswordChar = '\0';
                txtXacNhanMK.Text = "Xác nhận mật khẩu";
            }
        }

        /// <summary>
        /// Event of label Register&ogin
        /// </summary>

        //Event of image
        private void lockun(object sender, EventArgs e)
        {
            unlock();
        }
        int i = 1;
        private void Register(object sender, EventArgs e)
        {
            i++;
            Label lr = (Label)sender;
            logreg = lr;
            timer2.Start();
            switch (i % 2)
            {
                case 0:
                    bunifuSeparator10.LineThickness = 3;
                    bunifuSeparator10.LineColor = Color.FromArgb(0, 173, 239);
                    bunifuSeparator9.LineThickness = 1;
                    bunifuSeparator9.LineColor = Color.Silver;
                    break;
                case 1:
                    bunifuSeparator10.LineThickness = 1;
                    bunifuSeparator10.LineColor = Color.Silver;
                    bunifuSeparator9.LineThickness = 3;
                    bunifuSeparator9.LineColor = Color.FromArgb(0, 173, 239);
                    break;
            }


        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int check = Convert.ToInt32(Model.Connection.ExcuteScalar("select tmp = dbo.CheckDangNhap('" + txtDangNhap.Text + "','" + txtMatKhau.Text + "')"));
            if(check == 0)
            {
                MessageBox.Show("Sai Mật Khẩu hoặc Tên Đăng Nhập");
            }
            else
            {
                TenDN = txtDangNhap.Text;
                this.Close();
            }

        }

        private void btnTaoDangNhap_Click(object sender, EventArgs e)
        {
            string _TenDN = "";
            try
            {
                _TenDN = txtTaoTen.Text;
            }
            catch { }

            string _MatKhau = "";
            try
            {
                _MatKhau = txtTaoMK.Text;
            }
            catch { }

            string _XacNhanMK = "";
            try
            {
                _XacNhanMK = txtXacNhanMK.Text;
            }
            catch { }
            int check = Convert.ToInt32(Model.Connection.ExcuteScalar("select tmp = dbo.CheckDangNhap('" + txtDangNhap.Text + "','" + txtMatKhau.Text + "')"));
            if (check == 1)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu đã có người sử dụng");
            }
            else
            {
                int i = 0;
                i = Controller.DangNhapCtr.InsertDangNhap(_TenDN, _MatKhau);
                if (i == 0 || txtTaoMK.Text != txtXacNhanMK.Text)
                {
                    MessageBox.Show("Thêm mới thất bại !");
                }
                else
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
            }

        }

    }
}
