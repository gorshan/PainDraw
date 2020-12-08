using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Drawer
{
    public class FilledAngleFiguresDrawer : IDrawer
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints)
        {
            graphics.FillPolygon(new SolidBrush(pen.Color), figurePoints);
        }
    }
}
