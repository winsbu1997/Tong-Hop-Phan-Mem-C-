namespace QuanLiNhaHang.GUI
{
    partial class QuanLiNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiNguyenLieu));
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.grcNguyenLieu = new DevExpress.XtraEditors.GroupControl();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.NumericUpDown();
            this.ptbNL = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNguyenLieuMain = new DevExpress.XtraGrid.GridControl();
            this.dgvNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcNguyenLieu)).BeginInit();
            this.grcNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(270, 342);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(202, 84);
            this.btnSua.TabIndex = 76;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(507, 342);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 84);
            this.btnXoa.TabIndex = 70;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(385, 480);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(202, 86);
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(22, 342);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 84);
            this.btnThem.TabIndex = 69;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCapNhat.Location = new System.Drawing.Point(136, 480);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(202, 86);
            this.btnCapNhat.TabIndex = 71;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // grcNguyenLieu
            // 
            this.grcNguyenLieu.Controls.Add(this.txtDVT);
            this.grcNguyenLieu.Controls.Add(this.txtTenNL);
            this.grcNguyenLieu.Controls.Add(this.txtMaNL);
            this.grcNguyenLieu.Controls.Add(this.txtDonGia);
            this.grcNguyenLieu.Controls.Add(this.ptbNL);
            this.grcNguyenLieu.Controls.Add(this.label5);
            this.grcNguyenLieu.Controls.Add(this.label6);
            this.grcNguyenLieu.Controls.Add(this.label3);
            this.grcNguyenLieu.Controls.Add(this.label2);
            this.grcNguyenLieu.Location = new System.Drawing.Point(22, 71);
            this.grcNguyenLieu.Margin = new System.Windows.Forms.Padding(4);
            this.grcNguyenLieu.Name = "grcNguyenLieu";
            this.grcNguyenLieu.Size = new System.Drawing.Size(687, 225);
            this.grcNguyenLieu.TabIndex = 68;
            this.grcNguyenLieu.Text = "Thông tin chi tiết nguyên liệu";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(145, 130);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(220, 23);
            this.txtDVT.TabIndex = 33;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(145, 87);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(220, 23);
            this.txtTenNL.TabIndex = 32;
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(145, 41);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(220, 23);
            this.txtMaNL.TabIndex = 31;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(145, 173);
            this.txtDonGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(220, 23);
            this.txtDonGia.TabIndex = 30;
            // 
            // ptbNL
            // 
            this.ptbNL.ErrorImage = null;
            this.ptbNL.Location = new System.Drawing.Point(415, 41);
            this.ptbNL.Name = "ptbNL";
            this.ptbNL.Size = new System.Drawing.Size(256, 166);
            this.ptbNL.TabIndex = 26;
            this.ptbNL.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nguyên Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nguyên Liệu ";
            // 
            // dgvNguyenLieuMain
            // 
            this.dgvNguyenLieuMain.Location = new System.Drawing.Point(774, 71);
            this.dgvNguyenLieuMain.MainView = this.dgvNguyenLieu;
            this.dgvNguyenLieuMain.Name = "dgvNguyenLieuMain";
            this.dgvNguyenLieuMain.Size = new System.Drawing.Size(801, 557);
            this.dgvNguyenLieuMain.TabIndex = 79;
            this.dgvNguyenLieuMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvNguyenLieu});
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNL,
            this.TenNL,
            this.DonViTinh,
            this.DonGia});
            this.dgvNguyenLieu.GridControl = this.dgvNguyenLieuMain;
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvNguyenLieu.OptionsFind.AlwaysVisible = true;
            this.dgvNguyenLieu.OptionsView.ShowGroupPanel = false;
            // 
            // MaNL
            // 
            this.MaNL.Caption = "Mã Nguyên liệu";
            this.MaNL.FieldName = "MaNL";
            this.MaNL.Name = "MaNL";
            this.MaNL.Visible = true;
            this.MaNL.VisibleIndex = 0;
            // 
            // TenNL
            // 
            this.TenNL.Caption = "Tên Nguyên Liệu";
            this.TenNL.FieldName = "TenNL";
            this.TenNL.Name = "TenNL";
            this.TenNL.Visible = true;
            this.TenNL.VisibleIndex = 1;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị Tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            // 
            // QuanLiNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvNguyenLieuMain);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grcNguyenLieu);
            this.Name = "QuanLiNguyenLieu";
            this.Size = new System.Drawing.Size(1734, 676);
            this.Load += new System.EventHandler(this.QuanLiNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcNguyenLieu)).EndInit();
            this.grcNguyenLieu.ResumeLayout(false);
            this.grcNguyenLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.GroupControl grcNguyenLieu;
        private System.Windows.Forms.PictureBox ptbNL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtDonGia;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.TextBox txtMaNL;
        private DevExpress.XtraGrid.GridControl dgvNguyenLieuMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn MaNL;
        private DevExpress.XtraGrid.Columns.GridColumn TenNL;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
    }
}
