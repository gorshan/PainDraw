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

        void Update(Point startPoint, Point endPoint);

        Point[] GetPoints();

        List<Point> Points { get; set; }

    }
}
