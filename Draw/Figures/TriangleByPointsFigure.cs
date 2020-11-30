using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Draw.Figures;


namespace Draw.Figures
{
    public class TriangleByPointsFigure : IFigure
    {

        public List<Point> Points { get; set; }
        public int N {get; set; }
        public Point[] GetPoints(List<Point> points)
        {
                Point[] pointsArray = new Point[4];
                points.CopyTo(0, pointsArray, 0, N);
                pointsArray[3] = pointsArray[0];
                return pointsArray;
        }

        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public int GetLength()
        {
        return Points.Count;
        }

        public void Clear()
        {
            Points.Clear();
        }

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            throw new NotImplementedException();
        }
    }

}
