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
        public Color Color { get; set; }
        public int Width { get; set; }

        public CircleFigure()
        {
            Drawer = new EllipseDrawer();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
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

        public void Move(Point delta)
        {
            throw new NotImplementedException();
        }
    }
}
