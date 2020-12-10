using Draw.Drawer;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class PenFigure : AbstractFigure
    {
        private PointF _lastPoint;
        

        public PenFigure()
        {
            Points = new List<PointF>();
            Drawer = new PenDrawer();
        }

        private void AddPoint(PointF startPoint, PointF endPoint)
        {
            if (_lastPoint == null)
            {
                _lastPoint = startPoint;
            }
            if (Math.Abs(endPoint.X - _lastPoint.X) > 4 || Math.Abs(endPoint.Y - _lastPoint.Y) > 4)
            {
                Points.Add(endPoint);
                _lastPoint = endPoint;
            }
        }

        public void ClearPoints()
        {
            Points.Clear();
        }

        public override void Update(PointF startPoint, PointF endPoint)
        {
            AddPoint(startPoint, endPoint);
        }

        public override bool IsThisFigure(PointF point)
        {
            PointF p1 = new PointF(0,0);
            PointF p2;
            
            if(Points.Count != 0)
                p1 = Points[0];
            foreach (PointF p in Points)
            {
                p2 = p;
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(10 * ((p2.Y - p1.Y) + (p2.X - p1.X)))
                    && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
                    && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))))
                {
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public override void FillFigure()
        {
            IsFilled = !IsFilled;
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
