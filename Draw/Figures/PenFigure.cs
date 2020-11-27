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
        private Point point;
        public void DrawFigure(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            if (point != null)
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                graphics.DrawLine(pen, point, endPoint);
            }
            else
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                graphics.DrawLine(pen, startPoint, endPoint);
            }
            
            point = endPoint;
        }
    }
}
