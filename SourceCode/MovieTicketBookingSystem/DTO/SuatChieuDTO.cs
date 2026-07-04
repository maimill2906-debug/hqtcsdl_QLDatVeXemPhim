using System;

namespace MovieTicketBookingSystem.DTO
{
    public class SuatChieuDTO
    {
        public string MaSuatChieu { get; set; }
        public string MaPhong { get; set; }
        public string MaPhim { get; set; }
        public DateTime NgayChieu { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public string TrangThai { get; set; }
    }
}
