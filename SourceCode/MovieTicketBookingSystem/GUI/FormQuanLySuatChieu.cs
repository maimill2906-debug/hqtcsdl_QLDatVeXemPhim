using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormQuanLySuatChieu : Form
    {
        private SuatChieuBLL suatChieuBLL = new SuatChieuBLL();
        private PhimBLL phimBLL = new PhimBLL();
        private PhongChieuBLL phongChieuBLL = new PhongChieuBLL();
        private bool isBinding = false;

        public FormQuanLySuatChieu()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            PopulateStatusOptions();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormQuanLySuatChieu_Load;
            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvSuatChieu.SelectionChanged += DgvSuatChieu_SelectionChanged;
            txtMaSuatChieu.TextChanged += TxtMaSuatChieu_TextChanged;
            cboRap.SelectedIndexChanged += (s, e) => FilterRoomsBySelectedTheater();
        }

        private void FormQuanLySuatChieu_Load(object sender, EventArgs e)
        {
            txtMaSuatChieu.ReadOnly = true;
            LoadComboboxes();
            LoadData();
            ClearInputs();
        }

        private void PopulateStatusOptions()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang chiếu");
            cboTrangThai.Items.Add("Tạm ngưng");
            cboTrangThai.Items.Add("Đã hủy");
            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadComboboxes()
        {
            // Load Movies
            cboPhim.DataSource = phimBLL.GetAll();
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "MaPhim";

            // Load Theaters
            RapBLL rapBLL = new RapBLL();
            DataTable dtRap = rapBLL.GetAll();
            if (dtRap.Rows.Count > 0)
            {
                cboRap.DisplayMember = "TenRap";
                cboRap.ValueMember = "MaRap";
                cboRap.DataSource = dtRap;
                cboRap.SelectedIndex = 0;
            }

            FilterRoomsBySelectedTheater();
        }

        private void FilterRoomsBySelectedTheater()
        {
            if (cboRap.SelectedValue != null)
            {
                string selectedRap = cboRap.SelectedValue.ToString();
                DataTable dtAllPhong = phongChieuBLL.GetAll();

                DataView dv = new DataView(dtAllPhong);
                dv.RowFilter = "MaRap = '" + selectedRap + "'";
                DataTable dtFiltered = dv.ToTable();

                cboPhongChieu.DataSource = dtFiltered;
                cboPhongChieu.DisplayMember = "TenPhong";
                cboPhongChieu.ValueMember = "MaPhong";
            }
        }

        private void LoadData()
        {
            dgvSuatChieu.DataSource = suatChieuBLL.GetAll();
            FormatGridHeaders();
        }

        private void FormatGridHeaders()
        {
            if (dgvSuatChieu.Columns.Contains("MaSuatChieu"))
                dgvSuatChieu.Columns["MaSuatChieu"].HeaderText = "Mã Suất Chiếu";
            if (dgvSuatChieu.Columns.Contains("MaPhim"))
                dgvSuatChieu.Columns["MaPhim"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("TenPhim"))
                dgvSuatChieu.Columns["TenPhim"].HeaderText = "Tên Phim";
            if (dgvSuatChieu.Columns.Contains("MaPhong"))
                dgvSuatChieu.Columns["MaPhong"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("TenPhong"))
                dgvSuatChieu.Columns["TenPhong"].HeaderText = "Tên Phòng";
            if (dgvSuatChieu.Columns.Contains("MaRap"))
                dgvSuatChieu.Columns["MaRap"].Visible = false;
            if (dgvSuatChieu.Columns.Contains("TenRap"))
                dgvSuatChieu.Columns["TenRap"].HeaderText = "Rạp Chiếu";
            if (dgvSuatChieu.Columns.Contains("NgayChieu"))
                dgvSuatChieu.Columns["NgayChieu"].HeaderText = "Ngày Chiếu";
            if (dgvSuatChieu.Columns.Contains("GioBatDau"))
                dgvSuatChieu.Columns["GioBatDau"].HeaderText = "Giờ Bắt Đầu";
            if (dgvSuatChieu.Columns.Contains("GioKetThuc"))
                dgvSuatChieu.Columns["GioKetThuc"].HeaderText = "Giờ Kết Thúc";
            if (dgvSuatChieu.Columns.Contains("TrangThai"))
                dgvSuatChieu.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void DgvSuatChieu_SelectionChanged(object sender, EventArgs e)
        {
            // Only update when grid is focused to prevent circular TextChanged searches overriding inputs
            if (!dgvSuatChieu.Focused) return;

            if (dgvSuatChieu.SelectedRows.Count > 0)
            {
                isBinding = true;
                DataRowView row = (DataRowView)dgvSuatChieu.SelectedRows[0].DataBoundItem;
                if (row != null)
                {
                    txtMaSuatChieu.Text = row["MaSuatChieu"].ToString();
                    cboPhim.SelectedValue = row["MaPhim"].ToString();
                    
                    if (row.Row.Table.Columns.Contains("MaRap"))
                    {
                        cboRap.SelectedValue = row["MaRap"].ToString();
                        FilterRoomsBySelectedTheater();
                    }
                    cboPhongChieu.SelectedValue = row["MaPhong"].ToString();
                    
                    dtpNgayChieu.Value = Convert.ToDateTime(row["NgayChieu"]);
                    
                    TimeSpan gbd = (TimeSpan)row["GioBatDau"];
                    TimeSpan gkt = (TimeSpan)row["GioKetThuc"];
                    dtpGioBatDau.Value = DateTime.Today + gbd;
                    dtpGioKetThuc.Value = DateTime.Today + gkt;

                    string trangThai = row["TrangThai"].ToString();
                    int idx = cboTrangThai.FindStringExact(trangThai);
                    if (idx >= 0) cboTrangThai.SelectedIndex = idx;
                }
                isBinding = false;
            }
        }

        private void TxtMaSuatChieu_TextChanged(object sender, EventArgs e)
        {
            if (isBinding) return;

            string keyword = txtMaSuatChieu.Text.Trim();
            dgvSuatChieu.DataSource = suatChieuBLL.Search(keyword);
            FormatGridHeaders();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            SuatChieuDTO sc = new SuatChieuDTO
            {
                MaSuatChieu = txtMaSuatChieu.Text.Trim(),
                MaPhim = cboPhim.SelectedValue?.ToString() ?? "",
                MaPhong = cboPhongChieu.SelectedValue?.ToString() ?? "",
                NgayChieu = dtpNgayChieu.Value.Date,
                GioBatDau = dtpGioBatDau.Value.TimeOfDay,
                GioKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang chiếu"
            };

            string message;
            if (suatChieuBLL.Insert(sc, out message))
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

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSuatChieu.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn suất chiếu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SuatChieuDTO sc = new SuatChieuDTO
            {
                MaSuatChieu = txtMaSuatChieu.Text.Trim(),
                MaPhim = cboPhim.SelectedValue?.ToString() ?? "",
                MaPhong = cboPhongChieu.SelectedValue?.ToString() ?? "",
                NgayChieu = dtpNgayChieu.Value.Date,
                GioBatDau = dtpGioBatDau.Value.TimeOfDay,
                GioKetThuc = dtpGioKetThuc.Value.TimeOfDay,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang chiếu"
            };

            btnSua.Enabled = false;
            string originalText = btnSua.Text;
            btnSua.Text = "Đang xử lý...";

            bool success = false;
            string message = "";

            await System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    success = suatChieuBLL.Update(sc, out message);
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
            });

            btnSua.Text = originalText;
            btnSua.Enabled = true;

            if (success)
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
            string maSuatChieu = txtMaSuatChieu.Text.Trim();
            if (string.IsNullOrEmpty(maSuatChieu))
            {
                MessageBox.Show("Vui lòng chọn suất chiếu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa suất chiếu này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                string message;
                if (suatChieuBLL.Delete(maSuatChieu, out message))
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
            txtMaSuatChieu.Text = suatChieuBLL.GetNextMaSuatChieu();
            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;
            if (cboRap.Items.Count > 0) cboRap.SelectedIndex = 0;
            if (cboPhongChieu.Items.Count > 0) cboPhongChieu.SelectedIndex = 0;
            dtpNgayChieu.Value = DateTime.Today;
            dtpGioBatDau.Value = DateTime.Now;
            dtpGioKetThuc.Value = DateTime.Now.AddHours(2);
            cboTrangThai.SelectedIndex = 0;
            isBinding = false;
        }

    }
}
