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
    public class NAngleFigure : IFigure
    {
        public int N { get; set; }

        public IDrawer Drawer { get; set; }
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public NAngleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public NAngleFigure(int n)
        {
            N = n;
            Drawer = new AngleFiguresDrawer();
        }

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>();
            double r;
            r = Math.Sqrt(Math.Pow(endPoint.Y - startPoint.Y, 2) + Math.Pow(endPoint.X - startPoint.X, 2));
            for (int i = 0; i < N; i++)
            {
                Points.Add(new Point(Convert.ToInt32(startPoint.X + r * Math.Cos((2 * Math.PI * i) / N)),
                                      Convert.ToInt32(startPoint.Y + r * Math.Sin((2 * Math.PI * i) / N))));
            }
        }

        public void Move(Point delta)
        {
            throw new NotImplementedException();
        }

        public bool IsThisFigure(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
