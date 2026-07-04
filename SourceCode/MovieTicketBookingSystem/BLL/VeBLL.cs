using System;
using System.Collections.Generic;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class VeBLL
    {
        private VeDAL veDAL = new VeDAL();

        public DataTable GetBookedSeats(string maSuatChieu)
        {
            if (string.IsNullOrEmpty(maSuatChieu)) return new DataTable();
            return veDAL.GetBookedSeats(maSuatChieu);
        }

        public bool DatVe(string maKhachHang, string maSuatChieu, List<string> maGheList, decimal giaVeMoiGhe, out string message)
        {
            if (string.IsNullOrEmpty(maKhachHang))
            {
                message = "Khách hàng không hợp lệ!";
                return false;
            }
            if (string.IsNullOrEmpty(maSuatChieu))
            {
                message = "Suất chiếu không hợp lệ!";
                return false;
            }
            if (maGheList == null || maGheList.Count == 0)
            {
                message = "Vui lòng chọn ít nhất một ghế!";
                return false;
            }

            try
            {
                string maDatVe = "DV" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
                decimal totalAmount = maGheList.Count * giaVeMoiGhe;
                string danhSachGhe = string.Join(",", maGheList);

                if (veDAL.ThucHienDatVe(maDatVe, maKhachHang, maSuatChieu, totalAmount, danhSachGhe))
                {
                    message = "Đặt vé thành công!";
                    return true;
                }

                message = "Đặt vé thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi khi đặt vé: " + ex.Message;
                return false;
            }
        }
    }
}
