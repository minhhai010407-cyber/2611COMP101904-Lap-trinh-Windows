using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace QLSinhVienLab12.DAL
{
    /// <summary>Cấu hình kết nối và tiện ích gọi stored procedure dùng chung cho tầng DAL.</summary>
    public static class Database
    {
        private const string TenChuoiKetNoi = "QLSinhVienLab12";

        private static readonly Lazy<string> ChuoiKetNoi = new Lazy<string>(DocChuoiKetNoi);

        public static SqlConnection TaoKetNoi() => new SqlConnection(ChuoiKetNoi.Value);

        public static DataTable LayBang(string tenProcedure, params SqlParameter[] thamSo)
        {
            using SqlConnection connection = TaoKetNoi();
            using var command = new SqlCommand(tenProcedure, connection) { CommandType = CommandType.StoredProcedure };
            command.Parameters.AddRange(thamSo);

            using var adapter = new SqlDataAdapter(command);
            var bang = new DataTable();
            adapter.Fill(bang);
            return bang;
        }

        private static string DocChuoiKetNoi()
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build()
                .GetConnectionString(TenChuoiKetNoi);
        }
    }
}
