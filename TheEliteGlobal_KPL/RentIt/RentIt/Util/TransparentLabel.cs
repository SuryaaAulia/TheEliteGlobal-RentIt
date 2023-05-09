using System.Drawing;
using System.Windows.Forms;

public class TransparentLabel : Control
{
    private string text;

    public TransparentLabel()
    {
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.UserPaint, true);
    }

    public override string Text
    {
        get { return text; }
        set
        {
            text = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        g.DrawString(text, Font, new SolidBrush(ForeColor), ClientRectangle);
    }
}