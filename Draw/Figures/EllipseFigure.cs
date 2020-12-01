using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw.Figures
{
    public class EllipseFigure : IFigure
    {
        
        public Point[] GetPoints(Point startPoint, Point endPoint)
        {
            Point[] points = new Point[4];
            if (Control.ModifierKeys == Keys.Shift)
            {
                int r = (int)Math.Sqrt(Math.Pow(((double)endPoint.Y - startPoint.Y), 2.0) + Math.Pow(((double)endPoint.X - startPoint.X), 2.0));
                int x = startPoint.X - r;
                int y = startPoint.Y - r;                
                points[0] = new Point(x);
                points[1] = new Point(y);
                points[2] = new Point(r * 2);
                points[3] = new Point(r * 2);
            }
            else
            {
                points[0] = new Point(startPoint.X);
                points[1] = new Point(startPoint.Y);
                points[2] = new Point(endPoint.X - startPoint.X);
                points[3] = new Point(endPoint.Y - startPoint.Y);
            }
            return points;

        }
    }
}
