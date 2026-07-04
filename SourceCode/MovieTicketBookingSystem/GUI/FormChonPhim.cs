using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormChonPhim : Form
    {
        private PhimBLL phimBLL = new PhimBLL();
        private TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        private Action<string> onMovieSelected; // Callback when user chooses a movie
        private bool isBinding = false;

        public FormChonPhim()
        {
            InitializeComponent();
            ApplyCinemaTheme();
            RegisterEvents();
        }

        public FormChonPhim(Action<string> onMovieSelected) : this()
        {
            this.onMovieSelected = onMovieSelected;
        }

        private void RegisterEvents()
        {
            this.Load += FormChonPhim_Load;
            cboTheLoai.SelectedIndexChanged += CboTheLoai_SelectedIndexChanged;
            dgvPhim.SelectionChanged += DgvPhim_SelectionChanged;
            btnChonPhim.Click += BtnChonPhim_Click;
        }

        private void FormChonPhim_Load(object sender, EventArgs e)
        {
            LoadComboboxTheLoai();
            LoadData();
        }

        private void LoadComboboxTheLoai()
        {
            isBinding = true;
            DataTable dt = theLoaiBLL.GetAll();
            DataRow rowAll = dt.NewRow();
            rowAll["MaTheLoai"] = "";
            rowAll["TenTheLoai"] = "Tất cả";
            dt.Rows.InsertAt(rowAll, 0);

            cboTheLoai.DataSource = dt;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
            cboTheLoai.SelectedIndex = 0;
            isBinding = false;
        }

        private void LoadData()
        {
            DataTable dtPhim = phimBLL.GetAll();
            DataTable dtFiltered = GetMoviesWithActiveShowtimes(dtPhim);
            dgvPhim.DataSource = dtFiltered;
            FormatGridHeaders();
        }

        private DataTable GetMoviesWithActiveShowtimes(DataTable dtPhim)
        {
            // Lấy tất cả suất chiếu đang hoạt động (không bị Tạm ngưng hay Đã hủy)
            SuatChieuBLL scBLL = new SuatChieuBLL();
            DataTable dtSC = scBLL.GetAll();
            
            HashSet<string> activeMovieIds = new HashSet<string>();
            foreach (DataRow row in dtSC.Rows)
            {
                string trangThai = row["TrangThai"].ToString().Trim();
                if (trangThai != "Tạm ngưng" && trangThai != "Đã hủy")
                {
                    activeMovieIds.Add(row["MaPhim"].ToString().Trim());
                }
            }

            // Lọc danh sách phim chỉ giữ lại phim có ít nhất 1 suất chiếu hoạt động
            DataTable dtFiltered = dtPhim.Clone();
            foreach (DataRow row in dtPhim.Rows)
            {
                string maPhim = row["MaPhim"].ToString().Trim();
                if (activeMovieIds.Contains(maPhim))
                {
                    dtFiltered.ImportRow(row);
                }
            }
            return dtFiltered;
        }

        private void FormatGridHeaders()
        {
            if (dgvPhim.Columns.Contains("MaPhim"))
                dgvPhim.Columns["MaPhim"].HeaderText = "Mã phim";
            if (dgvPhim.Columns.Contains("TenPhim"))
                dgvPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            if (dgvPhim.Columns.Contains("TenTheLoai"))
                dgvPhim.Columns["TenTheLoai"].HeaderText = "Thể loại";
            if (dgvPhim.Columns.Contains("ThoiLuong"))
                dgvPhim.Columns["ThoiLuong"].HeaderText = "Thời lượng (phút)";
            
            // Hide details columns
            if (dgvPhim.Columns.Contains("MaPhim"))
            {
                dgvPhim.Columns["MaPhim"].Visible = false;
            }
            if (dgvPhim.Columns.Contains("MaTheLoai"))
                dgvPhim.Columns["MaTheLoai"].Visible = false;
            if (dgvPhim.Columns.Contains("MoTa"))
                dgvPhim.Columns["MoTa"].Visible = false;
            if (dgvPhim.Columns.Contains("AnhPoster"))
                dgvPhim.Columns["AnhPoster"].Visible = false;
        }

        private void CboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isBinding) return;
            if (cboTheLoai.SelectedValue == null) return;
            string selectedGenreId = cboTheLoai.SelectedValue.ToString();
            if (selectedGenreId == "System.Data.DataRowView") return;

            DataTable dtPhim;
            if (string.IsNullOrEmpty(selectedGenreId))
            {
                dtPhim = phimBLL.GetAll();
            }
            else
            {
                dtPhim = phimBLL.GetByTheLoai(selectedGenreId, true);
            }

            dgvPhim.DataSource = GetMoviesWithActiveShowtimes(dtPhim);
            FormatGridHeaders();
            
            if (dgvPhim.Rows.Count == 0)
            {
                ClearDetails();
            }
        }

        private void DgvPhim_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhim.SelectedRows.Count > 0)
            {
                DataRowView row = (DataRowView)dgvPhim.SelectedRows[0].DataBoundItem;
                if (row != null)
                {
                    lblTenPhimVal.Text = row["TenPhim"].ToString();
                    lblThoiLuongVal.Text = row["ThoiLuong"].ToString() + " phút";
                    lblMoTaVal.Text = row["MoTa"].ToString();
                    
                    string urlOrPath = row.Row.Table.Columns.Contains("AnhPoster") ? row["AnhPoster"].ToString() : "";
                    LoadPoster(urlOrPath, row["TenPhim"].ToString(), picPoster);
                    btnChonPhim.Enabled = true;
                }
            }
            else
            {
                ClearDetails();
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
                else if (urlOrPath.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                         urlOrPath.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    // Tải ảnh hoàn toàn dưới Background Thread (Task.Run) để tránh nghẽn DNS/mạng làm đơ giao diện UI
                    System.Threading.Tasks.Task.Run(() =>
                    {
                        try
                        {
                            using (var webClient = new System.Net.WebClient())
                            {
                                byte[] data = webClient.DownloadData(urlOrPath);
                                this.Invoke((MethodInvoker)delegate
                                {
                                    using (var ms = new System.IO.MemoryStream(data))
                                    {
                                        pic.Image = new Bitmap(Image.FromStream(ms));
                                    }
                                });
                            }
                        }
                        catch
                        {
                            try
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    pic.Image = CreateMockPoster(fallbackTitle, Color.FromArgb(108, 92, 231));
                                });
                            }
                            catch { }
                        }
                    });
                    return;
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
            catch
            {
                // Ignore and fallback
            }

            pic.Image = CreateMockPoster(fallbackTitle, Color.FromArgb(108, 92, 231));
        }

        private void ClearDetails()
        {
            lblTenPhimVal.Text = "Chưa chọn phim";
            lblThoiLuongVal.Text = "0 phút";
            lblMoTaVal.Text = "(Chọn một phim ở bảng trên để xem mô tả chi tiết)";
            picPoster.Image = null;
            btnChonPhim.Enabled = false;
        }

        private void BtnChonPhim_Click(object sender, EventArgs e)
        {
            if (dgvPhim.SelectedRows.Count > 0 && btnChonPhim.Enabled)
            {
                DataRowView row = (DataRowView)dgvPhim.SelectedRows[0].DataBoundItem;
                if (row != null && onMovieSelected != null)
                {
                    string selectedMaPhim = row["MaPhim"].ToString();
                    onMovieSelected(selectedMaPhim); // Pass the selected MaPhim to the callback
                }
            }
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

            pnlFilter.BackColor = CinemaTheme.White;
            pnlDetails.BackColor = CinemaTheme.White;

            lblTitle.ForeColor = CinemaTheme.DarkBlue;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            // Labels
            lblFilterTheLoai.ForeColor = CinemaTheme.TextColor;
            lblTenPhim.ForeColor = CinemaTheme.TextColor;
            lblThoiLuong.ForeColor = CinemaTheme.TextColor;
            lblMoTa.ForeColor = CinemaTheme.TextColor;

            // Values
            lblTenPhimVal.ForeColor = CinemaTheme.DarkBlue;
            lblTenPhimVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            
            lblThoiLuongVal.ForeColor = CinemaTheme.TextColor;
            lblMoTaVal.ForeColor = CinemaTheme.TextColor;

            // Inputs
            cboTheLoai.BackColor = CinemaTheme.White;
            cboTheLoai.ForeColor = CinemaTheme.TextColor;

            // Buttons
            btnChonPhim.BackColor = CinemaTheme.LightBlue;
            btnChonPhim.ForeColor = CinemaTheme.White;
            btnChonPhim.FlatStyle = FlatStyle.Flat;
            btnChonPhim.FlatAppearance.BorderSize = 0;
            btnChonPhim.FlatAppearance.MouseOverBackColor = CinemaTheme.DarkBlue;
            btnChonPhim.Cursor = Cursors.Hand;
            btnChonPhim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Mock Poster Area
            picPoster.BackColor = CinemaTheme.LightGray;
            picPoster.BorderStyle = BorderStyle.FixedSingle;

            // Grid styling
            StyleDataGridView(dgvPhim);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            CinemaTheme.StyleDataGridView(dgv);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (btnChonPhim != null && pnlDetails != null)
            {
                int newX = pnlDetails.Width - btnChonPhim.Width - 25;
                btnChonPhim.Location = new Point(newX, btnChonPhim.Location.Y);
            }
        }
    }
}
