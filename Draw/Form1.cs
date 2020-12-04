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
        private Point _lastPoint;
        private bool _mouseDown;
        private bool _pipetteClick=false;
        IFabric fabric;

        public Canvas Canvas { get; private set; }
        public AbstractFigure Figure { get; private set; }

        List<AbstractFigure> figures;
        string mode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            fabric = new PenFabric();
            mode = "Paint";
            pictureBox1.Image = Canvas.GetImage();
            _lastPoint = new Point(0, 0);
            _mouseDown = false;
            widthText.Text = WigthScrollBar.Value + "";
            ColorButton.BackColor = Canvas.Pen.Color;
            SetSizeLabel();
            figures = new List<AbstractFigure>();
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                switch (mode)
                {
                    case "Paint":
                        Figure.Update(_lastPoint, e.Location);
                        Canvas.DrawFigure(Figure);
                        pictureBox1.Image = Canvas.GetTmpImage();
                        break;
                    case "Figure":
                        if (Figure != null)
                        {
                            Point d = new Point(e.X - _lastPoint.X, e.Y - _lastPoint.Y);
                            _lastPoint = e.Location;
                            Figure.Move(d);
                            //DrawAll();
                            Canvas.DrawFigure(Figure);
                            
                            pictureBox1.Image = Canvas.GetTmpImage();
                            
                        }
                        break;
                }
                
                
            }
            if (_pipetteClick)
            {
                //_lastPoint2 = e.Location;
                Bitmap _tmpbitmap = Canvas.GetImage();
                Color pixelColor = Canvas.Pen.Color;
                pixelColor = _tmpbitmap.GetPixel(e.X, e.Y);
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {            
            _mouseDown = true;
            _lastPoint = e.Location;
            bool isNeededNewFigure = true;
            switch (mode)
            {
                case "Paint":
                    if (fabric is PolylineByPointsFabric)
                    {
                        isNeededNewFigure = false;
                        Figure.Update(_lastPoint, e.Location);
                        Canvas.DrawFigure(Figure);
                        pictureBox1.Image = Canvas.GetTmpImage();
                        _mouseDown = false;

                    }
                    if (fabric is NAngleByPointsFabric || fabric is TriangleByPointsFabric)
                    {
                        isNeededNewFigure = false;
                        if (((NAngleByPointsFigure)Figure).IsFull())
                        {
                            renewFigure();
                        }
                        Figure.Update(_lastPoint, e.Location);
                        Canvas.DrawFigure(Figure);
                        pictureBox1.Image = Canvas.GetTmpImage();
                        _mouseDown = false;
                    }
                    if (isNeededNewFigure)
                    {
                        renewFigure();
                    }
                    break;
                case "Figure":
                    Figure = null;
                    foreach (AbstractFigure figure in figures)
                    {
                        if (figure.IsThisFigure(e.Location))
                        {
                            Figure = figure;
                            figures.Remove(Figure);
                    DrawAll();
                            break;
                        }
                    }
                    break;
            }
        }

        private void renewFigure()
        {
            Figure = fabric.CreateFigure();
            Figure.Color = Canvas.Pen.Color;
            Figure.Width = (int)Canvas.Pen.Width;

            if (Figure is NAngleByPointsFigure)
            {
                ((NAngleByPointsFigure)Figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
            if (Figure is NAngleFigure)
            {
                ((NAngleFigure)Figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {           
            Canvas.EndDraw();
            _mouseDown = false;
            if (Figure != null && !figures.Contains(Figure))
            {
                figures.Add(Figure);
            }
           // DrawAll();
            //pictureBox1.Image = Canvas.GetImage();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_pipetteClick)
            {
                Bitmap _tmpbitmap = Canvas.GetImage();
                Color pixelColor = Canvas.Pen.Color;
                pixelColor = _tmpbitmap.GetPixel(e.X, e.Y);
                ColorButton.BackColor = pixelColor;
                Canvas.Pen.Color = pixelColor;
            }
            _pipetteClick = false;
        }

        private void RightTriangleButton_Click(object sender, EventArgs e)
        {
            fabric = new RightTriangleFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            fabric = new RectangleFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            fabric = new IsoscelesTriangleFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            fabric = new LineFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            fabric = new SquareFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            fabric = new NAngleFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            renewFigure();
            mode = "Paint";
        }

        private void EllipsButton_Click(object sender, EventArgs e)
        {
            fabric = new EllipseFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            fabric = new CircleFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Canvas.Clear();
            Figure.Clear();
            pictureBox1.Image = Canvas.GetImage();
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            fabric = new PenFabric();
            mode = "Paint";
            SettingsForm(sender);
        }

        private void WigthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.Pen.Width = WigthScrollBar.Value;
            widthText.Text = WigthScrollBar.Value + "";
        }


        
        

        private void TriangleByPoints_Click(object sender, EventArgs e)
        {
            fabric = new TriangleByPointsFabric();
            renewFigure();
            SettingsForm(sender);
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
            fabric = new NAngleByPointsFabric();
            renewFigure();
            SettingsForm(sender);
        }
        

        private void PolyLine_Click(object sender, EventArgs e)
        {
            fabric = new PolylineByPointsFabric();
            renewFigure();
            SettingsForm(sender);
        }

        private void workWithFigureButton_Click(object sender, EventArgs e)
        {
            mode = "Figure";
        }
        private void CancelLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.CancelLastAction();
            if (figures.Count != 0)
            {
                figures.RemoveAt(figures.Count - 1);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Canvas.SaveBitmap();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                //button1.BackColor = colorDialog1.Color;
                Canvas.Pen.Color = colorDialog1.Color;
            ColorButton.BackColor = colorDialog1.Color;

        }

        private void pipette_button_Click(object sender, EventArgs e)
        {
            _pipetteClick = true;
            SettingsForm(sender);
        }

        private void DrawAll()
        {
            Canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            foreach (AbstractFigure figure in figures)
            {
                Canvas.Pen.Color = figure.Color;
                Canvas.Pen.Width = figure.Width;
                Canvas.DrawFigure(figure);
                Canvas.Save();
            }

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (Figure is PolylineByPointsFigure)
            {
                ((PolylineByPointsFigure)Figure).Clear();
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
    }
}
