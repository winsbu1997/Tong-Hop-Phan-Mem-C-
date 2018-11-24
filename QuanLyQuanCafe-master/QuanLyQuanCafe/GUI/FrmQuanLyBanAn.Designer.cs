namespace QuanLyQuanCafe.GUI
{
    partial class FrmQuanLyBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyBanAn));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBanAnMain = new DevExpress.XtraGrid.GridControl();
            this.dgvBanAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOCHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VITRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtSoCho = new System.Windows.Forms.NumericUpDown();
            this.txtTenBA = new System.Windows.Forms.TextBox();
            this.txtMaBA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách bàn ăn";
            // 
            // dgvBanAnMain
            // 
            this.dgvBanAnMain.Location = new System.Drawing.Point(34, 29);
            this.dgvBanAnMain.MainView = this.dgvBanAn;
            this.dgvBanAnMain.Name = "dgvBanAnMain";
            this.dgvBanAnMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.dgvBanAnMain.Size = new System.Drawing.Size(431, 396);
            this.dgvBanAnMain.TabIndex = 2;
            this.dgvBanAnMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBanAn});
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaBA,
            this.TenBA,
            this.SOCHO,
            this.VITRI});
            this.dgvBanAn.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvBanAn.GridControl = this.dgvBanAnMain;
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.OptionsBehavior.Editable = false;
            this.dgvBanAn.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvBanAn.OptionsFind.AlwaysVisible = true;
            this.dgvBanAn.PaintStyleName = "UltraFlat";
            this.dgvBanAn.RowHeight = 20;
            this.dgvBanAn.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dgvBanAn_InitNewRow);
            // 
            // MaBA
            // 
            this.MaBA.Caption = "Mã bàn ăn";
            this.MaBA.FieldName = "MABA";
            this.MaBA.Name = "MaBA";
            this.MaBA.Width = 78;
            // 
            // TenBA
            // 
            this.TenBA.Caption = "Tên bàn";
            this.TenBA.FieldName = "TENBA";
            this.TenBA.Name = "TenBA";
            this.TenBA.Visible = true;
            this.TenBA.VisibleIndex = 0;
            this.TenBA.Width = 135;
            // 
            // SOCHO
            // 
            this.SOCHO.Caption = "Số chỗ";
            this.SOCHO.FieldName = "SOCHO";
            this.SOCHO.Name = "SOCHO";
            this.SOCHO.Visible = true;
            this.SOCHO.VisibleIndex = 1;
            this.SOCHO.Width = 81;
            // 
            // VITRI
            // 
            this.VITRI.Caption = "Vị trí";
            this.VITRI.FieldName = "VITRI";
            this.VITRI.Name = "VITRI";
            this.VITRI.Visible = true;
            this.VITRI.VisibleIndex = 2;
            this.VITRI.Width = 200;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(671, 363);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(178, 62);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Đóng chức năng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(671, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(178, 62);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCapNhat.Location = new System.Drawing.Point(484, 363);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(178, 62);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(484, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(178, 62);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtViTri);
            this.groupControl1.Controls.Add(this.txtSoCho);
            this.groupControl1.Controls.Add(this.txtTenBA);
            this.groupControl1.Controls.Add(this.txtMaBA);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(484, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 260);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin chi tiết bàn ăn";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(95, 147);
            this.txtViTri.Multiline = true;
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(233, 85);
            this.txtViTri.TabIndex = 9;
            // 
            // txtSoCho
            // 
            this.txtSoCho.Location = new System.Drawing.Point(95, 104);
            this.txtSoCho.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoCho.Name = "txtSoCho";
            this.txtSoCho.Size = new System.Drawing.Size(116, 21);
            this.txtSoCho.TabIndex = 8;
            this.txtSoCho.ThousandsSeparator = true;
            // 
            // txtTenBA
            // 
            this.txtTenBA.Location = new System.Drawing.Point(95, 68);
            this.txtTenBA.Name = "txtTenBA";
            this.txtTenBA.Size = new System.Drawing.Size(233, 21);
            this.txtTenBA.TabIndex = 6;
            // 
            // txtMaBA
            // 
            this.txtMaBA.AutoSize = true;
            this.txtMaBA.Location = new System.Drawing.Point(107, 38);
            this.txtMaBA.Name = "txtMaBA";
            this.txtMaBA.Size = new System.Drawing.Size(13, 13);
            this.txtMaBA.TabIndex = 5;
            this.txtMaBA.Text = "1";
            this.txtMaBA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vị trí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số chỗ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bàn ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bàn ăn";
            // 
            // FrmQuanLyBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 445);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvBanAnMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn ăn";
            this.Load += new System.EventHandler(this.FrmQuanLyBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAnMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgvBanAnMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBanAn;
        private DevExpress.XtraGrid.Columns.GridColumn MaBA;
        private DevExpress.XtraGrid.Columns.GridColumn TenBA;
        private DevExpress.XtraGrid.Columns.GridColumn SOCHO;
        private DevExpress.XtraGrid.Columns.GridColumn VITRI;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.NumericUpDown txtSoCho;
        private System.Windows.Forms.TextBox txtTenBA;
        private System.Windows.Forms.Label txtMaBA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViTri;
    }
}