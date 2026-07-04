using System.Data;
using MovieTicketBookingSystem.DAL;

namespace MovieTicketBookingSystem.BLL
{
    public class DonDatVeBLL
    {
        private DonDatVeDAL donDatVeDAL = new DonDatVeDAL();

        public DataTable GetBookingHistoryByKhachHang(string maKhachHang)
        {
            if (string.IsNullOrEmpty(maKhachHang)) return new DataTable();
            return donDatVeDAL.GetBookingHistoryByKhachHang(maKhachHang);
        }
    }
}
