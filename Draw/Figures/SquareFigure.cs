﻿using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class SquareFigure : IFigure
    {
        public IDrawer Drawer { get; set; }

        public SquareFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            int a = endPoint.Y - startPoint.Y;
            Point[] points = new Point[4];
            points[0] = startPoint;
            points[1] = new Point(startPoint.X, endPoint.Y);
            if ((endPoint.X - startPoint.X > 0) && (endPoint.Y - startPoint.Y < 0))
            {
                points[2] = new Point(startPoint.X - a, endPoint.Y);
                points[3] = new Point(startPoint.X - a, startPoint.Y);
            }
            else if ((endPoint.X - startPoint.X < 0) && (endPoint.Y - startPoint.Y > 0))
            {
                points[1] = new Point(startPoint.X - a, startPoint.Y);
                points[2] = new Point(startPoint.X - a, endPoint.Y);
                points[3] = new Point(startPoint.X, endPoint.Y);
            }
            else
            {
                points[2] = new Point(startPoint.X + a, endPoint.Y);
                points[3] = new Point(startPoint.X + a, startPoint.Y);
            }
            return points;
        }

        public Point[] GetPoints()
        {
            return GetPoints(_startPoint, _endPoint);
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }
    }
}
