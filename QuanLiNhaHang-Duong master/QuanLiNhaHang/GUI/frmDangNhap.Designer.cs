namespace QuanLiNhaHang.GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.bunifuSeparator10 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.bunifuSeparator9 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbTroLai = new System.Windows.Forms.Label();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtTaoMK = new System.Windows.Forms.TextBox();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtTaoTen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaoDangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator10
            // 
            this.bunifuSeparator10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator10.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator10.LineThickness = 1;
            this.bunifuSeparator10.Location = new System.Drawing.Point(233, 14);
            this.bunifuSeparator10.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator10.Name = "bunifuSeparator10";
            this.bunifuSeparator10.Size = new System.Drawing.Size(203, 16);
            this.bunifuSeparator10.TabIndex = 12;
            this.bunifuSeparator10.Transparency = 255;
            this.bunifuSeparator10.Vertical = false;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(57, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tạo tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Register);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(61, 165);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(280, 4);
            this.bunifuSeparator4.TabIndex = 7;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.txtMatKhau.Location = new System.Drawing.Point(57, 134);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(279, 27);
            this.txtMatKhau.TabIndex = 6;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.Enter2);
            this.txtMatKhau.Leave += new System.EventHandler(this.Leave2);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(57, 104);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(280, 4);
            this.bunifuSeparator3.TabIndex = 5;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDangNhap.ForeColor = System.Drawing.Color.Gray;
            this.txtDangNhap.Location = new System.Drawing.Point(59, 74);
            this.txtDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDangNhap.Multiline = true;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(279, 27);
            this.txtDangNhap.TabIndex = 0;
            this.txtDangNhap.Text = "Tên đăng nhập";
            this.txtDangNhap.Enter += new System.EventHandler(this.Enter1);
            this.txtDangNhap.Leave += new System.EventHandler(this.Leave1);
            // 
            // bunifuSeparator9
            // 
            this.bunifuSeparator9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator9.LineThickness = 3;
            this.bunifuSeparator9.Location = new System.Drawing.Point(44, 14);
            this.bunifuSeparator9.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator9.Name = "bunifuSeparator9";
            this.bunifuSeparator9.Size = new System.Drawing.Size(192, 16);
            this.bunifuSeparator9.TabIndex = 13;
            this.bunifuSeparator9.Transparency = 255;
            this.bunifuSeparator9.Vertical = false;
            // 
            // lbTroLai
            // 
            this.lbTroLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTroLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTroLai.ForeColor = System.Drawing.Color.White;
            this.lbTroLai.Location = new System.Drawing.Point(88, 340);
            this.lbTroLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTroLai.Name = "lbTroLai";
            this.lbTroLai.Size = new System.Drawing.Size(280, 28);
            this.lbTroLai.TabIndex = 12;
            this.lbTroLai.Text = "Trở lại";
            this.lbTroLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTroLai.Click += new System.EventHandler(this.Register);
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator7.LineThickness = 2;
            this.bunifuSeparator7.Location = new System.Drawing.Point(88, 214);
            this.bunifuSeparator7.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(280, 4);
            this.bunifuSeparator7.TabIndex = 19;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // txtTaoMK
            // 
            this.txtTaoMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txtTaoMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaoMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTaoMK.ForeColor = System.Drawing.Color.White;
            this.txtTaoMK.Location = new System.Drawing.Point(89, 102);
            this.txtTaoMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaoMK.Multiline = true;
            this.txtTaoMK.Name = "txtTaoMK";
            this.txtTaoMK.Size = new System.Drawing.Size(279, 27);
            this.txtTaoMK.TabIndex = 16;
            this.txtTaoMK.Text = "Mật khẩu";
            this.txtTaoMK.Enter += new System.EventHandler(this.Enter5);
            this.txtTaoMK.Leave += new System.EventHandler(this.Leave5);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txtXacNhanMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtXacNhanMK.ForeColor = System.Drawing.Color.White;
            this.txtXacNhanMK.Location = new System.Drawing.Point(89, 183);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtXacNhanMK.Multiline = true;
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(279, 27);
            this.txtXacNhanMK.TabIndex = 18;
            this.txtXacNhanMK.Text = "Xác nhận mật khẩu";
            this.txtXacNhanMK.Enter += new System.EventHandler(this.Enter6);
            this.txtXacNhanMK.Leave += new System.EventHandler(this.Leave6);
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator8.LineThickness = 2;
            this.bunifuSeparator8.Location = new System.Drawing.Point(88, 133);
            this.bunifuSeparator8.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(280, 4);
            this.bunifuSeparator8.TabIndex = 17;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // txtTaoTen
            // 
            this.txtTaoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txtTaoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTaoTen.ForeColor = System.Drawing.Color.White;
            this.txtTaoTen.Location = new System.Drawing.Point(93, 30);
            this.txtTaoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaoTen.Multiline = true;
            this.txtTaoTen.Name = "txtTaoTen";
            this.txtTaoTen.Size = new System.Drawing.Size(279, 27);
            this.txtTaoTen.TabIndex = 12;
            this.txtTaoTen.Text = "Tên đăng nhập";
            this.txtTaoTen.Enter += new System.EventHandler(this.Enter3);
            this.txtTaoTen.Leave += new System.EventHandler(this.Leave3);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.lbTroLai);
            this.panel2.Controls.Add(this.btnTaoDangNhap);
            this.panel2.Controls.Add(this.bunifuSeparator7);
            this.panel2.Controls.Add(this.txtTaoMK);
            this.panel2.Controls.Add(this.txtXacNhanMK);
            this.panel2.Controls.Add(this.bunifuSeparator8);
            this.panel2.Controls.Add(this.txtTaoTen);
            this.panel2.Controls.Add(this.bunifuSeparator6);
            this.panel2.Location = new System.Drawing.Point(486, 207);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 398);
            this.panel2.TabIndex = 10;
            // 
            // btnTaoDangNhap
            // 
            this.btnTaoDangNhap.ActiveBorderThickness = 1;
            this.btnTaoDangNhap.ActiveCornerRadius = 30;
            this.btnTaoDangNhap.ActiveFillColor = System.Drawing.Color.White;
            this.btnTaoDangNhap.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnTaoDangNhap.ActiveLineColor = System.Drawing.Color.White;
            this.btnTaoDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnTaoDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoDangNhap.BackgroundImage")));
            this.btnTaoDangNhap.ButtonText = "Tạo tài khoản";
            this.btnTaoDangNhap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnTaoDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTaoDangNhap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTaoDangNhap.IdleBorderThickness = 1;
            this.btnTaoDangNhap.IdleCornerRadius = 30;
            this.btnTaoDangNhap.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnTaoDangNhap.IdleForecolor = System.Drawing.Color.White;
            this.btnTaoDangNhap.IdleLineColor = System.Drawing.Color.White;
            this.btnTaoDangNhap.Location = new System.Drawing.Point(89, 267);
            this.btnTaoDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnTaoDangNhap.Name = "btnTaoDangNhap";
            this.btnTaoDangNhap.Size = new System.Drawing.Size(283, 58);
            this.btnTaoDangNhap.TabIndex = 12;
            this.btnTaoDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTaoDangNhap.Click += new System.EventHandler(this.btnTaoDangNhap_Click);
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator6.LineThickness = 2;
            this.bunifuSeparator6.Location = new System.Drawing.Point(92, 60);
            this.bunifuSeparator6.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(280, 4);
            this.bunifuSeparator6.TabIndex = 13;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.bunifuSeparator4);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.txtDangNhap);
            this.panel1.Location = new System.Drawing.Point(13, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 398);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::QuanLiNhaHang.Properties.Resources.Edit_48px;
            this.pictureBox2.Location = new System.Drawing.Point(359, 133);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lockun);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ActiveBorderThickness = 1;
            this.btnDangNhap.ActiveCornerRadius = 30;
            this.btnDangNhap.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnDangNhap.ActiveForecolor = System.Drawing.Color.White;
            this.btnDangNhap.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.BackgroundImage")));
            this.btnDangNhap.ButtonText = "Đăng nhập";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDangNhap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDangNhap.IdleBorderThickness = 1;
            this.btnDangNhap.IdleCornerRadius = 30;
            this.btnDangNhap.IdleFillColor = System.Drawing.Color.White;
            this.btnDangNhap.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnDangNhap.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnDangNhap.Location = new System.Drawing.Point(56, 195);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(283, 58);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 617);
            this.Controls.Add(this.bunifuSeparator10);
            this.Controls.Add(this.bunifuSeparator9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDangNhap;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.TextBox txtDangNhap;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTroLai;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTaoDangNhap;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private System.Windows.Forms.TextBox txtTaoMK;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private System.Windows.Forms.TextBox txtTaoTen;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private System.Windows.Forms.Panel panel1;
    }
}