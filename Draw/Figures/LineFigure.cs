using Draw.Drawer;
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
        public IDrawer Drawer => throw new NotImplementedException();

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = endPoint;
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
