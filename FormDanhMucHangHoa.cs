using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormDanhMucHangHoa : Form
    {
        private bool isAdding = false;
        private string currentImagePath = null;

        public FormDanhMucHangHoa()
        {
            InitializeComponent();
            // 1. Enable Double Buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private async void FormDanhMucHangHoa_Load(object sender, EventArgs e)
        {
            // 2. Async Data Loading
            try
            {
                ThemeManager.Apply(this);
                this.SuspendLayout();
                this.Cursor = Cursors.WaitCursor;

                var dataTask = Task.Run(() => GetData());
                var nhomHangTask = Task.Run(() => GetNhomHangData());

                await Task.WhenAll(dataTask, nhomHangTask);

                dgvHangHoa.DataSource = dataTask.Result;

                cboNhomHang.DataSource = nhomHangTask.Result;
                cboNhomHang.DisplayMember = "TENNHOM";
                cboNhomHang.ValueMember = "MANHOM";

                SetInputMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ResumeLayout();
                this.Cursor = Cursors.Default;
            }
        }

        private DataTable GetData()
        {
            string query = "SELECT MAHH, TENHH, MANHOM, DVT, GIAVON, GIABAN, TONKHO, ANH, ACTIVE FROM DM_HANGHOA";
            return DbHelper.Query(query);
        }

        private DataTable GetNhomHangData()
        {
            string query = "SELECT MANHOM, TENNHOM FROM DM_NHOMHANG";
            return DbHelper.Query(query);
        }

        private async void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt = await Task.Run(() => GetData());
                dgvHangHoa.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region UX Mới: Quản lý trạng thái giao diện

        private void SetInputMode(bool enable)
        {
            txtMaHH.ReadOnly = !isAdding; // Mã chỉ nhập khi thêm mới
            txtTenHH.ReadOnly = !enable;
            txtDVT.ReadOnly = !enable;
            txtGiaBan.ReadOnly = !enable;
            cboNhomHang.Enabled = enable;
            chkActive.Enabled = enable;
            btnBrowse.Enabled = enable;

            txtGiaVon.ReadOnly = true; // Giá vốn luôn read-only (tính tự động)
            txtGiaVon.BackColor = Color.LightGray;

            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
            btnIn.Enabled = !enable;
        }

        private void ClearInputs()
        {
            txtMaHH.Texts = "";
            txtTenHH.Texts = "";
            txtDVT.Texts = "";
            txtGiaBan.Texts = "0";
            txtGiaVon.Texts = "0";
            cboNhomHang.SelectedIndex = -1;
            chkActive.Checked = true;
            picHinhAnh.Image = null;
            currentImagePath = null;
        }

        #endregion

        #region Sự kiện của các nút

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetInputMode(true);
            txtMaHH.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdding = false;
            SetInputMode(true);
            txtTenHH.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string maHH = dgvHangHoa.SelectedRows[0].Cells["MAHH"].Value.ToString();
                    string query = "DELETE FROM DM_HANGHOA WHERE MAHH = @MaHH";
                    DbHelper.Execute(query, DbHelper.Param("@MaHH", maHH));

                    LoadData();
                    MessageBox.Show("Xóa mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Data.SqlClient.SqlException sqlEx)
                {
                    if (sqlEx.Number == 547) // Foreign Key constraint violation
                    {
                        MessageBox.Show("Dữ liệu này đang được sử dụng trong các phiếu nhập/xuất, không thể xóa!", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL khi xóa: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHH.Texts) || string.IsNullOrWhiteSpace(txtTenHH.Texts))
                {
                    MessageBox.Show("Mã và Tên hàng hóa không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isAdding)
                {
                    // 3. Duplicate Check
                    object count = DbHelper.Scalar("SELECT COUNT(*) FROM DM_HANGHOA WHERE MAHH = @MaHH", DbHelper.Param("@MaHH", txtMaHH.Texts));
                    if (Convert.ToInt32(count) > 0)
                    {
                        MessageBox.Show("Mã hàng hóa này đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaHH.Focus();
                        return;
                    }

                    string query = @"
                        INSERT INTO DM_HANGHOA (MAHH, TENHH, MANHOM, DVT, GIABAN, ANH, ACTIVE)
                        VALUES (@MaHH, @TenHH, @MaNhom, @DVT, @GiaBan, @Anh, @Active)";
                    DbHelper.Execute(query,
                        DbHelper.Param("@MaHH", txtMaHH.Texts),
                        DbHelper.Param("@TenHH", txtTenHH.Texts),
                        DbHelper.Param("@MaNhom", cboNhomHang.SelectedValue),
                        DbHelper.Param("@DVT", txtDVT.Texts),
                        DbHelper.Param("@GiaBan", decimal.Parse(txtGiaBan.Texts)),
                        DbHelper.Param("@Anh", currentImagePath),
                        DbHelper.Param("@Active", chkActive.Checked)
                    );
                }
                else
                {
                    string query = @"
                        UPDATE DM_HANGHOA SET
                            TENHH = @TenHH, MANHOM = @MaNhom, DVT = @DVT, GIABAN = @GiaBan, 
                            ANH = @Anh, ACTIVE = @Active
                        WHERE MAHH = @MaHH";
                    DbHelper.Execute(query,
                        DbHelper.Param("@TenHH", txtTenHH.Texts),
                        DbHelper.Param("@MaNhom", cboNhomHang.SelectedValue),
                        DbHelper.Param("@DVT", txtDVT.Texts),
                        DbHelper.Param("@GiaBan", decimal.Parse(txtGiaBan.Texts)),
                        DbHelper.Param("@Anh", currentImagePath),
                        DbHelper.Param("@Active", chkActive.Checked),
                        DbHelper.Param("@MaHH", txtMaHH.Texts)
                    );
                }
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                SetInputMode(false);
                isAdding = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                DgvHangHoa_SelectionChanged(null, null);
            }
            else
            {
                ClearInputs();
            }
            SetInputMode(false);
            isAdding = false;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = openFile.FileName;
                picHinhAnh.Image = new Bitmap(currentImagePath);
            }
        }

        private void DgvHangHoa_SelectionChanged(object sender, EventArgs e)
        {
            if (!isAdding && dgvHangHoa.SelectedRows.Count > 0)
            {
                var row = dgvHangHoa.SelectedRows[0];
                txtMaHH.Texts = row.Cells["MAHH"].Value?.ToString();
                txtTenHH.Texts = row.Cells["TENHH"].Value?.ToString();
                txtDVT.Texts = row.Cells["DVT"].Value?.ToString();
                txtGiaVon.Texts = row.Cells["GIAVON"].Value?.ToString();
                txtGiaBan.Texts = row.Cells["GIABAN"].Value?.ToString();
                cboNhomHang.SelectedValue = row.Cells["MANHOM"].Value;

                chkActive.Checked = row.Cells["ACTIVE"].Value != null && (bool)row.Cells["ACTIVE"].Value;

                currentImagePath = row.Cells["ANH"].Value?.ToString();
                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    picHinhAnh.Image = Image.FromFile(currentImagePath);
                }
                else
                {
                    picHinhAnh.Image = null;
                }
            }
        }

        #endregion
    }
}