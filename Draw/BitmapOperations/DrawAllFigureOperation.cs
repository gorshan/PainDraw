using Draw.BitmapOperations.OperationParameters;
using Draw.Drawer;
using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.BitmapOperations
{
    public class DrawAllFigureOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            DeleteAllFigure();
            foreach (AbstractFigure figure in Canvas.Current.Figures)
            {
                Canvas.Current.TmpBitmap = Canvas.Current.Action(new DrawFigureOperationParameters(figure));
                Canvas.Current.MainBitmap = Canvas.Current.Action(new EndDrawOperationParameters());
            }
            return Canvas.Current.MainBitmap;
        }

        private void DeleteAllFigure()
        {
            Canvas.Current.MainBitmap = new Bitmap(Canvas.Current.MainBitmap.Width, Canvas.Current.MainBitmap.Height);
            Canvas.Current.TmpBitmap = Canvas.Current.MainBitmap;        
            Canvas.Current.Graphics = Graphics.FromImage(Canvas.Current.MainBitmap);
            Canvas.Current.Graphics.Clear(Canvas.Current.Color);
            GC.Collect();
        }
    }
}
