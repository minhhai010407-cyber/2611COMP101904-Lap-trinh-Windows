using System;
using System.Drawing;

namespace StudentCardApp.Models
{
    /// <summary>
    /// Dữ liệu sinh viên dùng để vẽ thẻ (preview và in).
    /// </summary>
    public class StudentInfo
    {
        public string StudentId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.Today;
        public Image Avatar { get; set; }
    }
}
