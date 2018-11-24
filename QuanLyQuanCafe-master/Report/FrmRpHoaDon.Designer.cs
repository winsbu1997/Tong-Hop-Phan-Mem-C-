namespace QuanLyQuanCafe.Report
{
    partial class FrmRpHoaDon
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
            this.components = new System.ComponentModel.Container();
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new QuanLyQuanCafe.Report.ReportDataSet();
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.ReportDataSet;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //reportDataSource2.Name = "HoaDon";
            //reportDataSource2.Value = this.HOADONBindingSource;
            //this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.Report.HoaDon.rdlc";
            //this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.Size = new System.Drawing.Size(748, 500);
            //this.reportViewer1.TabIndex = 0;
            // 
            // FrmRpHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 500);
            //this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRpHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.FrmRpHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private ReportDataSet ReportDataSet;




    }
}