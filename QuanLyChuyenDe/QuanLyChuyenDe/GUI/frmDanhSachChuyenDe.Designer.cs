namespace QuanLyChuyenDe.GUI
{
    partial class frmDanhSachChuyenDe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachCD = new System.Windows.Forms.DataGridView();
            this.MaCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLSVToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhomToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachCD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chuyên đề";
            // 
            // dgvDanhSachCD
            // 
            this.dgvDanhSachCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCD,
            this.TenNganh,
            this.TenCD,
            this.NgayBD,
            this.NgayKT,
            this.SLSVToiDa,
            this.SLNhomToiDa,
            this.TrangThai});
            this.dgvDanhSachCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachCD.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachCD.Name = "dgvDanhSachCD";
            this.dgvDanhSachCD.ReadOnly = true;
            this.dgvDanhSachCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachCD.Size = new System.Drawing.Size(809, 256);
            this.dgvDanhSachCD.TabIndex = 0;
            // 
            // MaCD
            // 
            this.MaCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCD.DataPropertyName = "MaCD";
            this.MaCD.HeaderText = "Mã Chuyên Đề";
            this.MaCD.Name = "MaCD";
            this.MaCD.ReadOnly = true;
            // 
            // TenNganh
            // 
            this.TenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNganh.DataPropertyName = "TenNganh";
            this.TenNganh.HeaderText = "Ngành";
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.ReadOnly = true;
            // 
            // TenCD
            // 
            this.TenCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCD.DataPropertyName = "TenCD";
            this.TenCD.HeaderText = "Tên Chuyên Đề";
            this.TenCD.Name = "TenCD";
            this.TenCD.ReadOnly = true;
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày Bắt Đầu";
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.ReadOnly = true;
            // 
            // NgayKT
            // 
            this.NgayKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKT.DataPropertyName = "NgayKT";
            this.NgayKT.HeaderText = "Ngày Kết Thúc";
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.ReadOnly = true;
            // 
            // SLSVToiDa
            // 
            this.SLSVToiDa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SLSVToiDa.DataPropertyName = "SLSVToiDa";
            this.SLSVToiDa.HeaderText = "Số Lượng SV Tối Đa";
            this.SLSVToiDa.Name = "SLSVToiDa";
            this.SLSVToiDa.ReadOnly = true;
            // 
            // SLNhomToiDa
            // 
            this.SLNhomToiDa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SLNhomToiDa.DataPropertyName = "SLNhomToiDa";
            this.SLNhomToiDa.HeaderText = "Số Lượng Nhóm Tối Đa";
            this.SLNhomToiDa.Name = "SLNhomToiDa";
            this.SLNhomToiDa.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 302);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 42);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm chuyên đề";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(141, 302);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Cập nhật chuyên đề";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(267, 302);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa chuyên đề";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(740, 302);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 42);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDanhSachChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 362);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDanhSachChuyenDe";
            this.Text = "frmDanhSachChuyenDe";
            this.Load += new System.EventHandler(this.frmDanhSachChuyenDe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachCD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLSVToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhomToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}