using System;

namespace MovieTicketBookingSystem.DTO
{
    public class ViVoucherDTO
    {
        public string MaVoucher { get; set; }
        public string MaKhachHang { get; set; }
        public string MaLo { get; set; }
        public DateTime NgaySan { get; set; }
        public string TrangThai { get; set; } = "Chưa sử dụng";
    }
}
