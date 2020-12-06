using Draw.Canvases;
using Draw.Fabrics;
using Draw.Figures;
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

        private Point _lastPoint;
        private bool _mouseDown;

        private IFabric _fabric;
        private AbstractFigure _figure;
        private List<AbstractFigure> _figures;

        private string _mode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Canvas.GetImage();

            _lastPoint = new Point(0, 0);
            _mouseDown = false;

            _fabric = new PenFabric();
            _mode = "Paint";
            _figures = new List<AbstractFigure>();
            renewFigure();

            widthText.Text = WigthScrollBar.Value + "";
            ColorButton.BackColor = Canvas.Pen.Color;
            SetSizeLabel();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastPoint = e.Location;
            switch (_mode)
            {
                case "Paint":
                    if (_figure is NPointsFigure)
                    {
                        pictureBox1_MouseMove(sender, e);
                        _mouseDown = false;
                    }
                    break;
                case "Figure":
                    _figure = null;
                    foreach (AbstractFigure figure in _figures)
                    {
                        if (figure.IsThisFigure(e.Location))
                        {
                            _figure = figure;
                            _figures.Remove(_figure);
                            DrawAll();
                            break;
                        }
                    }
                    break;
                case "Rotate":
                    _figure = null;
                    foreach (AbstractFigure figure in _figures)
                    {
                        if (figure.IsThisFigure(e.Location))
                        {
                            _figure = figure;
                            _figures.Remove(_figure);
                            DrawAll();
                            break;
                        }
                    }
                    break;
                case "Pipette":
                    Color pixelColor = Canvas.Pen.Color;
                    pixelColor = Canvas.GetImage().GetPixel(e.X, e.Y);
                    ColorButton.BackColor = pixelColor;
                    Canvas.Pen.Color = pixelColor;
                    _figure.Color = pixelColor;
                    _mode = "Paint";
                    _mouseDown = false;
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                switch (_mode)
                {
                    case "Paint":
                        UpdateFigure(e.Location);

                        break;
                    case "Figure":
                        MoveFigure(e.Location);

                        break;
                    case "Rotate":
                        RotateFigure(e.Location);
                        break;
                }

                pictureBox1.Image = Canvas.GetTmpImage();
            }
        }



        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)

        {
            Canvas.EndDraw();

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

            _mouseDown = false;
            if (_figure != null && !_figures.Contains(_figure))
            {
                _figures.Add(_figure);
            }
            if (!(_figure is NPointsFigure) ||
                ((NPointsFigure)_figure).IsFull())
            {
                renewFigure();
            }
        }



        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (_fabric is PolylineByPointsFabric)
            {
                renewFigure();
            }

        }


        private void RightTriangleButton_Click(object sender, EventArgs e)
        {
            _fabric = new RightTriangleFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            _fabric = new RectangleFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            _fabric = new IsoscelesTriangleFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            _fabric = new LineFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            _fabric = new SquareFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            _fabric = new NAngleFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }



        private void EllipsButton_Click(object sender, EventArgs e)
        {
            _fabric = new EllipseFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            _fabric = new CircleFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }


        private void PenButton_Click(object sender, EventArgs e)
        {
            _fabric = new PenFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void TriangleByPoints_Click(object sender, EventArgs e)
        {
            _fabric = new TriangleByPointsFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
            _fabric = new NAngleByPointsFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }


        private void PolyLine_Click(object sender, EventArgs e)
        {
            _fabric = new PolylineByPointsFabric();
            renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void workWithFigureButton_Click(object sender, EventArgs e)
        {
            _mode = "Figure";
        }
        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renewFigure();
            _mode = "Paint";
        }

        private void pipette_button_Click(object sender, EventArgs e)
        {
            _mode = "Pipette";
            SettingsForm(sender);
        }

        private void renewFigure()
        {
            _figure = _fabric.CreateFigure();
            _figure.Color = Canvas.Pen.Color;
            _figure.Width = (int)Canvas.Pen.Width;

            if (_fabric is NAngleByPointsFabric)
            {
                ((NPointsFigure)_figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
            if (_figure is NAngleFigure)
            {
                ((NAngleFigure)_figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Canvas.Clear();
            _figure.Clear();
            _figures.Clear();
            pictureBox1.Image = Canvas.GetImage();
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

        }


        private void UpdateFigure(Point endPoint)
        {
            _figure.Update(_lastPoint, endPoint);
            Canvas.DrawFigure(_figure);
        }

        private void MoveFigure(Point endPoint)
        {
            if (_figure != null)
            {
                Point d = new Point(endPoint.X - _lastPoint.X, endPoint.Y - _lastPoint.Y);
                _lastPoint = endPoint;
                _figure.Move(d);
                Canvas.DrawFigure(_figure);
            }
        }

        private void RotateFigure(Point endPoint)
        {
            double a = Math.Sqrt(_lastPoint.X * _lastPoint.X + _lastPoint.Y * _lastPoint.Y);
            double b = Math.Sqrt(endPoint.X * endPoint.X + endPoint.Y * endPoint.Y);
            double c = Math.Sqrt(Math.Pow(endPoint.X - _lastPoint.X, 2) + Math.Pow(endPoint.Y - _lastPoint.Y, 2));
            if (_figure != null)
            {
                double phi = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
                _lastPoint = endPoint;
                _figure.Rotate(phi);
                Canvas.DrawFigure(_figure);
            }
        }

        private void DrawAll()
        {
            Canvas.Clear();
            foreach (AbstractFigure figure in _figures)
            {
                Canvas.Pen.Color = figure.Color;
                Canvas.Pen.Width = figure.Width;
                Canvas.DrawFigure(figure);
                Canvas.EndDraw();
            }

        }


        private void SetSizeLabel()
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
        private void Form1_ChangeSize(object sender, EventArgs e)
        {
            if (Canvas == null || pictureBox1.Width <= 0 || pictureBox1.Height <= 0)
            {
                return;
            }
            Canvas.Resize(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Canvas.GetImage();
            SetSizeLabel();
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            _mode = "Rotate";
        }
    }
}

  
