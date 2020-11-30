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
            for(int i = 0; i < figurePoints.Length-1; i++)
            {
            graphics.DrawLine(pen, figurePoints[i], figurePoints[i+1]);

            }
        }
    }
}