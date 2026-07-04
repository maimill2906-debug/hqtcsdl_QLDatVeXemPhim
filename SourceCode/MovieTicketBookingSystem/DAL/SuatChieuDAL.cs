using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class SuatChieuDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "EXEC sp_LayTatCaSuatChieu";
            return db.ExecuteQuery(query);
        }

        public bool Insert(SuatChieuDTO sc)
        {
            string query = "EXEC sp_ThemSuatChieu @MaSuatChieu , @MaPhim , @MaPhong , @NgayChieu , @GioBatDau , @GioKetThuc , @TrangThai";
            object[] parameter = new object[] 
            { 
                sc.MaSuatChieu, 
                sc.MaPhim, 
                sc.MaPhong, 
                sc.NgayChieu.ToString("yyyy-MM-dd"), 
                sc.GioBatDau.ToString(@"hh\:mm\:ss"), 
                sc.GioKetThuc.ToString(@"hh\:mm\:ss"), 
                sc.TrangThai 
            };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool Update(SuatChieuDTO sc)
        {
            string query = "EXEC sp_CapNhatSuatChieu @MaSuatChieu , @MaPhim , @MaPhong , @NgayChieu , @GioBatDau , @GioKetThuc , @TrangThai";
            object[] parameter = new object[] 
            { 
                sc.MaSuatChieu, 
                sc.MaPhim, 
                sc.MaPhong, 
                sc.NgayChieu.ToString("yyyy-MM-dd"), 
                sc.GioBatDau.ToString(@"hh\:mm\:ss"), 
                sc.GioKetThuc.ToString(@"hh\:mm\:ss"), 
                sc.TrangThai 
            };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool Delete(string maSuatChieu)
        {
            string query = "EXEC sp_XoaSuatChieu @MaSuatChieu";
            object[] parameter = new object[] { maSuatChieu };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public DataTable Search(string keyword)
        {
            string query = "SELECT MaSuatChieu, MaPhim, TenPhim, MaPhong, TenPhong, NgayChieu, GioBatDau, GioKetThuc, TrangThai " +
                           "FROM vw_DanhSachSuatChieu " +
                           "WHERE TenPhim LIKE @keyword OR TenPhong LIKE @keyword OR MaSuatChieu LIKE @keyword";
            object[] parameter = new object[] { "%" + keyword + "%" };
            return db.ExecuteQuery(query, parameter);
        }

        public DataTable GetShowtimesByMovie(string maPhim)
        {
            string query = "SELECT MaSuatChieu, MaPhim, TenPhim, MaPhong, TenPhong, MaRap, TenRap, NgayChieu, GioBatDau, GioKetThuc, TrangThai " +
                           "FROM vw_DanhSachSuatChieu " +
                           "WHERE MaPhim = @maPhim";
            object[] parameter = new object[] { maPhim };
            return db.ExecuteQuery(query, parameter);
        }

        public SuatChieuDTO GetById(string maSuatChieu)
        {
            string query = "SELECT MaSuatChieu, MaPhim, MaPhong, NgayChieu, GioBatDau, GioKetThuc, TrangThai " +
                           "FROM vw_DanhSachSuatChieu " +
                           "WHERE MaSuatChieu = @maSuatChieu";
            object[] parameter = new object[] { maSuatChieu };
            DataTable result = db.ExecuteQuery(query, parameter);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new SuatChieuDTO
                {
                    MaSuatChieu = row["MaSuatChieu"].ToString(),
                    MaPhim = row["MaPhim"].ToString(),
                    MaPhong = row["MaPhong"].ToString(),
                    NgayChieu = Convert.ToDateTime(row["NgayChieu"]),
                    GioBatDau = (TimeSpan)row["GioBatDau"],
                    GioKetThuc = (TimeSpan)row["GioKetThuc"],
                    TrangThai = row["TrangThai"].ToString()
                };
            }

            return null;
        }

        public string GetNextMaSuatChieu()
        {
            DataTable dt = GetAll();
            int maxId = 0;
            foreach (DataRow row in dt.Rows)
            {
                string maSuatChieu = row["MaSuatChieu"].ToString().Trim();
                if (maSuatChieu.StartsWith("SC"))
                {
                    int id;
                    if (int.TryParse(maSuatChieu.Substring(2), out id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            return "SC" + (maxId + 1).ToString("D3");
        }
    }
}
