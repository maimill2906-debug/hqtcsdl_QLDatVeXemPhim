using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        public KhachHangDTO GetKhachHangByTenDangNhap(string username)
        {
            if (string.IsNullOrEmpty(username)) return null;
            return khachHangDAL.GetKhachHangByTenDangNhap(username);
        }
    }
}
