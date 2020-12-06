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
    public class SquareFigure : AbstractFigure
    {
        public SquareFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }


        public override void Update(Point startPoint, Point endPoint)
        {
            int a = Math.Abs(endPoint.Y - startPoint.Y);
            Points = new List<Point>
            {
                startPoint                
            };

            if (startPoint.X > endPoint.X)
            {
                a = -a;
            }
            Points.Add(new Point(startPoint.X, endPoint.Y));
            Points.Add(new Point(startPoint.X + a, endPoint.Y));
            Points.Add(new Point(startPoint.X + a, startPoint.Y));
        }

        public override void Move(Point delta)
        {
            for (int i = 0; i < Points.Count(); i++)
            {
                Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
            }
        }

        public override bool IsThisFigure(Point point)
        {
            Point p1 = Points[3];
            Point p2;
            foreach (Point p in Points)
            {
                p2 = p;
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(20 * ((p2.Y - p1.Y) + (p2.X - p1.X))) 
                    && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
                    && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))) )
                {
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public override void Rotate(double phi)
        {
            throw new NotImplementedException();
        }
    }
}
