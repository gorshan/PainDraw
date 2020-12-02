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
    class NAngleByPointsFigure : IFigure
    {
        public int N { get; set; }

        public IDrawer Drawer { get; set; }

        public NAngleByPointsFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        public NAngleByPointsFigure(int n)
        {
            N = n;
        }


        private Point[] GetPoints(List<Point> points)
        {
            Point[] pointsArray = new Point[N+1];
            points.CopyTo(0, pointsArray, 0, N);
            pointsArray[N] = pointsArray[0];
            return pointsArray;
        }

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            throw new NotImplementedException();
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
