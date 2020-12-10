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

        public PointF FindCentre()
        {
            PointF centre = new PointF(
               x: Points.Sum(x => x.X) / Points.Count,
               y: Points.Sum(x => x.Y) / Points.Count);
            return centre;
        }
        public void RotateFigure(PointF endPoint)
        {
            int k;
            PointF centre = FindCenter();
            double a = Math.Sqrt(Math.Pow(Canvas.Current.LastPoint.X - centre.X, 2) + Math.Pow(Canvas.Current.LastPoint.Y - centre.Y, 2));
            double b = Math.Sqrt(Math.Pow(endPoint.X - centre.X, 2) + Math.Pow(endPoint.Y - centre.Y, 2));
            double c = Math.Sqrt(Math.Pow(endPoint.X - Canvas.Current.LastPoint.X, 2) + Math.Pow(endPoint.Y - Canvas.Current.LastPoint.Y, 2));
            if (Canvas.Current.Figure != null)
            {
                //double phi = Math.Acos((Canvas.Current.LastPoint.X * endPoint.X + Canvas.Current.LastPoint.Y * endPoint.Y) / a / b);
                if (Canvas.Current.LastPoint.X - centre.X > 0)
                    k = 1;
                else
                    k = -1;

                double phi = k * Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * Math.PI / 180;
                Canvas.Current.LastPoint = endPoint;
                Canvas.Current.Figure.Rotate(phi);
                Canvas.Current.DrawFigure(Canvas.Current.Figure);
            }
        }

        public void Rotate(double phi)
        {
            PointF center = FindCenter();
            for (int i = 0; i < Points.Count(); i++)
            {
                PointF points = Points[i];
                PointF delta = new PointF(points.X - center.X, points.Y - center.Y);
                Points[i] = new PointF(
                    (float)(center.X + delta.X * Math.Cos(phi) - delta.Y * Math.Sin(phi)),
                    (float)(center.Y + delta.X * Math.Sin(phi) + delta.Y * Math.Cos(phi))
                    );
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

        public PointF FindCenter()
        {
            float xCenter = 0;
            float yCenter = 0;
            for (int i = 0; i < Points.Count(); i++)
            {
                xCenter += Points[i].X;
                yCenter += Points[i].Y;
            }
            PointF center = new PointF(xCenter / Points.Count(), yCenter / Points.Count());
            return center;
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
