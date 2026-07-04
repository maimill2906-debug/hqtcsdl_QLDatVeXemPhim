using System;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class ViVoucherBLL
    {
        private ViVoucherDAL viVoucherDAL = new ViVoucherDAL();
        private KhachHangBLL khachHangBLL = new KhachHangBLL();

        // Lấy danh sách voucher trong ví của khách hàng hiện tại
        public DataTable GetVouchersByCustomer(string username)
        {
            KhachHangDTO kh = khachHangBLL.GetKhachHangByTenDangNhap(username);
            if (kh == null) return new DataTable();

            return viVoucherDAL.GetVouchersByCustomer(kh.MaKhachHang);
        }

        // Lưu voucher mới vào Database khi khách hàng săn được
        public bool AddVoucherToWallet(string maKhachHang, string maLo)
        {
            // Tự sinh mã voucher dạng: V_MaLo_Random (ví dụ: V_L001_A5C3)
            string maVoucher = "V_" + maLo + "_" + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            return viVoucherDAL.AddVoucherToWallet(maVoucher, maKhachHang, maLo);
        }
    }
}
