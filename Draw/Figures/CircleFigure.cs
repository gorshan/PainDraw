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
            //if (Math.Abs((Math.Pow((point.X - Points[0].X + r), 2) + Math.Pow((point.Y - Points[1].X + r), 2)) - r * r) <= 10)
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
    }
}
