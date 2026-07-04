namespace MovieTicketBookingSystem.GUI
{
    partial class FormKhoBapNuoc
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
            this.lblMaKho = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.lblRap = new System.Windows.Forms.Label();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblSoLuongHienCo = new System.Windows.Forms.Label();
            this.nudSoLuongHienCo = new System.Windows.Forms.NumericUpDown();
            this.lblSucChuaToiDa = new System.Windows.Forms.Label();
            this.nudSucChuaToiDa = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvKhoBapNuoc = new System.Windows.Forms.DataGridView();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongHienCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChuaToiDa)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoBapNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Controls.Add(this.lblMaKho);
            this.pnlInput.Controls.Add(this.txtMaKho);
            this.pnlInput.Controls.Add(this.lblRap);
            this.pnlInput.Controls.Add(this.cboRap);
            this.pnlInput.Controls.Add(this.lblTenSanPham);
            this.pnlInput.Controls.Add(this.txtTenSanPham);
            this.pnlInput.Controls.Add(this.lblSoLuongHienCo);
            this.pnlInput.Controls.Add(this.nudSoLuongHienCo);
            this.pnlInput.Controls.Add(this.lblSucChuaToiDa);
            this.pnlInput.Controls.Add(this.nudSucChuaToiDa);
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
            this.lblTitle.Size = new System.Drawing.Size(210, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ KHO BẮP NƯỚC";
            // 
            // lblMaKho
            // 
            this.lblMaKho.AutoSize = true;
            this.lblMaKho.Location = new System.Drawing.Point(20, 50);
            this.lblMaKho.Name = "lblMaKho";
            this.lblMaKho.Size = new System.Drawing.Size(71, 23);
            this.lblMaKho.TabIndex = 1;
            this.lblMaKho.Text = "Mã mặt hàng:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(20, 75);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(120, 30);
            this.txtMaKho.TabIndex = 2;
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(160, 50);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(43, 23);
            this.lblRap.TabIndex = 3;
            this.lblRap.Text = "Rạp:";
            // 
            // cboRap
            // 
            this.cboRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRap.Location = new System.Drawing.Point(160, 75);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(160, 31);
            this.cboRap.TabIndex = 4;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(340, 50);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(120, 23);
            this.lblTenSanPham.TabIndex = 5;
            this.lblTenSanPham.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(340, 75);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(220, 30);
            this.txtTenSanPham.TabIndex = 6;
            // 
            // lblSoLuongHienCo
            // 
            this.lblSoLuongHienCo.AutoSize = true;
            this.lblSoLuongHienCo.Location = new System.Drawing.Point(20, 115);
            this.lblSoLuongHienCo.Name = "lblSoLuongHienCo";
            this.lblSoLuongHienCo.Size = new System.Drawing.Size(143, 23);
            this.lblSoLuongHienCo.TabIndex = 7;
            this.lblSoLuongHienCo.Text = "Số lượng hiện có:";
            // 
            // nudSoLuongHienCo
            // 
            this.nudSoLuongHienCo.Location = new System.Drawing.Point(20, 140);
            this.nudSoLuongHienCo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuongHienCo.Name = "nudSoLuongHienCo";
            this.nudSoLuongHienCo.Size = new System.Drawing.Size(140, 30);
            this.nudSoLuongHienCo.TabIndex = 8;
            // 
            // lblSucChuaToiDa
            // 
            this.lblSucChuaToiDa.AutoSize = true;
            this.lblSucChuaToiDa.Location = new System.Drawing.Point(180, 115);
            this.lblSucChuaToiDa.Name = "lblSucChuaToiDa";
            this.lblSucChuaToiDa.Size = new System.Drawing.Size(132, 23);
            this.lblSucChuaToiDa.TabIndex = 9;
            this.lblSucChuaToiDa.Text = "Sức chứa tối đa:";
            // 
            // nudSucChuaToiDa
            // 
            this.nudSucChuaToiDa.Location = new System.Drawing.Point(180, 140);
            this.nudSucChuaToiDa.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSucChuaToiDa.Name = "nudSucChuaToiDa";
            this.nudSucChuaToiDa.Size = new System.Drawing.Size(140, 30);
            this.nudSucChuaToiDa.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "❌ Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(395, 185);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "🔄 Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.lblTimKiem);
            this.pnlSearch.Controls.Add(this.txtTimKiem);
            this.pnlSearch.Controls.Add(this.btnTimKiem);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 240);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(950, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 18);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(163, 23);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm sản phẩm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(180, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 30);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(450, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 35);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍 Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvKhoBapNuoc
            // 
            this.dgvKhoBapNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoBapNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoBapNuoc.Location = new System.Drawing.Point(0, 300);
            this.dgvKhoBapNuoc.Name = "dgvKhoBapNuoc";
            this.dgvKhoBapNuoc.RowHeadersWidth = 51;
            this.dgvKhoBapNuoc.Size = new System.Drawing.Size(950, 250);
            this.dgvKhoBapNuoc.TabIndex = 2;
            // 
            // FormKhoBapNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.dgvKhoBapNuoc);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhoBapNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Bắp Nước";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongHienCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChuaToiDa)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoBapNuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaKho;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.Label lblRap;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblSoLuongHienCo;
        private System.Windows.Forms.NumericUpDown nudSoLuongHienCo;
        private System.Windows.Forms.Label lblSucChuaToiDa;
        private System.Windows.Forms.NumericUpDown nudSucChuaToiDa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvKhoBapNuoc;
    }
}
