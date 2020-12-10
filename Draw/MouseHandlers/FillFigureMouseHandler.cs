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
        private AbstractFigure figurka;
        public Bitmap OnMouseDown(PointF location)
        {
         
            Canvas.Current.LastPoint = location;
            Bitmap bitmapBeforeChange = Canvas.Current.GetImage();
            if (Canvas.Current.Figure != null)
            {
                foreach (AbstractFigure figure in Canvas.Current.Figures)
                {
                    var points = figure.GetPoints();
                    //if (points == null) continue;
                    if (figure.IsPointInsidePolygon(points, location.X, location.Y))
                    {
                        figurka = figure;
                        figure.FillFigure();
                        figure.Color = Canvas.Current.Pen.Color;
                        Canvas.Current.DrawFigure(figure);
                     //  Canvas.Current.EndDraw();
                        
                     //  Canvas.Current.EndDraw();
                    }
                }
            }
              return Canvas.Current.GetTmpImage();
        }

        public Bitmap OnMouseMove(PointF location)
        {
            //if (_mouseDown && Canvas.Current.Figure != null)
            //{
            //    foreach (AbstractFigure figure in Canvas.Current.Figures)
            //    {
            //        if ( figure.IsPointInsidePolygon(figure.Points, location.X, location.Y)
            //    }
            //}
            return Canvas.Current.GetTmpImage();
        }

        public Bitmap OnMouseUp(PointF location)
        {

            //figurka.Color = figurka.ColorInside;
            //figurka.IsFilled = false;
            //Canvas.Current.DrawFigure(figurka);

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
