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
        private Stack <Bitmap> _allbitmaps;
        //public IDrawer Drawer { get; set; }
        public Pen Pen { get; set; }

        public Canvas(int width, int height)
        {
            _mainBitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_mainBitmap);
            Pen = new Pen(Color.Black, 1);
            _allbitmaps = new Stack<Bitmap>();
            _allbitmaps.Push((Bitmap)_mainBitmap.Clone());
            //Drawer = new PenDrawer();
        }

        //public void StartDraw(IFigure figure)
        //{
        //    if (figure is TriangleByPointsFigure)
        //    {
        //        Drawer = new AnglePointsDrawer();
        //    }
        //    if (figure is EllipseFigure || figure is CircleFigure)
        //    {
        //        if (!(Drawer is EllipseDrawer))
        //            Drawer = new EllipseDrawer();
        //    }else if(figure is PenFigure)
        //    {
        //        if (!(Drawer is PenDrawer))
        //            Drawer = new PenDrawer();
        //    }
        //    else if (figure is PolylineByPointsFigure)
        //    {
        //        Drawer = new PenDrawer();
        //    }
        //    else if (!(Drawer is AngleFiguresDrawer))
        //    {
        //        Drawer = new AngleFiguresDrawer();
        //    }
        //}

        public void DrawFigure(IFigure figure)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            figure.Drawer.DrawFigure(_graphics, Pen, figure.GetPoints());
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

        public void EndDraw(IFigure figure)
        {
            if (figure is PenFigure)
                ((PenFigure)figure).ClearPoints();
            if (figure is TriangleByPointsFigure)
            {
                ((TriangleByPointsFigure)figure).Clear();
            }
            //_allbitmaps.Push((Bitmap)_tmpBitmap.Clone());
            _mainBitmap = _tmpBitmap;
        }

        public void Save()
        {
            _mainBitmap = _tmpBitmap;
        }
        public void Clear()
        {
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
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
            if (_allbitmaps.Count == 0)
            {
                return _mainBitmap;
            }
            _mainBitmap = _allbitmaps.Pop();
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
