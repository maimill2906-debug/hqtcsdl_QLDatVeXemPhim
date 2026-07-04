using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class VeDAL
    {
        private Database db = new Database();

        public DataTable GetBookedSeats(string maSuatChieu)
        {
            string query = "SELECT MaGhe FROM VE WHERE MaSuatChieu = @maSuatChieu AND TrangThai != N'Đã hủy'";
            object[] parameter = new object[] { maSuatChieu };
            return db.ExecuteQuery(query, parameter);
        }

        public bool ThucHienDatVe(string maDatVe, string maKhachHang, string maSuatChieu, decimal tongTien, string danhSachGhe)
        {
            string query = "EXEC sp_DatVeXemPhim @MaDatVe , @MaKhachHang , @MaSuatChieu , @TongTien , @DanhSachGhe";
            object[] parameter = new object[]
            {
                maDatVe,
                maKhachHang,
                maSuatChieu,
                tongTien,
                danhSachGhe
            };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
