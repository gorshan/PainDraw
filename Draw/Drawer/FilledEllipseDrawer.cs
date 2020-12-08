using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Drawer
{
    public class FilledEllipseDrawer : IDrawer
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {
            graphics.FillEllipse(new SolidBrush(pen.Color), figurePoints[0].X, figurePoints[1].X, figurePoints[2].X, figurePoints[3].X);
        }
    }
}
