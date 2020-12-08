﻿using Draw.BitmapOperations;
using Draw.BitmapOperations.OperationParameters;
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
        public Bitmap MainBitmap { get; set; }
        public Bitmap TmpBitmap { get; set; }
        private Graphics _graphics;
        private LinkedList<Bitmap> _previousBitmaps;
        public Pen Pen { get; set; }
        public Color Color { get; set; }

        public IFabric Fabric { get; set; }
        public AbstractFigure Figure { get; set; }
        public List<AbstractFigure> Figures { get; set; }
        public Point LastPoint { get; set; }

        private OperationCreator _operations;

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

        public Canvas(int width, int height, OperationCreator operations)
        {
            MainBitmap = new Bitmap(width + 500, height+ 500);
            _graphics = Graphics.FromImage(MainBitmap);
            Pen = new Pen(Color.Black, 1);
            _previousBitmaps = new LinkedList<Bitmap>();
            _previousBitmaps.AddLast(MainBitmap);
            LastPoint = new Point(0, 0);
            _operations = operations;
            Fabric = new PenFabric();
            Figures = new List<AbstractFigure>();
            RenewFigure();
         
        }
        public static void Create(int width, int height, OperationCreator operation)
        {
            _obj = new Canvas(width, height, operation);
        }


        public Bitmap Action(IOperationParameters parameters)
        {
            return _operations.GetOperation(parameters.GetType()).Action(parameters);             
        }

        public void DrawFigure(AbstractFigure figure)
        {
            TmpBitmap = (Bitmap)MainBitmap.Clone();
            _graphics = Graphics.FromImage(TmpBitmap);
            figure.Drawer.DrawFigure(_graphics, new Pen(figure.Color, figure.Width), figure.GetPoints());
            GC.Collect();
        }

        public void EndDraw()
        {
            if (_previousBitmaps.Count >= 5)
            {
                _previousBitmaps.RemoveFirst();
            }
            _previousBitmaps.AddLast(MainBitmap);
            MainBitmap = TmpBitmap;
        }

        public void Clear()
        {
            CreateMainBitmap();
            Figure.Clear();
            Figures.Clear();
        }

        private void CreateMainBitmap()
        {
            MainBitmap = new Bitmap(MainBitmap.Width, MainBitmap.Height);
            TmpBitmap = MainBitmap;
            GC.Collect();
        }

        public Bitmap CancelLastAction()
        {
            if (_previousBitmaps.Count == 0)
            {
                return MainBitmap;
            }
            MainBitmap = _previousBitmaps.Last.Value;
            _previousBitmaps.RemoveLast();

            if (Figures.Count != 0)
            {
                Figures.RemoveAt(Figures.Count - 1);
            }

            return MainBitmap;
        }

        public void SaveBitmap()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp|GIF|*.gif";
            saveFileDialog.FileName = "figure";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainBitmap.Save(saveFileDialog.FileName);
            }
        }

        public Bitmap ChangeBackgroundColor(Color color)
        {
            _graphics = Graphics.FromImage(MainBitmap);
            _graphics.Clear(color);
            Color = color;
            return MainBitmap;
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
