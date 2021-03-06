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
    public class DeleteFigureMouseHandler : IMouseHandler
    {
        private bool _mouseDown;

        public Bitmap OnMouseDown(PointF location)
        {
            _mouseDown = true;
            return Canvas.Current.MainBitmap;
        }

        public Bitmap OnMouseMove(PointF location)
        {
            if (_mouseDown)
            {
                foreach (AbstractFigure figure in Canvas.Current.Figures)
                {
                    if (figure.IsThisFigure(location))
                    {
                        Canvas.Current.Figures.Remove(figure);
                        Canvas.Current.MainBitmap = Canvas.Current.Action(new DrawAllFigureOperationParameters());
                        break;
                    }
                }
                if(Canvas.Current.Figures.Count == 0)
                {
                    Canvas.Current.MainBitmap = Canvas.Current.Action(new DrawAllFigureOperationParameters());
                    _mouseDown = false;
                }
            }
            return Canvas.Current.MainBitmap;
        }

        public Bitmap OnMouseUp(PointF location)
        {
            _mouseDown = false;
            return Canvas.Current.MainBitmap;
        }
    }
}
