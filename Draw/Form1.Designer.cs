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
            this.N = new System.Windows.Forms.TextBox();
            this.PenWigth = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // PenButton
            // 
            this.PenButton.Location = new System.Drawing.Point(70, 23);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(75, 23);
            this.PenButton.TabIndex = 1;
            this.PenButton.Text = "Pen";
            this.PenButton.UseVisualStyleBackColor = true;
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(151, 23);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(75, 23);
            this.LineButton.TabIndex = 2;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(232, 22);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(75, 23);
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(313, 22);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(75, 23);
            this.SquareButton.TabIndex = 4;
            this.SquareButton.Text = "Square";
            this.SquareButton.UseVisualStyleBackColor = true;
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(394, 23);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(75, 23);
            this.CircleButton.TabIndex = 5;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            // 
            // EllipsButton
            // 
            this.EllipsButton.Location = new System.Drawing.Point(476, 23);
            this.EllipsButton.Name = "EllipsButton";
            this.EllipsButton.Size = new System.Drawing.Size(75, 23);
            this.EllipsButton.TabIndex = 6;
            this.EllipsButton.Text = "Ellips";
            this.EllipsButton.UseVisualStyleBackColor = true;
            // 
            // IsoscelesTriangleButton
            // 
            this.IsoscelesTriangleButton.Location = new System.Drawing.Point(558, 23);
            this.IsoscelesTriangleButton.Name = "IsoscelesTriangleButton";
            this.IsoscelesTriangleButton.Size = new System.Drawing.Size(75, 23);
            this.IsoscelesTriangleButton.TabIndex = 7;
            this.IsoscelesTriangleButton.Text = "IsoscelesTriangle";
            this.IsoscelesTriangleButton.UseVisualStyleBackColor = true;
            // 
            // RightTriangleButton
            // 
            this.RightTriangleButton.Location = new System.Drawing.Point(640, 23);
            this.RightTriangleButton.Name = "RightTriangleButton";
            this.RightTriangleButton.Size = new System.Drawing.Size(75, 23);
            this.RightTriangleButton.TabIndex = 8;
            this.RightTriangleButton.Text = "RightTriangle";
            this.RightTriangleButton.UseVisualStyleBackColor = true;
            // 
            // NAngleButton
            // 
            this.NAngleButton.Location = new System.Drawing.Point(722, 23);
            this.NAngleButton.Name = "NAngleButton";
            this.NAngleButton.Size = new System.Drawing.Size(75, 23);
            this.NAngleButton.TabIndex = 9;
            this.NAngleButton.Text = "N-angle";
            this.NAngleButton.UseVisualStyleBackColor = true;
            // 
            // RightNAngleButton
            // 
            this.RightNAngleButton.Location = new System.Drawing.Point(932, 23);
            this.RightNAngleButton.Name = "RightNAngleButton";
            this.RightNAngleButton.Size = new System.Drawing.Size(75, 23);
            this.RightNAngleButton.TabIndex = 10;
            this.RightNAngleButton.Text = "Right N-angle";
            this.RightNAngleButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(52, 44);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(816, 23);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(100, 22);
            this.N.TabIndex = 13;
            // 
            // PenWigth
            // 
            this.PenWigth.Location = new System.Drawing.Point(48, 73);
            this.PenWigth.Name = "PenWigth";
            this.PenWigth.Size = new System.Drawing.Size(113, 13);
            this.PenWigth.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 645);
            this.Controls.Add(this.PenWigth);
            this.Controls.Add(this.N);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.ProgressBar PenWigth;
    }
}

