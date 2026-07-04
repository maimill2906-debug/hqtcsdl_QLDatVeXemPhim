using System;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class KhoBapNuocBLL
    {
        private KhoBapNuocDAL khoBapNuocDAL = new KhoBapNuocDAL();

        public DataTable GetAll()
        {
            return khoBapNuocDAL.GetAll();
        }

        public bool Insert(KhoBapNuocDTO item, out string message)
        {
            if (string.IsNullOrEmpty(item.MaKho))
            {
                message = "Mã kho không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(item.MaRap))
            {
                message = "Mã rạp không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(item.TenSanPham))
            {
                message = "Tên sản phẩm không được trống!";
                return false;
            }
            if (item.SoLuongHienCo < 0)
            {
                message = "Số lượng hiện có không được âm!";
                return false;
            }
            if (item.SucChuaToiDa <= 0)
            {
                message = "Sức chứa tối đa phải lớn hơn 0!";
                return false;
            }
            if (item.SoLuongHienCo > item.SucChuaToiDa)
            {
                message = "Số lượng hiện có không được vượt quá sức chứa tối đa!";
                return false;
            }

            try
            {
                if (khoBapNuocDAL.GetById(item.MaKho) != null)
                {
                    message = "Mã kho đã tồn tại!";
                    return false;
                }

                if (khoBapNuocDAL.Insert(item))
                {
                    message = "Thêm sản phẩm vào kho thành công!";
                    return true;
                }
                message = "Thêm sản phẩm vào kho thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Update(KhoBapNuocDTO item, out string message)
        {
            if (string.IsNullOrEmpty(item.MaKho))
            {
                message = "Mã kho không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(item.MaRap))
            {
                message = "Mã rạp không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(item.TenSanPham))
            {
                message = "Tên sản phẩm không được trống!";
                return false;
            }
            if (item.SoLuongHienCo < 0)
            {
                message = "Số lượng hiện có không được âm!";
                return false;
            }
            if (item.SucChuaToiDa <= 0)
            {
                message = "Sức chứa tối đa phải lớn hơn 0!";
                return false;
            }
            if (item.SoLuongHienCo > item.SucChuaToiDa)
            {
                message = "Số lượng hiện có không được vượt quá sức chứa tối đa!";
                return false;
            }

            try
            {
                if (khoBapNuocDAL.Update(item))
                {
                    message = "Cập nhật thông tin kho thành công!";
                    return true;
                }
                message = "Cập nhật thông tin kho thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Delete(string maKho, out string message)
        {
            if (string.IsNullOrEmpty(maKho))
            {
                message = "Mã kho không được trống!";
                return false;
            }

            try
            {
                if (khoBapNuocDAL.Delete(maKho))
                {
                    message = "Xóa sản phẩm khỏi kho thành công!";
                    return true;
                }
                message = "Xóa sản phẩm khỏi kho thất bại hoặc sản phẩm không tồn tại!";
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
                return khoBapNuocDAL.GetAll();
            }
            return khoBapNuocDAL.Search(keyword);
        }

        public KhoBapNuocDTO GetById(string maKho)
        {
            if (string.IsNullOrEmpty(maKho)) return null;
            return khoBapNuocDAL.GetById(maKho);
        }
    }
}
