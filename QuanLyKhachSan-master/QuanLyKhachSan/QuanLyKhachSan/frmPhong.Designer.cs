namespace QuanLyKhachSan
{
    partial class frmPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.cbMaTB = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvChiTietTb = new System.Windows.Forms.DataGridView();
            this.matb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.rdbTrong = new System.Windows.Forms.RadioButton();
            this.rdbDaThue = new System.Windows.Forms.RadioButton();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTimKiemPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.Maloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemLP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaLP = new System.Windows.Forms.Button();
            this.txtGiaLP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNguoiLP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSuaLP = new System.Windows.Forms.Button();
            this.btnThemLP = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.btnXoaTB);
            this.panel2.Controls.Add(this.btnSuaTB);
            this.panel2.Controls.Add(this.btnThemTB);
            this.panel2.Controls.Add(this.cbMaTB);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtTenTB);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.dgvChiTietTb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(506, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 458);
            this.panel2.TabIndex = 1;
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTB.Location = new System.Drawing.Point(230, 236);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(50, 40);
            this.btnXoaTB.TabIndex = 63;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTB.UseVisualStyleBackColor = true;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTB.Location = new System.Drawing.Point(147, 236);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(48, 40);
            this.btnSuaTB.TabIndex = 62;
            this.btnSuaTB.Text = "Sửa";
            this.btnSuaTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTB.UseVisualStyleBackColor = true;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // btnThemTB
            // 
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTB.Location = new System.Drawing.Point(50, 236);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(60, 40);
            this.btnThemTB.TabIndex = 61;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTB.UseVisualStyleBackColor = true;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // cbMaTB
            // 
            this.cbMaTB.FormattingEnabled = true;
            this.cbMaTB.Location = new System.Drawing.Point(187, 15);
            this.cbMaTB.Name = "cbMaTB";
            this.cbMaTB.Size = new System.Drawing.Size(139, 27);
            this.cbMaTB.TabIndex = 60;
            this.cbMaTB.SelectedIndexChanged += new System.EventHandler(this.cbMaTB_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(187, 112);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(139, 26);
            this.txtSoLuong.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 19);
            this.label13.TabIndex = 58;
            this.label13.Text = "Số lượng";
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(187, 63);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.ReadOnly = true;
            this.txtTenTB.Size = new System.Drawing.Size(139, 26);
            this.txtTenTB.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 19);
            this.label12.TabIndex = 56;
            this.label12.Text = "Tên Thiết Bị";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 54;
            this.label11.Text = "Mã Thiết Bị";
            // 
            // dgvChiTietTb
            // 
            this.dgvChiTietTb.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvChiTietTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietTb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matb,
            this.tentb,
            this.soluong});
            this.dgvChiTietTb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietTb.Location = new System.Drawing.Point(0, 297);
            this.dgvChiTietTb.Name = "dgvChiTietTb";
            this.dgvChiTietTb.Size = new System.Drawing.Size(370, 161);
            this.dgvChiTietTb.TabIndex = 1;
            // 
            // matb
            // 
            this.matb.DataPropertyName = "Mathietbi";
            this.matb.HeaderText = "Mã TB";
            this.matb.Name = "matb";
            // 
            // tentb
            // 
            this.tentb.DataPropertyName = "Tenthietbi";
            this.tentb.HeaderText = "Tên TB";
            this.tentb.Name = "tentb";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtTenLoai);
            this.panel1.Controls.Add(this.rdbTrong);
            this.panel1.Controls.Add(this.rdbDaThue);
            this.panel1.Controls.Add(this.txtGiaPhong);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbLoaiPhong);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSoNguoi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTenPhong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.txtTimKiemPhong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnXoaPhong);
            this.panel1.Controls.Add(this.btnSuaPhong);
            this.panel1.Controls.Add(this.btnThemPhong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 458);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(271, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 19);
            this.label15.TabIndex = 65;
            this.label15.Text = "Tên loại";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(367, 104);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.ReadOnly = true;
            this.txtTenLoai.Size = new System.Drawing.Size(114, 26);
            this.txtTenLoai.TabIndex = 64;
            // 
            // rdbTrong
            // 
            this.rdbTrong.AutoSize = true;
            this.rdbTrong.Enabled = false;
            this.rdbTrong.Location = new System.Drawing.Point(367, 61);
            this.rdbTrong.Name = "rdbTrong";
            this.rdbTrong.Size = new System.Drawing.Size(72, 23);
            this.rdbTrong.TabIndex = 63;
            this.rdbTrong.Text = "Trống";
            this.rdbTrong.UseVisualStyleBackColor = true;
            // 
            // rdbDaThue
            // 
            this.rdbDaThue.AutoSize = true;
            this.rdbDaThue.Enabled = false;
            this.rdbDaThue.Location = new System.Drawing.Point(367, 20);
            this.rdbDaThue.Name = "rdbDaThue";
            this.rdbDaThue.Size = new System.Drawing.Size(90, 23);
            this.rdbDaThue.TabIndex = 62;
            this.rdbDaThue.Text = "Đã thuê";
            this.rdbDaThue.UseVisualStyleBackColor = true;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(114, 197);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.ReadOnly = true;
            this.txtGiaPhong.Size = new System.Drawing.Size(139, 26);
            this.txtGiaPhong.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 60;
            this.label10.Text = "Giá phòng";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(114, 104);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(139, 27);
            this.cbLoaiPhong.TabIndex = 59;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 58;
            this.label9.Text = "Loại phòng";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Location = new System.Drawing.Point(114, 154);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.ReadOnly = true;
            this.txtSoNguoi.Size = new System.Drawing.Size(139, 26);
            this.txtSoNguoi.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Số người";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(114, 60);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(139, 26);
            this.txtTenPhong.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tên phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(114, 16);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(139, 26);
            this.txtMaPhong.TabIndex = 53;
            // 
            // txtTimKiemPhong
            // 
            this.txtTimKiemPhong.Location = new System.Drawing.Point(302, 253);
            this.txtTimKiemPhong.Name = "txtTimKiemPhong";
            this.txtTimKiemPhong.Size = new System.Drawing.Size(179, 26);
            this.txtTimKiemPhong.TabIndex = 52;
            this.txtTimKiemPhong.TextChanged += new System.EventHandler(this.txtTimKiemPhong_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tìm kiếm";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhong.Location = new System.Drawing.Point(159, 245);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(50, 40);
            this.btnXoaPhong.TabIndex = 50;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhong.Location = new System.Drawing.Point(96, 245);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(48, 40);
            this.btnSuaPhong.TabIndex = 49;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhong.Location = new System.Drawing.Point(17, 245);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(60, 40);
            this.btnThemPhong.TabIndex = 48;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tenphong,
            this.Loaiphong,
            this.Tenlp,
            this.trangthai,
            this.so,
            this.gp});
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhong.Location = new System.Drawing.Point(0, 297);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(497, 161);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.Name = "Maphong";
            // 
            // Tenphong
            // 
            this.Tenphong.DataPropertyName = "Tenphong";
            this.Tenphong.HeaderText = "Tên Phòng";
            this.Tenphong.Name = "Tenphong";
            // 
            // Loaiphong
            // 
            this.Loaiphong.DataPropertyName = "Maloaiphong";
            this.Loaiphong.HeaderText = "Mã loại phòng ";
            this.Loaiphong.Name = "Loaiphong";
            // 
            // Tenlp
            // 
            this.Tenlp.DataPropertyName = "Tenloaiphong";
            this.Tenlp.HeaderText = "Tên Loại";
            this.Tenlp.Name = "Tenlp";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "Trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
            // 
            // so
            // 
            this.so.DataPropertyName = "Songuoi";
            this.so.HeaderText = "Số người";
            this.so.Name = "so";
            // 
            // gp
            // 
            this.gp.DataPropertyName = "Giaphong";
            this.gp.HeaderText = "Giá";
            this.gp.Name = "gp";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dgvLoaiPhong);
            this.tabPage2.Controls.Add(this.txtTimKiemLP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnXoaLP);
            this.tabPage2.Controls.Add(this.txtGiaLP);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSoNguoiLP);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtTenLP);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtMaLP);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnSuaLP);
            this.tabPage2.Controls.Add(this.btnThemLP);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại phòng";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaiphong,
            this.Tenloaiphong,
            this.Songuoi,
            this.Giaphong});
            this.dgvLoaiPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(3, 286);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(873, 175);
            this.dgvLoaiPhong.TabIndex = 48;
            // 
            // Maloaiphong
            // 
            this.Maloaiphong.DataPropertyName = "Maloaiphong";
            this.Maloaiphong.HeaderText = "Mã Loại Phòng";
            this.Maloaiphong.Name = "Maloaiphong";
            this.Maloaiphong.ReadOnly = true;
            // 
            // Tenloaiphong
            // 
            this.Tenloaiphong.DataPropertyName = "Tenloaiphong";
            this.Tenloaiphong.HeaderText = "Tên Loại Phòng";
            this.Tenloaiphong.Name = "Tenloaiphong";
            this.Tenloaiphong.ReadOnly = true;
            // 
            // Songuoi
            // 
            this.Songuoi.DataPropertyName = "Songuoi";
            this.Songuoi.HeaderText = "Số Người";
            this.Songuoi.Name = "Songuoi";
            this.Songuoi.ReadOnly = true;
            // 
            // Giaphong
            // 
            this.Giaphong.DataPropertyName = "Giaphong";
            this.Giaphong.HeaderText = "Giá ";
            this.Giaphong.Name = "Giaphong";
            this.Giaphong.ReadOnly = true;
            // 
            // txtTimKiemLP
            // 
            this.txtTimKiemLP.Location = new System.Drawing.Point(518, 167);
            this.txtTimKiemLP.Name = "txtTimKiemLP";
            this.txtTimKiemLP.Size = new System.Drawing.Size(179, 26);
            this.txtTimKiemLP.TabIndex = 47;
            this.txtTimKiemLP.TextChanged += new System.EventHandler(this.txtTimKiemLP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tìm kiếm";
            // 
            // btnXoaLP
            // 
            this.btnXoaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLP.Location = new System.Drawing.Point(285, 163);
            this.btnXoaLP.Name = "btnXoaLP";
            this.btnXoaLP.Size = new System.Drawing.Size(75, 40);
            this.btnXoaLP.TabIndex = 45;
            this.btnXoaLP.Text = "Xóa";
            this.btnXoaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLP.UseVisualStyleBackColor = true;
            this.btnXoaLP.Click += new System.EventHandler(this.btnXoaLP_Click);
            // 
            // txtGiaLP
            // 
            this.txtGiaLP.Location = new System.Drawing.Point(518, 78);
            this.txtGiaLP.Name = "txtGiaLP";
            this.txtGiaLP.Size = new System.Drawing.Size(179, 26);
            this.txtGiaLP.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Giá Phòng";
            // 
            // txtSoNguoiLP
            // 
            this.txtSoNguoiLP.Location = new System.Drawing.Point(518, 24);
            this.txtSoNguoiLP.Name = "txtSoNguoiLP";
            this.txtSoNguoiLP.Size = new System.Drawing.Size(179, 26);
            this.txtSoNguoiLP.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số Người";
            // 
            // txtTenLP
            // 
            this.txtTenLP.Location = new System.Drawing.Point(167, 82);
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.Size = new System.Drawing.Size(193, 26);
            this.txtTenLP.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tên Loại Phòng";
            // 
            // txtMaLP
            // 
            this.txtMaLP.Location = new System.Drawing.Point(167, 25);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.ReadOnly = true;
            this.txtMaLP.Size = new System.Drawing.Size(193, 26);
            this.txtMaLP.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "Mã Loại Phòng";
            // 
            // btnSuaLP
            // 
            this.btnSuaLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLP.Location = new System.Drawing.Point(167, 163);
            this.btnSuaLP.Name = "btnSuaLP";
            this.btnSuaLP.Size = new System.Drawing.Size(75, 40);
            this.btnSuaLP.TabIndex = 36;
            this.btnSuaLP.Text = "Sửa";
            this.btnSuaLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaLP.UseVisualStyleBackColor = true;
            this.btnSuaLP.Click += new System.EventHandler(this.btnSuaLP_Click);
            // 
            // btnThemLP
            // 
            this.btnThemLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLP.Location = new System.Drawing.Point(50, 163);
            this.btnThemLP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLP.Name = "btnThemLP";
            this.btnThemLP.Size = new System.Drawing.Size(85, 40);
            this.btnThemLP.TabIndex = 35;
            this.btnThemLP.Text = "Thêm";
            this.btnThemLP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLP.UseVisualStyleBackColor = true;
            this.btnThemLP.Click += new System.EventHandler(this.btnThemLP_Click);
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 496);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTimKiemLP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaLP;
        private System.Windows.Forms.TextBox txtGiaLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNguoiLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSuaLP;
        private System.Windows.Forms.Button btnThemLP;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaphong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbTrong;
        private System.Windows.Forms.RadioButton rdbDaThue;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTimKiemPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvChiTietTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlp;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn so;
        private System.Windows.Forms.DataGridViewTextBoxColumn gp;
        private System.Windows.Forms.ComboBox cbMaTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn matb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentb;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTenLoai;
    }
}