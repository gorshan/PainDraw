using Draw.Drawer;
using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.MouseHandlers
{
    public class MoveVertexMouseHandler : IMouseHandler
    {
        private bool _mouseDown;
        public Bitmap OnMouseDown(Point location)
        {
            _mouseDown = true;
            Canvas.Current.LastPoint = location;
            Canvas.Current.Figure = null;
            Bitmap bitmapBeforeChange = Canvas.Current.GetImage();
            foreach (AbstractFigure figure in Canvas.Current.Figures)
            {
                if (figure.IsThisVertex(location))
                {
                    Canvas.Current.Figure = figure;
                    Canvas.Current.Figures.Remove(Canvas.Current.Figure);
                    Canvas.Current.DrawAll();
                    break;
                }
            }
            
            return bitmapBeforeChange;
        }

        public Bitmap OnMouseMove(Point location)
        {

            if (_mouseDown && Canvas.Current.Figure != null)
            {
                Point d = new Point(location.X - Canvas.Current.LastPoint.X, location.Y - Canvas.Current.LastPoint.Y);
                Canvas.Current.LastPoint = location;
                Canvas.Current.Figure.MoveVertex(d);
                Canvas.Current.DrawFigure(Canvas.Current.Figure);
            }

            return Canvas.Current.GetTmpImage();
        }

        public Bitmap OnMouseUp(Point location)
        {
            Canvas.Current.EndDraw();
            _mouseDown = false;
            if (Canvas.Current.Figure != null && !Canvas.Current.Figures.Contains(Canvas.Current.Figure) && !(Canvas.Current.Figure.IsEmpty()))
            {
                Canvas.Current.Figures.Add(Canvas.Current.Figure);
            }
            if (!(Canvas.Current.Figure is NPointsFigure) ||
                ((NPointsFigure)Canvas.Current.Figure).IsFull())
            {
                Canvas.Current.RenewFigure();
            }
            return Canvas.Current.GetImage();
        }
    }
}
