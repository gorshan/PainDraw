using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Draw.Figures;
using Draw.Drawer;

namespace Draw.Figures
{
    public class TriangleByPointsFigure : IFigure
    {

        public List<Point> Points { get; set; }

        public IDrawer Drawer => throw new NotImplementedException();

        public TriangleByPointsFigure()
        {
            Points = new List<Point>();
        }

        //public Point[] GetPoints(Point startpoint, Point endpoint)
        //{
        //        Point[] pointsArray = new Point[4];
        //        Points.CopyTo(0, pointsArray, 0, 3);
        //        pointsArray[3] = pointsArray[0];
        //        return pointsArray;
        //}

        public Point[] GetPoints(Point startpoint, Point endpoint)
        {

            Point[] pointsArray = new Point[Points.Count + 2];
            Points.CopyTo(pointsArray, 0);
            pointsArray[pointsArray.Length - 1] = endpoint;
            return Points.ToArray();
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

        public void SetPoints(Point startPoint, Point endPoint)
        {
            throw new NotImplementedException();
        }

        public Point[] GetPoints()
        {
            throw new NotImplementedException();
        }
    }

}
