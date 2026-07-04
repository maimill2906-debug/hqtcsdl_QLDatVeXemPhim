using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;
using MovieTicketBookingSystem.DAL;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormSanVoucherGioVang : Form
    {
        private LoVoucherGioVangBLL loVoucherGioVangBLL = new LoVoucherGioVangBLL();
        private Action<string, string, decimal> onCampaignSelected; // Callback when user claims a ticket
        private decimal currentPromoPrice = 0;

        private Timer autoRefreshTimer;

        public FormSanVoucherGioVang()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            pnlBanner.BackColor = CinemaTheme.DarkBlue;
            pnlBanner.ForeColor = CinemaTheme.White;
            btnSanVe.BackColor = CinemaTheme.LightBlue;
            btnSanVe.ForeColor = CinemaTheme.White;
            lblGiaVeVal.ForeColor = CinemaTheme.DarkBlue;
            RegisterEvents();
            
            // Khởi tạo timer làm mới danh sách tự động mỗi 1 giây
            autoRefreshTimer = new Timer();
            autoRefreshTimer.Interval = 1000; // 1 giây
            autoRefreshTimer.Tick += async (s, ev) => {
                if (btnSanVe.Text != "Đang xử lý...")
                {
                    string selectedMaLo = lblMaLoVal.Text;
                    DataTable dt = null;
                    await System.Threading.Tasks.Task.Run(() =>
                    {
                        try
                        {
                            dt = loVoucherGioVangBLL.GetActiveCampaigns();
                        }
                        catch { }
                    });
                    if (dt != null)
                    {
                        dgvGioVang.DataSource = dt;
                        FormatGridHeaders();
                        if (selectedMaLo != "Chưa chọn voucher" && dgvGioVang.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow r in dgvGioVang.Rows)
                            {
                                if (r.Cells["MaLo"].Value != null && r.Cells["MaLo"].Value.ToString() == selectedMaLo)
                                {
                                    r.Selected = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            };
        }

        public FormSanVoucherGioVang(Action<string, string, decimal> onCampaignSelected) : this()
        {
            this.onCampaignSelected = onCampaignSelected;
        }

        private void RegisterEvents()
        {
            this.Load += FormSanVoucherGioVang_Load;
            dgvGioVang.SelectionChanged += DgvGioVang_SelectionChanged;
            btnSanVe.Click += BtnSanVe_Click;
            this.FormClosing += (s, ev) => autoRefreshTimer.Stop(); // Dừng timer khi đóng form
        }

        private void FormSanVoucherGioVang_Load(object sender, EventArgs e)
        {
            LoadActiveCampaigns();
            autoRefreshTimer.Start(); // Bắt đầu chạy tự động làm mới
        }

        private async void LoadActiveCampaigns()
        {
            DataTable dt = null;
            await System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    dt = loVoucherGioVangBLL.GetActiveCampaigns();
                }
                catch { }
            });
            if (dt != null)
            {
                dgvGioVang.DataSource = dt;
                FormatGridHeaders();
            }
        }

        private void FormatGridHeaders()
        {
            if (dgvGioVang.Columns.Contains("MaLo"))
                dgvGioVang.Columns["MaLo"].HeaderText = "Mã Voucher";
            if (dgvGioVang.Columns.Contains("MaSuatChieu"))
                dgvGioVang.Columns["MaSuatChieu"].HeaderText = "Mã Suất";
            if (dgvGioVang.Columns.Contains("SoLuong"))
                dgvGioVang.Columns["SoLuong"].HeaderText = "Còn Lại";
            if (dgvGioVang.Columns.Contains("GiaGiam"))
            {
                dgvGioVang.Columns["GiaGiam"].HeaderText = "Mức Giảm";
                dgvGioVang.Columns["GiaGiam"].DefaultCellStyle.Format = "N0";
            }
            
            // Hide columns that we only display on the details panel
            if (dgvGioVang.Columns.Contains("TenPhim"))
                dgvGioVang.Columns["TenPhim"].Visible = false;
            if (dgvGioVang.Columns.Contains("NgayChieu"))
                dgvGioVang.Columns["NgayChieu"].Visible = false;
            if (dgvGioVang.Columns.Contains("GioBatDau"))
                dgvGioVang.Columns["GioBatDau"].Visible = false;
            if (dgvGioVang.Columns.Contains("KinhPhiToiDa"))
                dgvGioVang.Columns["KinhPhiToiDa"].Visible = false;
            if (dgvGioVang.Columns.Contains("TrangThai"))
                dgvGioVang.Columns["TrangThai"].Visible = false;
        }

        private void DgvGioVang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGioVang.SelectedRows.Count > 0)
            {
                DataRowView row = (dgvGioVang.SelectedRows[0].DataBoundItem) as DataRowView;
                if (row != null)
                {
                    lblMaLoVal.Text = row["MaLo"].ToString();
                    
                    // Expiration date is set dynamically to 10 days from today
                    lblSuatChieuVal.Text = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy");
                    
                    decimal price = Convert.ToDecimal(row["GiaGiam"]);
                    currentPromoPrice = price;
                    lblGiaVeVal.Text = $"{price:N0} đ";
                    
                    lblSoLuongVal.Text = row["SoLuong"].ToString() + " voucher";
                    btnSanVe.Enabled = Convert.ToInt32(row["SoLuong"]) > 0;
                }
            }
            else
            {
                ClearDetails();
            }
        }

        private void ClearDetails()
        {
            lblMaLoVal.Text = "Chưa chọn voucher";
            lblSuatChieuVal.Text = "";
            lblGiaVeVal.Text = "0 đ";
            lblSoLuongVal.Text = "0 voucher";
            lblTenPhimVal.Text = "--";
            lblGioChieuVal.Text = "--";
            btnSanVe.Enabled = false;
            currentPromoPrice = 0;
        }

        private async void BtnSanVe_Click(object sender, EventArgs e)
        {
            string maLo = lblMaLoVal.Text;
            
            if (maLo != "Chưa chọn voucher")
            {
                btnSanVe.Enabled = false;
                btnSanVe.Text = "Đang xử lý...";
                
                string maKhachHang = "KH01"; // default fallback
                if (SessionHelper.CurrentUser != null)
                {
                    KhachHangBLL khBLL = new KhachHangBLL();
                    var kh = khBLL.GetKhachHangByTenDangNhap(SessionHelper.CurrentUser.TenDangNhap);
                    if (kh != null) maKhachHang = kh.MaKhachHang;
                }

                bool success = false;
                string errorMsg = "";
                await System.Threading.Tasks.Task.Run(() =>
                {
                    try
                    {
                        success = loVoucherGioVangBLL.SanVoucher(maLo, maKhachHang);
                    }
                    catch (Exception ex)
                    {
                        success = false;
                        errorMsg = ex.Message;
                    }
                });
                
                btnSanVe.Enabled = true;
                btnSanVe.Text = "SĂN VOUCHER NGAY ➔";


                if (success)
                {
                    MessageBox.Show("Chúc mừng bạn đã săn voucher thành công!\nMức giảm giá: " + currentPromoPrice.ToString("N0") + " đ\nHạn sử dụng: Suất chiếu liên kết\nVui lòng kiểm tra ví voucher!", "Săn voucher thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadActiveCampaigns();
                }
                else
                {
                    // Lọc mã lỗi SQL Server
                    if (!string.IsNullOrEmpty(errorMsg))
                    {
                        // Giả lập ghi Log cho lập trình viên (ghi ra Debug/Console)
                        System.Diagnostics.Debug.WriteLine("SQL Error Logged: " + errorMsg);

                        // Thông báo thân thiện cho người dùng dựa trên kiểu lỗi
                        if (errorMsg.Contains("Đã hết voucher") || errorMsg.Contains("50003"))
                        {
                            MessageBox.Show("Voucher không còn khả dụng. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi hệ thống. Vui lòng thử lại sau.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi hệ thống. Vui lòng thử lại sau.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadActiveCampaigns();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một voucher từ danh sách trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
