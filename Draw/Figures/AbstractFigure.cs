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

        public PointF [] PointsFace { get; set; }
        public PointF Vertex { get; set; }
        public List<PointF> Points { get; set; }

        public Color Color { get; set; }

        public virtual int Width { get; set; }

        public bool IsFilled { get; set; } = false;

        public abstract void Update(PointF startPoint, PointF endPoint);

        public  virtual void Move(PointF delta)
        {
            for (int i = 0; i < Points.Count(); i++)
            {
                Points[i] = new PointF(Points[i].X + delta.X, Points[i].Y + delta.Y);
            }
        }
        
        public virtual bool IsThisFigure(PointF point)

        {
            PointF p1 = Points[Points.Count - 1];
            PointF p2;
            foreach (PointF p in Points)
            {
                p2 = p;
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
                    <= Width*0.8 * Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2))
                    && (((p1.X - Width <= point.X) && (point.X <= p2.X + Width)) || ((p1.X + Width >= point.X) && (point.X >= p2.X - Width)))
                    && (((p1.Y - Width <= point.Y) && (point.Y <= p2.Y + Width)) || ((p1.Y + Width >= point.Y) && (point.Y >= p2.Y - Width))))
                {
                    PointsFace = new PointF[] { p1, p2 };
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public virtual void MoveFace(PointF delta)
        {
            if (PointsFace != null)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i] == PointsFace[0])
                    {
                        PointsFace[0] = new PointF(PointsFace[0].X + delta.X, PointsFace[0].Y + delta.Y);
                        Points[i] = new PointF(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                    if (Points[i] == PointsFace[1])
                    {
                        PointsFace[1] = new PointF(PointsFace[1].X + delta.X, PointsFace[1].Y + delta.Y);
                        Points[i] = new PointF(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                }
            }
        }

        public virtual bool IsThisVertex(PointF point)
        {
            foreach (PointF p in Points)
            {
                if (Math.Abs(point.X - p.X) < 5 && Math.Abs(point.Y - p.Y) < 5)
                {
                    Vertex = p;
                    return true;
                }
            }
            return false;
        }
        public virtual void MoveVertex(PointF delta)
        {
            if (Vertex != null)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i] == Vertex)
                    {
                        Vertex = new PointF(Vertex.X + delta.X, Vertex.Y + delta.Y);
                        Points[i] = new PointF(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                }
            }
        }

        public PointF[] GetPoints()
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
            if (Points == null  || Points.Count == 0)
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
        public PointF[] GetPointsInner(int width, int height)
        {
            LinkedList<PointF> points = new LinkedList<PointF>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    PointF point = new PointF(i, j);
                    if (IsThisVertex(point))
                    {
                        points.AddLast(point);
                    }
                }
            }
            return points.ToArray();
        }
    }
}
