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

        public PolylineByPointsFigure()
        {
            Points = new LinkedList<Point>();
        }

        public Point[] GetPoints(Point startpoint, Point endpoint)
        {
            // Point[] point = new Point[2];
            //if (endpoint.X == 0 && endpoint.Y == 0)
            // {
            //     point[0] = startpoint;
            //     point[1] = point[0];
            // }
            // else
            // {
            //     point[0] = startpoint;
            //     point[1] = endpoint;
            // }
            Point[] pointsArray = new Point[Points.Count + 2];
            Points.CopyTo(pointsArray,0);
            pointsArray[pointsArray.Length - 1] = endpoint;
            return Points.ToArray();
        }

        internal void Clesr()
        {
            Points.Clear();
        }
    }
}
