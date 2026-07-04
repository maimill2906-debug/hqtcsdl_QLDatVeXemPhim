namespace MovieTicketBookingSystem.GUI
{
    partial class FormDatVe
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
            this.lblVoucherText = new System.Windows.Forms.Label();
            this.cboVoucher = new System.Windows.Forms.ComboBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlSeatsLayout = new System.Windows.Forms.Panel();
            this.flpSoDoGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblLegendBooked = new System.Windows.Forms.Label();
            this.pnlLegendBooked = new System.Windows.Forms.Panel();
            this.lblLegendSelecting = new System.Windows.Forms.Label();
            this.pnlLegendSelecting = new System.Windows.Forms.Panel();
            this.lblLegendAvailable = new System.Windows.Forms.Label();
            this.pnlLegendAvailable = new System.Windows.Forms.Panel();
            this.pnlManHinh = new System.Windows.Forms.Panel();
            this.lblManHinhText = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblPriceInfo = new System.Windows.Forms.Label();
            this.lblGheDaChonText = new System.Windows.Forms.Label();
            this.lblGheDaChon = new System.Windows.Forms.Label();
            this.lblSuatChieuSelected = new System.Windows.Forms.Label();
            this.lblTenPhimSelected = new System.Windows.Forms.Label();
            this.btnXacNhanDatVe = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlSeatsLayout.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlManHinh.SuspendLayout();
            this.pnlBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dgvSuatChieu);
            this.pnlLeft.Controls.Add(this.lblTenPhim);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(260, 510);
            this.pnlLeft.TabIndex = 0;
            // 
            // dgvSuatChieu
            // 
            this.dgvSuatChieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuatChieu.Location = new System.Drawing.Point(10, 130);
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.RowHeadersWidth = 51;
            this.dgvSuatChieu.Size = new System.Drawing.Size(240, 370);
            this.dgvSuatChieu.TabIndex = 2;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenPhim.Location = new System.Drawing.Point(10, 75);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(110, 28);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên phim: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH SUẤT CHIẾU";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlSeatsLayout);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(260, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(740, 510);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlSeatsLayout
            // 
            this.pnlSeatsLayout.Controls.Add(this.flpSoDoGhe);
            this.pnlSeatsLayout.Controls.Add(this.pnlLegend);
            this.pnlSeatsLayout.Controls.Add(this.pnlManHinh);
            this.pnlSeatsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeatsLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlSeatsLayout.Name = "pnlSeatsLayout";
            this.pnlSeatsLayout.Size = new System.Drawing.Size(720, 480);
            this.pnlSeatsLayout.TabIndex = 1;
            // 
            // flpSoDoGhe
            // 
            this.flpSoDoGhe.AutoScroll = true;
            this.flpSoDoGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSoDoGhe.Location = new System.Drawing.Point(0, 35);
            this.flpSoDoGhe.Name = "flpSoDoGhe";
            this.flpSoDoGhe.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.flpSoDoGhe.Size = new System.Drawing.Size(720, 375);
            this.flpSoDoGhe.TabIndex = 2;
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.lblLegendBooked);
            this.pnlLegend.Controls.Add(this.pnlLegendBooked);
            this.pnlLegend.Controls.Add(this.lblLegendSelecting);
            this.pnlLegend.Controls.Add(this.pnlLegendSelecting);
            this.pnlLegend.Controls.Add(this.lblLegendAvailable);
            this.pnlLegend.Controls.Add(this.pnlLegendAvailable);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLegend.Location = new System.Drawing.Point(0, 410);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(720, 50);
            this.pnlLegend.TabIndex = 1;
            // 
            // lblLegendBooked
            // 
            this.lblLegendBooked.AutoSize = true;
            this.lblLegendBooked.Location = new System.Drawing.Point(430, 15);
            this.lblLegendBooked.Name = "lblLegendBooked";
            this.lblLegendBooked.Size = new System.Drawing.Size(95, 23);
            this.lblLegendBooked.TabIndex = 5;
            this.lblLegendBooked.Text = "Ghế đã đặt";
            // 
            // pnlLegendBooked
            // 
            this.pnlLegendBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.pnlLegendBooked.Location = new System.Drawing.Point(400, 16);
            this.pnlLegendBooked.Name = "pnlLegendBooked";
            this.pnlLegendBooked.Size = new System.Drawing.Size(24, 20);
            this.pnlLegendBooked.TabIndex = 4;
            // 
            // lblLegendSelecting
            // 
            this.lblLegendSelecting.AutoSize = true;
            this.lblLegendSelecting.Location = new System.Drawing.Point(240, 15);
            this.lblLegendSelecting.Name = "lblLegendSelecting";
            this.lblLegendSelecting.Size = new System.Drawing.Size(128, 23);
            this.lblLegendSelecting.TabIndex = 3;
            this.lblLegendSelecting.Text = "Ghế đang chọn";
            // 
            // pnlLegendSelecting
            // 
            this.pnlLegendSelecting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.pnlLegendSelecting.Location = new System.Drawing.Point(210, 16);
            this.pnlLegendSelecting.Name = "pnlLegendSelecting";
            this.pnlLegendSelecting.Size = new System.Drawing.Size(24, 20);
            this.pnlLegendSelecting.TabIndex = 2;
            // 
            // lblLegendAvailable
            // 
            this.lblLegendAvailable.AutoSize = true;
            this.lblLegendAvailable.Location = new System.Drawing.Point(65, 15);
            this.lblLegendAvailable.Name = "lblLegendAvailable";
            this.lblLegendAvailable.Size = new System.Drawing.Size(121, 23);
            this.lblLegendAvailable.TabIndex = 1;
            this.lblLegendAvailable.Text = "Ghế còn trống";
            // 
            // pnlLegendAvailable
            // 
            this.pnlLegendAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.pnlLegendAvailable.Location = new System.Drawing.Point(35, 16);
            this.pnlLegendAvailable.Name = "pnlLegendAvailable";
            this.pnlLegendAvailable.Size = new System.Drawing.Size(24, 20);
            this.pnlLegendAvailable.TabIndex = 0;
            // 
            // pnlManHinh
            // 
            this.pnlManHinh.Controls.Add(this.lblManHinhText);
            this.pnlManHinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManHinh.Location = new System.Drawing.Point(0, 0);
            this.pnlManHinh.Name = "pnlManHinh";
            this.pnlManHinh.Size = new System.Drawing.Size(720, 35);
            this.pnlManHinh.TabIndex = 0;
            // 
            // lblManHinhText
            // 
            this.lblManHinhText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblManHinhText.Location = new System.Drawing.Point(0, 0);
            this.lblManHinhText.Name = "lblManHinhText";
            this.lblManHinhText.Size = new System.Drawing.Size(720, 35);
            this.lblManHinhText.TabIndex = 0;
            this.lblManHinhText.Text = "MÀN HÌNH CHIẾU";
            this.lblManHinhText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.lblVoucherText);
            this.pnlBill.Controls.Add(this.cboVoucher);
            this.pnlBill.Controls.Add(this.lblPriceInfo);
            this.pnlBill.Controls.Add(this.lblGheDaChonText);
            this.pnlBill.Controls.Add(this.lblGheDaChon);
            this.pnlBill.Controls.Add(this.lblSuatChieuSelected);
            this.pnlBill.Controls.Add(this.lblTenPhimSelected);
            this.pnlBill.Controls.Add(this.btnXacNhanDatVe);
            this.pnlBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBill.Location = new System.Drawing.Point(0, 510);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(1000, 90);
            this.pnlBill.TabIndex = 0;
            // 
            // lblVoucherText
            // 
            this.lblVoucherText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoucherText.AutoSize = true;
            this.lblVoucherText.Location = new System.Drawing.Point(400, 50);
            this.lblVoucherText.Name = "lblVoucherText";
            this.lblVoucherText.Size = new System.Drawing.Size(117, 23);
            this.lblVoucherText.TabIndex = 6;
            this.lblVoucherText.Text = "Áp dụng Voucher:";
            // 
            // cboVoucher
            // 
            this.cboVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoucher.FormattingEnabled = true;
            this.cboVoucher.Location = new System.Drawing.Point(520, 47);
            this.cboVoucher.Name = "cboVoucher";
            this.cboVoucher.Size = new System.Drawing.Size(280, 27);
            this.cboVoucher.TabIndex = 7;
            // 
            // lblPriceInfo
            // 
            this.lblPriceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriceInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPriceInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblPriceInfo.Location = new System.Drawing.Point(680, 10);
            this.lblPriceInfo.Name = "lblPriceInfo";
            this.lblPriceInfo.Size = new System.Drawing.Size(300, 28);
            this.lblPriceInfo.TabIndex = 5;
            this.lblPriceInfo.Text = "Tổng tiền: 0 VND";
            this.lblPriceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGheDaChonText
            // 
            this.lblGheDaChonText.AutoSize = true;
            this.lblGheDaChonText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblGheDaChonText.Location = new System.Drawing.Point(20, 54);
            this.lblGheDaChonText.Name = "lblGheDaChonText";
            this.lblGheDaChonText.Size = new System.Drawing.Size(117, 23);
            this.lblGheDaChonText.TabIndex = 4;
            this.lblGheDaChonText.Text = "Ghế đã chọn: ";
            // 
            // lblGheDaChon
            // 
            this.lblGheDaChon.AutoEllipsis = true;
            this.lblGheDaChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGheDaChon.Location = new System.Drawing.Point(125, 54);
            this.lblGheDaChon.Name = "lblGheDaChon";
            this.lblGheDaChon.Size = new System.Drawing.Size(250, 30);
            this.lblGheDaChon.TabIndex = 3;
            this.lblGheDaChon.Text = "(Chưa chọn)";
            // 
            // lblSuatChieuSelected
            // 
            this.lblSuatChieuSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblSuatChieuSelected.Location = new System.Drawing.Point(20, 32);
            this.lblSuatChieuSelected.Name = "lblSuatChieuSelected";
            this.lblSuatChieuSelected.Size = new System.Drawing.Size(360, 23);
            this.lblSuatChieuSelected.TabIndex = 2;
            this.lblSuatChieuSelected.Text = "Suất chiếu: (Chưa chọn)";
            // 
            // lblTenPhimSelected
            // 
            this.lblTenPhimSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.lblTenPhimSelected.Location = new System.Drawing.Point(20, 10);
            this.lblTenPhimSelected.Name = "lblTenPhimSelected";
            this.lblTenPhimSelected.Size = new System.Drawing.Size(360, 23);
            this.lblTenPhimSelected.TabIndex = 1;
            this.lblTenPhimSelected.Text = "Phim: Tên Phim";
            // 
            // btnXacNhanDatVe
            // 
            this.btnXacNhanDatVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhanDatVe.Location = new System.Drawing.Point(830, 42);
            this.btnXacNhanDatVe.Name = "btnXacNhanDatVe";
            this.btnXacNhanDatVe.Size = new System.Drawing.Size(150, 38);
            this.btnXacNhanDatVe.TabIndex = 0;
            this.btnXacNhanDatVe.Text = "🎟️ Đặt Vé";
            this.btnXacNhanDatVe.UseVisualStyleBackColor = true;
            // 
            // FormDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBill);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Vé Xem Phim";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlSeatsLayout.ResumeLayout(false);
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.pnlManHinh.ResumeLayout(false);
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVoucherText;
        private System.Windows.Forms.ComboBox cboVoucher;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label lblPriceInfo;
        private System.Windows.Forms.Label lblGheDaChonText;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.Label lblSuatChieuSelected;
        private System.Windows.Forms.Label lblTenPhimSelected;
        private System.Windows.Forms.Button btnXacNhanDatVe;
        private System.Windows.Forms.Panel pnlSeatsLayout;
        private System.Windows.Forms.FlowLayoutPanel flpSoDoGhe;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblLegendBooked;
        private System.Windows.Forms.Panel pnlLegendBooked;
        private System.Windows.Forms.Label lblLegendSelecting;
        private System.Windows.Forms.Panel pnlLegendSelecting;
        private System.Windows.Forms.Label lblLegendAvailable;
        private System.Windows.Forms.Panel pnlLegendAvailable;
        private System.Windows.Forms.Panel pnlManHinh;
        private System.Windows.Forms.Label lblManHinhText;
    }
}
