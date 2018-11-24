namespace QuanLyKhachSan
{
    partial class frmTraPhong
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
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtTienBoiThuong = new System.Windows.Forms.TextBox();
            this.txtTienThuePhong = new System.Windows.Forms.TextBox();
            this.txtTienDichVu = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayThuePhong = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThongtin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuyBo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(488, 349);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(118, 45);
            this.btnHuyBo.TabIndex = 26;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDongY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(310, 349);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(107, 45);
            this.btnDongY.TabIndex = 25;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(206, 275);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(211, 27);
            this.txtTongTien.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tổng Tiền";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(630, 20);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(181, 27);
            this.txtTenPhong.TabIndex = 21;
            // 
            // txtTienBoiThuong
            // 
            this.txtTienBoiThuong.Location = new System.Drawing.Point(630, 219);
            this.txtTienBoiThuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienBoiThuong.Name = "txtTienBoiThuong";
            this.txtTienBoiThuong.Size = new System.Drawing.Size(181, 27);
            this.txtTienBoiThuong.TabIndex = 20;
            this.txtTienBoiThuong.Text = "0";
            this.txtTienBoiThuong.TextChanged += new System.EventHandler(this.txtTienBoiThuong_TextChanged);
            // 
            // txtTienThuePhong
            // 
            this.txtTienThuePhong.Location = new System.Drawing.Point(630, 147);
            this.txtTienThuePhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThuePhong.Name = "txtTienThuePhong";
            this.txtTienThuePhong.ReadOnly = true;
            this.txtTienThuePhong.Size = new System.Drawing.Size(181, 27);
            this.txtTienThuePhong.TabIndex = 19;
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.Location = new System.Drawing.Point(206, 216);
            this.txtTienDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.ReadOnly = true;
            this.txtTienDichVu.Size = new System.Drawing.Size(211, 27);
            this.txtTienDichVu.TabIndex = 18;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(206, 150);
            this.txtSoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.ReadOnly = true;
            this.txtSoNgay.Size = new System.Drawing.Size(211, 27);
            this.txtSoNgay.TabIndex = 22;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(206, 19);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(211, 27);
            this.txtTenKH.TabIndex = 17;
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Enabled = false;
            this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(630, 84);
            this.dtpNgayTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(181, 27);
            this.dtpNgayTraPhong.TabIndex = 16;
            // 
            // dtpNgayThuePhong
            // 
            this.dtpNgayThuePhong.Enabled = false;
            this.dtpNgayThuePhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThuePhong.Location = new System.Drawing.Point(206, 84);
            this.dtpNgayThuePhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayThuePhong.Name = "dtpNgayThuePhong";
            this.dtpNgayThuePhong.Size = new System.Drawing.Size(211, 27);
            this.dtpNgayThuePhong.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(484, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tiền Bồi Thường \r\n (Nếu Có)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiền Thuê Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tiền Dịch Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Ngày Thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khách Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 282);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Thông tin";
            // 
            // txtThongtin
            // 
            this.txtThongtin.Location = new System.Drawing.Point(630, 275);
            this.txtThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongtin.Name = "txtThongtin";
            this.txtThongtin.Size = new System.Drawing.Size(181, 27);
            this.txtThongtin.TabIndex = 28;
            // 
            // frmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 422);
            this.Controls.Add(this.txtThongtin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtTienBoiThuong);
            this.Controls.Add(this.txtTienThuePhong);
            this.Controls.Add(this.txtTienDichVu);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.dtpNgayTraPhong);
            this.Controls.Add(this.dtpNgayThuePhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraPhong";
            this.Text = "frmTraPhong";
            this.Load += new System.EventHandler(this.frmTraPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtTienBoiThuong;
        private System.Windows.Forms.TextBox txtTienThuePhong;
        private System.Windows.Forms.TextBox txtTienDichVu;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayThuePhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThongtin;
    }
}