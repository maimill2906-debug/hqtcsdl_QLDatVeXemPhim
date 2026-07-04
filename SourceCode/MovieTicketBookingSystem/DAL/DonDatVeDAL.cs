using System;
using System.Data;

namespace MovieTicketBookingSystem.DAL
{
    public class DonDatVeDAL
    {
        private Database db = new Database();

        public DataTable GetBookingHistoryByKhachHang(string maKhachHang)
        {
            string query = "EXEC sp_LichSuDatVe @MaKhachHang";
            object[] parameter = new object[] { maKhachHang };
            DataTable dt = db.ExecuteQuery(query, parameter);

            // Rename columns to match what GUI (FormVeCuaToi) expects
            if (dt.Columns.Contains("GioBatDau"))
                dt.Columns["GioBatDau"].ColumnName = "GioChieu";
            if (dt.Columns.Contains("DanhSachGhe"))
                dt.Columns["DanhSachGhe"].ColumnName = "Ghe";

            return dt;
        }
    }
}
