using System;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class SuatChieuBLL
    {
        private SuatChieuDAL suatChieuDAL = new SuatChieuDAL();

        public DataTable GetAll()
        {
            return suatChieuDAL.GetAll();
        }

        public bool Insert(SuatChieuDTO sc, out string message)
        {
            if (string.IsNullOrEmpty(sc.MaSuatChieu))
            {
                message = "Mã suất chiếu không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(sc.MaPhim))
            {
                message = "Phim không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(sc.MaPhong))
            {
                message = "Phòng chiếu không được trống!";
                return false;
            }
            if (sc.GioBatDau >= sc.GioKetThuc)
            {
                message = "Giờ kết thúc phải sau giờ bắt đầu!";
                return false;
            }

            try
            {
                if (suatChieuDAL.GetById(sc.MaSuatChieu) != null)
                {
                    message = "Mã suất chiếu đã tồn tại!";
                    return false;
                }

                bool success = suatChieuDAL.Insert(sc);
                if (success)
                {
                    message = "Thêm suất chiếu thành công!";
                    return true;
                }
                message = "Thêm suất chiếu thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Update(SuatChieuDTO sc, out string message)
        {
            if (string.IsNullOrEmpty(sc.MaSuatChieu))
            {
                message = "Mã suất chiếu không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(sc.MaPhim))
            {
                message = "Phim không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(sc.MaPhong))
            {
                message = "Phòng chiếu không được trống!";
                return false;
            }
            if (sc.GioBatDau >= sc.GioKetThuc)
            {
                message = "Giờ kết thúc phải sau giờ bắt đầu!";
                return false;
            }

            try
            {
                bool success = suatChieuDAL.Update(sc);
                if (success)
                {
                    message = "Cập nhật suất chiếu thành công!";
                    return true;
                }
                message = "Cập nhật suất chiếu thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Delete(string maSuatChieu, out string message)
        {
            if (string.IsNullOrEmpty(maSuatChieu))
            {
                message = "Mã suất chiếu không được trống!";
                return false;
            }

            try
            {
                bool success = suatChieuDAL.Delete(maSuatChieu);
                if (success)
                {
                    message = "Xóa suất chiếu thành công!";
                    return true;
                }
                message = "Xóa suất chiếu thất bại hoặc suất chiếu không tồn tại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public DataTable Search(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return suatChieuDAL.GetAll();
            }
            return suatChieuDAL.Search(keyword);
        }

        public DataTable GetShowtimesByMovie(string maPhim)
        {
            if (string.IsNullOrEmpty(maPhim)) return new DataTable();
            return suatChieuDAL.GetShowtimesByMovie(maPhim);
        }

        public SuatChieuDTO GetById(string maSuatChieu)
        {
            if (string.IsNullOrEmpty(maSuatChieu)) return null;
            return suatChieuDAL.GetById(maSuatChieu);
        }

        public string GetNextMaSuatChieu()
        {
            return suatChieuDAL.GetNextMaSuatChieu();
        }
    }
}
