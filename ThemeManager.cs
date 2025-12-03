using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy
{
    public static class ThemeManager
    {
        // Dark Mode Palette
        public static Color PrimaryColor = ColorTranslator.FromHtml("#1e1e1e"); // Deep Dark Gray (Background)
        public static Color SecondaryColor = ColorTranslator.FromHtml("#252526"); // Lighter Dark Gray (Panels/Headers)
        public static Color TextColor = ColorTranslator.FromHtml("#d4d4d4"); // Light Gray (Text)
        public static Color AccentColor = ColorTranslator.FromHtml("#007acc"); // VS Blue (Buttons/Highlights)
        public static Color GridLineColor = ColorTranslator.FromHtml("#3e3e42"); // Grid Lines
        public static Color TextBoxBackground = ColorTranslator.FromHtml("#333333"); // TextBox Background

        // Semantic Colors
        public static Color SuccessColor = ColorTranslator.FromHtml("#2ecc71"); // Green
        public static Color WarningColor = ColorTranslator.FromHtml("#f39c12"); // Orange
        public static Color DangerColor = ColorTranslator.FromHtml("#e74c3c"); // Red

        // Compatibility Aliases (DO NOT REMOVE)
        public static Color LightText => TextColor;
        public static Color Primary => SecondaryColor;
        public static Color Accent => AccentColor;
        public static Color Background => PrimaryColor;

        public static Font BaseFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static Font HeaderFont = new Font("Segoe UI", 12F, FontStyle.Bold);

        public static void Apply(Form f)
        {
            if (f == null) return;

            f.SuspendLayout();
            try
            {
                f.BackColor = PrimaryColor;
                f.ForeColor = TextColor;
                f.Font = BaseFont;

                // Use a queue or stack for iterative traversal instead of recursion if stack depth is a concern,
                // but recursion is fine for UI trees. 
                // Optimization: Only traverse if HasChildren is true.
                if (f.HasChildren)
                {
                    foreach (Control c in f.Controls)
                    {
                        ApplyRecursive(c);
                    }
                }
            }
            finally
            {
                f.ResumeLayout();
            }
        }

        private static void ApplyRecursive(Control c)
        {
            // 1. Base Text Styling
            c.ForeColor = TextColor;

            // Optimization: Check type once and switch or use pattern matching
            switch (c)
            {
                case Label _:
                case CheckBox _:
                case RadioButton _:
                case GroupBox _:
                    c.BackColor = Color.Transparent;
                    break;

                case DoAnLapTrinhQuanLy.CustomControls.ModernButton mBtn:
                    mBtn.BackColor = AccentColor;
                    mBtn.ForeColor = Color.White;
                    mBtn.BorderColor = Color.PaleVioletRed;
                    break;

                case DoAnLapTrinhQuanLy.CustomControls.MaterialTextBox mTxt:
                    mTxt.BackColor = TextBoxBackground;
                    mTxt.ForeColor = TextColor;
                    mTxt.BorderColor = SecondaryColor;
                    mTxt.BorderFocusColor = AccentColor;
                    mTxt.PlaceholderColor = Color.Gray;
                    break;

                case DoAnLapTrinhQuanLy.CustomControls.DarkTabControl dTab:
                    dTab.BackColor = PrimaryColor;
                    dTab.ForeColor = TextColor;
                    break;

                case Button btn:
                    // Standard Button (if not ModernButton)
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = AccentColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.Font = new Font(BaseFont, FontStyle.Bold);
                    break;

                case TextBox _:
                case ComboBox _:
                case DateTimePicker _:
                case NumericUpDown _:
                    c.BackColor = TextBoxBackground;
                    c.ForeColor = TextColor;
                    break;

                case DataGridView dgv:
                    StyleDataGridView(dgv);
                    break;

                case TableLayoutPanel tlp:
                    ThemeControlExtensions.SetDoubleBuffered(tlp, true); // Force Double Buffering for TableLayoutPanels
                    break;

                case Panel p:
                    // Skip ModernPanel as it has its own Gradient logic
                    if (p is DoAnLapTrinhQuanLy.CustomControls.ModernPanel)
                    {
                        // Do nothing
                    }
                    else if (p.Name.Contains("Header") || p.Name.Contains("Top") || p.Dock == DockStyle.Top)
                    {
                        p.BackColor = SecondaryColor;
                    }
                    else
                    {
                        p.BackColor = PrimaryColor;
                    }
                    ThemeControlExtensions.SetDoubleBuffered(p, true); // Force Double Buffering for Panels
                    break;

                case MenuStrip menu:
                    menu.BackColor = SecondaryColor;
                    menu.ForeColor = TextColor;
                    menu.Renderer = new ToolStripProfessionalRenderer(new DarkThemeColorTable());
                    break;

                case StatusStrip status:
                    status.BackColor = AccentColor;
                    status.ForeColor = Color.White;
                    break;
            }

            // 2. Recursive Call
            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    ApplyRecursive(child);
                }
            }
        }

        private static void StyleDataGridView(DataGridView dgv)
        {
            ThemeControlExtensions.SetDoubleBuffered(dgv, true); // Force Double Buffering via Extension
            dgv.BackgroundColor = PrimaryColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = GridLineColor;

            // Header
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SecondaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(BaseFont, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeight = 40;

            // Rows
            dgv.DefaultCellStyle.BackColor = PrimaryColor;
            dgv.DefaultCellStyle.ForeColor = TextColor;
            dgv.DefaultCellStyle.SelectionBackColor = AccentColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(4);

            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 35;

            // Alternating Rows
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SecondaryColor;
        }

        // Helper class for MenuStrip coloring
        private class DarkThemeColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected => Color.FromArgb(62, 62, 66);
            public override Color MenuItemBorder => Color.Transparent;
            public override Color MenuBorder => Color.FromArgb(62, 62, 66);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(45, 45, 48);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(45, 45, 48);
            public override Color ToolStripDropDownBackground => Color.FromArgb(27, 27, 28);
            public override Color ImageMarginGradientBegin => Color.FromArgb(27, 27, 28);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(27, 27, 28);
            public override Color ImageMarginGradientEnd => Color.FromArgb(27, 27, 28);
        }
    }
    public static class ThemeControlExtensions
    {
        public static void SetDoubleBuffered(this Control c, bool value)
        {
            // Use Reflection to access the protected 'DoubleBuffered' property
            System.Reflection.PropertyInfo pi = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (pi != null)
            {
                pi.SetValue(c, value, null);
            }
        }
    }
}
