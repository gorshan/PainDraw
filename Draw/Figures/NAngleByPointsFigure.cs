using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    class NAngleByPointsFigure : FigureByPoints
    {
        public int N { get; set; }

        public NAngleByPointsFigure(int n)
        {
            N = n;
        }

        public override void DrawFigure(Graphics graphics, Pen pen, List<Point> points)
        {
            graphics.DrawLines(pen, GetPoints(points));

        }

        private Point[] GetPoints(List<Point> points)
        {
            Point[] pointsArray = new Point[N+1];
            points.CopyTo(0, pointsArray, 0, N);
            pointsArray[N] = pointsArray[0];
            return pointsArray;
        }
    
    }
}
