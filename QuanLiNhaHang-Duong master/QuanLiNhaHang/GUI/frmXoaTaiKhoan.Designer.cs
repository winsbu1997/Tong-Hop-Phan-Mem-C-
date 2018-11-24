namespace QuanLiNhaHang.GUI
{
    partial class frmXoaTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaTaiKhoan));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.grvTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.ActiveBorderThickness = 1;
            this.btnThoat.ActiveCornerRadius = 20;
            this.btnThoat.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.ActiveForecolor = System.Drawing.Color.White;
            this.btnThoat.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Crimson;
            this.btnThoat.IdleBorderThickness = 1;
            this.btnThoat.IdleCornerRadius = 20;
            this.btnThoat.IdleFillColor = System.Drawing.Color.White;
            this.btnThoat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThoat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.Location = new System.Drawing.Point(223, 336);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 41);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.Location = new System.Drawing.Point(1, 3);
            this.dgvTaiKhoan.MainView = this.grvTaiKhoan;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.dgvTaiKhoan.Size = new System.Drawing.Size(641, 326);
            this.dgvTaiKhoan.TabIndex = 4;
            this.dgvTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTaiKhoan});
            // 
            // grvTaiKhoan
            // 
            this.grvTaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDangNhap,
            this.MatKhau,
            this.button});
            this.grvTaiKhoan.GridControl = this.dgvTaiKhoan;
            this.grvTaiKhoan.Name = "grvTaiKhoan";
            this.grvTaiKhoan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic;
            this.grvTaiKhoan.OptionsFind.AlwaysVisible = true;
            this.grvTaiKhoan.OptionsView.ShowGroupPanel = false;
            // 
            // IdDangNhap
            // 
            this.IdDangNhap.Caption = "Tên Đăng Nhập";
            this.IdDangNhap.FieldName = "IdDangNhap";
            this.IdDangNhap.Name = "IdDangNhap";
            this.IdDangNhap.Visible = true;
            this.IdDangNhap.VisibleIndex = 0;
            // 
            // MatKhau
            // 
            this.MatKhau.Caption = "Mật Khẩu";
            this.MatKhau.FieldName = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = true;
            this.MatKhau.VisibleIndex = 1;
            // 
            // button
            // 
            this.button.Caption = "Xóa";
            this.button.ColumnEdit = this.repositoryItemButtonEdit1;
            this.button.Name = "button";
            this.button.Visible = true;
            this.button.VisibleIndex = 2;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // frmXoaTaiKhoan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 391);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXoaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXoaTaiKhoan";
            this.Load += new System.EventHandler(this.frmXoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnThoat;
        private DevExpress.XtraGrid.GridControl dgvTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn IdDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn button;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}