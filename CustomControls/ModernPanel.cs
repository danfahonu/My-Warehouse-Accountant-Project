using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DoAnLapTrinhQuanLy.CustomControls
{
    public class ModernPanel : Panel
    {
        private int _borderRadius = 30;
        private float _gradientAngle = 90F;
        private Color _gradientTopColor = Color.DodgerBlue;
        private Color _gradientBottomColor = Color.CadetBlue;

        public ModernPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
            this.Resize += (s, e) => { this.Invalidate(); };
        }

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get { return _gradientAngle; }
            set
            {
                _gradientAngle = value;
                this.Invalidate();
            }
        }

        public Color GradientTopColor
        {
            get { return _gradientTopColor; }
            set
            {
                _gradientTopColor = value;
                this.Invalidate();
            }
        }

        public Color GradientBottomColor
        {
            get { return _gradientBottomColor; }
            set
            {
                _gradientBottomColor = value;
                this.Invalidate();
            }
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Gradient
            LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.GradientBottomColor, this.GradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brushArtan, this.ClientRectangle);

            // BorderRadius
            RectangleF rectF = new RectangleF(0, 0, this.Width, this.Height);
            if (_borderRadius > 2)
            {
                using (GraphicsPath path = GetFigurePath(rectF, _borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                this.Region = new Region(rectF);
            }
        }
    }
}
