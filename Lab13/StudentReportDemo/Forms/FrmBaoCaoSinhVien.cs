using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentReportDemo.Models;

namespace StudentReportDemo.Forms
{
    public partial class FrmBaoCaoSinhVien : Form
    {
        private const string TatCaLop = "Tất cả lớp";
        private const string TatCaKetQua = "Tất cả";
        private const string PhanCachCsv = ",";
        private const string PhanCachTxt = "\t";

        private readonly List<SinhVien> _danhSach = TaoDuLieuMau();
        private readonly DataGridViewColumn[] _cotBaoCao;
        private readonly DataGridViewColumn[] _cotThongKe;

        public FrmBaoCaoSinhVien()
        {
            InitializeComponent();

            _cotBaoCao = new DataGridViewColumn[] { colMaSV, colHoTen, colMaLop, colTenLop, colDiem, colKetQua };
            _cotThongKe = new DataGridViewColumn[]
            {
                colTkMaLop, colTkTenLop, colTkSoSinhVien, colTkSoDat, colTkSoKhongDat, colTkDiemTrungBinh
            };
        }

        private void FrmBaoCaoSinhVien_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            XemBaoCao();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e) => XemBaoCao();

        private void btnThongKe_Click(object sender, EventArgs e) => ThongKeTheoLop();

        private void btnXuatFile_Click(object sender, EventArgs e) => XuatFile();

        private void dgvBaoCao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colKetQua.Index && e.Value is string ketQua)
            {
                e.CellStyle.ForeColor = ketQua == SinhVien.KetQuaDat ? Color.SeaGreen : Color.Firebrick;
            }
        }

        private static List<SinhVien> TaoDuLieuMau()
        {
            const string maLopA51 = "51.01.CNTT.A";
            const string tenLopA51 = "CNTT K51 - Lớp A";
            const string maLopB51 = "51.01.CNTT.B";
            const string tenLopB51 = "CNTT K51 - Lớp B";
            const string maLopA50 = "50.01.CNTT.A";
            const string tenLopA50 = "CNTT K50 - Lớp A";

            return new List<SinhVien>
            {
                new("51.01.104.001", "Nguyễn Minh Anh", maLopA51, tenLopA51, 8.5),
                new("51.01.104.002", "Trần Quốc Bảo", maLopA51, tenLopA51, 7.25),
                new("51.01.104.003", "Lê Thị Cẩm Chi", maLopA51, tenLopA51, 4.5),
                new("51.01.104.004", "Phạm Hoàng Dũng", maLopA51, tenLopA51, 6.75),
                new("51.01.104.005", "Võ Ngọc Hà", maLopA51, tenLopA51, 9),
                new("51.01.104.006", "Đặng Gia Huy", maLopB51, tenLopB51, 5),
                new("51.01.104.007", "Bùi Thanh Lam", maLopB51, tenLopB51, 3.75),
                new("51.01.104.008", "Huỳnh Mỹ Linh", maLopB51, tenLopB51, 7.9),
                new("51.01.104.009", "Ngô Thành Long", maLopB51, tenLopB51, 6),
                new("51.01.104.010", "Phan Thu Ngân", maLopB51, tenLopB51, 8.25),
                new("50.01.104.011", "Lý Anh Quân", maLopA50, tenLopA50, 7),
                new("50.01.104.012", "Trương Bích Thảo", maLopA50, tenLopA50, 5.5),
                new("50.01.104.013", "Dương Văn Tín", maLopA50, tenLopA50, 2.75),
                new("50.01.104.014", "Hồ Thị Uyên", maLopA50, tenLopA50, 8),
                new("50.01.104.015", "Mai Quốc Việt", maLopA50, tenLopA50, 4.9)
            };
        }

        private void LoadComboBox()
        {
            var danhSachLop = _danhSach
                .Select(sv => new { sv.MaLop, sv.TenLop })
                .Distinct()
                .OrderBy(lop => lop.TenLop)
                .Prepend(new { MaLop = string.Empty, TenLop = TatCaLop })
                .ToList();

            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = danhSachLop;

            cboKetQua.Items.AddRange(new object[] { TatCaKetQua, SinhVien.KetQuaDat, SinhVien.KetQuaKhongDat });
            cboKetQua.SelectedIndex = 0;
        }

        private void XemBaoCao()
        {
            List<SinhVien> ketQuaLoc = LocDuLieu();

            HienThi(ketQuaLoc, laThongKe: false);
            CapNhatThongKe(ketQuaLoc);

            if (ketQuaLoc.Count == 0)
            {
                MessageBox.Show(this, "Không có sinh viên nào phù hợp với điều kiện đã chọn.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<SinhVien> LocDuLieu()
        {
            string maLop = cboLop.SelectedValue as string;
            string ketQua = cboKetQua.SelectedItem as string;
            string tuKhoa = txtTuKhoa.Text.Trim();

            return _danhSach
                .Where(sv => string.IsNullOrEmpty(maLop) || sv.MaLop == maLop)
                .Where(sv => ketQua == TatCaKetQua || sv.KetQua == ketQua)
                .Where(sv => tuKhoa.Length == 0
                    || sv.MaSV.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                    || sv.HoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(sv => sv.Diem)
                .ThenBy(sv => sv.HoTen)
                .ToList();
        }

        private void ThongKeTheoLop()
        {
            List<ThongKeLop> thongKe = _danhSach
                .GroupBy(sv => new { sv.MaLop, sv.TenLop })
                .Select(nhom => new ThongKeLop
                {
                    MaLop = nhom.Key.MaLop,
                    TenLop = nhom.Key.TenLop,
                    SoSinhVien = nhom.Count(),
                    SoDat = nhom.Count(sv => sv.Dat),
                    SoKhongDat = nhom.Count(sv => !sv.Dat),
                    DiemTrungBinh = Math.Round(nhom.Average(sv => sv.Diem), 2)
                })
                .OrderBy(lop => lop.TenLop)
                .ToList();

            HienThi(thongKe, laThongKe: true);
            CapNhatThongKe(_danhSach);
        }

        private void CapNhatThongKe(IReadOnlyCollection<SinhVien> danhSach)
        {
            int soDat = danhSach.Count(sv => sv.Dat);
            double diemTrungBinh = danhSach.Select(sv => sv.Diem).DefaultIfEmpty().Average();

            tslTongSo.Text = $"Tổng số sinh viên: {danhSach.Count}";
            tslSoDat.Text = $"Đạt: {soDat}";
            tslSoKhongDat.Text = $"Không đạt: {danhSach.Count - soDat}";
            tslDiemTrungBinh.Text = $"Điểm trung bình: {diemTrungBinh:0.00}";
        }

        private void HienThi(object nguonDuLieu, bool laThongKe)
        {
            foreach (DataGridViewColumn cot in _cotBaoCao)
            {
                cot.Visible = !laThongKe;
            }

            foreach (DataGridViewColumn cot in _cotThongKe)
            {
                cot.Visible = laThongKe;
            }

            grpKetQua.Text = laThongKe ? "Thống kê theo lớp" : "Danh sách sinh viên";
            dgvBaoCao.DataSource = nguonDuLieu;
        }

        private void XuatFile()
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show(this, "Không có dữ liệu để xuất. Vui lòng xem báo cáo hoặc thống kê trước.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (sfdBaoCao.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            string phanCach = Path.GetExtension(sfdBaoCao.FileName).Equals(".txt", StringComparison.OrdinalIgnoreCase)
                ? PhanCachTxt
                : PhanCachCsv;

            try
            {
                File.WriteAllLines(sfdBaoCao.FileName, TaoDongXuat(phanCach), new UTF8Encoding(true));
                MessageBox.Show(this, $"Đã xuất báo cáo thành công:\n{sfdBaoCao.FileName}",
                    "Xuất file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                MessageBox.Show(this, $"Không thể ghi file. {ex.Message}",
                    "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IEnumerable<string> TaoDongXuat(string phanCach)
        {
            List<DataGridViewColumn> cot = dgvBaoCao.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();

            yield return NoiCacO(cot.Select(c => c.HeaderText), phanCach);

            foreach (DataGridViewRow dong in dgvBaoCao.Rows)
            {
                yield return NoiCacO(
                    cot.Select(c => Convert.ToString(dong.Cells[c.Index].Value, CultureInfo.InvariantCulture)),
                    phanCach);
            }
        }

        private static string NoiCacO(IEnumerable<string> cacO, string phanCach)
        {
            return string.Join(phanCach, phanCach == PhanCachCsv ? cacO.Select(MaHoaCsv) : cacO);
        }

        private static string MaHoaCsv(string giaTri)
        {
            return giaTri.IndexOfAny(new[] { ',', '"', '\r', '\n' }) >= 0
                ? $"\"{giaTri.Replace("\"", "\"\"")}\""
                : giaTri;
        }
    }
}
