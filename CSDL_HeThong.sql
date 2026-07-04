--TẠO CSDL 
CREATE DATABASE QLDatVePhim;
GO
USE QLDatVePhim;
GO
--TẠO 16 BẢNG 
-- 1.Tạo bảng Tài khoản
CREATE TABLE TAI_KHOAN (
    MaTaiKhoan VARCHAR(10) PRIMARY KEY,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(256) NOT NULL,
    VaiTro NVARCHAR(50) NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Hoạt động'
);
GO
-- 2. Tạo bảng Khách hàng
CREATE TABLE KHACH_HANG (
    MaKhachHang VARCHAR(10) PRIMARY KEY,
    MaTaiKhoan VARCHAR(10) FOREIGN KEY REFERENCES TAI_KHOAN(MaTaiKhoan),
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100)
);
GO
-- 3. Tạo bảng Nhân viên
CREATE TABLE NHAN_VIEN (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    MaTaiKhoan VARCHAR(10) FOREIGN KEY REFERENCES TAI_KHOAN(MaTaiKhoan),
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15)
);
GO
-- 4. Tạo bảng Rạp
CREATE TABLE RAP (
    MaRap VARCHAR(10) PRIMARY KEY,
    TenRap NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL
);
GO
-- 5. Tạo bảng Phòng chiếu
CREATE TABLE PHONG_CHIEU (
    MaPhong VARCHAR(10) PRIMARY KEY,
    MaRap VARCHAR(10) FOREIGN KEY REFERENCES RAP(MaRap),
    TenPhong NVARCHAR(50) NOT NULL,
    SucChua INT NOT NULL
);
GO
-- 6. Tạo bảng Ghế
CREATE TABLE GHE (
    MaGhe VARCHAR(10) PRIMARY KEY,
    MaPhong VARCHAR(10) FOREIGN KEY REFERENCES PHONG_CHIEU(MaPhong),
    SoGhe VARCHAR(10) NOT NULL,
    LoaiGhe NVARCHAR(50) NOT NULL
);
GO
-- 7. Tạo bảng Thể loại
CREATE TABLE THE_LOAI (
    MaTheLoai VARCHAR(10) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL
);
GO
-- 8. Tạo bảng Phim
CREATE TABLE PHIM (
    MaPhim VARCHAR(10) PRIMARY KEY,
    MaTheLoai VARCHAR(10) FOREIGN KEY REFERENCES THE_LOAI(MaTheLoai),
    TenPhim NVARCHAR(100) NOT NULL,
    ThoiLuong INT NOT NULL,
    MoTa NVARCHAR(MAX),
    AnhPoster NVARCHAR(500)
);
GO
-- 9. Tạo bảng Suất chiếu
CREATE TABLE SUAT_CHIEU (
    MaSuatChieu VARCHAR(10) PRIMARY KEY,
    MaPhim VARCHAR(10) FOREIGN KEY REFERENCES PHIM(MaPhim),
    MaPhong VARCHAR(10) FOREIGN KEY REFERENCES PHONG_CHIEU(MaPhong),
    NgayChieu DATE NOT NULL,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Hoạt động'
);
GO
-- 10. Tạo bảng Đơn đặt vé
CREATE TABLE DON_DAT_VE (
    MaDatVe VARCHAR(10) PRIMARY KEY,
    MaKhachHang VARCHAR(10) FOREIGN KEY REFERENCES KHACH_HANG(MaKhachHang),
    MaSuatChieu VARCHAR(10) FOREIGN KEY REFERENCES SUAT_CHIEU(MaSuatChieu),
    ThoiGianDat DATETIME NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Đã thanh toán'
);
GO
-- 11. Tạo bảng Vé
CREATE TABLE VE (
    MaVe VARCHAR(30) PRIMARY KEY,
    MaDatVe VARCHAR(10) FOREIGN KEY REFERENCES DON_DAT_VE(MaDatVe),
    MaGhe VARCHAR(10) FOREIGN KEY REFERENCES GHE(MaGhe),
    MaSuatChieu VARCHAR(10) FOREIGN KEY REFERENCES SUAT_CHIEU(MaSuatChieu),
    GiaVe DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Đã đặt',
    CONSTRAINT UQ_Ghe_SuatChieu UNIQUE (MaGhe, MaSuatChieu)
);
GO
-- 12. Tạo bảng Lô voucher giờ vàng
CREATE TABLE LO_VOUCHER_GIO_VANG (
    MaLo VARCHAR(50) PRIMARY KEY,
    MaSuatChieu VARCHAR(10) FOREIGN KEY REFERENCES SUAT_CHIEU(MaSuatChieu),
    SoLuong INT NOT NULL,
    GiaGiam DECIMAL(18,2) NOT NULL,
    KinhPhiToiDa DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Chưa kích hoạt'
);
GO
-- 13. Tạo bảng Ví voucher
CREATE TABLE VI_VOUCHER (
    MaVoucher VARCHAR(50) PRIMARY KEY,
    MaKhachHang VARCHAR(10) FOREIGN KEY REFERENCES KHACH_HANG(MaKhachHang),
    MaLo VARCHAR(50) FOREIGN KEY REFERENCES LO_VOUCHER_GIO_VANG(MaLo),
    NgaySan DATETIME NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Chưa sử dụng'
);
GO
-- 14. Tạo bảng Nhà cung cấp
CREATE TABLE NHA_CUNG_CAP (
    MaNhaCungCap VARCHAR(10) PRIMARY KEY,
    TenNhaCungCap NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15),
    DiaChi NVARCHAR(200)
);
GO
-- 15. Tạo bảng Kho bắp nước
CREATE TABLE KHO_BAP_NUOC (
    MaKho VARCHAR(10) PRIMARY KEY,
    MaRap VARCHAR(10) FOREIGN KEY REFERENCES RAP(MaRap),
    TenSanPham NVARCHAR(100) NOT NULL,
    SoLuongHienCo INT NOT NULL,
    SucChuaToiDa INT NOT NULL
);
GO
-- 16. Tạo bảng Phiếu nhập kho
CREATE TABLE PHIEU_NHAP_KHO (
    MaPhieu VARCHAR(10) PRIMARY KEY,
    MaKho VARCHAR(10) FOREIGN KEY REFERENCES KHO_BAP_NUOC(MaKho),
    MaNhanVien VARCHAR(10) FOREIGN KEY REFERENCES NHAN_VIEN(MaNhanVien),
    MaNhaCungCap VARCHAR(10) FOREIGN KEY REFERENCES NHA_CUNG_CAP(MaNhaCungCap),
    SoLuongNhap INT NOT NULL,
    ThoiGianNhap DATETIME NOT NULL
);
GO


-- CÁC HÀM XỬ LÝ (FUNCTIONS)
-- 1. Hàm kiểm tra ghế đã đặt
CREATE FUNCTION fn_KiemTraGheDaDat (
    @MaGhe VARCHAR(10),
    @MaSuatChieu VARCHAR(10)
)
RETURNS BIT
AS
BEGIN
    DECLARE @DaDat BIT = 0;
    IF EXISTS (
        SELECT 1 
        FROM VE 
        WHERE MaGhe = @MaGhe AND MaSuatChieu = @MaSuatChieu AND TrangThai <> N'Đã hủy'
    )
        SET @DaDat = 1;
    RETURN @DaDat;
END;
GO
-- 2.Hàm tính toán sức chứa còn lại của Kho
CREATE FUNCTION fn_TinhSucChuaConLai (
    @MaKho VARCHAR(10)
)
RETURNS INT
AS
BEGIN
    DECLARE @SucChuaConLai INT = 0;
    SELECT @SucChuaConLai = (SucChuaToiDa - SoLuongHienCo)
    FROM KHO_BAP_NUOC
    WHERE MaKho = @MaKho;
    
    IF @SucChuaConLai < 0 SET @SucChuaConLai = 0;
    RETURN @SucChuaConLai;
END;
GO
-- 3. Hàm tính tổng tiền vé (Có áp dụng Voucher giảm giá)
CREATE FUNCTION fn_TinhTongTienVe (
    @MaSuatChieu VARCHAR(10),
    @DanhSachGhe NVARCHAR(MAX),
    @MaVoucher VARCHAR(20)
)
RETURNS DECIMAL(18,2)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18,2) = 0;
    
    DECLARE @Xml XML = CAST('<x>' + REPLACE(@DanhSachGhe, ',', '</x><x>') + '</x>' AS XML);
    DECLARE @GheTable TABLE (MaGhe VARCHAR(10));
    INSERT INTO @GheTable
    SELECT t.value('.', 'VARCHAR(10)') FROM @Xml.nodes('/x') AS x(t);
    DECLARE @TongTienGoc DECIMAL(18,2) = 0;
    SELECT @TongTienGoc = SUM(
        CASE 
            WHEN g.LoaiGhe = N'VIP' THEN 110000.00
            ELSE 80000.00
        END
    )
    FROM @GheTable gt
    INNER JOIN GHE g ON gt.MaGhe = g.MaGhe;
    DECLARE @TienGiam DECIMAL(18,2) = 0;
    IF @MaVoucher IS NOT NULL AND @MaVoucher <> ''
    BEGIN
        SELECT @TienGiam = l.GiaGiam
        FROM VI_VOUCHER v
        INNER JOIN LO_VOUCHER_GIO_VANG l ON v.MaLo = l.MaLo
        WHERE v.MaVoucher = @MaVoucher;
    END
    SET @TongTien = @TongTienGoc - ISNULL(@TienGiam, 0);
    
    IF @TongTien < 0 
        SET @TongTien = 0;
    RETURN ISNULL(@TongTien, 0);
END;
GO
-- 4. Hàm lấy danh sách ghế trống theo suất chiếu
CREATE FUNCTION fn_LayGheTrongTheoSuatChieu (
    @MaSuatChieu VARCHAR(10)
)
RETURNS TABLE
AS
RETURN (
    SELECT g.MaGhe, g.MaPhong, g.SoGhe, g.LoaiGhe
    FROM GHE g
    INNER JOIN SUAT_CHIEU s ON g.MaPhong = s.MaPhong
    LEFT JOIN VE v ON g.MaGhe = v.MaGhe AND v.MaSuatChieu = @MaSuatChieu AND v.TrangThai <> N'Đã hủy'
    WHERE s.MaSuatChieu = @MaSuatChieu AND v.MaVe IS NULL
);
GO
-- 5. Hàm lấy suất chiếu hôm nay 
CREATE FUNCTION fn_LaySuatChieuHomNay()
RETURNS TABLE
AS
RETURN (
    SELECT s.MaSuatChieu, s.MaPhim, p.TenPhim, s.MaPhong, s.NgayChieu, s.GioBatDau, s.GioKetThuc
    FROM SUAT_CHIEU s
    INNER JOIN PHIM p ON s.MaPhim = p.MaPhim
    WHERE s.NgayChieu = CAST(GETDATE() AS DATE) AND s.TrangThai = N'Đang chiếu'
);
GO

-- CÁC TRIGGER 
-- 1. Trigger chặn đặt trùng ghế (Double Booking)
CREATE TRIGGER trg_KhongChoDatTrungGhe
ON VE
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1 
        FROM VE v
        INNER JOIN inserted i ON v.MaGhe = i.MaGhe AND v.MaSuatChieu = i.MaSuatChieu
        WHERE v.MaVe <> i.MaVe 
          AND v.TrangThai <> N'Đã hủy' 
          AND i.TrangThai <> N'Đã hủy'
    )
    BEGIN
        RAISERROR(N'Lỗi trùng ghế: Vị trí ghế này đã được đặt cho suất chiếu hiện hành!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
-- 2. Trigger kiểm tra giới hạn sức chứa kho bắp nước
CREATE TRIGGER trg_KiemTraGioiHanSucChua
ON KHO_BAP_NUOC
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1 FROM inserted WHERE SoLuongHienCo > SucChuaToiDa
    )
    BEGIN
        RAISERROR(N'Lỗi: Số lượng sản phẩm vượt quá sức chứa tối đa của quầy kho!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
-- 3. Trigger kiểm tra giới hạn kinh phí phát hành Voucher
CREATE TRIGGER trg_KiemTraKinhPhiVoucher
ON LO_VOUCHER_GIO_VANG
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1 
        FROM inserted
        WHERE (SoLuong * GiaGiam) > KinhPhiToiDa
    )
    BEGIN
        RAISERROR(N'Lỗi nghiệp vụ: Tổng ngân sách phát hành voucher (Số lượng x Giá giảm) vượt quá Kinh phí tối đa cho phép!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
-- 4. Trigger tự động chuyển trạng thái Hết Voucher khi số lượng về 0
CREATE TRIGGER trg_TuDongCapNhatTrangThaiHetVoucher
ON LO_VOUCHER_GIO_VANG
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE LO_VOUCHER_GIO_VANG
    SET TrangThai = N'Hết voucher'
    FROM LO_VOUCHER_GIO_VANG l
    JOIN inserted i ON l.MaLo = i.MaLo
    WHERE i.SoLuong = 0;
END;
GO
-- 5. Trigger tự động hủy các vé liên quan khi đơn đặt vé bị hủy
CREATE TRIGGER trg_TuDongHuyVeKhiHuyDonDat
ON DON_DAT_VE
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF UPDATE(TrangThai)
    BEGIN
        UPDATE VE
        SET TrangThai = N'Đã hủy'
        WHERE MaDatVe IN (SELECT MaDatVe FROM inserted WHERE TrangThai = N'Đã hủy');
    END
END;
GO

-- CÁC VIEW 
--DÀNH CHO ADMIN 
-- 1. View thông tin kho bắp nước 
CREATE VIEW vw_ThongTinKho AS
SELECT 
    k.MaKho, 
    k.MaRap, 
    r.TenRap, 
    k.TenSanPham, 
    k.SoLuongHienCo, 
    k.SucChuaToiDa
FROM KHO_BAP_NUOC k
INNER JOIN RAP r ON k.MaRap = r.MaRap;
GO
-- 2. View lịch sử nhập kho đầy đủ thông tin 
CREATE VIEW vw_LichSuNhapKho AS
SELECT p.MaPhieu, p.SoLuongNhap, p.ThoiGianNhap,
       k.MaKho, k.TenSanPham AS TenSanPhamKho,
       nv.MaNhanVien, nv.HoTen AS TenNhanVien,
       ncc.MaNhaCungCap, ncc.TenNhaCungCap
FROM PHIEU_NHAP_KHO p
INNER JOIN KHO_BAP_NUOC k ON p.MaKho = k.MaKho
INNER JOIN NHAN_VIEN nv ON p.MaNhanVien = nv.MaNhanVien
INNER JOIN NHA_CUNG_CAP ncc ON p.MaNhaCungCap = ncc.MaNhaCungCap;
GO
-- 3. View quản lý danh sách phim 
CREATE VIEW vw_QuanLyPhim AS
SELECT 
    p.MaPhim,
    p.TenPhim,
    p.ThoiLuong,
    p.MoTa,
    p.MaTheLoai,
    t.TenTheLoai,
    p.AnhPoster
FROM PHIM p
INNER JOIN THE_LOAI t ON p.MaTheLoai = t.MaTheLoai;
GO
-- 4. View quản lý chi tiết suất chiếu 
CREATE VIEW vw_QuanLySuatChieu AS
SELECT 
    s.MaSuatChieu, 
    s.MaPhim,
    p.TenPhim, 
    s.MaPhong,
    pc.TenPhong, 
    s.NgayChieu, 
    s.GioBatDau, 
    s.GioKetThuc, 
    s.TrangThai
FROM SUAT_CHIEU s 
INNER JOIN PHIM p ON s.MaPhim = p.MaPhim
INNER JOIN PHONG_CHIEU pc ON s.MaPhong = pc.MaPhong;
GO
-- 5. View quản lý voucher khuyến mãi 
CREATE VIEW vw_QuanLyVoucher AS
SELECT 
    l.MaLo, 
    l.MaSuatChieu, 
    p.TenPhim, 
    l.SoLuong, 
    l.GiaGiam, 
    l.KinhPhiToiDa, 
    l.TrangThai 
FROM LO_VOUCHER_GIO_VANG l
INNER JOIN SUAT_CHIEU s ON l.MaSuatChieu = s.MaSuatChieu
INNER JOIN PHIM p ON s.MaPhim = p.MaPhim;
GO
--DÀNH CHO KHÁCH HÀNG 
-- 1. View lịch sử đặt vé xem phim 
CREATE VIEW vw_LichSuDatVe AS
SELECT d.MaDatVe, d.MaKhachHang, kh.HoTen AS TenKhachHang, 
       p.MaPhim, p.TenPhim, 
       sc.MaSuatChieu, sc.NgayChieu, sc.GioBatDau, sc.GioKetThuc,
       d.ThoiGianDat, d.TongTien, d.TrangThai
FROM DON_DAT_VE d
INNER JOIN KHACH_HANG kh ON d.MaKhachHang = kh.MaKhachHang
INNER JOIN SUAT_CHIEU sc ON d.MaSuatChieu = sc.MaSuatChieu
INNER JOIN PHIM p ON sc.MaPhim = p.MaPhim;
GO

-- 2. View Ví voucher cá nhân 
CREATE VIEW vw_ViVoucher AS
SELECT 
    v.MaVoucher,
    v.MaKhachHang,
    l.GiaGiam AS MucGiamGia,
    p.TenPhim AS PhimDuocApDung,
    sc.NgayChieu AS NgayChieuSuat,
    v.TrangThai
FROM VI_VOUCHER v
INNER JOIN LO_VOUCHER_GIO_VANG l ON v.MaLo = l.MaLo
INNER JOIN SUAT_CHIEU sc ON l.MaSuatChieu = sc.MaSuatChieu
INNER JOIN PHIM p ON sc.MaPhim = p.MaPhim;
GO
-- 3. View danh sách phim đang hoạt động 
CREATE VIEW vw_DanhSachPhim 
AS
SELECT 
    p.MaPhim,
    p.TenPhim, 
    p.ThoiLuong, 
    p.MaTheLoai,
    t.TenTheLoai, 
    p.MoTa, 
    p.AnhPoster
FROM PHIM p
INNER JOIN THE_LOAI t ON p.MaTheLoai = t.MaTheLoai;
GO
-- 4. View chi tiết các suất chiếu đang chạy 
CREATE VIEW vw_DanhSachSuatChieu AS
SELECT s.MaSuatChieu, s.NgayChieu, s.GioBatDau, s.GioKetThuc, s.TrangThai,
       p.MaPhim, p.TenPhim, p.ThoiLuong,
       pc.MaPhong, pc.TenPhong,
       r.MaRap, r.TenRap
FROM SUAT_CHIEU s
INNER JOIN PHIM p ON s.MaPhim = p.MaPhim
INNER JOIN PHONG_CHIEU pc ON s.MaPhong = pc.MaPhong
INNER JOIN RAP r ON pc.MaRap = r.MaRap;
GO
-- 5. View Lô Voucher Giờ Vàng đang mở bán 
CREATE VIEW vw_LoVoucherGioVang AS
SELECT l.MaLo, l.MaSuatChieu, p.TenPhim, s.NgayChieu, s.GioBatDau, l.SoLuong AS SoVeKhuyenMaiConLai, l.GiaGiam AS GiaKhuyenMai, l.KinhPhiToiDa, l.TrangThai AS TrangThaiLoVe 
FROM LO_VOUCHER_GIO_VANG l
INNER JOIN SUAT_CHIEU s ON l.MaSuatChieu = s.MaSuatChieu
INNER JOIN PHIM p ON s.MaPhim = p.MaPhim;
GO

-- CÁC GIAO TÁC GÂY TRANH CHẤP 

-- 1. TÌNH HUỐNG 1: DIRTY READ (Đọc dữ liệu rác)

--  Giao tác T1 (Tạo lô Voucher có delay gây Dirty Read)
CREATE PROCEDURE sp_TaoLoVoucher
    @MaLo VARCHAR(50),
    @MaSuatChieu VARCHAR(50),
    @SoLuong INT,
    @GiaGiam DECIMAL(18, 2),
    @KinhPhiToiDa DECIMAL(18, 2)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        INSERT INTO LO_VOUCHER_GIO_VANG (MaLo, MaSuatChieu, SoLuong, GiaGiam, KinhPhiToiDa, TrangThai)
        VALUES (@MaLo, @MaSuatChieu, @SoLuong, @GiaGiam, @KinhPhiToiDa, N'Chưa kích hoạt');
        
        -- Giả lập delay 8 giây chưa commit
        WAITFOR DELAY '00:00:08';
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
-- Giao tác T2 Gốc gây lỗi Dirty Read (Khách săn Voucher đọc Uncommitted)
-- Cho phép đọc Uncommitted nên khách hàng sẽ xem được lô voucher chưa được kích hoạt chính thức
CREATE PROCEDURE sp_LayVoucherKichHoat
AS
BEGIN
    -- Mức cô lập gây lỗi Dirty Read
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
    SELECT MaLo, MaSuatChieu, TenPhim, NgayChieu, GioBatDau, SoVeKhuyenMaiConLai AS SoLuong, GiaKhuyenMai AS GiaGiam, KinhPhiToiDa, TrangThaiLoVe AS TrangThai 
    FROM vw_LoVoucherGioVang;
END;
GO
-- Giao tác T3 gây hậu quả dirty read
CREATE PROCEDURE sp_SanVoucher
    @MaLo VARCHAR(50),
    @MaKhachHang VARCHAR(50)
AS
BEGIN
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @SoLuongCon INT;
        SELECT @SoLuongCon = SoLuong FROM LO_VOUCHER_GIO_VANG WHERE MaLo = @MaLo;
        IF @SoLuongCon IS NULL OR @SoLuongCon <= 0
            THROW 50003, N'Đã hết voucher!', 1;
        UPDATE LO_VOUCHER_GIO_VANG SET SoLuong = SoLuong - 1 WHERE MaLo = @MaLo;
        DECLARE @NewVoucherCode VARCHAR(20) = 'V_' + @MaLo + '_' + UPPER(SUBSTRING(REPLACE(CAST(NEWID() AS VARCHAR(36)), '-', ''), 1, 4));
        INSERT INTO VI_VOUCHER (MaVoucher, MaKhachHang, MaLo, NgaySan, TrangThai)
        VALUES (@NewVoucherCode, @MaKhachHang, @MaLo, GETDATE(), N'Chưa sử dụng');
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
-- FIX DIRTY READ 
-- Giao tác T2 Đã Khắc Phục sửa Dirty Read bằng ReadCommitted
-- Chuyển sang Read Committed để không cho phép đọc dữ liệu chưa commit của T1
CREATE PROCEDURE sp_LayVoucherKichHoat_Fix 
AS
BEGIN
    -- Giải pháp sửa lỗi Dirty Read
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
    SELECT MaLo, MaSuatChieu, TenPhim, NgayChieu, GioBatDau, SoVeKhuyenMaiConLai AS SoLuong, GiaKhuyenMai AS GiaGiam, KinhPhiToiDa, TrangThaiLoVe AS TrangThai 
    FROM vw_LoVoucherGioVang;
END;
GO

-- Giao tác T3 đã Khắc Phục sửa Dirty Read bằng ReadCommitted
CREATE PROCEDURE sp_SanVoucher_Fix 
    @MaLo VARCHAR(50), 
    @MaKhachHang VARCHAR(50) 
AS
BEGIN
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @SoLuongCon INT; SELECT @SoLuongCon = SoLuong FROM LO_VOUCHER_GIO_VANG WHERE MaLo = @MaLo;
        IF @SoLuongCon IS NULL OR @SoLuongCon <= 0 THROW 50003, N'Đã hết voucher hoặc đợt khuyến mãi đã dừng!', 1;
        UPDATE LO_VOUCHER_GIO_VANG SET SoLuong = SoLuong - 1 WHERE MaLo = @MaLo;
        DECLARE @NewVoucherCode VARCHAR(20) = 'V_' + @MaLo + '_' + UPPER(SUBSTRING(REPLACE(CAST(NEWID() AS VARCHAR(36)), '-', ''), 1, 4));
        INSERT INTO VI_VOUCHER (MaVoucher, MaKhachHang, MaLo, NgaySan, TrangThai) VALUES (@NewVoucherCode, @MaKhachHang, @MaLo, GETDATE(), N'Chưa sử dụng');
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; THROW; END CATCH
END;

GO


-- 2. TÌNH HUỐNG 2: LOST UPDATE (Mất dữ liệu cập nhật)
-- -------------------------------------------------------------------------
-- Giao tác Gốc gây lỗi Lost Update (Nhập Kho đọc tồn trước, cộng sau)
-- Nhân viên đọc tồn kho ra biến -> delay -> cập nhật dẫn đến ghi đè mất mát dữ liệu của người khác
CREATE PROCEDURE sp_NhapKho
    @MaPhieu VARCHAR(10),
    @MaKho VARCHAR(10),
    @MaNhanVien VARCHAR(10),
    @MaNhaCungCap VARCHAR(10),
    @SoLuongNhap INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @SoLuongTon INT;
        SELECT @SoLuongTon = SoLuongHienCo FROM KHO_BAP_NUOC WHERE MaKho = @MaKho;
        
        -- Delay 8 giây chờ người khác cập nhật ghi đè
        WAITFOR DELAY '00:00:08';
        
        UPDATE KHO_BAP_NUOC
        SET SoLuongHienCo = @SoLuongTon + @SoLuongNhap
        WHERE MaKho = @MaKho;
        
        INSERT INTO PHIEU_NHAP_KHO (MaPhieu, MaKho, MaNhanVien, MaNhaCungCap, SoLuongNhap, ThoiGianNhap)
        VALUES (@MaPhieu, @MaKho, @MaNhanVien, @MaNhaCungCap, @SoLuongNhap, GETDATE());
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
--FIX LOST UPDATE 
-- Giao tác Đã Khắc Phục sửa Lost Update ( sử dụng UPDLOCK) - Cơ chế 2PL
CREATE PROCEDURE sp_NhapKho_Fix
    @MaPhieu VARCHAR(10), 
    @MaKho VARCHAR(10), 
    @MaNhanVien VARCHAR(10), 
    @MaNhaCungCap VARCHAR(10), 
    @SoLuongNhap INT 
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @SoLuongTon INT; 
        SELECT @SoLuongTon = SoLuongHienCo 
        FROM KHO_BAP_NUOC WITH (UPDLOCK, ROWLOCK) 
        WHERE MaKho = @MaKho;
        WAITFOR DELAY '00:00:08';
        UPDATE KHO_BAP_NUOC 
        SET SoLuongHienCo = @SoLuongTon + @SoLuongNhap 
        WHERE MaKho = @MaKho;
        INSERT INTO PHIEU_NHAP_KHO (MaPhieu, MaKho, MaNhanVien, MaNhaCungCap, SoLuongNhap, ThoiGianNhap) 
        VALUES (@MaPhieu, @MaKho, @MaNhanVien, @MaNhaCungCap, @SoLuongNhap, GETDATE());
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH 
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
        THROW; 
    END CATCH
END;
GO
-- TÌNH HUỐNG 3: NON-REPEATABLE READ (không đọc lại được dữ liệu)
-- Đặt Vé Xem Phim Gốc gây lỗi do đọc trạng thái xong thì giải phóng khóa trong lúc đó admin cập nhật trạng thái 
-- Giao tác T1 đặt vé xem phim 
CREATE PROCEDURE sp_DatVeXemPhim
    @MaDatVe VARCHAR(50),
    @MaKhachHang VARCHAR(50),
    @MaSuatChieu VARCHAR(50),
    @TongTien DECIMAL(18, 2),
    @DanhSachGhe NVARCHAR(MAX)
AS
BEGIN
    SET ANSI_NULLS ON;
    SET QUOTED_IDENTIFIER ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @Status NVARCHAR(50) = (SELECT TrangThai FROM SUAT_CHIEU WHERE MaSuatChieu = @MaSuatChieu);
        
        -- THAY ĐỔI: Chỉ cần trạng thái khác 'Tạm ngưng' và khác 'Đã hủy' (cho dù có bị lỗi font) là sẽ delay
        IF @Status NOT LIKE N'%Tạm ngưng%' AND @Status NOT LIKE N'%Đã hủy%' AND @Status NOT LIKE N'%Tam ngung%' AND @Status NOT LIKE N'%Da huy%'
        BEGIN
            WAITFOR DELAY '00:00:08';
        END

        DECLARE @Status2 NVARCHAR(50) = (SELECT TrangThai FROM SUAT_CHIEU WHERE MaSuatChieu = @MaSuatChieu);
        
        -- Nếu trạng thái đã bị chuyển thành tạm ngưng hoặc hủy
        IF @Status2 LIKE N'%Tạm ngưng%' OR @Status2 LIKE N'%Đã hủy%' OR @Status2 LIKE N'%Tam ngung%' OR @Status2 LIKE N'%Da huy%'
        BEGIN
            THROW 50002, N'Suất chiếu đã bị tạm ngưng hoặc hủy bỏ, không thể đặt vé!', 1;
        END

        DECLARE @Xml XML = CAST('<x>' + REPLACE(@DanhSachGhe, ',', '</x><x>') + '</x>' AS XML);
        DECLARE @GheTable TABLE (MaGhe VARCHAR(50));
        
        INSERT INTO @GheTable SELECT t.value('.', 'VARCHAR(50)') FROM @Xml.nodes('/x') AS x(t);

        INSERT INTO DON_DAT_VE (MaDatVe, MaKhachHang, MaSuatChieu, ThoiGianDat, TongTien, TrangThai)
        VALUES (@MaDatVe, @MaKhachHang, @MaSuatChieu, GETDATE(), @TongTien, N'Đã thanh toán');

        DECLARE @Count INT = (SELECT COUNT(*) FROM @GheTable);
        DECLARE @GiaVeMoiGhe DECIMAL(18,2) = @TongTien / IIF(@Count > 0, @Count, 1);

        INSERT INTO VE (MaVe, MaDatVe, MaGhe, MaSuatChieu, GiaVe, TrangThai)
        SELECT @MaDatVe + '_' + gt.MaGhe, @MaDatVe, gt.MaGhe, @MaSuatChieu, @GiaVeMoiGhe, N'Đã đặt' 
        FROM @GheTable gt;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;

GO


-- Giao tác T2 cập nhật suất chiếu 
CREATE PROCEDURE sp_CapNhatSuatChieu
    @MaSuatChieu VARCHAR(50),
    @MaPhim VARCHAR(50),
    @MaPhong VARCHAR(50),
    @NgayChieu DATE,
    @GioBatDau TIME,
    @GioKetThuc TIME,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    SET ANSI_NULLS ON; 
    SET QUOTED_IDENTIFIER ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        UPDATE SUAT_CHIEU 
        SET MaPhim = @MaPhim, 
            MaPhong = @MaPhong, 
            NgayChieu = @NgayChieu, 
            GioBatDau = @GioBatDau, 
            GioKetThuc = @GioKetThuc, 
            TrangThai = @TrangThai 
        WHERE MaSuatChieu = @MaSuatChieu;
        
        
        IF (@TrangThai = N'Tạm ngưng' OR @TrangThai = N'Đã hủy') 
           AND EXISTS (
               SELECT 1 
               FROM VE 
               WHERE MaSuatChieu = @MaSuatChieu AND TrangThai <> N'Đã hủy'
           )
        BEGIN
            THROW 50005, N'Suất chiếu đã có khách hàng đặt vé, không thể tạm ngưng hoặc hủy!', 1;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- FIX NON-REPEATABLE READ  
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DatVeXemPhim_Fix
    @MaDatVe VARCHAR(50), 
    @MaKhachHang VARCHAR(50), 
    @MaSuatChieu VARCHAR(50), 
    @TongTien DECIMAL(18, 2), 
    @DanhSachGhe NVARCHAR(MAX) 
AS
BEGIN
    SET ANSI_NULLS ON; 
    SET QUOTED_IDENTIFIER ON;
    SET CONCAT_NULL_YIELDS_NULL ON;
    SET ANSI_WARNINGS ON;
    SET ANSI_PADDING ON;
    SET ARITHABORT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- [ĐỒ ÁN CHUẨN]: Chỉ dùng HOLDLOCK (Xin khóa đọc S kéo dài) để bảo vệ nhất quán dữ liệu suất chiếu
        DECLARE @Status NVARCHAR(50) = (
            SELECT TrangThai 
            FROM SUAT_CHIEU WITH (HOLDLOCK, ROWLOCK) 
            WHERE MaSuatChieu = @MaSuatChieu
        );
        
        IF @Status NOT LIKE N'%Tạm ngưng%' AND @Status NOT LIKE N'%Đã hủy%' 
            BEGIN WAITFOR DELAY '00:00:08'; END
            
        DECLARE @Status2 NVARCHAR(50) = (
            SELECT TrangThai 
            FROM SUAT_CHIEU 
            WHERE MaSuatChieu = @MaSuatChieu
        );
        
        IF @Status2 LIKE N'%Tạm ngưng%' OR @Status2 LIKE N'%Đã hủy%' 
            THROW 50002, N'Suất chiếu đã bị tạm ngưng hoặc hủy bỏ, không thể đặt vé!', 1;
            
        DECLARE @Xml XML = CAST('<x>' + REPLACE(@DanhSachGhe, ',', '</x><x>') + '</x>' AS XML);
        DECLARE @GheTable TABLE (MaGhe VARCHAR(50));
        INSERT INTO @GheTable SELECT t.value('.', 'VARCHAR(50)') FROM @Xml.nodes('/x') AS x(t);
        
        INSERT INTO DON_DAT_VE (MaDatVe, MaKhachHang, MaSuatChieu, ThoiGianDat, TongTien, TrangThai) 
        VALUES (@MaDatVe, @MaKhachHang, @MaSuatChieu, GETDATE(), @TongTien, N'Đã thanh toán');
        
        DECLARE @Count INT = (SELECT COUNT(*) FROM @GheTable);
        DECLARE @GiaVeMoiGhe DECIMAL(18,2) = @TongTien / IIF(@Count > 0, @Count, 1);
        
        INSERT INTO VE (MaVe, MaDatVe, MaGhe, MaSuatChieu, GiaVe, TrangThai) 
        SELECT @MaDatVe + '_' + gt.MaGhe, @MaDatVe, gt.MaGhe, @MaSuatChieu, @GiaVeMoiGhe, N'Đã đặt' 
        FROM @GheTable gt;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH 
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
        THROW; 
    END CATCH
END;

GO

-- TÌNH HUỐNG 4: PHANTOM  (bóng ma)
-- Giao tác Gốc gây lỗi Phantom Read (Lọc Phim đọc 2 lần có delay)
-- Giao tác T1 tìm kiếm phim theo thể loại 
CREATE PROCEDURE sp_LocPhim 
    @MaTheLoai VARCHAR(10), 
    @SkipDelay BIT = 0 
AS 
BEGIN 
    BEGIN TRANSACTION; 
    DECLARE @TongPhim INT;
    SELECT @TongPhim = COUNT(*) FROM PHIM WHERE MaTheLoai = @MaTheLoai;
    SELECT @TongPhim AS TongSoPhim;
    
    IF @SkipDelay = 0 BEGIN WAITFOR DELAY '00:00:08'; END 
    
    SELECT MaPhim, TenPhim, ThoiLuong, MaTheLoai, MoTa, AnhPoster FROM PHIM WHERE MaTheLoai = @MaTheLoai; 
    COMMIT TRANSACTION; 
END;
GO
--FIX PHANTOM 
-- Giao tác Đã Khắc Phục sửa Phantom Read bằng Snapshot Isolation
-- Chuyển sang SNAPSHOT để đọc bản chụp nhất quán trong TempDB, không bị ảnh hưởng bởi lệnh chèn mới của T2
CREATE PROCEDURE sp_LocPhim_Fix 
    @MaTheLoai VARCHAR(10), 
    @SkipDelay BIT = 0 
AS 
BEGIN 
    -- Giải pháp sửa lỗi Phantom: Sử dụng SNAPSHOT Isolation Level
    SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
    BEGIN TRANSACTION; 
    DECLARE @TongPhim INT;
    SELECT @TongPhim = COUNT(*) FROM PHIM WHERE MaTheLoai = @MaTheLoai;
    SELECT @TongPhim AS TongSoPhim;
    IF @SkipDelay = 0 BEGIN WAITFOR DELAY '00:00:08'; END 
    SELECT MaPhim, TenPhim, ThoiLuong, MaTheLoai, MoTa, AnhPoster FROM PHIM WHERE MaTheLoai = @MaTheLoai; 
    COMMIT TRANSACTION; 
END;
GO
--  Giao tác T2 đi kèm (Admin thêm phim mới)
CREATE PROCEDURE sp_ThemPhim 
    @MaPhim VARCHAR(10), 
    @MaTheLoai VARCHAR(10), 
    @TenPhim NVARCHAR(100), 
    @ThoiLuong INT, 
    @MoTa NVARCHAR(MAX),
    @AnhPoster NVARCHAR(500)
AS 
BEGIN 
    INSERT INTO PHIM (MaPhim, MaTheLoai, TenPhim, ThoiLuong, MoTa, AnhPoster) 
    VALUES (@MaPhim, @MaTheLoai, @TenPhim, @ThoiLuong, @MoTa, @AnhPoster); 
END;
GO

-- TÌNH HUỐNG 5: DEADLOCK (Khóa chết)

-- Giao tác Gốc gây lỗi Deadlock (Hủy Nhập Kho - DELETE trước, UPDATE sau)
-- Xóa phiếu trước (giữ khóa Phiếu) -> delay -> cập nhật Kho sau (Đâm sầm vào T1 đang giữ Kho chờ chèn Phiếu)
CREATE PROCEDURE sp_HuyNhapKho
    @MaPhieu VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @MaKho VARCHAR(10), @SoLuongNhap INT;
        SELECT @MaKho = MaKho, @SoLuongNhap = SoLuongNhap FROM PHIEU_NHAP_KHO WHERE MaPhieu = @MaPhieu;
        IF @MaKho IS NOT NULL
        BEGIN
            -- Xóa phiếu trước 
            DELETE FROM PHIEU_NHAP_KHO WHERE MaPhieu = @MaPhieu;
            
            -- Delay 3 giây tạo kẹt chéo
            WAITFOR DELAY '00:00:03';
            
            -- Cập nhật kho sau 
            UPDATE KHO_BAP_NUOC SET SoLuongHienCo = SoLuongHienCo - @SoLuongNhap WHERE MaKho = @MaKho;
        END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
-- Giao tác Đã Khắc Phục sửa Deadlock bằng Lock Ordering
-- Đảo trình tự: Cập nhật Kho trước, xóa Phiếu sau để cùng đi một chiều Kho -> Phiếu giống như store Nhập kho
CREATE PROCEDURE sp_HuyNhapKho_Fix
    @MaPhieu VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @MaKho VARCHAR(10), @SoLuongNhap INT;
        SELECT @MaKho = MaKho, @SoLuongNhap = SoLuongNhap FROM PHIEU_NHAP_KHO WHERE MaPhieu = @MaPhieu;
        IF @MaKho IS NOT NULL
        BEGIN
            -- Cập nhật Kho trước
            UPDATE KHO_BAP_NUOC SET SoLuongHienCo = SoLuongHienCo - @SoLuongNhap WHERE MaKho = @MaKho;
            
            -- Xóa phiếu sau
            DELETE FROM PHIEU_NHAP_KHO WHERE MaPhieu = @MaPhieu;
        END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO


-- CÁC STORED PROCEDURE CÒN LẠI 
--1.Đăng nhập 
CREATE PROCEDURE sp_DangNhap
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(50)
AS
BEGIN
    SELECT MaTaiKhoan, TenDangNhap, MatKhau, VaiTro, TrangThai 
    FROM TAI_KHOAN 
    WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND TrangThai IN (N'Kích hoạt', N'Hoạt động');
END;
GO
--2.Lấy danh sách kho 
CREATE PROCEDURE sp_LayDanhSachKho
AS
BEGIN
    SELECT MaKho, TenSanPham, SoLuongHienCo, SucChuaToiDa, MaRap, TenRap FROM vw_ThongTinKho;
END;
--3.Lấy kho theo ID
GO
CREATE PROCEDURE sp_LayKhoTheoId
    @MaKho VARCHAR(10)
AS
BEGIN
    SELECT MaKho, TenSanPham, SoLuongHienCo, SucChuaToiDa, MaRap, TenRap FROM vw_ThongTinKho WHERE MaKho = @MaKho;
END;
GO
--4. Lấy danh sách phòng chiếu phim theo Rạp
CREATE PROCEDURE sp_LayPhongTheoRap
    @MaRap VARCHAR(10)
AS
BEGIN
    SELECT MaPhong, MaRap, TenPhong, SucChua FROM PHONG_CHIEU WHERE MaRap = @MaRap;
END;
GO
-- 5. Lấy sơ đồ chọn ghế ngồi
CREATE PROCEDURE sp_LaySoDoGhe
    @MaSuatChieu VARCHAR(10)
AS
BEGIN
    SELECT g.MaGhe, g.MaPhong, g.SoGhe, g.LoaiGhe, dbo.fn_KiemTraGheDaDat(g.MaGhe, @MaSuatChieu) AS DaDat
    FROM GHE g
    INNER JOIN SUAT_CHIEU s ON g.MaPhong = s.MaPhong
    WHERE s.MaSuatChieu = @MaSuatChieu;
END;
GO
-- 6. Lấy tất cả nhà cung cấp
CREATE PROCEDURE sp_LayTatCaNhaCungCap
AS
BEGIN
    SELECT MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi FROM NHA_CUNG_CAP;
END;
GO
-- 7. Lấy danh sách nhân viên
CREATE PROCEDURE sp_LayTatCaNhanVien
AS
BEGIN
    SELECT MaNhanVien, MaTaiKhoan, HoTen, SoDienThoai FROM NHAN_VIEN;
END;
GO
--8.Lấy tất cả phim
CREATE PROCEDURE sp_LayTatCaPhim
AS
BEGIN
    SELECT MaPhim, TenPhim, ThoiLuong, MoTa, MaTheLoai, TenTheLoai, AnhPoster FROM vw_QuanLyPhim;
END;
GO
-- 9. Lấy danh sách phòng chiếu
CREATE PROCEDURE sp_LayTatCaPhong
AS
BEGIN
    SELECT MaPhong, MaRap, TenPhong, SucChua FROM PHONG_CHIEU;
END;
GO
-- 10. Lấy tất cả rạp phim
CREATE PROCEDURE sp_LayTatCaRap
AS
BEGIN
    SELECT MaRap, TenRap, DiaChi FROM RAP;
END;
GO
-- 11. Lấy danh sách tất cả suất chiếu
CREATE PROCEDURE sp_LayTatCaSuatChieu
AS
BEGIN
    SELECT MaSuatChieu, MaPhim, TenPhim, MaPhong, TenPhong, NgayChieu, GioBatDau, GioKetThuc, TrangThai FROM vw_QuanLySuatChieu;
END;
GO
--12. Lấy tất cả thể loại 
CREATE PROCEDURE sp_LayTatCaTheLoai
AS
BEGIN
    SELECT MaTheLoai, TenTheLoai FROM THE_LOAI;
END;
GO
-- 13. Lấy thông tin cá nhân khách hàng
CREATE PROCEDURE sp_LayThongTinKhachHang
    @MaTaiKhoan VARCHAR(50)
AS
BEGIN
    SELECT MaKhachHang, MaTaiKhoan, HoTen, SoDienThoai, Email FROM KHACH_HANG WHERE MaTaiKhoan = @MaTaiKhoan;
END;
GO
--14.Lịch sử đặt vé 
CREATE PROCEDURE sp_LichSuDatVe
    @MaKhachHang VARCHAR(50)
AS
BEGIN
    SELECT MaDatVe, MaKhachHang, TenKhachHang, TenPhim, NgayChieu, GioBatDau, GioKetThuc, ThoiGianDat, TongTien, TrangThai 
    FROM vw_LichSuDatVe WHERE MaKhachHang = @MaKhachHang;
END;
GO
-- 15. Lưu chỉnh sửa phim
CREATE PROCEDURE sp_LuuPhim 
    @MaPhim VARCHAR(50), 
    @TenPhim NVARCHAR(100), 
    @ThoiLuong INT, 
    @MaTheLoai VARCHAR(50), 
    @MoTa NVARCHAR(500),
    @AnhPoster NVARCHAR(500)
AS 
BEGIN 
    UPDATE PHIM SET TenPhim = @TenPhim, ThoiLuong = @ThoiLuong, MaTheLoai = @MaTheLoai, MoTa = @MoTa, AnhPoster = @AnhPoster WHERE MaPhim = @MaPhim;
END;
GO
-- 16. Sửa thông tin định mức kho bắp nước
CREATE PROCEDURE sp_LuuSanPhamKho
    @MaKho VARCHAR(50),
    @MaRap VARCHAR(50),
    @TenSanPham NVARCHAR(100),
    @SoLuongHienCo INT,
    @SucChuaToiDa INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM KHO_BAP_NUOC WHERE MaKho = @MaKho)
    BEGIN
        UPDATE KHO_BAP_NUOC 
        SET MaRap = @MaRap, TenSanPham = @TenSanPham, SoLuongHienCo = @SoLuongHienCo, SucChuaToiDa = @SucChuaToiDa 
        WHERE MaKho = @MaKho;
    END
    ELSE
    BEGIN
        INSERT INTO KHO_BAP_NUOC (MaKho, MaRap, TenSanPham, SoLuongHienCo, SucChuaToiDa)
        VALUES (@MaKho, @MaRap, @TenSanPham, @SoLuongHienCo, @SucChuaToiDa);
    END
END;
GO
-- 17. Lưu thể loại
CREATE   PROCEDURE sp_LuuTheLoai
    @MaTheLoai VARCHAR(10),
    @TenTheLoai NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM THE_LOAI WHERE MaTheLoai = @MaTheLoai)
    BEGIN
        UPDATE THE_LOAI SET TenTheLoai = @TenTheLoai WHERE MaTheLoai = @MaTheLoai;
    END
    ELSE
    BEGIN
        INSERT INTO THE_LOAI (MaTheLoai, TenTheLoai) VALUES (@MaTheLoai, @TenTheLoai);
    END
END;
GO
-- 17. Thêm suất chiếu mới
CREATE PROCEDURE sp_ThemSuatChieu
    @MaSuatChieu VARCHAR(50),
    @MaPhim VARCHAR(50),
    @MaPhong VARCHAR(50),
    @NgayChieu DATE,
    @GioBatDau TIME,
    @GioKetThuc TIME,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO SUAT_CHIEU (MaSuatChieu, MaPhim, MaPhong, NgayChieu, GioBatDau, GioKetThuc, TrangThai)
    VALUES (@MaSuatChieu, @MaPhim, @MaPhong, @NgayChieu, @GioBatDau, @GioKetThuc, @TrangThai);
END;
GO
-- 18. Xóa phim khỏi hệ thống
CREATE PROCEDURE sp_XoaPhim @MaPhim VARCHAR(50) AS 
BEGIN 
    IF EXISTS (SELECT 1 FROM SUAT_CHIEU WHERE MaPhim = @MaPhim) 
        RAISERROR(N'Không thể xóa phim đã xếp lịch!', 16, 1); 
    ELSE 
        DELETE FROM PHIM WHERE MaPhim = @MaPhim; 
END;
GO
-- 19. Xóa suất chiếu khỏi danh sách
CREATE PROCEDURE sp_XoaSuatChieu 
    @MaSuatChieu VARCHAR(10) 
AS
BEGIN
    DELETE FROM SUAT_CHIEU WHERE MaSuatChieu = @MaSuatChieu;
END;
GO
--20.Xóa thể loại 
CREATE PROCEDURE [dbo].[sp_XoaTheLoai] @MaTheLoai VARCHAR(10) AS BEGIN IF EXISTS (SELECT 1 FROM PHIM WHERE MaTheLoai = @MaTheLoai) BEGIN RAISERROR(N'Không thể xóa thể loại đã được sử dụng ở bảng Phim!', 16, 1); END ELSE BEGIN DELETE FROM THE_LOAI WHERE MaTheLoai = @MaTheLoai; END END;
GO


