using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draw.Drawer;
using Draw.Drawer;
using Draw.Figures;

namespace Draw.Figures
{
    public class RectangleFigure : AbstractFigure
    {
        public RectangleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }


        public override void Update(PointF startPoint, PointF endPoint)
        {
            Points = new List<PointF>
            {
                startPoint,
                new PointF(startPoint.X, endPoint.Y),
                endPoint,
                new PointF(endPoint.X, startPoint.Y)
            };
        }

    }
}
