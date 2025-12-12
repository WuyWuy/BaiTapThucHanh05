namespace Bai11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCanvas = new PictureBox();
            gbShapes = new GroupBox();
            radEllipse = new RadioButton();
            radRectangle = new RadioButton();
            radLine = new RadioButton();
            gbPen = new GroupBox();
            btnColor = new Button();
            txtWidth = new TextBox();
            Width = new Label();
            gbBrushes = new GroupBox();
            radLinearGradient = new RadioButton();
            radTexture = new RadioButton();
            radHatch = new RadioButton();
            radSolid = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            gbShapes.SuspendLayout();
            gbPen.SuspendLayout();
            gbBrushes.SuspendLayout();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.ButtonHighlight;
            picCanvas.Location = new Point(305, -1);
            picCanvas.Margin = new Padding(4);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(748, 588);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // gbShapes
            // 
            gbShapes.Controls.Add(radEllipse);
            gbShapes.Controls.Add(radRectangle);
            gbShapes.Controls.Add(radLine);
            gbShapes.Location = new Point(15, 15);
            gbShapes.Margin = new Padding(4);
            gbShapes.Name = "gbShapes";
            gbShapes.Padding = new Padding(4);
            gbShapes.Size = new Size(282, 156);
            gbShapes.TabIndex = 1;
            gbShapes.TabStop = false;
            gbShapes.Text = "Shapes";
            // 
            // radEllipse
            // 
            radEllipse.AutoSize = true;
            radEllipse.Location = new Point(8, 108);
            radEllipse.Margin = new Padding(4);
            radEllipse.Name = "radEllipse";
            radEllipse.Size = new Size(86, 29);
            radEllipse.TabIndex = 2;
            radEllipse.TabStop = true;
            radEllipse.Text = "Ellipse";
            radEllipse.UseVisualStyleBackColor = true;
            // 
            // radRectangle
            // 
            radRectangle.AutoSize = true;
            radRectangle.Location = new Point(8, 70);
            radRectangle.Margin = new Padding(4);
            radRectangle.Name = "radRectangle";
            radRectangle.Size = new Size(113, 29);
            radRectangle.TabIndex = 1;
            radRectangle.TabStop = true;
            radRectangle.Text = "Rectangle";
            radRectangle.UseVisualStyleBackColor = true;
            // 
            // radLine
            // 
            radLine.AutoSize = true;
            radLine.Location = new Point(8, 32);
            radLine.Margin = new Padding(4);
            radLine.Name = "radLine";
            radLine.Size = new Size(68, 29);
            radLine.TabIndex = 0;
            radLine.TabStop = true;
            radLine.Text = "Line";
            radLine.UseVisualStyleBackColor = true;
            // 
            // gbPen
            // 
            gbPen.Controls.Add(btnColor);
            gbPen.Controls.Add(txtWidth);
            gbPen.Controls.Add(Width);
            gbPen.Location = new Point(15, 179);
            gbPen.Margin = new Padding(4);
            gbPen.Name = "gbPen";
            gbPen.Padding = new Padding(4);
            gbPen.Size = new Size(282, 122);
            gbPen.TabIndex = 2;
            gbPen.TabStop = false;
            gbPen.Text = "Pen";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(59, 79);
            btnColor.Margin = new Padding(4);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(118, 36);
            btnColor.TabIndex = 2;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(80, 25);
            txtWidth.Margin = new Padding(4);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(155, 31);
            txtWidth.TabIndex = 1;
            txtWidth.Text = "1";
            txtWidth.KeyPress += txtWidth_KeyPress;
            // 
            // Width
            // 
            Width.AutoSize = true;
            Width.Location = new Point(8, 29);
            Width.Margin = new Padding(4, 0, 4, 0);
            Width.Name = "Width";
            Width.Size = new Size(64, 25);
            Width.TabIndex = 0;
            Width.Text = "Width:";
            // 
            // gbBrushes
            // 
            gbBrushes.Controls.Add(radLinearGradient);
            gbBrushes.Controls.Add(radTexture);
            gbBrushes.Controls.Add(radHatch);
            gbBrushes.Controls.Add(radSolid);
            gbBrushes.Location = new Point(15, 309);
            gbBrushes.Margin = new Padding(4);
            gbBrushes.Name = "gbBrushes";
            gbBrushes.Padding = new Padding(4);
            gbBrushes.Size = new Size(282, 254);
            gbBrushes.TabIndex = 3;
            gbBrushes.TabStop = false;
            gbBrushes.Text = "Brushes";
            // 
            // radLinearGradient
            // 
            radLinearGradient.AutoSize = true;
            radLinearGradient.Location = new Point(8, 190);
            radLinearGradient.Margin = new Padding(4);
            radLinearGradient.Name = "radLinearGradient";
            radLinearGradient.Size = new Size(155, 29);
            radLinearGradient.TabIndex = 6;
            radLinearGradient.TabStop = true;
            radLinearGradient.Text = "Linear Gradient";
            radLinearGradient.UseVisualStyleBackColor = true;
            // 
            // radTexture
            // 
            radTexture.AutoSize = true;
            radTexture.Location = new Point(8, 134);
            radTexture.Margin = new Padding(4);
            radTexture.Name = "radTexture";
            radTexture.Size = new Size(92, 29);
            radTexture.TabIndex = 5;
            radTexture.TabStop = true;
            radTexture.Text = "Texture";
            radTexture.UseVisualStyleBackColor = true;
            // 
            // radHatch
            // 
            radHatch.AutoSize = true;
            radHatch.Location = new Point(8, 84);
            radHatch.Margin = new Padding(4);
            radHatch.Name = "radHatch";
            radHatch.Size = new Size(83, 29);
            radHatch.TabIndex = 4;
            radHatch.TabStop = true;
            radHatch.Text = "Hatch";
            radHatch.UseVisualStyleBackColor = true;
            // 
            // radSolid
            // 
            radSolid.AutoSize = true;
            radSolid.Location = new Point(8, 32);
            radSolid.Margin = new Padding(4);
            radSolid.Name = "radSolid";
            radSolid.Size = new Size(77, 29);
            radSolid.TabIndex = 3;
            radSolid.TabStop = true;
            radSolid.Text = "Solid";
            radSolid.UseVisualStyleBackColor = true;
            radSolid.CheckedChanged += radSolid_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1049, 580);
            Controls.Add(gbBrushes);
            Controls.Add(gbPen);
            Controls.Add(gbShapes);
            Controls.Add(picCanvas);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Bai Thi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            gbShapes.ResumeLayout(false);
            gbShapes.PerformLayout();
            gbPen.ResumeLayout(false);
            gbPen.PerformLayout();
            gbBrushes.ResumeLayout(false);
            gbBrushes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCanvas;
        private GroupBox gbShapes;
        private RadioButton radEllipse;
        private RadioButton radRectangle;
        private RadioButton radLine;
        private GroupBox gbPen;
        private Button btnColor;
        private TextBox txtWidth;
        private Label Width;
        private GroupBox gbBrushes;
        private RadioButton radLinearGradient;
        private RadioButton radTexture;
        private RadioButton radHatch;
        private RadioButton radSolid;
    }
}
