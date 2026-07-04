using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class PhieuNhapKhoDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "SELECT MaPhieu, MaKho, TenSanPhamKho AS TenSanPham, MaNhanVien, MaNhaCungCap, TenNhaCungCap, SoLuongNhap, ThoiGianNhap FROM vw_LichSuNhapKho";
            return db.ExecuteQuery(query);
        }

        public bool ThucHienNhapKho(PhieuNhapKhoDTO p)
        {
            string query = "EXEC sp_NhapKho @MaPhieu , @MaKho , @MaNhanVien , @MaNhaCungCap , @SoLuongNhap";
            object[] parameter = new object[]
            {
                p.MaPhieu,
                p.MaKho,
                p.MaNhanVien,
                p.MaNhaCungCap,
                p.SoLuongNhap
            };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool HuyPhieuNhapKho(string maPhieu)
        {
            string query = "EXEC sp_HuyNhapKho @MaPhieu";
            object[] parameter = new object[] { maPhieu };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public PhieuNhapKhoDTO GetById(string maPhieu)
        {
            string query = "SELECT MaPhieu, MaKho, MaNhanVien, MaNhaCungCap, SoLuongNhap, ThoiGianNhap FROM PHIEU_NHAP_KHO WHERE MaPhieu = @maPhieu";
            object[] parameter = new object[] { maPhieu };
            DataTable dt = db.ExecuteQuery(query, parameter);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new PhieuNhapKhoDTO
                {
                    MaPhieu = row["MaPhieu"].ToString(),
                    MaKho = row["MaKho"].ToString(),
                    MaNhanVien = row["MaNhanVien"].ToString(),
                    MaNhaCungCap = row["MaNhaCungCap"].ToString(),
                    SoLuongNhap = Convert.ToInt32(row["SoLuongNhap"]),
                    ThoiGianNhap = Convert.ToDateTime(row["ThoiGianNhap"])
                };
            }

            return null;
        }
    }
}
