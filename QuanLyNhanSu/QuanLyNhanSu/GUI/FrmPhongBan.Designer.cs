﻿namespace QuanLyNhanSu.GUI
{
    partial class FrmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongBan));
            this.groupPhongBan = new System.Windows.Forms.GroupBox();
            this.dgvPhongBanMain = new DevExpress.XtraGrid.GridControl();
            this.dgvPhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapTren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.cbxCapTren = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.groupPhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBanMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPhongBan
            // 
            this.groupPhongBan.Controls.Add(this.dgvPhongBanMain);
            this.groupPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPhongBan.Location = new System.Drawing.Point(0, 0);
            this.groupPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPhongBan.Name = "groupPhongBan";
            this.groupPhongBan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPhongBan.Size = new System.Drawing.Size(1469, 476);
            this.groupPhongBan.TabIndex = 7;
            this.groupPhongBan.TabStop = false;
            this.groupPhongBan.Text = "Danh sách chức vụ";
            // 
            // dgvPhongBanMain
            // 
            this.dgvPhongBanMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBanMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhongBanMain.Location = new System.Drawing.Point(4, 19);
            this.dgvPhongBanMain.MainView = this.dgvPhongBan;
            this.dgvPhongBanMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhongBanMain.Name = "dgvPhongBanMain";
            this.dgvPhongBanMain.Size = new System.Drawing.Size(1461, 453);
            this.dgvPhongBanMain.TabIndex = 8;
            this.dgvPhongBanMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvPhongBan});
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dgvPhongBan.ColumnPanelRowHeight = 30;
            this.dgvPhongBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TenPB,
            this.CapTren});
            this.dgvPhongBan.FixedLineWidth = 1;
            this.dgvPhongBan.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dgvPhongBan.GridControl = this.dgvPhongBanMain;
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.OptionsBehavior.Editable = false;
            this.dgvPhongBan.OptionsBehavior.ReadOnly = true;
            this.dgvPhongBan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvPhongBan.OptionsFind.AlwaysVisible = true;
            this.dgvPhongBan.OptionsView.ShowGroupPanel = false;
            this.dgvPhongBan.PaintStyleName = "UltraFlat";
            this.dgvPhongBan.RowHeight = 30;
            this.dgvPhongBan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvPhongBan_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 84;
            // 
            // TenPB
            // 
            this.TenPB.Caption = "Tên phòng ban";
            this.TenPB.FieldName = "TenPB";
            this.TenPB.Name = "TenPB";
            this.TenPB.Visible = true;
            this.TenPB.VisibleIndex = 1;
            this.TenPB.Width = 283;
            // 
            // CapTren
            // 
            this.CapTren.Caption = "Phòng ban cấp trên";
            this.CapTren.FieldName = "CapTren";
            this.CapTren.Name = "CapTren";
            this.CapTren.Visible = true;
            this.CapTren.VisibleIndex = 2;
            this.CapTren.Width = 332;
            // 
            // panel
            // 
            this.panel.Appearance.BackColor = System.Drawing.Color.White;
            this.panel.Appearance.Options.UseBackColor = true;
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panel.Controls.Add(this.groupThongTin);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 540);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1469, 138);
            this.panel.TabIndex = 9;
            // 
            // groupThongTin
            // 
            this.groupThongTin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupThongTin.Appearance.Options.UseBackColor = true;
            this.groupThongTin.Controls.Add(this.cbxCapTren);
            this.groupThongTin.Controls.Add(this.label2);
            this.groupThongTin.Controls.Add(this.txtTenPB);
            this.groupThongTin.Controls.Add(this.label1);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupThongTin.Location = new System.Drawing.Point(2, 2);
            this.groupThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(1465, 134);
            this.groupThongTin.TabIndex = 0;
            this.groupThongTin.Text = "Thông tin phòng ban";
            // 
            // cbxCapTren
            // 
            this.cbxCapTren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCapTren.FormattingEnabled = true;
            this.cbxCapTren.Location = new System.Drawing.Point(564, 76);
            this.cbxCapTren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCapTren.Name = "cbxCapTren";
            this.cbxCapTren.Size = new System.Drawing.Size(317, 24);
            this.cbxCapTren.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phòng ban cấp trên : ";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(564, 32);
            this.txtTenPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(500, 23);
            this.txtTenPB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên phòng ban : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 64);
            this.panel1.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(884, 6);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(183, 39);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(503, 6);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(183, 39);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(693, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(183, 39);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1075, 6);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(183, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(1265, 6);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(183, 39);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            this.groupPhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBanMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPhongBan;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraGrid.GridControl dgvPhongBanMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvPhongBan;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private System.Windows.Forms.ComboBox cbxCapTren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TenPB;
        private DevExpress.XtraGrid.Columns.GridColumn CapTren;
        private DevExpress.XtraEditors.SimpleButton btnHuy;


    }
}