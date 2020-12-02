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
        public List<Point> Points { get; set; }

        public RectangleFigure()
        {
            Drawer = new AngleFiguresDrawer();
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
                startPoint,
                new Point(startPoint.X, endPoint.Y),
                endPoint,
                new Point(endPoint.X, startPoint.Y)
            };
        }
    }
}
