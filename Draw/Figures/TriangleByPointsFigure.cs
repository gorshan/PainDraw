using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Draw.Figures;
using Draw.Drawer;
using Draw.Canvases;

namespace Draw.Figures
{
    public class TriangleByPointsFigure : IFigure
    {

        public List<Point> Points { get; set; }
        public int N;
        public Color Color { get; set; }
        public int Width { get; set; }
        public IDrawer Drawer { get; set; }

        public TriangleByPointsFigure()
        {
            N = 3;
            Drawer = new AnglePointsDrawer(N);
            Points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public  void Clear()
        {
            if(Points.Count > 3) 
                Points.Clear();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public bool IsFool()
        {
            if (Points.Count > 3)
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
            if (Points.Count < 3)
            {
                Points.Add(endPoint);
                if (Points.Count == 3)
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
            Point p1 = Points[2];
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
