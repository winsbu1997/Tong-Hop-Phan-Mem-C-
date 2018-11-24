namespace QuanLyNhanSu.View
{
    partial class UCHeSoLuong
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
            this.lblBacLuong = new System.Windows.Forms.Label();
            this.dgvHeSoLuong = new System.Windows.Forms.DataGridView();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.lblLuongCB = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBacLuong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLuongtangca = new System.Windows.Forms.TextBox();
            this.lblLuongTangCa = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BacLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongTangCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBacLuong
            // 
            this.lblBacLuong.AutoSize = true;
            this.lblBacLuong.Location = new System.Drawing.Point(6, 45);
            this.lblBacLuong.Name = "lblBacLuong";
            this.lblBacLuong.Size = new System.Drawing.Size(115, 25);
            this.lblBacLuong.TabIndex = 0;
            this.lblBacLuong.Text = "Bậc Lương";
            // 
            // dgvHeSoLuong
            // 
            this.dgvHeSoLuong.AllowUserToAddRows = false;
            this.dgvHeSoLuong.AllowUserToDeleteRows = false;
            this.dgvHeSoLuong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHeSoLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeSoLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.BacLuong,
            this.LuongCB,
            this.LuongTangCa});
            this.dgvHeSoLuong.Location = new System.Drawing.Point(675, 30);
            this.dgvHeSoLuong.Name = "dgvHeSoLuong";
            this.dgvHeSoLuong.ReadOnly = true;
            this.dgvHeSoLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeSoLuong.Size = new System.Drawing.Size(506, 361);
            this.dgvHeSoLuong.TabIndex = 34;
            this.dgvHeSoLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeSoLuong_CellClick);
            this.dgvHeSoLuong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvHeSoLuong_RowPrePaint);
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(188, 141);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(165, 31);
            this.txtLuongCB.TabIndex = 3;
            // 
            // lblLuongCB
            // 
            this.lblLuongCB.AutoSize = true;
            this.lblLuongCB.Location = new System.Drawing.Point(6, 147);
            this.lblLuongCB.Name = "lblLuongCB";
            this.lblLuongCB.Size = new System.Drawing.Size(149, 25);
            this.lblLuongCB.TabIndex = 2;
            this.lblLuongCB.Text = "Lương Cơ Bản";
            // 
            // txtBacLuong
            // 
            this.txtBacLuong.Location = new System.Drawing.Point(188, 41);
            this.txtBacLuong.Name = "txtBacLuong";
            this.txtBacLuong.Size = new System.Drawing.Size(99, 31);
            this.txtBacLuong.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(458, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 111);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(158, 31);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThoat.Location = new System.Drawing.Point(566, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 43);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnHuy.Location = new System.Drawing.Point(566, 249);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(70, 43);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLuu.Location = new System.Drawing.Point(566, 171);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 43);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(464, 348);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 43);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSua.Location = new System.Drawing.Point(464, 249);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 43);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThem.Location = new System.Drawing.Point(464, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 43);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.txtLuongtangca);
            this.groupBox1.Controls.Add(this.lblLuongTangCa);
            this.groupBox1.Controls.Add(this.txtLuongCB);
            this.groupBox1.Controls.Add(this.lblLuongCB);
            this.groupBox1.Controls.Add(this.txtBacLuong);
            this.groupBox1.Controls.Add(this.lblBacLuong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 361);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hệ Số Lương";
            // 
            // txtLuongtangca
            // 
            this.txtLuongtangca.Location = new System.Drawing.Point(188, 269);
            this.txtLuongtangca.Name = "txtLuongtangca";
            this.txtLuongtangca.Size = new System.Drawing.Size(165, 31);
            this.txtLuongtangca.TabIndex = 5;
            // 
            // lblLuongTangCa
            // 
            this.lblLuongTangCa.AutoSize = true;
            this.lblLuongTangCa.Location = new System.Drawing.Point(6, 275);
            this.lblLuongTangCa.Name = "lblLuongTangCa";
            this.lblLuongTangCa.Size = new System.Drawing.Size(160, 25);
            this.lblLuongTangCa.TabIndex = 4;
            this.lblLuongTangCa.Text = "Lương Tăng Ca";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // BacLuong
            // 
            this.BacLuong.DataPropertyName = "BacLuong";
            this.BacLuong.HeaderText = "Bậc Lương";
            this.BacLuong.Name = "BacLuong";
            this.BacLuong.ReadOnly = true;
            // 
            // LuongCB
            // 
            this.LuongCB.DataPropertyName = "LuongCB";
            this.LuongCB.HeaderText = "Lương Cơ bản";
            this.LuongCB.Name = "LuongCB";
            this.LuongCB.ReadOnly = true;
            this.LuongCB.Width = 160;
            // 
            // LuongTangCa
            // 
            this.LuongTangCa.DataPropertyName = "LuongTangCa";
            this.LuongTangCa.HeaderText = "Lương Tăng Ca";
            this.LuongTangCa.Name = "LuongTangCa";
            this.LuongTangCa.ReadOnly = true;
            this.LuongTangCa.Width = 160;
            // 
            // UCHeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHeSoLuong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCHeSoLuong";
            this.Size = new System.Drawing.Size(1300, 620);
            this.Load += new System.EventHandler(this.UCHeSoLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBacLuong;
        private System.Windows.Forms.DataGridView dgvHeSoLuong;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label lblLuongCB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBacLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLuongtangca;
        private System.Windows.Forms.Label lblLuongTangCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongTangCa;
    }
}
