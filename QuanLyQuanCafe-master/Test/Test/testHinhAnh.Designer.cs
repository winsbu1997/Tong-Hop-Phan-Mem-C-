namespace Test
{
    partial class testHinhAnh
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
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnLoadAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.BackColor = System.Drawing.Color.White;
            this.imgMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgMain.Location = new System.Drawing.Point(23, 12);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(650, 365);
            this.imgMain.TabIndex = 0;
            this.imgMain.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(558, 397);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(437, 397);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(115, 35);
            this.btnChonAnh.TabIndex = 3;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnLoadAnh
            // 
            this.btnLoadAnh.Location = new System.Drawing.Point(316, 397);
            this.btnLoadAnh.Name = "btnLoadAnh";
            this.btnLoadAnh.Size = new System.Drawing.Size(115, 35);
            this.btnLoadAnh.TabIndex = 5;
            this.btnLoadAnh.Text = "Load ảnh";
            this.btnLoadAnh.UseVisualStyleBackColor = true;
            this.btnLoadAnh.Click += new System.EventHandler(this.btnLoadAnh_Click);
            // 
            // testHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 444);
            this.Controls.Add(this.btnLoadAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.imgMain);
            this.Name = "testHinhAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hình ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnLoadAnh;
    }
}