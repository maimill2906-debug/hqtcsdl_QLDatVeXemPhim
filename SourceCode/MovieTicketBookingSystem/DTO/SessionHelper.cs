using System.Collections.Generic;

namespace MovieTicketBookingSystem.DTO
{
    public static class SessionHelper
    {
        public static TaiKhoanDTO CurrentUser { get; set; }
        public static List<ViVoucherDTO> ClaimedVouchers { get; set; } = new List<ViVoucherDTO>();
    }
}
