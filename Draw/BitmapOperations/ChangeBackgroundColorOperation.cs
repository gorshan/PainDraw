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
    public class ChangeBackgroundColorOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            Canvas.Current.Graphics = Graphics.FromImage(Canvas.Current.MainBitmap);
            Canvas.Current.Graphics.Clear(((ChangeBackgroundColorOperationParameters)operationParameters).ColorBackground);
            return Canvas.Current.MainBitmap;
        }
    }
}
