using System;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormLogin : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public FormLogin()
        {
            InitializeComponent();
            ApplyCinemaTheme();
            RegisterEvents();
        }

        private void ApplyCinemaTheme()
        {
            CinemaTheme.ApplyTheme(this);
            lblTitle.ForeColor = CinemaTheme.DarkBlue;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDangNhap.BackColor = CinemaTheme.LightBlue;
            btnThoat.BackColor = Color.FromArgb(231, 76, 60); // Red warning button
        }

        private void RegisterEvents()
        {
            btnDangNhap.Click += BtnDangNhap_Click;
            btnThoat.Click += BtnThoat_Click;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoanDTO tk = taiKhoanBLL.DangNhap(username, password);

            if (tk != null)
            {
                SessionHelper.CurrentUser = tk;
                LaunchDashboard(tk.TenDangNhap, tk.VaiTro);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LaunchDashboard(string username, string role)
        {
            this.Hide(); // Hide Login Form
            txtMatKhau.Clear(); // Clear password for security

            if (role.Equals("Khách hàng", StringComparison.OrdinalIgnoreCase))
            {
                FormMainCustomer mainCustomer = new FormMainCustomer(username);
                mainCustomer.ShowDialog(); // Open dedicated Customer dashboard as dialog
            }
            else if (role.Equals("Nhân viên", StringComparison.OrdinalIgnoreCase) || role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                FormMainAdmin mainAdmin = new FormMainAdmin(username, role);
                mainAdmin.ShowDialog(); // Open Admin Dashboard as dialog
            }
            else
            {
                // Fallback / default
                FormMainAdmin mainAdmin = new FormMainAdmin(username, role);
                mainAdmin.ShowDialog();
            }

            // Once the dashboard form closes (due to Close() on logout), show Login form again
            this.Show();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
