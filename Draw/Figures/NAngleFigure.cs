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
        private PointF[] _points;
        private int _n;
        public int N { 
            get { return _n; }
            set { _n = value; } 
        }


        public NAngleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public NAngleFigure(int n)
        {
            N = n;
            Drawer = new AngleFiguresDrawer();
        }

        public override void Update(PointF startPoint, PointF endPoint)
        {
            Points = new List<PointF>();
            double r;
            r = Math.Sqrt(Math.Pow(endPoint.Y - startPoint.Y, 2) + Math.Pow(endPoint.X - startPoint.X, 2));
           
            for (int i = 0; i < N; i++)
            {
                Points.Add(new PointF(Convert.ToInt32(startPoint.X + r * Math.Cos((2 * Math.PI * i) / N)),
                                     Convert.ToInt32(startPoint.Y + r * Math.Sin((2 * Math.PI * i) / N))));

            }
        }


    }
}
