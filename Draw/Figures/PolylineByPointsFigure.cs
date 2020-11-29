using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    class PolylineByPointsFigure : FigureByPoints
    {
        public override void DrawFigure(Graphics graphics, Pen pen,List<Point> points)
        {
            Point[] point = GetPoints(points);
            graphics.DrawLine(pen, point[0].X, point[0].Y, point[1].X, point[1].Y);
        }

        private Point[] GetPoints(List<Point> points)
        {
            Point[] point = new Point[2];
            //point[0] = ;
            //point[1] = endPoint;
            if (point[1].X == 0 && point[1].Y == 0)
            {
                point[1] = point[0];
            }
            return point;
        }
    }
}
