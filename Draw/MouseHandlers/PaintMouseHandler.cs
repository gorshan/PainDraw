using Draw.BitmapOperations.OperationParameters;
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
    public class PaintMouseHandler : IMouseHandler
    {
        private bool _mouseDown;
        public Bitmap OnMouseDown(PointF location)
        {
            _mouseDown = true;
            Canvas.Current.LastPoint = location;
            if (Canvas.Current.Figure is NPointsFigure)
            {
                OnMouseMove(location);
                _mouseDown = false;
            }
            return Canvas.Current.MainBitmap;
        }

        public Bitmap OnMouseMove(PointF location)
        {
            Bitmap forReturn = Canvas.Current.MainBitmap;
            if (_mouseDown)
            {
                Canvas.Current.Figure.Update(Canvas.Current.LastPoint, location);
                Canvas.Current.TmpBitmap = Canvas.Current.Action(new DrawFigureOperationParameters(Canvas.Current.Figure));
                forReturn = Canvas.Current.TmpBitmap;
            }
            return forReturn;
        }

        public Bitmap OnMouseUp(PointF location)
        {
            Canvas.Current.MainBitmap = Canvas.Current.Action(new EndDrawOperationParameters());
            _mouseDown = false;

            Bitmap bitmap = Canvas.Current.MainBitmap;
            //Graphics graphics = Graphics.FromImage(bitmap);
            //PointF[] points;
            //if (Canvas.Current.Figure is CircleFigure)
            //    points = ((CircleFigure)Canvas.Current.Figure).GetPointsInner(bitmap.Width, bitmap.Height);
            //else
            //    points = ((EllipseFigure)Canvas.Current.Figure).GetPointsInner(bitmap.Width, bitmap.Height);
            //foreach (PointF p in points)
            //{
            //    bitmap.SetPixel(p.X, p.Y, Color.Black);
            //}

            if (Canvas.Current.Figure != null && !Canvas.Current.Figures.Contains(Canvas.Current.Figure) && !(Canvas.Current.Figure.IsEmpty()))
            {
                Canvas.Current.Figures.Add(Canvas.Current.Figure);
            }
            if (!(Canvas.Current.Figure is NPointsFigure) ||
                ((NPointsFigure)Canvas.Current.Figure).IsFull())
            {
                Canvas.Current.RenewFigure();
            }
            return bitmap;
        }
    }
}
