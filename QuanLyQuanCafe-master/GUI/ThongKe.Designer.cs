namespace QuanLyQuanCafe.GUI
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.dgrThongKe = new DevExpress.XtraGrid.GridControl();
            this.grvThongKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongGiaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.dtptoday = new System.Windows.Forms.DateTimePicker();
            this.dtpfromday = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtLoiNhuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrThongKe
            // 
            this.dgrThongKe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgrThongKe.Location = new System.Drawing.Point(16, 118);
            this.dgrThongKe.MainView = this.grvThongKe;
            this.dgrThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.dgrThongKe.Name = "dgrThongKe";
            this.dgrThongKe.Size = new System.Drawing.Size(692, 496);
            this.dgrThongKe.TabIndex = 0;
            this.dgrThongKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThongKe});
            // 
            // grvThongKe
            // 
            this.grvThongKe.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.grvThongKe.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvThongKe.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.grvThongKe.Appearance.Row.Options.UseFont = true;
            this.grvThongKe.ColumnPanelRowHeight = 25;
            this.grvThongKe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MatHang,
            this.SoLuong,
            this.TongGiaTri});
            this.grvThongKe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grvThongKe.GridControl = this.dgrThongKe;
            this.grvThongKe.Name = "grvThongKe";
            this.grvThongKe.OptionsBehavior.ReadOnly = true;
            this.grvThongKe.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvThongKe.OptionsView.ShowGroupPanel = false;
            this.grvThongKe.PaintStyleName = "UltraFlat";
            this.grvThongKe.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 96;
            // 
            // MatHang
            // 
            this.MatHang.AppearanceCell.Options.UseTextOptions = true;
            this.MatHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MatHang.Caption = "Tên mặt hàng";
            this.MatHang.FieldName = "MatHang";
            this.MatHang.Name = "MatHang";
            this.MatHang.Visible = true;
            this.MatHang.VisibleIndex = 1;
            this.MatHang.Width = 390;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 271;
            // 
            // TongGiaTri
            // 
            this.TongGiaTri.AppearanceCell.Options.UseTextOptions = true;
            this.TongGiaTri.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TongGiaTri.Caption = "Tổng giá trị";
            this.TongGiaTri.FieldName = "TongTien";
            this.TongGiaTri.Name = "TongGiaTri";
            this.TongGiaTri.Visible = true;
            this.TongGiaTri.VisibleIndex = 3;
            this.TongGiaTri.Width = 276;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.dtptoday);
            this.groupBox1.Controls.Add(this.dtpfromday);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1175, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(309, 27);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(5, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labelControl1.Location = new System.Drawing.Point(29, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Thời gian : ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnThongKe.Location = new System.Drawing.Point(534, 21);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(128, 30);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtptoday
            // 
            this.dtptoday.CustomFormat = "dd/MM/yyyy";
            this.dtptoday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptoday.Location = new System.Drawing.Point(321, 22);
            this.dtptoday.Margin = new System.Windows.Forms.Padding(4);
            this.dtptoday.Name = "dtptoday";
            this.dtptoday.Size = new System.Drawing.Size(173, 29);
            this.dtptoday.TabIndex = 1;
            this.dtptoday.ValueChanged += new System.EventHandler(this.dtptoday_ValueChanged);
            // 
            // dtpfromday
            // 
            this.dtpfromday.CustomFormat = "dd/MM/yyyy";
            this.dtpfromday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromday.Location = new System.Drawing.Point(122, 22);
            this.dtpfromday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfromday.Name = "dtpfromday";
            this.dtpfromday.Size = new System.Drawing.Size(179, 29);
            this.dtpfromday.TabIndex = 0;
            this.dtpfromday.ValueChanged += new System.EventHandler(this.dtpfromday_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartThongKe);
            this.groupBox2.Location = new System.Drawing.Point(716, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(475, 496);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê lượng hàng đã bán";
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(4, 26);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Times New Roman", 9F);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(467, 466);
            this.chartThongKe.TabIndex = 3;
            this.chartThongKe.Text = "chart1";
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.AutoSize = true;
            this.txtLoiNhuan.Location = new System.Drawing.Point(16, 97);
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.Size = new System.Drawing.Size(209, 21);
            this.txtLoiNhuan.TabIndex = 3;
            this.txtLoiNhuan.Text = "Tổng lợi nhuận : 1,300,000";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 627);
            this.Controls.Add(this.txtLoiNhuan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrThongKe);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrThongKe;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.DateTimePicker dtptoday;
        private System.Windows.Forms.DateTimePicker dtpfromday;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Label txtLoiNhuan;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MatHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn TongGiaTri;
    }
}