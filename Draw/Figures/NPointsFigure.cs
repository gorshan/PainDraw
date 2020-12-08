using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Draw.Figures
{
   
      public class NPointsFigure : AbstractFigure
    {
        private Point[] _points;
        public int N { get; set; }
        
        public NPointsFigure(int n)
        {
            N = n;
            Points = new List<Point>();
            Drawer = new PenDrawer();
        }

        public NPointsFigure()
        {
            Points = new List<Point>();
            Drawer = new PenDrawer();
        }

        public bool IsFull()
        {
            if (Points.Count >= N)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            if (Points.Count < N)
            {
                Points.Add(endPoint);
                if (Points.Count == N)
                {
                    Drawer = new AngleFiguresDrawer();
                }
            }
        }


      }
}
