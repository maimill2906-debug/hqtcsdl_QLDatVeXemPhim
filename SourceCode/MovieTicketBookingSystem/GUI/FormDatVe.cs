using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MovieTicketBookingSystem.BLL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.GUI
{
    public partial class FormDatVe : Form
    {
        private string maSuatChieu;
        private string maPhong;
        private string movieName;
        private List<string> selectedSeats = new List<string>(); // Stores selected MaGhe
        private List<string> selectedSeatNames = new List<string>(); // Stores selected SoGhe
        private int ticketPrice = 80000; // Dynamic price

        private GheBLL gheBLL = new GheBLL();
        private VeBLL veBLL = new VeBLL();
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        public FormDatVe()
        {
            InitializeComponent();
            ApplyCinemaTheme();
        }

        private decimal appliedDiscount = 0;
        private string appliedVoucherCode = "";

        public FormDatVe(string maSuatChieu, string maPhong) : this()
        {
            this.maSuatChieu = maSuatChieu;
            this.maPhong = maPhong;

            // Lấy thông tin phim từ suất chiếu
            SuatChieuBLL suatChieuBLL = new SuatChieuBLL();
            DataTable dtSC = suatChieuBLL.GetAll();
            string searchMovieName = "Phim";
            foreach (DataRow row in dtSC.Rows)
            {
                if (row["MaSuatChieu"].ToString() == maSuatChieu)
                {
                    searchMovieName = row["TenPhim"].ToString();
                    DateTime dateVal = Convert.ToDateTime(row["NgayChieu"]);
                    lblSuatChieuSelected.Text = $"Suất chiếu: {maSuatChieu} ({row["GioBatDau"]} - {dateVal.ToString("dd/MM/yyyy")})";
                    break;
                }
            }
            this.movieName = searchMovieName;
            lblTenPhimSelected.Text = "Phim: " + this.movieName;

            // Đóng băng bảng trái (dgvSuatChieu) bằng cách ẩn pnlLeft đi để sơ đồ ghế chiếm trọn diện tích rộng rãi
            pnlLeft.Visible = false;

            RegisterEvents();
            GenerateSeats(maSuatChieu, maPhong);
            LoadVouchersForShowtime();
        }

        private void RegisterEvents()
        {
            btnXacNhanDatVe.Click += BtnXacNhanDatVe_Click;
            cboVoucher.SelectedIndexChanged += CboVoucher_SelectedIndexChanged;
        }

        private void LoadVouchersForShowtime()
        {
            try
            {
                cboVoucher.Items.Clear();
                cboVoucher.Items.Add(new { Text = "-- Không sử dụng Voucher --", Value = "", Discount = 0m });

                if (SessionHelper.CurrentUser != null)
                {
                    ViVoucherBLL viBLL = new ViVoucherBLL();
                    DataTable dt = viBLL.GetVouchersByCustomer(SessionHelper.CurrentUser.TenDangNhap);

                    foreach (DataRow row in dt.Rows)
                    {
                        // Kiểm tra: 
                        // 1. Voucher đó phải thuộc suất chiếu hiện tại (thông qua phim và giờ chiếu của View vw_ViVoucher)
                        // 2. Trạng thái của voucher phải là "Chưa sử dụng"
                        if (row["PhimDuocApDung"].ToString() == this.movieName &&
                            row["TrangThaiSuDung"].ToString().Trim() == "Chưa sử dụng")
                        {
                            // Kiểm tra thời hạn: Chỉ được dùng khi suất chiếu chưa bắt đầu
                            // Lấy thông tin suất chiếu từ DB
                            SuatChieuBLL scBLL = new SuatChieuBLL();
                            DataTable dtSC = scBLL.GetAll();
                            DataRow showtimeRow = null;
                            foreach (DataRow r in dtSC.Rows)
                            {
                                if (r["MaSuatChieu"].ToString() == this.maSuatChieu)
                                {
                                    showtimeRow = r;
                                    break;
                                }
                            }

                            if (showtimeRow != null)
                            {
                                DateTime dateVal = Convert.ToDateTime(showtimeRow["NgayChieu"]);
                                TimeSpan timeVal = (TimeSpan)showtimeRow["GioBatDau"];
                                DateTime showtimeStart = dateVal.Date + timeVal;

                                // Nếu thời gian hiện tại của máy tính bé hơn giờ bắt đầu của suất chiếu thì mới cho dùng
                                if (DateTime.Now < showtimeStart)
                                {
                                    string voucherCode = row["MaVoucher"].ToString();
                                    decimal discount = Convert.ToDecimal(row["MucGiamGia"]);
                                    cboVoucher.Items.Add(new { Text = $"{voucherCode} (Giảm: {discount:N0} đ)", Value = voucherCode, Discount = discount });
                                }
                            }
                        }
                    }
                }

                cboVoucher.DisplayMember = "Text";
                cboVoucher.ValueMember = "Value";
                cboVoucher.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách voucher: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVoucher.SelectedItem != null)
            {
                // Sử dụng Reflection để lấy thuộc tính từ đối tượng nặc danh (Anonymous Type)
                var item = cboVoucher.SelectedItem;
                var valueProp = item.GetType().GetProperty("Value");
                var discountProp = item.GetType().GetProperty("Discount");

                appliedVoucherCode = valueProp != null ? valueProp.GetValue(item, null)?.ToString() : "";
                appliedDiscount = discountProp != null ? (decimal)discountProp.GetValue(item, null) : 0m;
            }
            else
            {
                appliedVoucherCode = "";
                appliedDiscount = 0;
            }
            UpdateBillInfo();
        }

        private void GenerateSeats(string maSuatChieu, string maPhong)
        {
            flpSoDoGhe.Controls.Clear();

            // Load all seats in this room
            DataTable dtGhe = gheBLL.GetGheByPhong(maPhong);

            // Load booked seats for this showtime
            DataTable dtVe = veBLL.GetBookedSeats(maSuatChieu);
            HashSet<string> bookedGheIds = new HashSet<string>();
            foreach (DataRow row in dtVe.Rows)
            {
                bookedGheIds.Add(row["MaGhe"].ToString());
            }

            foreach (DataRow rowGhe in dtGhe.Rows)
            {
                string maGhe = rowGhe["MaGhe"].ToString();
                string soGhe = rowGhe["SoGhe"].ToString();

                Button btnSeat = new Button();
                btnSeat.Size = new Size(50, 42); // Tăng kích thước nút ghế cho to, rõ ràng và cực kỳ dễ click
                btnSeat.Text = soGhe;
                btnSeat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btnSeat.FlatStyle = FlatStyle.Flat;
                btnSeat.FlatAppearance.BorderSize = 0;
                btnSeat.Margin = new Padding(6);
                btnSeat.Cursor = Cursors.Hand;

                if (bookedGheIds.Contains(maGhe))
                {
                    // Booked (Red)
                    btnSeat.BackColor = Color.FromArgb(214, 48, 49);
                    btnSeat.ForeColor = Color.White;
                    btnSeat.Enabled = false;
                }
                else
                {
                    // Available (Blue)
                    btnSeat.BackColor = Color.FromArgb(9, 132, 227);
                    btnSeat.ForeColor = Color.White;
                    btnSeat.Click += (s, ev) => Seat_Click(btnSeat, maGhe, soGhe);
                }

                flpSoDoGhe.Controls.Add(btnSeat);
            }
        }

        private void Seat_Click(Button btnSeat, string maGhe, string soGhe)
        {
            if (selectedSeats.Contains(maGhe))
            {
                // Toggle back to available (Blue)
                selectedSeats.Remove(maGhe);
                selectedSeatNames.Remove(soGhe);
                btnSeat.BackColor = Color.FromArgb(9, 132, 227);
            }
            else
            {
                // Toggle to selecting (Yellow)
                selectedSeats.Add(maGhe);
                selectedSeatNames.Add(soGhe);
                btnSeat.BackColor = Color.FromArgb(253, 203, 110);
            }

            UpdateBillInfo();
        }

        private void UpdateBillInfo()
        {
            if (selectedSeats.Count > 0)
            {
                lblGheDaChon.Text = string.Join(", ", selectedSeatNames);
                long baseTotal = selectedSeats.Count * ticketPrice;
                
                // Áp dụng giảm giá voucher trực tiếp
                long discountAmount = (long)appliedDiscount;
                long total = Math.Max(0, baseTotal - discountAmount);

                if (discountAmount > 0)
                {
                    lblPriceInfo.Text = $"Tổng: {total:N0} VND (Đã giảm: {discountAmount:N0}đ)";
                }
                else
                {
                    lblPriceInfo.Text = $"Tổng tiền: {total:N0} VND";
                }
            }
            else
            {
                lblGheDaChon.Text = "(Chưa chọn)";
                lblPriceInfo.Text = "Tổng tiền: 0 VND";
            }
        }

        private async void BtnXacNhanDatVe_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí ghế ngồi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find current customer ID
            string maKhachHang = "KH01"; // Fallback default
            if (SessionHelper.CurrentUser != null)
            {
                KhachHangDTO kh = khachHangBLL.GetKhachHangByTenDangNhap(SessionHelper.CurrentUser.TenDangNhap);
                if (kh != null)
                {
                    maKhachHang = kh.MaKhachHang;
                }
            }

            long baseTotal = selectedSeats.Count * ticketPrice;
            long finalTotal = Math.Max(0, baseTotal - (long)appliedDiscount);

            // Khóa nút bấm và đổi chữ hiển thị trạng thái đang xử lý
            btnXacNhanDatVe.Enabled = false;
            string originalText = btnXacNhanDatVe.Text;
            btnXacNhanDatVe.Text = "⏳ Đang xử lý (8s)...";

            try
            {
                // Call stored procedure to purchase tickets
                string message = "";
                bool result = await System.Threading.Tasks.Task.Run(() => 
                {
                    return veBLL.DatVe(maKhachHang, maSuatChieu, selectedSeats, (decimal)finalTotal / selectedSeats.Count, out message);
                });

                if (result)
                {
                    // Nếu có áp dụng voucher thành công -> Cập nhật trạng thái voucher thành "Đã sử dụng" trong Database
                    if (!string.IsNullOrEmpty(appliedVoucherCode))
                    {
                        await System.Threading.Tasks.Task.Run(() =>
                        {
                            try
                            {
                                MovieTicketBookingSystem.DAL.Database db = new MovieTicketBookingSystem.DAL.Database();
                                string query = "UPDATE VI_VOUCHER SET TrangThai = N'Đã sử dụng' WHERE MaVoucher = @maVoucher";
                                db.ExecuteNonQuery(query, new object[] { appliedVoucherCode });
                            }
                            catch { }
                        });
                    }

                    MessageBox.Show("Đặt vé thành công! Bạn có thể xem vé trong mục Lịch Sử Vé.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Reload seats and vouchers status
                    GenerateSeats(maSuatChieu, maPhong);
                    selectedSeats.Clear();
                    selectedSeatNames.Clear();
                    UpdateBillInfo();
                    LoadVouchersForShowtime();
                }
                else
                {
                    MessageBox.Show("Đặt vé thất bại! " + message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (message.Contains("tạm ngưng") || message.Contains("hủy bỏ"))
                    {
                        // Đóng form đặt vé
                        this.Close();
                        
                        // Chuyển hướng người dùng về màn hình chọn phim để tải lại toàn bộ danh sách mới nhất
                        FormMainCustomer mainForm = Application.OpenForms["FormMainCustomer"] as FormMainCustomer;
                        if (mainForm != null)
                        {
                            mainForm.LoadMovieSelectionForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (ex.Message.Contains("tạm ngưng") || ex.Message.Contains("hủy bỏ"))
                {
                    // Đóng form đặt vé
                    this.Close();
                    
                    // Chuyển hướng người dùng về màn hình chọn phim để tải lại toàn bộ danh sách mới nhất
                    FormMainCustomer mainForm = Application.OpenForms["FormMainCustomer"] as FormMainCustomer;
                    if (mainForm != null)
                    {
                        mainForm.LoadMovieSelectionForm();
                    }
                }
                else
                {
                    // Reload seats status in case of conflicts (locked seats)
                    GenerateSeats(maSuatChieu, maPhong);
                    selectedSeats.Clear();
                    selectedSeatNames.Clear();
                    UpdateBillInfo();
                }
            }
            finally
            {
                // Phục hồi lại trạng thái nút bấm
                btnXacNhanDatVe.Text = originalText;
                btnXacNhanDatVe.Enabled = true;
            }
        }

        private void ApplyCinemaTheme()
        {
            this.BackColor = CinemaTheme.LightGray;
            this.ForeColor = CinemaTheme.TextColor;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        }
    }
}
