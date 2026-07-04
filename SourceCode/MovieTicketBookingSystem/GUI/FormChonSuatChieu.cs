using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormChonSuatChieu : Form
    {
        private string maPhim;
        private string tenPhim;
        private PhimBLL phimBLL = new PhimBLL();
        private SuatChieuBLL suatChieuBLL = new SuatChieuBLL();
        private Action<string, string> onShowtimeSelected; // Callback passing (maSuatChieu, maPhong)

        public FormChonSuatChieu(string maPhim, Action<string, string> onShowtimeSelected)
        {
            InitializeComponent();
            this.maPhim = maPhim;
            this.onShowtimeSelected = onShowtimeSelected;
            ApplyCinemaTheme();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormChonSuatChieu_Load;
            btnTiepTuc.Click += BtnTiepTuc_Click;
        }

        private void FormChonSuatChieu_Load(object sender, EventArgs e)
        {
            LoadMovieInfo();
            LoadShowtimes();
        }

        private void LoadMovieInfo()
        {
            PhimDTO phim = phimBLL.GetById(maPhim);
            if (phim != null)
            {
                this.tenPhim = phim.TenPhim;
                lblTenPhimVal.Text = phim.TenPhim;
                lblThoiLuongVal.Text = phim.ThoiLuong.ToString() + " phút";
                lblMoTaVal.Text = phim.MoTa;
                LoadPoster(phim.AnhPoster, phim.TenPhim, picPoster);
            }
        }

        private void LoadShowtimes()
        {
            DataTable dtShowtimes = suatChieuBLL.GetShowtimesByMovie(maPhim);
            
            // Lọc bỏ suất chiếu Tạm ngưng và Đã hủy
            DataTable dtFiltered = dtShowtimes.Clone();
            foreach (DataRow row in dtShowtimes.Rows)
            {
                string trangThai = row["TrangThai"].ToString();
                if (trangThai != "Tạm ngưng" && trangThai != "Đã hủy")
                {
                    dtFiltered.ImportRow(row);
                }
            }

            dgvSuatChieu.DataSource = dtFiltered;
            FormatGridHeaders();
        }

        private void FormatGridHeaders()
        {
            // Ẩn các cột hệ thống để giao diện khách hàng trông cực kỳ tối giản, không rối mắt
            if (dgvSuatChieu.Columns.Contains("MaSuatChieu"))
                dgvSuatChieu.Columns["MaSuatChieu"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("MaPhim"))
                dgvSuatChieu.Columns["MaPhim"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("TenPhim"))
                dgvSuatChieu.Columns["TenPhim"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("MaPhong"))
                dgvSuatChieu.Columns["MaPhong"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("MaRap"))
                dgvSuatChieu.Columns["MaRap"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("TrangThai"))
                dgvSuatChieu.Columns["TrangThai"].Visible = false;

            // Đổi tiêu đề các cột cần hiển thị
            if (dgvSuatChieu.Columns.Contains("TenRap"))
                dgvSuatChieu.Columns["TenRap"].HeaderText = "Rạp Chiếu (Chi Nhánh)";
            if (dgvSuatChieu.Columns.Contains("TenPhong"))
                dgvSuatChieu.Columns["TenPhong"].HeaderText = "Phòng";
            if (dgvSuatChieu.Columns.Contains("NgayChieu"))
            {
                dgvSuatChieu.Columns["NgayChieu"].HeaderText = "Ngày chiếu";
                dgvSuatChieu.Columns["NgayChieu"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvSuatChieu.Columns.Contains("GioBatDau"))
                dgvSuatChieu.Columns["GioBatDau"].HeaderText = "Giờ bắt đầu";
            if (dgvSuatChieu.Columns.Contains("GioKetThuc"))
                dgvSuatChieu.Columns["GioKetThuc"].HeaderText = "Giờ kết thúc";

            StyleDataGridView(dgvSuatChieu);
        }

        private void BtnTiepTuc_Click(object sender, EventArgs e)
        {
            if (dgvSuatChieu.SelectedRows.Count > 0)
            {
                DataRowView row = (DataRowView)dgvSuatChieu.SelectedRows[0].DataBoundItem;
                if (row != null && onShowtimeSelected != null)
                {
                    string maSuatChieu = row["MaSuatChieu"].ToString();
                    string maPhong = row["MaPhong"].ToString();
                    onShowtimeSelected(maSuatChieu, maPhong);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một suất chiếu để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadPoster(string urlOrPath, string fallbackTitle, PictureBox pic)
        {
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            if (string.IsNullOrWhiteSpace(urlOrPath))
            {
                pic.Image = CreateMockPoster(fallbackTitle, Color.FromArgb(108, 92, 231));
                return;
            }

            try
            {
                if (urlOrPath.StartsWith("data:image/", StringComparison.OrdinalIgnoreCase))
                {
                    int commaIndex = urlOrPath.IndexOf(',');
                    if (commaIndex >= 0)
                    {
                        string base64Data = urlOrPath.Substring(commaIndex + 1);
                        byte[] imageBytes = Convert.FromBase64String(base64Data);
                        using (var ms = new System.IO.MemoryStream(imageBytes))
                        {
                            pic.Image = new Bitmap(Image.FromStream(ms));
                        }
                        return;
                    }
                }
                else if (System.IO.File.Exists(urlOrPath))
                {
                    using (var tempImg = Image.FromFile(urlOrPath))
                    {
                        pic.Image = new Bitmap(tempImg);
                    }
                    return;
                }
            }
            catch { }

            pic.Image = CreateMockPoster(fallbackTitle, Color.FromArgb(108, 92, 231));
        }

        private Image CreateMockPoster(string title, Color bg)
        {
            Bitmap bmp = new Bitmap(110, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(bg);
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    g.DrawString("POSTER", new Font("Segoe UI", 8, FontStyle.Bold), textBrush, 10, 10);
                    g.DrawString(title, new Font("Segoe UI", 9, FontStyle.Bold), textBrush, new RectangleF(10, 40, 90, 100));
                }
            }
            return bmp;
        }

        private void ApplyCinemaTheme()
        {
            this.BackColor = CinemaTheme.LightGray;
            this.ForeColor = CinemaTheme.TextColor;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 246, 250);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(9, 132, 227);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowTemplate.Height = 35;
        }
    }
}
