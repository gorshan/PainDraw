using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Drawer
{
    public class EllipseDrawer : IDrawer
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {
            graphics.DrawEllipse(pen, figurePoints[0].X, figurePoints[1].X, figurePoints[2].X, figurePoints[3].X);
        }
    }
}
