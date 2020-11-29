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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PenButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.EllipsButton = new System.Windows.Forms.Button();
            this.IsoscelesTriangleButton = new System.Windows.Forms.Button();
            this.RightTriangleButton = new System.Windows.Forms.Button();
            this.NAngleButton = new System.Windows.Forms.Button();
            this.RightNAngleButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WigthScrollBar = new System.Windows.Forms.HScrollBar();
            this.widthText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAngleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 520);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // PenButton
            // 
            this.PenButton.Location = new System.Drawing.Point(69, 23);
            this.PenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(75, 23);
            this.PenButton.TabIndex = 1;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(151, 23);
            this.LineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(75, 23);
            this.LineButton.TabIndex = 2;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(232, 22);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(75, 23);
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(313, 22);
            this.SquareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(75, 23);
            this.SquareButton.TabIndex = 4;
            this.SquareButton.Text = "Square";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(395, 23);
            this.CircleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(75, 22);
            this.CircleButton.TabIndex = 5;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // EllipsButton
            // 
            this.EllipsButton.Location = new System.Drawing.Point(476, 23);
            this.EllipsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EllipsButton.Name = "EllipsButton";
            this.EllipsButton.Size = new System.Drawing.Size(75, 23);
            this.EllipsButton.TabIndex = 6;
            this.EllipsButton.Text = "Ellips";
            this.EllipsButton.UseVisualStyleBackColor = true;
            this.EllipsButton.Click += new System.EventHandler(this.EllipsButton_Click);
            // 
            // IsoscelesTriangleButton
            // 
            this.IsoscelesTriangleButton.Location = new System.Drawing.Point(557, 23);
            this.IsoscelesTriangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IsoscelesTriangleButton.Name = "IsoscelesTriangleButton";
            this.IsoscelesTriangleButton.Size = new System.Drawing.Size(77, 63);
            this.IsoscelesTriangleButton.TabIndex = 7;
            this.IsoscelesTriangleButton.Text = "IsoscelesTriangle";
            this.IsoscelesTriangleButton.UseVisualStyleBackColor = true;
            this.IsoscelesTriangleButton.Click += new System.EventHandler(this.IsoscelesTriangleButton_Click);
            // 
            // RightTriangleButton
            // 
            this.RightTriangleButton.Location = new System.Drawing.Point(640, 23);
            this.RightTriangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightTriangleButton.Name = "RightTriangleButton";
            this.RightTriangleButton.Size = new System.Drawing.Size(75, 23);
            this.RightTriangleButton.TabIndex = 8;
            this.RightTriangleButton.Text = "RightTriangle";
            this.RightTriangleButton.UseVisualStyleBackColor = true;
            this.RightTriangleButton.Click += new System.EventHandler(this.RightTriangleButton_Click);
            // 
            // NAngleButton
            // 
            this.NAngleButton.Location = new System.Drawing.Point(723, 23);
            this.NAngleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NAngleButton.Name = "NAngleButton";
            this.NAngleButton.Size = new System.Drawing.Size(96, 48);
            this.NAngleButton.TabIndex = 9;
            this.NAngleButton.Text = "N-angle";
            this.NAngleButton.UseVisualStyleBackColor = true;
            // 
            // RightNAngleButton
            // 
            this.RightNAngleButton.Location = new System.Drawing.Point(837, 23);
            this.RightNAngleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightNAngleButton.Name = "RightNAngleButton";
            this.RightNAngleButton.Size = new System.Drawing.Size(79, 48);
            this.RightNAngleButton.TabIndex = 10;
            this.RightNAngleButton.Text = "Right N-angle";
            this.RightNAngleButton.UseVisualStyleBackColor = true;
            this.RightNAngleButton.Click += new System.EventHandler(this.RightNAngleButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 2);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(52, 44);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NAngleNumericUpDown
            // 
            this.NAngleNumericUpDown.Location = new System.Drawing.Point(923, 25);
            this.NAngleNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.NAngleNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NAngleNumericUpDown.Name = "NAngleNumericUpDown";
            this.NAngleNumericUpDown.Size = new System.Drawing.Size(71, 22);
            this.NAngleNumericUpDown.TabIndex = 15;
            this.NAngleNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NAngleNumericUpDown.ValueChanged += new System.EventHandler(this.NAngleNumericUpDown_ValueChanged);
            // 
            // WigthScrollBar
            // 
            this.WigthScrollBar.Location = new System.Drawing.Point(30, 50);
            this.WigthScrollBar.Maximum = 50;
            this.WigthScrollBar.Minimum = 1;
            this.WigthScrollBar.Name = "WigthScrollBar";
            this.WigthScrollBar.Size = new System.Drawing.Size(139, 21);
            this.WigthScrollBar.TabIndex = 16;
            this.WigthScrollBar.Value = 1;
            this.WigthScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.WigthScrollBar_Scroll);
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(85, 74);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(39, 22);
            this.widthText.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorLabel.Location = new System.Drawing.Point(187, 76);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(75, 10);
            this.colorLabel.TabIndex = 19;
            this.colorLabel.Text = "    ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 645);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.WigthScrollBar);
            this.Controls.Add(this.NAngleNumericUpDown);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RightNAngleButton);
            this.Controls.Add(this.NAngleButton);
            this.Controls.Add(this.RightTriangleButton);
            this.Controls.Add(this.IsoscelesTriangleButton);
            this.Controls.Add(this.EllipsButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.PenButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAngleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label colorLabel;
        protected System.Windows.Forms.PictureBox pictureBox1;
    }
}

