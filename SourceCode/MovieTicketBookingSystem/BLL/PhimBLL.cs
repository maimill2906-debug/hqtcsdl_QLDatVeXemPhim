using System;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class PhimBLL
    {
        private PhimDAL phimDAL = new PhimDAL();

        public DataTable GetAll()
        {
            return phimDAL.GetAll();
        }

        public bool Insert(PhimDTO phim, out string message)
        {
            if (string.IsNullOrEmpty(phim.MaPhim))
            {
                message = "Mã phim không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(phim.TenPhim))
            {
                message = "Tên phim không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(phim.MaTheLoai))
            {
                message = "Thể loại phim không được trống!";
                return false;
            }
            if (phim.ThoiLuong <= 0)
            {
                message = "Thời lượng phim phải lớn hơn 0!";
                return false;
            }

            try
            {
                //if (phimDAL.GetById(phim.MaPhim) != null)
                //{
                //    message = "Mã phim đã tồn tại!";
                //    return false;
                //}

                bool success = phimDAL.Insert(phim);
                if (success)
                {
                    message = "Thêm phim thành công!";
                    return true;
                }
                message = "Thêm phim thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Update(PhimDTO phim, out string message)
        {
            if (string.IsNullOrEmpty(phim.MaPhim))
            {
                message = "Mã phim không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(phim.TenPhim))
            {
                message = "Tên phim không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(phim.MaTheLoai))
            {
                message = "Thể loại phim không được trống!";
                return false;
            }
            if (phim.ThoiLuong <= 0)
            {
                message = "Thời lượng phim phải lớn hơn 0!";
                return false;
            }

            try
            {
                bool success = phimDAL.Update(phim);
                if (success)
                {
                    message = "Cập nhật thông tin phim thành công!";
                    return true;
                }
                message = "Cập nhật thông tin phim thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Delete(string maPhim, out string message)
        {
            if (string.IsNullOrEmpty(maPhim))
            {
                message = "Mã phim không được trống!";
                return false;
            }

            try
            {
                bool success = phimDAL.Delete(maPhim);
                if (success)
                {
                    message = "Xóa phim thành công!";
                    return true;
                }
                message = "Xóa phim thất bại hoặc phim không tồn tại!";
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
                return phimDAL.GetAll();
            }
            return phimDAL.Search(keyword);
        }

        public DataTable GetByTheLoai(string maTheLoai, bool skipDelay = false)
        {
            if (string.IsNullOrEmpty(maTheLoai))
            {
                return phimDAL.GetAll();
            }
            return phimDAL.GetByTheLoai(maTheLoai, skipDelay);
        }

        public DataSet GetByTheLoaiDataSet(string maTheLoai, bool skipDelay = false)
        {
            if (string.IsNullOrEmpty(maTheLoai))
            {
                DataSet ds = new DataSet();
                ds.Tables.Add(phimDAL.GetAll());
                return ds;
            }
            return phimDAL.GetByTheLoaiDataSet(maTheLoai, skipDelay);
        }

        public PhimDTO GetById(string maPhim)
        {
            if (string.IsNullOrEmpty(maPhim)) return null;
            return phimDAL.GetById(maPhim);
        }

        public string GetNextMaPhim()
        {
            return phimDAL.GetNextMaPhim();
        }
    }
}
