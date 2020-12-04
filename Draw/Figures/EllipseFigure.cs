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
        public Color Color { get; set; }
        public int Width { get; set; }
        public EllipseFigure()
        {
            Drawer = new EllipseDrawer();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
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

        public void Move(Point delta)

        {
            Points[0] = new Point(Points[0].X + delta.X, Points[0].Y);
            Points[1] = new Point(Points[1].X + delta.Y, Points[1].Y);
        }

        public bool IsThisFigure(Point point)
        {
            int x0 = (Points[0].X + Points[2].X )/ 2;
            int y0 = (Points[1].X + Points[3].X) / 2; 
            int rx = Points[2].X / 2;
            int ry = Points[3].X / 2;
            if (Math.Abs((Math.Pow((point.X - x0), 2) / (rx * rx)) + (Math.Pow((point.Y - y0), 2) / (ry * ry)) - 1) <= 3)
            {
                return true;
            }
            return false;
        }
    }
}
