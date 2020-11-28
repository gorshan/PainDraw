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

        public NAngleFigure(int n)
        {
            N = n;
        }
        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            double r;
            r = Math.Sqrt(Math.Pow(endPoint.Y - startPoint.Y, 2) + Math.Pow(endPoint.X - startPoint.X, 2));
            Point[] points = new Point[N];
            for (int i = 0; i < N; i++)
            {
                points[i] = new Point(Convert.ToInt32(startPoint.X + r * Math.Cos((2 * Math.PI * i) / N)),
                                      Convert.ToInt32(startPoint.Y + r * Math.Sin((2 * Math.PI * i) / N)));
            }
            return points;
        }

        public void DrawFigure(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            graphics.DrawPolygon(pen, GetPoints(startPoint, endPoint));
        }
    }
}
