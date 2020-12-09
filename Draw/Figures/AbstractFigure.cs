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
        public Point Vertex { get; set; }
        public List<Point> Points { get; set; }

        public Color Color { get; set; }

        public virtual int Width { get; set; }

        public bool IsFilled { get; set; } = false;

        public abstract void Update(Point startPoint, Point endPoint);

        public  virtual void Move(Point delta)
        {
            for (int i = 0; i < Points.Count(); i++)
            {
                Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
            }
        }

        public virtual bool IsThisFigure(Point point)
        {
            Point p1 = Points[Points.Count - 1];
            Point p2;
            foreach (Point p in Points)
            {
                p2 = p;
                if (Math.Abs((point.X - p1.X) * (p2.Y - p1.Y) - (point.Y - p1.Y) * (p2.X - p1.X))
                    <= Math.Abs(20 * ((p2.Y - p1.Y) + (p2.X - p1.X)))
                    && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
                    && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))))
                {
                    PointsFace = new Point[] { p1, p2 };
                    return true;
                }
                p1 = p2;
            }
            return false;
        }

        public virtual void MoveFace(Point delta)
        {
            if (PointsFace != null)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i] == PointsFace[0])
                    {
                        PointsFace[0] = new Point(PointsFace[0].X + delta.X, PointsFace[0].Y + delta.Y);
                        Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                    if (Points[i] == PointsFace[1])
                    {
                        PointsFace[1] = new Point(PointsFace[1].X + delta.X, PointsFace[1].Y + delta.Y);
                        Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                }
            }
        }

        public virtual bool IsThisVertex(Point point)
        {
            foreach (Point p in Points)
            {
                if (Math.Abs(point.X - p.X) < 5 && Math.Abs(point.Y - p.Y) < 5)
                {
                    Vertex = p;
                    return true;
                }
            }
            return false;
        }
        public virtual void MoveVertex(Point delta)
        {
            if (Vertex != null)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i] == Vertex)
                    {
                        Vertex = new Point(Vertex.X + delta.X, Vertex.Y + delta.Y);
                        Points[i] = new Point(Points[i].X + delta.X, Points[i].Y + delta.Y);
                    }
                }
            }
        }

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
        public Point[] GetPointsInner(int width, int height)
        {
            LinkedList<Point> points = new LinkedList<Point>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Point point = new Point(i, j);
                    if (IsThisVertex(point))
                    {
                        points.AddLast(point);
                    }
                }
            }
            return points.ToArray();
        }

        public void Scale(Point delta)
        {
        
            for (int i = 1; i < Points.Count; i++)
            {
                if (Points[0].X >= Points[i].X)
                { Points[i] = new Point(Points[i].X + delta.X, Points[i].Y); }
                if (Points[0].Y >= Points[i].Y)
                { Points[i] = new Point(Points[i].X , Points[i].Y + delta.Y); }
            }

            
        }

    }
}
