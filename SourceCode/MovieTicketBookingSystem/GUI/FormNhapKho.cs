using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormNhapKho : Form
    {
        private PhieuNhapKhoBLL phieuNhapKhoBLL = new PhieuNhapKhoBLL();

        public FormNhapKho()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormNhapKho_Load;
            btnNhapKho.Click += BtnNhapKho_Click;
            btnHuyPhieu.Click += BtnHuyPhieu_Click;
        }

        private void FormNhapKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvLichSuNhapKho.DataSource = phieuNhapKhoBLL.GetAll();
            FormatGridHeaders();
        }

        private void FormatGridHeaders()
        {
            if (dgvLichSuNhapKho.Columns.Contains("MaPhieu"))
                dgvLichSuNhapKho.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
            if (dgvLichSuNhapKho.Columns.Contains("MaKho"))
                dgvLichSuNhapKho.Columns["MaKho"].HeaderText = "Mã Kho";
            if (dgvLichSuNhapKho.Columns.Contains("TenSanPham"))
                dgvLichSuNhapKho.Columns["TenSanPham"].HeaderText = "Sản Phẩm";
            if (dgvLichSuNhapKho.Columns.Contains("MaNhanVien"))
                dgvLichSuNhapKho.Columns["MaNhanVien"].HeaderText = "Nhân Viên";
            if (dgvLichSuNhapKho.Columns.Contains("MaNhaCungCap"))
                dgvLichSuNhapKho.Columns["MaNhaCungCap"].Visible = false;
            if (dgvLichSuNhapKho.Columns.Contains("TenNhaCungCap"))
                dgvLichSuNhapKho.Columns["TenNhaCungCap"].HeaderText = "Nhà Cung Cấp";
            if (dgvLichSuNhapKho.Columns.Contains("SoLuongNhap"))
                dgvLichSuNhapKho.Columns["SoLuongNhap"].HeaderText = "Số Lượng Nhập";
            if (dgvLichSuNhapKho.Columns.Contains("ThoiGianNhap"))
            {
                dgvLichSuNhapKho.Columns["ThoiGianNhap"].HeaderText = "Thời Gian Nhập";
                dgvLichSuNhapKho.Columns["ThoiGianNhap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            dgvLichSuNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnNhapKho_Click(object sender, EventArgs e)
        {
            using (var dialog = new FormNhapKhoDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private async void BtnHuyPhieu_Click(object sender, EventArgs e)
        {
            if (dgvLichSuNhapKho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập trong bảng để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selectedRow = (DataRowView)dgvLichSuNhapKho.SelectedRows[0].DataBoundItem;
            if (selectedRow != null)
            {
                string maPhieu = selectedRow["MaPhieu"].ToString();
                int soLuong = Convert.ToInt32(selectedRow["SoLuongNhap"]);

                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn hủy phiếu nhập {maPhieu} (Số lượng: {soLuong}) không?",
                    "Xác nhận hủy phiếu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    btnHuyPhieu.Enabled = false;
                    btnNhapKho.Enabled = false;
                    string originalText = btnHuyPhieu.Text;
                    btnHuyPhieu.Text = "⏳ Đang xử lý...";

                    bool success = false;
                    string message = "";

                    // Chạy hủy phiếu dưới Background Thread
                    await System.Threading.Tasks.Task.Run(() =>
                    {
                        success = phieuNhapKhoBLL.HuyPhieuNhapKho(maPhieu, out message);
                    });

                    btnHuyPhieu.Text = originalText;
                    btnHuyPhieu.Enabled = true;
                    btnNhapKho.Enabled = true;

                    if (success)
                    {
                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
