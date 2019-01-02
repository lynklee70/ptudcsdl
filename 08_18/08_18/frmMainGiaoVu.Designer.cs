namespace _08_18
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnXemThongTinCD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDanhSachCD = new System.Windows.Forms.Button();
            this.btnTraCuuDiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTaoTK);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 96);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý ";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(6, 29);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(126, 50);
            this.btnTaoTK.TabIndex = 1;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnXemThongTinCD
            // 
            this.btnXemThongTinCD.Location = new System.Drawing.Point(305, 39);
            this.btnXemThongTinCD.Name = "btnXemThongTinCD";
            this.btnXemThongTinCD.Size = new System.Drawing.Size(126, 50);
            this.btnXemThongTinCD.TabIndex = 2;
            this.btnXemThongTinCD.Text = "Xem thông tin đăng ký chuyên đề";
            this.btnXemThongTinCD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDanhSachCD);
            this.groupBox1.Controls.Add(this.btnXemThongTinCD);
            this.groupBox1.Controls.Add(this.btnTraCuuDiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học";
            // 
            // btnDanhSachCD
            // 
            this.btnDanhSachCD.Location = new System.Drawing.Point(153, 39);
            this.btnDanhSachCD.Name = "btnDanhSachCD";
            this.btnDanhSachCD.Size = new System.Drawing.Size(131, 50);
            this.btnDanhSachCD.TabIndex = 2;
            this.btnDanhSachCD.Text = "Danh sách chuyên đề";
            this.btnDanhSachCD.UseVisualStyleBackColor = true;
            this.btnDanhSachCD.Click += new System.EventHandler(this.btnDanhSachCD_Click);
            // 
            // btnTraCuuDiem
            // 
            this.btnTraCuuDiem.Location = new System.Drawing.Point(6, 39);
            this.btnTraCuuDiem.Name = "btnTraCuuDiem";
            this.btnTraCuuDiem.Size = new System.Drawing.Size(126, 50);
            this.btnTraCuuDiem.TabIndex = 0;
            this.btnTraCuuDiem.Text = "Tra cứu điểm học phần";
            this.btnTraCuuDiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(364, 233);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 26);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMainGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 294);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainGiaoVu";
            this.Text = "frmMainGiaoVu";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnXemThongTinCD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDanhSachCD;
        private System.Windows.Forms.Button btnTraCuuDiem;
        private System.Windows.Forms.Button btnThoat;
    }
}