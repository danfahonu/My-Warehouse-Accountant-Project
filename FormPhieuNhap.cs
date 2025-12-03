using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormPhieuNhap : Form
    {
        private string _mode = "";
        private long _idYeuCau = 0;
        private readonly DataTable dtChiTiet;

        public FormPhieuNhap()
        {
            try
            {
                InitializeComponent();
                // 1. Double Buffering
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                this.UpdateStyles();

                if (dgvChiTiet == null) throw new Exception("dgvChiTiet is null after InitializeComponent");

                // Khởi tạo DataTable chi tiết
                dtChiTiet = new DataTable();
                dtChiTiet.Columns.Add("MAHH", typeof(string));
                dtChiTiet.Columns.Add("TENHH", typeof(string));
                dtChiTiet.Columns.Add("DVT", typeof(string));
                dtChiTiet.Columns.Add("SL", typeof(int));
                dtChiTiet.Columns.Add("DONGIA", typeof(decimal));
                // Use Expression Column for auto-calculation in DataTable
                dtChiTiet.Columns.Add("THANHTIEN", typeof(decimal), "SL * DONGIA");

                // Hook ColumnChanged for Total Amount calculation
                dtChiTiet.ColumnChanged += DtChiTiet_ColumnChanged;

                dgvChiTiet.DataSource = dtChiTiet;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Constructor Error: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void DtChiTiet_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            // Recalculate Total Amount whenever SL or DONGIA changes
            if (e.Column.ColumnName == "SL" || e.Column.ColumnName == "DONGIA" || e.Column.ColumnName == "THANHTIEN")
            {
                CalculateTotalAmount();
            }
        }

        private async void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeManager.Apply(this);
                this.SuspendLayout();
                this.Cursor = Cursors.WaitCursor;

                // 2. Async Data Loading
                var nccTask = Task.Run(() => GetNhaCungCapData());
                var productTask = Task.Run(() => GetProductData());

                await Task.WhenAll(nccTask, productTask);

                var dtNcc = nccTask.Result;
                var dtProduct = productTask.Result;

                // Bind NCC
                cboNhaCungCap.DataSource = dtNcc;
                cboNhaCungCap.DisplayMember = "TEN_NCC";
                cboNhaCungCap.ValueMember = "MA_NCC";
                cboNhaCungCap.SelectedIndex = -1;

                // Bind Product Column
                BindProductComboboxColumn(dtProduct);

                dgvChiTiet.CellValueChanged += DgvChiTiet_CellValueChanged;
                SetInputMode(false);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải form: " + ex.Message);
            }
            finally
            {
                this.ResumeLayout();
                this.Cursor = Cursors.Default;
            }
        }

        private DataTable GetNhaCungCapData()
        {
            string query = "SELECT MA_NCC, TEN_NCC FROM DM_NHACUNGCAP";
            return DbHelper.Query(query);
        }

        private DataTable GetProductData()
        {
            string query = "SELECT MAHH, TENHH FROM DM_HANGHOA";
            return DbHelper.Query(query);
        }

        private void BindProductComboboxColumn(DataTable dt)
        {
            if (dgvChiTiet.Columns.Contains("MAHH"))
            {
                if (dgvChiTiet.Columns["MAHH"] is DataGridViewComboBoxColumn) return;
                dgvChiTiet.Columns.Remove("MAHH");
            }

            DataGridViewComboBoxColumn cmbCol = new DataGridViewComboBoxColumn
            {
                HeaderText = "Hàng Hóa",
                Name = "MAHH",
                DataPropertyName = "MAHH",
                Width = 200,
                AutoComplete = true,
                DataSource = dt,
                DisplayMember = "TENHH",
                ValueMember = "MAHH"
            };

            dgvChiTiet.Columns.Insert(0, cmbCol);
        }

        private void SetInputMode(bool enable)
        {
            dtpNgayLap.Enabled = enable;
            cboNhaCungCap.Enabled = enable;
            txtGhiChu.Enabled = enable;
            dgvChiTiet.ReadOnly = !enable;

            btnThem.Enabled = !enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnChonYeuCau.Enabled = !enable;
        }

        private void ClearInputs()
        {
            dtpNgayLap.Value = DateTime.Now;
            cboNhaCungCap.SelectedIndex = -1;
            txtGhiChu.Texts = ""; // MaterialTextBox uses Texts
            dtChiTiet?.Clear();
            _idYeuCau = 0;
            lblTongTien.Text = "0";

            // Unlock Product Column
            if (dgvChiTiet.Columns["MAHH"] != null)
            {
                dgvChiTiet.Columns["MAHH"].ReadOnly = false;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            _mode = "add_manual";
            ClearInputs();
            SetInputMode(true);
        }

        private void BtnChonYeuCau_Click(object sender, EventArgs e)
        {
            using FormChonPhieuYeuCau f = new FormChonPhieuYeuCau();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                LoadDataFromYeuCau(f.SelectedYeuCauID);
            }
        }

        private void LoadDataFromYeuCau(long idYeuCau)
        {
            try
            {
                _idYeuCau = idYeuCau;

                string queryDetail = @"
                    SELECT 
                        ct.MAHH, 
                        hh.TENHH, 
                        hh.DVT, 
                        ct.SOLUONG_YEUCAU AS SL,
                        hh.GIAVON AS DONGIA
                    FROM PHIEU_YEUCAU_NHAPKHO_CT ct
                    JOIN DM_HANGHOA hh ON ct.MAHH = hh.MAHH
                    WHERE ct.ID_YEUCAU = @ID";

                DataTable dtTemp = DbHelper.Query(queryDetail, DbHelper.Param("@ID", idYeuCau));

                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("Phiếu yêu cầu này không có hàng hóa.");
                    _idYeuCau = 0;
                    return;
                }

                dtChiTiet.Clear();
                foreach (DataRow row in dtTemp.Rows)
                {
                    dtChiTiet.ImportRow(row);
                }

                SetInputMode(true);
                txtGhiChu.Texts = $"Nhập theo yêu cầu #{idYeuCau}";

                // Lock Product Column if importing from Request
                if (dgvChiTiet.Columns["MAHH"] != null)
                {
                    dgvChiTiet.Columns["MAHH"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hàng hóa: " + ex.Message);
            }
        }

        private void DgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // If Product changed, auto-fill Unit and Price
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "MAHH")
            {
                var row = dgvChiTiet.Rows[e.RowIndex];
                var cellValue = row.Cells["MAHH"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    string mahh = cellValue.ToString();
                    string query = "SELECT DVT, GIAVON FROM DM_HANGHOA WHERE MAHH = @MAHH";
                    DataTable dt = DbHelper.Query(query, DbHelper.Param("@MAHH", mahh));

                    if (dt.Rows.Count > 0)
                    {
                        row.Cells["DVT"].Value = dt.Rows[0]["DVT"];
                        row.Cells["DONGIA"].Value = dt.Rows[0]["GIAVON"];
                        row.Cells["SL"].Value = row.Cells["SL"].Value ?? 1;
                    }
                }
            }
        }

        private void CalculateTotalAmount()
        {
            try
            {
                decimal total = 0;
                foreach (DataRow row in dtChiTiet.Rows)
                {
                    // Check row state to avoid deleted rows
                    if (row.RowState == DataRowState.Deleted) continue;

                    if (row["THANHTIEN"] != DBNull.Value)
                    {
                        if (decimal.TryParse(row["THANHTIEN"].ToString(), out decimal val))
                        {
                            total += val;
                        }
                    }
                }

                // Update UI on UI thread if needed (though usually this runs on UI thread)
                if (lblTongTien.InvokeRequired)
                {
                    lblTongTien.Invoke(new Action(() => lblTongTien.Text = total.ToString("N0")));
                }
                else
                {
                    lblTongTien.Text = total.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                // Log error but don't crash
                Console.WriteLine("Calc Error: " + ex.Message);
            }
        }

        public void BtnHuy_Click(object sender, EventArgs e)
        {
            SetInputMode(false);
            ClearInputs();
        }

        public void BtnLuu_Click(object sender, EventArgs e)
        {
            // 1. Validate
            if (cboNhaCungCap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp!");
                return;
            }
            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hàng hóa nào!");
                return;
            }
            if (dtpNgayLap.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày lập phiếu không được lớn hơn ngày hiện tại!");
                return;
            }

            try
            {
                // 3. Transaction Scope
                using TransactionScope scope = new TransactionScope();

                // 4. Insert PHIEU (Master)
                string sqlPhieu = @"INSERT INTO PHIEU (NGAYLAP, LOAI, MA_NCC, GHICHU, TRANGTHAI, ID_YEUCAU) 
                                  VALUES (@NGAYLAP, 'N', @MA_NCC, @GHICHU, 1, @ID_YEUCAU);
                                  SELECT SCOPE_IDENTITY();";

                object result = DbHelper.Scalar(sqlPhieu,
                    DbHelper.Param("@NGAYLAP", dtpNgayLap.Value),
                    DbHelper.Param("@MA_NCC", cboNhaCungCap.SelectedValue),
                    DbHelper.Param("@GHICHU", txtGhiChu.Texts),
                    DbHelper.Param("@ID_YEUCAU", _idYeuCau == 0 ? (object)DBNull.Value : _idYeuCau)
                );

                long soPhieu = Convert.ToInt64(result);

                // 5. Insert Details & Inventory Log
                foreach (DataRow row in dtChiTiet.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    string mahh = row["MAHH"].ToString();
                    int soLuong = Convert.ToInt32(row["SL"]);
                    decimal donGia = Convert.ToDecimal(row["DONGIA"]);

                    // a. Insert PHIEU_CT
                    // SQL Safety: Excluded THANHTIEN
                    string sqlChiTiet = @"INSERT INTO PHIEU_CT (SOPHIEU, MAHH, SL, DONGIA) 
                                        VALUES (@SOPHIEU, @MAHH, @SL, @DONGIA);
                                        SELECT SCOPE_IDENTITY();";

                    object resultCT = DbHelper.Scalar(sqlChiTiet,
                        DbHelper.Param("@SOPHIEU", soPhieu),
                        DbHelper.Param("@MAHH", mahh),
                        DbHelper.Param("@SL", soLuong),
                        DbHelper.Param("@DONGIA", donGia)
                    );

                    long idPhieuCT = Convert.ToInt64(resultCT);

                    // b. Insert KHO_CHITIET_TONKHO
                    string sqlKho = @"INSERT INTO KHO_CHITIET_TONKHO 
                                    (ID_PHIEUNHAP_CT, MAHH, NGAY_NHAP, SO_LUONG_NHAP, DON_GIA_NHAP, SO_LUONG_TON)
                                    VALUES 
                                    (@ID_PHIEUNHAP_CT, @MAHH, @NGAY_NHAP, @SL, @DONGIA, @SL)";

                    DbHelper.Execute(sqlKho,
                        DbHelper.Param("@ID_PHIEUNHAP_CT", idPhieuCT),
                        DbHelper.Param("@MAHH", mahh),
                        DbHelper.Param("@NGAY_NHAP", dtpNgayLap.Value),
                        DbHelper.Param("@SL", soLuong),
                        DbHelper.Param("@DONGIA", donGia)
                    );
                }

                // 6. Update Status of YeuCau if needed
                if (_idYeuCau > 0)
                {
                    // Update status to 3 (Completed)
                    string sqlUpdateYC = "UPDATE PHIEU_YEUCAU_NHAPKHO SET TRANGTHAI = 3 WHERE ID = @ID";
                    DbHelper.Execute(sqlUpdateYC, DbHelper.Param("@ID", _idYeuCau));
                }

                scope.Complete();
                MessageBox.Show($"Lưu phiếu nhập #{soPhieu} thành công!");
                SetInputMode(false);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu: " + ex.Message);
            }
        }
    }
}