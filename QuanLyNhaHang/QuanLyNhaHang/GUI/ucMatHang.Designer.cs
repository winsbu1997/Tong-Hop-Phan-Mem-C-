namespace BTL_CNPM.GUI
{
    partial class ucMatHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGiaBan = new System.Windows.Forms.Label();
            this.txtTenMatHang = new System.Windows.Forms.Label();
            this.imgAnh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(this.txtTenMatHang);
            this.panel1.Controls.Add(this.imgAnh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 154);
            this.panel1.TabIndex = 0;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(3, 135);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(119, 17);
            this.txtGiaBan.TabIndex = 2;
            this.txtGiaBan.Text = "25000 vnđ";
            this.txtGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMatHang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(3, 118);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(119, 17);
            this.txtTenMatHang.TabIndex = 1;
            this.txtTenMatHang.Text = "BÁNH TRÁNG TRỘN";
            this.txtTenMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgAnh
            // 
            this.imgAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgAnh.Image = global::BTL_CNPM.Properties.Resources.Nau;
            this.imgAnh.Location = new System.Drawing.Point(0, 0);
            this.imgAnh.Name = "imgAnh";
            this.imgAnh.Size = new System.Drawing.Size(125, 113);
            this.imgAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAnh.TabIndex = 0;
            this.imgAnh.TabStop = false;
            // 
            // ucMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucMatHang";
            this.Size = new System.Drawing.Size(125, 154);
            this.Load += new System.EventHandler(this.ucMatHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgAnh;
        private System.Windows.Forms.Label txtGiaBan;
        private System.Windows.Forms.Label txtTenMatHang;
    }
}
