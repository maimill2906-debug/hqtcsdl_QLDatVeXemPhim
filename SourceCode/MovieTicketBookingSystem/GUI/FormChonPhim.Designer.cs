namespace MovieTicketBookingSystem.GUI
{
    partial class FormChonPhim
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFilterTheLoai = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnChonPhim = new System.Windows.Forms.Button();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblTenPhimVal = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblThoiLuongVal = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblMoTaVal = new System.Windows.Forms.Label();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblTitle);
            this.pnlFilter.Controls.Add(this.lblFilterTheLoai);
            this.pnlFilter.Controls.Add(this.cboTheLoai);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(850, 60);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH PHIM ĐANG CHIẾU";
            // 
            // lblFilterTheLoai
            // 
            this.lblFilterTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterTheLoai.AutoSize = true;
            this.lblFilterTheLoai.Location = new System.Drawing.Point(520, 21);
            this.lblFilterTheLoai.Name = "lblFilterTheLoai";
            this.lblFilterTheLoai.Size = new System.Drawing.Size(142, 23);
            this.lblFilterTheLoai.TabIndex = 1;
            this.lblFilterTheLoai.Text = "Lọc theo thể loại:";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Location = new System.Drawing.Point(650, 17);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(180, 31);
            this.cboTheLoai.TabIndex = 2;
            // 
            // dgvPhim
            // 
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhim.Location = new System.Drawing.Point(0, 60);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.RowHeadersWidth = 51;
            this.dgvPhim.Size = new System.Drawing.Size(850, 260);
            this.dgvPhim.TabIndex = 1;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.btnChonPhim);
            this.pnlDetails.Controls.Add(this.picPoster);
            this.pnlDetails.Controls.Add(this.lblTenPhim);
            this.pnlDetails.Controls.Add(this.lblTenPhimVal);
            this.pnlDetails.Controls.Add(this.lblThoiLuong);
            this.pnlDetails.Controls.Add(this.lblThoiLuongVal);
            this.pnlDetails.Controls.Add(this.lblMoTa);
            this.pnlDetails.Controls.Add(this.lblMoTaVal);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetails.Location = new System.Drawing.Point(0, 320);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(850, 180);
            this.pnlDetails.TabIndex = 2;
            // 
            // btnChonPhim
            // 
            this.btnChonPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonPhim.Location = new System.Drawing.Point(683, 122);
            this.btnChonPhim.Name = "btnChonPhim";
            this.btnChonPhim.Size = new System.Drawing.Size(147, 43);
            this.btnChonPhim.TabIndex = 8;
            this.btnChonPhim.Text = "Tiếp tục đặt vé ";
            this.btnChonPhim.UseVisualStyleBackColor = true;
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(20, 15);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(110, 150);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(150, 15);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(84, 23);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên phim:";
            // 
            // lblTenPhimVal
            // 
            this.lblTenPhimVal.AutoSize = true;
            this.lblTenPhimVal.Location = new System.Drawing.Point(240, 15);
            this.lblTenPhimVal.Name = "lblTenPhimVal";
            this.lblTenPhimVal.Size = new System.Drawing.Size(137, 23);
            this.lblTenPhimVal.TabIndex = 2;
            this.lblTenPhimVal.Text = "Chưa chọn phim";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Location = new System.Drawing.Point(150, 45);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(96, 23);
            this.lblThoiLuong.TabIndex = 3;
            this.lblThoiLuong.Text = "Thời lượng:";
            // 
            // lblThoiLuongVal
            // 
            this.lblThoiLuongVal.AutoSize = true;
            this.lblThoiLuongVal.Location = new System.Drawing.Point(240, 45);
            this.lblThoiLuongVal.Name = "lblThoiLuongVal";
            this.lblThoiLuongVal.Size = new System.Drawing.Size(60, 23);
            this.lblThoiLuongVal.TabIndex = 4;
            this.lblThoiLuongVal.Text = "0 phút";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(150, 75);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(59, 23);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblMoTaVal
            // 
            this.lblMoTaVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoTaVal.Location = new System.Drawing.Point(240, 75);
            this.lblMoTaVal.Name = "lblMoTaVal";
            this.lblMoTaVal.Size = new System.Drawing.Size(420, 90);
            this.lblMoTaVal.TabIndex = 6;
            this.lblMoTaVal.Text = "(Chọn một phim ở bảng trên để xem mô tả chi tiết)";
            // 
            // FormChonPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.dgvPhim);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Phim";
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilterTheLoai;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblTenPhimVal;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblThoiLuongVal;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMoTaVal;
        private System.Windows.Forms.Button btnChonPhim;
    }
}
