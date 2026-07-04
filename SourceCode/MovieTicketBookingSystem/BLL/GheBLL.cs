using System.Data;
using MovieTicketBookingSystem.DAL;

namespace MovieTicketBookingSystem.BLL
{
    public class GheBLL
    {
        private GheDAL gheDAL = new GheDAL();

        public DataTable GetGheByPhong(string maPhong)
        {
            if (string.IsNullOrEmpty(maPhong)) return new DataTable();
            return gheDAL.GetGheByPhong(maPhong);
        }
    }
}
