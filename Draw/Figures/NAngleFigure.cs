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
    public class NAngleFigure : AbstractFigure
    {
        public int N { get; set; }

        public NAngleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public NAngleFigure(int n)
        {
            N = n;
            Drawer = new AngleFiguresDrawer();
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>();
            double r;
            r = Math.Sqrt(Math.Pow(endPoint.Y - startPoint.Y, 2) + Math.Pow(endPoint.X - startPoint.X, 2));
            for (int i = 0; i < N; i++)
            {
                Points.Add(new Point(Convert.ToInt32(startPoint.X + r * Math.Cos((2 * Math.PI * i) / N)),
                                      Convert.ToInt32(startPoint.Y + r * Math.Sin((2 * Math.PI * i) / N))));
            }
        }

        public override void Move(Point delta)
        {
            for (int i = 0; i < Points.Count(); i++)
            {
                Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
            }
        }

        public override bool IsThisFigure(Point point)
        {
            Point p1 = Points[N-1];
            Point p2;
            foreach (Point p in Points)
            {
                p2 = p;
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X)))
                    && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
                    && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))))
                {
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public Point FindCenter()
        {
            int xCenter = 0;
            int yCenter = 0;
            for (int i = 0; i < Points.Count(); i++)
            {
                xCenter += Points[i].X;
                yCenter += Points[i].Y;
            }
            Point center = new Point(xCenter / Points.Count(), yCenter / Points.Count());
            return center;
        }

        public override void Rotate(double phi)
        {
            Point center = FindCenter();
            for (int i = 0; i < Points.Count(); i++)
            {
                Point points = Points[i];
                Point delta = new Point(points.X - center.X, points.Y - center.Y);
                Points[i] = new Point(
                    (int)(center.X + delta.X * Math.Cos(phi) - delta.Y * Math.Sin(phi)),
                    (int)(center.Y + delta.X * Math.Sin(phi) + delta.Y * Math.Cos(phi))
                    );
            }
        }
    }
}
