using Draw.Drawer;
using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.MouseHandlers
{
    public class FillFigureMouseHandler : IMouseHandler
    {
        
        public Bitmap OnMouseDown(PointF location)
        {
         
            Canvas.Current.LastPoint = location;
            if (Canvas.Current.Figure != null)
            {
                foreach (AbstractFigure figure in Canvas.Current.Figures)
                {
                    var points = figure.GetPoints();
                    if (figure.IsPointInsidePolygon(points, location.X, location.Y))
                    {
                        figure.ColorBackgroundFigure = Canvas.Current.Pen.Color;
                        figure.FillFigure();
                        Canvas.Current.DrawFigure(figure);
                    }
                    if (figure.IsThisFigure(location))
                    {
                        figure.Color = Canvas.Current.Pen.Color;
                        Canvas.Current.DrawFigure(figure);
                    }
                }
            }
              return Canvas.Current.GetTmpImage();
        }

        public Bitmap OnMouseMove(PointF location)
        {
          
            return Canvas.Current.GetTmpImage();
        }

        public Bitmap OnMouseUp(PointF location)
        {

            Canvas.Current.EndDraw();

            if (Canvas.Current.Figure != null && !Canvas.Current.Figures.Contains(Canvas.Current.Figure) && !(Canvas.Current.Figure.IsEmpty()))
            {
                Canvas.Current.Figures.Add(Canvas.Current.Figure);
               Canvas.Current.Figure.IsFilled = false;
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
