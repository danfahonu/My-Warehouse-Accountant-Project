using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy.CustomControls
{
    public class ModernButton : Button
    {
        private int _borderRadius = 20;
        private Color _borderColor = Color.PaleVioletRed;

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public ModernButton()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Optimization
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += (s, e) => { if (_borderRadius > this.Height) _borderRadius = this.Height; };
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if (BorderRadius > 2) // Rounded button
            {
                using GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius);
                using GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - 1F);
                using Pen penSurface = new Pen(this.Parent.BackColor, 2);
                using Pen penBorder = new Pen(BorderColor, 1.6F);

                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);
                // Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);
                // Draw control border
                if (this.FlatAppearance.BorderSize >= 1)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Normal button
            {
                this.Region = new Region(rectSurface);
                if (this.FlatAppearance.BorderSize >= 1)
                {
                    using Pen penBorder = new Pen(BorderColor, 1F);
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += (s, args) => { if (this.DesignMode == false) this.Invalidate(); };
        }
    }
}
