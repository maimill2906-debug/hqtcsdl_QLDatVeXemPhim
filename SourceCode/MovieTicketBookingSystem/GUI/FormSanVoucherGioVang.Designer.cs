namespace MovieTicketBookingSystem.GUI
{
    partial class FormSanVoucherGioVang
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
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.lblMaLo = new System.Windows.Forms.Label();
            this.lblMaLoVal = new System.Windows.Forms.Label();
            this.lblSuatChieu = new System.Windows.Forms.Label();
            this.lblSuatChieuVal = new System.Windows.Forms.Label();
            this.lblGiaVePromote = new System.Windows.Forms.Label();
            this.lblGiaVeVal = new System.Windows.Forms.Label();
            this.lblSoLuongCon = new System.Windows.Forms.Label();
            this.lblSoLuongVal = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblTenPhimVal = new System.Windows.Forms.Label();
            this.lblGioChieu = new System.Windows.Forms.Label();
            this.lblGioChieuVal = new System.Windows.Forms.Label();
            this.btnSanVe = new System.Windows.Forms.Button();
            this.dgvGioVang = new System.Windows.Forms.DataGridView();
            this.pnlBanner.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioVang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.Controls.Add(this.lblTitle);
            this.pnlBanner.Controls.Add(this.lblSubTitle);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(850, 70);
            this.pnlBanner.TabIndex = 0;
            // 
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚡ SĂN VOUCHER GIỜ VÀNG";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Location = new System.Drawing.Point(20, 38);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(449, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Số lượng voucher có hạn - Nhanh tay săn ngay voucher!";
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblDetailsTitle);
            this.pnlDetails.Controls.Add(this.lblMaLo);
            this.pnlDetails.Controls.Add(this.lblMaLoVal);
            this.pnlDetails.Controls.Add(this.lblSuatChieu);
            this.pnlDetails.Controls.Add(this.lblSuatChieuVal);
            this.pnlDetails.Controls.Add(this.lblGiaVePromote);
            this.pnlDetails.Controls.Add(this.lblGiaVeVal);
            this.pnlDetails.Controls.Add(this.lblSoLuongCon);
            this.pnlDetails.Controls.Add(this.lblSoLuongVal);
            this.pnlDetails.Controls.Add(this.lblTenPhim);
            this.pnlDetails.Controls.Add(this.lblTenPhimVal);
            this.pnlDetails.Controls.Add(this.lblGioChieu);
            this.pnlDetails.Controls.Add(this.lblGioChieuVal);
            this.pnlDetails.Controls.Add(this.btnSanVe);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Location = new System.Drawing.Point(600, 70);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(250, 430);
            this.pnlDetails.TabIndex = 1;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.Location = new System.Drawing.Point(15, 20);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(212, 28);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "VOUCHER ĐANG CHỌN";
            // 
            // lblMaLo
            // 
            this.lblMaLo.AutoSize = true;
            this.lblMaLo.Location = new System.Drawing.Point(15, 60);
            this.lblMaLo.Name = "lblMaLo";
            this.lblMaLo.Size = new System.Drawing.Size(100, 23);
            this.lblMaLo.TabIndex = 1;
            this.lblMaLo.Text = "Mã voucher:";
            // 
            // lblMaLoVal
            // 
            this.lblMaLoVal.AutoSize = true;
            this.lblMaLoVal.Location = new System.Drawing.Point(125, 60);
            this.lblMaLoVal.Name = "lblMaLoVal";
            this.lblMaLoVal.Size = new System.Drawing.Size(112, 23);
            this.lblMaLoVal.TabIndex = 2;
            this.lblMaLoVal.Text = "Chưa chọn";
            // 
            // lblSuatChieu
            // 
            this.lblSuatChieu.AutoSize = true;
            this.lblSuatChieu.Location = new System.Drawing.Point(15, 95);
            this.lblSuatChieu.Name = "lblSuatChieu";
            this.lblSuatChieu.Size = new System.Drawing.Size(80, 23);
            this.lblSuatChieu.TabIndex = 3;
            this.lblSuatChieu.Text = "Hạn dùng:";
            // 
            // lblSuatChieuVal
            // 
            this.lblSuatChieuVal.AutoSize = true;
            this.lblSuatChieuVal.Location = new System.Drawing.Point(125, 95);
            this.lblSuatChieuVal.Name = "lblSuatChieuVal";
            this.lblSuatChieuVal.Size = new System.Drawing.Size(24, 23);
            this.lblSuatChieuVal.TabIndex = 4;
            this.lblSuatChieuVal.Text = "--";
            // 
            // lblGiaVePromote
            // 
            this.lblGiaVePromote.AutoSize = true;
            this.lblGiaVePromote.Location = new System.Drawing.Point(15, 130);
            this.lblGiaVePromote.Name = "lblGiaVePromote";
            this.lblGiaVePromote.Size = new System.Drawing.Size(114, 23);
            this.lblGiaVePromote.TabIndex = 5;
            this.lblGiaVePromote.Text = "Mức giảm giá:";
            // 
            // lblGiaVeVal
            // 
            this.lblGiaVeVal.AutoSize = true;
            this.lblGiaVeVal.Location = new System.Drawing.Point(125, 130);
            this.lblGiaVeVal.Name = "lblGiaVeVal";
            this.lblGiaVeVal.Size = new System.Drawing.Size(34, 23);
            this.lblGiaVeVal.TabIndex = 6;
            this.lblGiaVeVal.Text = "0 đ";
            // 
            // lblSoLuongCon
            // 
            this.lblSoLuongCon.AutoSize = true;
            this.lblSoLuongCon.Location = new System.Drawing.Point(15, 165);
            this.lblSoLuongCon.Name = "lblSoLuongCon";
            this.lblSoLuongCon.Size = new System.Drawing.Size(99, 23);
            this.lblSoLuongCon.TabIndex = 7;
            this.lblSoLuongCon.Text = "Còn lại (vé):";
            // 
            // lblSoLuongVal
            // 
            this.lblSoLuongVal.AutoSize = true;
            this.lblSoLuongVal.Location = new System.Drawing.Point(125, 165);
            this.lblSoLuongVal.Name = "lblSoLuongVal";
            this.lblSoLuongVal.Size = new System.Drawing.Size(19, 23);
            this.lblSoLuongVal.TabIndex = 8;
            this.lblSoLuongVal.Text = "0";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(15, 200);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(84, 23);
            this.lblTenPhim.TabIndex = 10;
            this.lblTenPhim.Text = "Tên phim:";
            this.lblTenPhim.Visible = false;
            // 
            // lblTenPhimVal
            // 
            this.lblTenPhimVal.Location = new System.Drawing.Point(125, 200);
            this.lblTenPhimVal.Name = "lblTenPhimVal";
            this.lblTenPhimVal.Size = new System.Drawing.Size(95, 60);
            this.lblTenPhimVal.TabIndex = 11;
            this.lblTenPhimVal.Text = "--";
            this.lblTenPhimVal.Visible = false;
            // 
            // lblGioChieu
            // 
            this.lblGioChieu.AutoSize = true;
            this.lblGioChieu.Location = new System.Drawing.Point(15, 265);
            this.lblGioChieu.Name = "lblGioChieu";
            this.lblGioChieu.Size = new System.Drawing.Size(87, 23);
            this.lblGioChieu.TabIndex = 12;
            this.lblGioChieu.Text = "Lịch chiếu:";
            this.lblGioChieu.Visible = false;
            // 
            // lblGioChieuVal
            // 
            this.lblGioChieuVal.Location = new System.Drawing.Point(125, 265);
            this.lblGioChieuVal.Name = "lblGioChieuVal";
            this.lblGioChieuVal.Size = new System.Drawing.Size(95, 50);
            this.lblGioChieuVal.TabIndex = 13;
            this.lblGioChieuVal.Text = "--";
            this.lblGioChieuVal.Visible = false;
            // 
            // btnSanVe
            // 
            this.btnSanVe.Location = new System.Drawing.Point(15, 360);
            this.btnSanVe.Name = "btnSanVe";
            this.btnSanVe.Size = new System.Drawing.Size(220, 45);
            this.btnSanVe.TabIndex = 9;
            this.btnSanVe.Text = "SĂN VOUCHER NGAY ➔";
            this.btnSanVe.UseVisualStyleBackColor = true;
            // 
            // dgvGioVang
            // 
            this.dgvGioVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioVang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioVang.Location = new System.Drawing.Point(0, 70);
            this.dgvGioVang.Name = "dgvGioVang";
            this.dgvGioVang.RowHeadersWidth = 51;
            this.dgvGioVang.Size = new System.Drawing.Size(600, 430);
            this.dgvGioVang.TabIndex = 2;
            // 
            // FormSanVeGioVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.dgvGioVang);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanVoucherGioVang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Săn Voucher Giờ Vàng";
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioVang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblMaLo;
        private System.Windows.Forms.Label lblMaLoVal;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.Label lblSuatChieuVal;
        private System.Windows.Forms.Label lblGiaVePromote;
        private System.Windows.Forms.Label lblGiaVeVal;
        private System.Windows.Forms.Label lblSoLuongCon;
        private System.Windows.Forms.Label lblSoLuongVal;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblTenPhimVal;
        private System.Windows.Forms.Label lblGioChieu;
        private System.Windows.Forms.Label lblGioChieuVal;
        private System.Windows.Forms.Button btnSanVe;
        private System.Windows.Forms.DataGridView dgvGioVang;
    }
}
