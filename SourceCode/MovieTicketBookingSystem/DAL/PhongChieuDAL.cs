using System.Data;

namespace MovieTicketBookingSystem.DAL
{
    public class PhongChieuDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "EXEC sp_LayTatCaPhong";
            return db.ExecuteQuery(query);
        }
    }
}
