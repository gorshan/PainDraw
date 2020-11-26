using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw.Figures
{
    public interface IFigure
    {
        void DrawFigure(Graphics graphics, Pen pen, Point startPoint, Point endPoint);
    }
}
