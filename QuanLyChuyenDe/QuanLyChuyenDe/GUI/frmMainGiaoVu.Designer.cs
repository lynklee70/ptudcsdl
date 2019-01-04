namespace QuanLyChuyenDe.GUI
{
    partial class frmMainGiaoVu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuanLyChuyenDe = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.btnTraCuKQDK = new System.Windows.Forms.Button();
            this.btnTraCuuDiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTraCuuDiem);
            this.groupBox1.Controls.Add(this.btnTraCuKQDK);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTaoTaiKhoan);
            this.groupBox2.Controls.Add(this.btnQuanLyChuyenDe);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hệ thống";
            // 
            // btnQuanLyChuyenDe
            // 
            this.btnQuanLyChuyenDe.Location = new System.Drawing.Point(50, 20);
            this.btnQuanLyChuyenDe.Name = "btnQuanLyChuyenDe";
            this.btnQuanLyChuyenDe.Size = new System.Drawing.Size(180, 60);
            this.btnQuanLyChuyenDe.TabIndex = 1;
            this.btnQuanLyChuyenDe.Text = "QUẢN LÝ CHUYÊN ĐỀ";
            this.btnQuanLyChuyenDe.UseVisualStyleBackColor = true;
            this.btnQuanLyChuyenDe.Click += new System.EventHandler(this.btnQuanLyChuyenDe_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(250, 20);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(180, 60);
            this.btnTaoTaiKhoan.TabIndex = 2;
            this.btnTaoTaiKhoan.Text = "TẠO TÀI KHOẢN";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // btnTraCuKQDK
            // 
            this.btnTraCuKQDK.Location = new System.Drawing.Point(50, 20);
            this.btnTraCuKQDK.Name = "btnTraCuKQDK";
            this.btnTraCuKQDK.Size = new System.Drawing.Size(180, 60);
            this.btnTraCuKQDK.TabIndex = 4;
            this.btnTraCuKQDK.Text = "TRA CỨU KẾT QUẢ ĐĂNG KỲ CHUYÊN ĐỀ";
            this.btnTraCuKQDK.UseVisualStyleBackColor = true;
            this.btnTraCuKQDK.Click += new System.EventHandler(this.btnTraCuKQDK_Click);
            // 
            // btnTraCuuDiem
            // 
            this.btnTraCuuDiem.Location = new System.Drawing.Point(250, 20);
            this.btnTraCuuDiem.Name = "btnTraCuuDiem";
            this.btnTraCuuDiem.Size = new System.Drawing.Size(180, 60);
            this.btnTraCuuDiem.TabIndex = 5;
            this.btnTraCuuDiem.Text = "TRA CỨU ĐIỂM HỌC PHẦN";
            this.btnTraCuuDiem.UseVisualStyleBackColor = true;
            this.btnTraCuuDiem.Click += new System.EventHandler(this.btnTraCuuDiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(354, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMainGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 315);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainGiaoVu";
            this.Text = "frmMainGiaoVu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainGiaoVu_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraCuuDiem;
        private System.Windows.Forms.Button btnTraCuKQDK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyChuyenDe;
        private System.Windows.Forms.Button btnThoat;
    }
}