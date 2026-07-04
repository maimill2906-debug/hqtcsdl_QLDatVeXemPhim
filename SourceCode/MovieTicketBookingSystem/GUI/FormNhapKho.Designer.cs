namespace MovieTicketBookingSystem.GUI
{
    partial class FormNhapKho
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
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.btnHuyPhieu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLichSuNhapKho = new System.Windows.Forms.DataGridView();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnNhapKho);
            this.pnlActions.Controls.Add(this.btnHuyPhieu);
            this.pnlActions.Controls.Add(this.lblTitle);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(950, 60);
            this.pnlActions.TabIndex = 0;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapKho.Location = new System.Drawing.Point(626, 6);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(140, 35);
            this.btnNhapKho.TabIndex = 1;
            this.btnNhapKho.Text = "📥 Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyPhieu.Location = new System.Drawing.Point(788, 6);
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(150, 35);
            this.btnHuyPhieu.TabIndex = 2;
            this.btnHuyPhieu.Text = "🗑️ Hủy Phiếu ";
            this.btnHuyPhieu.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LỊCH SỬ NHẬP KHO";
            // 
            // dgvLichSuNhapKho
            // 
            this.dgvLichSuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuNhapKho.Location = new System.Drawing.Point(0, 60);
            this.dgvLichSuNhapKho.Name = "dgvLichSuNhapKho";
            this.dgvLichSuNhapKho.RowHeadersWidth = 51;
            this.dgvLichSuNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSuNhapKho.Size = new System.Drawing.Size(950, 490);
            this.dgvLichSuNhapKho.TabIndex = 1;
            // 
            // FormNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.dgvLichSuNhapKho);
            this.Controls.Add(this.pnlActions);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử Nhập Kho";
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuNhapKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnHuyPhieu;
        private System.Windows.Forms.DataGridView dgvLichSuNhapKho;
    }
}
