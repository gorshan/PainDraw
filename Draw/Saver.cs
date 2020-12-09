using Draw.Drawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public class Saver
    {
        public static void SaveImage(Bitmap bitmap)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp|GIF|*.gif";
            saveFileDialog.FileName = "figure";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }

        public static void SaveProject(Canvas canvas)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PainDraw|*.pd";
            saveFileDialog.FileName = "figure";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.
                bitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}
