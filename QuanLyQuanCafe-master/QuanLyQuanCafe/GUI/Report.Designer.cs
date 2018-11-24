namespace QuanLyQuanCafe.GUI
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qUANLYQUANCAFEDataSet1 = new QuanLyQuanCafe.QUANLYQUANCAFEDataSet1();
            this.qUANLYQUANCAFEDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYQUANCAFEDataSet2 = new QuanLyQuanCafe.QUANLYQUANCAFEDataSet2();
            this.qUANLYQUANCAFEDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.qUANLYQUANCAFEDataSet2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.GUI.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(593, 326);
            this.reportViewer1.TabIndex = 0;
            // 
            // qUANLYQUANCAFEDataSet1
            // 
            this.qUANLYQUANCAFEDataSet1.DataSetName = "QUANLYQUANCAFEDataSet1";
            this.qUANLYQUANCAFEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYQUANCAFEDataSet1BindingSource
            // 
            this.qUANLYQUANCAFEDataSet1BindingSource.DataSource = this.qUANLYQUANCAFEDataSet1;
            this.qUANLYQUANCAFEDataSet1BindingSource.Position = 0;
            // 
            // qUANLYQUANCAFEDataSet2
            // 
            this.qUANLYQUANCAFEDataSet2.DataSetName = "QUANLYQUANCAFEDataSet2";
            this.qUANLYQUANCAFEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYQUANCAFEDataSet2BindingSource
            // 
            this.qUANLYQUANCAFEDataSet2BindingSource.DataSource = this.qUANLYQUANCAFEDataSet2;
            this.qUANLYQUANCAFEDataSet2BindingSource.Position = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 350);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYQUANCAFEDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qUANLYQUANCAFEDataSet1BindingSource;
        private QUANLYQUANCAFEDataSet1 qUANLYQUANCAFEDataSet1;
        private System.Windows.Forms.BindingSource qUANLYQUANCAFEDataSet2BindingSource;
        private QUANLYQUANCAFEDataSet2 qUANLYQUANCAFEDataSet2;
    }
}