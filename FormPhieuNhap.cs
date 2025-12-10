using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;
using DoAnLapTrinhQuanLy; // Quan trọng: Để gọi được ReportService

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuNhap : Form
    {
        // Service
        private readonly PhieuNhapService _service = new PhieuNhapService();
        private readonly NhaCungCapService _nccService = new NhaCungCapService();
        private readonly HangHoaService _hangHoaService = new HangHoaService();

        // Biến cục bộ
        private DataTable _dtHangHoa; // Cache danh sách hàng
        private long _idYeuCau = 0;   // Lưu ID phiếu yêu cầu

        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
        }

        private void LoadData()
        {
            try
            {
                // 1. Load Nhà cung cấp
                cboNhaCungCap.DataSource = _nccService.GetAll();
                cboNhaCungCap.DisplayMember = "TEN_NCC";
                cboNhaCungCap.ValueMember = "MA_NCC";
                cboNhaCungCap.SelectedIndex = -1;

                // 2. Load Hàng hóa
                _dtHangHoa = _hangHoaService.GetAll();
                colMaHH.DataSource = _dtHangHoa;
                colMaHH.DisplayMember = "TENHH";
                colMaHH.ValueMember = "MAHH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtSoPhieu.Text = "";
            txtGhiChu.Text = "";
            dgvChiTiet.Rows.Clear();
            lblTongTien.Text = "0 đ";
            chkThanhToan.Checked = false;
            _idYeuCau = 0;

            cboNhaCungCap.SelectedIndex = -1;
            dtpNgayNhap.Value = DateTime.Now;

            // Logic nút bấm: Mới vào cho Lưu, cấm In (vì chưa có số phiếu)
            btnLuu.Enabled = true;
            btnIn.Enabled = false;

            dgvChiTiet.ReadOnly = false;
            dgvChiTiet.AllowUserToAddRows = true;
        }

        // --- XỬ LÝ LƯỚI (GRID) ---
        private void dgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colMaHH"].Index && e.Control is ComboBox comboBox)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colSoLuong"].Index ||
                dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colDonGia"].Index)
            {
                e.Control.KeyPress -= Numeric_KeyPress;
                e.Control.KeyPress += Numeric_KeyPress;
            }
        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void dgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            // Tự điền thông tin hàng
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colMaHH")
            {
                string maHH = row.Cells["colMaHH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH))
                {
                    DataRow[] found = _dtHangHoa.Select($"MAHH = '{maHH}'");
                    if (found.Length > 0)
                    {
                        row.Cells["colDVT"].Value = found[0]["DVT"];
                        if (row.Cells["colDonGia"].Value == null || Convert.ToDecimal(row.Cells["colDonGia"].Value) == 0)
                            row.Cells["colDonGia"].Value = found[0]["GIAVON"];
                        if (row.Cells["colSoLuong"].Value == null)
                            row.Cells["colSoLuong"].Value = 1;
                    }
                }
            }

            // Tính tiền
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colSoLuong" ||
                dgvChiTiet.Columns[e.ColumnIndex].Name == "colDonGia" ||
                dgvChiTiet.Columns[e.ColumnIndex].Name == "colMaHH")
            {
                decimal sl = 0, gia = 0;
                if (row.Cells["colSoLuong"].Value != null) decimal.TryParse(row.Cells["colSoLuong"].Value.ToString(), out sl);
                if (row.Cells["colDonGia"].Value != null) decimal.TryParse(row.Cells["colDonGia"].Value.ToString(), out gia);

                row.Cells["colThanhTien"].Value = sl * gia;
                TinhTongCong();
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChiTiet.Columns[e.ColumnIndex].Name == "colXoa")
            {
                if (!dgvChiTiet.Rows[e.RowIndex].IsNewRow)
                {
                    dgvChiTiet.Rows.RemoveAt(e.RowIndex);
                    TinhTongCong();
                }
            }
        }

        private void dgvChiTiet_DataError(object sender, DataGridViewDataErrorEventArgs e) => e.Cancel = true;

        private void TinhTongCong()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells["colThanhTien"].Value != null)
                    tong += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
            }
            lblTongTien.Text = tong.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        }

        // --- CÁC NÚT CHỨC NĂNG ---
        private void btnThem_Click(object sender, EventArgs e) => ClearInputs();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp!", "Cảnh báo");
                return;
            }

            var listChiTiet = new List<PhieuNhapChiTietDTO>();
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["colMaHH"].Value == null) continue;

                listChiTiet.Add(new PhieuNhapChiTietDTO
                {
                    MaHH = row.Cells["colMaHH"].Value.ToString(),
                    SoLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value ?? 0),
                    DonGia = Convert.ToDecimal(row.Cells["colDonGia"].Value ?? 0),
                    DVT = row.Cells["colDVT"].Value?.ToString(),
                    GhiChu = row.Cells["colGhiChuHang"].Value?.ToString()
                });
            }

            if (listChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có mặt hàng nào.", "Cảnh báo");
                return;
            }

            try
            {
                string maNCC = cboNhaCungCap.SelectedValue.ToString();
                long soPhieu = _service.LuuPhieuNhap(
                    dtpNgayNhap.Value,
                    maNCC,
                    txtGhiChu.Text,
                    _idYeuCau,
                    chkThanhToan.Checked,
                    listChiTiet
                );

                MessageBox.Show("Lưu thành công! Số phiếu: " + soPhieu);
                txtSoPhieu.Text = soPhieu.ToString();

                // Lưu xong thì cho phép In
                btnLuu.Enabled = false;
                btnIn.Enabled = true; // Bật sáng nút In

                dgvChiTiet.ReadOnly = true;
                dgvChiTiet.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ==========================================================
        // ĐÂY LÀ CHỖ QUAN TRỌNG: GỌI HÀM IN BẰNG NÚT CŨ (btnIn)
        // ==========================================================
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text))
            {
                MessageBox.Show("Chưa có số phiếu để in. Vui lòng lưu phiếu trước!", "Thông báo");
                return;
            }

            try
            {
                // Gọi Service in phiếu tui đã viết cho bà
                ReportService.InPhieu(txtSoPhieu.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi in: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => this.Close();

        private void btnChonPhieuYeuCau_Click(object sender, EventArgs e)
        {
            using (var f = new FormChonPhieuYeuCau())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _idYeuCau = f.SelectedYeuCauID;
                    LoadChiTietYeuCau(_idYeuCau);
                }
            }
        }

        private void LoadChiTietYeuCau(long idYeuCau)
        {
            try
            {
                dgvChiTiet.Rows.Clear();
                DataTable dt = _service.GetChiTietYeuCau(idYeuCau);

                foreach (DataRow row in dt.Rows)
                {
                    decimal slCon = Convert.ToDecimal(row["SL_CON_LAI"]);
                    if (slCon <= 0) continue;

                    string maHH = row["MAHH"].ToString();
                    decimal gia = Convert.ToDecimal(row["GIAVON"]);

                    int idx = dgvChiTiet.Rows.Add();
                    dgvChiTiet.Rows[idx].Cells["colMaHH"].Value = maHH;
                    dgvChiTiet.Rows[idx].Cells["colDVT"].Value = row["DVT"].ToString();
                    dgvChiTiet.Rows[idx].Cells["colSoLuong"].Value = slCon;
                    dgvChiTiet.Rows[idx].Cells["colDonGia"].Value = gia;

                    dgvChiTiet_CellValueChanged(dgvChiTiet, new DataGridViewCellEventArgs(dgvChiTiet.Columns["colSoLuong"].Index, idx));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải yêu cầu: " + ex.Message);
            }
        }
    }
}