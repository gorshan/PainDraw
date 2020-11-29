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
        public Point[] GetPoints(Point startpoint, Point endpoint)
        {
            Point[] point = new Point[2];
           if (endpoint.X == 0 && endpoint.Y == 0)
            {
                point[0] = startpoint;
                point[1] = point[0];
            }
           else
            {
                point[0] = startpoint;
                point[1] = endpoint;
            }
            return point;
        }
    }
}
