using System.Data;
using MovieTicketBookingSystem.DAL;

namespace MovieTicketBookingSystem.BLL
{
    public class PhongChieuBLL
    {
        private PhongChieuDAL phongChieuDAL = new PhongChieuDAL();

        public DataTable GetAll()
        {
            return phongChieuDAL.GetAll();
        }
    }
}
