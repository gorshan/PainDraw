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
    public class EndDrawOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            if (Canvas.Current.PreviousBitmaps.Count >= 5)
            {
                Canvas.Current.PreviousBitmaps.RemoveFirst();
            }
            Canvas.Current.PreviousBitmaps.AddLast(Canvas.Current.MainBitmap);
            Canvas.Current.MainBitmap = Canvas.Current.TmpBitmap;
            return Canvas.Current.MainBitmap;
        }
    }
}
