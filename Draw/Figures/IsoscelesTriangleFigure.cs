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
    public class IsoscelesTriangleFigure : AbstractFigure
    {
        public IsoscelesTriangleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>
            {
                startPoint,
                new Point(2 * startPoint.X - endPoint.X, endPoint.Y),
                endPoint
            };
        }


    }
}
