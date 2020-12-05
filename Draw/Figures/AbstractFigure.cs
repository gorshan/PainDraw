using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Draw.Drawer;

namespace Draw.Figures
{
    public abstract class AbstractFigure
    {
        public IDrawer Drawer{ get; protected set; }


        public List<Point> Points { get; set; }

        public Color Color { get; set; }
        public int Width { get; set; }

        public abstract void Update(Point startPoint, Point endPoint);

        public abstract void Move(Point delta);

        public abstract bool IsThisFigure(Point point);
        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void Clear()
        {
            Points.Clear();
        }

    }
}
