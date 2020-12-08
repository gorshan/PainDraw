using Draw.Drawer;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class NAngleFigure : AbstractFigure
    {
        private Point[] _points;
        public int N { get; set; }

        public NAngleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public NAngleFigure(int n)
        {
            N = n;
            Drawer = new AngleFiguresDrawer();
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>();
            double r;
            //r = Math.Sqrt(Math.Pow(((double)endPoint.Y - startPoint.Y), 2.0) + Math.Pow(((double)endPoint.X - startPoint.X), 2.0));
            r = Math.Sqrt(Math.Pow(endPoint.Y - startPoint.Y, 2) + Math.Pow(endPoint.X - startPoint.X, 2));
            double r1;
            double r2;
            r1 = (endPoint.X -startPoint.X)/2;
            r2 = (endPoint.Y - startPoint.Y)/2;
            double x = startPoint.X + r1;
            double y = startPoint.Y + r2;
            
            
            
            for (int i = 0; i < N; i++)
            {
                Points.Add(new Point(Convert.ToInt32(x + r1 * Math.Cos((2 * Math.PI * i) / N)),
                                      Convert.ToInt32(y + r2 * Math.Sin((2 * Math.PI * i) / N))));
            }
        }


    }
}
