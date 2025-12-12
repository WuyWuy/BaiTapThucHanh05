using System.Drawing.Drawing2D;

namespace Bai09
{
    public partial class Form1 : Form
    {
        Graphics draw;
        Pen blackpen;
        SolidBrush blackbrush;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Filled Ellipse";
            draw = this.CreateGraphics();
            draw.SmoothingMode = SmoothingMode.AntiAlias;
            blackpen = new Pen(Color.FromArgb(139, 0, 0), 4);
            blackbrush = new SolidBrush(Color.FromArgb(139, 0, 0));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {   

            switch (comboBox1.Text)
            {

                case "Circle":
                    DrawEllipse(200, 200);
                    break;
                case "Square":
                    DrawRectangle(200, 200);
                    break;
                case "Ellipse":
                    DrawEllipse(200, 100);
                    break;
                case "Pie":
                    DrawPie(200, 200, 275);
                    break;
                case "Filled Circle":
                    DrawFilledEllipse(200, 200);
                    break;
                case "Filled Square":
                    DrawFilledRectangle(200, 200);
                    break;
                case "Filled Ellipse":
                    DrawFilledEllipse(200, 100);
                    break;
                case "Filled Pie":
                    DrawFilledPie(200, 200, 275);
                    break;

            }

        }
        private void DrawEllipse(int width, int height)
        {
            draw.DrawEllipse(blackpen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height);
        }
        private void DrawRectangle(int width, int height)
        {
            draw.DrawRectangle(blackpen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height);
        }
        private void DrawPie(int width, int height, int angle)
        {
            draw.DrawPie(blackpen, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height, 0, angle);
        }
        private void DrawFilledEllipse(int width, int height)
        {
            draw.FillEllipse(blackbrush, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height);
        }
        private void DrawFilledRectangle(int width, int height)
        {
            draw.FillRectangle(blackbrush, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height);
        }
        private void DrawFilledPie(int width, int height, int angle)
        {
            draw.FillPie(blackbrush, this.Width / 2 - width / 2, this.Height / 2 - height / 2, width, height, 0, angle);
        }

    }
}
