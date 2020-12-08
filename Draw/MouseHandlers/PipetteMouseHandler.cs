using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.MouseHandlers
{
    public class PipetteMouseHandler : IMouseHandler
    {
        public System.Windows.Forms.Button ColorButton { get; private set; }

        public PipetteMouseHandler(System.Windows.Forms.Button colorButton)
        {
            ColorButton = colorButton;
        }

        public Bitmap OnMouseDown(Point location)
        {
            Color pixelColor = Canvas.Current.Pen.Color;
            pixelColor = Canvas.Current.GetImage().GetPixel(location.X, location.Y);
            ColorButton.BackColor = pixelColor;
            Canvas.Current.Pen.Color = pixelColor;
            Canvas.Current.Figure.Color = pixelColor;
            return Canvas.Current.GetImage();
        }

        public Bitmap OnMouseMove(Point location)
        {
            return Canvas.Current.GetImage();
        }

        public Bitmap OnMouseUp(Point location)
        {
            return Canvas.Current.GetImage();
        }
    }
}
