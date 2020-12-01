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
        private bool _mouseDown;
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
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Figure.SetPoints(_lastPoint, e.Location);
                Canvas.DrawFigure(Figure);
                pictureBox1.Image = Canvas.GetTmpImage();
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastPoint = e.Location;
            if (Figure is PolylineByPointsFigure)
            {
                ((PolylineByPointsFigure)Figure).Points.AddLast(e.Location);
                Canvas.StartDraw(Figure);
                Canvas.DrawFigure(Figure.GetPoints(_lastPoint, e.Location));
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            if (Figure is TriangleByPointsFigure)
            {
                ((TriangleByPointsFigure)Figure).Points.Add(e.Location);
                Canvas.StartDraw(Figure);
                Canvas.DrawFigure(Figure.GetPoints(_lastPoint, e.Location));
                  ((TriangleByPointsFigure)Figure).Clear();        
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            if (Figure is NAngleByPointsFigure)
            {
                ((NAngleByPointsFigure)Figure).AddPoint(e.Location);
                Canvas.StartDraw(Figure);
                Canvas.DrawFigure(Figure.GetPoints(_lastPoint, e.Location));
                ((NAngleByPointsFigure)Figure).Clear();
                pictureBox1.Image = Canvas.GetTmpImage();
            }
            Canvas.StartDraw(Figure);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {           
            Canvas.EndDraw(Figure);
            _mouseDown = false;
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
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Figure = new RectangleFigure();
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            Figure = new IsoscelesTriangleFigure();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Figure = new LineFigure();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Figure = new SquareFigure();
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            Figure = new NAngleFigure(Convert.ToInt32(NAngleNumericUpDown.Value));
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
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Figure = new CircleFigure();
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
            Figure = new TriangleByPointsFigure();
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
           Figure = new NAngleByPointsFigure(Convert.ToInt32(NAngleByPointsNumericUpDown.Value));
        }

        private void NAngleByPointsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PolyLine_Click(object sender, EventArgs e)
        {
            Figure = new PolylineByPointsFigure();
        }

        private void CancelLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.CancelLastAction();
        }
    }
}
