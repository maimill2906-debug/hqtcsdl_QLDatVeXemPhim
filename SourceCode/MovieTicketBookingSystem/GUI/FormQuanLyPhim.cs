using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormQuanLyPhim : Form
    {
        private PhimBLL phimBLL = new PhimBLL();
        private TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        private bool isBinding = false;
        private string currentAnhPoster = "";

        public FormQuanLyPhim()
        {
            InitializeComponent();
            ApplyCinemaTheme();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormQuanLyPhim_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            btnTimTheoTheLoai.Click += BtnTimTheoTheLoai_Click;
            dgvPhim.SelectionChanged += DgvPhim_SelectionChanged;
            txtTenPhim.TextChanged += TxtTenPhim_TextChanged;
        }

        private void FormQuanLyPhim_Load(object sender, EventArgs e)
        {
            txtMaPhim.ReadOnly = true;
            LoadComboboxes();
            LoadData();
            ClearInputs();
        }

        private void LoadComboboxes()
        {
            // Load cboTheLoai
            DataTable dtTheLoai1 = theLoaiBLL.GetAll();
            cboTheLoai.DataSource = dtTheLoai1;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";

            // Load cboTimTheLoai with "-- Tất cả --" option
            DataTable dtTheLoai2 = theLoaiBLL.GetAll();
            DataRow rowAll = dtTheLoai2.NewRow();
            rowAll["MaTheLoai"] = "";
            rowAll["TenTheLoai"] = "-- Tất cả thể loại --";
            dtTheLoai2.Rows.InsertAt(rowAll, 0);

            cboTimTheLoai.DataSource = dtTheLoai2;
            cboTimTheLoai.DisplayMember = "TenTheLoai";
            cboTimTheLoai.ValueMember = "MaTheLoai";
            cboTimTheLoai.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dgvPhim.DataSource = phimBLL.GetAll();
            FormatGridHeaders(false);
        }

        private void FormatGridHeaders(bool showSTT = false)
        {
            if (showSTT)
            {
                // Thêm cột STT nếu chưa tồn tại
                if (!dgvPhim.Columns.Contains("STT"))
                {
                    DataGridViewTextBoxColumn sttCol = new DataGridViewTextBoxColumn();
                    sttCol.Name = "STT";
                    sttCol.HeaderText = "STT";
                    sttCol.Width = 60;
                    sttCol.ReadOnly = true;
                    sttCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvPhim.Columns.Insert(0, sttCol);
                }
                dgvPhim.Columns["STT"].Visible = true;

                // Ẩn cột Mã Phim
                if (dgvPhim.Columns.Contains("MaPhim"))
                    dgvPhim.Columns["MaPhim"].Visible = false;

                // Điền giá trị số thứ tự (STT) lần lượt từ 1
                for (int i = 0; i < dgvPhim.Rows.Count; i++)
                {
                    dgvPhim.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                }
            }
            else
            {
                // Ẩn cột STT nếu tồn tại
                if (dgvPhim.Columns.Contains("STT"))
                    dgvPhim.Columns["STT"].Visible = false;

                // Hiện cột Mã Phim ở vị trí đầu tiên
                if (dgvPhim.Columns.Contains("MaPhim"))
                {
                    dgvPhim.Columns["MaPhim"].Visible = true;
                    dgvPhim.Columns["MaPhim"].HeaderText = "Mã Phim";
                    dgvPhim.Columns["MaPhim"].DisplayIndex = 0;
                }
            }

            if (dgvPhim.Columns.Contains("TenPhim"))
                dgvPhim.Columns["TenPhim"].HeaderText = "Tên Phim";
            if (dgvPhim.Columns.Contains("ThoiLuong"))
                dgvPhim.Columns["ThoiLuong"].HeaderText = "Thời Lượng";
            if (dgvPhim.Columns.Contains("MaTheLoai"))
                dgvPhim.Columns["MaTheLoai"].Visible = false; // Hide ID
            if (dgvPhim.Columns.Contains("TenTheLoai"))
                dgvPhim.Columns["TenTheLoai"].HeaderText = "Thể Loại";
            if (dgvPhim.Columns.Contains("MoTa"))
                dgvPhim.Columns["MoTa"].HeaderText = "Mô Tả";
            if (dgvPhim.Columns.Contains("AnhPoster"))
                dgvPhim.Columns["AnhPoster"].Visible = false;
        }

        private void DgvPhim_SelectionChanged(object sender, EventArgs e)
        {
            // Only update when grid is focused to prevent circular TextChanged searches overriding inputs
            if (!dgvPhim.Focused) return;

            if (dgvPhim.SelectedRows.Count > 0)
            {
                isBinding = true;
                DataRowView row = (DataRowView)dgvPhim.SelectedRows[0].DataBoundItem;
                if (row != null)
                {
                    txtMaPhim.Text = row["MaPhim"].ToString();
                    txtTenPhim.Text = row["TenPhim"].ToString();
                    nudThoiLuong.Value = Convert.ToDecimal(row["ThoiLuong"]);
                    txtMoTa.Text = row["MoTa"].ToString();
                    currentAnhPoster = row.Row.Table.Columns.Contains("AnhPoster") ? row["AnhPoster"].ToString() : "";
                    
                    if (cboTheLoai.DataSource != null)
                    {
                        cboTheLoai.SelectedValue = row["MaTheLoai"].ToString();
                    }
                }
                isBinding = false;
            }
        }

        private void TxtTenPhim_TextChanged(object sender, EventArgs e)
        {
            // Removed live search on TextChanged to prevent database query spamming and UI lags.
        }

        private async void BtnTimTheoTheLoai_Click(object sender, EventArgs e)
        {
            if (cboTimTheLoai.SelectedValue == null) return;
            
            string maTheLoaiSelected = cboTimTheLoai.SelectedValue.ToString();
            
            // Đọc lần 1: Đếm số lượng phim theo thể loại hiện có trong Database
            var db = new MovieTicketBookingSystem.DAL.Database();
            int count1 = 0;
            string countQuery = "SELECT COUNT(*) FROM PHIM";
            object[] countParams = null;
            if (!string.IsNullOrEmpty(maTheLoaiSelected))
            {
                countQuery = "SELECT COUNT(*) FROM PHIM WHERE MaTheLoai = @MaTheLoai";
                countParams = new object[] { maTheLoaiSelected };
            }
            
            object res = db.ExecuteScalar(countQuery, countParams);
            if (res != null) count1 = Convert.ToInt32(res);
 
            // Lưu lại chiều rộng và chữ gốc của nút
            int originalWidth = btnTimTheoTheLoai.Width;
            string originalText = btnTimTheoTheLoai.Text;

            // Mở rộng nút và vô hiệu hóa các điều khiển
            btnTimTheoTheLoai.Width = 280;
            btnTimTheoTheLoai.Enabled = false;
            cboTimTheLoai.Enabled = false;
 
            DataSet ds = null;
            
            // Khởi chạy tác vụ lấy dữ liệu bất đồng bộ dưới SQL (chờ 8 giây)
            var queryTask = System.Threading.Tasks.Task.Run(() =>
            {
                ds = phimBLL.GetByTheLoaiDataSet(maTheLoaiSelected);
            });

            // Bước 1: Hiển thị số lượng đã tìm thấy ngay trong nút
            btnTimTheoTheLoai.Text = $"Đã tìm thấy {count1} phim...";
            await System.Threading.Tasks.Task.Delay(1800);

            // Bước 2: Chạy hiệu ứng chấm động liên tục cho đến khi tải xong
            int dotCount = 0;
            while (!queryTask.IsCompleted)
            {
                string dots = new string('.', (dotCount % 5) + 1);
                btnTimTheoTheLoai.Text = $"Đang tải chi tiết{dots}";
                dotCount++;
                await System.Threading.Tasks.Task.Delay(600);
            }

            // Chờ tác vụ hoàn thành thực tế (nếu có sai lệch mili giây)
            await queryTask;
 
            // Bước 3: Thông báo đã xong và kiểm tra hiện tượng bóng ma (Phantom Read)
            btnTimTheoTheLoai.Text = "✓ Đã tải xong!";
            await System.Threading.Tasks.Task.Delay(800);
            
            // Khôi phục kích thước và chữ ban đầu
            btnTimTheoTheLoai.Text = originalText;
            btnTimTheoTheLoai.Width = originalWidth;
            btnTimTheoTheLoai.Enabled = true;
            cboTimTheLoai.Enabled = true;
 
            if (ds != null && ds.Tables.Count >= 2)
            {
                DataTable dtAfter = ds.Tables[1];
                dgvPhim.DataSource = dtAfter;
                FormatGridHeaders(true);
            }
            else if (ds != null && ds.Tables.Count == 1)
            {
                dgvPhim.DataSource = ds.Tables[0];
                FormatGridHeaders(true);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            PhimDTO phim = new PhimDTO
            {
                MaPhim = txtMaPhim.Text.Trim(),
                TenPhim = txtTenPhim.Text.Trim(),
                ThoiLuong = (int)nudThoiLuong.Value,
                MaTheLoai = cboTheLoai.SelectedValue?.ToString() ?? "",
                MoTa = txtMoTa.Text.Trim(),
                AnhPoster = ""
            };

            string message;
            if (phimBLL.Insert(phim, out message))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhim.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn phim để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PhimDTO phim = new PhimDTO
            {
                MaPhim = txtMaPhim.Text.Trim(),
                TenPhim = txtTenPhim.Text.Trim(),
                ThoiLuong = (int)nudThoiLuong.Value,
                MaTheLoai = cboTheLoai.SelectedValue?.ToString() ?? "",
                MoTa = txtMoTa.Text.Trim(),
                AnhPoster = currentAnhPoster
            };

            string message;
            if (phimBLL.Update(phim, out message))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string maPhim = txtMaPhim.Text.Trim();
            if (string.IsNullOrEmpty(maPhim))
            {
                MessageBox.Show("Vui lòng chọn phim để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phim này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                string message;
                if (phimBLL.Delete(maPhim, out message))
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadComboboxes();
            LoadData();
        }

        private void ClearInputs()
        {
            isBinding = true;
            txtMaPhim.Text = phimBLL.GetNextMaPhim();
            txtTenPhim.Clear();
            nudThoiLuong.Value = 0;
            txtMoTa.Clear();
            currentAnhPoster = "";
            if (cboTheLoai.Items.Count > 0) cboTheLoai.SelectedIndex = 0;
            isBinding = false;
            txtTenPhim.Focus();
        }

        private void ApplyCinemaTheme()
        {
            CinemaTheme.ApplyTheme(this);
            pnlInput.BackColor = CinemaTheme.White;
            pnlSearch.BackColor = CinemaTheme.White;
            lblTitle.ForeColor = CinemaTheme.DarkBlue;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            // Labels
            lblMaPhim.ForeColor = CinemaTheme.TextColor;
            lblTenPhim.ForeColor = CinemaTheme.TextColor;
            lblTheLoai.ForeColor = CinemaTheme.TextColor;
            lblThoiLuong.ForeColor = CinemaTheme.TextColor;
            lblMoTa.ForeColor = CinemaTheme.TextColor;
            lblTimTheLoai.ForeColor = CinemaTheme.TextColor;

            // Inputs
            StyleTextBox(txtMaPhim);
            StyleTextBox(txtTenPhim);
            StyleTextBox(txtMoTa);
            StyleComboBox(cboTheLoai);
            StyleComboBox(cboTimTheLoai);
            
            nudThoiLuong.BackColor = CinemaTheme.White;
            nudThoiLuong.ForeColor = CinemaTheme.TextColor;

            // Buttons
            StylePrimaryButton(btnThem);
            StylePrimaryButton(btnSua);
            StylePrimaryButton(btnXoa);
            StyleSecondaryButton(btnLamMoi);
            StyleSecondaryButton(btnTimTheoTheLoai);

            // Grid
            StyleDataGridView(dgvPhim);
        }

        private void StyleTextBox(TextBox txt)
        {
            CinemaTheme.StyleControl(txt);
        }

        private void StyleComboBox(ComboBox cbo)
        {
            CinemaTheme.StyleControl(cbo);
        }

        private void StylePrimaryButton(Button btn)
        {
            CinemaTheme.StyleControl(btn);
        }

        private void StyleSecondaryButton(Button btn)
        {
            CinemaTheme.StyleControl(btn);
            btn.BackColor = CinemaTheme.LightBlue;
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            CinemaTheme.StyleDataGridView(dgv);
        }
    }
}
