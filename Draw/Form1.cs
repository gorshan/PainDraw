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

        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen pen;
        Point point;
        bool mouseDown;
        bool penButton;
        IFigure figure;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBitmap);
            pen = new Pen(Color.Black, 1);
            figure = new RectangleFigure();

            pictureBox1.Image = mainBitmap;
            point = new Point(0, 0);
            mouseDown = false;
            //penButton = false;
            widthText.Text = WigthScrollBar.Value + "";
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


                //Brush
                //graphics.DrawLine(pen, point, e.Location);
                //pictureBox1.Image = mainBitmap;


                //Brush



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

        

        private void ClearButton_Click(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(mainBitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = mainBitmap;
        }

        

        private void PenButton_Click(object sender, EventArgs e)
        {
            figure = new PenFigure();
        }

        private void WigthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pen.Width = WigthScrollBar.Value;
            widthText.Text = WigthScrollBar.Value + "";
        }

       
    }
}
