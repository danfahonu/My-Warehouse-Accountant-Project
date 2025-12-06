using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy.Controls
{
    public class ModernButton : Button
    {
        private int _borderRadius = 20;
        private Color _borderColor = Color.FromArgb(62, 62, 66); // Default dark border
        private bool _isPressed = false;

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
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(0, 122, 204); // VS Code Blue
            this.ForeColor = Color.White;
            this.Resize += (s, e) => { if (_borderRadius > this.Height) _borderRadius = this.Height; };
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isPressed = true;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isPressed = false;
            this.Invalidate();
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

            // Press Animation: Shift content down 1px
            if (_isPressed)
            {
                pevent.Graphics.TranslateTransform(0, 1);
            }

            if (BorderRadius > 2) // Rounded button
            {
                using GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius);
                using GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - 1F);
                Color parentColor = this.Parent != null ? this.Parent.BackColor : SystemColors.Control;
                using Pen penSurface = new Pen(parentColor, 2);
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

            // Darken on press
            if (_isPressed)
            {
                using (SolidBrush darkBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0)))
                {
                    pevent.Graphics.FillRectangle(darkBrush, rectSurface);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += (s, args) => { if (this.DesignMode == false) this.Invalidate(); };
            }
        }
    }
}
