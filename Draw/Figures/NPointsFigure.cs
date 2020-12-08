using Draw.Drawer;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Draw.Figures
{

    public class NPointsFigure : AbstractFigure
    {
        public int N { get; set; }
        public override int Width
        {
            get
            {
                if (IsFilled && N != int.MaxValue)
                {
                    return 1;
                }
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        private int _width;


        public NPointsFigure(int n)
        {
            N = n;
            Points = new List<Point>();
            Drawer = new PenDrawer();
        }

        public NPointsFigure()
        {
            Points = new List<Point>();
            Drawer = new PenDrawer();
        }

        public bool IsFull()
        {
            if (Points.Count >= N)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            if (Points.Count < N)
            {
                Points.Add(endPoint);
                if (Points.Count == N)
                {
                    if (IsFilled)
                    {
                        Drawer = new FilledAngleFiguresDrawer();
                    }
                    else
                    {
                        Drawer = new AngleFiguresDrawer();
                    }
                }
            }
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
            Point p1 = Points[Points.Count - 1];
            Point p2;
            foreach (Point p in Points)
            {
                p2 = p;
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X)))
                    && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
                    && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))))
                {
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public override void FillFigure()
        {
            IsFilled = !IsFilled;
        }
    }
}
