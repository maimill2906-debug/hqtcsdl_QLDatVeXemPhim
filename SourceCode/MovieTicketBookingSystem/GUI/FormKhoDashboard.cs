using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormKhoDashboard : Form
    {
        private Form activeChildForm = null;

        // Navigation state:
        // 0: Main Menu (Thông tin kho, Lịch sử nhập kho)
        // 1: FormKhoBapNuoc loaded
        // 2: FormNhapKho loaded
        private int currentNavigationState = 0;

        public FormKhoDashboard()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            RegisterEvents();
            this.Load += (s, e) => PositionMenuCards();
            this.Resize += (s, e) => PositionMenuCards();
            ShowNavigationState(0);
        }

        private void ApplyCinemaTheme()
        {
            // Set custom properties for dashboard elements
            pnlHeader.BackColor = CinemaTheme.White;
            pnlHeader.ForeColor = CinemaTheme.TextColor;
            btnBack.BackColor = CinemaTheme.LightBlue;
            btnBack.ForeColor = CinemaTheme.White;
            
            btnMenuThongTin.BackColor = CinemaTheme.LightBlue;
            btnMenuThongTin.ForeColor = CinemaTheme.White;
            btnMenuThongTin.FlatStyle = FlatStyle.Flat;
            btnMenuThongTin.FlatAppearance.BorderSize = 0;
            btnMenuThongTin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            btnMenuLichSu.BackColor = CinemaTheme.LightBlue;
            btnMenuLichSu.ForeColor = CinemaTheme.White;
            btnMenuLichSu.FlatStyle = FlatStyle.Flat;
            btnMenuLichSu.FlatAppearance.BorderSize = 0;
            btnMenuLichSu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private void PositionMenuCards()
        {
            int totalWidth = pnlMain.Width;
            int totalHeight = pnlMain.Height;

            int cardWidth = 180;
            int cardHeight = 110;
            int gap = 20;

            int startX = (totalWidth - (cardWidth * 2 + gap)) / 2;
            int startY = (totalHeight - cardHeight) / 2;

            if (startX < 10) startX = 10;
            if (startY < 10) startY = 10;

            btnMenuThongTin.Size = new Size(cardWidth, cardHeight);
            btnMenuLichSu.Size = new Size(cardWidth, cardHeight);

            btnMenuThongTin.Location = new Point(startX, startY);
            btnMenuLichSu.Location = new Point(startX + cardWidth + gap, startY);

            pnlMenuLevel1.Size = pnlMain.Size;
        }

        private void RegisterEvents()
        {
            btnMenuThongTin.Click += (s, e) => ShowNavigationState(1);
            btnMenuLichSu.Click += (s, e) => ShowNavigationState(2);
            btnBack.Click += (s, e) => NavigateBack();
        }

        private void ShowNavigationState(int state)
        {
            currentNavigationState = state;

            // Close active child form if returning to main menu
            if (state == 0)
            {
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm = null;
                }
            }

            switch (state)
            {
                case 0: // Main Menu
                    pnlMenuLevel1.Visible = true;
                    btnBack.Visible = false;
                    lblSubTitle.Text = "KHO BẮP NƯỚC";
                    pnlMenuLevel1.BringToFront();
                    break;
                case 1: // Inventory details
                    pnlMenuLevel1.Visible = false;
                    btnBack.Visible = true;
                    lblSubTitle.Text = "KHO BẮP NƯỚC > THÔNG TIN KHO";
                    LoadChildForm(new FormKhoBapNuoc());
                    break;
                case 2: // History grid with import & cancellation
                    pnlMenuLevel1.Visible = false;
                    btnBack.Visible = true;
                    lblSubTitle.Text = "KHO BẮP NƯỚC > LỊCH SỬ NHẬP KHO";
                    LoadChildForm(new FormNhapKho());
                    break;
            }
        }

        private void NavigateBack()
        {
            if (currentNavigationState != 0)
            {
                ShowNavigationState(0);
            }
        }

        private void LoadChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
