using Draw.Drawer;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class CircleFigure : AbstractFigure
    {

        public CircleFigure()
        {
            Drawer = new EllipseDrawer();
        }


        public override void Update(Point startPoint, Point endPoint)
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

        public override void Move(Point delta)
        {
            throw new NotImplementedException();
        }

        public override bool IsThisFigure(Point point)
        {
            throw new NotImplementedException();
        }

        public override void FillFigure()
        {
            IsFilled = !IsFilled;
            if (IsFilled)
            {
                Drawer = new FilledEllipseDrawer();
            }
            else
            {
                Drawer = new EllipseDrawer();
            }
        }

    }
}
