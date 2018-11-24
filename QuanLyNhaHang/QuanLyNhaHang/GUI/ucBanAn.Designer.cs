namespace BTL_CNPM.GUI
{
    partial class ucBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanAn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBanAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnBanAn
            // 
            this.btnBanAn.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanAn.Appearance.Options.UseFont = true;
            this.btnBanAn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanAn.Image = ((System.Drawing.Image)(resources.GetObject("btnBanAn.Image")));
            this.btnBanAn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBanAn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBanAn.Location = new System.Drawing.Point(0, 0);
            this.btnBanAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Size = new System.Drawing.Size(105, 86);
            this.btnBanAn.TabIndex = 16;
            this.btnBanAn.Text = "Bàn 1";
            // 
            // ucBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucBanAn";
            this.Size = new System.Drawing.Size(105, 86);
            this.Load += new System.EventHandler(this.ucBanAn_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnBanAn;
    }
}
