using System.Data;

namespace MovieTicketBookingSystem.DAL
{
    public class RapDAL
    {
        private Database db = new Database();

        public DataTable GetAll()
        {
            string query = "EXEC sp_LayTatCaRap";
            return db.ExecuteQuery(query);
        }
    }
}
