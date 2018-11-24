namespace QuanLyNhanSu.View
{
    partial class BangLuong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbNgayThang = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLuong = new System.Windows.Forms.GroupBox();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbKhenThuong = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudGioTangCa = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienKhenThuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienKyLuat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLuongTangCa = new System.Windows.Forms.NumericUpDown();
            this.txtLuongCoBan = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtKyLuat = new System.Windows.Forms.TextBox();
            this.txtKhenThuong = new System.Windows.Forms.TextBox();
            this.dgvKhenThuong = new System.Windows.Forms.DataGridView();
            this.dgvKyLuat = new System.Windows.Forms.DataGridView();
            this.MaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.grbNgayThang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            this.grbLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.grbKhenThuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGioTangCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongTangCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCoBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNgayThang
            // 
            this.grbNgayThang.Controls.Add(this.btnTraCuu);
            this.grbNgayThang.Controls.Add(this.nudNam);
            this.grbNgayThang.Controls.Add(this.nudThang);
            this.grbNgayThang.Controls.Add(this.domainUpDown1);
            this.grbNgayThang.Controls.Add(this.label2);
            this.grbNgayThang.Controls.Add(this.label1);
            this.grbNgayThang.Location = new System.Drawing.Point(4, 4);
            this.grbNgayThang.Name = "grbNgayThang";
            this.grbNgayThang.Size = new System.Drawing.Size(188, 165);
            this.grbNgayThang.TabIndex = 0;
            this.grbNgayThang.TabStop = false;
            this.grbNgayThang.Text = "Bảng lương theo tháng - năm";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(51, 91);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 40);
            this.btnTraCuu.TabIndex = 8;
            this.btnTraCuu.Text = "Tính lương";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // nudNam
            // 
            this.nudNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNam.Location = new System.Drawing.Point(75, 52);
            this.nudNam.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(66, 22);
            this.nudNam.TabIndex = 6;
            this.nudNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudThang
            // 
            this.nudThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThang.Location = new System.Drawing.Point(75, 24);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(66, 22);
            this.nudThang.TabIndex = 5;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(-19, -19);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 3;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // grbLuong
            // 
            this.grbLuong.Controls.Add(this.dgvLuong);
            this.grbLuong.Location = new System.Drawing.Point(7, 203);
            this.grbLuong.Name = "grbLuong";
            this.grbLuong.Size = new System.Drawing.Size(1017, 320);
            this.grbLuong.TabIndex = 1;
            this.grbLuong.TabStop = false;
            this.grbLuong.Text = "Bảng lương của nhân viên";
            // 
            // dgvLuong
            // 
            this.dgvLuong.AllowUserToAddRows = false;
            this.dgvLuong.AllowUserToDeleteRows = false;
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuong.Location = new System.Drawing.Point(3, 16);
            this.dgvLuong.MultiSelect = false;
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.Size = new System.Drawing.Size(1011, 301);
            this.dgvLuong.TabIndex = 0;
            this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(79, 175);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(931, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // grbKhenThuong
            // 
            this.grbKhenThuong.Controls.Add(this.dgvKyLuat);
            this.grbKhenThuong.Controls.Add(this.dgvKhenThuong);
            this.grbKhenThuong.Controls.Add(this.btnLuu);
            this.grbKhenThuong.Controls.Add(this.btnTroVe);
            this.grbKhenThuong.Controls.Add(this.btnHuy);
            this.grbKhenThuong.Controls.Add(this.btnSua);
            this.grbKhenThuong.Controls.Add(this.txtLuongCoBan);
            this.grbKhenThuong.Controls.Add(this.txtLuongTangCa);
            this.grbKhenThuong.Controls.Add(this.label13);
            this.grbKhenThuong.Controls.Add(this.label12);
            this.grbKhenThuong.Controls.Add(this.txtTienKyLuat);
            this.grbKhenThuong.Controls.Add(this.label11);
            this.grbKhenThuong.Controls.Add(this.txtKyLuat);
            this.grbKhenThuong.Controls.Add(this.label10);
            this.grbKhenThuong.Controls.Add(this.txtTienKhenThuong);
            this.grbKhenThuong.Controls.Add(this.label9);
            this.grbKhenThuong.Controls.Add(this.txtKhenThuong);
            this.grbKhenThuong.Controls.Add(this.label8);
            this.grbKhenThuong.Controls.Add(this.nudGioTangCa);
            this.grbKhenThuong.Controls.Add(this.label7);
            this.grbKhenThuong.Controls.Add(this.label6);
            this.grbKhenThuong.Controls.Add(this.label5);
            this.grbKhenThuong.Controls.Add(this.txtNhanVien);
            this.grbKhenThuong.Controls.Add(this.label4);
            this.grbKhenThuong.Controls.Add(this.label14);
            this.grbKhenThuong.Location = new System.Drawing.Point(199, 4);
            this.grbKhenThuong.Name = "grbKhenThuong";
            this.grbKhenThuong.Size = new System.Drawing.Size(811, 165);
            this.grbKhenThuong.TabIndex = 11;
            this.grbKhenThuong.TabStop = false;
            this.grbKhenThuong.Text = "Thông tin lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nhân viên";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(103, 16);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(137, 22);
            this.txtNhanVien.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lương cơ bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lương tăng ca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Giờ tăng ca";
            // 
            // nudGioTangCa
            // 
            this.nudGioTangCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGioTangCa.Location = new System.Drawing.Point(661, 72);
            this.nudGioTangCa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGioTangCa.Name = "nudGioTangCa";
            this.nudGioTangCa.Size = new System.Drawing.Size(57, 22);
            this.nudGioTangCa.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Khen thưởng";
            // 
            // txtTienKhenThuong
            // 
            this.txtTienKhenThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhenThuong.Location = new System.Drawing.Point(661, 16);
            this.txtTienKhenThuong.Name = "txtTienKhenThuong";
            this.txtTienKhenThuong.Size = new System.Drawing.Size(107, 22);
            this.txtTienKhenThuong.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(545, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tiền khen thưởng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kỷ luật";
            // 
            // txtTienKyLuat
            // 
            this.txtTienKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKyLuat.Location = new System.Drawing.Point(661, 44);
            this.txtTienKyLuat.Name = "txtTienKyLuat";
            this.txtTienKyLuat.Size = new System.Drawing.Size(107, 22);
            this.txtTienKyLuat.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(545, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tiền kỷ luật";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(509, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = " - - - >";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(509, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = " - - - >";
            // 
            // txtLuongTangCa
            // 
            this.txtLuongTangCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongTangCa.Location = new System.Drawing.Point(391, 72);
            this.txtLuongTangCa.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtLuongTangCa.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtLuongTangCa.Name = "txtLuongTangCa";
            this.txtLuongTangCa.Size = new System.Drawing.Size(100, 22);
            this.txtLuongTangCa.TabIndex = 30;
            this.txtLuongTangCa.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(103, 44);
            this.txtLuongCoBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtLuongCoBan.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(134, 22);
            this.txtLuongCoBan.TabIndex = 31;
            this.txtLuongCoBan.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(127, 110);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 40);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(289, 110);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 40);
            this.btnTroVe.TabIndex = 34;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(208, 110);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 40);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(46, 110);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtKyLuat
            // 
            this.txtKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyLuat.Location = new System.Drawing.Point(391, 44);
            this.txtKyLuat.Name = "txtKyLuat";
            this.txtKyLuat.Size = new System.Drawing.Size(112, 22);
            this.txtKyLuat.TabIndex = 24;
            this.txtKyLuat.TextChanged += new System.EventHandler(this.txtKyLuat_TextChanged);
            this.txtKyLuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKyLuat_KeyDown);
            this.txtKyLuat.Leave += new System.EventHandler(this.txtKyLuat_Leave);
            // 
            // txtKhenThuong
            // 
            this.txtKhenThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhenThuong.Location = new System.Drawing.Point(391, 16);
            this.txtKhenThuong.Name = "txtKhenThuong";
            this.txtKhenThuong.Size = new System.Drawing.Size(112, 22);
            this.txtKhenThuong.TabIndex = 20;
            this.txtKhenThuong.TextChanged += new System.EventHandler(this.txtKhenThuong_TextChanged);
            this.txtKhenThuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKhenThuong_KeyDown);
            this.txtKhenThuong.Leave += new System.EventHandler(this.txtKhenThuong_Leave);
            // 
            // dgvKhenThuong
            // 
            this.dgvKhenThuong.AllowUserToAddRows = false;
            this.dgvKhenThuong.AllowUserToDeleteRows = false;
            this.dgvKhenThuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhenThuong.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKT,
            this.NoiDung,
            this.TienKT});
            this.dgvKhenThuong.Location = new System.Drawing.Point(391, 38);
            this.dgvKhenThuong.Name = "dgvKhenThuong";
            this.dgvKhenThuong.ReadOnly = true;
            this.dgvKhenThuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhenThuong.Size = new System.Drawing.Size(414, 112);
            this.dgvKhenThuong.TabIndex = 37;
            this.dgvKhenThuong.Visible = false;
            this.dgvKhenThuong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhenThuong_CellDoubleClick);
            this.dgvKhenThuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvKhenThuong_KeyDown);
            this.dgvKhenThuong.Leave += new System.EventHandler(this.dgvKhenThuong_Leave);
            // 
            // dgvKyLuat
            // 
            this.dgvKyLuat.AllowUserToAddRows = false;
            this.dgvKyLuat.AllowUserToDeleteRows = false;
            this.dgvKyLuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyLuat.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKL,
            this.NguyenNhan,
            this.TienKL});
            this.dgvKyLuat.Location = new System.Drawing.Point(400, 66);
            this.dgvKyLuat.Name = "dgvKyLuat";
            this.dgvKyLuat.ReadOnly = true;
            this.dgvKyLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKyLuat.Size = new System.Drawing.Size(405, 93);
            this.dgvKyLuat.TabIndex = 38;
            this.dgvKyLuat.Visible = false;
            this.dgvKyLuat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyLuat_CellDoubleClick);
            this.dgvKyLuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvKyLuat_KeyDown);
            this.dgvKyLuat.Leave += new System.EventHandler(this.dgvKyLuat_Leave);
            // 
            // MaKT
            // 
            this.MaKT.DataPropertyName = "MaKT";
            this.MaKT.FillWeight = 60F;
            this.MaKT.HeaderText = "Mã KT";
            this.MaKT.Name = "MaKT";
            this.MaKT.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // TienKT
            // 
            this.TienKT.DataPropertyName = "QuyDoiRaTienMat";
            this.TienKT.HeaderText = "Tiền KT";
            this.TienKT.Name = "TienKT";
            this.TienKT.ReadOnly = true;
            // 
            // MaKL
            // 
            this.MaKL.DataPropertyName = "MaKL";
            this.MaKL.HeaderText = "Mã KL";
            this.MaKL.Name = "MaKL";
            this.MaKL.ReadOnly = true;
            // 
            // NguyenNhan
            // 
            this.NguyenNhan.DataPropertyName = "NguyenNhan";
            this.NguyenNhan.HeaderText = "Nguyên nhân";
            this.NguyenNhan.Name = "NguyenNhan";
            this.NguyenNhan.ReadOnly = true;
            // 
            // TienKL
            // 
            this.TienKL.DataPropertyName = "QuyDoiRaTienMat";
            this.TienKL.HeaderText = "Tiền KL";
            this.TienKL.Name = "TienKL";
            this.TienKL.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(724, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "giờ";
            // 
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbLuong);
            this.Controls.Add(this.grbNgayThang);
            this.Controls.Add(this.grbKhenThuong);
            this.Name = "BangLuong";
            this.Size = new System.Drawing.Size(1024, 526);
            this.Load += new System.EventHandler(this.BangLuong_Load);
            this.grbNgayThang.ResumeLayout(false);
            this.grbNgayThang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            this.grbLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.grbKhenThuong.ResumeLayout(false);
            this.grbKhenThuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGioTangCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongTangCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCoBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNgayThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.GroupBox grbLuong;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbKhenThuong;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTienKyLuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienKhenThuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudGioTangCa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtLuongCoBan;
        private System.Windows.Forms.NumericUpDown txtLuongTangCa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtKyLuat;
        private System.Windows.Forms.TextBox txtKhenThuong;
        private System.Windows.Forms.DataGridView dgvKyLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKL;
        private System.Windows.Forms.DataGridView dgvKhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKT;
        private System.Windows.Forms.Label label14;
    }
}
