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
    public class LineFigure : IFigure
    {
        public IDrawer Drawer { get; set; }

        public LineFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[2];
            points[0] = startPoint;
            points[1] = endPoint;
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
