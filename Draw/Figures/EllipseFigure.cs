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
    public class EllipseFigure : AbstractFigure
    {
        public EllipseFigure()
        {
            Drawer = new EllipseDrawer();
        }

        public override void Update(PointF startPoint, PointF endPoint)
        {
            Points = new List<PointF>
            {
                new PointF(startPoint.X, 0),
                new PointF(startPoint.Y, 0),
                new PointF(endPoint.X - startPoint.X, 0),
                new PointF(endPoint.Y - startPoint.Y, 0)
            };
        }

        public override void Move(PointF delta)
        {
            Points[0] = new PointF(Points[0].X + delta.X, Points[0].Y);
            Points[1] = new PointF(Points[1].X + delta.Y, Points[1].Y);

            //center = new PointF(center.X + delta.X, center.Y + delta.Y);
        }

        public override bool IsThisFigure(PointF point)
        {
            double x0 = Points[0].X + (Points[2].X / 2);
            double y0 = Points[1].X + (Points[3].X / 2);
            double rx = Points[2].X / 2;
            double ry = Points[3].X / 2;
            double res = Math.Pow(point.X - x0, 2) / Math.Pow(rx, 2) + Math.Pow(point.Y - y0, 2)/ Math.Pow(ry, 2) - 1;
            double resCircleIn = Math.Pow(point.X - x0, 2) + Math.Pow(point.Y - y0, 2) - Math.Pow((rx - ry)/2 + Width, 2);
            double resCircleOut = Math.Pow(point.X - x0, 2) + Math.Pow(point.Y - y0, 2) - Math.Pow((rx - ry) / 2 + 2*Width, 2);
            double resInner = Math.Pow(point.X - x0, 2) / Math.Pow(rx - Width, 2) + Math.Pow(point.Y - y0, 2) / Math.Pow(ry + Width, 2) - 1;
            double resOuter = Math.Pow(point.X - x0, 2) / Math.Pow(rx + Width, 2) + Math.Pow(point.Y - y0, 2) / Math.Pow(ry + 2*Width, 2) - 1;
            
            if (resCircleIn <= resInner && resCircleOut <= resOuter)
                //(res <= 0.1*Width && res >= -0.1*Width)
            {
                return true;
            }
            return false;
        }

        public PointF[] GetPointsInner(int width, int height)
        {
            LinkedList<PointF> points = new LinkedList<PointF>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    PointF point = new PointF(i, j);
                    if (IsThisFigure(point))
                    {
                        points.AddLast(point);
                    }
                }
            }
            return points.ToArray();
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

        public override void MoveFace(PointF delta)
        {
            
        }

        public override bool IsThisVertex(PointF point)
        {
            return false;
        }

        public override void MoveVertex(PointF delta)
        {
            
        }
    }
}
