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

        public IDrawer Drawer { get; set; }

        public TriangleByPointsFigure()
        {
            N = 3;
            Drawer = new AnglePointsDrawer(N);
            Points = new List<Point>();
        }

        private Point _startPoint;
        private Point _endPoint;

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

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
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
    }

}
