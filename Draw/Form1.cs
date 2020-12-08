﻿using Draw.Drawer;
using Draw.Fabrics;
using Draw.Figures;
using Draw.MouseHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Draw
{
    public partial class Form1 : Form
    {
        public Canvas Canvas { get; private set; }
        private IMouseHandler _mouseHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas.Create(pictureBox1.Width, pictureBox1.Height);
            Canvas.Current.NAngleNumericUpDown = Convert.ToInt32(NAngleNumericUpDown.Value);
            pictureBox1.Image = Canvas.Current.GetImage();
            _mouseHandler = new PaintMouseHandler();

            widthText.Text = WigthScrollBar.Value + "";
            ColorButton.BackColor = Canvas.Current.Pen.Color;
            SetSizeLabel();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = _mouseHandler.OnMouseDown(e.Location);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = _mouseHandler.OnMouseMove(e.Location);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)

        {
            pictureBox1.Image = _mouseHandler.OnMouseUp(e.Location);
            if (_mode == "Paint")
            {
                Bitmap bitmap = Canvas.GetImage();
                Graphics graphics = Graphics.FromImage(bitmap);
                Point[] points;
                if (_figure is CircleFigure)
                    points = ((CircleFigure)_figure).GetPointsInner(bitmap.Width, bitmap.Height);
                else
                    points = ((EllipseFigure)_figure).GetPointsInner(bitmap.Width, bitmap.Height);
                foreach (Point p in points)
                {
                    bitmap.SetPixel(p.X, p.Y, Color.Black);
                }
                pictureBox1.Image = bitmap;
            }
        }
        


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (Canvas.Current.Fabric is PolylineByPointsFabric)
            {
                Canvas.Current.RenewFigure();
            }

            pictureBox1.Image = Canvas.Current.ChangeBackgroundColor(colorDialog1.Color);

            foreach (AbstractFigure figure in Canvas.Current.Figures)
            {
                Canvas.Current.Pen.Color = figure.Color;
                Canvas.Current.Pen.Width = figure.Width;
                Canvas.Current.DrawFigure(figure);
                Canvas.Current.EndDraw();
            }
            pictureBox1.Image = Canvas.Current.GetImage();

        }

            private void RightTriangleButton_Click(object sender, EventArgs e)
            {
                _fabric = new RightTriangleFabric();
                renewFigure();
                _mode = "Paint";
                SettingsForm(sender);
            }

        private void RightTriangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new RightTriangleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new RectangleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new IsoscelesTriangleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new LineFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new SquareFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new NAngleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }



        private void EllipsButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new EllipseFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new CircleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }


        private void PenButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new PenFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void TriangleByPoints_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new TriangleByPointsFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new NAngleByPointsFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }


        private void PolyLine_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new PolylineByPointsFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void workWithFigureButton_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is MoveFigureMouseHandler))
            {
                _mouseHandler = new MoveFigureMouseHandler();
            }
            SettingsForm(sender);
        }

        private void pipette_button_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is PipetteMouseHandler))
            {
                _mouseHandler = new PipetteMouseHandler(ColorButton);
            }
            SettingsForm(sender);
        }

        private void MoveFace_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is MoveFaceMouseHandler))
            {
                _mouseHandler = new MoveFaceMouseHandler();
            }
            SettingsForm(sender);
        }
        private void DeleteFigureButton_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is DeleteFigureMouseHandler))
            {
                _mouseHandler = new DeleteFigureMouseHandler();
            }
            SettingsForm(sender);
        }

        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Canvas.Current.NAngleNumericUpDown = Convert.ToInt32(NAngleNumericUpDown.Value);
        }
        private void FillFigureButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Figure.FillFigure();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Clear();
            pictureBox1.Image = Canvas.Current.GetImage();
        }

        private void WigthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.Current.ChangeWidth(WigthScrollBar.Value);
            widthText.Text = WigthScrollBar.Value + "";
        }
        private void CancelLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.Current.CancelLastAction();

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.SaveBitmap();
        }

            private void ClearButton_Click(object sender, EventArgs e)
            {
                Canvas.Current.ChangeColor(colorDialog1.Color);
            }

            private void WigthScrollBar_Scroll(object sender, ScrollEventArgs e)
            {
                Canvas.Pen.Width = WigthScrollBar.Value;
                _figure.Width = WigthScrollBar.Value;
                widthText.Text = WigthScrollBar.Value + "";
            }
            private void CancelLast_Click(object sender, EventArgs e)
            {
                pictureBox1.Image = Canvas.CancelLastAction();
                if (_figures.Count != 0)
                {
                    _figures.RemoveAt(_figures.Count - 1);
                }
            }
            private void saveButton_Click(object sender, EventArgs e)
            {
                Canvas.SaveBitmap();
            }

            private void colorButton_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    _figure.Color = colorDialog1.Color;
                    Canvas.Pen.Color = colorDialog1.Color;
                }
                ColorButton.BackColor = colorDialog1.Color;

        private void SettingsForm(object sender)
        {
            if (sender == NAngleButton || sender == RightNAngleButton)
            {
                SizeLabel.Text = $"{pictureBox1.Width} x {pictureBox1.Width}";
            }

            private void SettingsForm(object sender)
            {
                if (sender == NAngleButton || sender == RightNAngleButton)
                {
                    NAngleNumericUpDown.Visible = true;
                }
                else
                {
                    NAngleNumericUpDown.Visible = false;
                }
            }
        }
        private void Form1_ChangeSize(object sender, EventArgs e)
        {
            if (Canvas.Current == null || pictureBox1.Width <= 0 || pictureBox1.Height <= 0)
            {
                if (Canvas == null || pictureBox1.Width <= 0 || pictureBox1.Height <= 0)
                {
                    return;
                }
                Canvas.Resize(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = Canvas.GetImage();
                SetSizeLabel();
            }
            Canvas.Current.Resize(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Canvas.Current.GetImage();
            SetSizeLabel();
        }
        private void SetSizeLabel()
        {
            SizeLabel.Text = $"{pictureBox1.Width} x {pictureBox1.Width}";
        }
    }

  
