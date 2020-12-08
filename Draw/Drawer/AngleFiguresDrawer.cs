using Draw.Drawer;
using System.Drawing;

namespace Draw.Drawer
{
    public class AngleFiguresDrawer : IDrawer
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {
            graphics.DrawPolygon(pen, figurePoints);
        }
    }
}