using System.Data;
using Microsoft.Data.SqlClient;

namespace Lab11_QuanLyLopHoc
{
    public partial class FrmQuanLyLop : Form
    {
        private readonly string _connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=EduManagerDB;Integrated Security=True;TrustServerCertificate=True;";
        private bool _daChonLop = false;

        public FrmQuanLyLop()
        {
            InitializeComponent();
        }

        private void FrmQuanLyLop_Load(object sender, EventArgs e)
        {
            TaiDanhSachLop();
        }

        private void TaiDanhSachLop()
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                const string sql = "SELECT MaLop, TenLop FROM LOP ORDER BY MaLop";
                using SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                HienThiLenLuoi(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiLenLuoi(DataTable dt)
        {
            dgvLop.DataSource = dt;
            if (dgvLop.Columns["MaLop"] != null)
            {
                dgvLop.Columns["MaLop"].HeaderText = "Mã lớp";
                dgvLop.Columns["MaLop"].FillWeight = 35;
            }
            if (dgvLop.Columns["TenLop"] != null)
            {
                dgvLop.Columns["TenLop"].HeaderText = "Tên lớp";
                dgvLop.Columns["TenLop"].FillWeight = 65;
            }
            dgvLop.ClearSelection();
        }

        private bool KiemTraTrungMaLop(string maLop)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            const string sql = "SELECT COUNT(1) FROM LOP WHERE MaLop = @MaLop";
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private bool KiemTraLopCoSinhVien(string maLop)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            const string sql = "SELECT COUNT(1) FROM SINHVIEN WHERE MaLop = @MaLop";
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private void LamMoiNhapLieu()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtTimKiem.Clear();
            txtMaLop.ReadOnly = false;
            _daChonLop = false;
            dgvLop.ClearSelection();
            txtMaLop.Focus();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLop.Rows[e.RowIndex];
            txtMaLop.Text = row.Cells["MaLop"].Value?.ToString() ?? string.Empty;
            txtTenLop.Text = row.Cells["TenLop"].Value?.ToString() ?? string.Empty;
            txtMaLop.ReadOnly = true;
            _daChonLop = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã lớp và tên lớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (KiemTraTrungMaLop(maLop))
                {
                    MessageBox.Show("Mã lớp đã tồn tại. Vui lòng nhập mã lớp khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLop.Focus();
                    return;
                }

                using SqlConnection conn = new SqlConnection(_connectionString);
                const string sql = "INSERT INTO LOP (MaLop, TenLop) VALUES (@MaLop, @TenLop)";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachLop();
                LamMoiNhapLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (!_daChonLop || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp từ danh sách để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Tên lớp không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                const string sql = "UPDATE LOP SET TenLop = @TenLop WHERE MaLop = @MaLop";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật tên lớp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachLop();
                    LamMoiNhapLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã lớp cần cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();

            if (!_daChonLop || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp từ danh sách để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (KiemTraLopCoSinhVien(maLop))
                {
                    MessageBox.Show("Không thể xóa lớp này vì đang có sinh viên thuộc lớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa lớp '{maLop}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                using SqlConnection conn = new SqlConnection(_connectionString);
                const string sql = "DELETE FROM LOP WHERE MaLop = @MaLop";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa lớp học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachLop();
                LamMoiNhapLieu();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Không thể xóa lớp này do ràng buộc khóa ngoại với dữ liệu sinh viên.", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                const string sql = "SELECT MaLop, TenLop FROM LOP WHERE MaLop LIKE @TuKhoa OR TenLop LIKE @TuKhoa ORDER BY MaLop";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                HienThiLenLuoi(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiNhapLieu();
            TaiDanhSachLop();
        }
    }
}
