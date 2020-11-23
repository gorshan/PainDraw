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

            if (mouseDown)
            {
                graphics.Clear(Color.White);
                PointF[] points = new PointF[4];
                points[0] = point;
                points[1] = new Point(point.X, e.Y);
                points[2] = e.Location;
                points[3] = new Point(e.X, point.Y);
                graphics.DrawPolygon(pen, points);
                pictureBox1.Image = mainBitmap;
                //point = e.Location;

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
