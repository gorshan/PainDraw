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
        Graphics graphics;
        Pen pen;
        Point point;
        bool mouseDown;

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
                //эллипс
                //graphics.Clear(Color.White);
                //graphics.DrawEllipse(pen, point.X, point.Y, e.X - point.X, e.Y-point.Y );
                //pictureBox1.Image = mainBitmap;

                //окружность
                //graphics.Clear(Color.White);
                //graphics.DrawEllipse(pen, point.X, point.Y, e.Y-point.Y, e.Y - point.Y);
                //pictureBox1.Image = mainBitmap;

                // n-угольник
                //double r;
                //int n=500;
                //r = Math.Sqrt(Math.Pow(e.Y - point.Y, 2) + Math.Pow(e.X - point.X, 2));
                //graphics.Clear(Color.White);

                //PointF[] points = new PointF[n];
                //for (int i=0; i < n; i++)
                //{
                //    points[i] = new Point(Convert.ToInt32(point.X + r * Math.Cos((2 * Math.PI * i) / n)), 
                //                          Convert.ToInt32(point.Y + r * Math.Sin((2 * Math.PI * i) / n)));
                //}
                //graphics.DrawPolygon(pen, points);
                //pictureBox1.Image = mainBitmap;

                //равнобедренный треугольник
                //graphics.Clear(Color.White);
                //PointF[] points = new PointF[3];
                //points[0] = point;
                //points[1] = new Point(2*point.X-e.X, e.Y);
                //points[2] = e.Location;
                //graphics.DrawPolygon(pen, points);
                //pictureBox1.Image = mainBitmap;

                //прямая
                //graphics.Clear(Color.White);
                //PointF[] points = new PointF[2];
                //points[0] = point;
                //points[1] = e.Location;
                //graphics.DrawPolygon(pen, points);
                //pictureBox1.Image = mainBitmap;

                //прямоугольный треугольник
                //graphics.Clear(Color.White);
                //PointF[] points = new PointF[3];
                //points[0] = point;
                //points[1] = new Point(point.X, e.Y);
                //points[2] = e.Location;
                //graphics.DrawPolygon(pen, points);
                //pictureBox1.Image = mainBitmap;

                // прямоугольник
                //graphics.Clear(Color.White);
                //PointF[] points = new PointF[4];
                //points[0] = point;
                //points[1] = new Point(point.X, e.Y);
                //points[2] = e.Location;
                //points[3] = new Point(e.X, point.Y);
                //graphics.DrawPolygon(pen, points);
                //pictureBox1.Image = mainBitmap;

                // квадрат, но только 2 и 4 четверти
                //graphics.Clear(Color.White);
                //PointF[] points = new PointF[4];
                //points[0] = point;
                //points[1] = new Point(point.X, e.Y);
                //points[2] = new Point(point.X + e.Y - point.Y, e.Y);
                //points[3] = new Point(point.X + e.Y - point.Y, point.Y);
                //graphics.DrawPolygon(pen, points);
                //pictureBox1.Image = mainBitmap;

                //кривая линия
                //graphics.DrawLine(pen, point, e.Location);
                //pictureBox1.Image = mainBitmap;
                //point = e.Location;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            mouseDown = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
