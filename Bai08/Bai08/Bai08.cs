namespace Bai08
{
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timer1.Tick += (s, e) => this.Invalidate();
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;
            int radius = Math.Min(cx, cy) - 20;

            using (Pen penWhite = new Pen(Color.White, 2))
            {
                g.DrawEllipse(penWhite, cx - radius, cy - radius, radius * 2, radius * 2);

                for (int i = 0; i < 60; i++)
                {
                    double ang = i * Math.PI / 30; 
                    int rSmall = radius - 10;

                    int x = cx + (int)(rSmall * Math.Cos(ang - Math.PI / 2));
                    int y = cy + (int)(rSmall * Math.Sin(ang - Math.PI / 2));

                    if (i % 5 == 0)
                        g.FillEllipse(Brushes.White, x - 6, y - 6, 12, 12); 
                    else
                        g.FillEllipse(Brushes.White, x - 3, y - 3, 6, 6); 
                }

                DateTime t = DateTime.Now;

                double secAng = (Math.PI / 30) * t.Second;
                double minAng = (Math.PI / 30) * t.Minute + secAng / 60;
                double hourAng = (Math.PI / 6) * (t.Hour % 12) + minAng / 12;

                DrawHand(g, cx, cy, radius * 0.5f, hourAng, 6);
                DrawHand(g, cx, cy, radius * 0.75f, minAng, 4);
                DrawHand(g, cx, cy, radius * 0.85f, secAng, 2);
            }
        }

        private void DrawHand(Graphics g, int cx, int cy, float len, double angle, int width)
        {
            using (Pen p = new Pen(Color.White, width))
            {
                int x = cx + (int)(len * Math.Cos(angle - Math.PI / 2));
                int y = cy + (int)(len * Math.Sin(angle - Math.PI / 2));
                g.DrawLine(p, cx, cy, x, y);
            }
        }
    }

}
