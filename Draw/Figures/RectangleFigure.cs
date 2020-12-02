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
    }
}
