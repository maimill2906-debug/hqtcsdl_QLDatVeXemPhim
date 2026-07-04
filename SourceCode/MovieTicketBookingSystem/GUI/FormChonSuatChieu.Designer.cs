namespace MovieTicketBookingSystem.GUI
{
    partial class FormChonSuatChieu
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
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblTenPhimVal = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblThoiLuongVal = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblMoTaVal = new System.Windows.Forms.Label();
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(20, 50);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(110, 150);
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenPhim.Location = new System.Drawing.Point(150, 50);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(89, 23);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên Phim:";
            // 
            // lblTenPhimVal
            // 
            this.lblTenPhimVal.AutoSize = true;
            this.lblTenPhimVal.Location = new System.Drawing.Point(250, 50);
            this.lblTenPhimVal.Name = "lblTenPhimVal";
            this.lblTenPhimVal.Size = new System.Drawing.Size(80, 23);
            this.lblTenPhimVal.TabIndex = 2;
            this.lblTenPhimVal.Text = "Ten Phim";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThoiLuong.Location = new System.Drawing.Point(150, 80);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(106, 23);
            this.lblThoiLuong.TabIndex = 3;
            this.lblThoiLuong.Text = "Thời Lượng:";
            // 
            // lblThoiLuongVal
            // 
            this.lblThoiLuongVal.AutoSize = true;
            this.lblThoiLuongVal.Location = new System.Drawing.Point(250, 80);
            this.lblThoiLuongVal.Name = "lblThoiLuongVal";
            this.lblThoiLuongVal.Size = new System.Drawing.Size(60, 23);
            this.lblThoiLuongVal.TabIndex = 4;
            this.lblThoiLuongVal.Text = "0 phút";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(150, 110);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(64, 23);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô Tả:";
            // 
            // lblMoTaVal
            // 
            this.lblMoTaVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoTaVal.Location = new System.Drawing.Point(250, 110);
            this.lblMoTaVal.Name = "lblMoTaVal";
            this.lblMoTaVal.Size = new System.Drawing.Size(570, 90);
            this.lblMoTaVal.TabIndex = 6;
            this.lblMoTaVal.Text = "Mo ta chi tiet ve bo phim...";
            // 
            // dgvSuatChieu
            // 
            this.dgvSuatChieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuatChieu.Location = new System.Drawing.Point(20, 215);
            this.dgvSuatChieu.MultiSelect = false;
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.RowHeadersWidth = 51;
            this.dgvSuatChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuatChieu.Size = new System.Drawing.Size(800, 215);
            this.dgvSuatChieu.TabIndex = 7;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiepTuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.Location = new System.Drawing.Point(623, 445);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(197, 43);
            this.btnTiepTuc.TabIndex = 8;
            this.btnTiepTuc.Text = "Tiếp tục chọn ghế";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 28);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "CHỌN SUẤT CHIẾU PHIM";
            // 
            // FormChonSuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.dgvSuatChieu);
            this.Controls.Add(this.lblMoTaVal);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblThoiLuongVal);
            this.Controls.Add(this.lblThoiLuong);
            this.Controls.Add(this.lblTenPhimVal);
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.picPoster);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonSuatChieu";
            this.Text = "Chọn Suất Chiếu";
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblTenPhimVal;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblThoiLuongVal;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMoTaVal;
        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Label lblTitle;
    }
}
