using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;
using DoAnLapTrinhQuanLy.Core;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormYeuCauNhapKho : Form
    {
        private readonly YeuCauNhapKhoService _service = new YeuCauNhapKhoService();
        private readonly HangHoaService _hangHoaService = new HangHoaService();

        private DataTable _dtHangHoa;
        private string _mode = "";

        public FormYeuCauNhapKho()
        {
            InitializeComponent();
        }

        private void FormYeuCauNhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxes();
                LoadGridLookup();
                LoadData();
                SetMode("view");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }
        }

        private void LoadComboBoxes()
        {
            cboNhanVienYeuCau.DataSource = _service.LayDanhSachNhanVien();
            cboNhanVienYeuCau.DisplayMember = "HOTEN";
            cboNhanVienYeuCau.ValueMember = "MANV";
        }

        private void LoadGridLookup()
        {
            _dtHangHoa = _hangHoaService.GetAll();
            colMaHH.DataSource = _dtHangHoa;
            colMaHH.DisplayMember = "TENHH";
            colMaHH.ValueMember = "MAHH";
        }

        private void LoadData()
        {
            dgvDanhSach.DataSource = _service.LayDanhSach();
        }

        // --- SET MODE ---
        private void SetMode(string mode)
        {
            _mode = mode;
            bool isEditing = (mode == "add" || mode == "edit");

            grpInfo.Enabled = isEditing;
            dgvChiTiet.ReadOnly = !isEditing;
            dgvChiTiet.AllowUserToAddRows = isEditing;
            dgvChiTiet.AllowUserToDeleteRows = isEditing;
            grpDanhSach.Enabled = !isEditing;

            btnThem.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing && IsCurrentRowEditable();
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            bool canApprove = (Session.LoggedInUser?.TenQuyen == "Administrator" || Session.LoggedInUser?.TenQuyen == "Kế toán");
            bool isPending = IsCurrentRowPending();

            grpDuyet.Enabled = !isEditing;
            btnDuyet.Enabled = !isEditing && isPending && canApprove;
            btnTuChoi.Enabled = !isEditing && isPending && canApprove;
            txtGhiChuDuyet.ReadOnly = !canApprove;

            if (mode == "view" && dgvDanhSach.SelectedRows.Count == 0)
            {
                ClearInputs();
            }
        }

        private bool IsCurrentRowEditable() => IsCurrentRowPending();

        private bool IsCurrentRowPending()
        {
            if (dgvDanhSach.CurrentRow == null) return false;
            var val = dgvDanhSach.CurrentRow.Cells["colTrangThaiVal"].Value;
            return (val != null && Convert.ToInt32(val) == 0);
        }

        private void ClearInputs()
        {
            txtID.Text = "(Tạo mới)";
            dtpNgayYeuCau.Value = DateTime.Now;
            if (Session.LoggedInUser != null) cboNhanVienYeuCau.SelectedValue = Session.LoggedInUser.MaNV;
            txtLyDo.Text = "";
            txtGhiChuDuyet.Text = "";
            dgvChiTiet.Rows.Clear();
        }

        // --- EVENTS ---

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (_mode == "add" || _mode == "edit") return;

            if (dgvDanhSach.CurrentRow != null)
            {
                long id = Convert.ToInt64(dgvDanhSach.CurrentRow.Cells[0].Value);
                LoadDetails(id);
                SetMode("view");
            }
        }

        private void LoadDetails(long id)
        {
            DataSet ds = _service.GetChiTietPhieu(id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow m = ds.Tables[0].Rows[0];
                txtID.Text = m["ID"].ToString();
                dtpNgayYeuCau.Value = (DateTime)m["NGAY_YEUCAU"];
                cboNhanVienYeuCau.SelectedValue = m["MANV_YEUCAU"].ToString();
                txtLyDo.Text = m["LYDO"].ToString();
                txtGhiChuDuyet.Text = m["GHICHU_DUYET"].ToString();
            }

            dgvChiTiet.Rows.Clear();
            foreach (DataRow r in ds.Tables[1].Rows)
            {
                int idx = dgvChiTiet.Rows.Add();
                dgvChiTiet.Rows[idx].Cells["colMaHH"].Value = r["MAHH"].ToString();
                dgvChiTiet.Rows[idx].Cells["colDVT"].Value = r["DVT"].ToString();
                dgvChiTiet.Rows[idx].Cells["colSL"].Value = r["SOLUONG_YEUCAU"];
                dgvChiTiet.Rows[idx].Cells["colGhiChu"].Value = r["GHICHU"].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetMode("add");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!IsCurrentRowEditable())
            {
                MessageBox.Show("Chỉ được xóa phiếu ở trạng thái chờ duyệt.");
                return;
            }

            if (MessageBox.Show("Xóa phiếu yêu cầu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    long id = Convert.ToInt64(txtID.Text);
                    _service.XoaYeuCau(id);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<ChiTietYeuCauDTO> details = new List<ChiTietYeuCauDTO>();
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;
                string maHH = row.Cells["colMaHH"].Value?.ToString();
                if (string.IsNullOrEmpty(maHH)) continue;

                details.Add(new ChiTietYeuCauDTO
                {
                    MaHH = maHH,
                    SoLuong = Convert.ToInt32(row.Cells["colSL"].Value ?? 0),
                    GhiChu = row.Cells["colGhiChu"].Value?.ToString(),
                    DVT = row.Cells["colDVT"].Value?.ToString()
                });
            }

            if (details.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập chi tiết hàng hóa.");
                return;
            }

            try
            {
                long id = (_mode == "add") ? 0 : Convert.ToInt64(txtID.Text);
                string manv = cboNhanVienYeuCau.SelectedValue?.ToString();

                _service.LuuYeuCau(id, dtpNgayYeuCau.Value, manv, txtLyDo.Text, details);

                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetMode("view");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMode("view");
            dgvDanhSach_SelectionChanged(null, null);
        }

        private void btnDuyet_Click(object sender, EventArgs e) => ProcessApproval(1);
        private void btnTuChoi_Click(object sender, EventArgs e) => ProcessApproval(2);

        private void ProcessApproval(int status)
        {
            try
            {
                long id = Convert.ToInt64(txtID.Text);
                string manv = Session.LoggedInUser?.MaNV;

                if (status == 1) _service.DuyetYeuCau(id, manv, txtGhiChuDuyet.Text);
                else _service.TuChoiYeuCau(id, manv, txtGhiChuDuyet.Text);

                MessageBox.Show("Cập nhật trạng thái thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- GRID HELPERS ---

        private void DgvChiTiet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvChiTiet.CurrentCell.ColumnIndex == dgvChiTiet.Columns["colMaHH"].Index && e.Control is ComboBox comboBox)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void DgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colMaHH")
            {
                string maHH = dgvChiTiet.Rows[e.RowIndex].Cells["colMaHH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maHH))
                {
                    DataRow[] rows = _dtHangHoa.Select($"MAHH = '{maHH}'");
                    if (rows.Length > 0)
                    {
                        dgvChiTiet.Rows[e.RowIndex].Cells["colDVT"].Value = rows[0]["DVT"];
                    }
                }
            }
        }

        // --- HÀM BỔ SUNG: XỬ LÝ NÚT XÓA TRÊN LƯỚI ---
        private void DgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChiTiet.Columns[e.ColumnIndex].Name == "colXoa")
            {
                if (!dgvChiTiet.Rows[e.RowIndex].IsNewRow && !dgvChiTiet.ReadOnly)
                {
                    dgvChiTiet.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        // --- HÀM BỔ SUNG: CHẶN LỖI COMBOBOX ---
        private void DgvChiTiet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}