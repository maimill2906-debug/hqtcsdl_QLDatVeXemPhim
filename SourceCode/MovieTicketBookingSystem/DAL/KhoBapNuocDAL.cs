using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class KhoBapNuocDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "EXEC sp_LayDanhSachKho";
            return db.ExecuteQuery(query);
        }

        public bool Insert(KhoBapNuocDTO item)
        {
            string query = "EXEC sp_LuuSanPhamKho @MaKho , @MaRap , @TenSanPham , @SoLuongHienCo , @SucChuaToiDa";
            object[] parameter = new object[]
            {
                item.MaKho,
                item.MaRap,
                item.TenSanPham,
                item.SoLuongHienCo,
                item.SucChuaToiDa
            };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool Update(KhoBapNuocDTO item)
        {
            string query = "EXEC sp_LuuSanPhamKho @MaKho , @MaRap , @TenSanPham , @SoLuongHienCo , @SucChuaToiDa";
            object[] parameter = new object[]
            {
                item.MaKho,
                item.MaRap,
                item.TenSanPham,
                item.SoLuongHienCo,
                item.SucChuaToiDa
            };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool Delete(string maKho)
        {
            string query = "DELETE FROM KHO_BAP_NUOC WHERE MaKho = @maKho";
            object[] parameter = new object[] { maKho };
            return db.ExecuteNonQuery(query, parameter) > 0;
        }

        public DataTable Search(string keyword)
        {
            string query = "SELECT MaKho, MaRap, TenSanPham, SoLuongHienCo, SucChuaToiDa " +
                           "FROM KHO_BAP_NUOC " +
                           "WHERE TenSanPham LIKE @keyword OR MaKho LIKE @keyword";
            object[] parameter = new object[] { "%" + keyword + "%" };
            return db.ExecuteQuery(query, parameter);
        }

        public KhoBapNuocDTO GetById(string maKho)
        {
            string query = "EXEC sp_LayKhoTheoId @MaKho";
            object[] parameter = new object[] { maKho };
            DataTable dt = db.ExecuteQuery(query, parameter);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new KhoBapNuocDTO
                {
                    MaKho = row["MaKho"].ToString(),
                    MaRap = row["MaRap"].ToString(),
                    TenSanPham = row["TenSanPham"].ToString(),
                    SoLuongHienCo = Convert.ToInt32(row["SoLuongHienCo"]),
                    SucChuaToiDa = Convert.ToInt32(row["SucChuaToiDa"])
                };
            }

            return null;
        }
    }
}
