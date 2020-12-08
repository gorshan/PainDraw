using Draw.Canvases;
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
            Drawer = new EllipseDrawer();
        }

        public override void Update(Point startPoint, Point endPoint)
        {
            Points = new List<Point>
            {
                new Point(startPoint.X),
                new Point(startPoint.Y),
                new Point(endPoint.X - startPoint.X),
                new Point(endPoint.Y - startPoint.Y)
            };
        }

        public override void Move(Point delta)
        {
            
        }

        public override bool IsThisFigure(Point point)
        {
            return false;
        }

        public override void MoveFace(Point delta)
        {
            
        }

        public override bool IsThisVertex(Point point)
        {
            throw new NotImplementedException();
        }

        public override void MoveVertex(Point delta)
        {
            throw new NotImplementedException();
        }
    }
}
