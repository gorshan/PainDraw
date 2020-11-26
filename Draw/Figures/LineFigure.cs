using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class LineFigure : IFigure
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            graphics.DrawPolygon(pen, GetPoints(startPoint, endPoint));
        }

        private Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = endPoint;
            return points;
        }
    }
}
