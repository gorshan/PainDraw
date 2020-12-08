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
    public class ResizeBitmapAction : IBitmapAction
    {
        public void Action(IOperationParameters operationParameters)
        {
            Bitmap tmp = Canvas.Current.MainBitmap;
            Canvas.Current.MainBitmap = new Bitmap(((NewSizeOperationParameter)operationParameters).Width + 500,
                ((NewSizeOperationParameter)operationParameters).Height + 500);
            Graphics.FromImage(Canvas.Current.MainBitmap).DrawImage(tmp, new Point(0, 0));
            Canvas.Current.TmpBitmap = Canvas.Current.MainBitmap;
            GC.Collect();
        }
    }
}
