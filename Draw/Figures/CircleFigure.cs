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
    public class CircleFigure : IFigure
    {
        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }

        public CircleFigure()
        {
            Drawer = new EllipseDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public void Update(Point startPoint, Point endPoint)
        {
            int r = (int)Math.Sqrt(Math.Pow(((double)endPoint.Y - startPoint.Y), 2.0) + Math.Pow(((double)endPoint.X - startPoint.X), 2.0));
            int x = startPoint.X - r;
            int y = startPoint.Y - r;

            Points = new List<Point>
            {
                new Point(x),
                new Point(y),
                new Point(r * 2),
                new Point(r * 2)
            };
        }
    }
}
