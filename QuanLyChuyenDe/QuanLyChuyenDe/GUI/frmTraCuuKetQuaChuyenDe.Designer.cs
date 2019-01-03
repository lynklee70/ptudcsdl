namespace QuanLyChuyenDe.GUI
{
    partial class frmTraCuuKetQuaChuyenDe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXem = new System.Windows.Forms.Button();
            this.dgvChuyenDe = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbtimkiem = new System.Windows.Forms.ComboBox();
            this.dgvTraCuu = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANHOM11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMHOC11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTim_Kiem = new System.Windows.Forms.ComboBox();
            this.txtTim_Kiem = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTim_Kiem);
            this.tabPage1.Controls.Add(this.cbbTim_Kiem);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnXem);
            this.tabPage1.Controls.Add(this.dgvChuyenDe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tra Cứu Kết Quả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(168, 323);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dgvChuyenDe
            // 
            this.dgvChuyenDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.MACD,
            this.MALOP,
            this.DIEM});
            this.dgvChuyenDe.Location = new System.Drawing.Point(12, 10);
            this.dgvChuyenDe.Name = "dgvChuyenDe";
            this.dgvChuyenDe.Size = new System.Drawing.Size(516, 255);
            this.dgvChuyenDe.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTraCuu);
            this.tabPage2.Controls.Add(this.txtMssv);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbbtimkiem);
            this.tabPage2.Controls.Add(this.dgvTraCuu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tra Cứu Chuyên Đề";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(147, 331);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 4;
            this.btnTraCuu.Text = "Tìm";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(122, 294);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(100, 20);
            this.txtMssv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // cbbtimkiem
            // 
            this.cbbtimkiem.AutoCompleteCustomSource.AddRange(new string[] {
            "MSSV",
            "Mã Chuyên Đề",
            "Mã Nhóm",
            "Mã Lớp",
            "Học Kỳ ",
            "Năm Học",
            "Tất Cả"});
            this.cbbtimkiem.FormattingEnabled = true;
            this.cbbtimkiem.Items.AddRange(new object[] {
            "MSSV",
            "Mã Chuyên Đề",
            "Mã Nhóm",
            "Học Kỳ",
            "Năm Học",
            "Tất Cả"});
            this.cbbtimkiem.Location = new System.Drawing.Point(16, 294);
            this.cbbtimkiem.Name = "cbbtimkiem";
            this.cbbtimkiem.Size = new System.Drawing.Size(100, 21);
            this.cbbtimkiem.TabIndex = 1;
            this.cbbtimkiem.SelectedIndexChanged += new System.EventHandler(this.cbbtimkiem_SelectedIndexChanged);
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV1,
            this.MaCD1,
            this.MANHOM11,
            this.HOCKY11,
            this.NAMHOC11});
            this.dgvTraCuu.Location = new System.Drawing.Point(12, 10);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.Size = new System.Drawing.Size(516, 255);
            this.dgvTraCuu.TabIndex = 0;
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MaSV";
            this.MASV.HeaderText = "Mã Sinh Viên";
            this.MASV.Name = "MASV";
            // 
            // MACD
            // 
            this.MACD.DataPropertyName = "MaCD";
            this.MACD.HeaderText = "Mã Chuyên Đề";
            this.MACD.Name = "MACD";
            // 
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MaLop";
            this.MALOP.HeaderText = "Mã Lớp";
            this.MALOP.Name = "MALOP";
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "Diem";
            this.DIEM.HeaderText = "Điểm";
            this.DIEM.Name = "DIEM";
            // 
            // MASV1
            // 
            this.MASV1.DataPropertyName = "MaSV";
            this.MASV1.HeaderText = "Mã Sinh Viên";
            this.MASV1.Name = "MASV1";
            // 
            // MaCD1
            // 
            this.MaCD1.DataPropertyName = "MaCD";
            this.MaCD1.HeaderText = "Mã Chuyên Đề";
            this.MaCD1.Name = "MaCD1";
            // 
            // MANHOM11
            // 
            this.MANHOM11.DataPropertyName = "MaNhom";
            this.MANHOM11.HeaderText = "Mã Nhóm";
            this.MANHOM11.Name = "MANHOM11";
            // 
            // HOCKY11
            // 
            this.HOCKY11.DataPropertyName = "HocKy";
            this.HOCKY11.HeaderText = "Học Kỳ";
            this.HOCKY11.Name = "HOCKY11";
            // 
            // NAMHOC11
            // 
            this.NAMHOC11.DataPropertyName = "NamHoc";
            this.NAMHOC11.HeaderText = "Năm Học";
            this.NAMHOC11.Name = "NAMHOC11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Kiếm Theo";
            // 
            // cbbTim_Kiem
            // 
            this.cbbTim_Kiem.FormattingEnabled = true;
            this.cbbTim_Kiem.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Mã Chuyên Đề",
            "Mã Lớp",
            "Tất Cả"});
            this.cbbTim_Kiem.Location = new System.Drawing.Point(16, 296);
            this.cbbTim_Kiem.Name = "cbbTim_Kiem";
            this.cbbTim_Kiem.Size = new System.Drawing.Size(108, 21);
            this.cbbTim_Kiem.TabIndex = 3;
            this.cbbTim_Kiem.SelectedIndexChanged += new System.EventHandler(this.cbbTim_Kiem_SelectedIndexChanged);
            // 
            // txtTim_Kiem
            // 
            this.txtTim_Kiem.Location = new System.Drawing.Point(143, 297);
            this.txtTim_Kiem.Name = "txtTim_Kiem";
            this.txtTim_Kiem.Size = new System.Drawing.Size(100, 20);
            this.txtTim_Kiem.TabIndex = 4;
            // 
            // frmTraCuuKetQuaChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 394);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTraCuuKetQuaChuyenDe";
            this.Text = "frmTraCuuKetQuaChuyenDe";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgvChuyenDe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbtimkiem;
        private System.Windows.Forms.DataGridView dgvTraCuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCD1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHOM11;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY11;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMHOC11;
        private System.Windows.Forms.TextBox txtTim_Kiem;
        private System.Windows.Forms.ComboBox cbbTim_Kiem;
        private System.Windows.Forms.Label label2;
    }
}