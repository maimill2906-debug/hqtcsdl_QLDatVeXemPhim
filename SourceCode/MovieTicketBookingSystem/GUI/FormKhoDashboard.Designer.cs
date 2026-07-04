namespace MovieTicketBookingSystem.GUI
{
    partial class FormKhoDashboard
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenuLevel1 = new System.Windows.Forms.Panel();
            this.btnMenuLichSu = new System.Windows.Forms.Button();
            this.btnMenuThongTin = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMenuLevel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "⬅ Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Location = new System.Drawing.Point(130, 15);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(0, 25);
            this.lblSubTitle.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlMenuLevel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(880, 560);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlMenuLevel1
            // 
            this.pnlMenuLevel1.Controls.Add(this.btnMenuLichSu);
            this.pnlMenuLevel1.Controls.Add(this.btnMenuThongTin);
            this.pnlMenuLevel1.Location = new System.Drawing.Point(3, 3);
            this.pnlMenuLevel1.Name = "pnlMenuLevel1";
            this.pnlMenuLevel1.Size = new System.Drawing.Size(874, 554);
            this.pnlMenuLevel1.TabIndex = 0;
            // 
            // btnMenuLichSu
            // 
            this.btnMenuLichSu.Location = new System.Drawing.Point(320, 100);
            this.btnMenuLichSu.Name = "btnMenuLichSu";
            this.btnMenuLichSu.Size = new System.Drawing.Size(180, 120);
            this.btnMenuLichSu.TabIndex = 1;
            this.btnMenuLichSu.Text = "📋\r\nLịch Sử Nhập Kho";
            this.btnMenuLichSu.UseVisualStyleBackColor = true;
            // 
            // btnMenuThongTin
            // 
            this.btnMenuThongTin.Location = new System.Drawing.Point(100, 100);
            this.btnMenuThongTin.Name = "btnMenuThongTin";
            this.btnMenuThongTin.Size = new System.Drawing.Size(180, 120);
            this.btnMenuThongTin.TabIndex = 0;
            this.btnMenuThongTin.Text = "🍿\r\nThông Tin Kho";
            this.btnMenuThongTin.UseVisualStyleBackColor = true;
            // 
            // FormKhoDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 610);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKhoDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhoDashboard";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMenuLevel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMenuLevel1;
        private System.Windows.Forms.Button btnMenuLichSu;
        private System.Windows.Forms.Button btnMenuThongTin;
    }
}
