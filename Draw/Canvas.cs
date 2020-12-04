using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw.Canvases
{
    public class Canvas
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        private Stack<Bitmap> _previousBitmaps;
        public Pen Pen { get; set; }

        public static Canvas Cur { get { return _obj; } }
        private static Canvas _obj;

        public static void Create(int width, int height)
        {
            _obj = new Canvas(width, height);
        }

        public Canvas(int width, int height)
        {
            _mainBitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_mainBitmap);
            Pen = new Pen(Color.Black, 1);
            _previousBitmaps = new Stack<Bitmap>();
            _previousBitmaps.Push(_mainBitmap);
           
            //Drawer = new PenDrawer();
        }


        public void DrawFigure(AbstractFigure figure)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            figure.Drawer.DrawFigure(_graphics, new Pen(figure.Color, figure.Width), figure.GetPoints());
            GC.Collect();
        }

        public Bitmap GetTmpImage()
        {
            return _tmpBitmap;
        }

        public Bitmap GetImage()
        {
            return _mainBitmap;
        }

        public void EndDraw()
        {            
            _previousBitmaps.Push(_mainBitmap);
            _mainBitmap = _tmpBitmap;
        }

        public void Clear()
        {
            _mainBitmap = new Bitmap(_mainBitmap.Width, _mainBitmap.Height);
        }

        public void Resize(int width, int height)
        {
            Bitmap tmp = _mainBitmap;
            _mainBitmap = new Bitmap(width,height);
            Graphics.FromImage(_mainBitmap).DrawImage(tmp,new Point(0,0));
            tmp.Dispose();
        }

        public Bitmap CancelLastAction()
        {
            if (_previousBitmaps.Count == 0)
            {
                return _mainBitmap;
            }
            _mainBitmap = _previousBitmaps.Pop();
            return _mainBitmap;
        }

        public void SaveBitmap()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp|GIF|*.gif";
            saveFileDialog.FileName = "figure";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _mainBitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}
