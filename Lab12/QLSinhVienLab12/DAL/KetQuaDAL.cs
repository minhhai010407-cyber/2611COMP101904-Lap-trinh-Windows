using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLSinhVienLab12.DAL
{
    /// <summary>Truy cập dữ liệu lớp, môn học và kết quả học tập thông qua stored procedure.</summary>
    public class KetQuaDAL
    {
        public DataTable LayDanhSachLop()
        {
            return Database.LayBang("sp_Lop_GetAll");
        }

        public DataTable LayDanhSachMonHoc()
        {
            return Database.LayBang("sp_MonHoc_GetAll");
        }

        public DataTable LayKetQuaTheoLopMon(string maLop, string maMon)
        {
            return Database.LayBang("sp_KetQua_GetByLopMon",
                new SqlParameter("@MaLop", SqlDbType.VarChar, 15) { Value = maLop },
                new SqlParameter("@MaMon", SqlDbType.VarChar, 10) { Value = maMon });
        }

        /// <summary>Lưu toàn bộ dòng trong một transaction: một dòng lỗi thì rollback tất cả.</summary>
        public int LuuTatCa(string maMon, DataTable bangKetQua)
        {
            using SqlConnection connection = Database.TaoKetNoi();
            connection.Open();

            using SqlTransaction transaction = connection.BeginTransaction();
            using var command = new SqlCommand("sp_KetQua_Save", connection, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlParameter thamSoMaSV = command.Parameters.Add("@MaSV", SqlDbType.VarChar, 15);
            command.Parameters.Add("@MaMon", SqlDbType.VarChar, 10).Value = maMon;
            SqlParameter thamSoDiem = command.Parameters.Add(
                new SqlParameter("@Diem", SqlDbType.Decimal) { Precision = 4, Scale = 2 });
            SqlParameter thamSoGhiChu = command.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 200);

            string maSVDangLuu = null;
            try
            {
                foreach (DataRow dong in bangKetQua.Rows)
                {
                    maSVDangLuu = (string)dong["MaSV"];
                    thamSoMaSV.Value = maSVDangLuu;
                    thamSoDiem.Value = dong["Diem"];
                    thamSoGhiChu.Value = LayGhiChu(dong);
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                return bangKetQua.Rows.Count;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new DataException(
                    $"Không thể lưu điểm của sinh viên {maSVDangLuu}. {ex.Message}", ex);
            }
        }

        private static object LayGhiChu(DataRow dong)
        {
            return dong["GhiChu"] is string ghiChu && !string.IsNullOrWhiteSpace(ghiChu)
                ? (object)ghiChu.Trim()
                : DBNull.Value;
        }
    }
}
