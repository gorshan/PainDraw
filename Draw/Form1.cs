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
        private Point _lastPoint2;
        private bool _mouseDown;
        private bool _pipetteClick=false;
        IFabric fabric;

        public Canvas Canvas { get; private set; }
        public IFigure Figure { get; private set; }

        List<IFigure> figures;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            fabric = new PenFabric();

            pictureBox1.Image = Canvas.GetImage();
            _lastPoint = new Point(0, 0);
            _mouseDown = false;
            widthText.Text = WigthScrollBar.Value + "";
            figures = new List<IFigure>();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Figure.Update(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            if (_pipetteClick)
            {
                _lastPoint2 = e.Location;
                Bitmap _tmpbitmap = Canvas.GetImage();
                Color pixelColor = Canvas.Pen.Color;
                pixelColor = _tmpbitmap.GetPixel(e.X, e.Y);
                colorLabel2.BackColor = pixelColor;
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {            
            _mouseDown = true;
            _lastPoint = e.Location;
            bool isNeededNewFigure = true;            
            
            if (Figure is PolylineByPointsFigure)
            {
                Figure.Update(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            if (fabric is TriangleByPointsFabric)
            {
                if (!((TriangleByPointsFigure)Figure).IsFool())
                {
                    isNeededNewFigure = false;
                }
                Figure.Update(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);       
                pictureBox1.Image = Canvas.GetTmpImage();
                _mouseDown = false;
            }
            if (fabric is NAngleByPointsFabric)
            {
                if (!((NAngleByPointsFigure)Figure).IsFool())
                {
                    isNeededNewFigure = false;
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
        }

        private void renewFigure()
        {
            Figure = fabric.CreateFigure();
            Figure.Color = Canvas.Pen.Color;
            Figure.Width = (int)Canvas.Pen.Width;

            if (Figure is NAngleByPointsFigure)
            {
                ((NAngleByPointsFigure)Figure).N = Convert.ToInt32(NAngleByPointsNumericUpDown.Value);
            }
            if (Figure is NAngleFigure)
            {
                ((NAngleFigure)Figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {           
            Canvas.EndDraw(Figure);
            _mouseDown = false;
            figures.Add(Figure);

        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_pipetteClick)
            {
                Bitmap _tmpbitmap = Canvas.GetImage();
                Color pixelColor = Canvas.Pen.Color;
                pixelColor = _tmpbitmap.GetPixel(e.X, e.Y);
                colorLabel2.BackColor = pixelColor;
                colorLabel.BackColor = pixelColor;
                Canvas.Pen.Color = pixelColor;
            }
            _pipetteClick = false;
        }
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Figure is PolylineByPointsFigure)
            {
                ((PolylineByPointsFigure)Figure).Clear();
            }
        }

        private void RightTriangleButton_Click(object sender, EventArgs e)
        {
            fabric = new RightTriangleFabric();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            fabric = new RectangleFabric();
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            fabric = new IsoscelesTriangleFabric();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            fabric = new LineFabric();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            fabric = new SquareFabric();
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            fabric = new NAngleFabric();
        }

        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (fabric is NAngleFabric)
            {
                ((NAngleFigure)Figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
        }

        private void EllipsButton_Click(object sender, EventArgs e)
        {
            fabric = new EllipseFabric();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            fabric = new CircleFabric();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Canvas.Clear();
            pictureBox1.Image = Canvas.GetImage();
            if(Figure is PolylineByPointsFigure)
            {
                ((PolylineByPointsFigure)Figure).Clear();
            }
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            fabric = new PenFabric();
        }

        private void WigthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.Pen.Width = WigthScrollBar.Value;
            widthText.Text = WigthScrollBar.Value + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            //button1.BackColor = colorDialog1.Color;
            Canvas.Pen.Color = colorDialog1.Color;
            colorLabel.BackColor = colorDialog1.Color;
        }

        private void pipette_button_Click(object sender, EventArgs e)
        {
            _pipetteClick = true;
        }

        private void Form1_ChangeSize(object sender, EventArgs e)
        {
           if (Canvas == null)
            {
                return;
            }
            Canvas.Resize(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Canvas.GetImage();
        }

        private void TriangleByPoints_Click(object sender, EventArgs e)
        {
            fabric = new TriangleByPointsFabric();
            Figure = fabric.CreateFigure();
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
            fabric = new NAngleByPointsFabric();
            Figure = fabric.CreateFigure();
        }

        private void NAngleByPointsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PolyLine_Click(object sender, EventArgs e)
        {
            fabric = new PolylineByPointsFabric();
            Figure = fabric.CreateFigure();
        }

        private void CancelLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.CancelLastAction();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Canvas.SaveBitmap();
        }
    }
}
