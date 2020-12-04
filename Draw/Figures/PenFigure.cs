using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class PenFigure : IFigure
    {
        private Point _lastPoint;

        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public PenFigure()
        {
            Points = new List<Point>();
            Drawer = new PenDrawer();
        }

        //public PenFigure()
        //{
        //    points = new LinkedList<Point>();
        //}


        private void AddPoint(Point startPoint, Point endPoint)
        {
            if (_lastPoint == null)
            {
                _lastPoint = startPoint;
            }
            if (Math.Abs(endPoint.X - _lastPoint.X) > 4 || Math.Abs(endPoint.Y - _lastPoint.Y) > 4)
            {
                Points.Add(endPoint);
                _lastPoint = endPoint;
            }
        }

        public void ClearPoints()
        {
            Points.Clear();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void Update(Point startPoint, Point endPoint)
        {
            AddPoint(startPoint, endPoint);
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
            Point p1;
            Point p2;
            
                p1 = Points[0];
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
