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
    public class ClearBitmapOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            CreateMainBitmap();
            Canvas.Current.Figure.Clear();
            Canvas.Current.Figures.Clear();
            return Canvas.Current.MainBitmap;
        }

        private void CreateMainBitmap()
        {
            Canvas.Current.MainBitmap = new Bitmap(Canvas.Current.MainBitmap.Width, Canvas.Current.MainBitmap.Height);
            Canvas.Current.TmpBitmap = Canvas.Current.MainBitmap;
            Canvas.Current.Color = Color.Transparent;
            GC.Collect();
        }
    }
}
