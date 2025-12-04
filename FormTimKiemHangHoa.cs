using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhQuanLy.Data;

namespace DoAnLapTrinhQuanLy.GuiLayer
{
    public partial class FormTimKiemHangHoa : Form
    {
        public string SelectedMaHH { get; private set; }
        public string SelectedTenHH { get; private set; }
        public string SelectedDVT { get; private set; }
        public decimal SelectedDonGia { get; private set; }

        private DataGridView dgvResult;
        private TextBox txtSearch;
        private Button btnSelect;
        private Button btnCancel;

        public FormTimKiemHangHoa()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.Text = "Tìm Kiếm Hàng Hóa";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Layout
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.RowCount = 3;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // Search
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // Grid
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // Buttons
            this.Controls.Add(layout);

            // Search Box
            Panel pnlSearch = new Panel { Dock = DockStyle.Fill, Padding = new Padding(5) };
            txtSearch = new TextBox { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10) };
            txtSearch.TextChanged += TxtSearch_TextChanged;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            pnlSearch.Controls.Add(txtSearch);
            layout.Controls.Add(pnlSearch, 0, 0);

            // Grid
            dgvResult = new DataGridView();
            dgvResult.Dock = DockStyle.Fill;
            dgvResult.AutoGenerateColumns = false;
            dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResult.MultiSelect = false;
            dgvResult.AllowUserToAddRows = false;
            dgvResult.ReadOnly = true;
            dgvResult.RowHeadersVisible = false;
            dgvResult.CellDoubleClick += DgvResult_CellDoubleClick;
            dgvResult.KeyDown += DgvResult_KeyDown;

            // Columns
            dgvResult.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã HH", DataPropertyName = "MAHH", Width = 100 });
            dgvResult.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên Hàng Hóa", DataPropertyName = "TENHH", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvResult.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ĐVT", DataPropertyName = "DVT", Width = 60 });
            dgvResult.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá Vốn", DataPropertyName = "GIAVON", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });

            layout.Controls.Add(dgvResult, 0, 1);

            // Buttons
            FlowLayoutPanel pnlButtons = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, Padding = new Padding(5) };
            btnCancel = new Button { Text = "Hủy", DialogResult = DialogResult.Cancel };
            btnSelect = new Button { Text = "Chọn", DialogResult = DialogResult.OK };
            btnSelect.Click += BtnSelect_Click;

            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSelect);
            layout.Controls.Add(pnlButtons, 0, 2);
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = DbHelper.Query("SELECT MAHH, TENHH, DVT, GIAVON FROM DM_HANGHOA WHERE ACTIVE = 1");
                dgvResult.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvResult.DataSource is DataTable dt)
            {
                string keyword = txtSearch.Text.Trim().Replace("'", "''");
                dt.DefaultView.RowFilter = $"MAHH LIKE '%{keyword}%' OR TENHH LIKE '%{keyword}%'";
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && dgvResult.Rows.Count > 0)
            {
                dgvResult.Focus();
                dgvResult.Rows[0].Selected = true;
            }
            else if (e.KeyCode == Keys.Enter && dgvResult.Rows.Count > 0)
            {
                SelectCurrentItem();
            }
        }

        private void DgvResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent moving to next row
                SelectCurrentItem();
            }
        }

        private void DgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectCurrentItem();
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            SelectCurrentItem();
        }

        private void SelectCurrentItem()
        {
            if (dgvResult.CurrentRow != null)
            {
                var row = dgvResult.CurrentRow;
                SelectedMaHH = row.Cells[0].Value.ToString();
                SelectedTenHH = row.Cells[1].Value.ToString();
                SelectedDVT = row.Cells[2].Value.ToString();
                SelectedDonGia = Convert.ToDecimal(row.Cells[3].Value != DBNull.Value ? row.Cells[3].Value : 0);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
