using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw.Figures
{
    abstract class FigureByPoints
    {
        abstract public void DrawFigure(Graphics graphics, Pen pen, List<Point> points);
        

    }
}
