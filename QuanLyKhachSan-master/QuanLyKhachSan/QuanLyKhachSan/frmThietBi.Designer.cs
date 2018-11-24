namespace QuanLyKhachSan
{
    partial class frmThietBi
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
            this.btnThemTB = new System.Windows.Forms.Button();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.Mathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.txtMaTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiemTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemTB
            // 
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTB.Location = new System.Drawing.Point(63, 163);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(85, 40);
            this.btnThemTB.TabIndex = 20;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTB.UseVisualStyleBackColor = true;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathietbi,
            this.Tenthietbi,
            this.Giathietbi,
            this.Soluong});
            this.dgvThietBi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThietBi.Location = new System.Drawing.Point(0, 232);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.ReadOnly = true;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(771, 142);
            this.dgvThietBi.TabIndex = 22;
            // 
            // Mathietbi
            // 
            this.Mathietbi.DataPropertyName = "Mathietbi";
            this.Mathietbi.HeaderText = "Mã Thiết Bị";
            this.Mathietbi.Name = "Mathietbi";
            this.Mathietbi.ReadOnly = true;
            // 
            // Tenthietbi
            // 
            this.Tenthietbi.DataPropertyName = "Tenthietbi";
            this.Tenthietbi.HeaderText = "Tên Thiết Bị";
            this.Tenthietbi.Name = "Tenthietbi";
            this.Tenthietbi.ReadOnly = true;
            // 
            // Giathietbi
            // 
            this.Giathietbi.DataPropertyName = "Giathietbi";
            this.Giathietbi.HeaderText = "Giá";
            this.Giathietbi.Name = "Giathietbi";
            this.Giathietbi.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTB.Location = new System.Drawing.Point(180, 163);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(75, 40);
            this.btnSuaTB.TabIndex = 23;
            this.btnSuaTB.Text = "Sửa";
            this.btnSuaTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTB.UseVisualStyleBackColor = true;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // txtMaTb
            // 
            this.txtMaTb.Location = new System.Drawing.Point(180, 25);
            this.txtMaTb.Name = "txtMaTb";
            this.txtMaTb.ReadOnly = true;
            this.txtMaTb.Size = new System.Drawing.Size(193, 27);
            this.txtMaTb.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Mã Thiết Bị";
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(180, 82);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(193, 27);
            this.txtTenTB.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên Thiết Bị";
            // 
            // txtSoLuongTb
            // 
            this.txtSoLuongTb.Location = new System.Drawing.Point(531, 24);
            this.txtSoLuongTb.Name = "txtSoLuongTb";
            this.txtSoLuongTb.Size = new System.Drawing.Size(179, 27);
            this.txtSoLuongTb.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số lượng";
            // 
            // txtGiaTB
            // 
            this.txtGiaTB.Location = new System.Drawing.Point(531, 78);
            this.txtGiaTB.Name = "txtGiaTB";
            this.txtGiaTB.Size = new System.Drawing.Size(179, 27);
            this.txtGiaTB.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Giá";
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTB.Location = new System.Drawing.Point(298, 163);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(75, 40);
            this.btnXoaTB.TabIndex = 32;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTB.UseVisualStyleBackColor = true;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tìm kiếm";
            // 
            // txtTimKiemTB
            // 
            this.txtTimKiemTB.Location = new System.Drawing.Point(531, 167);
            this.txtTimKiemTB.Name = "txtTimKiemTB";
            this.txtTimKiemTB.Size = new System.Drawing.Size(179, 27);
            this.txtTimKiemTB.TabIndex = 34;
            this.txtTimKiemTB.TextChanged += new System.EventHandler(this.txtTimKiemTB_TextChanged);
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 374);
            this.Controls.Add(this.txtTimKiemTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaTB);
            this.Controls.Add(this.txtGiaTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuongTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSuaTB);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.btnThemTB);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThietBi";
            this.Text = "frmThietBi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.TextBox txtMaTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}