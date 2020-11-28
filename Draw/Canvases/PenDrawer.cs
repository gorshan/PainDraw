using System.Drawing;

namespace Draw.Canvases
{
    internal class PenDrawer : IDrawer
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {
            graphics.DrawCurve(pen, figurePoints);
        }
    }
}