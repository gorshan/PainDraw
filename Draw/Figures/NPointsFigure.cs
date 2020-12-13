using Draw.Drawer;
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
        public int N { get; set; }
        public override int Width
        {
            get
            {
                if (IsFilled && N != int.MaxValue)
                {
                    return 1;
                }
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        private int _width;


        public NPointsFigure(int n)
        {
            N = n;
            Points = new List<PointF>();
            Drawer = new PenDrawer();
        }

        public NPointsFigure()
        {
            N = 3;
            Points = new List<PointF>();
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

        public override void Update(PointF startPoint, PointF endPoint)
        {
            if (Points.Count < N)
            {
                Points.Add(endPoint);
                if (Points.Count >= N)
                {
                    if (IsFilled)
                    {
                        Drawer = new FilledAngleFiguresDrawer(Color, ColorBackgroundFigure);
                    }
                    else
                    {
                        Drawer = new AngleFiguresDrawer();
                    }
                }
            }
        }


        public override void FillFigure()
        {
            IsFilled = !IsFilled;
            if (Points.Count >= N)
            {
                if (IsFilled)
                {
                    Drawer = new FilledAngleFiguresDrawer(Color, ColorBackgroundFigure);
                }
                else
                {
                    Drawer = new AngleFiguresDrawer();
                }
            }
        }
    }
}
