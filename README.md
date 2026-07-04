# hqtcsdl_QLDatVeXemPhim
Báo cáo môn học hệ quản trị CSDL - Hệ thống quản lý đặt vé xem phim - Ứng dụng Winform 
# Hướng Dẫn Cài Đặt Nhanh
### Bước 1: Khởi tạo Cơ sở dữ liệu
1. Mở SQL Server Management Studio (SSMS) trên máy
2. Mở file `CSDL_HeThong.sql` và nhấn **Execute (F5)** để tạo CSDL tên `QLDatVePhim`.
### Bước 2: Cấu hình mã nguồn C#
1. Mở Visual Studio và mở file solution `SourceCode/MovieTicketBookingSystem.sln`.
2. Mở file `Database.cs` (nằm ở thư mục `DAL`) và thay đổi chuỗi kết nối phù hợp với máy tại dòng số 9:
   ```csharp
   private string connectionString = @"Data Source=TÊN_SERVER_CỦA_BẠN;Initial Catalog=QLDatVePhim;Integrated Security=True";
