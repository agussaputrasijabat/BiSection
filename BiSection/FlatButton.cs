using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Threading.Tasks;

namespace BiSection
{
    public class FlatButton : Button
    {
        private Color _NormalBackColor = ColorTranslator.FromHtml("#2C3E50");
        private Color CurrentBackColor;

        public FlatButton()
        {
            CurrentBackColor = _NormalBackColor;
            BackColor = CurrentBackColor;
            ForeColor = Color.White;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (Enabled)
            {
                CurrentBackColor = MouseHoverBackColor;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (Enabled)
            {
                CurrentBackColor = _NormalBackColor;
                Invalidate();
            }
        }

        protected async override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (Enabled)
            {
                CurrentBackColor = MouseDownBackColor;
                Invalidate();
                await Task.Delay(200);
                CurrentBackColor = _NormalBackColor;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (Enabled)
            {
                CurrentBackColor = MouseDownBackColor;
                Invalidate();
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!Enabled)
            {
                CurrentBackColor = DisableBackColor;
                Invalidate();
            }
            else
            {
                OnMouseLeave(e);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }

        [Category("FlatButton")]
        public Color NormalBackColor
        {
            get { return _NormalBackColor; }
            set
            {
                _NormalBackColor = value;
                CurrentBackColor = value;
            }
        }

        [Category("FlatButton")]
        public Color MouseHoverBackColor { get; set; } = ColorTranslator.FromHtml("#34495E");

        [Category("FlatButton")]
        public Color MouseDownBackColor { get; set; } = ColorTranslator.FromHtml("#3f5a73");

        [Category("FlatButton")]
        public Color DisableBackColor { get; set; } = ColorTranslator.FromHtml("#9eb0c7");
    }
}
