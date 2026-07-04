using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class LoVoucherGioVangDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "SELECT MaLo, MaSuatChieu, TenPhim, SoVeKhuyenMaiConLai AS SoLuong, GiaKhuyenMai AS GiaGiam, KinhPhiToiDa, TrangThaiLoVe AS TrangThai FROM vw_LoVoucherGioVang";
            return db.ExecuteQuery(query);
        }

        public DataTable GetActiveCampaigns()
        {
            string query = "EXEC sp_LayVoucherKichHoat";
            return db.ExecuteQuery(query);
        }

        public bool Insert(LoVoucherGioVangDTO lo)
        {
            string query = "EXEC sp_TaoLoVoucher @MaLo , @MaSuatChieu , @SoLuong , @GiaGiam , @KinhPhiToiDa";
            object[] parameter = new object[]
            {
                lo.MaLo,
                lo.MaSuatChieu,
                lo.SoLuong,
                lo.GiaGiam,
                lo.KinhPhiToiDa
            };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool Update(LoVoucherGioVangDTO lo)
        {
            string query = "EXEC sp_TaoLoVoucher  @MaLo , @MaSuatChieu , @SoLuong , @GiaGiam , @KinhPhiToiDa";
            object[] parameter = new object[]
            {
                lo.MaLo,
                lo.MaSuatChieu,
                lo.SoLuong,
                lo.GiaGiam,
                lo.KinhPhiToiDa
            };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool Delete(string maLo)
        {
            string query = "DELETE FROM LO_VOUCHER_GIO_VANG WHERE MaLo = @maLo";
            object[] parameter = new object[] { maLo };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public LoVoucherGioVangDTO GetById(string maLo)
        {
            string query = "SELECT MaLo, MaSuatChieu, SoLuong, GiaGiam, KinhPhiToiDa, TrangThai FROM LO_VOUCHER_GIO_VANG WHERE MaLo = @maLo";
            object[] parameter = new object[] { maLo };
            DataTable dt = db.ExecuteQuery(query, parameter);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new LoVoucherGioVangDTO
                {
                    MaLo = row["MaLo"].ToString(),
                    MaSuatChieu = row["MaSuatChieu"].ToString(),
                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                    GiaGiam = Convert.ToDecimal(row["GiaGiam"]),
                    KinhPhiToiDa = Convert.ToDecimal(row["KinhPhiToiDa"]),
                    TrangThai = row["TrangThai"].ToString()
                };
            }

            return null;
        }

        public bool SanVoucher(string maLo, string maKH)
        {
            string query = "EXEC sp_SanVoucher @MaLo , @MaKhachHang";
            object[] parameter = new object[] { maLo, maKH };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
