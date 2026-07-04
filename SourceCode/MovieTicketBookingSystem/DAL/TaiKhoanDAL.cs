using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class TaiKhoanDAL
    {
        private Database db = new Database();

        public TaiKhoanDTO DangNhap(string username, string password)
        {
            string query = "EXEC sp_DangNhap @TenDangNhap , @MatKhau";
            object[] parameter = new object[] { username, password };
            DataTable result = db.ExecuteQuery(query, parameter);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new TaiKhoanDTO
                {
                    MaTaiKhoan = row["MaTaiKhoan"].ToString(),
                    TenDangNhap = row["TenDangNhap"].ToString(),
                    MatKhau = row["MatKhau"].ToString(),
                    VaiTro = row["VaiTro"].ToString(),
                    TrangThai = row["TrangThai"].ToString()
                };
            }

            return null;
        }
    }
}
