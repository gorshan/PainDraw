using Draw.Drawer;
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
        public IDrawer Drawer => throw new NotImplementedException();

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

        public Point[] GetPoints()
        {
            throw new NotImplementedException();
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
