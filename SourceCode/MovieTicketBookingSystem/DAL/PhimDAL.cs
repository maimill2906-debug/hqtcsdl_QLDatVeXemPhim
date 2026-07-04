using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class PhimDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "EXEC sp_LayTatCaPhim";
            return db.ExecuteQuery(query);
        }

        public bool Insert(PhimDTO phim)
        {
            string query = "EXEC sp_ThemPhim @MaPhim , @MaTheLoai , @TenPhim , @ThoiLuong , @MoTa , @AnhPoster";
            object[] parameter = new object[] { phim.MaPhim, phim.MaTheLoai, phim.TenPhim, phim.ThoiLuong, phim.MoTa ?? "", phim.AnhPoster ?? "" };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool Update(PhimDTO phim)
        {
            string query = "EXEC sp_LuuPhim @MaPhim , @TenPhim , @ThoiLuong , @MaTheLoai , @MoTa , @AnhPoster";
            object[] parameter = new object[] { phim.MaPhim, phim.TenPhim, phim.ThoiLuong, phim.MaTheLoai, phim.MoTa ?? "", phim.AnhPoster ?? "" };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool Delete(string maPhim)
        {
            string query = "EXEC sp_XoaPhim @MaPhim";
            object[] parameter = new object[] { maPhim };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public DataTable Search(string keyword)
        {
            string query = "SELECT * FROM vw_DanhSachPhim WHERE TenPhim LIKE @keyword";
            object[] parameter = new object[] { "%" + keyword + "%" };
            return db.ExecuteQuery(query, parameter);
        }

        public DataTable GetByTheLoai(string maTheLoai, bool skipDelay = false)
        {
            string query = "EXEC sp_LocPhim @maTheLoai , @skipDelay";
            object[] parameter = new object[] { maTheLoai, skipDelay ? 1 : 0 };
            return db.ExecuteQuery(query, parameter);
        }

        public DataSet GetByTheLoaiDataSet(string maTheLoai, bool skipDelay = false)
        {
            string query = "EXEC sp_LocPhim @maTheLoai , @skipDelay";
            object[] parameter = new object[] { maTheLoai, skipDelay ? 1 : 0 };
            return db.ExecuteQueryDataSet(query, parameter);
        }

        public PhimDTO GetById(string maPhim)
        {
            string query = "SELECT * FROM vw_DanhSachPhim WHERE MaPhim = @maPhim";
            object[] parameter = new object[] { maPhim };
            DataTable result = db.ExecuteQuery(query, parameter);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new PhimDTO
                {
                    MaPhim = row["MaPhim"].ToString(),
                    TenPhim = row["TenPhim"].ToString(),
                    ThoiLuong = Convert.ToInt32(row["ThoiLuong"]),
                    MaTheLoai = row["MaTheLoai"].ToString(),
                    MoTa = row["MoTa"].ToString(),
                    AnhPoster = row.Table.Columns.Contains("AnhPoster") ? row["AnhPoster"].ToString() : ""
                };
            }

            return null;
        }

        public string GetNextMaPhim()
        {
            DataTable dt = GetAll();
            int maxId = 0;
            foreach (DataRow row in dt.Rows)
            {
                string maPhim = row["MaPhim"].ToString().Trim();
                if (maPhim.StartsWith("PH"))
                {
                    int id;
                    if (int.TryParse(maPhim.Substring(2), out id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            return "PH" + (maxId + 1).ToString("D3");
        }
    }
}
