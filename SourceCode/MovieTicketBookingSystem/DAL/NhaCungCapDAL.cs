using System.Data;

namespace MovieTicketBookingSystem.DAL
{
    public class NhaCungCapDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "EXEC sp_LayTatCaNhaCungCap";
            return db.ExecuteQuery(query);
        }
    }
}
