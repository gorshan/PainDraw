using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw.Figures;
using System.Drawing.Drawing2D;


namespace Draw.Figures
{
   public class PolylineByPointsFigure : IFigure
    {
       
        public IDrawer Drawer { get; set; }
        //List<Point> Points { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public List<Point> Points { get ; set ; }

        public PolylineByPointsFigure()
        {
            Drawer = new PenDrawer();
            Points = new List<Point>();
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
            Points.Add(endPoint);                
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
