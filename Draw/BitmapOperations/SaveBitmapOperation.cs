using Draw.BitmapOperations.OperationParameters;
using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw.BitmapOperations
{
    public class SaveBitmapOperation : IBitmapOperation
    {
        public Bitmap Action(IOperationParameters operationParameters)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp|GIF|*.gif";
            saveFileDialog.FileName = "figure";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Canvas.Current.MainBitmap.Save(saveFileDialog.FileName);
            }
            return Canvas.Current.MainBitmap;
        }
    }
}
