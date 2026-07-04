namespace MovieTicketBookingSystem.GUI
{
    partial class FormMainCustomer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMuaVe = new System.Windows.Forms.Button();
            this.btnSanVeGioVang = new System.Windows.Forms.Button();
            this.btnViVoucher = new System.Windows.Forms.Button();
            this.btnVeCuaToi = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnMuaVe);
            this.pnlSidebar.Controls.Add(this.btnSanVeGioVang);
            this.pnlSidebar.Controls.Add(this.btnViVoucher);
            this.pnlSidebar.Controls.Add(this.btnVeCuaToi);
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(160, 600);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(160, 65);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🎟️ TICKET";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMuaVe
            // 
            this.btnMuaVe.Location = new System.Drawing.Point(0, 90);
            this.btnMuaVe.Name = "btnMuaVe";
            this.btnMuaVe.Size = new System.Drawing.Size(160, 48);
            this.btnMuaVe.TabIndex = 1;
            this.btnMuaVe.Text = "🎬 Đặt Vé";
            this.btnMuaVe.UseVisualStyleBackColor = true;
            // 
            // btnSanVeGioVang
            // 
            this.btnSanVeGioVang.Location = new System.Drawing.Point(0, 144);
            this.btnSanVeGioVang.Name = "btnSanVeGioVang";
            this.btnSanVeGioVang.Size = new System.Drawing.Size(160, 48);
            this.btnSanVeGioVang.TabIndex = 2;
            this.btnSanVeGioVang.Text = "⚡ Săn Voucher";
            this.btnSanVeGioVang.UseVisualStyleBackColor = true;
            // 
            // btnViVoucher
            // 
            this.btnViVoucher.Location = new System.Drawing.Point(0, 198);
            this.btnViVoucher.Name = "btnViVoucher";
            this.btnViVoucher.Size = new System.Drawing.Size(160, 48);
            this.btnViVoucher.TabIndex = 3;
            this.btnViVoucher.Text = "🎁 Ví Voucher";
            this.btnViVoucher.UseVisualStyleBackColor = true;
            // 
            // btnVeCuaToi
            // 
            this.btnVeCuaToi.Location = new System.Drawing.Point(0, 252);
            this.btnVeCuaToi.Name = "btnVeCuaToi";
            this.btnVeCuaToi.Size = new System.Drawing.Size(160, 48);
            this.btnVeCuaToi.TabIndex = 4;
            this.btnVeCuaToi.Text = "🎫 Vé Của Tôi";
            this.btnVeCuaToi.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 550);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(160, 50);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "🚪 Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblTaiKhoan);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(160, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(640, 65);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(120, 23);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CHỌN PHIM";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(310, 20);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(310, 23);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Khách hàng: khachhang";
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(160, 65);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(640, 535);
            this.pnlContainer.TabIndex = 2;
            // 
            // FormMainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "FormMainCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Đặt Vé Xem Phim - Khách hàng";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMuaVe;
        private System.Windows.Forms.Button btnSanVeGioVang;
        private System.Windows.Forms.Button btnViVoucher;
        private System.Windows.Forms.Button btnVeCuaToi;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Panel pnlContainer;
    }
}
