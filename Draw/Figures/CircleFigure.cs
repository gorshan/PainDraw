﻿using Draw.Drawer;
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

        int r;
        public override void Update(PointF startPoint, PointF endPoint)
        {
           float  r = (int)Math.Sqrt(Math.Pow(((double)endPoint.Y - startPoint.Y), 2.0) + Math.Pow(((double)endPoint.X - startPoint.X), 2.0));
            float x = startPoint.X - r;
            float y = startPoint.Y - r;

            Points = new List<PointF>
            {
                new PointF(x, 0),
                new PointF(0, y),
                new PointF(r * 2, 0),
                new PointF(r * 2, 0)
            };
        }

        public override void Move(PointF delta)
        {
            Points[0] = new PointF(Points[0].X + delta.X, Points[0].Y);
            Points[1] = new PointF(Points[1].X + delta.Y, Points[1].Y);
        }

        public override bool IsThisFigure(PointF point)
        {
            float x0 = Points[0].X + (Points[2].X / 2);
            float y0 = Points[1].X + (Points[3].X/2);
            float res = (((point.X - x0) * (point.X - x0) + (point.Y - y0) * (point.Y - y0)) - (r * r));
            if (res <= 200*Width && res >=-200*Width)
            {
                return true;
            }
            return false;

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

        public PointF[] GetPointsInner( int width, int height)
        {
            LinkedList<PointF> points = new LinkedList<PointF>();
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    PointF point = new PointF(i,j);
                    if (IsThisFigure(point))
                    {
                        points.AddLast(point);
                    }
                }
            }
            return points.ToArray();
        }
        public override void MoveVertex(PointF delta)
        {

        }
        public override bool IsThisVertex(PointF point)
        {
            return false;
        }
        public override void MoveFace(PointF delta)
        {
            
        }
    }
}
