USE EduManagerDB;
GO

INSERT INTO KHOA (MaKhoa, TenKhoa) VALUES
('CNTT', N'Công nghệ Thông tin'),
('SPTOAN', N'Sư phạm Toán học');
GO

INSERT INTO LOP (MaLop, TenLop, MaKhoa) VALUES
('COMP01', N'Công nghệ Thông tin A', 'CNTT'),
('COMP02', N'Sư phạm Tin học', 'CNTT'),
('MATH01', N'Sư phạm Toán A', 'SPTOAN');
GO

INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop) VALUES
('SV01', N'Ngô Minh Hải', '2007-04-01', N'Nam', 'COMP01'),
('SV02', N'Nguyễn Văn An', '2007-05-12', N'Nam', 'COMP01'),
('SV03', N'Trần Thị Bình', '2007-08-20', N'Nữ', 'COMP01'),
('SV04', N'Lê Hoàng Cường', '2007-01-15', N'Nam', 'COMP02'),
('SV05', N'Phạm Mai Dung', '2007-11-30', N'Nữ', 'COMP02'),
('SV06', N'Võ Quốc Khánh', '2007-09-02', N'Nam', 'MATH01'),
('SV07', N'Đặng Thu Thảo', '2007-12-10', N'Nữ', 'MATH01');
GO

INSERT INTO MONHOC (MaMH, TenMH, SoTinChi) VALUES
('COMP1019', N'Lập trình trên Windows', 3),
('COMP1010', N'Cơ sở dữ liệu', 4),
('COMP1001', N'Nhập môn Lập trình', 3),
('MATH1001', N'Giải tích 1', 3);
GO

INSERT INTO KETQUA (MaSV, MaMH, Diem) VALUES
('SV01', 'COMP1019', 9.0),
('SV01', 'COMP1010', 8.5),
('SV02', 'COMP1019', 7.5),
('SV02', 'COMP1001', 8.0),
('SV03', 'COMP1019', 8.5),
('SV04', 'COMP1010', 6.5),
('SV05', 'COMP1001', 9.5),
('SV06', 'MATH1001', 8.0);
GO

INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES
('admin', '123', N'Quản trị viên', N'Admin'),
('user', '123', N'Nhân viên đào tạo', N'User');
GO
