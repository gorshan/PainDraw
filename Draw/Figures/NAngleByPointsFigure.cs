using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    class NAngleByPointsFigure : IFigure
    {
        public int N { get; set; }
        public List<Point> Points { get; set; }
        public NAngleByPointsFigure(int n)
        {
            N = n;
            Points = new List<Point>();
        }

        public Point[] GetPoints(Point startpoint, Point endpoint)
        {

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
            Point[] pointsArray = new Point[Points.Count + 1];
            Points.CopyTo(pointsArray, 0);
            pointsArray[pointsArray.Length - 1] = endpoint;
            return Points.ToArray();
        }

        public void AddPoint(Point point)
        {
            throw new NotImplementedException();
        }
            Points.Add(point);
        }

        public void Clear()
        {
            if (Points.Count > N)
            Points.Clear();
        }

    }
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
