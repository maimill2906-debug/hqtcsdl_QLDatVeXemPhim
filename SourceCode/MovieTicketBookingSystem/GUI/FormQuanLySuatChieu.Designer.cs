namespace MovieTicketBookingSystem.GUI
{
    partial class FormQuanLySuatChieu
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
            this.lblMaSuatChieu = new System.Windows.Forms.Label();
            this.txtMaSuatChieu = new System.Windows.Forms.TextBox();
            this.lblPhim = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblRap = new System.Windows.Forms.Label();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.lblPhongChieu = new System.Windows.Forms.Label();
            this.cboPhongChieu = new System.Windows.Forms.ComboBox();
            this.lblNgayChieu = new System.Windows.Forms.Label();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblGioKetThuc = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Controls.Add(this.lblMaSuatChieu);
            this.pnlInput.Controls.Add(this.txtMaSuatChieu);
            this.pnlInput.Controls.Add(this.lblPhim);
            this.pnlInput.Controls.Add(this.cboPhim);
            this.pnlInput.Controls.Add(this.lblRap);
            this.pnlInput.Controls.Add(this.cboRap);
            this.pnlInput.Controls.Add(this.lblPhongChieu);
            this.pnlInput.Controls.Add(this.cboPhongChieu);
            this.pnlInput.Controls.Add(this.lblNgayChieu);
            this.pnlInput.Controls.Add(this.dtpNgayChieu);
            this.pnlInput.Controls.Add(this.lblGioBatDau);
            this.pnlInput.Controls.Add(this.dtpGioBatDau);
            this.pnlInput.Controls.Add(this.lblGioKetThuc);
            this.pnlInput.Controls.Add(this.dtpGioKetThuc);
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
            this.lblTitle.Size = new System.Drawing.Size(180, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SUẤT CHIẾU";
            // 
            // lblMaSuatChieu
            // 
            this.lblMaSuatChieu.AutoSize = true;
            this.lblMaSuatChieu.Location = new System.Drawing.Point(20, 50);
            this.lblMaSuatChieu.Name = "lblMaSuatChieu";
            this.lblMaSuatChieu.Size = new System.Drawing.Size(121, 23);
            this.lblMaSuatChieu.TabIndex = 1;
            this.lblMaSuatChieu.Text = "Mã suất chiếu:";
            // 
            // txtMaSuatChieu
            // 
            this.txtMaSuatChieu.Location = new System.Drawing.Point(20, 75);
            this.txtMaSuatChieu.Name = "txtMaSuatChieu";
            this.txtMaSuatChieu.Size = new System.Drawing.Size(120, 30);
            this.txtMaSuatChieu.TabIndex = 2;
            // 
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(340, 50);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(53, 23);
            this.lblPhim.TabIndex = 3;
            this.lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.Location = new System.Drawing.Point(340, 75);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(130, 31);
            this.cboPhim.TabIndex = 4;
            // 
            // lblRap
            // 
            this.lblRap.AutoSize = true;
            this.lblRap.Location = new System.Drawing.Point(155, 50);
            this.lblRap.Name = "lblRap";
            this.lblRap.Size = new System.Drawing.Size(43, 23);
            this.lblRap.TabIndex = 19;
            this.lblRap.Text = "Rạp:";
            // 
            // cboRap
            // 
            this.cboRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRap.Location = new System.Drawing.Point(155, 75);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(170, 31);
            this.cboRap.TabIndex = 20;
            // 
            // lblPhongChieu
            // 
            this.lblPhongChieu.AutoSize = true;
            this.lblPhongChieu.Location = new System.Drawing.Point(340, 115);
            this.lblPhongChieu.Name = "lblPhongChieu";
            this.lblPhongChieu.Size = new System.Drawing.Size(110, 23);
            this.lblPhongChieu.TabIndex = 5;
            this.lblPhongChieu.Text = "Phòng chiếu:";
            // 
            // cboPhongChieu
            // 
            this.cboPhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongChieu.Location = new System.Drawing.Point(340, 140);
            this.cboPhongChieu.Name = "cboPhongChieu";
            this.cboPhongChieu.Size = new System.Drawing.Size(130, 31);
            this.cboPhongChieu.TabIndex = 6;
            // 
            // lblNgayChieu
            // 
            this.lblNgayChieu.AutoSize = true;
            this.lblNgayChieu.Location = new System.Drawing.Point(485, 50);
            this.lblNgayChieu.Name = "lblNgayChieu";
            this.lblNgayChieu.Size = new System.Drawing.Size(100, 23);
            this.lblNgayChieu.TabIndex = 7;
            this.lblNgayChieu.Text = "Ngày chiếu:";
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(485, 75);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(120, 30);
            this.dtpNgayChieu.TabIndex = 8;
            // 
            // lblGioBatDau
            // 
            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.Location = new System.Drawing.Point(20, 115);
            this.lblGioBatDau.Name = "lblGioBatDau";
            this.lblGioBatDau.Size = new System.Drawing.Size(104, 23);
            this.lblGioBatDau.TabIndex = 9;
            this.lblGioBatDau.Text = "Giờ bắt đầu:";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(20, 140);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(120, 30);
            this.dtpGioBatDau.TabIndex = 10;
            // 
            // lblGioKetThuc
            // 
            this.lblGioKetThuc.AutoSize = true;
            this.lblGioKetThuc.Location = new System.Drawing.Point(155, 115);
            this.lblGioKetThuc.Name = "lblGioKetThuc";
            this.lblGioKetThuc.Size = new System.Drawing.Size(107, 23);
            this.lblGioKetThuc.TabIndex = 11;
            this.lblGioKetThuc.Text = "Giờ kết thúc:";
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(155, 140);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(170, 30);
            this.dtpGioKetThuc.TabIndex = 12;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(485, 115);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 23);
            this.lblTrangThai.TabIndex = 13;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Location = new System.Drawing.Point(485, 140);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(120, 31);
            this.cboTrangThai.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 190);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 190);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "❌ Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(395, 190);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(150, 35);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "🔄 Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvSuatChieu
            // 
            this.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuatChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuatChieu.Location = new System.Drawing.Point(0, 240);
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.RowHeadersWidth = 51;
            this.dgvSuatChieu.Size = new System.Drawing.Size(950, 310);
            this.dgvSuatChieu.TabIndex = 1;
            // 
            // FormQuanLySuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.dgvSuatChieu);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLySuatChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Suất Chiếu";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSuatChieu;
        private System.Windows.Forms.TextBox txtMaSuatChieu;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblPhongChieu;
        private System.Windows.Forms.ComboBox cboPhongChieu;
        private System.Windows.Forms.Label lblNgayChieu;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.Label lblRap;
        private System.Windows.Forms.ComboBox cboRap;
    }
}
