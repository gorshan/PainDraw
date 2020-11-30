using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Draw.Figures;

namespace Draw.Canvases
{
   public class AnglePointsDrawer :IDrawer
    {
       
        public void DrawFigure(Graphics graphics, Pen pen, Point [] points)
        {
                graphics.DrawLines(pen, points);

        }
    }
}
