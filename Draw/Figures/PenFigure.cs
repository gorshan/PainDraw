using Draw.Canvases;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
    public class PenFigure : IFigure
    {
        private LinkedList<Point> points;

        public IDrawer Drawer { get; set; }

        public PenFigure()
        {
            Drawer = new PenDrawer();
        }

        private Point _startPoint;
        private Point _endPoint;

        //public PenFigure()
        //{
        //    points = new LinkedList<Point>();
        //}
       

        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            //if (point != null)
            //{
            //    pen.StartCap = LineCap.Round;
            //    pen.EndCap = LineCap.Round;
            //    graphics.DrawLine(pen, point, endPoint);
            //}
            //else
            //{
            //    pen.StartCap = LineCap.Round;
            //    pen.EndCap = LineCap.Round;
            //    graphics.DrawLine(pen, startPoint, endPoint);
            //}

            //point = endPoint;


            if (!(points.Contains(startPoint)))
            {
                points.AddLast(startPoint);
            }
            points.AddLast(endPoint);
            return points.ToArray();
        }

        public void ClearPoints()
        {
            points.Clear();
        }

        public Point[] GetPoints()
        {
            return GetPoints(_startPoint, _endPoint);
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }
    }
}
