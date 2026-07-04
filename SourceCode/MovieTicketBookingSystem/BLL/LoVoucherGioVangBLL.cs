using System;
using System.Data;
using MovieTicketBookingSystem.DAL;
using MovieTicketBookingSystem.DTO;

namespace MovieTicketBookingSystem.BLL
{
    public class LoVoucherGioVangBLL
    {
        private LoVoucherGioVangDAL loVoucherGioVangDAL = new LoVoucherGioVangDAL();

        public DataTable GetAll()
        {
            return loVoucherGioVangDAL.GetAll();
        }

        public DataTable GetActiveCampaigns()
        {
            return loVoucherGioVangDAL.GetActiveCampaigns();
        }

        public bool Insert(LoVoucherGioVangDTO lo, out string message)
        {
            if (string.IsNullOrEmpty(lo.MaLo))
            {
                message = "Mã lô voucher không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(lo.MaSuatChieu))
            {
                message = "Suất chiếu không được trống!";
                return false;
            }
            if (lo.SoLuong <= 0)
            {
                message = "Số lượng voucher phải lớn hơn 0!";
                return false;
            }
            if (lo.GiaGiam < 0)
            {
                message = "Mức giảm không hợp lệ!";
                return false;
            }

            try
            {
                if (loVoucherGioVangDAL.GetById(lo.MaLo) != null)
                {
                    message = "Mã lô voucher đã tồn tại!";
                    return false;
                }

                if (loVoucherGioVangDAL.Insert(lo))
                {
                    message = "Thêm lô voucher giờ vàng thành công!";
                    return true;
                }
                message = "Thêm lô voucher giờ vàng thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Update(LoVoucherGioVangDTO lo, out string message)
        {
            if (string.IsNullOrEmpty(lo.MaLo))
            {
                message = "Mã lô voucher không được trống!";
                return false;
            }
            if (string.IsNullOrEmpty(lo.MaSuatChieu))
            {
                message = "Suất chiếu không được trống!";
                return false;
            }
            if (lo.SoLuong < 0)
            {
                message = "Số lượng voucher không được âm!";
                return false;
            }
            if (lo.GiaGiam < 0)
            {
                message = "Mức giảm không hợp lệ!";
                return false;
            }

            try
            {
                if (loVoucherGioVangDAL.Update(lo))
                {
                    message = "Cập nhật lô voucher giờ vàng thành công!";
                    return true;
                }
                message = "Cập nhật lô voucher giờ vàng thất bại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool Delete(string maLo, out string message)
        {
            if (string.IsNullOrEmpty(maLo))
            {
                message = "Mã lô voucher không được trống!";
                return false;
            }

            try
            {
                if (loVoucherGioVangDAL.Delete(maLo))
                {
                    message = "Xóa lô voucher giờ vàng thành công!";
                    return true;
                }
                message = "Xóa lô voucher giờ vàng thất bại hoặc lô không tồn tại!";
                return false;
            }
            catch (Exception ex)
            {
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool SanVoucher(string maLo, string maKH)
        {
            if (string.IsNullOrEmpty(maLo) || string.IsNullOrEmpty(maKH)) return false;
            return loVoucherGioVangDAL.SanVoucher(maLo, maKH);
        }

        public LoVoucherGioVangDTO GetById(string maLo)
        {
            if (string.IsNullOrEmpty(maLo)) return null;
            return loVoucherGioVangDAL.GetById(maLo);
        }

        public string GetNextMaLo()
        {
            DataTable dt = GetAll();
            int maxId = 0;
            foreach (DataRow row in dt.Rows)
            {
                string maLo = row["MaLo"].ToString().Trim();
                if (maLo.StartsWith("L") && maLo.Length > 1)
                {
                    int id;
                    if (int.TryParse(maLo.Substring(1), out id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            return "L" + (maxId + 1).ToString("D3");
        }
    }
}
