namespace Lab06
{
    partial class frmNhapLieu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSoDong = new System.Windows.Forms.Label();
            this.lblSoCot = new System.Windows.Forms.Label();
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblSoDong
            this.lblSoDong.AutoSize = true;
            this.lblSoDong.Location = new System.Drawing.Point(20, 25);
            this.lblSoDong.Name = "lblSoDong";
            this.lblSoDong.Text = "Số dòng";
            // lblSoCot
            this.lblSoCot.AutoSize = true;
            this.lblSoCot.Location = new System.Drawing.Point(20, 60);
            this.lblSoCot.Name = "lblSoCot";
            this.lblSoCot.Text = "Số cột";
            // txtSoDong
            this.txtSoDong.Location = new System.Drawing.Point(90, 22);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(100, 23);
            this.txtSoDong.TabIndex = 0;
            // txtSoCot
            this.txtSoCot.Location = new System.Drawing.Point(90, 57);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(100, 23);
            this.txtSoCot.TabIndex = 1;
            // btnKhoiTao
            this.btnKhoiTao.Location = new System.Drawing.Point(215, 22);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(110, 58);
            this.btnKhoiTao.TabIndex = 2;
            this.btnKhoiTao.Text = "Khởi tạo form";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // frmNhapLieu
            this.AcceptButton = this.btnKhoiTao;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 105);
            this.Controls.Add(this.lblSoDong);
            this.Controls.Add(this.lblSoCot);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.btnKhoiTao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNhapLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập liệu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSoDong;
        private System.Windows.Forms.Label lblSoCot;
        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.Button btnKhoiTao;
    }
}
