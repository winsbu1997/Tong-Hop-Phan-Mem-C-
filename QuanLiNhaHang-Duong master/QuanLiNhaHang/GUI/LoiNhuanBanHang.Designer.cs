namespace QuanLiNhaHang.GUI
{
    partial class LoiNhuanBanHang
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoiNhuanBanHang));
            this.chartThuNhap = new DevExpress.XtraCharts.ChartControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtLaiSuat = new DevExpress.XtraEditors.LabelControl();
            this.TxtTienLai = new DevExpress.XtraEditors.LabelControl();
            this.txtTienLuongTra = new DevExpress.XtraEditors.LabelControl();
            this.txtTienMuaNL = new DevExpress.XtraEditors.LabelControl();
            this.txtTienThuVe = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInThongKe = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartThuNhap
            // 
            this.chartThuNhap.AppearanceNameSerializable = "Northern Lights";
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "12";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "1";
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "12";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "1";
            xyDiagram1.AxisY.Logarithmic = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "100000000";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "1000000";
            this.chartThuNhap.Diagram = xyDiagram1;
            this.chartThuNhap.Legend.Name = "ListData";
            this.chartThuNhap.Location = new System.Drawing.Point(427, 89);
            this.chartThuNhap.Name = "chartThuNhap";
            this.chartThuNhap.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch;
            series1.Name = "Nhập Vào";
            sideBySideBarSeriesView1.BarWidth = 0.8D;
            series1.View = sideBySideBarSeriesView1;
            series2.Name = "Bán Ra";
            sideBySideBarSeriesView2.BarWidth = 0.8D;
            series2.View = sideBySideBarSeriesView2;
            this.chartThuNhap.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartThuNhap.Size = new System.Drawing.Size(1104, 582);
            this.chartThuNhap.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.txtLaiSuat);
            this.groupBox1.Controls.Add(this.TxtTienLai);
            this.groupBox1.Controls.Add(this.txtTienLuongTra);
            this.groupBox1.Controls.Add(this.txtTienMuaNL);
            this.groupBox1.Controls.Add(this.txtTienThuVe);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 346);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Nhà Hàng";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(319, 256);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(39, 24);
            this.labelControl11.TabIndex = 43;
            this.labelControl11.Text = "VND";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(319, 158);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 24);
            this.labelControl10.TabIndex = 42;
            this.labelControl10.Text = "VND";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(319, 106);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 24);
            this.labelControl9.TabIndex = 41;
            this.labelControl9.Text = "VND";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(319, 56);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 24);
            this.labelControl8.TabIndex = 40;
            this.labelControl8.Text = "VND";
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaiSuat.Location = new System.Drawing.Point(218, 303);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.Size = new System.Drawing.Size(80, 24);
            this.txtLaiSuat.TabIndex = 38;
            this.txtLaiSuat.Text = "_ _ _ _ _";
            // 
            // TxtTienLai
            // 
            this.TxtTienLai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTienLai.Location = new System.Drawing.Point(218, 256);
            this.TxtTienLai.Name = "TxtTienLai";
            this.TxtTienLai.Size = new System.Drawing.Size(80, 24);
            this.TxtTienLai.TabIndex = 37;
            this.TxtTienLai.Text = "_ _ _ _ _";
            // 
            // txtTienLuongTra
            // 
            this.txtTienLuongTra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienLuongTra.Location = new System.Drawing.Point(218, 158);
            this.txtTienLuongTra.Name = "txtTienLuongTra";
            this.txtTienLuongTra.Size = new System.Drawing.Size(80, 24);
            this.txtTienLuongTra.TabIndex = 36;
            this.txtTienLuongTra.Text = "_ _ _ _ _";
            // 
            // txtTienMuaNL
            // 
            this.txtTienMuaNL.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienMuaNL.Location = new System.Drawing.Point(218, 106);
            this.txtTienMuaNL.Name = "txtTienMuaNL";
            this.txtTienMuaNL.Size = new System.Drawing.Size(80, 24);
            this.txtTienMuaNL.TabIndex = 35;
            this.txtTienMuaNL.Text = "_ _ _ _ _";
            // 
            // txtTienThuVe
            // 
            this.txtTienThuVe.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThuVe.Location = new System.Drawing.Point(177, 56);
            this.txtTienThuVe.Name = "txtTienThuVe";
            this.txtTienThuVe.Size = new System.Drawing.Size(80, 24);
            this.txtTienThuVe.TabIndex = 34;
            this.txtTienThuVe.Text = "_ _ _ _ _";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(113, 208);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(245, 24);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "-----------------------------------";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(6, 51);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(119, 29);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Tiền Thu Về :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(8, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(193, 29);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Tiền Lương Phải Trả:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(122, 251);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 29);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Tiền Lãi:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(6, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(206, 29);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Tiền Mua Nguyên Liệu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(122, 303);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 29);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Lãi Suất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(775, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thống Kê Nhà Hàng Trong Năm";
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnInThongKe.Image")));
            this.btnInThongKe.Location = new System.Drawing.Point(42, 116);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.Size = new System.Drawing.Size(156, 42);
            this.btnInThongKe.TabIndex = 14;
            this.btnInThongKe.Text = "In Thống Kê";
            this.btnInThongKe.Click += new System.EventHandler(this.btnInThongKe_Click);
            // 
            // LoiNhuanBanHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnInThongKe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartThuNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoiNhuanBanHang";
            this.Size = new System.Drawing.Size(1592, 733);
            this.Load += new System.EventHandler(this.LoiNhuanBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartThuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl txtLaiSuat;
        private DevExpress.XtraEditors.LabelControl TxtTienLai;
        private DevExpress.XtraEditors.LabelControl txtTienLuongTra;
        private DevExpress.XtraEditors.LabelControl txtTienMuaNL;
        private DevExpress.XtraEditors.LabelControl txtTienThuVe;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnInThongKe;
    }
}
