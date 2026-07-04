namespace MovieTicketBookingSystem.GUI
{
    partial class FormVoucherGioVang
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
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaLo = new System.Windows.Forms.Label();
            this.txtMaLo = new System.Windows.Forms.TextBox();
            this.lblSuatChieu = new System.Windows.Forms.Label();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.nudGiaVe = new System.Windows.Forms.NumericUpDown();
            this.lblKinhPhiToiDa = new System.Windows.Forms.Label();
            this.nudKinhPhiToiDa = new System.Windows.Forms.NumericUpDown();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvLoVeGioVang = new System.Windows.Forms.DataGridView();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKinhPhiToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoVeGioVang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Controls.Add(this.lblMaLo);
            this.pnlInput.Controls.Add(this.txtMaLo);
            this.pnlInput.Controls.Add(this.lblSuatChieu);
            this.pnlInput.Controls.Add(this.cboSuatChieu);
            this.pnlInput.Controls.Add(this.lblSoLuong);
            this.pnlInput.Controls.Add(this.nudSoLuong);
            this.pnlInput.Controls.Add(this.lblGiaVe);
            this.pnlInput.Controls.Add(this.nudGiaVe);
            this.pnlInput.Controls.Add(this.lblKinhPhiToiDa);
            this.pnlInput.Controls.Add(this.nudKinhPhiToiDa);
            this.pnlInput.Controls.Add(this.lblTrangThai);
            this.pnlInput.Controls.Add(this.cboTrangThai);
            this.pnlInput.Controls.Add(this.btnThem);
            this.pnlInput.Controls.Add(this.btnSua);
            this.pnlInput.Controls.Add(this.btnXoa);
            this.pnlInput.Controls.Add(this.btnLamMoi);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(950, 240);
            this.pnlInput.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ VOUCHER GIỜ VÀNG";
            // 
            // lblMaLo
            // 
            this.lblMaLo.AutoSize = true;
            this.lblMaLo.Location = new System.Drawing.Point(20, 50);
            this.lblMaLo.Name = "lblMaLo";
            this.lblMaLo.Size = new System.Drawing.Size(57, 23);
            this.lblMaLo.TabIndex = 1;
            this.lblMaLo.Text = "Mã voucher:";
            // 
            // txtMaLo
            // 
            this.txtMaLo.Location = new System.Drawing.Point(20, 75);
            this.txtMaLo.Name = "txtMaLo";
            this.txtMaLo.Size = new System.Drawing.Size(120, 30);
            this.txtMaLo.TabIndex = 2;
            // 
            // lblSuatChieu
            // 
            this.lblSuatChieu.AutoSize = true;
            this.lblSuatChieu.Location = new System.Drawing.Point(160, 50);
            this.lblSuatChieu.Name = "lblSuatChieu";
            this.lblSuatChieu.Size = new System.Drawing.Size(94, 23);
            this.lblSuatChieu.TabIndex = 3;
            this.lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuatChieu.Location = new System.Drawing.Point(160, 75);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(160, 31);
            this.cboSuatChieu.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(340, 50);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(82, 23);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(340, 75);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(110, 30);
            this.nudSoLuong.TabIndex = 6;
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Location = new System.Drawing.Point(470, 50);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(61, 23);
            this.lblGiaVe.TabIndex = 7;
            this.lblGiaVe.Text = "Mức giảm:";
            // 
            // nudGiaVe
            // 
            this.nudGiaVe.Location = new System.Drawing.Point(470, 75);
            this.nudGiaVe.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGiaVe.Name = "nudGiaVe";
            this.nudGiaVe.Size = new System.Drawing.Size(120, 30);
            this.nudGiaVe.TabIndex = 8;
            // 
            // lblKinhPhiToiDa
            // 
            this.lblKinhPhiToiDa.AutoSize = true;
            this.lblKinhPhiToiDa.Location = new System.Drawing.Point(20, 115);
            this.lblKinhPhiToiDa.Name = "lblKinhPhiToiDa";
            this.lblKinhPhiToiDa.Size = new System.Drawing.Size(126, 23);
            this.lblKinhPhiToiDa.TabIndex = 9;
            this.lblKinhPhiToiDa.Text = "Kinh phí tối đa:";
            // 
            // nudKinhPhiToiDa
            // 
            this.nudKinhPhiToiDa.Location = new System.Drawing.Point(20, 140);
            this.nudKinhPhiToiDa.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudKinhPhiToiDa.Name = "nudKinhPhiToiDa";
            this.nudKinhPhiToiDa.Size = new System.Drawing.Size(200, 30);
            this.nudKinhPhiToiDa.TabIndex = 10;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(240, 115);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 23);
            this.lblTrangThai.TabIndex = 11;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Location = new System.Drawing.Point(240, 140);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(180, 31);
            this.cboTrangThai.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 190);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "❌ Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(395, 190);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "🔄 Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvLoVeGioVang
            // 
            this.dgvLoVeGioVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoVeGioVang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoVeGioVang.Location = new System.Drawing.Point(0, 240);
            this.dgvLoVeGioVang.Name = "dgvLoVeGioVang";
            this.dgvLoVeGioVang.RowHeadersWidth = 51;
            this.dgvLoVeGioVang.Size = new System.Drawing.Size(950, 310);
            this.dgvLoVeGioVang.TabIndex = 1;
            // 
            // FormVeGioVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.dgvLoVeGioVang);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVoucherGioVang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher Giờ Vàng";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKinhPhiToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoVeGioVang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaLo;
        private System.Windows.Forms.TextBox txtMaLo;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.NumericUpDown nudGiaVe;
        private System.Windows.Forms.Label lblKinhPhiToiDa;
        private System.Windows.Forms.NumericUpDown nudKinhPhiToiDa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLoVeGioVang;
    }
}
