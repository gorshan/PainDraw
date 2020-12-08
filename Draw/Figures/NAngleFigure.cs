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
        private Point[] _points;
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
                    _points = new Point[] { p1, p2 };
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public override void MoveFace(Point delta)
        {
            if (_points != null)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i] == _points[0])
                    {
                        _points[0] = new Point(_points[0].X + delta.X, _points[0].Y + delta.Y);
                        Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                    if (Points[i] == _points[1])
                    {
                        _points[1] = new Point(_points[1].X + delta.X, _points[1].Y + delta.Y);
                        Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                }
            }
        }

        public override bool IsThisVertex(Point point)
        {

            foreach (Point p in Points)
            {
                if (p == point)
                {
                    _points = new Point[] { p };
                    return true;
                }
            }
            return false;
        }

        public override void MoveVertex(Point delta)
        {
            if (_points != null)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i] == _points[0])
                    {
                        _points[0] = new Point(_points[0].X + delta.X, _points[0].Y + delta.Y);
                        Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                }
            }
        }

    }
}
