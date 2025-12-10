using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;
using DoAnLapTrinhQuanLy;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormTongHopKho : Form
    {
        private readonly TongHopKhoService _service = new TongHopKhoService();
        private readonly HangHoaService _hhService = new HangHoaService();

        public FormTongHopKho()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void FormTongHopKho_Load(object sender, EventArgs e)
        {
            DateTime dauThang = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dtpTuTH.Value = dtpTuTK.Value = dtpTuCT.Value = dauThang;
            dtpDenTH.Value = dtpDenTK.Value = dtpDenCT.Value = DateTime.Now;

            LoadComboData();
            cboLoaiPhieu.SelectedIndex = 0;
        }

        private void LoadComboData()
        {
            try
            {
                // Load nhóm hàng
                DataTable dtNhom = _service.GetNhomHang();
                // Kiểm tra null để tránh lỗi nếu không có dữ liệu
                if (dtNhom != null)
                {
                    DataRow dr = dtNhom.NewRow();
                    dr["MANHOM"] = "ALL";
                    dr["TENNHOM"] = "--- Tất cả ---";
                    dtNhom.Rows.InsertAt(dr, 0);
                    cboNhomHang.DataSource = dtNhom;
                    cboNhomHang.DisplayMember = "TENNHOM";
                    cboNhomHang.ValueMember = "MANHOM";
                }

                // Load hàng hóa
                cboHangHoa.DataSource = _service.GetHangHoa();
                cboHangHoa.DisplayMember = "TENHH";
                cboHangHoa.ValueMember = "MAHH";
                cboHangHoa.SelectedIndex = -1;
            }
            catch { }
        }

        // --- TAB 1: TỔNG HỢP ---
        // --- TAB 1: TỔNG HỢP ---
        private void btnXemTH_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã nhóm từ ComboBox (ví dụ "N01" hoặc "ALL")
                string nhom = cboNhomHang.SelectedValue?.ToString();

                // SỬA LỖI Ở ĐÂY: Truyền biến 'nhom' vào thay vì truyền chuỗi rỗng ""
                DataTable dt = _service.GetTongHopTonKho(dtpTuTH.Value, dtpDenTH.Value, nhom);

                dgvTongHop.DataSource = dt;

                FormatCol(dgvTongHop, "TON_DAU", "Tồn Đầu");
                FormatCol(dgvTongHop, "NHAP", "Nhập");
                FormatCol(dgvTongHop, "XUAT", "Xuất");
                FormatCol(dgvTongHop, "TON_CUOI", "Tồn Cuối");

                if (dgvTongHop.Columns.Contains("GIATRI_TON"))
                {
                    dgvTongHop.Columns["GIATRI_TON"].HeaderText = "Giá Trị Tồn";
                    dgvTongHop.Columns["GIATRI_TON"].DefaultCellStyle.Format = "N0";
                    dgvTongHop.Columns["GIATRI_TON"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                decimal tongVal = 0;
                foreach (DataRow r in dt.Rows)
                {
                    if (r["GIATRI_TON"] != DBNull.Value)
                        tongVal += Convert.ToDecimal(r["GIATRI_TON"]);
                }
                lblTongGiaTri.Text = "Tổng Giá Trị Tồn: " + tongVal.ToString("N0") + " đ   ";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnInTH_Click(object sender, EventArgs e) { MessageBox.Show("Chức năng xuất Excel đang được phát triển."); }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                ReportService.InTonKho(dtpTuTH.Value, dtpDenTH.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in báo cáo: " + ex.Message);
            }
        }

        // --- TAB 2: CHI TIẾT ---
        private void btnXemCT_Click(object sender, EventArgs e)
        {
            try
            {
                string loai = "ALL";
                if (cboLoaiPhieu.SelectedIndex == 1) loai = "N";
                if (cboLoaiPhieu.SelectedIndex == 2) loai = "X";

                DataTable dt = _service.GetBangKeNhapXuat(dtpTuCT.Value, dtpDenCT.Value, loai);
                dgvChiTiet.DataSource = dt;

                // === SỬA TÊN CỘT Ở ĐÂY CHO KHỚP CSDL ===
                // Trong DB cột là SL, không phải SOLUONG
                FormatCol(dgvChiTiet, "SL", "Số Lượng");
                FormatCol(dgvChiTiet, "DONGIA", "Đơn Giá");
                FormatCol(dgvChiTiet, "THANHTIEN", "Thành Tiền");

                if (dgvChiTiet.Columns.Contains("DOI_TUONG")) dgvChiTiet.Columns["DOI_TUONG"].HeaderText = "Khách Hàng / NCC";
                if (dgvChiTiet.Columns.Contains("TEN_DOITUONG")) dgvChiTiet.Columns["TEN_DOITUONG"].HeaderText = "Đối Tượng";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // --- TAB 3: THẺ KHO (QUAN TRỌNG) ---
        private void btnXemTK_Click(object sender, EventArgs e)
        {
            if (cboHangHoa.SelectedValue == null) { MessageBox.Show("Vui lòng chọn hàng hóa!"); return; }
            try
            {
                DataTable dt = _service.GetTheKho(cboHangHoa.SelectedValue.ToString(), dtpTuTK.Value, dtpDenTK.Value);

                // === XỬ LÝ TÍNH TỒN LŨY KẾ TRONG C# ===
                // Vì SQL chỉ trả về dòng đầu có số dư, các dòng sau bằng 0
                if (dt.Rows.Count > 0)
                {
                    decimal tonHienTai = 0;

                    // Lấy số dư đầu kỳ từ dòng đầu tiên (nếu có)
                    if (dt.Rows[0]["TON_LUY_KE"] != DBNull.Value)
                        tonHienTai = Convert.ToDecimal(dt.Rows[0]["TON_LUY_KE"]);

                    // Chạy vòng lặp từ dòng thứ 2 (index 1) trở đi để cộng dồn
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        decimal nhap = Convert.ToDecimal(dt.Rows[i]["NHAP"]);
                        decimal xuat = Convert.ToDecimal(dt.Rows[i]["XUAT"]);

                        tonHienTai = tonHienTai + nhap - xuat;

                        // Gán ngược lại vào DataTable
                        dt.Rows[i]["TON_LUY_KE"] = tonHienTai;
                    }
                }

                dgvTheKho.DataSource = dt;

                FormatCol(dgvTheKho, "NHAP", "Nhập");
                FormatCol(dgvTheKho, "XUAT", "Xuất");
                FormatCol(dgvTheKho, "TON_LUY_KE", "Tồn Cuối");

                // Ẩn cột sắp xếp nếu có
                if (dgvTheKho.Columns.Contains("STT_SAP_XEP")) dgvTheKho.Columns["STT_SAP_XEP"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void FormatCol(DataGridView dgv, string colName, string header)
        {
            if (dgv.Columns.Contains(colName))
            {
                dgv.Columns[colName].HeaderText = header;
                dgv.Columns[colName].DefaultCellStyle.Format = "N0";
                dgv.Columns[colName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}