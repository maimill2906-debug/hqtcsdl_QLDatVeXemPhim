using System.Data;
using MovieTicketBookingSystem.DAL;

namespace MovieTicketBookingSystem.BLL
{
    public class RapBLL
    {
        private RapDAL rapDAL = new RapDAL();

        public DataTable GetAll()
        {
            return rapDAL.GetAll();
        }
    }
}
