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
    public class EllipseFigure : AbstractFigure
    {
        public EllipseFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public override void Update(PointF startPoint, PointF endPoint)
        {
            Points = new List<PointF>();
            int N = 50;
            double r1;
            double r2;
            r1 = (endPoint.X - startPoint.X) / 2;
            r2 = (endPoint.Y - startPoint.Y) / 2;
            double x = startPoint.X + r1;
            double y = startPoint.Y + r2;

            for (int i = 0; i < N; i++)
            {
                Points.Add(new PointF(Convert.ToInt32(x + r1 * Math.Cos((2 * Math.PI * i) / N)),
                                     Convert.ToInt32(y + r2 * Math.Sin((2 * Math.PI * i) / N))));

            }
        }

        //public override void Move(PointF delta)
        //{
        //    Points[0] = new PointF(Points[0].X + delta.X, Points[0].Y);
        //    Points[1] = new PointF(Points[1].X + delta.Y, Points[1].Y);
        //}


        public PointF[] GetPointsInner(int width, int height)
        {
            LinkedList<PointF> points = new LinkedList<PointF>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    PointF point = new PointF(i, j);
                    if (IsThisFigure(point))
                    {
                        points.AddLast(point);
                    }
                }
            }
            return points.ToArray();
        }

        public override void FillFigure()
        {
            IsFilled = !IsFilled;
            if (IsFilled)
            {
                Drawer = new FilledAngleFiguresDrawer(Color, ColorBackgroundFigure);
            }
            else
            {
                Drawer = new AngleFiguresDrawer();
            }
        }

        public override void MoveFace(PointF delta)
        {
            
        }

        public override bool IsThisVertex(PointF point)
        {
            return false;
        }

        public override void MoveVertex(PointF delta)
        {
            
        }
    }
}
