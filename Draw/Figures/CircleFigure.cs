using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class CircleFigure : IFigure
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, endPoint.Y - startPoint.Y, endPoint.Y - startPoint.Y);
        }
    }
}
