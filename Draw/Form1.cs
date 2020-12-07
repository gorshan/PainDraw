using Draw.Drawer;
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

        //private Point Canvas.Current.LastPoint;
        private bool _mouseDown;

        //private IFabric Canvas.Current.Fabric;
        //private AbstractFigure Canvas.Current.Figure;
        //private List<AbstractFigure> Canvas.Current.Figures;

        private string _mode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas.Create(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Canvas.Current.GetImage();

            Canvas.Current.LastPoint = new Point(0, 0);
            _mouseDown = false;

            Canvas.Current.Fabric = new PenFabric();
            _mouseHandler = new PaintMouseHandler();
             _mode = "Paint";
            Canvas.Current.Figures = new List<AbstractFigure>();
            Canvas.Current.renewFigure();

            Canvas.Current.NAngleNumericUpDown = Convert.ToInt32(NAngleNumericUpDown.Value);
            widthText.Text = WigthScrollBar.Value + "";
            ColorButton.BackColor = Canvas.Current.Pen.Color;
            SetSizeLabel();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            Canvas.Current.LastPoint = e.Location;
            switch (_mode)
            {
                case "Paint":
                    _mouseHandler.OnMouseDown(e.Location);
                    break;
                case "Figure":
                    Canvas.Current.Figure = null;
                    foreach (AbstractFigure figure in Canvas.Current.Figures)
                    {
                        if (figure.IsThisFigure(e.Location))
                        {
                            Canvas.Current.Figure = figure;
                            Canvas.Current.Figures.Remove(Canvas.Current.Figure);
                            DrawAll();
                            break;
                        }
                    }
                    break;
                case "MoveFace":
                    Canvas.Current.Figure = null;
                    foreach (AbstractFigure figure in Canvas.Current.Figures)
                    {
                        if (((SquareFigure)figure).IsThisFigure(e.Location))
                        {
                            Canvas.Current.Figure = figure;
                            Canvas.Current.Figures.Remove(Canvas.Current.Figure);
                            DrawAll();
                            break;
                        }
                    }
                    break;
                case "Pipette":
                    Color pixelColor = Canvas.Current.Pen.Color;
                    pixelColor = Canvas.Current.GetImage().GetPixel(e.X, e.Y);
                    ColorButton.BackColor = pixelColor;
                    Canvas.Current.Pen.Color = pixelColor;
                    Canvas.Current.Figure.Color = pixelColor;
                    _mode = "Paint";
                    _mouseDown = false;
                    break;
                case "Delete":
                    Canvas.Current.Figure = null;
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
                        _mouseHandler.OnMouseMove(e.Location);

                        break;
                    case "Figure":
                        MoveFigure(e.Location);

                        break;
                    case "MoveFace":
                        MoveFaceFigure(e.Location);
                        break;
                    case "Delete":
                        DeleteFigure(e.Location);
                        break;
                }

                pictureBox1.Image = Canvas.Current.GetTmpImage();
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseHandler.OnMouseUp(e.Location);
            //Canvas.Current.EndDraw();
            //_mouseDown = false;
            //if (Canvas.Current.Figure != null && !Canvas.Current.Figures.Contains(Canvas.Current.Figure) && !(Canvas.Current.Figure.IsEmpty()))
            //{
            //    Canvas.Current.Figures.Add(Canvas.Current.Figure);
            //}
            //if (!(Canvas.Current.Figure is NPointsFigure) ||
            //    ((NPointsFigure)Canvas.Current.Figure).IsFull())
            //{
            //    Canvas.Current.renewFigure();
            //}
        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (Canvas.Current.Fabric is PolylineByPointsFabric)
            {
                Canvas.Current.renewFigure();
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
            Canvas.Current.Fabric = new RightTriangleFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new RectangleFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new IsoscelesTriangleFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new LineFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new SquareFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new NAngleFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        

        private void EllipsButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new EllipseFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new CircleFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }


        private void PenButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new PenFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }      

        private void TriangleByPoints_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new TriangleByPointsFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new NAngleByPointsFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }
        

        private void PolyLine_Click(object sender, EventArgs e)
        {
            Canvas.Current.Fabric = new PolylineByPointsFabric();
            Canvas.Current.renewFigure();
            _mode = "Paint";
            SettingsForm(sender);
        }

        private void workWithFigureButton_Click(object sender, EventArgs e)
        {
            _mode = "Figure";
        }
        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Canvas.Current.renewFigure();
            _mode = "Paint";
        }

        private void pipette_button_Click(object sender, EventArgs e)
        {
            _mode = "Pipette";
            SettingsForm(sender);
        }

        

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Clear();
            Canvas.Current.Figure.Clear();
            Canvas.Current.Figures.Clear();
            pictureBox1.Image = Canvas.Current.GetImage();
        }

        private void WigthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.Current.Pen.Width = WigthScrollBar.Value;
            Canvas.Current.Figure.Width = WigthScrollBar.Value;
            widthText.Text = WigthScrollBar.Value + "";
        }
        private void CancelLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.Current.CancelLastAction();
            if (Canvas.Current.Figures.Count != 0)
            {
                Canvas.Current.Figures.RemoveAt(Canvas.Current.Figures.Count - 1);
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.SaveBitmap();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Canvas.Current.Figure.Color = colorDialog1.Color;
                Canvas.Current.Pen.Color = colorDialog1.Color;
            }
            ColorButton.BackColor = colorDialog1.Color;

        }


        private void UpdateFigure(Point endPoint)
        {
            Canvas.Current.Figure.Update(Canvas.Current.LastPoint, endPoint);
            Canvas.Current.DrawFigure(Canvas.Current.Figure);
        }

        private void MoveFigure(Point endPoint)
        {
            if (Canvas.Current.Figure != null)
            {
                Point d = new Point(endPoint.X - Canvas.Current.LastPoint.X, endPoint.Y - Canvas.Current.LastPoint.Y);
                Canvas.Current.LastPoint = endPoint;
                Canvas.Current.Figure.Move(d);
                Canvas.Current.DrawFigure(Canvas.Current.Figure);
            }
        }

        private void MoveFaceFigure(Point endPoint)
        {
            if (Canvas.Current.Figure != null)
            {
                Point d = new Point(endPoint.X - Canvas.Current.LastPoint.X, endPoint.Y - Canvas.Current.LastPoint.Y);
                Canvas.Current.LastPoint = endPoint;
               ((SquareFigure)Canvas.Current.Figure).MoveFace(d);
                Canvas.Current.DrawFigure(Canvas.Current.Figure);
            }
        }


        private void DeleteFigure(Point location)
        {
            foreach (AbstractFigure figure in Canvas.Current.Figures)
            {
                if (figure.IsThisFigure(location))
                {
                    Canvas.Current.Figures.Remove(figure);
                    DrawAll();
                    //pictureBox1.Image = Canvas.Current.GetImage();
                    break;
                }
            }
        }

        private void DrawAll()
        {
            Canvas.Current.DeleteAllFigures();
            foreach (AbstractFigure figure in Canvas.Current.Figures)
            {
                Canvas.Current.DrawFigure(figure);
                Canvas.Current.EndDraw();
            }
            pictureBox1.Image = Canvas.Current.GetImage();

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
            Canvas.Current.Resize(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Canvas.Current.GetImage();
            SetSizeLabel();
        }

        private void MoveFace_Click(object sender, EventArgs e)
        {
            _mode = "MoveFace";
        }

        private void FillFigureButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Figure.FillFigure();
        }

        private void DeleteFigureButton_Click(object sender, EventArgs e)
        {
            _mode = "Delete";
        }
    }
}
