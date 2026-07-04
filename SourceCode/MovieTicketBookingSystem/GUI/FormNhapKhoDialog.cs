using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormNhapKhoDialog : Form
    {
        public string MaPhieu { get; private set; }
        public string MaKho { get; private set; }
        public string MaNhanVien { get; private set; }
        public string MaNhaCungCap { get; private set; }
        public int SoLuongNhap { get; private set; }

        private KhoBapNuocBLL khoBapNuocBLL = new KhoBapNuocBLL();
        private NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();

        public FormNhapKhoDialog()
        {
            InitializeComponent();
            CinemaTheme.ApplyTheme(this);
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            this.Load += FormNhapKhoDialog_Load;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
        }

        private void FormNhapKhoDialog_Load(object sender, EventArgs e)
        {
            InitializeSelections();
        }

        private void InitializeSelections()
        {
            // Load list of Rạp (Theaters)
            RapBLL rapBLL = new RapBLL();
            DataTable dtRap = rapBLL.GetAll();
            if (dtRap.Rows.Count > 0)
            {
                cboRap.DisplayMember = "TenRap";
                cboRap.ValueMember = "MaRap";
                cboRap.DataSource = dtRap;
                cboRap.SelectedIndex = 0;
            }

            // Register selected index change to filter products
            cboRap.SelectedIndexChanged += (s, e) => FilterProductsBySelectedTheater();
            FilterProductsBySelectedTheater();

            // Load suppliers (Nhà cung cấp)
            DataTable dtNcc = nhaCungCapBLL.GetAll();
            if (dtNcc.Rows.Count > 0)
            {
                cboNhaCungCap.DisplayMember = "TenNhaCungCap";
                cboNhaCungCap.ValueMember = "MaNhaCungCap";
                cboNhaCungCap.DataSource = dtNcc;
            }
            else
            {
                cboNhaCungCap.DataSource = null;
                cboNhaCungCap.Items.Clear();
                cboNhaCungCap.Items.Add("NCC01");
                cboNhaCungCap.Items.Add("NCC02");
                cboNhaCungCap.SelectedIndex = 0;
            }

            // Default logged in staff or default staff (must match MaNhanVien in NHAN_VIEN table)
            string defaultStaff = "NV001";
            if (SessionHelper.CurrentUser != null)
            {
                var db = new MovieTicketBookingSystem.DAL.Database();
                DataTable dtNhanVien = db.ExecuteQuery(
                    "SELECT MaNhanVien FROM NHAN_VIEN WHERE MaTaiKhoan = @MaTaiKhoan",
                    new object[] { SessionHelper.CurrentUser.MaTaiKhoan }
                );
                if (dtNhanVien.Rows.Count > 0)
                {
                    defaultStaff = dtNhanVien.Rows[0]["MaNhanVien"].ToString();
                }
            }
            txtMaNhanVien.Text = defaultStaff;

            // Auto-generate ticket/coupon code based on date-time to ensure uniqueness (max 10 chars)
            txtMaPhieu.Text = "PN" + DateTime.Now.ToString("ddHHmmss");
            txtMaPhieu.ReadOnly = true;
        }

        private void FilterProductsBySelectedTheater()
        {
            if (cboRap.SelectedValue != null)
            {
                string selectedRap = cboRap.SelectedValue.ToString();
                DataTable dtAllKho = khoBapNuocBLL.GetAll();
                
                // Filter rows matching selected theater (MaRap)
                DataView dv = new DataView(dtAllKho);
                dv.RowFilter = "MaRap = '" + selectedRap + "'";
                DataTable dtFiltered = dv.ToTable();

                if (dtFiltered.Rows.Count > 0)
                {
                    cboKho.DisplayMember = "TenSanPham";
                    cboKho.ValueMember = "MaKho";
                    cboKho.DataSource = dtFiltered;
                }
                else
                {
                    cboKho.DataSource = null;
                    cboKho.Items.Clear();
                }
            }
        }

        private async void BtnLuu_Click(object sender, EventArgs e)
        {
            MaPhieu = txtMaPhieu.Text.Trim();
            if (string.IsNullOrEmpty(MaPhieu))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboKho.SelectedValue != null)
                MaKho = cboKho.SelectedValue.ToString();
            else
                MaKho = cboKho.SelectedItem?.ToString() ?? "K01";

            MaNhanVien = txtMaNhanVien.Text.Trim();

            if (cboNhaCungCap.SelectedValue != null)
                MaNhaCungCap = cboNhaCungCap.SelectedValue.ToString();
            else
                MaNhaCungCap = cboNhaCungCap.SelectedItem?.ToString() ?? "NCC01";

            SoLuongNhap = (int)nudSoLuongNhap.Value;

            if (SoLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khóa nút bấm và hiển thị trạng thái đang xử lý
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            string originalText = btnLuu.Text;
            btnLuu.Text = "⏳ Đang xử lý (8s)...";

            // Tự động đổi chữ nút Lưu sang "Vui lòng chờ..." sau 5 giây nếu giao dịch bị kẹt dưới DB
            var textUpdateTask = System.Threading.Tasks.Task.Delay(5000).ContinueWith(t => {
                try {
                    this.Invoke((MethodInvoker)delegate {
                        if (!btnLuu.Enabled) // Giao dịch vẫn đang chạy
                        {
                            btnLuu.Text = "⏳ Vui lòng chờ...";
                        }
                    });
                } catch { }
            });

            PhieuNhapKhoDTO newItem = new PhieuNhapKhoDTO
            {
                MaPhieu = MaPhieu,
                MaKho = MaKho,
                MaNhanVien = MaNhanVien,
                MaNhaCungCap = MaNhaCungCap,
                SoLuongNhap = SoLuongNhap,
                ThoiGianNhap = DateTime.Now
            };

            string message = "";
            bool success = false;

            // Thực thi lưu dữ liệu bất đồng bộ dưới background thread
            await System.Threading.Tasks.Task.Run(() =>
            {
                PhieuNhapKhoBLL phieuNhapKhoBLL = new PhieuNhapKhoBLL();
                success = phieuNhapKhoBLL.NhapKho(newItem, out message);
            });

            if (success)
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLuu.Text = originalText;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }
    }
}
