﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw.Canvases;
using Draw.Drawer;
using Draw.Figures;

namespace Draw.Figures
{
    public class RectangleFigure : IFigure
    {

        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public RectangleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>
            {
                startPoint,
                new Point(startPoint.X, endPoint.Y),
                endPoint,
                new Point(endPoint.X, startPoint.Y)
            };
        }

        public void Move(Point delta)
        {
            for (int i=0; i<Points.Count(); i++)
            {
                Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
            }
        }

        public bool IsThisFigure(Point point)
        {
            Point p1 = Points[3];
            Point p2;
            foreach (Point p in Points)
            {
                p2 = p;
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X)) 
                    <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X))))
                {
                    return true;
                }
                p1 = p2;
            }
            return false;
        }
    }
}
