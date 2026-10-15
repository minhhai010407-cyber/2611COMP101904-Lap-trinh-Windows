USE EduManagerDB;
GO

-- 1. Liệt kê toàn bộ sinh viên
SELECT MaSV, HoTen, NgaySinh, GioiTinh, MaLop
FROM SINHVIEN;
GO

-- 2. Liệt kê sinh viên kèm tên lớp và tên khoa
SELECT sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, l.TenLop, k.TenKhoa
FROM SINHVIEN sv
INNER JOIN LOP l ON sv.MaLop = l.MaLop
INNER JOIN KHOA k ON l.MaKhoa = k.MaKhoa;
GO

-- 3. Tìm sinh viên theo một phần họ tên bằng LIKE
SELECT MaSV, HoTen, NgaySinh, GioiTinh, MaLop
FROM SINHVIEN
WHERE HoTen LIKE N'%Hải%';
GO

-- 4. Liệt kê sinh viên theo mã lớp
SELECT MaSV, HoTen, NgaySinh, GioiTinh, MaLop
FROM SINHVIEN
WHERE MaLop = 'COMP01';
GO

-- 5. Cập nhật họ tên hoặc lớp của một sinh viên
UPDATE SINHVIEN
SET MaLop = 'COMP02'
WHERE MaSV = 'SV03';
GO

-- 6. Xóa một sinh viên chưa có dữ liệu điểm
DELETE FROM SINHVIEN
WHERE MaSV = 'SV07'
  AND NOT EXISTS (SELECT 1 FROM KETQUA WHERE MaSV = 'SV07');
GO

-- 7. Liệt kê điểm của từng sinh viên theo từng môn
SELECT sv.MaSV, sv.HoTen, mh.MaMH, mh.TenMH, kq.Diem
FROM KETQUA kq
INNER JOIN SINHVIEN sv ON kq.MaSV = sv.MaSV
INNER JOIN MONHOC mh ON kq.MaMH = mh.MaMH;
GO

-- 8. Tính điểm trung bình của từng sinh viên
SELECT sv.MaSV, sv.HoTen, ROUND(AVG(kq.Diem), 2) AS DiemTrungBinh
FROM SINHVIEN sv
LEFT JOIN KETQUA kq ON sv.MaSV = kq.MaSV
GROUP BY sv.MaSV, sv.HoTen;
GO

-- 9. Thống kê số sinh viên theo từng lớp
SELECT l.MaLop, l.TenLop, COUNT(sv.MaSV) AS SoLuongSinhVien
FROM LOP l
LEFT JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
GROUP BY l.MaLop, l.TenLop;
GO

-- 10. Liệt kê các lớp có từ 2 sinh viên trở lên
SELECT l.MaLop, l.TenLop, COUNT(sv.MaSV) AS SoLuongSinhVien
FROM LOP l
INNER JOIN SINHVIEN sv ON l.MaLop = sv.MaLop
GROUP BY l.MaLop, l.TenLop
HAVING COUNT(sv.MaSV) >= 2;
GO

-- 11. Test lỗi khi thêm sinh viên vào lớp không tồn tại
BEGIN TRY
    INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop)
    VALUES ('SV99', N'Lê Văn Lỗi', '2007-01-01', N'Nam', 'LOP_AO');
END TRY
BEGIN CATCH
    SELECT ERROR_NUMBER() AS MaLoi, ERROR_MESSAGE() AS ThongBaoLoi_KhoaNgoaiLop;
END CATCH;
GO

-- 12. Test lỗi khi nhập điểm ngoài khoảng 0 đến 10
BEGIN TRY
    INSERT INTO KETQUA (MaSV, MaMH, Diem)
    VALUES ('SV01', 'MATH1001', 15.0);
END TRY
BEGIN CATCH
    SELECT ERROR_NUMBER() AS MaLoi, ERROR_MESSAGE() AS ThongBaoLoi_RangBuocDiem;
END CATCH;
GO
