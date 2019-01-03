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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnCDPT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(86, 128);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "button1";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnCDPT
            // 
            this.btnCDPT.Location = new System.Drawing.Point(312, 128);
            this.btnCDPT.Name = "btnCDPT";
            this.btnCDPT.Size = new System.Drawing.Size(75, 23);
            this.btnCDPT.TabIndex = 1;
            this.btnCDPT.Text = "button2";
            this.btnCDPT.UseVisualStyleBackColor = true;
            this.btnCDPT.Click += new System.EventHandler(this.btnCDPT_Click);
            // 
            // frmMainGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 266);
            this.Controls.Add(this.btnCDPT);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "frmMainGiaoVien";
            this.Text = "frmMainGiaoVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnCDPT;
    }
}