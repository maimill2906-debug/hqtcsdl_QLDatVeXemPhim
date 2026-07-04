namespace MovieTicketBookingSystem.GUI
{
    partial class FormVeCuaToi
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblTrangThaiVal = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTongTienVal = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGheVal = new System.Windows.Forms.Label();
            this.lblGhe = new System.Windows.Forms.Label();
            this.lblGioChieuVal = new System.Windows.Forms.Label();
            this.lblGioChieu = new System.Windows.Forms.Label();
            this.lblNgayChieuVal = new System.Windows.Forms.Label();
            this.lblNgayChieu = new System.Windows.Forms.Label();
            this.lblTenPhimVal = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblMaDatVeVal = new System.Windows.Forms.Label();
            this.lblMaDatVe = new System.Windows.Forms.Label();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH VÉ PHIM ĐÃ MUA";
            // 
            // dgvVe
            // 
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVe.Location = new System.Drawing.Point(0, 60);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.Size = new System.Drawing.Size(600, 490);
            this.dgvVe.TabIndex = 1;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblTrangThaiVal);
            this.pnlDetails.Controls.Add(this.lblTrangThai);
            this.pnlDetails.Controls.Add(this.lblTongTienVal);
            this.pnlDetails.Controls.Add(this.lblTongTien);
            this.pnlDetails.Controls.Add(this.lblGheVal);
            this.pnlDetails.Controls.Add(this.lblGhe);
            this.pnlDetails.Controls.Add(this.lblGioChieuVal);
            this.pnlDetails.Controls.Add(this.lblGioChieu);
            this.pnlDetails.Controls.Add(this.lblNgayChieuVal);
            this.pnlDetails.Controls.Add(this.lblNgayChieu);
            this.pnlDetails.Controls.Add(this.lblTenPhimVal);
            this.pnlDetails.Controls.Add(this.lblTenPhim);
            this.pnlDetails.Controls.Add(this.lblMaDatVeVal);
            this.pnlDetails.Controls.Add(this.lblMaDatVe);
            this.pnlDetails.Controls.Add(this.lblDetailTitle);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Location = new System.Drawing.Point(600, 60);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(350, 490);
            this.pnlDetails.TabIndex = 2;
            // 
            // lblTrangThaiVal
            // 
            this.lblTrangThaiVal.AutoSize = true;
            this.lblTrangThaiVal.Location = new System.Drawing.Point(150, 270);
            this.lblTrangThaiVal.Name = "lblTrangThaiVal";
            this.lblTrangThaiVal.Size = new System.Drawing.Size(97, 23);
            this.lblTrangThaiVal.TabIndex = 14;
            this.lblTrangThaiVal.Text = "(Trạng thái)";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(20, 270);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 23);
            this.lblTrangThai.TabIndex = 13;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblTongTienVal
            // 
            this.lblTongTienVal.AutoSize = true;
            this.lblTongTienVal.Location = new System.Drawing.Point(150, 235);
            this.lblTongTienVal.Name = "lblTongTienVal";
            this.lblTongTienVal.Size = new System.Drawing.Size(60, 23);
            this.lblTongTienVal.TabIndex = 12;
            this.lblTongTienVal.Text = "0 VND";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(20, 235);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(87, 23);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblGheVal
            // 
            this.lblGheVal.AutoSize = true;
            this.lblGheVal.Location = new System.Drawing.Point(150, 200);
            this.lblGheVal.Name = "lblGheVal";
            this.lblGheVal.Size = new System.Drawing.Size(103, 23);
            this.lblGheVal.TabIndex = 10;
            this.lblGheVal.Text = "(Chưa chọn)";
            // 
            // lblGhe
            // 
            this.lblGhe.AutoSize = true;
            this.lblGhe.Location = new System.Drawing.Point(20, 200);
            this.lblGhe.Name = "lblGhe";
            this.lblGhe.Size = new System.Drawing.Size(114, 23);
            this.lblGhe.TabIndex = 9;
            this.lblGhe.Text = "Vị trí ghế đặt:";
            // 
            // lblGioChieuVal
            // 
            this.lblGioChieuVal.AutoSize = true;
            this.lblGioChieuVal.Location = new System.Drawing.Point(150, 165);
            this.lblGioChieuVal.Name = "lblGioChieuVal";
            this.lblGioChieuVal.Size = new System.Drawing.Size(72, 23);
            this.lblGioChieuVal.TabIndex = 8;
            this.lblGioChieuVal.Text = "00:00:00";
            // 
            // lblGioChieu
            // 
            this.lblGioChieu.AutoSize = true;
            this.lblGioChieu.Location = new System.Drawing.Point(20, 165);
            this.lblGioChieu.Name = "lblGioChieu";
            this.lblGioChieu.Size = new System.Drawing.Size(86, 23);
            this.lblGioChieu.TabIndex = 7;
            this.lblGioChieu.Text = "Giờ chiếu:";
            // 
            // lblNgayChieuVal
            // 
            this.lblNgayChieuVal.AutoSize = true;
            this.lblNgayChieuVal.Location = new System.Drawing.Point(150, 130);
            this.lblNgayChieuVal.Name = "lblNgayChieuVal";
            this.lblNgayChieuVal.Size = new System.Drawing.Size(96, 23);
            this.lblNgayChieuVal.TabIndex = 6;
            this.lblNgayChieuVal.Text = "01/01/2026";
            // 
            // lblNgayChieu
            // 
            this.lblNgayChieu.AutoSize = true;
            this.lblNgayChieu.Location = new System.Drawing.Point(20, 130);
            this.lblNgayChieu.Name = "lblNgayChieu";
            this.lblNgayChieu.Size = new System.Drawing.Size(100, 23);
            this.lblNgayChieu.TabIndex = 5;
            this.lblNgayChieu.Text = "Ngày chiếu:";
            // 
            // lblTenPhimVal
            // 
            this.lblTenPhimVal.AutoSize = true;
            this.lblTenPhimVal.Location = new System.Drawing.Point(150, 95);
            this.lblTenPhimVal.Name = "lblTenPhimVal";
            this.lblTenPhimVal.Size = new System.Drawing.Size(90, 23);
            this.lblTenPhimVal.TabIndex = 4;
            this.lblTenPhimVal.Text = "(Tên phim)";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(20, 95);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(84, 23);
            this.lblTenPhim.TabIndex = 3;
            this.lblTenPhim.Text = "Tên phim:";
            // 
            // lblMaDatVeVal
            // 
            this.lblMaDatVeVal.AutoSize = true;
            this.lblMaDatVeVal.Location = new System.Drawing.Point(150, 60);
            this.lblMaDatVeVal.Name = "lblMaDatVeVal";
            this.lblMaDatVeVal.Size = new System.Drawing.Size(79, 23);
            this.lblMaDatVeVal.TabIndex = 2;
            this.lblMaDatVeVal.Text = "(Mã đơn)";
            // 
            // lblMaDatVe
            // 
            this.lblMaDatVe.AutoSize = true;
            this.lblMaDatVe.Location = new System.Drawing.Point(20, 60);
            this.lblMaDatVe.Name = "lblMaDatVe";
            this.lblMaDatVe.Size = new System.Drawing.Size(90, 23);
            this.lblMaDatVe.TabIndex = 1;
            this.lblMaDatVe.Text = "Mã đặt vé:";
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.Location = new System.Drawing.Point(20, 15);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(175, 28);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "CHI TIẾT ĐƠN VÉ";
            // 
            // FormVeCuaToi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVeCuaToi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vé Của Tôi";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblTrangThaiVal;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTongTienVal;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGheVal;
        private System.Windows.Forms.Label lblGhe;
        private System.Windows.Forms.Label lblGioChieuVal;
        private System.Windows.Forms.Label lblGioChieu;
        private System.Windows.Forms.Label lblNgayChieuVal;
        private System.Windows.Forms.Label lblNgayChieu;
        private System.Windows.Forms.Label lblTenPhimVal;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblMaDatVeVal;
        private System.Windows.Forms.Label lblMaDatVe;
        private System.Windows.Forms.Label lblDetailTitle;
    }
}
