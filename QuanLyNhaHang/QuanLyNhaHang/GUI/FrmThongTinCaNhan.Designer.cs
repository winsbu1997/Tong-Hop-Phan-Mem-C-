namespace BTL_CNPM.GUI
{
    partial class FrmThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinCaNhan));
            this.imgAnh = new System.Windows.Forms.PictureBox();
            this.txtTitleTen = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxChucVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtQueQuan = new DevExpress.XtraEditors.MemoEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTitleChucVu = new System.Windows.Forms.Label();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgAnh
            // 
            this.imgAnh.BackColor = System.Drawing.Color.White;
            this.imgAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAnh.Location = new System.Drawing.Point(16, 4);
            this.imgAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgAnh.Name = "imgAnh";
            this.imgAnh.Size = new System.Drawing.Size(159, 196);
            this.imgAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAnh.TabIndex = 3;
            this.imgAnh.TabStop = false;
            this.imgAnh.WaitOnLoad = true;
            this.imgAnh.Click += new System.EventHandler(this.imgAnh_Click);
            // 
            // txtTitleTen
            // 
            this.txtTitleTen.AutoSize = true;
            this.txtTitleTen.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleTen.ForeColor = System.Drawing.Color.Black;
            this.txtTitleTen.Location = new System.Drawing.Point(205, 63);
            this.txtTitleTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitleTen.Name = "txtTitleTen";
            this.txtTitleTen.Size = new System.Drawing.Size(304, 49);
            this.txtTitleTen.TabIndex = 1;
            this.txtTitleTen.Text = "Phạm Thị Quỳnh";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.Location = new System.Drawing.Point(861, 110);
            this.cbxGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxGioiTinh.Properties.Appearance.Options.UseFont = true;
            this.cbxGioiTinh.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxGioiTinh.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxGioiTinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGioiTinh.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxGioiTinh.Properties.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbxGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxGioiTinh.Size = new System.Drawing.Size(292, 28);
            this.cbxGioiTinh.TabIndex = 50;
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.Enabled = false;
            this.cbxChucVu.Location = new System.Drawing.Point(861, 26);
            this.cbxChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxChucVu.Properties.Appearance.Options.UseFont = true;
            this.cbxChucVu.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxChucVu.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxChucVu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChucVu.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxChucVu.Properties.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản trị viên"});
            this.cbxChucVu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxChucVu.Size = new System.Drawing.Size(292, 28);
            this.cbxChucVu.TabIndex = 48;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(299, 110);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dateNgaySinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgaySinh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateNgaySinh.Size = new System.Drawing.Size(209, 28);
            this.dateNgaySinh.TabIndex = 49;
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(971, 487);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(196, 55);
            this.btnDong.TabIndex = 47;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(767, 487);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(196, 55);
            this.btnCapNhat.TabIndex = 46;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(299, 362);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtQueQuan.Properties.Appearance.Options.UseFont = true;
            this.txtQueQuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtQueQuan.Size = new System.Drawing.Size(868, 98);
            this.txtQueQuan.TabIndex = 45;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(299, 277);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtEmail.Size = new System.Drawing.Size(367, 28);
            this.txtEmail.TabIndex = 42;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(299, 193);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtSDT.Size = new System.Drawing.Size(367, 28);
            this.txtSDT.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.imgAnh);
            this.panel5.Controls.Add(this.txtTitleChucVu);
            this.panel5.Controls.Add(this.txtTitleTen);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1241, 210);
            this.panel5.TabIndex = 1;
            // 
            // txtTitleChucVu
            // 
            this.txtTitleChucVu.AutoSize = true;
            this.txtTitleChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtTitleChucVu.Location = new System.Drawing.Point(211, 126);
            this.txtTitleChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitleChucVu.Name = "txtTitleChucVu";
            this.txtTitleChucVu.Size = new System.Drawing.Size(105, 21);
            this.txtTitleChucVu.TabIndex = 2;
            this.txtTitleChucVu.Text = "Quản trị viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(299, 26);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtHoTen.Size = new System.Drawing.Size(367, 28);
            this.txtHoTen.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Số điện thoại :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(737, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "Chức vụ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 366);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Quê quán :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Giới tính : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Họ và tên :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 769);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxGioiTinh);
            this.panel2.Controls.Add(this.cbxChucVu);
            this.panel2.Controls.Add(this.dateNgaySinh);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.txtQueQuan);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 557);
            this.panel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 282);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Email :";
            // 
            // FrmThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 868);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmThongTinCaNhan";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "THÔNG TIN CÁ NHÂN";
            this.Load += new System.EventHandler(this.FrmThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAnh;
        private System.Windows.Forms.Label txtTitleTen;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGioiTinh;
        private DevExpress.XtraEditors.ComboBoxEdit cbxChucVu;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.MemoEdit txtQueQuan;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtTitleChucVu;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
    }
}