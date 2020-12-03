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

        Point[] GetPoints();

        List<Point> Points { get; set; }

        Color Color { get; set; }
        int Width { get; set; }

        void Update(Point startPoint, Point endPoint);

        void Move(Point delta);

    }
}
