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
            Drawer = new AngleFiguresDrawer();
            Points = new List<Point>();
            N = 3;
        }

        private Point _startPoint;
        private Point _endPoint;
        public Point[] GetPoints(Point startpoint, Point endpoint)
        {

            Point[] pointsArray = new Point[Points.Count + 1];
            Points.CopyTo(pointsArray, 0);
            pointsArray[pointsArray.Length - 1] = endpoint;
            Debug.WriteLine(string.Join("   ", Points.Select(x=>$"{x.X};{x.Y}")));
            return Points.ToArray();
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
            return GetPoints(_startPoint, _endPoint);
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }
    }

}
