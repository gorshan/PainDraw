using Draw.Drawer;
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
            double res = Math.Pow(point.X - x0, 2) / Math.Pow(rx, 2) + Math.Pow(point.Y - y0, 2)/ Math.Pow(ry, 2) - 1;
            double resCircleIn = Math.Pow(point.X - x0, 2) + Math.Pow(point.Y - y0, 2) - Math.Pow((rx - ry)/2 + Width, 2);
            double resCircleOut = Math.Pow(point.X - x0, 2) + Math.Pow(point.Y - y0, 2) - Math.Pow((rx - ry) / 2 + 2*Width, 2);
            double resInner = Math.Pow(point.X - x0, 2) / Math.Pow(rx - Width, 2) + Math.Pow(point.Y - y0, 2) / Math.Pow(ry + Width, 2) - 1;
            double resOuter = Math.Pow(point.X - x0, 2) / Math.Pow(rx + Width, 2) + Math.Pow(point.Y - y0, 2) / Math.Pow(ry + 2*Width, 2) - 1;
            
            if (resCircleIn <= resInner && resCircleOut <= resOuter)
                //(res <= 0.1*Width && res >= -0.1*Width)
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

        public override void FillFigure()
        {
            IsFilled = !IsFilled;
            if (IsFilled)
            {
                Drawer = new FilledEllipseDrawer();
            }
            else
            {
                Drawer = new EllipseDrawer();
            }
        }

        public override void MoveFace(Point delta)
        {
            
        }

        public override bool IsThisVertex(Point point)
        {
            return false;
        }

        public override void MoveVertex(Point delta)
        {
            
        }
    }
}
