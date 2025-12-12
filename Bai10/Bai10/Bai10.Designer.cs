namespace Bai10
{
    partial class Bai10
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
            panelDraw = new Panel();
            label1 = new Label();
            cmbDashStyle = new ComboBox();
            cmbWidth = new ComboBox();
            label2 = new Label();
            cmbLineJoin = new ComboBox();
            label3 = new Label();
            cmbDashCap = new ComboBox();
            label4 = new Label();
            cmbStartCap = new ComboBox();
            label5 = new Label();
            cmbEndCap = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.Control;
            panelDraw.Location = new Point(299, 0);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(504, 420);
            panelDraw.TabIndex = 0;
            panelDraw.Paint += panelDraw_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Dash Style:";
            // 
            // cmbDashStyle
            // 
            cmbDashStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDashStyle.FormattingEnabled = true;
            cmbDashStyle.Location = new Point(114, 36);
            cmbDashStyle.Name = "cmbDashStyle";
            cmbDashStyle.Size = new Size(177, 33);
            cmbDashStyle.TabIndex = 2;
            cmbDashStyle.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // cmbWidth
            // 
            cmbWidth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWidth.FormattingEnabled = true;
            cmbWidth.Location = new Point(114, 96);
            cmbWidth.Name = "cmbWidth";
            cmbWidth.Size = new Size(177, 33);
            cmbWidth.TabIndex = 4;
            cmbWidth.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 96);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 3;
            label2.Text = "Width:";
            // 
            // cmbLineJoin
            // 
            cmbLineJoin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLineJoin.FormattingEnabled = true;
            cmbLineJoin.Location = new Point(114, 153);
            cmbLineJoin.Name = "cmbLineJoin";
            cmbLineJoin.Size = new Size(177, 33);
            cmbLineJoin.TabIndex = 6;
            cmbLineJoin.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 153);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "Line Join:";
            // 
            // cmbDashCap
            // 
            cmbDashCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDashCap.FormattingEnabled = true;
            cmbDashCap.Location = new Point(114, 214);
            cmbDashCap.Name = "cmbDashCap";
            cmbDashCap.Size = new Size(177, 33);
            cmbDashCap.TabIndex = 8;
            cmbDashCap.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 214);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 7;
            label4.Text = "Dash Cap:";
            // 
            // cmbStartCap
            // 
            cmbStartCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStartCap.FormattingEnabled = true;
            cmbStartCap.Location = new Point(114, 277);
            cmbStartCap.Name = "cmbStartCap";
            cmbStartCap.Size = new Size(177, 33);
            cmbStartCap.TabIndex = 10;
            cmbStartCap.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 277);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 9;
            label5.Text = "Start Cap:";
            // 
            // cmbEndCap
            // 
            cmbEndCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEndCap.FormattingEnabled = true;
            cmbEndCap.Location = new Point(114, 337);
            cmbEndCap.Name = "cmbEndCap";
            cmbEndCap.Size = new Size(177, 33);
            cmbEndCap.TabIndex = 12;
            cmbEndCap.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 337);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 11;
            label6.Text = "End Cap:";
            // 
            // Bai10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 414);
            Controls.Add(cmbEndCap);
            Controls.Add(label6);
            Controls.Add(cmbStartCap);
            Controls.Add(label5);
            Controls.Add(cmbDashCap);
            Controls.Add(label4);
            Controls.Add(cmbLineJoin);
            Controls.Add(label3);
            Controls.Add(cmbWidth);
            Controls.Add(label2);
            Controls.Add(cmbDashStyle);
            Controls.Add(label1);
            Controls.Add(panelDraw);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Bai10";
            Text = "Pen Demo";
            Load += Bai10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDraw;
        private Label label1;
        private ComboBox cmbDashStyle;
        private ComboBox cmbWidth;
        private Label label2;
        private ComboBox cmbLineJoin;
        private Label label3;
        private ComboBox cmbDashCap;
        private Label label4;
        private ComboBox cmbStartCap;
        private Label label5;
        private ComboBox cmbEndCap;
        private Label label6;
    }
}
