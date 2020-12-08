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
    public class ResizeBitmapOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            Bitmap tmp = Canvas.Current.MainBitmap;
            Canvas.Current.MainBitmap = new Bitmap(((SizeOperationParameter)operationParameters).Width + 500,
                ((SizeOperationParameter)operationParameters).Height + 500);
            Graphics.FromImage(Canvas.Current.MainBitmap).DrawImage(tmp, new Point(0, 0));
            Canvas.Current.TmpBitmap = Canvas.Current.MainBitmap;
            GC.Collect();
            return Canvas.Current.MainBitmap;
        }
    }
}
