IF DB_ID(N'QLSinhVienLab12') IS NULL
    CREATE DATABASE QLSinhVienLab12;
GO

USE QLSinhVienLab12;
GO

IF OBJECT_ID(N'dbo.LOP', N'U') IS NULL
    CREATE TABLE dbo.LOP
    (
        MaLop  VARCHAR(15)   NOT NULL,
        TenLop NVARCHAR(100) NOT NULL,
        CONSTRAINT PK_LOP PRIMARY KEY (MaLop)
    );
GO

IF OBJECT_ID(N'dbo.SINHVIEN', N'U') IS NULL
    CREATE TABLE dbo.SINHVIEN
    (
        MaSV     VARCHAR(15)   NOT NULL,
        HoTen    NVARCHAR(100) NOT NULL,
        NgaySinh DATE          NOT NULL,
        MaLop    VARCHAR(15)   NOT NULL,
        CONSTRAINT PK_SINHVIEN PRIMARY KEY (MaSV),
        CONSTRAINT FK_SINHVIEN_LOP FOREIGN KEY (MaLop) REFERENCES dbo.LOP (MaLop)
    );
GO

IF OBJECT_ID(N'dbo.MONHOC', N'U') IS NULL
    CREATE TABLE dbo.MONHOC
    (
        MaMon    VARCHAR(10)   NOT NULL,
        TenMon   NVARCHAR(100) NOT NULL,
        SoTinChi INT           NOT NULL,
        CONSTRAINT PK_MONHOC PRIMARY KEY (MaMon),
        CONSTRAINT CK_MONHOC_SoTinChi CHECK (SoTinChi BETWEEN 1 AND 6)
    );
GO

IF OBJECT_ID(N'dbo.KETQUA', N'U') IS NULL
    CREATE TABLE dbo.KETQUA
    (
        MaSV   VARCHAR(15)   NOT NULL,
        MaMon  VARCHAR(10)   NOT NULL,
        Diem   DECIMAL(4, 2) NOT NULL,
        GhiChu NVARCHAR(200) NULL,
        CONSTRAINT PK_KETQUA PRIMARY KEY (MaSV, MaMon),
        CONSTRAINT FK_KETQUA_SINHVIEN FOREIGN KEY (MaSV) REFERENCES dbo.SINHVIEN (MaSV),
        CONSTRAINT FK_KETQUA_MONHOC FOREIGN KEY (MaMon) REFERENCES dbo.MONHOC (MaMon),
        CONSTRAINT CK_KETQUA_Diem CHECK (Diem BETWEEN 0 AND 10)
    );
GO

IF NOT EXISTS (SELECT 1 FROM dbo.LOP)
    INSERT INTO dbo.LOP (MaLop, TenLop)
    VALUES
        ('51.01.CNTT.A', N'CNTT K51 - Lớp A'),
        ('51.01.CNTT.B', N'CNTT K51 - Lớp B'),
        ('50.01.CNTT.A', N'CNTT K50 - Lớp A');
GO

IF NOT EXISTS (SELECT 1 FROM dbo.SINHVIEN)
    INSERT INTO dbo.SINHVIEN (MaSV, HoTen, NgaySinh, MaLop)
    VALUES
        ('51.01.104.001', N'Nguyễn Minh Anh',  '2005-03-12', '51.01.CNTT.A'),
        ('51.01.104.002', N'Trần Quốc Bảo',    '2005-07-25', '51.01.CNTT.A'),
        ('51.01.104.003', N'Lê Thị Cẩm Chi',   '2005-01-09', '51.01.CNTT.A'),
        ('51.01.104.004', N'Phạm Hoàng Dũng',  '2005-11-30', '51.01.CNTT.A'),
        ('51.01.104.005', N'Võ Ngọc Hà',       '2005-05-18', '51.01.CNTT.A'),
        ('51.01.104.006', N'Đặng Gia Huy',     '2005-09-02', '51.01.CNTT.B'),
        ('51.01.104.007', N'Bùi Thanh Lam',    '2005-02-14', '51.01.CNTT.B'),
        ('51.01.104.008', N'Huỳnh Mỹ Linh',    '2005-12-21', '51.01.CNTT.B'),
        ('51.01.104.009', N'Ngô Thành Long',   '2005-06-06', '51.01.CNTT.B'),
        ('51.01.104.010', N'Phan Thu Ngân',    '2005-08-27', '51.01.CNTT.B'),
        ('50.01.104.011', N'Lý Anh Quân',      '2004-04-03', '50.01.CNTT.A'),
        ('50.01.104.012', N'Trương Bích Thảo', '2004-10-16', '50.01.CNTT.A'),
        ('50.01.104.013', N'Dương Văn Tín',    '2004-01-28', '50.01.CNTT.A'),
        ('50.01.104.014', N'Hồ Thị Uyên',      '2004-07-11', '50.01.CNTT.A'),
        ('50.01.104.015', N'Mai Quốc Việt',    '2004-12-05', '50.01.CNTT.A');
GO

IF NOT EXISTS (SELECT 1 FROM dbo.MONHOC)
    INSERT INTO dbo.MONHOC (MaMon, TenMon, SoTinChi)
    VALUES
        ('COMP1011', N'Nhập môn lập trình', 3),
        ('COMP1015', N'Cơ sở dữ liệu', 3),
        ('COMP1018', N'Lập trình hướng đối tượng', 3),
        ('COMP1019', N'Lập trình trên Windows', 3),
        ('MATH1001', N'Toán rời rạc', 2);
GO

IF NOT EXISTS (SELECT 1 FROM dbo.KETQUA)
    INSERT INTO dbo.KETQUA (MaSV, MaMon, Diem, GhiChu)
    VALUES
        ('51.01.104.001', 'COMP1019', 8.50, N'Chuyên cần tốt'),
        ('51.01.104.002', 'COMP1019', 7.25, NULL),
        ('51.01.104.003', 'COMP1019', 4.50, N'Cần cố gắng thêm'),
        ('51.01.104.006', 'COMP1019', 5.00, NULL),
        ('51.01.104.007', 'COMP1019', 3.75, N'Vắng nhiều buổi'),
        ('51.01.104.001', 'COMP1015', 9.00, NULL),
        ('51.01.104.002', 'COMP1015', 6.50, NULL);
GO

CREATE OR ALTER PROCEDURE dbo.sp_Lop_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaLop, TenLop
    FROM dbo.LOP
    ORDER BY TenLop;
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_MonHoc_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaMon, TenMon, SoTinChi
    FROM dbo.MONHOC
    ORDER BY TenMon;
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_KetQua_GetByLopMon
    @MaLop VARCHAR(15),
    @MaMon VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT sv.MaSV, sv.HoTen, kq.Diem, kq.GhiChu
    FROM dbo.SINHVIEN AS sv
    LEFT JOIN dbo.KETQUA AS kq
        ON kq.MaSV = sv.MaSV AND kq.MaMon = @MaMon
    WHERE sv.MaLop = @MaLop
    ORDER BY sv.MaSV;
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_KetQua_Save
    @MaSV   VARCHAR(15),
    @MaMon  VARCHAR(10),
    @Diem   DECIMAL(4, 2),
    @GhiChu NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Diem IS NULL OR @Diem NOT BETWEEN 0 AND 10
        THROW 50001, N'Điểm phải nằm trong khoảng từ 0 đến 10.', 1;

    UPDATE dbo.KETQUA
    SET Diem = @Diem, GhiChu = @GhiChu
    WHERE MaSV = @MaSV AND MaMon = @MaMon;

    IF @@ROWCOUNT = 0
        INSERT INTO dbo.KETQUA (MaSV, MaMon, Diem, GhiChu)
        VALUES (@MaSV, @MaMon, @Diem, @GhiChu);
END
GO
