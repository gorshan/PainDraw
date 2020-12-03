using Draw.Canvases;
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

        public Canvas Canvas { get; private set; }
        public IFigure Figure { get; private set; }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas = new Canvas(pictureBox1.Width, pictureBox1.Height);
            Figure = new PenFigure();

            pictureBox1.Image = Canvas.GetImage();
            _lastPoint = new Point(0, 0);
            _mouseDown = false;
            widthText.Text = WigthScrollBar.Value + "";
            ColorButton.BackColor = Canvas.Pen.Color;
            SetSizeLabel();
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Figure.SetPoints(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            if (_pipetteClick)
            {
                _lastPoint2 = e.Location;
                Bitmap _tmpbitmap = Canvas.GetImage();
                Color pixelColor = Canvas.Pen.Color;
                pixelColor = _tmpbitmap.GetPixel(e.X, e.Y);
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastPoint = e.Location;
            if (Figure is PolylineByPointsFigure)
            {
                ((PolylineByPointsFigure)Figure).Points.AddLast(e.Location);
                Figure.SetPoints(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            if (Figure is TriangleByPointsFigure)
            {
                ((TriangleByPointsFigure)Figure).Points.Add(e.Location);
                Figure.SetPoints(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);
                ((TriangleByPointsFigure)Figure).Clear();        
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            if (Figure is NAngleByPointsFigure)
            {
                ((NAngleByPointsFigure)Figure).AddPoint(e.Location);
                Figure.SetPoints(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);
                ((NAngleByPointsFigure)Figure).Clear();
                pictureBox1.Image = Canvas.GetTmpImage();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {           
            Canvas.EndDraw(Figure);
            _mouseDown = false;

            //_lastPoint2 = e.Location;

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
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Figure is PolylineByPointsFigure)
            {
                ((PolylineByPointsFigure)Figure).Clear();
            }
        }

        private void RightTriangleButton_Click(object sender, EventArgs e)
        {
            Figure = new RightTriangleFigure();

            SettingsForm(sender);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Figure = new RectangleFigure();

            SettingsForm(sender);
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            Figure = new IsoscelesTriangleFigure();

            SettingsForm(sender);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Figure = new LineFigure();

            SettingsForm(sender);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Figure = new SquareFigure();

            SettingsForm(sender);
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            Figure = new NAngleFigure(Convert.ToInt32(NAngleNumericUpDown.Value));

            SettingsForm(sender);
        }

        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Figure is NAngleFigure)
            {
                ((NAngleFigure)Figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
        }

        private void EllipsButton_Click(object sender, EventArgs e)
        {
            Figure = new EllipseFigure();

            SettingsForm(sender);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Figure = new CircleFigure();

            SettingsForm(sender);
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
            Figure = new PenFigure();

            SettingsForm(sender);
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
            ColorButton.BackColor = colorDialog1.Color;

        }

        private void pipette_button_Click(object sender, EventArgs e)
        {
            _pipetteClick = true;
            SettingsForm(sender);
        }


        private void Form1_ChangeSize(object sender, EventArgs e)
        {
            if (Canvas == null || pictureBox1.Width <=0 || pictureBox1.Height <= 0)
            {
                return;
            }
            Canvas.Resize(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Canvas.GetImage();
            SetSizeLabel();
        }

        private void TriangleByPoints_Click(object sender, EventArgs e)
        {
            Figure = new TriangleByPointsFigure();
            SettingsForm(sender);
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
           Figure = new NAngleByPointsFigure(Convert.ToInt32(NAngleByPointsNumericUpDown.Value));
            SettingsForm(sender);
        }

        
        private void NAngleByPointsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PolyLine_Click(object sender, EventArgs e)
        {
            Figure = new PolylineByPointsFigure();

            SettingsForm(sender);
        }

        private void CancelLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.CancelLastAction();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Canvas.SaveBitmap();
        }

        private void SetSizeLabel()
        {
            SizeLabel.Text = $"{pictureBox1.Width} x {pictureBox1.Width}";
        }

        private void SettingsForm(object sender)
        {
            if (sender == NAngleButton)
            {
                NAngleByPointsNumericUpDown.Visible = true;
                NAngleNumericUpDown.Visible = false;
            }
            else if (sender == RightNAngleButton)
            {
                NAngleNumericUpDown.Visible = true;
                NAngleByPointsNumericUpDown.Visible = false;
            }
            else
            {
                NAngleNumericUpDown.Visible = false;
                NAngleByPointsNumericUpDown.Visible = false;
            }
        }
    }
}
