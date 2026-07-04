using System;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormMainCustomer : Form
    {
        private Form activeForm = null;
        private string currentCustomer = "khachhang";

        public FormMainCustomer() : this("khachhang")
        {
        }

        public FormMainCustomer(string username)
        {
            InitializeComponent();
            this.currentCustomer = username;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += FormMainCustomer_Load;
            ApplyCinemaTheme();
            RegisterEvents();
        }

        private void FormMainCustomer_Load(object sender, EventArgs e)
        {
            int screenW = Screen.PrimaryScreen.WorkingArea.Width;
            int screenH = Screen.PrimaryScreen.WorkingArea.Height;
            int targetW = screenW / 2;
            int targetH = Math.Min(650, screenH - 40);
            this.Size = new Size(targetW, targetH);
            this.CenterToScreen();
            
            // Tải form chọn phim sau khi giao diện chính đã hiển thị để đăng nhập mượt mà, không bị trễ
            LoadMovieSelectionForm();
        }

        private void ApplyCinemaTheme()
        {
            this.BackColor = CinemaTheme.White;
            this.ForeColor = CinemaTheme.TextColor;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Sidebar Panel
            pnlSidebar.BackColor = CinemaTheme.LightGray;
            pnlSidebar.ForeColor = CinemaTheme.TextColor;
            lblLogo.ForeColor = CinemaTheme.DarkBlue;
            StyleNavButton(btnMuaVe);
            StyleNavButton(btnSanVeGioVang);
            StyleNavButton(btnViVoucher);
            StyleNavButton(btnVeCuaToi);

            // Header Panel
            pnlHeader.BackColor = CinemaTheme.White;
            pnlHeader.ForeColor = CinemaTheme.TextColor;
            lblTieuDe.ForeColor = CinemaTheme.DarkBlue;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTaiKhoan.ForeColor = CinemaTheme.TextColor;

            // Logout Button
            btnDangXuat.BackColor = CinemaTheme.LightGray;
            btnDangXuat.ForeColor = CinemaTheme.TextColor;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            // Set account info text
            lblTaiKhoan.Text = "Khách hàng: " + currentCustomer;
        }

        private void StyleNavButton(Button btn)
        {
            btn.BackColor = CinemaTheme.LightGray;
            btn.ForeColor = CinemaTheme.TextColor;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);
        }

        private void RegisterEvents()
        {
            btnMuaVe.Click += (s, e) => LoadMovieSelectionForm();
            btnSanVeGioVang.Click += (s, e) => LoadGoldenHourHuntingForm();
            btnViVoucher.Click += (s, e) => LoadViVoucherForm();
            btnVeCuaToi.Click += (s, e) => LoadMyTicketsForm();
        }

        public void LoadViVoucherForm()
        {
            FormViVoucher viVoucherForm = new FormViVoucher();
            OpenChildForm(viVoucherForm, "VÍ VOUCHER CỦA TÔI");
        }

        public void LoadMyTicketsForm()
        {
            FormVeCuaToi myTicketsForm = new FormVeCuaToi(currentCustomer);
            OpenChildForm(myTicketsForm, "VÉ CỦA TÔI");
        }

        public void LoadMovieSelectionForm()
        {
            FormChonPhim chonPhimForm = new FormChonPhim(maPhim => {
                PhimBLL phimBLL = new PhimBLL();
                var phim = phimBLL.GetById(maPhim);
                string tenPhim = phim != null ? phim.TenPhim : maPhim;
                
                // Chuyển tiếp sang Bước 2: Chọn suất chiếu
                FormChonSuatChieu chonSuatChieuForm = new FormChonSuatChieu(maPhim, (maSuatChieu, maPhong) => {
                    // Chuyển tiếp sang Bước 3: Đặt vé chọn ghế rộng rãi
                    FormDatVe datVeForm = new FormDatVe(maSuatChieu, maPhong);
                    OpenChildForm(datVeForm, "ĐẶT VÉ: " + tenPhim.ToUpper());
                });
                OpenChildForm(chonSuatChieuForm, "CHỌN SUẤT CHIẾU: " + tenPhim.ToUpper());
            });
            OpenChildForm(chonPhimForm, "CHỌN PHIM");
        }

        public void LoadGoldenHourHuntingForm()
        {
            FormSanVoucherGioVang sanVeForm = new FormSanVoucherGioVang();
            OpenChildForm(sanVeForm, "SĂN VOUCHER GIỜ VÀNG");
        }

        private void OpenChildForm(Form childForm, string title)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTieuDe.Text = title;
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to Login
        }
    }
}
