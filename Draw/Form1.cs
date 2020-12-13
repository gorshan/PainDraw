using Draw.BitmapOperations;
using Draw.BitmapOperations.OperationParameters;
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
        private IMouseHandler _mouseHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Canvas.Create(pictureBox1.Width, pictureBox1.Height, new OperationCreator());
            Canvas.Current.NAngle = Convert.ToInt32(NAngleNumericUpDown.Value);
            pictureBox1.Image = Canvas.Current.MainBitmap;
            _mouseHandler = new PaintMouseHandler();

            widthText.Text = WigthScrollBar.Value + "";
            ColorButton.BackColor = Canvas.Current.Pen.Color;
            SetSizeLabel();
            ToolTip t = new ToolTip();
            t.SetToolTip(ColorButton, "Color");
            t.SetToolTip(pipette_button, "Pipette");
            t.SetToolTip(CancelLast, "Cancel last");
            t.SetToolTip(saveImageButton, "Save image");
            t.SetToolTip(SaveProjectButton, "Save project");
            t.SetToolTip(LoadProjectButton, "Load project");
            t.SetToolTip(ClearButton, "Clear all");
            t.SetToolTip(ChangeBackgroundColor, "Background color");

            t.SetToolTip(workWithFigureButton, "Move figure");
            t.SetToolTip(MoveFace, "Move edge");
            t.SetToolTip(MoveVertex, "Move top");
            t.SetToolTip(rotateButton, "Rotate figure");
            //fills
            t.SetToolTip(DeleteFigureButton, "Delete figure");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = _mouseHandler.OnMouseDown(e.Location);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = _mouseHandler.OnMouseMove(e.Location);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)

        {
            pictureBox1.Image = _mouseHandler.OnMouseUp(e.Location);


        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (Canvas.Current.Fabric is PolylineByPointsFabric)
            {
                Canvas.Current.RenewFigure();
            }
        }

        private void RightTriangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new RightTriangleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new RectangleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void IsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new IsoscelesTriangleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new LineFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new SquareFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void RightNAngleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new NAngleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }



        private void EllipsButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new EllipseFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new CircleFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }


        private void PenButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new PenFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void TriangleByPoints_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new TriangleByPointsFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void NAngleButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new NAngleByPointsFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }


        private void PolyLine_Click(object sender, EventArgs e)
        {
            Canvas.Current.ChangeFabric(new PolylineByPointsFabric());
            if (!(_mouseHandler is PaintMouseHandler))
            {
                _mouseHandler = new PaintMouseHandler();
            }
            SettingsForm(sender);
        }

        private void workWithFigureButton_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is MoveFigureMouseHandler))
            {
                _mouseHandler = new MoveFigureMouseHandler();
            }
            SettingsForm(sender);
        }

        private void pipette_button_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is PipetteMouseHandler))
            {
                _mouseHandler = new PipetteMouseHandler(ColorButton);
            }
            SettingsForm(sender);
        }

        private void MoveFace_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is MoveFaceMouseHandler))
            {
                _mouseHandler = new MoveFaceMouseHandler();
            }
            SettingsForm(sender);
        }
        private void DeleteFigureButton_Click(object sender, EventArgs e)
        {
            if (!(_mouseHandler is DeleteFigureMouseHandler))
            {
                _mouseHandler = new DeleteFigureMouseHandler();
            }
            SettingsForm(sender);
        }

        private void NAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Canvas.Current.NAngle = Convert.ToInt32(NAngleNumericUpDown.Value);
        }

        private void FillFigureButton_Click(object sender, EventArgs e)
        {
            Canvas.Current.Figure.FillFigure();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {            
            pictureBox1.Image = Canvas.Current.Action(new ClearOperationParameters());
        }

        private void WigthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.Current.ChangeWidth(WigthScrollBar.Value);
            widthText.Text = WigthScrollBar.Value + "";
        }
        private void CancelLast_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.Current.Action(new CancelLastActionParameter());

        }
        private void saveImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.Current.Action(new SaveBitmapOperationParameters());
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Canvas.Current.ChangeColor(colorDialog1.Color);
            }
            ColorButton.BackColor = colorDialog1.Color;
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
            if (Canvas.Current != null || pictureBox1.Width <= 0 || pictureBox1.Height <= 0)
            {                
                pictureBox1.Image = Canvas.Current.Action(new SizeOperationParameter(pictureBox1.Width, pictureBox1.Height));
                SetSizeLabel();
            }
        }
        private void SetSizeLabel()
        {
            SizeLabel.Text = $"{pictureBox1.Width} x {pictureBox1.Width}";
        }


        private void ChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Canvas.Current.Action(new ChangeBackgroundColorOperationParameters(colorDialog1
                .Color));
            Canvas.Current.Color = colorDialog1.Color;
            pictureBox1.Image = Canvas.Current.Action(new DrawAllFigureOperationParameters());
        }

        private void MoveVertex_Click(object sender, EventArgs e)
        {
            _mouseHandler = new MoveVertexMouseHandler();
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            _mouseHandler = new ScaleOfFigureMouseHandler();
        }

        private void FillFigure_Click(object sender, EventArgs e)
        {
            _mouseHandler = new FillFigureMouseHandler();
        }

        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            Saver.SaveProject(Canvas.Current.Figures);
        }

        private void LoadProjectButton_Click(object sender, EventArgs e)
        {
            List<AbstractFigure> figures = Saver.LoadProject();
            if(figures != null)
            {
                Canvas.Current.Figures = figures;
                Canvas.Current.DrawAll();
                pictureBox1.Image = Canvas.Current.GetImage();
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            _mouseHandler = new RotateFigureMouseHandler();
        }
    }
}

  
