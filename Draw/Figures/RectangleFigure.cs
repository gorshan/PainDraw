using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw.Canvases;
using Draw.Drawer;
using Draw.Figures;

namespace Draw.Figures
{
    public class RectangleFigure : IFigure
    {

        public IDrawer Drawer { get; set; }

        public RectangleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, endPoint.Y);
            points[2] = endPoint;
            points[3] = new Point(endPoint.X, startPoint.Y);

            return points;
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
