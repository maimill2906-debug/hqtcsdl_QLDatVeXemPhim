using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormVoucherGioVang : Form
    {
        private LoVoucherGioVangBLL loVoucherGioVangBLL = new LoVoucherGioVangBLL();
        private SuatChieuBLL suatChieuBLL = new SuatChieuBLL();

        public FormVoucherGioVang()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            PopulateStatusOptions();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormVoucherGioVang_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvLoVeGioVang.SelectionChanged += DgvLoVeGioVang_SelectionChanged;
        }

        private void FormVoucherGioVang_Load(object sender, EventArgs e)
        {
            txtMaLo.ReadOnly = true;
            LoadComboboxSuatChieu();
            LoadData();
            ClearInputs();
        }

        private void PopulateStatusOptions()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Kích hoạt");
            cboTrangThai.Items.Add("Tạm dừng");
            cboTrangThai.Items.Add("Kết thúc");
            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadComboboxSuatChieu()
        {
            cboSuatChieu.DataSource = suatChieuBLL.GetAll();
            cboSuatChieu.DisplayMember = "MaSuatChieu";
            cboSuatChieu.ValueMember = "MaSuatChieu";
        }

        private void LoadData()
        {
            dgvLoVeGioVang.DataSource = loVoucherGioVangBLL.GetAll();
            FormatGridHeaders();
        }

        private void FormatGridHeaders()
        {
            if (dgvLoVeGioVang.Columns.Contains("MaLo"))
                dgvLoVeGioVang.Columns["MaLo"].HeaderText = "Mã Voucher";
            if (dgvLoVeGioVang.Columns.Contains("MaSuatChieu"))
                dgvLoVeGioVang.Columns["MaSuatChieu"].HeaderText = "Mã Suất Chiếu";
            if (dgvLoVeGioVang.Columns.Contains("TenPhim"))
                dgvLoVeGioVang.Columns["TenPhim"].HeaderText = "Tên Phim";
            if (dgvLoVeGioVang.Columns.Contains("SoLuong"))
                dgvLoVeGioVang.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (dgvLoVeGioVang.Columns.Contains("GiaGiam"))
            {
                dgvLoVeGioVang.Columns["GiaGiam"].HeaderText = "Mức Giảm";
                dgvLoVeGioVang.Columns["GiaGiam"].DefaultCellStyle.Format = "N0";
            }
            if (dgvLoVeGioVang.Columns.Contains("KinhPhiToiDa"))
            {
                dgvLoVeGioVang.Columns["KinhPhiToiDa"].HeaderText = "Kinh Phí Tối Đa";
                dgvLoVeGioVang.Columns["KinhPhiToiDa"].DefaultCellStyle.Format = "N0";
            }
            if (dgvLoVeGioVang.Columns.Contains("TrangThai"))
                dgvLoVeGioVang.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void DgvLoVeGioVang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoVeGioVang.SelectedRows.Count > 0)
            {
                DataRowView row = (DataRowView)dgvLoVeGioVang.SelectedRows[0].DataBoundItem;
                if (row != null)
                {
                    txtMaLo.Text = row["MaLo"].ToString();
                    cboSuatChieu.SelectedValue = row["MaSuatChieu"].ToString();
                    nudSoLuong.Value = Convert.ToDecimal(row["SoLuong"]);
                    nudGiaVe.Value = Convert.ToDecimal(row["GiaGiam"]);
                    nudKinhPhiToiDa.Value = Convert.ToDecimal(row["KinhPhiToiDa"]);

                    string trangThai = row["TrangThai"].ToString();
                    int idx = cboTrangThai.FindStringExact(trangThai);
                    if (idx >= 0) cboTrangThai.SelectedIndex = idx;
                }
            }
        }

        private async void BtnThem_Click(object sender, EventArgs e)
        {
            LoVoucherGioVangDTO lo = new LoVoucherGioVangDTO
            {
                MaLo = txtMaLo.Text.Trim(),
                MaSuatChieu = cboSuatChieu.SelectedValue?.ToString() ?? "",
                SoLuong = (int)nudSoLuong.Value,
                GiaGiam = nudGiaVe.Value,
                KinhPhiToiDa = nudKinhPhiToiDa.Value,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Kích hoạt"
            };

            btnThem.Enabled = false;
            btnThem.Text = "Đang xử lý...";

            string message = "";
            bool success = false;

            await System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    success = loVoucherGioVangBLL.Insert(lo, out message);
                }
                catch (Exception ex)
                {
                    // Catch SQL Server exception from THROW
                    success = false;
                    message = ex.Message;
                }
            });

            btnThem.Enabled = true;
            btnThem.Text = "Thêm";

            if (success)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLo.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn lô voucher để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoVoucherGioVangDTO lo = new LoVoucherGioVangDTO
            {
                MaLo = txtMaLo.Text.Trim(),
                MaSuatChieu = cboSuatChieu.SelectedValue?.ToString() ?? "",
                SoLuong = (int)nudSoLuong.Value,
                GiaGiam = nudGiaVe.Value,
                KinhPhiToiDa = nudKinhPhiToiDa.Value,
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Kích hoạt"
            };

            string message;
            if (loVoucherGioVangBLL.Update(lo, out message))
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
            string maLo = txtMaLo.Text.Trim();
            if (string.IsNullOrEmpty(maLo))
            {
                MessageBox.Show("Vui lòng chọn lô voucher để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa lô voucher giờ vàng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                string message;
                if (loVoucherGioVangBLL.Delete(maLo, out message))
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
            LoadComboboxSuatChieu();
            LoadData();
        }

        private void ClearInputs()
        {
            txtMaLo.Text = loVoucherGioVangBLL.GetNextMaLo();
            if (cboSuatChieu.Items.Count > 0) cboSuatChieu.SelectedIndex = 0;
            nudSoLuong.Value = 0;
            nudGiaVe.Value = 0;
            nudKinhPhiToiDa.Value = 0;
            cboTrangThai.SelectedIndex = 0;
            cboSuatChieu.Focus();
        }
    }
}
