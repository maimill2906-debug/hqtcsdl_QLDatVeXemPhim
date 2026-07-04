using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormKhoBapNuoc : Form
    {
        private KhoBapNuocBLL khoBapNuocBLL = new KhoBapNuocBLL();
        private RapBLL rapBLL = new RapBLL();
        private bool isBinding = false;
        private Timer refreshTimer;

        public FormKhoBapNuoc()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormKhoBapNuoc_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            btnTimKiem.Click += BtnTimKiem_Click;
            dgvKhoBapNuoc.SelectionChanged += DgvKhoBapNuoc_SelectionChanged;

            // Khởi tạo Timer tự động quét làm mới lưới dữ liệu
            refreshTimer = new Timer();
            refreshTimer.Interval = 1500; // 1.5 giây
            refreshTimer.Tick += RefreshTimer_Tick;
        }

        private void FormKhoBapNuoc_Load(object sender, EventArgs e)
        {
            txtMaKho.ReadOnly = true;
            LoadComboboxRap();
            LoadData();
            ClearInputs();
            refreshTimer.Start(); // Bắt đầu quét làm mới tự động sau khi load xong
        }

        private void LoadComboboxRap()
        {
            DataTable dtRap = rapBLL.GetAll();
            if (dtRap.Rows.Count > 0)
            {
                cboRap.DataSource = dtRap;
                cboRap.DisplayMember = "TenRap";
                cboRap.ValueMember = "MaRap";
            }
            else
            {
                cboRap.DataSource = null;
                cboRap.Items.Clear();
                cboRap.Items.Add("RAP01");
                cboRap.Items.Add("RAP02");
                cboRap.Items.Add("RAP03");
                cboRap.SelectedIndex = 0;
            }
        }

        private void LoadData()
        {
            isBinding = true;
            dgvKhoBapNuoc.DataSource = khoBapNuocBLL.GetAll();
            FormatGridHeaders();
            dgvKhoBapNuoc.ClearSelection();
            isBinding = false;
        }

        private void FormatGridHeaders()
        {
            if (dgvKhoBapNuoc.Columns.Contains("MaKho"))
                dgvKhoBapNuoc.Columns["MaKho"].HeaderText = "Mã Mặt Hàng";
            if (dgvKhoBapNuoc.Columns.Contains("MaRap"))
                dgvKhoBapNuoc.Columns["MaRap"].Visible = false; // Ẩn cột mã rạp đi cho đẹp
            if (dgvKhoBapNuoc.Columns.Contains("TenRap"))
                dgvKhoBapNuoc.Columns["TenRap"].HeaderText = "Tên Rạp";
            if (dgvKhoBapNuoc.Columns.Contains("TenSanPham"))
                dgvKhoBapNuoc.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            if (dgvKhoBapNuoc.Columns.Contains("SoLuongHienCo"))
                dgvKhoBapNuoc.Columns["SoLuongHienCo"].HeaderText = "Số Lượng Hiện Có";
            if (dgvKhoBapNuoc.Columns.Contains("SucChuaToiDa"))
                dgvKhoBapNuoc.Columns["SucChuaToiDa"].HeaderText = "Sức Chứa Tối Đa";
        }

        private void DgvKhoBapNuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (isBinding) return;
            if (dgvKhoBapNuoc.SelectedRows.Count > 0)
            {
                DataRowView row = (DataRowView)dgvKhoBapNuoc.SelectedRows[0].DataBoundItem;
                if (row != null)
                {
                    txtMaKho.Text = row["MaKho"].ToString();
                    txtTenSanPham.Text = row["TenSanPham"].ToString();
                    nudSoLuongHienCo.Value = Convert.ToDecimal(row["SoLuongHienCo"]);
                    nudSucChuaToiDa.Value = Convert.ToDecimal(row["SucChuaToiDa"]);

                    string maRap = row["MaRap"].ToString();
                    if (cboRap.DataSource != null)
                    {
                        cboRap.SelectedValue = maRap;
                    }
                    else
                    {
                        int idx = cboRap.FindStringExact(maRap);
                        if (idx >= 0) cboRap.SelectedIndex = idx;
                    }
                }
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string selectedMaRap = cboRap.DataSource != null ? (cboRap.SelectedValue?.ToString() ?? "") : (cboRap.SelectedItem?.ToString() ?? "RAP01");
            
            KhoBapNuocDTO item = new KhoBapNuocDTO
            {
                MaKho = txtMaKho.Text.Trim(),
                MaRap = selectedMaRap,
                TenSanPham = txtTenSanPham.Text.Trim(),
                SoLuongHienCo = (int)nudSoLuongHienCo.Value,
                SucChuaToiDa = (int)nudSucChuaToiDa.Value
            };

            string message;
            if (khoBapNuocBLL.Insert(item, out message))
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

        private async void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm kho để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạm thời dừng Timer tự động quét để tránh tranh chấp dữ liệu khi đang sửa
            refreshTimer.Stop();

            // Hiển thị trạng thái Đang xử lý... trên nút bấm và khóa nút lại
            btnSua.Enabled = false;
            string originalText = btnSua.Text;
            btnSua.Text = "⏳ Đang xử lý...";

            // Giả lập thời gian chờ xử lý giao dịch 2 giây
            await System.Threading.Tasks.Task.Delay(2000);

            string selectedMaRap = cboRap.DataSource != null ? (cboRap.SelectedValue?.ToString() ?? "") : (cboRap.SelectedItem?.ToString() ?? "RAP01");
            
            KhoBapNuocDTO item = new KhoBapNuocDTO
            {
                MaKho = txtMaKho.Text.Trim(),
                MaRap = selectedMaRap,
                TenSanPham = txtTenSanPham.Text.Trim(),
                SoLuongHienCo = (int)nudSoLuongHienCo.Value,
                SucChuaToiDa = (int)nudSucChuaToiDa.Value
            };

            string message;
            if (khoBapNuocBLL.Update(item, out message))
            {
                btnSua.Text = originalText;
                btnSua.Enabled = true;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                btnSua.Text = originalText;
                btnSua.Enabled = true;
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kích hoạt lại Timer làm mới tự động
            refreshTimer.Start();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string maKho = txtMaKho.Text.Trim();
            if (string.IsNullOrEmpty(maKho))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm kho để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này khỏi kho không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                string message;
                if (khoBapNuocBLL.Delete(maKho, out message))
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
            LoadComboboxRap();
            LoadData();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvKhoBapNuoc.DataSource = khoBapNuocBLL.Search(keyword);
            FormatGridHeaders();
        }

        private void ClearInputs()
        {
            isBinding = true;
            dgvKhoBapNuoc.ClearSelection();
            txtMaKho.Text = GenerateNextMaKho();
            txtTenSanPham.Clear();
            nudSoLuongHienCo.Value = 0;
            nudSucChuaToiDa.Value = 0;
            txtTimKiem.Clear();
            if (cboRap.Items.Count > 0) cboRap.SelectedIndex = 0;
            isBinding = false;
            txtTenSanPham.Focus();
        }

        private string GenerateNextMaKho()
        {
            try
            {
                DataTable dt = khoBapNuocBLL.GetAll();
                int maxId = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string ma = row["MaKho"].ToString();
                    if (ma.StartsWith("K") && int.TryParse(ma.Substring(1), out int num))
                    {
                        if (num > maxId) maxId = num;
                    }
                }
                return "K" + (maxId + 1).ToString("D2");
            }
            catch
            {
                return "K01";
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Chỉ tự động làm mới lưới dữ liệu nếu người dùng không tập trung vào các ô nhập liệu
            if (!txtTenSanPham.Focused && !nudSoLuongHienCo.Focused && !nudSucChuaToiDa.Focused && !txtTimKiem.Focused)
            {
                int selectedIdx = -1;
                if (dgvKhoBapNuoc.SelectedRows.Count > 0)
                {
                    selectedIdx = dgvKhoBapNuoc.SelectedRows[0].Index;
                }

                isBinding = true;
                dgvKhoBapNuoc.DataSource = khoBapNuocBLL.GetAll();
                FormatGridHeaders();

                if (selectedIdx >= 0 && selectedIdx < dgvKhoBapNuoc.Rows.Count)
                {
                    dgvKhoBapNuoc.Rows[selectedIdx].Selected = true;
                }
                else
                {
                    dgvKhoBapNuoc.ClearSelection();
                }
                isBinding = false;
            }
        }

    }
}
