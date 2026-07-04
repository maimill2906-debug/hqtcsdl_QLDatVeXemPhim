namespace MovieTicketBookingSystem.GUI
{
    partial class FormNhapKhoDialog
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMaKho = new System.Windows.Forms.Label();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNhaCungCap = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.lblSoLuongNhap = new System.Windows.Forms.Label();
            this.nudSoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblRap = new System.Windows.Forms.Label();
            this.cboRap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP PHIẾU NHẬP KHO";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location = new System.Drawing.Point(30, 75);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(86, 23);
            this.lblMaPhieu.TabIndex = 1;
            this.lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(160, 72);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(240, 30);
            this.txtMaPhieu.TabIndex = 2;
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Location = new System.Drawing.Point(30, 125);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(91, 23);
            this.lblMaKho.TabIndex = 3;
            this.lblMaKho.Text = "Mặt hàng:";
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.Location = new System.Drawing.Point(160, 122);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(240, 31);
            this.cboKho.TabIndex = 4;
            // 
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(30, 175);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(43, 23);
            this.lblRap.TabIndex = 13;
            this.lblRap.Text = "Rạp:";
            // 
            // cboRap
            // 
            this.cboRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRap.Location = new System.Drawing.Point(160, 172);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(240, 31);
            this.cboRap.TabIndex = 14;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(30, 225);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(118, 23);
            this.lblMaNhanVien.TabIndex = 5;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(160, 222);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(240, 30);
            this.txtMaNhanVien.TabIndex = 6;
            // 
            // lblMaNhaCungCap
            // 
            this.lblMaNhaCungCap.AutoSize = true;
            this.lblMaNhaCungCap.Location = new System.Drawing.Point(30, 275);
            this.lblMaNhaCungCap.Name = "lblMaNhaCungCap";
            this.lblMaNhaCungCap.Size = new System.Drawing.Size(121, 23);
            this.lblMaNhaCungCap.TabIndex = 7;
            this.lblMaNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.Location = new System.Drawing.Point(160, 272);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(240, 31);
            this.cboNhaCungCap.TabIndex = 8;
            // 
            // lblSoLuongNhap
            // 
            this.lblSoLuongNhap.AutoSize = true;
            this.lblSoLuongNhap.Location = new System.Drawing.Point(30, 325);
            this.lblSoLuongNhap.Name = "lblSoLuongNhap";
            this.lblSoLuongNhap.Size = new System.Drawing.Size(126, 23);
            this.lblSoLuongNhap.TabIndex = 9;
            this.lblSoLuongNhap.Text = "Số lượng nhập:";
            // 
            // nudSoLuongNhap
            // 
            this.nudSoLuongNhap.Location = new System.Drawing.Point(160, 322);
            this.nudSoLuongNhap.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSoLuongNhap.Name = "nudSoLuongNhap";
            this.nudSoLuongNhap.Size = new System.Drawing.Size(240, 30);
            this.nudSoLuongNhap.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(160, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(140, 35);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "💾 Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(310, 380);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "❌ Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // 
            // FormNhapKhoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 445);
            this.Controls.Add(this.cboRap);
            this.Controls.Add(this.lblRap);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.nudSoLuongNhap);
            this.Controls.Add(this.lblSoLuongNhap);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.lblMaNhaCungCap);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.cboKho);
            this.Controls.Add(this.lblMaKho);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhapKhoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Nhập Kho";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblMaKho;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label lblSoLuongNhap;
        private System.Windows.Forms.NumericUpDown nudSoLuongNhap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblRap;
        private System.Windows.Forms.ComboBox cboRap;
    }
}
