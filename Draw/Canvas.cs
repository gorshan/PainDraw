using Draw.Fabrics;
using Draw.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw.Drawer
{
    public class Canvas
    {
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        private LinkedList<Bitmap> _previousBitmaps;
        public Pen Pen { get; set; }
        public Color Color { get; set; }

        public IFabric Fabric { get; set; }
        public AbstractFigure Figure { get; set; }
        public List<AbstractFigure> Figures { get; set; }
        public PointF LastPoint { get; set; }

        public static Canvas Current
        {
            get { return _obj; }
            private set { }
        }


        private int _NNumericUpDown;
        public int NAngleNumericUpDown
        {
            get { return _NNumericUpDown; }
            set
            {
                _NNumericUpDown = value;
                RenewFigure();
            }
        }

        private static Canvas _obj;

        public static void Create(int width, int height)
        {
            _obj = new Canvas(width, height);
        }
        public Canvas(int width, int height)
        {
            _mainBitmap = new Bitmap(width + 500, height+ 500);
            _graphics = Graphics.FromImage(_mainBitmap);
            Pen = new Pen(Color.Black, 1);
            _previousBitmaps = new LinkedList<Bitmap>();
            _previousBitmaps.AddLast(_mainBitmap);
            LastPoint = new PointF(0, 0);

            Fabric = new PenFabric();
            Figures = new List<AbstractFigure>();
            RenewFigure();
         
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
            if (_previousBitmaps.Count >= 5)
            {
                _previousBitmaps.RemoveFirst();
            }
            _previousBitmaps.AddLast(_mainBitmap);
            _mainBitmap = _tmpBitmap;
        }

        public void Clear()
        {
            CreateMainBitmap();
            Figure.Clear();
            Figures.Clear();
        }

        private void CreateMainBitmap()
        {
            _mainBitmap = new Bitmap(_mainBitmap.Width, _mainBitmap.Height);
            _tmpBitmap = _mainBitmap;
            GC.Collect();
        }

        public void Resize(int width, int height)
        {
            Bitmap tmp = _mainBitmap;
            _mainBitmap = new Bitmap(width + 500, height+500);
            Graphics.FromImage(_mainBitmap).DrawImage(tmp, new PointF(0, 0));
            _tmpBitmap = _mainBitmap;
            GC.Collect();
        }

        public Bitmap CancelLastAction()
        {
            if (_previousBitmaps.Count == 0)
            {
                _tmpBitmap = _mainBitmap;
                return _mainBitmap;
            }
            _mainBitmap = _previousBitmaps.Last.Value;
            _tmpBitmap = _mainBitmap;
            _previousBitmaps.RemoveLast();

            if (Figures.Count != 0)
            {
                Figures.RemoveAt(Figures.Count - 1);
            }

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

        public Bitmap ChangeBackgroundColor(Color color)
        {
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(color);
            Color = color;
            return _mainBitmap;
        }

        public void DeleteAllFigures()
        {
            CreateMainBitmap();
            ChangeBackgroundColor(Color);
        }

        public void RenewFigure()
        {
            bool isFilled = false;
            if (Figure != null)
            {
                isFilled = Figure.IsFilled;
            }
            Figure = Fabric.CreateFigure();
            Figure.Color = Pen.Color;
            Figure.Width = (int)Pen.Width;
            Figure.FillFigure(isFilled);

            if (Fabric is NAngleByPointsFabric)
            {
                ((NPointsFigure)Figure).N = NAngleNumericUpDown;
            }
            if (Figure is NAngleFigure)
            {
                ((NAngleFigure)Figure).N = NAngleNumericUpDown;
            }
        }

        public void ChangeFabric(IFabric fabric)
        {
            Fabric = fabric;
            RenewFigure();
        }

        public void ChangeWidth(int width)
        {
            Pen.Width = width;
            Figure.Width = width;
        }

        public void ChangeColor(Color color)
        {
            Figure.Color = color;
            Pen.Color = color;
        }
        public void DrawAll()
        {
            DeleteAllFigures();
            foreach (AbstractFigure figure in Figures)
            {
                DrawFigure(figure);
                EndDraw();
            }
        }
    }
}
