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
   public class PolylineByPointsFigure : IFigure
    {
        public LinkedList<Point> Points { get; set; }

        public IDrawer Drawer { get; set; }
        List<Point> IFigure.Points { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public PolylineByPointsFigure()
        {
            Drawer = new PenDrawer();
            Points = new LinkedList<Point>();
        }

        internal void Clear()
        {
            Points.Clear();
        }

        
        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void Update(Point startPoint, Point endPoint)

        {
            //Points.Add(endPoint);                
        }

        //public class PolylineByPointsFigure : IFigure
        //{
        //    public LinkedList<Point> Points { get; set; }

        //    public IDrawer Drawer { get; set; }

        //    public PolylineByPointsFigure()
        //    {
        //        Drawer = new PenDrawer();
        //        Points = new LinkedList<Point>();
        //    }

        //    private Point _startPoint;
        //    private Point _endPoint;

        //    public Point[] GetPoints(Point startpoint, Point endpoint)
        //    {

        //        Point[] pointsArray = new Point[Points.Count + 2];
        //        Points.CopyTo(pointsArray, 0);
        //        pointsArray[pointsArray.Length - 1] = endpoint;
        //        return Points.ToArray();
        //    }

        //    internal void Clear()
        //    {
        //        Points.Clear();
        //    }

        //    public Point[] GetPoints()
        //    {
        //        return GetPoints(_startPoint, _endPoint);
        //    }

        //    public void SetPoints(Point startPoint, Point endPoint)
        //    {
        //        _startPoint = startPoint;
        //        _endPoint = endPoint;
        //    }
        }
}
