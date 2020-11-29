using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Canvases
{
    public interface IDrawer
    {
        void DrawFigure(Graphics graphics, Pen pen, Point[] figurePoints);
    }
}
