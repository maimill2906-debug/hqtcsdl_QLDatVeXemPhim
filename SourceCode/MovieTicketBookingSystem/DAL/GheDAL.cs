using System.Data;

namespace MovieTicketBookingSystem.DAL
{
    public class GheDAL
    {
        private Database db = new Database();

        public DataTable GetGheByPhong(string maPhong)
        {
            string query = "SELECT MaGhe, MaPhong, SoGhe, LoaiGhe FROM GHE WHERE MaPhong = @maPhong";
            object[] parameter = new object[] { maPhong };
            return db.ExecuteQuery(query, parameter);
        }
    }
}
