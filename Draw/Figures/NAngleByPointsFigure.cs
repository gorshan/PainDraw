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
        private Point _startPoint;
        private Point _endPoint;

        public IDrawer Drawer { get; set; }

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

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
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
    }
}
