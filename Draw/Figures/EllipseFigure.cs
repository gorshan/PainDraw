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
    public class EllipseFigure : IFigure
    {
        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }

        public EllipseFigure()
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
            Points = new List<Point>
            {
                new Point(startPoint.X),
                new Point(startPoint.Y),
                new Point(endPoint.X - startPoint.X),
                new Point(endPoint.Y - startPoint.Y)
            };
        }
    }
}
