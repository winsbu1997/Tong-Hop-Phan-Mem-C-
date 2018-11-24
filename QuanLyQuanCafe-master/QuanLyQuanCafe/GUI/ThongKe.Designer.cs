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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.dgrThongKe = new DevExpress.XtraGrid.GridControl();
            this.grvThongKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.dtptoday = new System.Windows.Forms.DateTimePicker();
            this.dtpfromday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrThongKe
            // 
            this.dgrThongKe.Location = new System.Drawing.Point(12, 74);
            this.dgrThongKe.MainView = this.grvThongKe;
            this.dgrThongKe.Name = "dgrThongKe";
            this.dgrThongKe.Size = new System.Drawing.Size(656, 285);
            this.dgrThongKe.TabIndex = 0;
            this.dgrThongKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvThongKe});
            // 
            // grvThongKe
            // 
            this.grvThongKe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grvThongKe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grvThongKe.GridControl = this.dgrThongKe;
            this.grvThongKe.Name = "grvThongKe";
            this.grvThongKe.OptionsBehavior.ReadOnly = true;
            this.grvThongKe.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvThongKe.PaintStyleName = "UltraFlat";
            this.grvThongKe.RowHeight = 30;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mặt hàng";
            this.gridColumn1.FieldName = "TENMH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng bán";
            this.gridColumn2.FieldName = "SOLUONGBAN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sớ lượng còn";
            this.gridColumn3.FieldName = "SOLUONGTONKHO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.dtptoday);
            this.groupBox1.Controls.Add(this.dtpfromday);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(309, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Thời gian";
            // 
            // btnThongKe
            // 
            this.btnThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnThongKe.Location = new System.Drawing.Point(536, 16);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtptoday
            // 
            this.dtptoday.CustomFormat = "dd/MM/yyyy";
            this.dtptoday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptoday.Location = new System.Drawing.Point(337, 19);
            this.dtptoday.Name = "dtptoday";
            this.dtptoday.Size = new System.Drawing.Size(131, 20);
            this.dtptoday.TabIndex = 1;
            this.dtptoday.ValueChanged += new System.EventHandler(this.dtptoday_ValueChanged);
            // 
            // dtpfromday
            // 
            this.dtpfromday.CustomFormat = "dd/MM/yyyy";
            this.dtpfromday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromday.Location = new System.Drawing.Point(148, 19);
            this.dtpfromday.Name = "dtpfromday";
            this.dtpfromday.Size = new System.Drawing.Size(135, 20);
            this.dtpfromday.TabIndex = 0;
            this.dtpfromday.ValueChanged += new System.EventHandler(this.dtpfromday_ValueChanged);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrThongKe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgrThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrThongKe;
        private DevExpress.XtraGrid.Views.Grid.GridView grvThongKe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.DateTimePicker dtptoday;
        private System.Windows.Forms.DateTimePicker dtpfromday;
    }
}