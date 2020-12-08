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

        public Point [] PointsFace { get; set; }
        public List<Point> Points { get; set; }

        public Color Color { get; set; }
        public int Width { get; set; }

        public abstract void Update(Point startPoint, Point endPoint);

        public abstract void Move(Point delta);

        public abstract bool IsThisFigure(Point point);
        public abstract bool IsThisVertex(Point point);
        public abstract void MoveVertex(Point delta);

        public Point[] GetPoints()
        {
            return Points.ToArray();
        }

        public void Clear()
        {
            if (Points != null)
            Points.Clear();
        }

        public bool IsEmpty()
        {
            if (Points == null)
            {
                return true;
            }
            return false;
        }

        public abstract void MoveFace(Point delta);
    }
}
