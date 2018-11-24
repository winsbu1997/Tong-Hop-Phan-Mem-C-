namespace QuanLyQuanCafe.GUI
{
    partial class FrmQuanLyMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyMatHang));
            this.dgvMatHangMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dvTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuAnh = new DevExpress.XtraEditors.SimpleButton();
            this.imgHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemAnh = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatHangMain
            // 
            this.dgvMatHangMain.Location = new System.Drawing.Point(12, 38);
            this.dgvMatHangMain.MainView = this.dgvMatHang;
            this.dgvMatHangMain.Name = "dgvMatHangMain";
            this.dgvMatHangMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.dgvMatHangMain.Size = new System.Drawing.Size(572, 481);
            this.dgvMatHangMain.TabIndex = 0;
            this.dgvMatHangMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMatHang});
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaMH,
            this.TenMH,
            this.dvTinh,
            this.DONGIA,
            this.HinhAnh});
            this.dgvMatHang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvMatHang.GridControl = this.dgvMatHangMain;
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.OptionsBehavior.Editable = false;
            this.dgvMatHang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvMatHang.OptionsFind.AlwaysVisible = true;
            this.dgvMatHang.PaintStyleName = "UltraFlat";
            this.dgvMatHang.RowHeight = 120;
            this.dgvMatHang.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dgvMatHang_InitNewRow);
            // 
            // MaMH
            // 
            this.MaMH.Caption = "Mã mặt hàng";
            this.MaMH.FieldName = "MAMH";
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 84;
            // 
            // TenMH
            // 
            this.TenMH.Caption = "Tên mặt hàng";
            this.TenMH.FieldName = "TENMH";
            this.TenMH.Name = "TenMH";
            this.TenMH.Visible = true;
            this.TenMH.VisibleIndex = 0;
            this.TenMH.Width = 134;
            // 
            // dvTinh
            // 
            this.dvTinh.Caption = "Đơn vị tính";
            this.dvTinh.FieldName = "DVTINH";
            this.dvTinh.Name = "dvTinh";
            this.dvTinh.Visible = true;
            this.dvTinh.VisibleIndex = 1;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Đơn giá";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 2;
            this.DONGIA.Width = 105;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "Hình ảnh";
            this.HinhAnh.ColumnEdit = this.repositoryItemPictureEdit1;
            this.HinhAnh.FieldName = "HINHANH";
            this.HinhAnh.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = true;
            this.HinhAnh.VisibleIndex = 3;
            this.HinhAnh.Width = 153;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnLuuAnh);
            this.groupControl1.Controls.Add(this.imgHinhAnh);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.btnThemAnh);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtDonViTinh);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.txtMaMH);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(602, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(391, 330);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin chi tiết mặt hàng";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(299, 251);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(87, 33);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Xóa ảnh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnLuuAnh
            // 
            this.btnLuuAnh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuuAnh.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLuuAnh.Location = new System.Drawing.Point(299, 212);
            this.btnLuuAnh.Name = "btnLuuAnh";
            this.btnLuuAnh.Size = new System.Drawing.Size(87, 33);
            this.btnLuuAnh.TabIndex = 11;
            this.btnLuuAnh.Text = "Lưu ảnh";
            this.btnLuuAnh.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // imgHinhAnh
            // 
            this.imgHinhAnh.Location = new System.Drawing.Point(95, 173);
            this.imgHinhAnh.Name = "imgHinhAnh";
            this.imgHinhAnh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.imgHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgHinhAnh.Properties.ZoomAccelerationFactor = 1D;
            this.imgHinhAnh.Size = new System.Drawing.Size(198, 130);
            this.imgHinhAnh.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "VNĐ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThemAnh.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThemAnh.Location = new System.Drawing.Point(299, 173);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(87, 33);
            this.btnThemAnh.TabIndex = 10;
            this.btnThemAnh.Text = "Chọn ảnh";
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(95, 137);
            this.txtDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 21);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.ThousandsSeparator = true;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(95, 103);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(219, 21);
            this.txtDonViTinh.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(95, 68);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(219, 21);
            this.txtTen.TabIndex = 6;
            // 
            // txtMaMH
            // 
            this.txtMaMH.AutoSize = true;
            this.txtMaMH.Location = new System.Drawing.Point(107, 38);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(13, 13);
            this.txtMaMH.TabIndex = 5;
            this.txtMaMH.Text = "1";
            this.txtMaMH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hình ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã mặt hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách các mặt hàng";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(602, 389);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 62);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCapNhat.Location = new System.Drawing.Point(602, 457);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(190, 62);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(803, 389);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(190, 62);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(803, 457);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 62);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Đóng chức năng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 531);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvMatHangMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý mặt hàng";
            this.Load += new System.EventHandler(this.FrmQuanLyMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvMatHangMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMatHang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMaMH;
        private System.Windows.Forms.NumericUpDown txtDonGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.PictureEdit imgHinhAnh;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnThemAnh;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnLuuAnh;
        private DevExpress.XtraGrid.Columns.GridColumn MaMH;
        private DevExpress.XtraGrid.Columns.GridColumn TenMH;
        private DevExpress.XtraGrid.Columns.GridColumn dvTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnh;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}