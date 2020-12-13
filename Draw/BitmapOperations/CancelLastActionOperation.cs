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
    public class CancelLastActionOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            if (Canvas.Current.PreviousBitmaps.Count == 0)
            {
                return Canvas.Current.MainBitmap;
            }
            Canvas.Current.MainBitmap = Canvas.Current.PreviousBitmaps.Last.Value;
            Canvas.Current.PreviousBitmaps.RemoveLast();

            if (Canvas.Current.Figures.Count != 0)
            {
                Canvas.Current.Figures.RemoveAt(Canvas.Current.Figures.Count - 1);
            }

            return Canvas.Current.MainBitmap;
        }
    }
}
