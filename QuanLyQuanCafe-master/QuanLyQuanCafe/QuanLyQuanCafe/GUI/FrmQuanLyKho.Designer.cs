namespace QuanLyQuanCafe.GUI
{
    partial class FrmQuanLyKho
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
            this.dgvHoaDonNhapMain = new DevExpress.XtraGrid.GridControl();
            this.dgvHoaDonNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDonNhapMain
            // 
            this.dgvHoaDonNhapMain.Location = new System.Drawing.Point(12, 30);
            this.dgvHoaDonNhapMain.MainView = this.dgvHoaDonNhap;
            this.dgvHoaDonNhapMain.Name = "dgvHoaDonNhapMain";
            this.dgvHoaDonNhapMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemLookUpEdit1});
            this.dgvHoaDonNhapMain.Size = new System.Drawing.Size(568, 294);
            this.dgvHoaDonNhapMain.TabIndex = 4;
            this.dgvHoaDonNhapMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHoaDonNhap});
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHDN,
            this.NgayNhap,
            this.NhanVienNhap,
            this.NoiNhap,
            this.TongTien});
            this.dgvHoaDonNhap.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvHoaDonNhap.GridControl = this.dgvHoaDonNhapMain;
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.OptionsBehavior.Editable = false;
            this.dgvHoaDonNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvHoaDonNhap.OptionsFind.AlwaysVisible = true;
            this.dgvHoaDonNhap.OptionsView.ColumnAutoWidth = false;
            this.dgvHoaDonNhap.PaintStyleName = "UltraFlat";
            this.dgvHoaDonNhap.RowHeight = 30;
            // 
            // MAHDN
            // 
            this.MAHDN.Caption = "Mã HĐN";
            this.MAHDN.FieldName = "MAHDN";
            this.MAHDN.Name = "MAHDN";
            this.MAHDN.Visible = true;
            this.MAHDN.VisibleIndex = 0;
            this.MAHDN.Width = 47;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.FieldName = "NGAY";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 1;
            this.NgayNhap.Width = 78;
            // 
            // NhanVienNhap
            // 
            this.NhanVienNhap.Caption = "Nhân viên nhập";
            this.NhanVienNhap.FieldName = "MANV";
            this.NhanVienNhap.Name = "NhanVienNhap";
            this.NhanVienNhap.Visible = true;
            this.NhanVienNhap.VisibleIndex = 2;
            this.NhanVienNhap.Width = 107;
            // 
            // NoiNhap
            // 
            this.NoiNhap.Caption = "Nơi nhập";
            this.NoiNhap.FieldName = "NOINHAP";
            this.NoiNhap.Name = "NoiNhap";
            this.NoiNhap.Visible = true;
            this.NoiNhap.VisibleIndex = 3;
            this.NoiNhap.Width = 233;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng tiền";
            this.TongTien.FieldName = "TONGTIEN";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 4;
            this.TongTien.Width = 86;
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
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin kho";
            // 
            // FrmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDonNhapMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvHoaDonNhapMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHoaDonNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MAHDN;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienNhap;
        private DevExpress.XtraGrid.Columns.GridColumn NoiNhap;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.Label label1;

    }
}