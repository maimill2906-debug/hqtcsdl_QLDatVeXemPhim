using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormVeCuaToi : Form
    {
        private string customerUsername;
        private DonDatVeBLL donDatVeBLL = new DonDatVeBLL();
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        public FormVeCuaToi()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
        }

        public FormVeCuaToi(string username) : this()
        {
            this.customerUsername = username;
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormVeCuaToi_Load;
            dgvVe.SelectionChanged += DgvVe_SelectionChanged;
        }

        private void FormVeCuaToi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string maKhachHang = "KH01"; // Fallback default
            string targetUsername = this.customerUsername;
            if (string.IsNullOrEmpty(targetUsername) && SessionHelper.CurrentUser != null)
            {
                targetUsername = SessionHelper.CurrentUser.TenDangNhap;
            }

            if (!string.IsNullOrEmpty(targetUsername))
            {
                KhachHangDTO kh = khachHangBLL.GetKhachHangByTenDangNhap(targetUsername);
                if (kh != null)
                {
                    maKhachHang = kh.MaKhachHang;
                }
            }

            dgvVe.DataSource = donDatVeBLL.GetBookingHistoryByKhachHang(maKhachHang);
            FormatGridHeaders();
        }

        private void FormatGridHeaders()
        {
            if (dgvVe.Columns.Contains("MaDatVe"))
                dgvVe.Columns["MaDatVe"].HeaderText = "Mã vé";
            if (dgvVe.Columns.Contains("TenPhim"))
                dgvVe.Columns["TenPhim"].HeaderText = "Tên phim";
            if (dgvVe.Columns.Contains("NgayChieu"))
            {
                dgvVe.Columns["NgayChieu"].HeaderText = "Ngày chiếu";
                dgvVe.Columns["NgayChieu"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvVe.Columns.Contains("GioChieu"))
                dgvVe.Columns["GioChieu"].HeaderText = "Giờ chiếu";
            if (dgvVe.Columns.Contains("Ghe"))
                dgvVe.Columns["Ghe"].HeaderText = "Ghế";
            if (dgvVe.Columns.Contains("TongTien"))
            {
                dgvVe.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvVe.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            }
            if (dgvVe.Columns.Contains("TrangThai"))
                dgvVe.Columns["TrangThai"].HeaderText = "Trạng thái";
            if (dgvVe.Columns.Contains("TrangThaiDonHang"))
                dgvVe.Columns["TrangThaiDonHang"].HeaderText = "Trạng thái";
            
            // Hide NgayDat/ThoiGianDat from Grid View (it can be viewed in detail)
            if (dgvVe.Columns.Contains("NgayDat"))
                dgvVe.Columns["NgayDat"].Visible = false;
            if (dgvVe.Columns.Contains("ThoiGianDat"))
                dgvVe.Columns["ThoiGianDat"].Visible = false;
        }

        private void DgvVe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVe.SelectedRows.Count > 0)
            {
                DataRowView row = (DataRowView)dgvVe.SelectedRows[0].DataBoundItem;
                if (row != null)
                {
                    lblMaDatVeVal.Text = row["MaDatVe"].ToString();
                    lblTenPhimVal.Text = row["TenPhim"].ToString();
                    
                    DateTime dateVal = Convert.ToDateTime(row["NgayChieu"]);
                    lblNgayChieuVal.Text = dateVal.ToString("dd/MM/yyyy");
                    lblGioChieuVal.Text = row["GioChieu"].ToString();
                    
                    if (row.Row.Table.Columns.Contains("Ghe"))
                    {
                        lblGheVal.Text = row["Ghe"].ToString();
                    }
                    else
                    {
                        lblGheVal.Text = "-";
                    }
                    lblTongTienVal.Text = $"{Convert.ToDecimal(row["TongTien"]):N0} VND";
                    
                    string trangThai = row.Row.Table.Columns.Contains("TrangThai") ? row["TrangThai"].ToString() : 
                                      (row.Row.Table.Columns.Contains("TrangThaiDonHang") ? row["TrangThaiDonHang"].ToString() : "Chưa xác định");
                    lblTrangThaiVal.Text = trangThai;

                    // Color status label depending on state
                    if (trangThai.Contains("Đã thanh toán") || trangThai.Contains("Đã đặt") || trangThai.Contains("Thành công"))
                        lblTrangThaiVal.ForeColor = Color.FromArgb(0, 184, 148); // Green
                    else if (trangThai.Contains("Chờ thanh toán"))
                        lblTrangThaiVal.ForeColor = Color.FromArgb(253, 203, 110); // Yellow
                    else
                        lblTrangThaiVal.ForeColor = Color.FromArgb(214, 48, 49); // Red
                }
            }
            else
            {
                ClearDetails();
            }
        }

        private void ClearDetails()
        {
            lblMaDatVeVal.Text = "-";
            lblTenPhimVal.Text = "-";
            lblNgayChieuVal.Text = "-";
            lblGioChieuVal.Text = "-";
            lblGheVal.Text = "-";
            lblTongTienVal.Text = "0 VND";
            lblTrangThaiVal.Text = "-";
            lblTrangThaiVal.ForeColor = Color.White;
        }

    }
}
