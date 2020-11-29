using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw.Canvases
{
    public class AngleByPointsDrawer : IDrawer
    {
        public void DrawFigure(Graphics graphics, Pen pen, Point [] points)
        {

            points[0] = points[1];
            graphics.DrawLine(pen, points[0], points[1]);
           // points[0] = points[1];
                
            
        }
    }
}
