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
    public class IsoscelesTriangleFigure : AbstractFigure
    {
        public IsoscelesTriangleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }

        public override void Update(PointF startPoint, PointF endPoint)
        {
            Points = new List<PointF>
            {
                startPoint,
                new PointF(2 * startPoint.X - endPoint.X, endPoint.Y),
                endPoint
            };
        }

      
    }
}
