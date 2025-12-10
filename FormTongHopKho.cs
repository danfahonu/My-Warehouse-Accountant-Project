using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Services;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormTongHopKho : Form // <-- ĐÃ ĐỔI TÊN CLASS
    {
        private readonly TongHopKhoService _service = new TongHopKhoService();
        private readonly HangHoaService _hhService = new HangHoaService();

        public FormTongHopKho() // <-- ĐÃ ĐỔI TÊN CONSTRUCTOR
        {
            InitializeComponent();
            // 3 DÒNG THẦN THÁNH
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
                DataRow dr = dtNhom.NewRow(); dr["MANHOM"] = "ALL"; dr["TENNHOM"] = "--- Tất cả ---";
                dtNhom.Rows.InsertAt(dr, 0);
                cboNhomHang.DataSource = dtNhom; cboNhomHang.DisplayMember = "TENNHOM"; cboNhomHang.ValueMember = "MANHOM";

                // Load hàng hóa
                cboHangHoa.DataSource = _service.GetHangHoa();
                cboHangHoa.DisplayMember = "TENHH"; cboHangHoa.ValueMember = "MAHH";
                cboHangHoa.SelectedIndex = -1;
            }
            catch { }
        }

        // --- TAB 1: TỔNG HỢP ---
        private void btnXemTH_Click(object sender, EventArgs e)
        {
            try
            {
                string nhom = cboNhomHang.SelectedValue?.ToString();
                DataTable dt = _service.GetTongHopTonKho(dtpTuTH.Value, dtpDenTH.Value, nhom);
                dgvTongHop.DataSource = dt;

                FormatCol(dgvTongHop, "TON_DAU", "Tồn Đầu");
                FormatCol(dgvTongHop, "NHAP", "Nhập");
                FormatCol(dgvTongHop, "XUAT", "Xuất");
                FormatCol(dgvTongHop, "TON_CUOI", "Tồn Cuối");
                FormatCol(dgvTongHop, "GIATRI_TON", "Giá Trị Tồn");

                decimal tongVal = 0;
                foreach (DataRow r in dt.Rows) tongVal += Convert.ToDecimal(r["GIATRI_TON"]);
                lblTongGiaTri.Text = "Tổng Giá Trị Tồn: " + tongVal.ToString("N0") + " đ   ";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnInTH_Click(object sender, EventArgs e) { MessageBox.Show("Chức năng xuất Excel đang được phát triển."); }

        // --- TAB 2: CHI TIẾT ---
        private void btnXemCT_Click(object sender, EventArgs e)
        {
            try
            {
                string loai = "ALL";
                if (cboLoaiPhieu.SelectedIndex == 1) loai = "N";
                if (cboLoaiPhieu.SelectedIndex == 2) loai = "X";

                dgvChiTiet.DataSource = _service.GetBangKeNhapXuat(dtpTuCT.Value, dtpDenCT.Value, loai);
                FormatCol(dgvChiTiet, "SOLUONG", "Số Lượng");
                FormatCol(dgvChiTiet, "DONGIA", "Đơn Giá");
                FormatCol(dgvChiTiet, "THANHTIEN", "Thành Tiền");

                if (dgvChiTiet.Columns.Contains("DOI_TUONG")) dgvChiTiet.Columns["DOI_TUONG"].HeaderText = "Khách Hàng / NCC";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // --- TAB 3: THẺ KHO ---
        private void btnXemTK_Click(object sender, EventArgs e)
        {
            if (cboHangHoa.SelectedValue == null) { MessageBox.Show("Vui lòng chọn hàng hóa!"); return; }
            try
            {
                DataTable dt = _service.GetTheKho(cboHangHoa.SelectedValue.ToString(), dtpTuTK.Value, dtpDenTK.Value);
                dgvTheKho.DataSource = dt;

                FormatCol(dgvTheKho, "NHAP", "Nhập");
                FormatCol(dgvTheKho, "XUAT", "Xuất");
                FormatCol(dgvTheKho, "TON_LUY_KE", "Tồn");
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