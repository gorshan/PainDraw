using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw.Canvases
{
    internal class PenDrawer : IDrawer
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            graphics.DrawCurve(pen, figurePoints);
        }
    }
}