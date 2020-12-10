using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Draw.Drawer;
using System.Diagnostics;

namespace Draw.Figures
{
    public abstract class AbstractFigure
    {
        public IDrawer Drawer{ get; protected set; }

        public PointF [] PointsFace { get; set; }
        public PointF Vertex { get; set; }
        public List<PointF> Points { get; set; }

        public Color Color { get; set; }
        public Color ColorInside { get; set; }
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
                    <= Math.Abs(20 * ((p2.Y - p1.Y) + (p2.X - p1.X)))
                    && (((p1.X <= point.X) && (point.X <= p2.X)) || ((p1.X >= point.X) && (point.X >= p2.X)))
                    && (((p1.Y <= point.Y) && (point.Y <= p2.Y)) || ((p1.Y >= point.Y) && (point.Y >= p2.Y))))
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
            return Points?.ToArray() ?? Array.Empty<PointF>();
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

        public PointF FindCentre()
        {
            PointF centre = new PointF(
               x: Points.Sum(x => x.X) / Points.Count,
               y: Points.Sum(x => x.Y) / Points.Count);
            return centre;
        }

        public void Scale(double m)
        {
            PointF centre = FindCentre();
            Debug.WriteLine(centre);

            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new PointF(
                    x: (float)(centre.X + (Points[i].X - centre.X)*m),
                    y: (float)(centre.Y + (Points[i].Y - centre.Y)*m));
            }


        }


       public bool IsPointInsidePolygon(PointF[] points, float x, float y)
        {
            float  S, S1, S2, S3;
            int i1, i2, N;
            bool flag = false;
            N = points.Length;
            for (int n = 0; n < N; n++)
            {
                flag = false;
                i1 = n < N - 1 ? n + 1 : 0;
                while (!flag)
                {
                    i2 = i1 + 1;
                    if (i2 >= N)
                        i2 = 0;
                    if (i2 == (n < N - 1 ? n + 1 : 0))
                        break;

                    S = Math.Abs(points[i1].X * (points[i2].Y - points[n].Y) +
                             points[i2].X * (points[n].Y - points[i1].Y) +
                             points[n].X * (points[i1].Y - points[i2].Y));
                    S1 = Math.Abs(points[i1].X * (points[i2].Y - y) +
                              points[i2].X * (y - points[i1].Y) +
                              x * (points[i1].Y - points[i2].Y));
                    S2 = Math.Abs(points[n].X * (points[i2].Y - y) +
                              points[i2].X * (y - points[n].Y) +
                              x * (points[n].Y - points[i2].Y));
                    S3 = Math.Abs(points[i1].X * (points[n].Y - y) +
                              points[n].X * (y - points[i1].Y) +
                              x * (points[i1].Y - points[n].Y));
                    if (S == S1 + S2 + S3)
                    {
                        flag = true;
                        break;
                    }
                    i1 = i1 + 1;
                    if (i1 >= N)
                        i1 = 0;
                }
                if (!flag)
                    break;
            }
            return flag;
        }



    }
}
