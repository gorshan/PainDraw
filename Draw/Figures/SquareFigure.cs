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
        public List<Point> Points { get; set; }

        public SquareFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public void Update(Point startPoint, Point endPoint)
        {
            int a = endPoint.Y - startPoint.Y;
            Points = new List<Point>
            {
                startPoint                
            };
            if ((endPoint.X - startPoint.X > 0) && (endPoint.Y - startPoint.Y < 0))
            {
                Points.Add(new Point(startPoint.X, endPoint.Y));
                Points.Add(new Point(startPoint.X - a, endPoint.Y));
                Points.Add(new Point(startPoint.X - a, startPoint.Y));
            }
            else if ((endPoint.X - startPoint.X < 0) && (endPoint.Y - startPoint.Y > 0))
            {
                Points.Add(new Point(startPoint.X - a, startPoint.Y));
                Points.Add(new Point(startPoint.X - a, endPoint.Y));
                Points.Add(new Point(startPoint.X, endPoint.Y));
            }
            else
            {
                Points.Add(new Point(startPoint.X, endPoint.Y));
                Points.Add(new Point(startPoint.X + a, endPoint.Y));
                Points.Add(new Point(startPoint.X + a, startPoint.Y));
            }
        }
    }
}
