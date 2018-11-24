namespace QuanLyNhanSu.View
{
    partial class FormMain
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
            this.btnHome = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnHeSoLuong = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnKyLuat = new System.Windows.Forms.Button();
            this.btnKhenTHuong = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1783, 169);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnHome);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1775, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Window;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Image = global::QuanLyNhanSu.Properties.Resources.Home_48;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(21, 16);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(153, 113);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnChucVu);
            this.tabPage2.Controls.Add(this.btnPhongBan);
            this.tabPage2.Controls.Add(this.btnNhanVien);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1775, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Nhân Viên";
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackColor = System.Drawing.SystemColors.Window;
            this.btnChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucVu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChucVu.Image = global::QuanLyNhanSu.Properties.Resources.Contract_Job_64;
            this.btnChucVu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChucVu.Location = new System.Drawing.Point(440, 7);
            this.btnChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(153, 113);
            this.btnChucVu.TabIndex = 5;
            this.btnChucVu.Text = "Chức Vụ";
            this.btnChucVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChucVu.UseVisualStyleBackColor = false;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.BackColor = System.Drawing.SystemColors.Window;
            this.btnPhongBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPhongBan.Image = global::QuanLyNhanSu.Properties.Resources.Post_Office_64;
            this.btnPhongBan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhongBan.Location = new System.Drawing.Point(220, 7);
            this.btnPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(153, 113);
            this.btnPhongBan.TabIndex = 4;
            this.btnPhongBan.Text = "Phòng Ban";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhongBan.UseVisualStyleBackColor = false;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhanVien.Image = global::QuanLyNhanSu.Properties.Resources.Worker_Male_48;
            this.btnNhanVien.Location = new System.Drawing.Point(8, 7);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(153, 113);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnHeSoLuong);
            this.tabPage3.Controls.Add(this.btnHopDong);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1775, 140);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hợp Đồng";
            // 
            // btnHeSoLuong
            // 
            this.btnHeSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.btnHeSoLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeSoLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHeSoLuong.Image = global::QuanLyNhanSu.Properties.Resources.Payroll_64;
            this.btnHeSoLuong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHeSoLuong.Location = new System.Drawing.Point(237, 7);
            this.btnHeSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHeSoLuong.Name = "btnHeSoLuong";
            this.btnHeSoLuong.Size = new System.Drawing.Size(153, 113);
            this.btnHeSoLuong.TabIndex = 6;
            this.btnHeSoLuong.Text = "Hệ Số Lương";
            this.btnHeSoLuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHeSoLuong.UseVisualStyleBackColor = false;
            this.btnHeSoLuong.Click += new System.EventHandler(this.btnHeSoLuong_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.SystemColors.Window;
            this.btnHopDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHopDong.Image = global::QuanLyNhanSu.Properties.Resources.Helping_Hand_64;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHopDong.Location = new System.Drawing.Point(24, 7);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(153, 113);
            this.btnHopDong.TabIndex = 5;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.btnKyLuat);
            this.tabPage4.Controls.Add(this.btnKhenTHuong);
            this.tabPage4.Controls.Add(this.btnBangLuong);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(1775, 140);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bảng Lương";
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.BackColor = System.Drawing.SystemColors.Window;
            this.btnKyLuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyLuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKyLuat.Image = global::QuanLyNhanSu.Properties.Resources.No_Cash_48;
            this.btnKyLuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKyLuat.Location = new System.Drawing.Point(433, 7);
            this.btnKyLuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.Size = new System.Drawing.Size(153, 113);
            this.btnKyLuat.TabIndex = 9;
            this.btnKyLuat.Text = "Kỷ Luật";
            this.btnKyLuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKyLuat.UseVisualStyleBackColor = false;
            this.btnKyLuat.Click += new System.EventHandler(this.btnKyLuat_Click);
            // 
            // btnKhenTHuong
            // 
            this.btnKhenTHuong.BackColor = System.Drawing.SystemColors.Window;
            this.btnKhenTHuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKhenTHuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhenTHuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKhenTHuong.Image = global::QuanLyNhanSu.Properties.Resources.Receive_Cash_64;
            this.btnKhenTHuong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKhenTHuong.Location = new System.Drawing.Point(220, 7);
            this.btnKhenTHuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhenTHuong.Name = "btnKhenTHuong";
            this.btnKhenTHuong.Size = new System.Drawing.Size(153, 113);
            this.btnKhenTHuong.TabIndex = 8;
            this.btnKhenTHuong.Text = "Khen Thưởng";
            this.btnKhenTHuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKhenTHuong.UseVisualStyleBackColor = false;
            this.btnKhenTHuong.Click += new System.EventHandler(this.btnKhenTHuong_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.BackColor = System.Drawing.SystemColors.Window;
            this.btnBangLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBangLuong.Image = global::QuanLyNhanSu.Properties.Resources.Money_50;
            this.btnBangLuong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBangLuong.Location = new System.Drawing.Point(8, 7);
            this.btnBangLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(153, 113);
            this.btnBangLuong.TabIndex = 7;
            this.btnBangLuong.Text = "Bảng Lương";
            this.btnBangLuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBangLuong.UseVisualStyleBackColor = false;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(21, 186);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1779, 711);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 902);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnHeSoLuong;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnKyLuat;
        private System.Windows.Forms.Button btnKhenTHuong;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}