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
    public class LineFigure : AbstractFigure
    {

        
        public LineFigure()
        {
            Drawer = new PenDrawer();
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>
            {
                startPoint,
                endPoint
            };
        }

        public override bool IsThisFigure(Point point)
        {
            Point p1 = Points[0];
            Point p2 = Points[1];
            foreach (Point p in Points)
            {
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X)))
                    && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
                    && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))))
                {
                    return true;
                }
            }
            return false;
        }

        public override void MoveFace(Point delta)
        {
            
        }
      


        public override void FillFigure()
        {
            IsFilled = !IsFilled;
        }
    }
}
