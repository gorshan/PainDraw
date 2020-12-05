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
    public class CircleFigure : IFigure
    {
        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        int r;

        public CircleFigure()
        {
            Drawer = new EllipseDrawer();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }


     
        public void Update(Point startPoint, Point endPoint)
        {
            r = (int)Math.Sqrt(Math.Pow(((double)endPoint.Y - startPoint.Y), 2.0) + Math.Pow(((double)endPoint.X - startPoint.X), 2.0));
            int x = startPoint.X - r;
            int y = startPoint.Y - r;

            Points = new List<Point>
            {
                new Point(x),
                new Point(y),
                new Point(r * 2),
                new Point(r * 2)
            };
        }

        public void Move(Point delta)
        
        {
            Points[0] = new Point(Points[0].X + delta.X, Points[0].Y);
            Points[1] = new Point(Points[1].X + delta.Y, Points[1].Y);
        }

        public bool IsThisFigure(Point point)
        {
            int x0 = (Points[0].X + (Points[2].X / 2));
            int y0 = (Points[1].X + (Points[3].X/2));
            int res = (((point.X - x0) * (point.X - x0) + (point.Y - y0) * (point.Y - y0)) - (r * r));
            if (res <= 200*Width && res >=-200*Width)
            {
                return true;
            }
            return false;

            //Point p1 = Points[3];
            //Point p2;
            //foreach (Point p in Points)
            //{
            //    p2 = p;
            //    if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
            //        <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X)))
            //        && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
            //        && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))))
            //    {
            //        return true;
            //    }
            //    p1 = p2;
            //}
            //return false;
        }

        public Point[] GetPointsInner( int width, int height)
        {
            LinkedList<Point> points = new LinkedList<Point>();
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Point point = new Point(i,j);
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
