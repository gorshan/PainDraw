﻿using Draw.BitmapOperations.OperationParameters;
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
    public class MoveFaceMouseHandler : IMouseHandler
    {
        private bool _mouseDown;

        public Bitmap OnMouseDown(PointF location)
        {
            _mouseDown = true;
            Canvas.Current.LastPoint = location;
            Canvas.Current.Figure = null;
            Bitmap bitmapBeforeChange = Canvas.Current.MainBitmap;
            foreach (AbstractFigure figure in Canvas.Current.Figures)
            {
                if (figure.IsThisFigure(location))
                {
                    Canvas.Current.Figure = figure;
                    Canvas.Current.Figures.Remove(Canvas.Current.Figure);
                    Canvas.Current.MainBitmap = Canvas.Current.Action(new DrawAllFigureOperationParameters());
                    break;
                }
            }
            return bitmapBeforeChange;
        }

        public Bitmap OnMouseMove(PointF location)
        {
            if (_mouseDown&&Canvas.Current.Figure != null)
            {
                PointF d = new PointF(location.X - Canvas.Current.LastPoint.X, location.Y - Canvas.Current.LastPoint.Y);
                Canvas.Current.LastPoint = location;
                (Canvas.Current.Figure).MoveFace(d);
                Canvas.Current.TmpBitmap = Canvas.Current.Action(new DrawFigureOperationParameters(Canvas.Current.Figure));
            }
            return Canvas.Current.TmpBitmap;
        }

        public Bitmap OnMouseUp(PointF location)
        {
            Canvas.Current.MainBitmap = Canvas.Current.Action(new EndDrawOperationParameters());
            _mouseDown = false;
            if (Canvas.Current.Figure != null && !Canvas.Current.Figures.Contains(Canvas.Current.Figure) && !(Canvas.Current.Figure.IsEmpty()))
            {
                Canvas.Current.Figures.Insert(0, Canvas.Current.Figure);
            }
            if (!(Canvas.Current.Figure is NPointsFigure) ||
                ((NPointsFigure)Canvas.Current.Figure).IsFull())
            {
                Canvas.Current.RenewFigure();
            }
            return Canvas.Current.MainBitmap;
        }
    }
}
