namespace QuanLiNhaHang.GUI
{
    partial class ListThucDon
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
            this.components = new System.ComponentModel.Container();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlNhomMon = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlMonAn = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            // 
            // pnlNhomMon
            // 
            this.pnlNhomMon.AutoScroll = true;
            this.pnlNhomMon.BackColor = System.Drawing.Color.Transparent;
            this.pnlNhomMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNhomMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNhomMon.Location = new System.Drawing.Point(0, 620);
            this.pnlNhomMon.Name = "pnlNhomMon";
            this.pnlNhomMon.Size = new System.Drawing.Size(2050, 129);
            this.pnlNhomMon.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(50, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlMonAn
            // 
            this.pnlMonAn.AutoScroll = true;
            this.pnlMonAn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMonAn.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMonAn.Location = new System.Drawing.Point(0, 0);
            this.pnlMonAn.Name = "pnlMonAn";
            this.pnlMonAn.Size = new System.Drawing.Size(2050, 632);
            this.pnlMonAn.TabIndex = 8;
            // 
            // ListThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMonAn);
            this.Controls.Add(this.pnlNhomMon);
            this.Name = "ListThucDon";
            this.Size = new System.Drawing.Size(2050, 749);
            this.Load += new System.EventHandler(this.ListThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private System.Windows.Forms.FlowLayoutPanel pnlNhomMon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel pnlMonAn;
    }
}
