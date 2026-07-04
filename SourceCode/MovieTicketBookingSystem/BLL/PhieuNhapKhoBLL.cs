using System;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class PhieuNhapKhoBLL
    {
        private PhieuNhapKhoDAL phieuNhapKhoDAL = new PhieuNhapKhoDAL();

        public DataTable GetAll()
        {
            return phieuNhapKhoDAL.GetAll();
        }

        public bool NhapKho(PhieuNhapKhoDTO p, out string message)
        {
            if (string.IsNullOrEmpty(p.MaPhieu))
            {
                message = "Mã phiếu không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(p.MaKho))
            {
                message = "Mã kho không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(p.MaNhanVien))
            {
                message = "Mã nhân viên không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(p.MaNhaCungCap))
            {
                message = "Nhà cung cấp không được trống!";
                return false;
            }
            if (p.SoLuongNhap <= 0)
            {
                message = "Số lượng nhập phải lớn hơn 0!";
                return false;
            }

            try
            {
                // Verify duplicate
                if (phieuNhapKhoDAL.GetById(p.MaPhieu) != null)
                {
                    message = "Mã phiếu nhập đã tồn tại trong hệ thống!";
                    return false;
                }

                // Execute the SP which will validate capacity and execute transaction in DB
                if (phieuNhapKhoDAL.ThucHienNhapKho(p))
                {
                    message = "Nhập kho thành công!";
                    return true;
                }
                
                message = "Lập phiếu nhập kho thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("deadlock") || ex.Message.Contains("1205"))
                {
                    message = "Vui lòng thử lại sau giây lát!";
                }
                else
                {
                    message = "Lỗi: " + ex.Message;
                }
                return false;
            }
        }

        public bool HuyPhieuNhapKho(string maPhieu, out string message)
        {
            if (string.IsNullOrEmpty(maPhieu))
            {
                message = "Mã phiếu không được trống!";
                return false;
            }

            try
            {
                // Execute the SP which will check constraints and cancel receipt in DB transaction
                if (phieuNhapKhoDAL.HuyPhieuNhapKho(maPhieu))
                {
                    message = "Hủy phiếu nhập kho thành công!";
                    return true;
                }

                message = "Hủy phiếu nhập kho thất bại hoặc không tìm thấy phiếu!";
                return false;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("deadlock") || ex.Message.Contains("1205"))
                {
                    message = "Vui lòng thử lại sau giây lát!";
                }
                else
                {
                    message = "Lỗi: " + ex.Message;
                }
                return false;
            }
        }
    }
}
