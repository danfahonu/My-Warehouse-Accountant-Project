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
    public partial class FormYeuCauNhapKho : System.Windows.Forms.Form
    {
        private readonly YeuCauNhapKhoService _service = new YeuCauNhapKhoService();
        private DataTable _dtHangHoa;
        private string _mode = ""; // "view", "add", "edit"

        public FormYeuCauNhapKho()
        {
            InitializeComponent();
        }

        private void FormYeuCauNhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                ApplyModernUI();
                SetupGrids();
                LoadComboBoxes();
                LoadData();
                SetMode("view");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }
        }

        private void ApplyModernUI()
        {
            this.BackColor = Color.FromArgb(241, 245, 249); // Light Gray Background
                                                            // Ensure child controls have transparent backgrounds where needed or consistent styling
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox gb)
                {
                    gb.ForeColor = Color.Black; // Reset text color
                }
            }
        }

        private void SetupGrids()
        {
            // === Master Grid ===
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.AutoGenerateColumns = false;

            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID", Width = 50 });
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày YC", DataPropertyName = "NGAY_YEUCAU", Width = 100 });
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lý Do", DataPropertyName = "LYDO", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng Thái", DataPropertyName = "TRANGTHAI_TEXT", Width = 120 });
            // Hidden State Column
            dgvDanhSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTrangThai", DataPropertyName = "TRANGTHAI", Visible = false });

            // === Detail Grid ===
            dgvChiTiet.Columns.Clear();
            dgvChiTiet.AutoGenerateColumns = false;

            _dtHangHoa = _service.LayDanhSachHangHoa();

            var colMaHH = new DataGridViewComboBoxColumn();
            colMaHH.HeaderText = "Hàng Hóa";
            colMaHH.Name = "colMaHH";
            colMaHH.DataPropertyName = "MAHH";
            colMaHH.DataSource = _dtHangHoa;
            colMaHH.DisplayMember = "TENHH";
            colMaHH.ValueMember = "MAHH";
            colMaHH.Width = 250;
            colMaHH.FlatStyle = FlatStyle.Flat;
            dgvChiTiet.Columns.Add(colMaHH);

            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ĐVT", Name = "colDVT", DataPropertyName = "DVT", ReadOnly = true, Width = 80 });

            var colSL = new DataGridViewTextBoxColumn { HeaderText = "Số Lượng", Name = "colSL", DataPropertyName = "SOLUONG_YEUCAU", Width = 100 };
            colSL.DefaultCellStyle.Format = "N0";
            dgvChiTiet.Columns.Add(colSL);

            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ghi Chú", Name = "colGhiChu", DataPropertyName = "GHICHU", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvChiTiet.EditingControlShowing += DgvChiTiet_EditingControlShowing;
            dgvChiTiet.CellValueChanged += DgvChiTiet_CellValueChanged;
            dgvChiTiet.DataError += (s, e) => { }; // Suppress ComboBox errors
        }

        private void LoadComboBoxes()
        {
            cboNhanVienYeuCau.DataSource = _service.LayDanhSachNhanVien();
            cboNhanVienYeuCau.DisplayMember = "HOTEN";
            cboNhanVienYeuCau.ValueMember = "MANV";
        }

        private void LoadData()
        {
            dgvDanhSach.DataSource = _service.LayDanhSach();
        }

        private void SetMode(string mode)
        {
            _mode = mode;
            bool isEditing = (mode == "add" || mode == "edit");

            grpInfo.Enabled = isEditing;
            dgvChiTiet.ReadOnly = !isEditing;
            dgvChiTiet.AllowUserToAddRows = isEditing;
            dgvChiTiet.AllowUserToDeleteRows = isEditing;
            dgvDanhSach.Enabled = !isEditing;

            btnThem.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing && IsCurrentRowEditable();
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;

            // Approval Buttons logic
            bool canApprove = (Session.LoggedInUser?.TenQuyen == "Administrator" || Session.LoggedInUser?.TenQuyen == "Kế toán");
            bool isPending = IsCurrentRowPending();

            grpAction.Enabled = !isEditing;
            btnDuyet.Enabled = !isEditing && isPending && canApprove;
            btnTuChoi.Enabled = !isEditing && isPending && canApprove;
            txtGhiChuDuyet.ReadOnly = !canApprove;

            if (mode == "view" && dgvDanhSach.SelectedRows.Count == 0)
            {
                ClearInputs();
            }
        }

        private bool IsCurrentRowEditable()
        {
            return IsCurrentRowPending();
        }

        private bool IsCurrentRowPending()
        {
            if (dgvDanhSach.CurrentRow == null) return false;
            var val = dgvDanhSach.CurrentRow.Cells["colTrangThai"].Value;
            return (val != null && Convert.ToInt32(val) == 0);
        }

        private void ClearInputs()
        {
            txtID.Text = "(Tạo mới)";
            dtpNgayYeuCau.Value = DateTime.Now;
            if (Session.LoggedInUser != null) cboNhanVienYeuCau.SelectedValue = Session.LoggedInUser.MaNV;
            txtLyDo.Text = "";
            txtGhiChuDuyet.Text = "";
            dgvChiTiet.DataSource = null;
            dgvChiTiet.Rows.Clear();
        }

        // === Event Handlers ===

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (_mode == "add" || _mode == "edit") return;

            if (dgvDanhSach.CurrentRow != null)
            {
                long id = Convert.ToInt64(dgvDanhSach.CurrentRow.Cells[0].Value);
                LoadDetails(id);

                // Update button states based on selection status
                SetMode("view");
            }
        }

        private void LoadDetails(long id)
        {
            DataSet ds = _service.GetChiTietPhieu(id);
            if (ds.Tables["Master"].Rows.Count > 0)
            {
                DataRow m = ds.Tables["Master"].Rows[0];
                txtID.Text = m["ID"].ToString();
                dtpNgayYeuCau.Value = (DateTime)m["NGAY_YEUCAU"];
                cboNhanVienYeuCau.SelectedValue = m["MANV_YEUCAU"].ToString();
                txtLyDo.Text = m["LYDO"].ToString();
                txtGhiChuDuyet.Text = m["GHICHU_DUYET"].ToString();
            }

            // Bind Grid
            // Convert DataTable to a List or just bind directly if columns match
            // Since we use ComboBox, we need to be careful with binding.
            // Let's manually populate to ensure safe combobox behavior or use binding source.
            // Direct Binding is fine if columns map correctly.
            dgvChiTiet.DataSource = ds.Tables["Detail"];
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

            if (MessageBox.Show("Xóa phiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            dgvDanhSach_SelectionChanged(null, null); // Reload selection
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            ProcessApproval(1);
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            ProcessApproval(2);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcessApproval(int status)
        {
            try
            {
                long id = Convert.ToInt64(txtID.Text);
                string manv = Session.LoggedInUser?.MaNV;

                if (status == 1)
                {
                    _service.DuyetYeuCau(id, manv, txtGhiChuDuyet.Text);
                }
                else if (status == 2)
                {
                    _service.TuChoiYeuCau(id, manv, txtGhiChuDuyet.Text);
                }

                MessageBox.Show("Cập nhật trạng thái thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // === Grid Helpers ===
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
    }
}