﻿using Draw.Drawer;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class SquareFigure : AbstractFigure
    {
        public SquareFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public override void Update(PointF startPoint, PointF endPoint)
        {
            float a = Math.Abs(endPoint.Y - startPoint.Y);
            Points = new List<PointF>
            {
                startPoint
            };

            if (startPoint.X > endPoint.X)
            {
                a = -a;
            }
            Points.Add(new PointF(startPoint.X, endPoint.Y));
            Points.Add(new PointF(startPoint.X + a, endPoint.Y));
            Points.Add(new PointF(startPoint.X + a, startPoint.Y));
        }

    }
}
