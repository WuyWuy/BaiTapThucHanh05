using System.IO;

namespace Bai11
{
    public partial class Form1 : Form
    {
        Color penColor = Color.Black;
        bool isDrawing = false;
        Point startPoint, endPoint;

        Bitmap bm;

        public Form1()
        {
            InitializeComponent();
            radSolid.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bm = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bm;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                penColor = cd.Color;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            isDrawing = false;
            endPoint = e.Location;

            using (Graphics g = Graphics.FromImage(bm))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int width;
                if (!int.TryParse(txtWidth.Text, out width) || width <= 0)
                {
                    width = 1; txtWidth.Text = "1";
                }

                Pen p = new Pen(penColor, width);

                if (radLine.Checked)
                {
                    g.DrawLine(p, startPoint, endPoint);
                }
                else
                {
                    Rectangle rect = new Rectangle(
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Abs(startPoint.X - endPoint.X),
                        Math.Abs(startPoint.Y - endPoint.Y)
                    );

                    Brush br = CreateBrush(rect);

                    if (radRectangle.Checked)
                        g.FillRectangle(br, rect);
                    else if (radEllipse.Checked)
                        g.FillEllipse(br, rect);
                }
            }

            picCanvas.Refresh();
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private Brush CreateBrush(Rectangle rect)
        {
            if (radSolid.Checked)
            {
                return new SolidBrush(Color.Green);
            }

            if (radHatch.Checked)
            {
                return new System.Drawing.Drawing2D.HatchBrush(
                    System.Drawing.Drawing2D.HatchStyle.Horizontal,
                    Color.Blue,
                    Color.Green
                );
            }

            if (radTexture.Checked)
            {
                string assetPath = Path.Combine(Application.StartupPath, "Assets", "texture.png");

                Bitmap tex = new Bitmap(assetPath);
                return new System.Drawing.TextureBrush(tex);
            }
            if (radLinearGradient.Checked)
            {
                return new System.Drawing.Drawing2D.LinearGradientBrush(
                    rect,
                    Color.Green,
                    Color.Red,
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical
                );
            }

            return new SolidBrush(Color.Green);
        }

        private void radSolid_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
