using System.Drawing;

namespace Draw
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WigthScrollBar = new System.Windows.Forms.HScrollBar();
            this.widthText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ToolLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PenButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.PolyLine = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.EllipsButton = new System.Windows.Forms.Button();
            this.IsoscelesTriangleButton = new System.Windows.Forms.Button();
            this.TriangleByPoints = new System.Windows.Forms.Button();
            this.RightTriangleButton = new System.Windows.Forms.Button();
            this.RightNAngleButton = new System.Windows.Forms.Button();
            this.NAngleButton = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pipette_button = new System.Windows.Forms.Button();
            this.ChangeBackgroundColor = new System.Windows.Forms.Button();
            this.CancelLast = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteFigureButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.SaveProjectButton = new System.Windows.Forms.Button();
            this.LoadProjectButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.workWithFigureButton = new System.Windows.Forms.Button();
            this.MoveFace = new System.Windows.Forms.Button();
            this.MoveVertex = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.Scale = new System.Windows.Forms.Button();
            this.FillFigure = new System.Windows.Forms.Button();
            this.FillFigureButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NAngleNumericUpDown)).BeginInit();
            this.ToolLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NAngleNumericUpDown
            // 
            this.NAngleNumericUpDown.Location = new System.Drawing.Point(14, 475);
            this.NAngleNumericUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.NAngleNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NAngleNumericUpDown.Name = "NAngleNumericUpDown";
            this.NAngleNumericUpDown.Size = new System.Drawing.Size(134, 22);
            this.NAngleNumericUpDown.TabIndex = 15;
            this.NAngleNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NAngleNumericUpDown.Visible = false;
            this.NAngleNumericUpDown.ValueChanged += new System.EventHandler(this.NAngleNumericUpDown_ValueChanged);
            // 
            // WigthScrollBar
            // 
            this.WigthScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WigthScrollBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WigthScrollBar.LargeChange = 1;
            this.WigthScrollBar.Location = new System.Drawing.Point(405, 7);
            this.WigthScrollBar.Maximum = 50;
            this.WigthScrollBar.Minimum = 3;
            this.WigthScrollBar.Name = "WigthScrollBar";
            this.WigthScrollBar.Size = new System.Drawing.Size(177, 16);
            this.WigthScrollBar.TabIndex = 16;
            this.WigthScrollBar.Value = 3;
            this.WigthScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.WigthScrollBar_Scroll);
            // 
            // widthText
            // 
            this.widthText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.widthText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthText.Enabled = false;
            this.widthText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.widthText.Location = new System.Drawing.Point(481, 28);
            this.widthText.Margin = new System.Windows.Forms.Padding(1);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(21, 15);
            this.widthText.TabIndex = 17;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(3, 2);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(33, 31);
            this.ColorButton.TabIndex = 18;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // ToolLayoutPanel
            // 
            this.ToolLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ToolLayoutPanel.Controls.Add(this.PenButton);
            this.ToolLayoutPanel.Controls.Add(this.LineButton);
            this.ToolLayoutPanel.Controls.Add(this.PolyLine);
            this.ToolLayoutPanel.Controls.Add(this.SquareButton);
            this.ToolLayoutPanel.Controls.Add(this.RectangleButton);
            this.ToolLayoutPanel.Controls.Add(this.CircleButton);
            this.ToolLayoutPanel.Controls.Add(this.EllipsButton);
            this.ToolLayoutPanel.Controls.Add(this.IsoscelesTriangleButton);
            this.ToolLayoutPanel.Controls.Add(this.TriangleByPoints);
            this.ToolLayoutPanel.Controls.Add(this.RightTriangleButton);
            this.ToolLayoutPanel.Controls.Add(this.RightNAngleButton);
            this.ToolLayoutPanel.Controls.Add(this.NAngleButton);
            this.ToolLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ToolLayoutPanel.Location = new System.Drawing.Point(15, 57);
            this.ToolLayoutPanel.Margin = new System.Windows.Forms.Padding(5);
            this.ToolLayoutPanel.Name = "ToolLayoutPanel";
            this.ToolLayoutPanel.Size = new System.Drawing.Size(133, 408);
            this.ToolLayoutPanel.TabIndex = 22;
            this.ToolLayoutPanel.WrapContents = false;
            // 
            // PenButton
            // 
            this.PenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.PenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PenButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PenButton.Image = ((System.Drawing.Image)(resources.GetObject("PenButton.Image")));
            this.PenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PenButton.Location = new System.Drawing.Point(1, 1);
            this.PenButton.Margin = new System.Windows.Forms.Padding(1);
            this.PenButton.Name = "PenButton";
            this.PenButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PenButton.Size = new System.Drawing.Size(136, 31);
            this.PenButton.TabIndex = 1;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = false;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.LineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LineButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LineButton.Image = ((System.Drawing.Image)(resources.GetObject("LineButton.Image")));
            this.LineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LineButton.Location = new System.Drawing.Point(1, 34);
            this.LineButton.Margin = new System.Windows.Forms.Padding(1);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(136, 31);
            this.LineButton.TabIndex = 2;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = false;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // PolyLine
            // 
            this.PolyLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.PolyLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PolyLine.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PolyLine.Image = ((System.Drawing.Image)(resources.GetObject("PolyLine.Image")));
            this.PolyLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PolyLine.Location = new System.Drawing.Point(1, 67);
            this.PolyLine.Margin = new System.Windows.Forms.Padding(1);
            this.PolyLine.Name = "PolyLine";
            this.PolyLine.Size = new System.Drawing.Size(135, 31);
            this.PolyLine.TabIndex = 18;
            this.PolyLine.Text = "PolyLine";
            this.PolyLine.UseVisualStyleBackColor = false;
            this.PolyLine.Click += new System.EventHandler(this.PolyLine_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.SquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SquareButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SquareButton.Image = ((System.Drawing.Image)(resources.GetObject("SquareButton.Image")));
            this.SquareButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SquareButton.Location = new System.Drawing.Point(1, 100);
            this.SquareButton.Margin = new System.Windows.Forms.Padding(1);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(136, 31);
            this.SquareButton.TabIndex = 4;
            this.SquareButton.Text = "Square";
            this.SquareButton.UseVisualStyleBackColor = false;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.RectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RectangleButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("RectangleButton.Image")));
            this.RectangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RectangleButton.Location = new System.Drawing.Point(1, 133);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(1);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(136, 31);
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = false;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.CircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CircleButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CircleButton.Image = ((System.Drawing.Image)(resources.GetObject("CircleButton.Image")));
            this.CircleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CircleButton.Location = new System.Drawing.Point(1, 166);
            this.CircleButton.Margin = new System.Windows.Forms.Padding(1);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(136, 31);
            this.CircleButton.TabIndex = 5;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = false;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // EllipsButton
            // 
            this.EllipsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.EllipsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EllipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EllipsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EllipsButton.Image = ((System.Drawing.Image)(resources.GetObject("EllipsButton.Image")));
            this.EllipsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EllipsButton.Location = new System.Drawing.Point(1, 199);
            this.EllipsButton.Margin = new System.Windows.Forms.Padding(1);
            this.EllipsButton.Name = "EllipsButton";
            this.EllipsButton.Size = new System.Drawing.Size(136, 31);
            this.EllipsButton.TabIndex = 6;
            this.EllipsButton.Text = "Ellipse";
            this.EllipsButton.UseVisualStyleBackColor = false;
            this.EllipsButton.Click += new System.EventHandler(this.EllipsButton_Click);
            // 
            // IsoscelesTriangleButton
            // 
            this.IsoscelesTriangleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.IsoscelesTriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IsoscelesTriangleButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IsoscelesTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("IsoscelesTriangleButton.Image")));
            this.IsoscelesTriangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IsoscelesTriangleButton.Location = new System.Drawing.Point(3, 233);
            this.IsoscelesTriangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IsoscelesTriangleButton.Name = "IsoscelesTriangleButton";
            this.IsoscelesTriangleButton.Size = new System.Drawing.Size(135, 31);
            this.IsoscelesTriangleButton.TabIndex = 7;
            this.IsoscelesTriangleButton.Text = "Iso. Triangle";
            this.IsoscelesTriangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsoscelesTriangleButton.UseVisualStyleBackColor = false;
            this.IsoscelesTriangleButton.Click += new System.EventHandler(this.IsoscelesTriangleButton_Click);
            // 
            // TriangleByPoints
            // 
            this.TriangleByPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.TriangleByPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TriangleByPoints.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TriangleByPoints.Image = ((System.Drawing.Image)(resources.GetObject("TriangleByPoints.Image")));
            this.TriangleByPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TriangleByPoints.Location = new System.Drawing.Point(3, 268);
            this.TriangleByPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TriangleByPoints.Name = "TriangleByPoints";
            this.TriangleByPoints.Size = new System.Drawing.Size(135, 31);
            this.TriangleByPoints.TabIndex = 16;
            this.TriangleByPoints.Text = "Triangle";
            this.TriangleByPoints.UseVisualStyleBackColor = false;
            this.TriangleByPoints.Click += new System.EventHandler(this.TriangleByPoints_Click);
            // 
            // RightTriangleButton
            // 
            this.RightTriangleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.RightTriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RightTriangleButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RightTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("RightTriangleButton.Image")));
            this.RightTriangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RightTriangleButton.Location = new System.Drawing.Point(3, 303);
            this.RightTriangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightTriangleButton.Name = "RightTriangleButton";
            this.RightTriangleButton.Size = new System.Drawing.Size(135, 31);
            this.RightTriangleButton.TabIndex = 8;
            this.RightTriangleButton.Text = "Right Trangle";
            this.RightTriangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightTriangleButton.UseVisualStyleBackColor = false;
            this.RightTriangleButton.Click += new System.EventHandler(this.RightTriangleButton_Click);
            // 
            // RightNAngleButton
            // 
            this.RightNAngleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.RightNAngleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToolLayoutPanel.SetFlowBreak(this.RightNAngleButton, true);
            this.RightNAngleButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RightNAngleButton.Image = ((System.Drawing.Image)(resources.GetObject("RightNAngleButton.Image")));
            this.RightNAngleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RightNAngleButton.Location = new System.Drawing.Point(3, 338);
            this.RightNAngleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightNAngleButton.Name = "RightNAngleButton";
            this.RightNAngleButton.Size = new System.Drawing.Size(135, 31);
            this.RightNAngleButton.TabIndex = 10;
            this.RightNAngleButton.Text = "Right N-angle";
            this.RightNAngleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightNAngleButton.UseVisualStyleBackColor = false;
            this.RightNAngleButton.Click += new System.EventHandler(this.RightNAngleButton_Click);
            // 
            // NAngleButton
            // 
            this.NAngleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.NAngleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NAngleButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NAngleButton.Image = ((System.Drawing.Image)(resources.GetObject("NAngleButton.Image")));
            this.NAngleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAngleButton.Location = new System.Drawing.Point(3, 373);
            this.NAngleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NAngleButton.Name = "NAngleButton";
            this.NAngleButton.Size = new System.Drawing.Size(135, 31);
            this.NAngleButton.TabIndex = 9;
            this.NAngleButton.Text = "N-angle";
            this.NAngleButton.UseVisualStyleBackColor = false;
            this.NAngleButton.Click += new System.EventHandler(this.NAngleButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SizeLabel.Location = new System.Drawing.Point(49, 503);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(46, 17);
            this.SizeLabel.TabIndex = 23;
            this.SizeLabel.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Controls.Add(this.ColorButton);
            this.flowLayoutPanel1.Controls.Add(this.pipette_button);
            this.flowLayoutPanel1.Controls.Add(this.ChangeBackgroundColor);
            this.flowLayoutPanel1.Controls.Add(this.CancelLast);
            this.flowLayoutPanel1.Controls.Add(this.ClearButton);
            this.flowLayoutPanel1.Controls.Add(this.DeleteFigureButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(155, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 36);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // pipette_button
            // 
            this.pipette_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.pipette_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipette_button.Image = ((System.Drawing.Image)(resources.GetObject("pipette_button.Image")));
            this.pipette_button.Location = new System.Drawing.Point(42, 2);
            this.pipette_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipette_button.Name = "pipette_button";
            this.pipette_button.Size = new System.Drawing.Size(33, 31);
            this.pipette_button.TabIndex = 20;
            this.pipette_button.UseVisualStyleBackColor = false;
            this.pipette_button.Click += new System.EventHandler(this.pipette_button_Click);
            // 
            // ChangeBackgroundColor
            // 
            this.ChangeBackgroundColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangeBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("ChangeBackgroundColor.Image")));
            this.ChangeBackgroundColor.Location = new System.Drawing.Point(82, 2);
            this.ChangeBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ChangeBackgroundColor.Name = "ChangeBackgroundColor";
            this.ChangeBackgroundColor.Size = new System.Drawing.Size(33, 31);
            this.ChangeBackgroundColor.TabIndex = 0;
            this.ChangeBackgroundColor.UseVisualStyleBackColor = false;
            this.ChangeBackgroundColor.Click += new System.EventHandler(this.ChangeBackgroundColor_Click);
            // 
            // CancelLast
            // 
            this.CancelLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelLast.Image = ((System.Drawing.Image)(resources.GetObject("CancelLast.Image")));
            this.CancelLast.Location = new System.Drawing.Point(122, 2);
            this.CancelLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelLast.Name = "CancelLast";
            this.CancelLast.Size = new System.Drawing.Size(33, 31);
            this.CancelLast.TabIndex = 20;
            this.CancelLast.UseVisualStyleBackColor = false;
            this.CancelLast.Click += new System.EventHandler(this.CancelLast_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.Location = new System.Drawing.Point(161, 2);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(33, 31);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteFigureButton
            // 
            this.DeleteFigureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DeleteFigureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFigureButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteFigureButton.Image")));
            this.DeleteFigureButton.Location = new System.Drawing.Point(200, 2);
            this.DeleteFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteFigureButton.Name = "DeleteFigureButton";
            this.DeleteFigureButton.Size = new System.Drawing.Size(33, 31);
            this.DeleteFigureButton.TabIndex = 28;
            this.DeleteFigureButton.UseVisualStyleBackColor = false;
            this.DeleteFigureButton.Click += new System.EventHandler(this.DeleteFigureButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.saveImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImageButton.Image = ((System.Drawing.Image)(resources.GetObject("saveImageButton.Image")));
            this.saveImageButton.Location = new System.Drawing.Point(3, 2);
            this.saveImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(33, 31);
            this.saveImageButton.TabIndex = 20;
            this.saveImageButton.UseVisualStyleBackColor = false;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // SaveProjectButton
            // 
            this.SaveProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveProjectButton.Image")));
            this.SaveProjectButton.Location = new System.Drawing.Point(42, 2);
            this.SaveProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveProjectButton.Name = "SaveProjectButton";
            this.SaveProjectButton.Size = new System.Drawing.Size(33, 31);
            this.SaveProjectButton.TabIndex = 26;
            this.SaveProjectButton.UseVisualStyleBackColor = false;
            this.SaveProjectButton.Click += new System.EventHandler(this.SaveProjectButton_Click);
            // 
            // LoadProjectButton
            // 
            this.LoadProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.LoadProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadProjectButton.Image")));
            this.LoadProjectButton.Location = new System.Drawing.Point(81, 2);
            this.LoadProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadProjectButton.Name = "LoadProjectButton";
            this.LoadProjectButton.Size = new System.Drawing.Size(33, 31);
            this.LoadProjectButton.TabIndex = 27;
            this.LoadProjectButton.UseVisualStyleBackColor = false;
            this.LoadProjectButton.Click += new System.EventHandler(this.LoadProjectButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel2.Controls.Add(this.workWithFigureButton);
            this.flowLayoutPanel2.Controls.Add(this.MoveFace);
            this.flowLayoutPanel2.Controls.Add(this.MoveVertex);
            this.flowLayoutPanel2.Controls.Add(this.rotateButton);
            this.flowLayoutPanel2.Controls.Add(this.Scale);
            this.flowLayoutPanel2.Controls.Add(this.FillFigure);
            this.flowLayoutPanel2.Controls.Add(this.FillFigureButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(586, 5);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(255, 36);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // workWithFigureButton
            // 
            this.workWithFigureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.workWithFigureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workWithFigureButton.Image = ((System.Drawing.Image)(resources.GetObject("workWithFigureButton.Image")));
            this.workWithFigureButton.Location = new System.Drawing.Point(3, 2);
            this.workWithFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workWithFigureButton.Name = "workWithFigureButton";
            this.workWithFigureButton.Size = new System.Drawing.Size(33, 31);
            this.workWithFigureButton.TabIndex = 22;
            this.workWithFigureButton.UseVisualStyleBackColor = false;
            this.workWithFigureButton.Click += new System.EventHandler(this.workWithFigureButton_Click);
            // 
            // MoveFace
            // 
            this.MoveFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.MoveFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveFace.Image = ((System.Drawing.Image)(resources.GetObject("MoveFace.Image")));
            this.MoveFace.Location = new System.Drawing.Point(42, 2);
            this.MoveFace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveFace.Name = "MoveFace";
            this.MoveFace.Size = new System.Drawing.Size(33, 31);
            this.MoveFace.TabIndex = 26;
            this.MoveFace.UseVisualStyleBackColor = false;
            this.MoveFace.Click += new System.EventHandler(this.MoveFace_Click);
            // 
            // MoveVertex
            // 
            this.MoveVertex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.MoveVertex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveVertex.Image = ((System.Drawing.Image)(resources.GetObject("MoveVertex.Image")));
            this.MoveVertex.Location = new System.Drawing.Point(81, 2);
            this.MoveVertex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveVertex.Name = "MoveVertex";
            this.MoveVertex.Size = new System.Drawing.Size(33, 31);
            this.MoveVertex.TabIndex = 1;
            this.MoveVertex.UseVisualStyleBackColor = false;
            this.MoveVertex.Click += new System.EventHandler(this.MoveVertex_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateButton.Image")));
            this.rotateButton.Location = new System.Drawing.Point(120, 2);
            this.rotateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(33, 31);
            this.rotateButton.TabIndex = 29;
            this.rotateButton.UseVisualStyleBackColor = false;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // Scale
            // 
            this.Scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.Scale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scale.Image = ((System.Drawing.Image)(resources.GetObject("Scale.Image")));
            this.Scale.Location = new System.Drawing.Point(159, 2);
            this.Scale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(33, 31);
            this.Scale.TabIndex = 26;
            this.Scale.UseVisualStyleBackColor = false;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // FillFigure
            // 
            this.FillFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FillFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillFigure.Image = ((System.Drawing.Image)(resources.GetObject("FillFigure.Image")));
            this.FillFigure.Location = new System.Drawing.Point(198, 2);
            this.FillFigure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FillFigure.Name = "FillFigure";
            this.FillFigure.Size = new System.Drawing.Size(33, 31);
            this.FillFigure.TabIndex = 27;
            this.FillFigure.UseVisualStyleBackColor = false;
            this.FillFigure.Click += new System.EventHandler(this.FillFigure_Click);
            // 
            // FillFigureButton
            // 
            this.FillFigureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FillFigureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillFigureButton.Image = ((System.Drawing.Image)(resources.GetObject("FillFigureButton.Image")));
            this.FillFigureButton.Location = new System.Drawing.Point(3, 37);
            this.FillFigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FillFigureButton.Name = "FillFigureButton";
            this.FillFigureButton.Size = new System.Drawing.Size(33, 31);
            this.FillFigureButton.TabIndex = 27;
            this.FillFigureButton.UseVisualStyleBackColor = false;
            this.FillFigureButton.Click += new System.EventHandler(this.FillFigureButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(11, 5);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(137, 38);
            this.logoPictureBox.TabIndex = 25;
            this.logoPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(155, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1105, 551);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.saveImageButton);
            this.flowLayoutPanel3.Controls.Add(this.SaveProjectButton);
            this.flowLayoutPanel3.Controls.Add(this.LoadProjectButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(956, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(121, 37);
            this.flowLayoutPanel3.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1262, 599);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ToolLayoutPanel);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.NAngleNumericUpDown);
            this.Controls.Add(this.WigthScrollBar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1100, 567);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_ChangeSize);
            ((System.ComponentModel.ISupportInitialize)(this.NAngleNumericUpDown)).EndInit();
            this.ToolLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Color _mainColor;

        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button EllipsButton;
        private System.Windows.Forms.Button IsoscelesTriangleButton;
        private System.Windows.Forms.Button RightTriangleButton;
        private System.Windows.Forms.Button NAngleButton;
        private System.Windows.Forms.Button RightNAngleButton;
        private System.Windows.Forms.Button ClearButton;

        private System.Windows.Forms.NumericUpDown NAngleNumericUpDown;
        private System.Windows.Forms.HScrollBar WigthScrollBar;
        private System.Windows.Forms.TextBox widthText;

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorButton;
        protected System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button TriangleByPoints;
        private System.Windows.Forms.Button PolyLine;
        private System.Windows.Forms.Button pipette_button;
        private System.Windows.Forms.Button CancelLast;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.FlowLayoutPanel ToolLayoutPanel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button workWithFigureButton;
        private System.Windows.Forms.Button MoveFace;
        private System.Windows.Forms.Button FillFigureButton;
        private System.Windows.Forms.Button DeleteFigureButton;
        private System.Windows.Forms.Button ChangeBackgroundColor;
        private System.Windows.Forms.Button MoveVertex;
        private System.Windows.Forms.Button SaveProjectButton;
        private System.Windows.Forms.Button LoadProjectButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button Scale;
        private System.Windows.Forms.Button FillFigure;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

