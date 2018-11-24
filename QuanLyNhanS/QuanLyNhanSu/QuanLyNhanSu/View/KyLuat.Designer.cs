namespace QuanLyNhanSu.View
{
    partial class KyLuat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_kyluat = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quydoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_quydoi = new System.Windows.Forms.TextBox();
            this.txt_nguyennhan = new System.Windows.Forms.TextBox();
            this.txt_hinhthuc = new System.Windows.Forms.TextBox();
            this.txt_tenkl = new System.Windows.Forms.TextBox();
            this.txt_makl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kyluat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_kyluat);
            this.groupBox2.Location = new System.Drawing.Point(1, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Các Loại Khen Thưởng";
            // 
            // dgv_kyluat
            // 
            this.dgv_kyluat.AllowUserToAddRows = false;
            this.dgv_kyluat.AllowUserToDeleteRows = false;
            this.dgv_kyluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kyluat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.makt,
            this.tenkt,
            this.hinhthuc,
            this.noidung,
            this.quydoi});
            this.dgv_kyluat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_kyluat.Location = new System.Drawing.Point(3, 16);
            this.dgv_kyluat.Name = "dgv_kyluat";
            this.dgv_kyluat.ReadOnly = true;
            this.dgv_kyluat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kyluat.Size = new System.Drawing.Size(746, 217);
            this.dgv_kyluat.TabIndex = 0;
            this.dgv_kyluat.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_kyluat_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // makt
            // 
            this.makt.DataPropertyName = "MaKT";
            this.makt.HeaderText = "Mã Khen Thưởng";
            this.makt.Name = "makt";
            this.makt.ReadOnly = true;
            // 
            // tenkt
            // 
            this.tenkt.DataPropertyName = "TenKT";
            this.tenkt.FillWeight = 160F;
            this.tenkt.HeaderText = "Tên Khen Thưởng";
            this.tenkt.Name = "tenkt";
            this.tenkt.ReadOnly = true;
            this.tenkt.Width = 140;
            // 
            // hinhthuc
            // 
            this.hinhthuc.DataPropertyName = "HinhThuc";
            this.hinhthuc.HeaderText = "Hình Thức";
            this.hinhthuc.Name = "hinhthuc";
            this.hinhthuc.ReadOnly = true;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "NoiDung";
            this.noidung.FillWeight = 160F;
            this.noidung.HeaderText = "Nội Dung";
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            this.noidung.Width = 160;
            // 
            // quydoi
            // 
            this.quydoi.DataPropertyName = "QuyDoiRaTienMat";
            this.quydoi.HeaderText = "Quy Đổi Ra Tiền Mặt";
            this.quydoi.Name = "quydoi";
            this.quydoi.ReadOnly = true;
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(657, 124);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(83, 59);
            this.btn_TroVe.TabIndex = 17;
            this.btn_TroVe.Text = "Trở Về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(657, 55);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(83, 59);
            this.btn_Luu.TabIndex = 16;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(533, 124);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(83, 59);
            this.btn_Huy.TabIndex = 15;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(405, 124);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 59);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(533, 55);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(83, 59);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(405, 55);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 59);
            this.btn_Them.TabIndex = 12;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(664, 21);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(404, 23);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(238, 20);
            this.txt_TimKiem.TabIndex = 10;
            this.txt_TimKiem.Text = "Nhập Tên Khen Thưởng Cần Tìm Kiếm ...";
            this.txt_TimKiem.Click += new System.EventHandler(this.txt_TimKiem_Click);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // txt_quydoi
            // 
            this.txt_quydoi.Location = new System.Drawing.Point(139, 144);
            this.txt_quydoi.Name = "txt_quydoi";
            this.txt_quydoi.Size = new System.Drawing.Size(238, 20);
            this.txt_quydoi.TabIndex = 9;
            this.txt_quydoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quydoi_KeyPress);
            // 
            // txt_nguyennhan
            // 
            this.txt_nguyennhan.Location = new System.Drawing.Point(139, 114);
            this.txt_nguyennhan.Name = "txt_nguyennhan";
            this.txt_nguyennhan.Size = new System.Drawing.Size(238, 20);
            this.txt_nguyennhan.TabIndex = 8;
            // 
            // txt_hinhthuc
            // 
            this.txt_hinhthuc.Location = new System.Drawing.Point(139, 83);
            this.txt_hinhthuc.Name = "txt_hinhthuc";
            this.txt_hinhthuc.Size = new System.Drawing.Size(238, 20);
            this.txt_hinhthuc.TabIndex = 7;
            // 
            // txt_tenkl
            // 
            this.txt_tenkl.Location = new System.Drawing.Point(139, 53);
            this.txt_tenkl.Name = "txt_tenkl";
            this.txt_tenkl.Size = new System.Drawing.Size(238, 20);
            this.txt_tenkl.TabIndex = 6;
            // 
            // txt_makl
            // 
            this.txt_makl.Location = new System.Drawing.Point(139, 23);
            this.txt_makl.Name = "txt_makl";
            this.txt_makl.Size = new System.Drawing.Size(238, 20);
            this.txt_makl.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quy Đổi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nguyên Nhân :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình Thức :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Ky Luật :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Kỷ Luật :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TroVe);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.txt_quydoi);
            this.groupBox1.Controls.Add(this.txt_nguyennhan);
            this.groupBox1.Controls.Add(this.txt_hinhthuc);
            this.groupBox1.Controls.Add(this.txt_tenkl);
            this.groupBox1.Controls.Add(this.txt_makl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Khen Thưởng";
            // 
            // KyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KyLuat";
            this.Size = new System.Drawing.Size(755, 464);
            this.Load += new System.EventHandler(this.KyLuat_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kyluat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_kyluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn quydoi;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.TextBox txt_quydoi;
        private System.Windows.Forms.TextBox txt_nguyennhan;
        private System.Windows.Forms.TextBox txt_hinhthuc;
        private System.Windows.Forms.TextBox txt_tenkl;
        private System.Windows.Forms.TextBox txt_makl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
