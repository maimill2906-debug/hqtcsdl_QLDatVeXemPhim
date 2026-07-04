namespace MovieTicketBookingSystem.GUI
{
    partial class FormMainAdmin
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
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnPhim = new System.Windows.Forms.Button();
            this.btnSuatChieu = new System.Windows.Forms.Button();
            this.btnVeGioVang = new System.Windows.Forms.Button();
            this.btnKhoBapNuoc = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnHuyNhapKho = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTaiKhoanDangNhap = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlCardPhim = new System.Windows.Forms.Panel();
            this.lblCardPhimTitle = new System.Windows.Forms.Label();
            this.lblCardPhimVal = new System.Windows.Forms.Label();
            this.pnlCardSuatChieu = new System.Windows.Forms.Panel();
            this.lblCardSuatChieuTitle = new System.Windows.Forms.Label();
            this.lblCardSuatChieuVal = new System.Windows.Forms.Label();
            this.pnlCardDonVe = new System.Windows.Forms.Panel();
            this.lblCardDonVeTitle = new System.Windows.Forms.Label();
            this.lblCardDonVeVal = new System.Windows.Forms.Label();
            this.pnlCardGioVang = new System.Windows.Forms.Panel();
            this.lblCardGioVangTitle = new System.Windows.Forms.Label();
            this.lblCardGioVangVal = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlCardPhim.SuspendLayout();
            this.pnlCardSuatChieu.SuspendLayout();
            this.pnlCardDonVe.SuspendLayout();
            this.pnlCardGioVang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnTheLoai);
            this.pnlSidebar.Controls.Add(this.btnPhim);
            this.pnlSidebar.Controls.Add(this.btnSuatChieu);
            this.pnlSidebar.Controls.Add(this.btnVeGioVang);
            this.pnlSidebar.Controls.Add(this.btnKhoBapNuoc);
            this.pnlSidebar.Controls.Add(this.btnNhapKho);
            this.pnlSidebar.Controls.Add(this.btnHuyNhapKho);
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
            this.lblLogo.Size = new System.Drawing.Size(160, 70);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🎬 ADMIN";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Location = new System.Drawing.Point(0, 90);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(160, 48);
            this.btnTheLoai.TabIndex = 1;
            this.btnTheLoai.Text = "📁 Thể Loại";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnPhim
            // 
            this.btnPhim.Location = new System.Drawing.Point(0, 144);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(160, 48);
            this.btnPhim.TabIndex = 2;
            this.btnPhim.Text = "🎥 Phim";
            this.btnPhim.UseVisualStyleBackColor = true;
            // 
            // btnSuatChieu
            // 
            this.btnSuatChieu.Location = new System.Drawing.Point(0, 198);
            this.btnSuatChieu.Name = "btnSuatChieu";
            this.btnSuatChieu.Size = new System.Drawing.Size(160, 48);
            this.btnSuatChieu.TabIndex = 3;
            this.btnSuatChieu.Text = "📅 Suất Chiếu";
            this.btnSuatChieu.UseVisualStyleBackColor = true;
            // 
            // btnVeGioVang
            // 
            this.btnVeGioVang.Location = new System.Drawing.Point(0, 252);
            this.btnVeGioVang.Name = "btnVeGioVang";
            this.btnVeGioVang.Size = new System.Drawing.Size(160, 48);
            this.btnVeGioVang.TabIndex = 4;
            this.btnVeGioVang.Text = "💛 Voucher Giờ Vàng";
            this.btnVeGioVang.UseVisualStyleBackColor = true;
            // 
            // btnKhoBapNuoc
            // 
            this.btnKhoBapNuoc.Location = new System.Drawing.Point(0, 306);
            this.btnKhoBapNuoc.Name = "btnKhoBapNuoc";
            this.btnKhoBapNuoc.Size = new System.Drawing.Size(160, 48);
            this.btnKhoBapNuoc.TabIndex = 5;
            this.btnKhoBapNuoc.Text = "🍿 Kho Bắp Nước";
            this.btnKhoBapNuoc.UseVisualStyleBackColor = true;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Location = new System.Drawing.Point(0, 360);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(160, 48);
            this.btnNhapKho.TabIndex = 6;
            this.btnNhapKho.Text = "📥 Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            // 
            // btnHuyNhapKho
            // 
            this.btnHuyNhapKho.Location = new System.Drawing.Point(0, 414);
            this.btnHuyNhapKho.Name = "btnHuyNhapKho";
            this.btnHuyNhapKho.Size = new System.Drawing.Size(160, 48);
            this.btnHuyNhapKho.TabIndex = 7;
            this.btnHuyNhapKho.Text = "🗑️ Hủy Nhập";
            this.btnHuyNhapKho.UseVisualStyleBackColor = true;
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
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblTaiKhoanDangNhap);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(160, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(640, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(20, 22);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(201, 23);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "DASHBOARD QUẢN TRỊ";
            // 
            // lblTaiKhoanDangNhap
            // 
            this.lblTaiKhoanDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaiKhoanDangNhap.Location = new System.Drawing.Point(380, 25);
            this.lblTaiKhoanDangNhap.Name = "lblTaiKhoanDangNhap";
            this.lblTaiKhoanDangNhap.Size = new System.Drawing.Size(240, 23);
            this.lblTaiKhoanDangNhap.TabIndex = 1;
            this.lblTaiKhoanDangNhap.Text = "Tài khoản: admin";
            this.lblTaiKhoanDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlCardPhim);
            this.pnlContainer.Controls.Add(this.pnlCardSuatChieu);
            this.pnlContainer.Controls.Add(this.pnlCardDonVe);
            this.pnlContainer.Controls.Add(this.pnlCardGioVang);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(160, 70);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(640, 530);
            this.pnlContainer.TabIndex = 2;
            // 
            // pnlCardPhim
            // 
            this.pnlCardPhim.Controls.Add(this.lblCardPhimTitle);
            this.pnlCardPhim.Controls.Add(this.lblCardPhimVal);
            this.pnlCardPhim.Location = new System.Drawing.Point(30, 20);
            this.pnlCardPhim.Name = "pnlCardPhim";
            this.pnlCardPhim.Size = new System.Drawing.Size(240, 100);
            this.pnlCardPhim.TabIndex = 0;
            // 
            // lblCardPhimTitle
            // 
            this.lblCardPhimTitle.AutoSize = true;
            this.lblCardPhimTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardPhimTitle.Name = "lblCardPhimTitle";
            this.lblCardPhimTitle.Size = new System.Drawing.Size(117, 23);
            this.lblCardPhimTitle.TabIndex = 0;
            this.lblCardPhimTitle.Text = "TỔNG SỐ PHIM";
            // 
            // lblCardPhimVal
            // 
            this.lblCardPhimVal.AutoSize = true;
            this.lblCardPhimVal.Location = new System.Drawing.Point(15, 45);
            this.lblCardPhimVal.Name = "lblCardPhimVal";
            this.lblCardPhimVal.Size = new System.Drawing.Size(32, 46);
            this.lblCardPhimVal.TabIndex = 1;
            this.lblCardPhimVal.Text = "0";
            // 
            // pnlCardSuatChieu
            // 
            this.pnlCardSuatChieu.Controls.Add(this.lblCardSuatChieuTitle);
            this.pnlCardSuatChieu.Controls.Add(this.lblCardSuatChieuVal);
            this.pnlCardSuatChieu.Location = new System.Drawing.Point(290, 20);
            this.pnlCardSuatChieu.Name = "pnlCardSuatChieu";
            this.pnlCardSuatChieu.Size = new System.Drawing.Size(240, 100);
            this.pnlCardSuatChieu.TabIndex = 1;
            // 
            // lblCardSuatChieuTitle
            // 
            this.lblCardSuatChieuTitle.AutoSize = true;
            this.lblCardSuatChieuTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardSuatChieuTitle.Name = "lblCardSuatChieuTitle";
            this.lblCardSuatChieuTitle.Size = new System.Drawing.Size(133, 23);
            this.lblCardSuatChieuTitle.TabIndex = 0;
            this.lblCardSuatChieuTitle.Text = "TỔNG SUẤT CHIẾU";
            // 
            // lblCardSuatChieuVal
            // 
            this.lblCardSuatChieuVal.AutoSize = true;
            this.lblCardSuatChieuVal.Location = new System.Drawing.Point(15, 45);
            this.lblCardSuatChieuVal.Name = "lblCardSuatChieuVal";
            this.lblCardSuatChieuVal.Size = new System.Drawing.Size(32, 46);
            this.lblCardSuatChieuVal.TabIndex = 1;
            this.lblCardSuatChieuVal.Text = "0";
            // 
            // pnlCardDonVe
            // 
            this.pnlCardDonVe.Controls.Add(this.lblCardDonVeTitle);
            this.pnlCardDonVe.Controls.Add(this.lblCardDonVeVal);
            this.pnlCardDonVe.Location = new System.Drawing.Point(30, 140);
            this.pnlCardDonVe.Name = "pnlCardDonVe";
            this.pnlCardDonVe.Size = new System.Drawing.Size(240, 100);
            this.pnlCardDonVe.TabIndex = 2;
            // 
            // lblCardDonVeTitle
            // 
            this.lblCardDonVeTitle.AutoSize = true;
            this.lblCardDonVeTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardDonVeTitle.Name = "lblCardDonVeTitle";
            this.lblCardDonVeTitle.Size = new System.Drawing.Size(149, 23);
            this.lblCardDonVeTitle.TabIndex = 0;
            this.lblCardDonVeTitle.Text = "TỔNG ĐƠN ĐẶT VÉ";
            // 
            // lblCardDonVeVal
            // 
            this.lblCardDonVeVal.AutoSize = true;
            this.lblCardDonVeVal.Location = new System.Drawing.Point(15, 45);
            this.lblCardDonVeVal.Name = "lblCardDonVeVal";
            this.lblCardDonVeVal.Size = new System.Drawing.Size(32, 46);
            this.lblCardDonVeVal.TabIndex = 1;
            this.lblCardDonVeVal.Text = "0";
            // 
            // pnlCardGioVang
            // 
            this.pnlCardGioVang.Controls.Add(this.lblCardGioVangTitle);
            this.pnlCardGioVang.Controls.Add(this.lblCardGioVangVal);
            this.pnlCardGioVang.Location = new System.Drawing.Point(290, 140);
            this.pnlCardGioVang.Name = "pnlCardGioVang";
            this.pnlCardGioVang.Size = new System.Drawing.Size(240, 100);
            this.pnlCardGioVang.TabIndex = 3;
            // 
            // lblCardGioVangTitle
            // 
            this.lblCardGioVangTitle.AutoSize = true;
            this.lblCardGioVangTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardGioVangTitle.Name = "lblCardGioVangTitle";
            this.lblCardGioVangTitle.Size = new System.Drawing.Size(155, 23);
            this.lblCardGioVangTitle.TabIndex = 0;
            this.lblCardGioVangTitle.Text = "LÔ VÉ GIỜ VÀNG";
            // 
            // lblCardGioVangVal
            // 
            this.lblCardGioVangVal.AutoSize = true;
            this.lblCardGioVangVal.Location = new System.Drawing.Point(15, 55);
            this.lblCardGioVangVal.Name = "lblCardGioVangVal";
            this.lblCardGioVangVal.Size = new System.Drawing.Size(32, 46);
            this.lblCardGioVangVal.TabIndex = 1;
            this.lblCardGioVangVal.Text = "0";
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "FormMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý đặt vé xem phim";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlCardPhim.ResumeLayout(false);
            this.pnlCardPhim.PerformLayout();
            this.pnlCardSuatChieu.ResumeLayout(false);
            this.pnlCardSuatChieu.PerformLayout();
            this.pnlCardDonVe.ResumeLayout(false);
            this.pnlCardDonVe.PerformLayout();
            this.pnlCardGioVang.ResumeLayout(false);
            this.pnlCardGioVang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnPhim;
        private System.Windows.Forms.Button btnSuatChieu;
        private System.Windows.Forms.Button btnVeGioVang;
        private System.Windows.Forms.Button btnKhoBapNuoc;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnHuyNhapKho;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTaiKhoanDangNhap;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlCardPhim;
        private System.Windows.Forms.Label lblCardPhimTitle;
        private System.Windows.Forms.Label lblCardPhimVal;
        private System.Windows.Forms.Panel pnlCardSuatChieu;
        private System.Windows.Forms.Label lblCardSuatChieuTitle;
        private System.Windows.Forms.Label lblCardSuatChieuVal;
        private System.Windows.Forms.Panel pnlCardDonVe;
        private System.Windows.Forms.Label lblCardDonVeTitle;
        private System.Windows.Forms.Label lblCardDonVeVal;
        private System.Windows.Forms.Panel pnlCardGioVang;
        private System.Windows.Forms.Label lblCardGioVangTitle;
        private System.Windows.Forms.Label lblCardGioVangVal;
    }
}
