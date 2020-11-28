﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw.Figures;

namespace Draw.Figures
{
    public class RectangleFigure : IFigure
    {

        public void DrawFigure(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            graphics.DrawPolygon(pen, GetPoints(startPoint, endPoint));
        }
        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, endPoint.Y);
            points[2] = endPoint;
            points[3] = new Point(endPoint.X, startPoint.Y);

            return points;
        }
    }
}
