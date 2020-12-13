using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Drawer
{
    public class FilledAngleFiguresDrawer : IDrawer
    {
        public Color ColorBackground { get; set; }
        public Color Color { get; set; }

        public FilledAngleFiguresDrawer(Color color, Color colorBackground)
        {
            ColorBackground = colorBackground;
            Color = color;
        }

        public void DrawFigure(Graphics graphics, Pen pen, PointF[] figurePoints)
        {
            graphics.FillPolygon(new SolidBrush(ColorBackground), figurePoints);
            graphics.DrawPolygon(new Pen(Color, pen.Width), figurePoints);
        }
    }
}
