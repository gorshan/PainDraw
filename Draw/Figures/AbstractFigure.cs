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

        public virtual int Width { get; set; }

        public bool IsFilled { get; set; } = false;

        public abstract void Update(Point startPoint, Point endPoint);

        public abstract void Move(Point delta);

        public abstract bool IsThisFigure(Point point);
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
            if (Points == null  && Points.Count == 0)
            {
                return true;
            }
            return false;
        }

        public virtual void FillFigure()
        {
            IsFilled = !IsFilled;
            if (IsFilled)
            {
                Drawer = new FilledAngleFiguresDrawer();
            }
            else
            {
                Drawer = new AngleFiguresDrawer();
            }
        }
        
        public void FillFigure(bool fill)
        {
            IsFilled = !fill;
            FillFigure();
        }
    }
}
