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
            int r = (int)Math.Sqrt(Math.Pow(((double)endPoint.Y - startPoint.Y), 2.0) + Math.Pow(((double)endPoint.X - startPoint.X), 2.0));
            int x;
            int y;
            x = startPoint.X - r;
            y = startPoint.Y - r;
            graphics.DrawEllipse(pen, x, y, r * 2, r * 2);
        }

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            int r = (int)Math.Sqrt(Math.Pow(((double)endPoint.Y - startPoint.Y), 2.0) + Math.Pow(((double)endPoint.X - startPoint.X), 2.0));            
            int x = startPoint.X - r;
            int y = startPoint.Y - r;
            Point[] points = new Point[4];
            points[0] = new Point(x);
            points[1] = new Point(y);
            points[2] = new Point(r*2);
            points[3] = new Point(r*2);
            return points;
        }
    }
}
