namespace MovieTicketBookingSystem.GUI
{
    partial class FormQuanLyPhim
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
            this.lblMaPhim = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.nudThoiLuong = new System.Windows.Forms.NumericUpDown();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblTimTheLoai = new System.Windows.Forms.Label();
            this.cboTimTheLoai = new System.Windows.Forms.ComboBox();
            this.btnTimTheoTheLoai = new System.Windows.Forms.Button();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiLuong)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Controls.Add(this.lblMaPhim);
            this.pnlInput.Controls.Add(this.txtMaPhim);
            this.pnlInput.Controls.Add(this.lblTenPhim);
            this.pnlInput.Controls.Add(this.txtTenPhim);
            this.pnlInput.Controls.Add(this.lblTheLoai);
            this.pnlInput.Controls.Add(this.cboTheLoai);
            this.pnlInput.Controls.Add(this.lblThoiLuong);
            this.pnlInput.Controls.Add(this.nudThoiLuong);
            this.pnlInput.Controls.Add(this.lblMoTa);
            this.pnlInput.Controls.Add(this.txtMoTa);
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
            this.lblTitle.Size = new System.Drawing.Size(127, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHIM";
            // 
            // lblMaPhim
            // 
            this.lblMaPhim.AutoSize = true;
            this.lblMaPhim.Location = new System.Drawing.Point(20, 50);
            this.lblMaPhim.Name = "lblMaPhim";
            this.lblMaPhim.Size = new System.Drawing.Size(82, 23);
            this.lblMaPhim.TabIndex = 1;
            this.lblMaPhim.Text = "Mã phim:";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(20, 75);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(120, 30);
            this.txtMaPhim.TabIndex = 2;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(160, 50);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(84, 23);
            this.lblTenPhim.TabIndex = 3;
            this.lblTenPhim.Text = "Tên phim:";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(160, 75);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(180, 30);
            this.txtTenPhim.TabIndex = 4;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(360, 50);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(74, 23);
            this.lblTheLoai.TabIndex = 5;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Location = new System.Drawing.Point(360, 75);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(120, 31);
            this.cboTheLoai.TabIndex = 6;
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Location = new System.Drawing.Point(500, 50);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(96, 23);
            this.lblThoiLuong.TabIndex = 7;
            this.lblThoiLuong.Text = "Thời lượng:";
            // 
            // nudThoiLuong
            // 
            this.nudThoiLuong.Location = new System.Drawing.Point(500, 75);
            this.nudThoiLuong.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudThoiLuong.Name = "nudThoiLuong";
            this.nudThoiLuong.Size = new System.Drawing.Size(90, 30);
            this.nudThoiLuong.TabIndex = 8;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(20, 115);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(59, 23);
            this.lblMoTa.TabIndex = 9;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(20, 140);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(570, 40);
            this.txtMoTa.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "❌ Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(395, 195);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "🔄 Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.lblTimTheLoai);
            this.pnlSearch.Controls.Add(this.cboTimTheLoai);
            this.pnlSearch.Controls.Add(this.btnTimTheoTheLoai);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 240);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(950, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblTimTheLoai
            // 
            this.lblTimTheLoai.AutoSize = true;
            this.lblTimTheLoai.Location = new System.Drawing.Point(20, 18);
            this.lblTimTheLoai.Name = "lblTimTheLoai";
            this.lblTimTheLoai.Size = new System.Drawing.Size(142, 23);
            this.lblTimTheLoai.TabIndex = 0;
            this.lblTimTheLoai.Text = "Lọc theo thể loại:";
            // 
            // cboTimTheLoai
            // 
            this.cboTimTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimTheLoai.Location = new System.Drawing.Point(170, 15);
            this.cboTimTheLoai.Name = "cboTimTheLoai";
            this.cboTimTheLoai.Size = new System.Drawing.Size(200, 31);
            this.cboTimTheLoai.TabIndex = 1;
            // 
            // btnTimTheoTheLoai
            // 
            this.btnTimTheoTheLoai.Location = new System.Drawing.Point(390, 13);
            this.btnTimTheoTheLoai.Name = "btnTimTheoTheLoai";
            this.btnTimTheoTheLoai.Size = new System.Drawing.Size(120, 35);
            this.btnTimTheoTheLoai.TabIndex = 2;
            this.btnTimTheoTheLoai.Text = "🔍 Tìm Kiếm";
            this.btnTimTheoTheLoai.UseVisualStyleBackColor = true;
            // 
            // dgvPhim
            // 
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhim.Location = new System.Drawing.Point(0, 300);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.Size = new System.Drawing.Size(950, 250);
            this.dgvPhim.TabIndex = 2;
            // 
            // FormQuanLyPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.dgvPhim);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phim";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiLuong)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.NumericUpDown nudThoiLuong;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblTimTheLoai;
        private System.Windows.Forms.ComboBox cboTimTheLoai;
        private System.Windows.Forms.Button btnTimTheoTheLoai;
        private System.Windows.Forms.DataGridView dgvPhim;
    }
}
