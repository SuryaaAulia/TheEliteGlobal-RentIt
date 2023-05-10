using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);


        GraphicsPath path = new GraphicsPath();
        RectangleF rectangle = new RectangleF(0, 0, this.Width, this.Height);
        float radius = 20;
        path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
        path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
        path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
        path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);
    }
}