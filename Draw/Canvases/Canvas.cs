using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.Canvases
{
    public class Canvas
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        public IDrawer Drawer { get; set; }
        public Pen Pen { get; set; }

        public Canvas(int width, int height)
        {
            _mainBitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_mainBitmap);
            Pen = new Pen(Color.Black, 1);
            Drawer = new PenDrawer();
        }

        public void StartDraw(IFigure figure)
        {
            if (figure is TriangleByPointsFigure)
            {
                Drawer = new AnglePointsDrawer(((TriangleByPointsFigure)figure).N);
            }
           else if (figure is NAngleByPointsFigure)
            {
                Drawer = new AnglePointsDrawer(((NAngleByPointsFigure)figure).N);
            }            
            else if (figure is EllipseFigure || figure is CircleFigure)
            {
                if (!(Drawer is EllipseDrawer))
                    Drawer = new EllipseDrawer();
            }else if(figure is PenFigure)
            {
                if (!(Drawer is PenDrawer))
                    Drawer = new PenDrawer();
            }
            else if (figure is PolylineByPointsFigure)
            {
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
            //if (figure is TriangleByPointsFigure)
            //{
            //    ((TriangleByPointsFigure)figure).Clear();
            //}
            //if (figure is PolylineByPointsFigure)
            //{
            //    ((PolylineByPointsFigure)figure).Clear();
            //}
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
    }
}
