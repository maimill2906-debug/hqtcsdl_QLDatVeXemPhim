using System;

namespace MovieTicketBookingSystem.DTO
{
    public class PhieuNhapKhoDTO
    {
        public string MaPhieu { get; set; }
        public string MaKho { get; set; }
        public string MaNhanVien { get; set; }
        public string MaNhaCungCap { get; set; }
        public int SoLuongNhap { get; set; }
        public DateTime ThoiGianNhap { get; set; }
    }
}
