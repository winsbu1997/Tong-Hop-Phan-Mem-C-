namespace QuanLiNhaHang.GUI
{
    partial class QuanLiKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiKhachHang));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.dgvKhachHangMain = new DevExpress.XtraGrid.GridControl();
            this.dgvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxFindIdorTen = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.grcKhachHang = new DevExpress.XtraEditors.GroupControl();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.ptbKH = new System.Windows.Forms.PictureBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHangMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).BeginInit();
            this.grcKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHangMain
            // 
            this.dgvKhachHangMain.Location = new System.Drawing.Point(869, 79);
            this.dgvKhachHangMain.MainView = this.dgvKhachHang;
            this.dgvKhachHangMain.Name = "dgvKhachHangMain";
            this.dgvKhachHangMain.Size = new System.Drawing.Size(861, 493);
            this.dgvKhachHangMain.TabIndex = 67;
            this.dgvKhachHangMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvKhachHang});
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dgvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.TenKH,
            this.Sdt,
            this.DiaChi});
            this.dgvKhachHang.GridControl = this.dgvKhachHangMain;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvKhachHang.OptionsView.ShowGroupPanel = false;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã Khách Hàng";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên Khách Hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            // 
            // Sdt
            // 
            this.Sdt.Caption = "Số Điện Thoại";
            this.Sdt.FieldName = "Sdt";
            this.Sdt.Name = "Sdt";
            this.Sdt.Visible = true;
            this.Sdt.VisibleIndex = 2;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            // 
            // cbxFindIdorTen
            // 
            this.cbxFindIdorTen.FormattingEnabled = true;
            this.cbxFindIdorTen.Location = new System.Drawing.Point(977, 27);
            this.cbxFindIdorTen.Name = "cbxFindIdorTen";
            this.cbxFindIdorTen.Size = new System.Drawing.Size(164, 24);
            this.cbxFindIdorTen.TabIndex = 66;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(1181, 27);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(331, 22);
            this.txtFind.TabIndex = 65;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(287, 303);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(202, 84);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1651, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 23);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(866, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Tìm kiếm";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(524, 303);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 84);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1543, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(73, 23);
            this.btnFind.TabIndex = 61;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(402, 441);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(202, 86);
            this.btnThoat.TabIndex = 60;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(39, 303);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 84);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCapNhat.Location = new System.Drawing.Point(153, 441);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(202, 86);
            this.btnCapNhat.TabIndex = 59;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // grcKhachHang
            // 
            this.grcKhachHang.Controls.Add(this.txtSdt);
            this.grcKhachHang.Controls.Add(this.ptbKH);
            this.grcKhachHang.Controls.Add(this.txtMaKH);
            this.grcKhachHang.Controls.Add(this.txtDiaChi);
            this.grcKhachHang.Controls.Add(this.label5);
            this.grcKhachHang.Controls.Add(this.txtTenKH);
            this.grcKhachHang.Controls.Add(this.label6);
            this.grcKhachHang.Controls.Add(this.label3);
            this.grcKhachHang.Controls.Add(this.label2);
            this.grcKhachHang.Location = new System.Drawing.Point(39, 32);
            this.grcKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.grcKhachHang.Name = "grcKhachHang";
            this.grcKhachHang.Size = new System.Drawing.Size(687, 225);
            this.grcKhachHang.TabIndex = 56;
            this.grcKhachHang.Text = "Thông tin chi tiết khách hàng";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(145, 127);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(220, 23);
            this.txtSdt.TabIndex = 29;
            // 
            // ptbKH
            // 
            this.ptbKH.ErrorImage = null;
            this.ptbKH.Location = new System.Drawing.Point(415, 41);
            this.ptbKH.Name = "ptbKH";
            this.ptbKH.Size = new System.Drawing.Size(256, 166);
            this.ptbKH.TabIndex = 26;
            this.ptbKH.TabStop = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(145, 41);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(220, 23);
            this.txtMaKH.TabIndex = 19;
            this.txtMaKH.TabStop = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(145, 172);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(220, 23);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(145, 81);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(220, 23);
            this.txtTenKH.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuanLiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvKhachHangMain);
            this.Controls.Add(this.cbxFindIdorTen);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grcKhachHang);
            this.Name = "QuanLiKhachHang";
            this.Size = new System.Drawing.Size(1786, 664);
            this.Load += new System.EventHandler(this.QuanLiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHangMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).EndInit();
            this.grcKhachHang.ResumeLayout(false);
            this.grcKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private DevExpress.XtraGrid.GridControl dgvKhachHangMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKhachHang;
        private System.Windows.Forms.ComboBox cbxFindIdorTen;
        private System.Windows.Forms.TextBox txtFind;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Button btnFind;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.GroupControl grcKhachHang;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.PictureBox ptbKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn Sdt;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private System.Windows.Forms.Button button1;
    }
}
