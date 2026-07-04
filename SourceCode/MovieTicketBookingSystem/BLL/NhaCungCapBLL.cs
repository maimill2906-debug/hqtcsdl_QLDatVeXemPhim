using System.Data;
using MovieTicketBookingSystem.DAL;

namespace MovieTicketBookingSystem.BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL nhaCungCapDAL = new NhaCungCapDAL();

        public DataTable GetAll()
        {
            return nhaCungCapDAL.GetAll();
        }
    }
}
