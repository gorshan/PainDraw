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
    public class LineFigure : AbstractFigure
    {
        private Point[] _points;
        public LineFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }


        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>
            {
                startPoint,
                endPoint
            };
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

        public override bool IsThisVertex(Point point)
        {

            foreach (Point p in Points)
            {
                if (p == point)
                {
                    _points = new Point[] { p };
                    return true;
                }
            }
            return false;
        }

        public override void MoveVertex(Point delta)
        {
            if (_points != null)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i] == _points[0])
                    {
                        _points[0] = new Point(_points[0].X + delta.X, _points[0].Y + delta.Y);
                        Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                }
            }
        }
    }
}
