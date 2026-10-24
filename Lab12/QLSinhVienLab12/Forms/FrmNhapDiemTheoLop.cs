using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLSinhVienLab12.DAL;
using QLSinhVienLab12.Helpers;

namespace QLSinhVienLab12.Forms
{
    public partial class FrmNhapDiemTheoLop : Form
    {
        private const decimal DiemDat = 5m;
        private const int SoLoiToiDaHienThi = 8;

        private readonly KetQuaDAL _ketQuaDal = new KetQuaDAL();
        private string _maMonDangNhap;

        public FrmNhapDiemTheoLop()
        {
            InitializeComponent();
        }

        private void FrmNhapDiemTheoLop_Load(object sender, EventArgs e) => LoadComboBox();

        private void btnTaiDanhSach_Click(object sender, EventArgs e) => TaiDanhSach();

        private void btnLuuTatCa_Click(object sender, EventArgs e) => LuuTatCa();

        private void dgvKetQua_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != colDiem.Index)
            {
                return;
            }

            string text = Convert.ToString(e.FormattedValue);
            string loi = string.IsNullOrWhiteSpace(text) ? null : DiemValidator.KiemTraChuoi(text);

            dgvKetQua.Rows[e.RowIndex].ErrorText = loi ?? string.Empty;
            if (loi != null)
            {
                e.Cancel = true;
                CapNhatTrangThai($"Dòng {e.RowIndex + 1}: {loi}");
            }
        }

        private void dgvKetQua_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDiem.Index)
            {
                CapNhatThongKe();
            }
        }

        private void dgvKetQua_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colDiem.Index && e.Value is decimal diem && diem < DiemDat)
            {
                e.CellStyle.ForeColor = Color.Firebrick;
            }
        }

        private void dgvKetQua_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            CapNhatTrangThai("Giá trị vừa nhập không hợp lệ. Vui lòng kiểm tra lại.");
        }

        private void LoadComboBox()
        {
            try
            {
                bsLop.DataSource = _ketQuaDal.LayDanhSachLop();
                bsMonHoc.DataSource = _ketQuaDal.LayDanhSachMonHoc();
            }
            catch (Exception ex)
            {
                btnTaiDanhSach.Enabled = false;
                HienThiLoiHeThong(ex);
                return;
            }

            CapNhatTrangThai("Sẵn sàng. Chọn lớp, môn học rồi bấm Tải danh sách.");
        }

        private void TaiDanhSach()
        {
            if (cboLop.SelectedValue is not string maLop || cboMonHoc.SelectedValue is not string maMon)
            {
                MessageBox.Show(this, "Vui lòng chọn lớp và môn học.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CoThayDoiChuaLuu() && !XacNhanBoThayDoi())
            {
                return;
            }

            DataTable bang;
            try
            {
                bang = _ketQuaDal.LayKetQuaTheoLopMon(maLop, maMon);
            }
            catch (Exception ex)
            {
                HienThiLoiHeThong(ex);
                return;
            }

            _maMonDangNhap = maMon;
            bsKetQua.DataSource = bang;
            grpKetQua.Text = $"Danh sách sinh viên - {cboLop.Text} - {cboMonHoc.Text}";
            btnLuuTatCa.Enabled = bang.Rows.Count > 0;

            CapNhatThongKe();
            CapNhatTrangThai(bang.Rows.Count > 0
                ? $"Đã tải {bang.Rows.Count} sinh viên. Nhập điểm rồi bấm Lưu tất cả."
                : "Lớp này chưa có sinh viên nào.");
        }

        private void LuuTatCa()
        {
            if (!dgvKetQua.EndEdit() || !KiemTraTatCaDong())
            {
                return;
            }

            var bang = (DataTable)bsKetQua.DataSource;
            try
            {
                int soDong = _ketQuaDal.LuuTatCa(_maMonDangNhap, bang);
                bang.AcceptChanges();

                CapNhatTrangThai($"Đã lưu {soDong} dòng điểm thành công.");
                MessageBox.Show(this, $"Đã lưu thành công {soDong} dòng điểm.", "Lưu điểm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                CapNhatTrangThai("Lưu điểm thất bại, toàn bộ thao tác đã được hủy.");
                MessageBox.Show(this,
                    "Lưu điểm thất bại. Toàn bộ thao tác đã được hủy (rollback), không có dòng nào được lưu.\n\n"
                    + ex.Message,
                    "Lỗi lưu điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KiemTraTatCaDong()
        {
            var dsLoi = new List<string>();
            DataGridViewRow dongLoiDauTien = null;

            foreach (DataGridViewRow dong in dgvKetQua.Rows)
            {
                DataRow dongDuLieu = ((DataRowView)dong.DataBoundItem).Row;
                string loi = DiemValidator.KiemTraGiaTri(dongDuLieu["Diem"]);

                dong.ErrorText = loi ?? string.Empty;
                if (loi == null)
                {
                    continue;
                }

                dongLoiDauTien ??= dong;
                dsLoi.Add($"- {dongDuLieu["MaSV"]} ({dongDuLieu["HoTen"]}): {loi}");
            }

            if (dsLoi.Count == 0)
            {
                return true;
            }

            string chiTiet = string.Join(Environment.NewLine, dsLoi.Take(SoLoiToiDaHienThi));
            if (dsLoi.Count > SoLoiToiDaHienThi)
            {
                chiTiet += $"{Environment.NewLine}... và {dsLoi.Count - SoLoiToiDaHienThi} dòng khác.";
            }

            dgvKetQua.CurrentCell = dongLoiDauTien.Cells[colDiem.Index];
            CapNhatTrangThai($"Có {dsLoi.Count} dòng điểm chưa hợp lệ, chưa lưu.");
            MessageBox.Show(this,
                $"Không thể lưu vì có {dsLoi.Count} dòng điểm chưa hợp lệ:\n\n{chiTiet}",
                "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private bool CoThayDoiChuaLuu()
        {
            return bsKetQua.DataSource is DataTable bang
                && bang.Rows.Cast<DataRow>().Any(dong => dong.RowState != DataRowState.Unchanged);
        }

        private bool XacNhanBoThayDoi()
        {
            DialogResult ketQua = MessageBox.Show(this,
                "Bạn có thay đổi chưa lưu. Tải danh sách mới sẽ làm mất các thay đổi này. Tiếp tục?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            return ketQua == DialogResult.Yes;
        }

        private void CapNhatThongKe()
        {
            if (bsKetQua.DataSource is not DataTable bang)
            {
                return;
            }

            List<decimal> dsDiem = bang.AsEnumerable()
                .Where(dong => !dong.IsNull("Diem"))
                .Select(dong => dong.Field<decimal>("Diem"))
                .ToList();

            tslSiSo.Text = $"Sĩ số: {bang.Rows.Count}";
            tslDaNhap.Text = $"Đã nhập điểm: {dsDiem.Count}";
            tslDiemTrungBinh.Text = dsDiem.Count == 0
                ? "Điểm trung bình: --"
                : $"Điểm trung bình: {dsDiem.Average():0.00}";
        }

        private void CapNhatTrangThai(string noiDung)
        {
            tslTrangThai.Text = noiDung;
        }

        private void HienThiLoiHeThong(Exception ex)
        {
            CapNhatTrangThai("Không thể truy cập cơ sở dữ liệu.");
            MessageBox.Show(this,
                "Không thể thực hiện thao tác với cơ sở dữ liệu.\n"
                + "Vui lòng kiểm tra SQL Server, chuỗi kết nối trong appsettings.json "
                + "và đã chạy script Database/QLSinhVienLab12.sql hay chưa.\n\n"
                + $"Chi tiết: {ex.GetBaseException().Message}",
                "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
