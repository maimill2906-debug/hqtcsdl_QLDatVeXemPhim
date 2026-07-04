using System;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class TheLoaiBLL
    {
        private TheLoaiDAL theLoaiDAL = new TheLoaiDAL();

        public DataTable GetAll()
        {
            return theLoaiDAL.GetAll();
        }

        public bool Insert(TheLoaiDTO theLoai, out string message)
        {
            if (string.IsNullOrEmpty(theLoai.MaTheLoai))
            {
                message = "Mã thể loại không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(theLoai.TenTheLoai))
            {
                message = "Tên thể loại không được trống!";
                return false;
            }

            try
            {
                bool success = theLoaiDAL.Insert(theLoai);
                if (success)
                {
                    message = "Thêm thể loại thành công!";
                    return true;
                }
                message = "Thêm thể loại thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Update(TheLoaiDTO theLoai, out string message)
        {
            if (string.IsNullOrEmpty(theLoai.MaTheLoai))
            {
                message = "Mã thể loại không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(theLoai.TenTheLoai))
            {
                message = "Tên thể loại không được trống!";
                return false;
            }

            try
            {
                bool success = theLoaiDAL.Update(theLoai);
                if (success)
                {
                    message = "Cập nhật thể loại thành công!";
                    return true;
                }
                message = "Cập nhật thể loại thất bại hoặc thể loại không tồn tại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Delete(string maTheLoai, out string message)
        {
            if (string.IsNullOrEmpty(maTheLoai))
            {
                message = "Mã thể loại không được trống!";
                return false;
            }

            try
            {
                bool success = theLoaiDAL.Delete(maTheLoai);
                if (success)
                {
                    message = "Xóa thể loại thành công!";
                    return true;
                }
                message = "Xóa thể loại thất bại hoặc thể loại không tồn tại!";
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
                return theLoaiDAL.GetAll();
            }
            return theLoaiDAL.Search(keyword);
        }

        public string GetNextMaTheLoai()
        {
            return theLoaiDAL.GetNextMaTheLoai();
        }
    }
}
