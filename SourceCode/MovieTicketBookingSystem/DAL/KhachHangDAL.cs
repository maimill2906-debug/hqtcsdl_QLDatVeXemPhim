using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class KhachHangDAL
    {
        private Database db = new Database();

        public KhachHangDTO GetKhachHangByTenDangNhap(string username)
        {
            // Get MaTaiKhoan from TAI_KHOAN first
            string getAccQuery = "SELECT MaTaiKhoan FROM TAI_KHOAN WHERE TenDangNhap = @username";
            object[] accParam = new object[] { username };
            DataTable accDt = db.ExecuteQuery(getAccQuery, accParam);
            if (accDt.Rows.Count == 0) return null;

            string maTaiKhoan = accDt.Rows[0]["MaTaiKhoan"].ToString();

            // Execute stored procedure
            string query = "EXEC sp_LayThongTinKhachHang @MaTaiKhoan";
            object[] parameter = new object[] { maTaiKhoan };
            DataTable result = db.ExecuteQuery(query, parameter);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new KhachHangDTO
                {
                    MaKhachHang = row["MaKhachHang"].ToString(),
                    MaTaiKhoan = row["MaTaiKhoan"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    Email = row["Email"].ToString()
                };
            }

            return null;
        }
    }
}
