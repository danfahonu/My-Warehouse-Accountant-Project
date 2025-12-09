using System;
using System.Data;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormThuChi : Form
    {
        private readonly ThuChiService _service = new ThuChiService();
        private string _mode = "";

        public FormThuChi()
        {
            InitializeComponent();
            // --- 3 DÒNG THẦN THÁNH ---
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormThuChi_Load(object sender, EventArgs e)
        {
            cboFilterLoai.SelectedIndex = 0;
            LoadData();
            SetMode("view");
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = _service.GetAll();
                if (cboFilterLoai.SelectedIndex > 0)
                {
                    string loai = cboFilterLoai.SelectedIndex == 1 ? "T" : "C";
                    dt.DefaultView.RowFilter = $"LOAI = '{loai}'";
                }

                dgvDanhSach.DataSource = dt;

                if (dgvDanhSach.Columns.Contains("SOPTC")) dgvDanhSach.Columns["SOPTC"].HeaderText = "Số Phiếu";
                if (dgvDanhSach.Columns.Contains("NGAYLAP")) dgvDanhSach.Columns["NGAYLAP"].HeaderText = "Ngày Lập";
                if (dgvDanhSach.Columns.Contains("SOTIEN"))
                {
                    dgvDanhSach.Columns["SOTIEN"].HeaderText = "Số Tiền";
                    dgvDanhSach.Columns["SOTIEN"].DefaultCellStyle.Format = "N0";
                }

                // Ẩn cột không cần
                string[] hiddenCols = { "LOAI", "MAKH", "MA_NCC", "TEN_NCC", "TENKH", "SOTK_NO", "SOTK_CO", "LYDO", "MANV" };
                foreach (string col in hiddenCols)
                    if (dgvDanhSach.Columns.Contains(col)) dgvDanhSach.Columns[col].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải: " + ex.Message); }
        }

        private void radDoiTuong_CheckedChanged(object sender, EventArgs e)
        {
            if (radKhachHang.Checked)
            {
                cboDoiTuong.DataSource = _service.GetKhachHang();
                cboDoiTuong.DisplayMember = "TENKH";
                cboDoiTuong.ValueMember = "MAKH";
            }
            else
            {
                cboDoiTuong.DataSource = _service.GetNhaCungCap();
                cboDoiTuong.DisplayMember = "TEN_NCC";
                cboDoiTuong.ValueMember = "MA_NCC";
            }
            cboDoiTuong.SelectedIndex = -1;
        }

        private void SetMode(string mode)
        {
            _mode = mode;
            bool isEditing = (_mode == "add" || _mode == "edit");

            grpDetail.Enabled = isEditing;
            grpList.Enabled = !isEditing;

            btnThem.Visible = !isEditing;
            btnSua.Visible = !isEditing && dgvDanhSach.Rows.Count > 0;
            btnXoa.Visible = !isEditing && dgvDanhSach.Rows.Count > 0;
            btnLuu.Visible = isEditing;
            btnHuy.Visible = isEditing;

            if (_mode == "view" && dgvDanhSach.CurrentRow != null) DisplayDetail(dgvDanhSach.CurrentRow);
            else if (_mode == "add") ClearInputs();
        }

        private void ClearInputs()
        {
            txtSoPhieu.Text = "PT" + DateTime.Now.ToString("ddHHmm");
            dtpNgayLap.Value = DateTime.Now;
            cboLoaiPhieu.SelectedIndex = 0;
            radKhachHang.Checked = true;
            txtSoTien.Text = "0";
            txtLyDo.Text = "";
        }

        private void DisplayDetail(DataGridViewRow row)
        {
            try
            {
                txtSoPhieu.Text = row.Cells["SOPTC"].Value.ToString();
                dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NGAYLAP"].Value);
                txtSoTien.Text = Convert.ToDecimal(row.Cells["SOTIEN"].Value).ToString("N0");
                txtLyDo.Text = row.Cells["LYDO"].Value.ToString();
                txtTkNo.Text = row.Cells["SOTK_NO"].Value.ToString();
                txtTkCo.Text = row.Cells["SOTK_CO"].Value.ToString();

                string loai = row.Cells["LOAI"].Value.ToString();
                cboLoaiPhieu.SelectedIndex = loai == "T" ? 0 : 1;

                if (row.Cells["MAKH"].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells["MAKH"].Value.ToString()))
                {
                    radKhachHang.Checked = true;
                    cboDoiTuong.SelectedValue = row.Cells["MAKH"].Value;
                }
                else
                {
                    radNhaCungCap.Checked = true;
                    cboDoiTuong.SelectedValue = row.Cells["MA_NCC"].Value;
                }
            }
            catch { }
        }

        private void cboLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiPhieu.SelectedIndex == 0)
            { // Thu
                txtTkNo.Text = "1111"; txtTkCo.Text = "131";
                if (txtSoPhieu.Text.StartsWith("PC")) txtSoPhieu.Text = txtSoPhieu.Text.Replace("PC", "PT");
            }
            else
            { // Chi
                txtTkNo.Text = "331"; txtTkCo.Text = "1111";
                if (txtSoPhieu.Text.StartsWith("PT")) txtSoPhieu.Text = txtSoPhieu.Text.Replace("PT", "PC");
            }
        }

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null && _mode == "view") DisplayDetail(dgvDanhSach.CurrentRow);
        }

        private void cboFilterLoai_SelectedIndexChanged(object sender, EventArgs e) => LoadData();

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetMode("add");
            cboLoaiPhieu_SelectedIndexChanged(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetMode("edit");
            txtSoPhieu.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa phiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtSoPhieu.Text);
                    LoadData();
                    SetMode("view");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDoiTuong.SelectedValue == null) { MessageBox.Show("Chưa chọn đối tượng!"); return; }
            try
            {
                string loai = cboLoaiPhieu.SelectedIndex == 0 ? "T" : "C";
                string maDoiTuong = cboDoiTuong.SelectedValue.ToString();
                bool isKH = radKhachHang.Checked;
                decimal tien = decimal.Parse(txtSoTien.Text);
                string maNV = "ADMIN"; // Sau này lấy từ UserData

                if (_mode == "add")
                    _service.Add(txtSoPhieu.Text, dtpNgayLap.Value, loai, maDoiTuong, isKH, tien, txtLyDo.Text, txtTkNo.Text, txtTkCo.Text, maNV);
                else if (_mode == "edit")
                    _service.Update(txtSoPhieu.Text, dtpNgayLap.Value, loai, maDoiTuong, isKH, tien, txtLyDo.Text, txtTkNo.Text, txtTkCo.Text);

                MessageBox.Show("Lưu thành công!");
                LoadData();
                SetMode("view");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMode("view");
            dgvDanhSach_SelectionChanged(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}