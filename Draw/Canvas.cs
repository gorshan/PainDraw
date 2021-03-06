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
        public Graphics Graphics { get; set; }
        public LinkedList<Bitmap> PreviousBitmaps { get; set; }
        public Pen Pen { get; set; }
        public Color Color { get; set; }
        public IFabric Fabric { get; set; }
        public AbstractFigure Figure { get; set; }
        public List<AbstractFigure> Figures { get; set; }
        public PointF LastPoint { get; set; }

        private OperationCreator _operations;

        public static Canvas Current
        {
            get { return _obj; }
            set { _obj = value; }
        }


        private int _NAngle;
        public int NAngle
        {
            get { return _NAngle; }
            set
            {
                _NAngle = value;
                RenewFigure();
            }

        }

        private static Canvas _obj;

        public Canvas(int width, int height, OperationCreator operations)
        {
            MainBitmap = new Bitmap(width + 500, height+ 500);
            Graphics = Graphics.FromImage(MainBitmap);
            Pen = new Pen(Color.Black, 1);
            PreviousBitmaps = new LinkedList<Bitmap>();
            PreviousBitmaps.AddLast(MainBitmap);
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

        public void RenewFigure()
        {
            bool isFilled = false;
            if (Figure != null)
            {
                isFilled = Figure.IsFilled;
            }
            Figure = Fabric.CreateFigure();
            Figure.Color = Pen.Color;
            Figure.ColorBackgroundFigure = Pen.Color;
            Figure.Width = (int)Pen.Width;
            Figure.FillFigure(isFilled);

            if (Fabric is NAngleByPointsFabric)
            {
                ((NPointsFigure)Figure).N = NAngle;
            }
            if (Fabric is NAngleFabric)
            {
                ((RightNAngleFigure)Figure).N = NAngle;
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
    }
}
