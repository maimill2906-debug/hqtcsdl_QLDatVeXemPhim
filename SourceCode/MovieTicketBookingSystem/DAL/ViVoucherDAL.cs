using System;
using System.Data;

namespace MovieTicketBookingSystem.DAL
{
    public class ViVoucherDAL
    {
        private Database db = new Database();

        // Lấy danh sách voucher trong ví của khách hàng từ View vw_ViVoucher
        public DataTable GetVouchersByCustomer(string maKhachHang)
        {
            string query = "SELECT * FROM vw_ViVoucher WHERE MaKhachHang = @MaKhachHang";
            object[] parameter = new object[] { maKhachHang };
            return db.ExecuteQuery(query, parameter);
        }

        // Lưu voucher mới vào Database khi khách hàng săn được
        public bool AddVoucherToWallet(string maVoucher, string maKhachHang, string maLo)
        {
            string query = "INSERT INTO VI_VOUCHER (MaVoucher, MaKhachHang, MaLo, NgaySan, TrangThai) " +
                           "VALUES ( @MaVoucher , @MaKhachHang , @MaLo , GETDATE() , N'Chưa sử dụng' )";
            object[] parameters = new object[] { maVoucher, maKhachHang, maLo };
            return db.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
