USE master;
GO

-- Drop the database if it already exists to start fresh
IF DB_ID('CSDLNhaHang') IS NOT NULL
BEGIN
    ALTER DATABASE CSDLNhaHang SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CSDLNhaHang;
END
GO

CREATE DATABASE CSDLNhaHang;
GO

USE CSDLNhaHang;
GO

-- Bảng Tài Khoản (Account Table)
CREATE TABLE TaiKhoan (
    tenTaiKhoan NVARCHAR(50) PRIMARY KEY, -- Changed to NVARCHAR
    matKhau NVARCHAR(100) NOT NULL,     -- Changed to NVARCHAR
    quyen NVARCHAR(50) NOT NULL         -- Changed to NVARCHAR
);
GO

INSERT INTO TaiKhoan (tenTaiKhoan, matKhau, quyen) VALUES
('longnv', '1234', N'Quản lý'),
('duclh', '1234', N'Nhân viên'),
('sangdh', '1234', N'Nhân viên'),
('hoanglan', '1234', N'Quản lý');
GO

-- Bảng Nhân Viên (Employee Table)
CREATE TABLE NhanVien (
    maNhanVien INT PRIMARY KEY IDENTITY(1,1),
    tenNhanVien NVARCHAR(100) NOT NULL,    -- Increased length
    soDienThoai NVARCHAR(15) NOT NULL,     -- Changed to NVARCHAR
    chungMinhThu NVARCHAR(20) NOT NULL,    -- Changed to NVARCHAR
    tenTaiKhoan NVARCHAR(50),            -- Changed to NVARCHAR
    CONSTRAINT FK_NhanVien_TaiKhoan FOREIGN KEY (tenTaiKhoan)
        REFERENCES TaiKhoan(tenTaiKhoan)
        ON UPDATE CASCADE
        ON DELETE SET NULL -- Or CASCADE/RESTRICT depending on business rules
);
GO

INSERT INTO NhanVien (tenNhanVien, soDienThoai, chungMinhThu, tenTaiKhoan) VALUES
(N'Nguyễn Văn Long', '0969010998', '122244567', 'longnv'),
(N'Lê Huỳnh Đức', '0349010998', '123444567', 'duclh'),
(N'Đinh Huy Sáng', '0969010348', '122244534', 'sangdh');
-- Add more employees if needed, potentially linking to 'hoanglan' or having NULL tenTaiKhoan
GO

-- Bảng Loại Món Ăn (Dish Category Table - Replaces LoaiHang)
CREATE TABLE LoaiMonAn (
    maLoaiMonAn INT PRIMARY KEY IDENTITY(1,1),
    tenLoaiMonAn NVARCHAR(100) NOT NULL -- Increased length
);
GO

-- Adapted from LoaiHang data
INSERT INTO LoaiMonAn (tenLoaiMonAn) VALUES
(N'Mì'),
(N'Bún nước'),
(N'Cơm tẻ'),
(N'Cơm nếp'),
(N'Món cá'),
(N'Món thịt'),
(N'Rau'),
(N'Lẩu'),
(N'Đồ khô'),
(N'Đồ uống'), -- Changed from Bia for broader category
(N'Xôi'),
(N'Nướng');
GO

-- Bảng Nhà Cung Cấp (Supplier Table)
CREATE TABLE NhaCungCap (
    maNhaCungCap INT PRIMARY KEY IDENTITY(1,1),
    tenNhaCungCap NVARCHAR(100) NOT NULL, -- Increased length
    diaChi NVARCHAR(200) NOT NULL
);
GO

INSERT INTO NhaCungCap (tenNhaCungCap, diaChi) VALUES
(N'BBQ', N'Hà Nội'),
(N'Nhất Nhất', N'Hà Nội'),
(N'Wang', N'Hồ Chí Minh'),
(N'Hoàng Lan', N'Hải Phòng'),
(N'Ajinomoto', N'Hà Nội'), -- Corrected spelling
(N'Đệ Nhất', N'Hưng Yên'),
(N'Thăng Long', N'Hà Nội'),
(N'Hải Hà', N'Bắc Ninh'),
(N'Ngân Hương', N'Bắc Giang'),
(N'PepsiCo', N'Hà Nội'); -- Changed name slightly
GO

-- Bảng Món Ăn (Dish Table - Replaces Hang)
CREATE TABLE MonAn (
    maMonAn INT PRIMARY KEY IDENTITY(1,1),
    tenMonAn NVARCHAR(100) NOT NULL,    -- Increased length
    donViTinh NVARCHAR(50) NOT NULL,
    donGia DECIMAL(18, 2) NOT NULL,    -- Changed to DECIMAL
    soLuongCon INT NOT NULL,
    maLoaiMonAn INT NOT NULL,
    maNhaCungCap INT NOT NULL,
    CONSTRAINT FK_MonAn_LoaiMonAn FOREIGN KEY (maLoaiMonAn)
        REFERENCES LoaiMonAn(maLoaiMonAn)
        ON UPDATE CASCADE
        ON DELETE CASCADE, -- Or RESTRICT/SET NULL
    CONSTRAINT FK_MonAn_NhaCungCap FOREIGN KEY (maNhaCungCap)
        REFERENCES NhaCungCap(maNhaCungCap)
        ON UPDATE CASCADE
        ON DELETE CASCADE -- Or RESTRICT/SET NULL
);
GO

-- Adapted from Hang data (assuming LoaiMonAn IDs match the order above, starting from 1)
-- Verify maLoaiMonAn and maNhaCungCap IDs based on actual inserted values if needed
INSERT INTO MonAn (tenMonAn, donViTinh, donGia, soLuongCon, maLoaiMonAn, maNhaCungCap) VALUES
(N'Bún bò Huế', N'Bát', 35000.00, 100, 2, 3), -- Example: Assuming Bún nước is ID 2, Wang is ID 3
(N'Bia Hà Nội', N'Chai', 15000.00, 100, 10, 10), -- Example: Assuming Đồ uống is ID 10, PepsiCo is ID 10
(N'Coca Cola', N'Lon', 10000.00, 100, 10, 10), -- Example: Assuming Đồ uống is ID 10, PepsiCo is ID 10
(N'Phở bò', N'Bát', 40000.00, 100, 2, 3), -- Example: Assuming Bún nước is ID 2, Wang is ID 3
(N'Thịt Bò Tái', N'Đĩa', 150000.00, 50, 6, 1), -- Example: Assuming Món thịt is ID 6, BBQ is ID 1
(N'Canh Cua Rau Đay', N'Bát', 50000.00, 100, 7, 4), -- Example: Assuming Rau is ID 7, Hoàng Lan is ID 4
(N'Thịt bò nướng', N'Đĩa', 250000.00, 100, 12, 1), -- Example: Assuming Nướng is ID 12, BBQ is ID 1
(N'Cá Hấp Xì Dầu', N'Con', 300000.00, 30, 5, 8), -- Example: Assuming Món cá is ID 5, Hải Hà is ID 8
(N'Lẩu Thái Chua Cay', N'Nồi', 350000.00, 20, 8, 6), -- Example: Assuming Lẩu is ID 8, Đệ Nhất is ID 6
(N'Set Nướng 199k', N'Set', 199000.00, 50, 12, 1), -- Example: Assuming Nướng is ID 12, BBQ is ID 1
(N'Lẩu Buffet 199k', N'Suất', 199000.00, 100, 8, 6); -- Example: Assuming Lẩu is ID 8, Đệ Nhất is ID 6
GO


-- Bảng Loại Khách Hàng (Customer Category Table)
CREATE TABLE LoaiKhachHang (
    maLoaiKhachHang INT PRIMARY KEY IDENTITY(1,1),
    tenLoaiKhachHang NVARCHAR(100) NOT NULL -- Increased length
);
GO

INSERT INTO LoaiKhachHang (tenLoaiKhachHang) VALUES
(N'Khách hàng mới'),
(N'Khách hàng thân thiết'), -- Changed from cũ
(N'Khách hàng VIP'); -- Changed from thường xuyên
GO

-- Bảng Khách Hàng (Customer Table)
CREATE TABLE KhachHang (
    maKhachHang INT PRIMARY KEY IDENTITY(1,1),
    hoTen NVARCHAR(100) NOT NULL,       -- Standardized column name, increased length
    diaChi NVARCHAR(200) NOT NULL,
    soDienThoai NVARCHAR(15) NOT NULL,  -- Changed to NVARCHAR
    maLoaiKhachHang INT NOT NULL,
    CONSTRAINT FK_KhachHang_LoaiKhachHang FOREIGN KEY (maLoaiKhachHang)
        REFERENCES LoaiKhachHang(maLoaiKhachHang)
        ON UPDATE CASCADE
        ON DELETE CASCADE -- Or RESTRICT
);
GO
-- Assuming LoaiKhachHang IDs match order above (1, 2, 3)
INSERT INTO KhachHang (hoTen, diaChi, soDienThoai, maLoaiKhachHang) VALUES
(N'Hoàng Thu Trang', N'Bắc Ninh', '0969222000', 1),
(N'Hoàng Bắc', N'Tuyên Quang', '0969222345', 3),
(N'Nguyễn Thị An', N'Bắc Ninh', '0969222765', 1),
(N'Nông Văn Huy', N'Cao Bằng', '0969222678', 2),
(N'Hứa Thanh Huy', N'Cao Bằng', '0969222242', 1),
(N'Nguyễn Văn Thành', N'Gia Lai', '0969222333', 3),
(N'Quách Tĩnh', N'Hà Nội', '0969222000', 3),
(N'Hứa Huyền Trang', N'Bắc Ninh', '0969222043', 1),
(N'Hà Văn Đạt', N'Hải Phòng', '0969222066', 1),
(N'Nguyễn Minh Lăng', N'Bắc Ninh', '0969222765', 3),
(N'Trần Văn Toàn', N'Thái Bình', '0969222678', 1),
(N'Ngô Thị Phương', N'Bắc Giang', '0969222654', 3),
(N'Nguyễn Thị Thư', N'Bắc Ninh', '0969222045', 2),
(N'Nguyễn Bá An', N'Hà Tĩnh', '0969222032', 1),
(N'Lương Văn Hà', N'Bắc Ninh', '0969222023', 1),
(N'Hoàng Dung', N'Nam Định', '0969222065', 2);
GO

-- Bảng Bàn Ăn (Dining Table Table)
CREATE TABLE BanAn (
    maBan INT PRIMARY KEY IDENTITY(1,1),
    tenBan NVARCHAR(50) NOT NULL,
    viTri NVARCHAR(100) NULL, -- Added from QL_NhaHang schema
    trangThai NVARCHAR(50) NOT NULL -- Ví dụ: Trống, Đã đặt, Đang phục vụ
);
GO
-- Add sample tables
INSERT INTO BanAn (tenBan, viTri, trangThai) VALUES
(N'Bàn 1', N'Gần cửa sổ', N'Trống'),
(N'Bàn 2', N'Góc trong', N'Trống'),
(N'Bàn 3 VIP', N'Phòng riêng 1', N'Trống'),
(N'Bàn 4', N'Gần cửa sổ', N'Trống');
GO

-- Bảng Đặt Bàn (Booking Table)
CREATE TABLE DatBan (
    maDatBan INT PRIMARY KEY IDENTITY(1,1),
    maKhachHang INT NULL, -- Allow anonymous booking? Or NOT NULL?
    maBan INT NOT NULL,
    thoiGianDat DATETIME NOT NULL,
    soNguoi INT NOT NULL,
    ghiChu NVARCHAR(255) NULL,
    CONSTRAINT FK_DatBan_KhachHang FOREIGN KEY (maKhachHang)
        REFERENCES KhachHang(maKhachHang)
        ON UPDATE CASCADE
        ON DELETE SET NULL, -- Keep booking record even if customer deleted?
    CONSTRAINT FK_DatBan_BanAn FOREIGN KEY (maBan)
        REFERENCES BanAn(maBan)
        ON UPDATE CASCADE
        ON DELETE CASCADE -- If table deleted, booking is invalid
);
GO
-- Add sample booking (adjust maKhachHang/maBan as needed)
-- Get current time for thoiGianDat
DECLARE @bookingTime DATETIME = GETDATE();
INSERT INTO DatBan (maKhachHang, maBan, thoiGianDat, soNguoi, ghiChu) VALUES
(2, 3, DATEADD(hour, 2, @bookingTime), 4, N'Yêu cầu ghế trẻ em'); -- KhachHang ID 2 (Hoang Bac) books Ban ID 3 (VIP) in 2 hours
GO
-- Optionally update table status
UPDATE BanAn SET trangThai = N'Đã đặt' WHERE maBan = 3;
GO


-- Bảng Hóa Đơn (Invoice Table)
CREATE TABLE HoaDon (
    maHoaDon INT PRIMARY KEY IDENTITY(1,1),
    ngayGioTao DATETIME NOT NULL DEFAULT GETDATE(), -- Use default for creation time
    maKhachHang INT NOT NULL,
    maNhanVien INT NOT NULL,
    maDatBan INT NULL, -- Link to booking (optional)
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (maKhachHang)
        REFERENCES KhachHang(maKhachHang)
        ON UPDATE NO ACTION -- Usually don't cascade customer changes to old invoices
        ON DELETE NO ACTION, -- Usually keep invoices even if customer deleted
    CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (maNhanVien)
        REFERENCES NhanVien(maNhanVien)
        ON UPDATE NO ACTION -- Usually don't cascade employee changes
        ON DELETE NO ACTION, -- Usually keep invoices even if employee deleted
    CONSTRAINT FK_HoaDon_DatBan FOREIGN KEY (maDatBan)
        REFERENCES DatBan(maDatBan)
        ON UPDATE NO ACTION
        ON DELETE SET NULL -- If booking deleted, unlink from invoice but keep invoice
);
GO -- GO after CREATE TABLE is fine

-- Bảng Chi Tiết Hóa Đơn (Invoice Details Table)
CREATE TABLE ChiTietHoaDon (
    maHoaDon INT NOT NULL,
    maMonAn INT NOT NULL,           -- Changed from maHang
    soLuong INT NOT NULL,
    thanhTien DECIMAL(18, 2) NOT NULL, -- Changed to DECIMAL
    PRIMARY KEY (maHoaDon, maMonAn), -- Composite primary key
    CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (maHoaDon)
        REFERENCES HoaDon(maHoaDon)
        ON UPDATE CASCADE -- Cascade if HoaDon PK changes (unlikely with IDENTITY)
        ON DELETE CASCADE, -- If invoice deleted, delete details
    CONSTRAINT FK_ChiTietHoaDon_MonAn FOREIGN KEY (maMonAn)
        REFERENCES MonAn(maMonAn)
        ON UPDATE CASCADE -- Cascade if MonAn PK changes (unlikely with IDENTITY)
        ON DELETE NO ACTION -- Usually keep invoice detail even if menu item deleted (record price at time of sale)
);
GO -- GO after CREATE TABLE is fine

-- === BEGIN BATCH FOR INSERTING INVOICE AND DETAILS ===
-- Khai báo biến ở đầu batch
DECLARE @LastInvoiceID INT;

-- Adapted sample invoice - Need valid maKhachHang, maNhanVien. maDatBan is NULL here.
-- Using maKhachHang=1 (Hoang Thu Trang), maNhanVien=1 (Nguyen Van Long)
INSERT INTO HoaDon (ngayGioTao, maKhachHang, maNhanVien, maDatBan) VALUES
('2024-05-18T10:30:00', 1, 1, NULL); -- Using a more standard date format

-- Get the ID of the inserted invoice immediately after insert, store in variable
SET @LastInvoiceID = SCOPE_IDENTITY();

-- Adapted sample details for the invoice created above (@LastInvoiceID)
-- Need valid maMonAn IDs. Assuming maMonAn=1 (Bun bo Hue), maMonAn=2 (Bia Ha Noi)
-- Use the @LastInvoiceID variable captured after inserting into HoaDon
INSERT INTO ChiTietHoaDon (maHoaDon, maMonAn, soLuong, thanhTien)
SELECT @LastInvoiceID, 1, 2, (SELECT donGia FROM MonAn WHERE maMonAn = 1) * 2 -- Bun Bo Hue x 2
UNION ALL
SELECT @LastInvoiceID, 2, 4, (SELECT donGia FROM MonAn WHERE maMonAn = 2) * 4; -- Bia Ha Noi x 4
-- Note: thanhTien is often calculated, but storing it captures the price at the time of the transaction.

-- === END BATCH ===
GO -- GO here, after the related inserts are done

-- Print confirmation
SELECT 'Database CSDLNhaHang created and populated successfully.' AS Status;
GO

