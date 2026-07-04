using System;
using System.Data;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.DAL
{
    public class TheLoaiDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "EXEC sp_LayTatCaTheLoai";
            return db.ExecuteQuery(query);
        }

        public bool Insert(TheLoaiDTO theLoai)
        {
            string query = "EXEC sp_LuuTheLoai @MaTheLoai , @TenTheLoai";
            object[] parameter = new object[] { theLoai.MaTheLoai, theLoai.TenTheLoai };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool Update(TheLoaiDTO theLoai)
        {
            string query = "EXEC sp_LuuTheLoai @MaTheLoai , @TenTheLoai";
            object[] parameter = new object[] { theLoai.MaTheLoai, theLoai.TenTheLoai };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool Delete(string maTheLoai)
        {
            string query = "EXEC sp_XoaTheLoai @MaTheLoai";
            object[] parameter = new object[] { maTheLoai };
            int result = db.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public DataTable Search(string keyword)
        {
            string query = "SELECT MaTheLoai, TenTheLoai FROM THE_LOAI WHERE TenTheLoai LIKE @tenTheLoai";
            object[] parameter = new object[] { "%" + keyword + "%" };
            return db.ExecuteQuery(query, parameter);
        }

        public string GetNextMaTheLoai()
        {
            DataTable dt = GetAll();
            int maxId = 0;
            foreach (DataRow row in dt.Rows)
            {
                string maTheLoai = row["MaTheLoai"].ToString().Trim();
                if (maTheLoai.StartsWith("TL"))
                {
                    int id;
                    if (int.TryParse(maTheLoai.Substring(2), out id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            return "TL" + (maxId + 1).ToString("D2");
        }
    }
}
