using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Draw.Drawer;

namespace Draw.Figures
{
    public interface IFigure
    {
        IDrawer Drawer{ get; }

        void SetPoints(Point startPoint, Point endPoint);

        Point[] GetPoints();
        Point[] GetPoints(Point startPoint, Point endPoint);
    }
}
