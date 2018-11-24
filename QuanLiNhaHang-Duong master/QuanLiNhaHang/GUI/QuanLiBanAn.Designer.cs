namespace QuanLiNhaHang.GUI
{
    partial class QuanLiBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiBanAn));
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvBanAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoCho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvBanAnMain = new DevExpress.XtraGrid.GridControl();
            this.txtMaBA = new System.Windows.Forms.TextBox();
            this.ptbBA = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.grcBanAn = new DevExpress.XtraEditors.GroupControl();
            this.txtSoCho = new System.Windows.Forms.NumericUpDown();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMaHDB = new System.Windows.Forms.ComboBox();
            this.cbxViTri = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBanAn)).BeginInit();
            this.grcBanAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCho)).BeginInit();
            this.SuspendLayout();
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng Thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 3;
            // 
            // MaHDB
            // 
            this.MaHDB.Caption = "Mã Hóa Đơn Bán";
            this.MaHDB.FieldName = "MaHDB";
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.Visible = true;
            this.MaHDB.VisibleIndex = 1;
            // 
            // MaBA
            // 
            this.MaBA.Caption = "Mã Bàn Ăn";
            this.MaBA.FieldName = "MaBA";
            this.MaBA.Name = "MaBA";
            this.MaBA.Visible = true;
            this.MaBA.VisibleIndex = 0;
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaBA,
            this.MaHDB,
            this.SoCho,
            this.TrangThai,
            this.ViTri});
            this.dgvBanAn.GridControl = this.dgvBanAnMain;
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvBanAn.OptionsFind.AlwaysVisible = true;
            this.dgvBanAn.OptionsView.ShowGroupPanel = false;
            // 
            // SoCho
            // 
            this.SoCho.Caption = "Trạng Thái";
            this.SoCho.FieldName = "SoCho";
            this.SoCho.Name = "SoCho";
            this.SoCho.Visible = true;
            this.SoCho.VisibleIndex = 2;
            // 
            // ViTri
            // 
            this.ViTri.Caption = "Vị Trí";
            this.ViTri.FieldName = "ViTri";
            this.ViTri.Name = "ViTri";
            this.ViTri.Visible = true;
            this.ViTri.VisibleIndex = 4;
            // 
            // dgvBanAnMain
            // 
            this.dgvBanAnMain.Location = new System.Drawing.Point(755, 17);
            this.dgvBanAnMain.MainView = this.dgvBanAn;
            this.dgvBanAnMain.Name = "dgvBanAnMain";
            this.dgvBanAnMain.Size = new System.Drawing.Size(841, 557);
            this.dgvBanAnMain.TabIndex = 86;
            this.dgvBanAnMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBanAn});
            // 
            // txtMaBA
            // 
            this.txtMaBA.Location = new System.Drawing.Point(145, 41);
            this.txtMaBA.Name = "txtMaBA";
            this.txtMaBA.Size = new System.Drawing.Size(220, 23);
            this.txtMaBA.TabIndex = 31;
            // 
            // ptbBA
            // 
            this.ptbBA.ErrorImage = null;
            this.ptbBA.Location = new System.Drawing.Point(413, 56);
            this.ptbBA.Name = "ptbBA";
            this.ptbBA.Size = new System.Drawing.Size(256, 195);
            this.ptbBA.TabIndex = 26;
            this.ptbBA.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vị Trí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã HDB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Bàn Ăn ";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(254, 361);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(202, 84);
            this.btnSua.TabIndex = 85;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(488, 361);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 84);
            this.btnXoa.TabIndex = 82;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(373, 488);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(202, 86);
            this.btnThoat.TabIndex = 84;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(0, 361);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 84);
            this.btnThem.TabIndex = 81;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCapNhat.Location = new System.Drawing.Point(82, 488);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(202, 86);
            this.btnCapNhat.TabIndex = 83;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // grcBanAn
            // 
            this.grcBanAn.Controls.Add(this.cbxViTri);
            this.grcBanAn.Controls.Add(this.cbxMaHDB);
            this.grcBanAn.Controls.Add(this.txtSoCho);
            this.grcBanAn.Controls.Add(this.cbxTrangThai);
            this.grcBanAn.Controls.Add(this.label1);
            this.grcBanAn.Controls.Add(this.txtMaBA);
            this.grcBanAn.Controls.Add(this.ptbBA);
            this.grcBanAn.Controls.Add(this.label5);
            this.grcBanAn.Controls.Add(this.label6);
            this.grcBanAn.Controls.Add(this.label3);
            this.grcBanAn.Controls.Add(this.label2);
            this.grcBanAn.Location = new System.Drawing.Point(3, 17);
            this.grcBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.grcBanAn.Name = "grcBanAn";
            this.grcBanAn.Size = new System.Drawing.Size(687, 282);
            this.grcBanAn.TabIndex = 80;
            this.grcBanAn.Text = "Thông tin chi tiết bàn ăn";
            // 
            // txtSoCho
            // 
            this.txtSoCho.Location = new System.Drawing.Point(145, 130);
            this.txtSoCho.Name = "txtSoCho";
            this.txtSoCho.Size = new System.Drawing.Size(220, 23);
            this.txtSoCho.TabIndex = 38;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Location = new System.Drawing.Point(145, 183);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(220, 24);
            this.cbxTrangThai.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Số Chỗ";
            // 
            // cbxMaHDB
            // 
            this.cbxMaHDB.FormattingEnabled = true;
            this.cbxMaHDB.Location = new System.Drawing.Point(145, 80);
            this.cbxMaHDB.Name = "cbxMaHDB";
            this.cbxMaHDB.Size = new System.Drawing.Size(220, 24);
            this.cbxMaHDB.TabIndex = 39;
            // 
            // cbxViTri
            // 
            this.cbxViTri.FormattingEnabled = true;
            this.cbxViTri.Location = new System.Drawing.Point(145, 247);
            this.cbxViTri.Name = "cbxViTri";
            this.cbxViTri.Size = new System.Drawing.Size(220, 24);
            this.cbxViTri.TabIndex = 40;
            // 
            // QuanLiBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvBanAnMain);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grcBanAn);
            this.Name = "QuanLiBanAn";
            this.Size = new System.Drawing.Size(1632, 625);
            this.Load += new System.EventHandler(this.QuanLiBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAnMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBanAn)).EndInit();
            this.grcBanAn.ResumeLayout(false);
            this.grcBanAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn MaHDB;
        private DevExpress.XtraGrid.Columns.GridColumn MaBA;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBanAn;
        private DevExpress.XtraGrid.Columns.GridColumn SoCho;
        private DevExpress.XtraGrid.GridControl dgvBanAnMain;
        private System.Windows.Forms.TextBox txtMaBA;
        private System.Windows.Forms.PictureBox ptbBA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.GroupControl grcBanAn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ViTri;
        private System.Windows.Forms.NumericUpDown txtSoCho;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.ComboBox cbxMaHDB;
        private System.Windows.Forms.ComboBox cbxViTri;
    }
}
