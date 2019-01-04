namespace QuanLyChuyenDe.GUI
{
    partial class frmMainGiaoVien
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
            this.btnGuiChuyenDe = new System.Windows.Forms.Button();
            this.btnCapNhatThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuiChuyenDe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hệ thống";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapNhatThongTin);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật";
            // 
            // btnGuiChuyenDe
            // 
            this.btnGuiChuyenDe.Location = new System.Drawing.Point(77, 19);
            this.btnGuiChuyenDe.Name = "btnGuiChuyenDe";
            this.btnGuiChuyenDe.Size = new System.Drawing.Size(180, 60);
            this.btnGuiChuyenDe.TabIndex = 0;
            this.btnGuiChuyenDe.Text = "Gửi chuyên đề";
            this.btnGuiChuyenDe.UseVisualStyleBackColor = true;
            this.btnGuiChuyenDe.Click += new System.EventHandler(this.btnGuiChuyenDe_Click);
            // 
            // btnCapNhatThongTin
            // 
            this.btnCapNhatThongTin.Location = new System.Drawing.Point(77, 19);
            this.btnCapNhatThongTin.Name = "btnCapNhatThongTin";
            this.btnCapNhatThongTin.Size = new System.Drawing.Size(180, 60);
            this.btnCapNhatThongTin.TabIndex = 1;
            this.btnCapNhatThongTin.Text = "Cập nhật thông tin cá nhân";
            this.btnCapNhatThongTin.UseVisualStyleBackColor = true;
            this.btnCapNhatThongTin.Click += new System.EventHandler(this.btnCapNhatThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(191, 236);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMainGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 291);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainGiaoVien";
            this.Text = "frmMainGiaoVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainGiaoVien_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuiChuyenDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhatThongTin;
        private System.Windows.Forms.Button btnThoat;

    }
}