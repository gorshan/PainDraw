using Draw.BitmapOperations.OperationParameters;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.BitmapOperations
{
    public class DrawFigureOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            Canvas.Current.TmpBitmap = (Bitmap)Canvas.Current.MainBitmap.Clone();
            Canvas.Current.Graphics = Graphics.FromImage(Canvas.Current.TmpBitmap);
            ((DrawFigureOperationParameters)operationParameters).Figure.Drawer.DrawFigure(Canvas.Current.Graphics, new Pen(((DrawFigureOperationParameters)operationParameters).Figure.Color, ((DrawFigureOperationParameters)operationParameters).Figure.Width), ((DrawFigureOperationParameters)operationParameters).Figure.GetPoints());
            GC.Collect();
            return Canvas.Current.TmpBitmap;
        }
    }
}
