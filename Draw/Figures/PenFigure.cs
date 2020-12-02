using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class PenFigure : IFigure
    {
        private Point _lastPoint;
        private LinkedList<Point> _points;

        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }

        public PenFigure()
        {
            _points = new LinkedList<Point>();
            Drawer = new PenDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        //public PenFigure()
        //{
        //    points = new LinkedList<Point>();
        //}


        //public Point[] GetPoints(Point startPoint, Point endPoint)
        //{
        //    AddPoint(startPoint, endPoint);
        //    return _points.ToArray();
        //}

        private void AddPoint(Point startPoint, Point endPoint)
        {
            if (_lastPoint == null)
            {
                _lastPoint = startPoint;
            }
            if (Math.Abs(endPoint.X - _lastPoint.X) > 4 || Math.Abs(endPoint.Y - _lastPoint.Y) > 4)
            {
                _points.AddLast(endPoint);
                _lastPoint = endPoint;
            }
        }

        public void ClearPoints()
        {
            _points.Clear();
        }

        public Point[] GetPoints()
        {
            return _points.ToArray();
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public void Update(Point startPoint, Point endPoint)
        {
            AddPoint(startPoint, endPoint);
        }
    }
}
