namespace QuanLiNhaHang.GUI
{
    partial class frmCTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTB));
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenMA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnSUB = new DevExpress.XtraEditors.SimpleButton();
            this.btnADD = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "VND";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(307, 142);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(107, 23);
            this.txtDonGia.TabIndex = 18;
            // 
            // txtTenMA
            // 
            this.txtTenMA.Enabled = false;
            this.txtTenMA.Location = new System.Drawing.Point(307, 76);
            this.txtTenMA.Name = "txtTenMA";
            this.txtTenMA.Size = new System.Drawing.Size(107, 23);
            this.txtTenMA.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Món Ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // txtDVT
            // 
            this.txtDVT.Enabled = false;
            this.txtDVT.Location = new System.Drawing.Point(307, 108);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(107, 23);
            this.txtDVT.TabIndex = 24;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(290, 30);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(50, 23);
            this.txtSL.TabIndex = 25;
            // 
            // Cancel
            // 
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.Cancel.Location = new System.Drawing.Point(356, 189);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(99, 37);
            this.Cancel.TabIndex = 27;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOK.Location = new System.Drawing.Point(199, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 37);
            this.btnOK.TabIndex = 26;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSUB
            // 
            this.btnSUB.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSUB.Image = ((System.Drawing.Image)(resources.GetObject("btnSUB.Image")));
            this.btnSUB.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSUB.Location = new System.Drawing.Point(401, 25);
            this.btnSUB.Name = "btnSUB";
            this.btnSUB.Size = new System.Drawing.Size(49, 37);
            this.btnSUB.TabIndex = 22;
            this.btnSUB.Click += new System.EventHandler(this.btnSUB_Click);
            // 
            // btnADD
            // 
            this.btnADD.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnADD.Location = new System.Drawing.Point(346, 25);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(49, 37);
            this.btnADD.TabIndex = 21;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLiNhaHang.Properties.Resources.sting;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 239);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmCTB
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lime;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 248);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSUB);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCTB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenMA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnADD;
        private DevExpress.XtraEditors.SimpleButton btnSUB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtSL;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton Cancel;
    }
}