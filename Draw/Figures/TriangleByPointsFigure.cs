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
            throw new NotImplementedException();
        }

        public bool IsThisFigure(Point point)
        {
            throw new NotImplementedException();
        }
    }

}
