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
    public class RightTriangleFigure : AbstractFigure
    {
        public RightTriangleFigure()
        {
            Drawer = new AngleFiguresDrawer();
        }


        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>
            {
                startPoint,
                new Point(startPoint.X, endPoint.Y),
                endPoint
            };
        }

    }
}
