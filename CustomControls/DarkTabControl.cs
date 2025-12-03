using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy.CustomControls
{
    public class DarkTabControl : TabControl
    {
        public DarkTabControl()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Padding = new Point(12, 4);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(ThemeManager.PrimaryColor);
            e.Graphics.FillRectangle(new SolidBrush(ThemeManager.PrimaryColor), this.ClientRectangle);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var textBrush = new SolidBrush(ThemeManager.TextColor);
            var tabRect = GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                g.FillRectangle(new SolidBrush(ThemeManager.AccentColor), tabRect);
                g.DrawString(this.TabPages[e.Index].Text, ThemeManager.BaseFont, Brushes.White, tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
            else
            {
                g.FillRectangle(new SolidBrush(ThemeManager.SecondaryColor), tabRect);
                g.DrawString(this.TabPages[e.Index].Text, ThemeManager.BaseFont, textBrush, tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }
    }
}
