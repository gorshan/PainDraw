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
            this.CancelLast = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.workWithFigureButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NAngleNumericUpDown)).BeginInit();
            this.ToolLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NAngleNumericUpDown
            // 
            this.NAngleNumericUpDown.Location = new System.Drawing.Point(8, 379);
            this.NAngleNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NAngleNumericUpDown.Name = "NAngleNumericUpDown";
            this.NAngleNumericUpDown.Size = new System.Drawing.Size(102, 20);
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
            this.WigthScrollBar.Location = new System.Drawing.Point(319, 4);
            this.WigthScrollBar.Maximum = 50;
            this.WigthScrollBar.Minimum = 1;
            this.WigthScrollBar.Name = "WigthScrollBar";
            this.WigthScrollBar.Size = new System.Drawing.Size(133, 16);
            this.WigthScrollBar.TabIndex = 16;
            this.WigthScrollBar.Value = 1;
            this.WigthScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.WigthScrollBar_Scroll);
            // 
            // widthText
            // 
            this.widthText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.widthText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthText.Enabled = false;
            this.widthText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.widthText.Location = new System.Drawing.Point(375, 22);
            this.widthText.Margin = new System.Windows.Forms.Padding(1);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(16, 13);
            this.widthText.TabIndex = 17;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(2, 2);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(2);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(25, 25);
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
            this.ToolLayoutPanel.Location = new System.Drawing.Point(8, 38);
            this.ToolLayoutPanel.Name = "ToolLayoutPanel";
            this.ToolLayoutPanel.Size = new System.Drawing.Size(103, 335);
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
            this.PenButton.Size = new System.Drawing.Size(102, 25);
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
            this.LineButton.Location = new System.Drawing.Point(1, 28);
            this.LineButton.Margin = new System.Windows.Forms.Padding(1);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(102, 25);
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
            this.PolyLine.Location = new System.Drawing.Point(1, 55);
            this.PolyLine.Margin = new System.Windows.Forms.Padding(1);
            this.PolyLine.Name = "PolyLine";
            this.PolyLine.Size = new System.Drawing.Size(101, 25);
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
            this.SquareButton.Location = new System.Drawing.Point(1, 82);
            this.SquareButton.Margin = new System.Windows.Forms.Padding(1);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(102, 25);
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
            this.RectangleButton.Location = new System.Drawing.Point(1, 109);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(1);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(102, 25);
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
            this.CircleButton.Location = new System.Drawing.Point(1, 136);
            this.CircleButton.Margin = new System.Windows.Forms.Padding(1);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(102, 25);
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
            this.EllipsButton.Location = new System.Drawing.Point(1, 163);
            this.EllipsButton.Margin = new System.Windows.Forms.Padding(1);
            this.EllipsButton.Name = "EllipsButton";
            this.EllipsButton.Size = new System.Drawing.Size(102, 25);
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
            this.IsoscelesTriangleButton.Location = new System.Drawing.Point(2, 191);
            this.IsoscelesTriangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.IsoscelesTriangleButton.Name = "IsoscelesTriangleButton";
            this.IsoscelesTriangleButton.Size = new System.Drawing.Size(101, 25);
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
            this.TriangleByPoints.Location = new System.Drawing.Point(2, 220);
            this.TriangleByPoints.Margin = new System.Windows.Forms.Padding(2);
            this.TriangleByPoints.Name = "TriangleByPoints";
            this.TriangleByPoints.Size = new System.Drawing.Size(101, 25);
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
            this.RightTriangleButton.Location = new System.Drawing.Point(2, 249);
            this.RightTriangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RightTriangleButton.Name = "RightTriangleButton";
            this.RightTriangleButton.Size = new System.Drawing.Size(101, 25);
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
            this.RightNAngleButton.Location = new System.Drawing.Point(2, 278);
            this.RightNAngleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RightNAngleButton.Name = "RightNAngleButton";
            this.RightNAngleButton.Size = new System.Drawing.Size(101, 25);
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
            this.NAngleButton.Location = new System.Drawing.Point(2, 307);
            this.NAngleButton.Margin = new System.Windows.Forms.Padding(2);
            this.NAngleButton.Name = "NAngleButton";
            this.NAngleButton.Size = new System.Drawing.Size(101, 25);
            this.NAngleButton.TabIndex = 9;
            this.NAngleButton.Text = "N-angle";
            this.NAngleButton.UseVisualStyleBackColor = false;
            this.NAngleButton.Click += new System.EventHandler(this.NAngleButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SizeLabel.Location = new System.Drawing.Point(37, 403);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 13);
            this.SizeLabel.TabIndex = 23;
            this.SizeLabel.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Controls.Add(this.ColorButton);
            this.flowLayoutPanel1.Controls.Add(this.pipette_button);
            this.flowLayoutPanel1.Controls.Add(this.CancelLast);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.ClearButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 29);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // pipette_button
            // 
            this.pipette_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.pipette_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipette_button.Image = ((System.Drawing.Image)(resources.GetObject("pipette_button.Image")));
            this.pipette_button.Location = new System.Drawing.Point(31, 2);
            this.pipette_button.Margin = new System.Windows.Forms.Padding(2);
            this.pipette_button.Name = "pipette_button";
            this.pipette_button.Size = new System.Drawing.Size(25, 25);
            this.pipette_button.TabIndex = 20;
            this.pipette_button.UseVisualStyleBackColor = false;
            this.pipette_button.Click += new System.EventHandler(this.pipette_button_Click);
            // 
            // CancelLast
            // 
            this.CancelLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelLast.Image = ((System.Drawing.Image)(resources.GetObject("CancelLast.Image")));
            this.CancelLast.Location = new System.Drawing.Point(60, 2);
            this.CancelLast.Margin = new System.Windows.Forms.Padding(2);
            this.CancelLast.Name = "CancelLast";
            this.CancelLast.Size = new System.Drawing.Size(25, 25);
            this.CancelLast.TabIndex = 20;
            this.CancelLast.UseVisualStyleBackColor = false;
            this.CancelLast.Click += new System.EventHandler(this.CancelLast_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(89, 2);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(25, 25);
            this.saveButton.TabIndex = 20;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.Location = new System.Drawing.Point(118, 2);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(25, 25);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel2.Controls.Add(this.workWithFigureButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(455, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 29);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // workWithFigureButton
            // 
            this.workWithFigureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.workWithFigureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workWithFigureButton.Image = ((System.Drawing.Image)(resources.GetObject("workWithFigureButton.Image")));
            this.workWithFigureButton.Location = new System.Drawing.Point(3, 3);
            this.workWithFigureButton.Name = "workWithFigureButton";
            this.workWithFigureButton.Size = new System.Drawing.Size(25, 25);
            this.workWithFigureButton.TabIndex = 22;
            this.workWithFigureButton.UseVisualStyleBackColor = false;
            this.workWithFigureButton.Click += new System.EventHandler(this.workWithFigureButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(8, 4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(103, 31);
            this.logoPictureBox.TabIndex = 25;
            this.logoPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(116, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 463);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1006, 512);
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
            this.MinimumSize = new System.Drawing.Size(520, 485);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_ChangeSize);
            ((System.ComponentModel.ISupportInitialize)(this.NAngleNumericUpDown)).EndInit();
            this.ToolLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel ToolLayoutPanel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button workWithFigureButton;
    }
}

