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
    public class IsoscelesTriangleFigure : IFigure
    {
        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public IsoscelesTriangleFigure()
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
                new Point(2 * startPoint.X - endPoint.X, endPoint.Y),
                endPoint
            };
        }

        public void Move(Point delta)
        {
            throw new NotImplementedException();
        }
    }
}
