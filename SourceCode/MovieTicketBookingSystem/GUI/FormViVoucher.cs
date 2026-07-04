using System;
using System.Windows.Forms;
using MovieTicketBookingSystem.DTO;
using MovieTicketBookingSystem.BLL;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormViVoucher : Form
    {
        public FormViVoucher()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            pnlHeader.BackColor = CinemaTheme.DarkBlue;
            lblTitle.ForeColor = CinemaTheme.White;
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormViVoucher_Load;
        }

        private ViVoucherBLL viVoucherBLL = new ViVoucherBLL();

        private void FormViVoucher_Load(object sender, EventArgs e)
        {
            LoadVouchers();
        }

        private void LoadVouchers()
        {
            if (SessionHelper.CurrentUser != null)
            {
                dgvVouchers.DataSource = viVoucherBLL.GetVouchersByCustomer(SessionHelper.CurrentUser.TenDangNhap);
                FormatGridHeaders();
            }
            else
            {
                dgvVouchers.DataSource = null;
            }
        }

        private void FormatGridHeaders()
        {
            // Ẩn các cột khóa hệ thống
            if (dgvVouchers.Columns.Contains("MaKhachHang"))
                dgvVouchers.Columns["MaKhachHang"].Visible = false;

            // Đổi tên tiêu đề hiển thị chuẩn hóa từ View vw_ViVoucher
            if (dgvVouchers.Columns.Contains("MaVoucher"))
                dgvVouchers.Columns["MaVoucher"].HeaderText = "Mã Voucher";
            
            if (dgvVouchers.Columns.Contains("MucGiamGia"))
            {
                dgvVouchers.Columns["MucGiamGia"].HeaderText = "Mức Giảm Giá";
                dgvVouchers.Columns["MucGiamGia"].DefaultCellStyle.Format = "N0";
            }
            
            if (dgvVouchers.Columns.Contains("PhimDuocApDung"))
                dgvVouchers.Columns["PhimDuocApDung"].HeaderText = "Phim Áp Dụng";

            if (dgvVouchers.Columns.Contains("NgayChieuApDung"))
            {
                dgvVouchers.Columns["NgayChieuApDung"].HeaderText = "Ngày Chiếu";
                dgvVouchers.Columns["NgayChieuApDung"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvVouchers.Columns.Contains("GioChieuApDung"))
                dgvVouchers.Columns["GioChieuApDung"].HeaderText = "Suất Chiếu";

            if (dgvVouchers.Columns.Contains("NgaySan"))
            {
                dgvVouchers.Columns["NgaySan"].HeaderText = "Ngày Săn";
                dgvVouchers.Columns["NgaySan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            
            if (dgvVouchers.Columns.Contains("TrangThaiSuDung"))
                dgvVouchers.Columns["TrangThaiSuDung"].HeaderText = "Trạng Thái";
        }
    }
}
