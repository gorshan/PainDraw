﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class RightTriangleFigure : IFigure
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            graphics.DrawPolygon(pen, GetPoints(startPoint, endPoint));
        }

        private Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[3];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, endPoint.Y);
            points[2] = endPoint;
            return points;
        }
    }
}