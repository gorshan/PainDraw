using Draw.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Draw
{
    public partial class Form1 : Form
    {

        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen pen;
        Point point;
        bool mouseDown;
        IFigure figure;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //mainBitmap.SetPixel(10, 10, Color.Black);
            graphics = Graphics.FromImage(mainBitmap);
            pen = new Pen(Color.Black, 1);
            figure = new RectangleFigure();
            
            //Point point1 = new Point(0, 0);
            //Point point2 = new Point(300, 300);
            //graphics.DrawLine(pen, point1, point2);

            pictureBox1.Image = mainBitmap;
            point = new Point(0, 0);
            mouseDown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            List<Point> points1 = new List<Point>();

            if (mouseDown)
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                figure.DrawFigure(graphics, pen, point, e.Location);                
                pictureBox1.Image = tmpBitmap;
                GC.Collect();

                //окружность
                graphics.Clear(Color.White);
                int r = (int)Math.Sqrt(Math.Pow(((double)e.Y - point.Y), 2.0) + Math.Pow(((double)e.X - point.X), 2.0));
                int x;
                int y;
                x = point.X - r;
                y = point.Y - r;
                graphics.DrawEllipse(pen, x, y, r * 2, r * 2);
                pictureBox1.Image = mainBitmap;
                

                //Brush
                //graphics.DrawLine(pen, point, e.Location);
                //pictureBox1.Image = mainBitmap;
                //point = e.Location;


                //if (MouseDown == true)
                //{
                //    tmpBitmap = (Bitmap)mainBitmap.Clone();
                //    graphics = Graphics.FromImage(tmpBitmap);
                // Point pointLine = new POint();
                //    pictureBox1.Image = tmpBitmap;
                //    pointLine = e.Location;
                //    graphics.DrawLine(pen, pointLine.X, pointLine.Y, point[1].X, point[1].Y);
                //    pointLine = e.Location;
                //    GC.Collect();
                //}

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            mouseDown = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mainBitmap = tmpBitmap;
            mouseDown = false;
        }

        private void RightTriangleButton_Click(object sender, EventArgs e)
        {
            figure = new RightTriangleFigure();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            figure = new RectangleFigure();
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            figure = new IsoscelesTriangleFigure();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            figure = new LineFigure();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            figure = new SquareFigure();
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            figure = new NAngleFigure(Convert.ToInt32( NAngleNumericUpDown.Value));
        }

        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(figure is NAngleFigure)
            {
                ((NAngleFigure)figure).N = Convert.ToInt32(NAngleNumericUpDown.Value);
            }
        }

        private void EllipsButton_Click(object sender, EventArgs e)
        {
            figure = new EllipseFigure();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            figure = new CircleFigure();
        }
    }
}
