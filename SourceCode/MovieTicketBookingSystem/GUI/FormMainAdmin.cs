using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormMainAdmin : Form
    {
        private Form activeForm = null;
        private string currentUser = "admin";
        private string currentRole = "Admin";

        // Parameterless constructor for VS Designer compatibility
        public FormMainAdmin() : this("admin", "Admin")
        {
        }

        public FormMainAdmin(string username, string role)
        {
            InitializeComponent();
            this.currentUser = username;
            this.currentRole = role;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += FormMainAdmin_Load;
            ApplyCinemaTheme();
            RegisterNavigationEvents();
            ConfigureAccessByRole();
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            int screenW = Screen.PrimaryScreen.WorkingArea.Width;
            int screenH = Screen.PrimaryScreen.WorkingArea.Height;
            int targetW = screenW / 2;
            int targetH = Math.Min(650, screenH - 40);
            this.Size = new Size(targetW, targetH);
            this.CenterToScreen();

            // Load FormQuanLyPhim ngay lập tức khi đăng nhập vào Admin
            OpenChildForm(new FormQuanLyPhim(), "QUẢN LÝ PHIM");
        }

        private void ApplyCinemaTheme()
        {
            this.BackColor = CinemaTheme.White;
            this.ForeColor = CinemaTheme.TextColor;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Left Sidebar Styling
            pnlSidebar.BackColor = CinemaTheme.LightGray;
            pnlSidebar.ForeColor = CinemaTheme.TextColor;
            lblLogo.ForeColor = CinemaTheme.DarkBlue;

            // Header Styling
            pnlHeader.BackColor = CinemaTheme.White;
            pnlHeader.ForeColor = CinemaTheme.TextColor;
            lblTieuDe.ForeColor = CinemaTheme.DarkBlue;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTaiKhoanDangNhap.ForeColor = CinemaTheme.TextColor;

            // Navigation Buttons Styling
            StyleNavButton(btnTheLoai);
            StyleNavButton(btnPhim);
            StyleNavButton(btnSuatChieu);
            StyleNavButton(btnVeGioVang);
            StyleNavButton(btnKhoBapNuoc);
            
            // Hide sub action buttons from sidebar as they are moved inside FormKhoDashboard
            btnNhapKho.Visible = false;
            btnHuyNhapKho.Visible = false;
            
            // Logout button styling
            btnDangXuat.BackColor = CinemaTheme.LightGray;
            btnDangXuat.ForeColor = CinemaTheme.TextColor;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnDangXuat.Cursor = Cursors.Hand;

            // Dashboard Cards styling
            StyleCard(pnlCardPhim, lblCardPhimTitle, lblCardPhimVal, CinemaTheme.DarkBlue);
            StyleCard(pnlCardSuatChieu, lblCardSuatChieuTitle, lblCardSuatChieuVal, CinemaTheme.LightBlue);
            StyleCard(pnlCardDonVe, lblCardDonVeTitle, lblCardDonVeVal, CinemaTheme.DarkBlue);
            StyleCard(pnlCardGioVang, lblCardGioVangTitle, lblCardGioVangVal, CinemaTheme.LightBlue);
        }

        private void StyleNavButton(Button btn)
        {
            btn.BackColor = CinemaTheme.LightGray;
            btn.ForeColor = CinemaTheme.TextColor;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);
        }

        private void StyleCard(Panel pnl, Label title, Label val, Color accentColor)
        {
            pnl.BackColor = CinemaTheme.White;
            pnl.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(accentColor, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
                }
            };

            title.ForeColor = CinemaTheme.TextColor;
            title.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            val.ForeColor = CinemaTheme.DarkBlue;
            val.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        }

        private void RegisterNavigationEvents()
        {
            btnTheLoai.Click += (s, e) => OpenChildForm(new FormQuanLyTheLoai(), "QUẢN LÝ THỂ LOẠI");
            btnPhim.Click += (s, e) => OpenChildForm(new FormQuanLyPhim(), "QUẢN LÝ PHIM");
            btnSuatChieu.Click += (s, e) => OpenChildForm(new FormQuanLySuatChieu(), "QUẢN LÝ SUẤT CHIẾU");
            btnVeGioVang.Click += (s, e) => OpenChildForm(new FormVoucherGioVang(), "QUẢN LÝ VOUCHER GIỜ VÀNG");
            btnKhoBapNuoc.Click += (s, e) => OpenChildForm(new FormKhoDashboard(), "KHO BẮP NƯỚC");
            btnDangXuat.Click += BtnDangXuat_Click;
        }

        private void ConfigureAccessByRole()
        {
            // Set Header account name
            lblTaiKhoanDangNhap.Text = "Quản trị viên: " + currentUser;

            // Ensure all admin parent buttons are visible
            btnTheLoai.Visible = true;
            btnPhim.Visible = true;
            btnSuatChieu.Visible = true;
            btnVeGioVang.Visible = true;
            btnKhoBapNuoc.Visible = true;
            
            // Hide import & cancel buttons from the sidebar
            btnNhapKho.Visible = false;
            btnHuyNhapKho.Visible = false;
        }

        private void OpenChildForm(Form childForm, string title)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Close previously opened child form
            }

            activeForm = childForm;
            childForm.TopLevel = false; // Set TopLevel to false so it acts as a control
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTieuDe.Text = title; // Update page title in Header
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Dashboard to return to Login Form
        }
    }
}
