using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class EllipseFigure : AbstractFigure
    {
        public EllipseFigure()
        {
            Drawer = new EllipseDrawer();
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>
            {
                new Point(startPoint.X),
                new Point(startPoint.Y),
                new Point(endPoint.X - startPoint.X),
                new Point(endPoint.Y - startPoint.Y)
            };
        }

        public override void Move(Point delta)
        {
            Points[0] = new Point(Points[0].X + delta.X, Points[0].Y);
            Points[1] = new Point(Points[1].X + delta.Y, Points[1].Y);

            //center = new Point(center.X + delta.X, center.Y + delta.Y);
        }

        public override bool IsThisFigure(Point point)
        {
            int x0 = Points[0].X + (Points[2].X / 2);
            int y0 = Points[1].X + (Points[3].X / 2);
            double rx = Points[2].X / 2;
            double ry = Points[3].X / 2;
            double res = (((point.X - x0)* (point.X - x0)) / (rx * rx)) + (((point.Y - y0)* (point.Y - y0) )/ (ry * ry)) - 1;
            if (res <= 0.1*Width && res >= -0.1*Width)
            {
                return true;
            }
            return false;
        }

        public Point[] GetPointsInner(int width, int height)
        {
            LinkedList<Point> points = new LinkedList<Point>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Point point = new Point(i, j);
                    if (IsThisFigure(point))
                    {
                        points.AddLast(point);
                    }
                }
            }
            return points.ToArray();
        }
    }
}
