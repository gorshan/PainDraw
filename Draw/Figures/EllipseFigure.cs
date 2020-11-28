﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class EllipseFigure : IFigure
    {
        
        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[4];
            points[0] = new Point(startPoint.X);
            points[1] = new Point(startPoint.Y);
            points[2] = new Point(endPoint.X - startPoint.X);
            points[3] = new Point(endPoint.Y - startPoint.Y);
            return points;
        }
    }
}
