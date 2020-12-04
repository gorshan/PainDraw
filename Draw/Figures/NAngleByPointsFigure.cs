using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Draw.Figures
{
   
      public class NAngleByPointsFigure : IFigure
    {
        public int N { get; set; }
        public List<Point> Points { get; set; }
        public IDrawer Drawer { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public NAngleByPointsFigure(int n)
        {
            N = n;
            Points = new List<Point>();
            Drawer = new AnglePointsDrawer(N);
        }

        public NAngleByPointsFigure()
        {
            Points = new List<Point>();
            Drawer = new AnglePointsDrawer(N);
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public void Clear()
        {
            if (Points.Count > N)
            Points.Clear();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public bool IsFool()
        {
            if (Points.Count > N)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(Point startPoint, Point endPoint)
        {
            if (Points.Count <= N)
            {
                Points.Add(endPoint);
                if (Points.Count == N)
                {
                    Points.Add(Points[0]);
                }
            }
        }

        public void Move(Point delta)
        {
            for (int i = 0; i < Points.Count(); i++)
            {
                Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
            }
        }

        public bool IsThisFigure(Point point)
        {
            Point p1 = Points[N];
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
    }
}
