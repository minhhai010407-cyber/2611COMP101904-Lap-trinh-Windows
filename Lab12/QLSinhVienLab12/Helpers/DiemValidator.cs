using System.Globalization;

namespace QLSinhVienLab12.Helpers
{
    /// <summary>Kiểm tra điểm: không rỗng, là số và nằm trong khoảng từ 0 đến 10.</summary>
    public static class DiemValidator
    {
        public const decimal DiemToiThieu = 0m;
        public const decimal DiemToiDa = 10m;

        public static string KiemTraChuoi(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return "Điểm không được để trống.";
            }

            const NumberStyles kieuSo = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
            if (!decimal.TryParse(text.Trim(), kieuSo, CultureInfo.CurrentCulture, out decimal diem))
            {
                return $"Điểm phải là một số (ví dụ {7.5m.ToString(CultureInfo.CurrentCulture)}).";
            }

            return KiemTraKhoang(diem);
        }

        public static string KiemTraGiaTri(object giaTri)
        {
            if (giaTri is decimal diem)
            {
                return KiemTraKhoang(diem);
            }

            return "Điểm không được để trống.";
        }

        private static string KiemTraKhoang(decimal diem)
        {
            return diem < DiemToiThieu || diem > DiemToiDa
                ? $"Điểm phải nằm trong khoảng từ {DiemToiThieu:0} đến {DiemToiDa:0}."
                : null;
        }
    }
}
