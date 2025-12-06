using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormNhanVien : Form
    {
        private readonly NhanVienService _service;
        private FormState _currentState;
        private string _currentImagePath = null; // Stores the path of the current image

        public enum FormState
        {
            View,
            Adding,
            Editing
        }

        public FormNhanVien()
        {
            InitializeComponent();
            _service = new NhanVienService();


        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SetState(FormState.View);
        }

        private void LoadData()
        {
            try
            {
                dgvNhanVien.DataSource = _service.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi");
            }
        }

        // --- STATE MANAGEMENT ---
        private void SetState(FormState state)
        {
            _currentState = state;
            switch (state)
            {
                case FormState.View:
                    SetInputsReadOnly(true);
                    btnBrowse.Enabled = false;
                    chkHoatDong.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = (dgvNhanVien.CurrentRow != null);
                    btnXoa.Enabled = (dgvNhanVien.CurrentRow != null);
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;

                    dgvNhanVien.Enabled = true;
                    if (dgvNhanVien.CurrentRow != null)
                        PopulateInputs(dgvNhanVien.CurrentRow);
                    else
                        ClearInputs();
                    break;

                case FormState.Adding:
                    ClearInputs();
                    SetInputsReadOnly(false);
                    txtMaNV.Enabled = true;
                    btnBrowse.Enabled = true;
                    chkHoatDong.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;

                    dgvNhanVien.Enabled = false;
                    txtMaNV.Focus();
                    break;

                case FormState.Editing:
                    SetInputsReadOnly(false);
                    txtMaNV.Enabled = false; // Locked
                    btnBrowse.Enabled = true;
                    chkHoatDong.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;

                    dgvNhanVien.Enabled = false;
                    txtHoTen.Focus();
                    break;
            }
        }

        private void SetInputsReadOnly(bool isReadOnly)
        {
            bool isEnabled = !isReadOnly;
            txtMaNV.Enabled = isEnabled;
            txtHoTen.Enabled = isEnabled;
            cboChucVu.Enabled = isEnabled; // Updated to ComboBox
            txtDiaChi.Enabled = isEnabled;
            txtSDT.Enabled = isEnabled;
            txtEmail.Enabled = isEnabled;
        }

        private void ClearInputs()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cboChucVu.SelectedIndex = -1; // Updated to ComboBox
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            chkHoatDong.Checked = true;

            picHinhAnh.Image = null;
            _currentImagePath = null;
        }

        private void PopulateInputs(DataGridViewRow row)
        {
            txtMaNV.Texts = row.Cells["MANV"].Value?.ToString();
            txtHoTen.Texts = row.Cells["HOTEN"].Value?.ToString();
            cboChucVu.Text = row.Cells["CHUCVU"].Value?.ToString(); // Updated to ComboBox
            txtDiaChi.Texts = row.Cells["DIACHI"].Value?.ToString();
            txtSDT.Texts = row.Cells["SDT"].Value?.ToString();
            txtEmail.Texts = row.Cells["EMAIL"].Value?.ToString();

            object activeVal = row.Cells["HOATDONG"].Value;
            chkHoatDong.Checked = (activeVal != null && activeVal != DBNull.Value && Convert.ToBoolean(activeVal));

            // Load Image
            string imagePath = row.Cells["ANH"].Value?.ToString();
            _currentImagePath = imagePath;
            LoadImageToBox(imagePath);
        }

        private void LoadImageToBox(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    picHinhAnh.Image = Image.FromFile(path);
                }
                catch
                {
                    picHinhAnh.Image = null; // Error loading image
                }
            }
            else
            {
                picHinhAnh.Image = null;
            }
        }

        // --- EVENTS ---

        private void DgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (_currentState == FormState.View)
            {
                if (dgvNhanVien.CurrentRow != null)
                {
                    PopulateInputs(dgvNhanVien.CurrentRow);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    ClearInputs();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _currentImagePath = ofd.FileName;
                LoadImageToBox(_currentImagePath);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e) => SetState(FormState.Adding);

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            SetState(FormState.Editing);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Texts) || string.IsNullOrWhiteSpace(txtHoTen.Texts))
                {
                    MessageBox.Show("Vui lòng nhập Mã và Tên nhân viên.", "Cảnh báo");
                    return;
                }

                if (_currentState == FormState.Adding)
                {
                    if (_service.CheckTonTai(txtMaNV.Texts))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại.", "Lỗi");
                        return;
                    }
                    _service.Insert(txtMaNV.Texts, txtHoTen.Texts, cboChucVu.Text, txtDiaChi.Texts, txtSDT.Texts, txtEmail.Texts, _currentImagePath, chkHoatDong.Checked);
                    MessageBox.Show("Thêm thành công.");
                }
                else if (_currentState == FormState.Editing)
                {
                    _service.Update(txtMaNV.Texts, txtHoTen.Texts, cboChucVu.Text, txtDiaChi.Texts, txtSDT.Texts, txtEmail.Texts, _currentImagePath, chkHoatDong.Checked);
                    MessageBox.Show("Cập nhật thành công.");
                }

                LoadData();
                SetState(FormState.View);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Texts)) return;
            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaNV.Texts);
                    LoadData();
                    SetState(FormState.View);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e) => SetState(FormState.View);


    }
}