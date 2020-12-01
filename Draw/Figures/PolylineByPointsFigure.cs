using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Figures
{
   public class PolylineByPointsFigure : IFigure
    {
        public LinkedList<Point> Points { get; set; }

        public IDrawer Drawer => throw new NotImplementedException();

        public PolylineByPointsFigure()
        {
            Points = new LinkedList<Point>();
        }

        public Point[] GetPoints(Point startpoint, Point endpoint)
        {
            
            Point[] pointsArray = new Point[Points.Count + 2];
            Points.CopyTo(pointsArray,0);
            pointsArray[pointsArray.Length - 1] = endpoint;
            return Points.ToArray();
        }

        internal void Clesr()
        {
            Points.Clear();
        }

        public void SetPoints(Point startPoint, Point endPoint)
        {
            throw new NotImplementedException();
        }

        public Point[] GetPoints()
        {
            throw new NotImplementedException();
        }
    }
}
