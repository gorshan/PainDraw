using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Canvases
{
    public class Canvas
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Stack<Bitmap> _allbitmaps = new Stack<Bitmap>();
        private Graphics _graphics;
        public IDrawer Drawer { get; set; }
        public Pen Pen { get; set; }

        public Canvas(int width, int height)
        {
            _mainBitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _allbitmaps.Push((Bitmap)_mainBitmap.Clone());
            Pen = new Pen(Color.Black, 1);
            Drawer = new PenDrawer();
        }

        public void StartDraw(IFigure figure)
        {
            if (figure is TriangleByPointsFigure || figure is NAngleByPointsFigure)
            {
                if (figure is TriangleByPointsFigure)
                    Drawer = new AnglePointsDrawer(((TriangleByPointsFigure)figure).N);
                else
                    Drawer = new AnglePointsDrawer(((NAngleByPointsFigure)figure).N);
            }
            else if (figure is EllipseFigure || figure is CircleFigure)
            {
                if (!(Drawer is EllipseDrawer))
                    Drawer = new EllipseDrawer();
            }else if(figure is PenFigure || figure is PolylineByPointsFigure)
            {
                if (!(Drawer is PenDrawer))
                    Drawer = new PenDrawer();
            }
            else if (!(Drawer is AngleFiguresDrawer))
            {
                Drawer = new AngleFiguresDrawer();
            }
        }

        public void DrawFigure(Point[] figurePoints)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            Drawer.DrawFigure(_graphics,Pen,figurePoints);
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
            _mainBitmap = _tmpBitmap;
            _allbitmaps.Push((Bitmap)_mainBitmap.Clone());
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
            Debug.WriteLine(_allbitmaps.Count);
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
