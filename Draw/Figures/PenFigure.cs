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
